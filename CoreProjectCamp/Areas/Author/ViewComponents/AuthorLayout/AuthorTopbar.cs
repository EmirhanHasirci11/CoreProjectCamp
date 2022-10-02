using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Areas.Author.ViewComponents.AuthorLayout
{
    public class AuthorTopbar:ViewComponent
    {
        IAuthorService _authorService;

        public AuthorTopbar(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var author = _authorService.GetById(1);
            return View();
        }
    }
}
