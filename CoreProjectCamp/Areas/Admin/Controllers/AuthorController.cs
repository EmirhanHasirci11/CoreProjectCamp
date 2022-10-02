using CoreProjectCamp.Areas.Admin.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class AuthorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AuthorList()
        {
            var JsonAuthors = JsonConvert.SerializeObject(Authors);
            return Json(JsonAuthors);
        }
        public IActionResult GetAuthorByID(int AuthorId)
        {
            var findAuthor = Authors.FirstOrDefault(x => x.Id == AuthorId);
            var jsonAuthors = JsonConvert.SerializeObject(findAuthor);
            return Json(jsonAuthors);
        }
        [HttpPost]
        public IActionResult AddAuthor(AuthorModel w)
        {
            Authors.Add(w);
            var jsonAuthors = JsonConvert.SerializeObject(w);
            return Json(jsonAuthors);
        }
        [HttpPost]
        public IActionResult DeleteAuthor(int id)
        {
            var Author = Authors.FirstOrDefault(x => x.Id == id);
            Authors.Remove(Author);
            return Json(Author);
            
        }
        public IActionResult UpdateAuthor(AuthorModel AuthorModel)
        {
            var Author = Authors.FirstOrDefault(x => x.Id == AuthorModel.Id);
            Author.Name = AuthorModel.Name;
            var jsonAuthor = JsonConvert.SerializeObject(AuthorModel);
            return Json(jsonAuthor);
        }
        public static List<AuthorModel> Authors = new List<AuthorModel>
        {
            new AuthorModel
            {
                Id=1,
                Name="Emirhan"
            },
            new AuthorModel
            {
                Id=2,
                Name="Ahmet"
            },
            new AuthorModel
            {
                Id=3,
                Name="Veri"
            },
            new AuthorModel
            {
                Id=4,
                Name="Aynen"
            }
        };
    }

}
