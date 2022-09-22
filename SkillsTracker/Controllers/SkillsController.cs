using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860
namespace SkillsTracker.Controllers
{
    public class SkillsController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        [Route("/skills/")]
        public IActionResult Index()
        {
            string html =
                "<h1>Skill Tracker</h1>" +
                "<h2>Coding Skills to Learn:</h2>" +
                "<ol>" +
                "<li>C#</li>" +
                "<li>JavaScript</li>" +
                "<li>CSS</li>" +
                "</ol>";
            return Content(html, "text/html");
        }
        [HttpGet]
        [Route("/skills/form/")]
        public IActionResult Form()
        {
            string html2 = "<form method='post' action='/skills/form/'>" +
                "<h3>Date:</h3>" +
                "<input type='date' name='date'>" +
                "<h3>C#</h3>" +
                "<select name='CSharp'>" +
                "<option value='learning basics'>Learning basics</option>" +
                "<option value='middle of the road'>Middle of the road</option>" +
                "<option value='top of the class'>Top of the class</option>" +
                "</select>" +
                "<h3>JavaScript</h3>" +
                "<select name='JavaScript'>" +
                "<option value='learning basics'>Learning basics</option>" +
                "<option value='middle of the road'>Middle of the road</option>" +
                "<option value='top of the class'>Top of the class</option>" +
                "</select>" +
                "<h3>CSS</h3>" +
                "<select name='CSS'>" +
                "<option value='learning basics'>Learning basics</option>" +
                "<option value='middle of the road'>Middle of the road</option>" +
                "<option value='top of the class'>Top of the class</option>" +
                "</select>" +
                "<br>" +
                "<input type='submit' value='submit' />" +
                "</form>";
            return Content(html2, "text/html");
        }
        [HttpPost]
        [Route("/skills/form/")]
        public IActionResult ReportOut(DateTime date, string CSharp, string JavaScript, string CSS)
        {
            string html3 = "<h1>" + date.ToString("yyyy-MM-dd") + "</h1>" +
                    "<ol>" +
                    "<li>C#: " + CSharp + "</li>" +
                    "<li>JavaScript: " + JavaScript + "</li>" +
                    "<li>CSS: " + CSS + "</li>" +
                    "</ol>";
            return Content(html3, "text/html");
        }
    }
}