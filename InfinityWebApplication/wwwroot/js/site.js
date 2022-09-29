"use strict";
/* 
The user documentation is technically implemented in this project by including 
an array of FaqEntry objects that describe questions and answers for components included on each page.
For example, if the map is present, code for the map would add instructions to the faq by
adding an object literal to the array below.
*/
// Note that in js const means that the entire array can't be reassigned, but it remains mutable
/**
 * @type {{question: String, answer: String, category: String}[]}
 */
const faq = [];
