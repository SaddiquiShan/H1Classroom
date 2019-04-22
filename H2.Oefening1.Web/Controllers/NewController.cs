using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace H2.Oefening1.Web.Controllers
{
    public class NewController : Controller
    {
        public IActionResult Index()
        {

            return Content
                ("<ul><li><a href='https://www.rottentomatoes.com/'>Rotten Tomatoes</a></li>" +
                "<li><a href='https://worldofwarcraft.com/en-us/'>World of Warcraft</a></li>" +
                "<li><a href='https://darksiders.com/'>Darksiders</a></li>" +
                "<li><a href='new/whatsmyname'>Whats my name?</a></li></ul>", "text/html");
        }

        public IActionResult Whatsmyname()
        {
            return Content("Shan Saddiqui", "text/plain");
        }

    }
}