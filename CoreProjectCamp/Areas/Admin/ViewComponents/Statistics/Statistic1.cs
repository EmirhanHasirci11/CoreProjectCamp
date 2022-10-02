using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CoreProjectCamp.Areas.Admin.ViewComponents.Statistics
{
    public class Statistic1:ViewComponent
    {
        public IViewComponentResult Invoke()
        {            
            Context c = new Context();
            ViewBag.totalBlogCount = c.Blogs.Count();
            ViewBag.totalContactCount = c.Contacts.Count();
            ViewBag.totalCommentCount = c.Comments.Count();
            string apiKey = "Your API Key here";
            string connectionString = "https://api.openweathermap.org/data/2.5/weather?q=bozüyük&mode=xml&lang=tr&units=metric&appid=" + apiKey;
            XDocument document = XDocument.Load(connectionString);
            ViewBag.temperature = document.Descendants("temperature").ElementAt(0).Attribute("value").Value;
            return View();
        }
    }
}
