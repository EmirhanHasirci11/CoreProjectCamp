using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Areas.Author.ViewComponents.AuthorLayout
{
    public class TopbarMailNotifications:ViewComponent
    {
        IAuthorService _authorService;
        IMessage2Service _message2Service;

        public TopbarMailNotifications(IAuthorService authorService, IMessage2Service message2Service)
        {
            _authorService = authorService;
            _message2Service = message2Service;
        }

        public IViewComponentResult Invoke()
        {
            var author = _authorService.GetById(1);
            var messages = _message2Service.GetInboxMessageByAuthor(author.AuthorID, 3, null);
            ViewBag.message = _message2Service.GetInboxMessageByAuthor(author.AuthorID, null, false).Count();
            return View(messages);
        }
    }
}
