let hasMapLoaded = false;
let user_coordinates = [145, -30];

mapboxgl.accessToken = 'pk.eyJ1IjoiaXhiaXhiYW0iLCJhIjoiY2wzY2NkeWU2MDJoNTNsb2t0YjdwbnVzciJ9.EWh6boEzzAIaLO6I5N6lRQ';

const map = new mapboxgl.Map({
    container: 'map',
    style: 'mapbox://styles/mapbox/streets-v11',
    zoom: 9,
    center: user_coordinates
});

fetch('/api/LocateIP').then(response => response.json())
    .then(data => {
        if (hasGeolocated === false) {
            user_coordinates = data.loc.split(',').map(parseFloat);
            map.jumpTo({
                center: [user_coordinates[1], user_coordinates[0]],
            });
            if (hasMapLoaded) {
                updateDistances();
            }
        }
    });

// Add geolocate control to the map.
map.addControl(
    new mapboxgl.GeolocateControl({
        positionOptions: {
            enableHighAccuracy: true
        },
        trackUserLocation: false,
        showUserHeading: false
    })
);

const storeLocationPromise = fetch('/api/StoreLocations').then(response => response.json());
let stores = [];

map.addControl(new mapboxgl.NavigationControl());

let hasGeolocated = false;
navigator.geolocation.getCurrentPosition(position => {
    hasGeolocated = true;
    user_coordinates = [position.coords.longitude, position.coords.latitude];
    map.jumpTo({
        center: user_coordinates,
        essential: true
    });
    if (hasMapLoaded) {
        updateDistances();
    }
});

storeLocationPromise.then(buildLocationList);

map.on("load", () => {
    map.loadImage(
        '/images/map-logo.png',
        async (error, image) => {
            if (error) throw error;

            // Add the image to the map style.
            map.addImage('logo', image);

            stores = await storeLocationPromise;

            stores = stores.map(value => {
                return {
                    "properties": {
                        ...value,
                        "icon": "logo",
                        "distance": getDistance(user_coordinates, [value.longitude, value.latitude])
                    },
                    "geometry": {
                        "type": "Point",
                        "coordinates": [value.longitude, value.latitude]
                    }
                }
            });

            stores.sort((a, b) => a.properties.distance - b.properties.distance);

            map.addSource('places', {
                'type': 'geojson',
                'data': {
                    'type': 'FeatureCollection',
                    "features": stores
                }
            });
            // Add a layer showing the places.
            map.addLayer({
                'id': 'places',
                'type': 'symbol',
                'source': 'places',
                'layout': {
                    'icon-image': 'logo',
                    'icon-allow-overlap': true,
                    'icon-size': 0.05
                }
            });

            // When a click event occurs on a feature in the places layer, open a popup at the
            // location of the feature, with description HTML from its properties.
            map.on('click', 'places', e => {
                popupStore(e.features[0]);

                const activeItem = document.getElementsByClassName('active');
                if (activeItem[0]) {
                    activeItem[0].classList.remove('active');
                }
                const listing = document.getElementById(
                    `listing-${e.features[0].properties.storeId}`
                );
                listing.classList.add('active');

                listing.scrollIntoView({ "behavior": "smooth" });
            });

            // Change the cursor to a pointer when the mouse is over the places layer.
            map.on('mouseenter', 'places', () => {
                map.getCanvas().style.cursor = 'pointer';
            });

            // Change it back to a pointer when it leaves.
            map.on('mouseleave', 'places', () => {
                map.getCanvas().style.cursor = '';
            });

            buildLocationList();
            hasMapLoaded = true;
        });
});

function popupStore(storeFeature) {
    const coordinates = storeFeature.geometry.coordinates.slice();
    const props = storeFeature.properties;
    const storeDetails = `<h3>${props.title}</h3><h6>${buildStoreDetails(props)}</h6>`;

    // Remove existing popups.
    const popups = document.getElementsByClassName("mapboxgl-popup");
    for (let popup of popups) {
        popup.remove();
    }

    // Create popup.
    new mapboxgl.Popup()
        .setLngLat(coordinates)
        .setHTML(storeDetails)
        .addTo(map);
}

function buildStoreDetails(props) {
    return `${props.address}<br>${props.suburb} ${props.state} ${props.postcode}`;
}

// Returns distance in km
function getDistance(coord1, coord2) {
    // https://stackoverflow.com/questions/18883601/function-to-calculate-distance-between-two-coordinates
    // Note to sir: some variables are renamed for intrinsic documentation, but not all are. Not my code anyway.
    function degreeToRadian(degree) {
        return degree * (Math.PI / 180)
    }

    // Radius of the earth in km
    const radius = 6371.009;
    const dLat = degreeToRadian(coord1[1] - coord2[1]);
    const dLon = degreeToRadian(coord1[0] - coord2[0]);
    const angle =
        Math.sin(dLat / 2) * Math.sin(dLat / 2) +
        Math.cos(degreeToRadian(coord1[1])) * Math.cos(degreeToRadian(coord2[1])) *
        Math.sin(dLon / 2) * Math.sin(dLon / 2);
    const c = 2 * Math.atan2(Math.sqrt(angle), Math.sqrt(1 - angle));
    const distance = radius * c;
    return distance;
}

function updateDistances() {
    for (const store of stores) {
        store.properties.distance = getDistance(user_coordinates,
            store.geometry.coordinates);
    }

    // Sort the stores by distance
    stores.sort((a, b) => a.properties.distance - b.properties.distance);

    buildLocationList();

    map.getSource('places').setData({
        'type': 'FeatureCollection',
        "features": stores
    });
}

function flyToStore(currentFeature) {
    map.flyTo({
        center: currentFeature.geometry.coordinates,
        zoom: 15
    });
}

function buildLocationList() {
    const listings = document.getElementById('listings');
    // Remove all children
    listings.innerHTML = "";
    for (const store of stores) {
        // Add a new listing section to the sidebar.
        const listing = listings.appendChild(document.createElement('div'));
        // Assign a unique `id` to the listing.
        const props = store.properties;
        listing.id = `listing-${props.storeId}`;
        // Assign the `item` class to each listing for styling.
        listing.className = 'item';

        // Add the link to the individual listing created above.
        const link = listing.appendChild(document.createElement('a'));
        link.href = '#';
        link.className = 'title';
        link.id = `link-${store.properties.storeId}`;
        link.innerHTML = `${store.properties.title}`;

        // Add details to the individual listing.
        const details = listing.appendChild(document.createElement('div'));
        details.innerHTML = buildStoreDetails(props);
        if (store.properties.distance) {
            const roundedDistance = Math.round(store.properties.distance * 100) / 100;
            details.innerHTML += `<div><strong>${roundedDistance}km</strong></div>`;
        }

        link.addEventListener('click', function () {
            for (const feature of stores) {
                if (this.id === `link-${feature.properties.storeId}`) {
                    flyToStore(feature);
                    popupStore(feature);
                }
            }
            const activeItem = document.getElementsByClassName('active');
            if (activeItem[0]) {
                activeItem[0].classList.remove('active');
            }
            this.parentNode.classList.add('active');
        });
        details.innerHTML += "<a class=\"title\" target=\"_blank\" href=\"https://www.google.com/maps/dir/Current+Location/" +
            props.latitude + "," + props.longitude + "\">Directions</a>";
    }
}
