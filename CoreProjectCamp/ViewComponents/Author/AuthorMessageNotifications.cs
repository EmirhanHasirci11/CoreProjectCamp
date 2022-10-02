using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreProjectCamp.ViewComponents.AuthorMessageNotifications
{
    public class AuthorMessageNotifications:ViewComponent
    {
        private readonly UserManager<AppUser> _userManager;
        private readonly IAuthorService _authorService;
        private readonly IMessage2Service _message2Service;

        public AuthorMessageNotifications(UserManager<AppUser> userManager, IAuthorService authorService, IMessage2Service message2Service)
        {
            _userManager = userManager;
            _authorService = authorService;
            _message2Service = message2Service;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
           // var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //var author = arm.FindByEmail(user.Email);
            var author = _authorService.GetById(1);
            var messages = _message2Service.GetInboxMessageByAuthor(author.AuthorID, 3,null);
            return View(messages);
        }
    }
}
