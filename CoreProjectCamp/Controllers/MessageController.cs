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

namespace CoreProjectCamp.Controllers
{
    public class MessageController : Controller
    {
     
        private readonly UserManager<AppUser> _userManager;
        IAuthorService _authorService;
        IMessage2Service _message2Service;

        public MessageController(UserManager<AppUser> userManager, IAuthorService authorService, IMessage2Service message2Service)
        {
            _userManager = userManager;
            _authorService = authorService;
            _message2Service = message2Service;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> InboxMessages()
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var author = _authorService.FindByEmail(user.Email);
            var values = _message2Service.GetInboxMessageByAuthor(author.AuthorID, null,null);

            return View(values);
        }
        public IActionResult MessageDetails(int id)
        {
            var messageValues = _message2Service.GetByIdWAuthor(id);
            return View(messageValues);
        }
    }
}
