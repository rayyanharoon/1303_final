using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReferencesController : ControllerBase
    {
        private static readonly IEnumerable<References> _references = new List<References>()
        {
            new References() { ReferenceId = 1, Description = "HTML Browser Support",
                Urls = new List<string>() { "https://www.w3schools.com/tags/ref_html_browsersupport.asp"} },
            new References() { ReferenceId = 2, Description = "HTML Status Messages",
                Urls = new List<string>() { "https://www.w3schools.com/tags/ref_httpmessages.asp"} },
            new References() { ReferenceId = 3, Description = "HTML Methods",
                Urls = new List<string>() { "https://www.w3schools.com/tags/ref_httpmethods.asp"} },
        };
        public ReferencesController()
        {

        }
        [HttpGet]
        public ActionResult<IEnumerable<References>> Get()
        {
            return new ActionResult<IEnumerable<References>>(_references);
        }
        [HttpGet("[id}")]
        public ActionResult<string> Get(int id)
        {
            if (id == 1)
                return "value 1 is here for you";
            else
                return "value!";
        }
    }
}
