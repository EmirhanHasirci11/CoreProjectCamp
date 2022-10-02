using BusinessLayer.Concrete;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Areas.Author.ViewComponents.Message
{
    public class MessageSidebar:ViewComponent
    {
        AuthorManager arm = new AuthorManager(new EFAuthorDal());
        Message2Manager mm = new Message2Manager(new EFMessage2Dal());
        private readonly UserManager<AppUser> _userManager;

        public MessageSidebar(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            //var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //var author = arm.FindByEmail(user.Email);
            var author = arm.GetById(1);                     
            ViewBag.count = mm.GetInboxMessageByAuthor(author.AuthorID, null,null).Count();
            ViewBag.count2 = mm.GetSendboxMessageByAuthor(author.AuthorID, null).Count();
            ViewBag.count3 = mm.GetImportantBoxByAuthorForSender(author.AuthorID).Count() + mm.GetImportantBoxByAuthorForReceiver(author.AuthorID).Count();
            ViewBag.count4 = mm.GetDraftBoxByAuthor(author.AuthorID).Count();
            ViewBag.count5 = mm.GetTrashBoxByAuthorForReceiver(author.AuthorID).Count() + mm.GetTrashBoxByAuthorForSender(author.AuthorID).Count();
            return View();
        }
    }
}
