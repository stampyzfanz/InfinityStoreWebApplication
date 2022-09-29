using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using InfinityWebApplication.Services;

namespace InfinityWebApplication.Controllers
{
    [Produces("application/json")]
    [Route("api/LocateIP")]
    public class LocateIPController : Controller
    {
        private readonly ILocationService _locationService;
        private readonly ILogger<LocateIPController> _logger;

        public LocateIPController(ILocationService locationService, ILogger<LocateIPController> logger)
        {
            _locationService = locationService;
            _logger = logger;
        }

        // GET: api/LocateIP
        [HttpGet]
        public async Task<LocationData> Get()
        {
            string iPAddress = HttpContext.Connection.RemoteIpAddress!.ToString();
            _logger.LogInformation("Get /api/LocateIP called. IP is " + iPAddress);
            LocationData locationData = await _locationService.getLocationData(iPAddress);
            return locationData;
        }
    }
}