using BusinessLayer.Concrete;
using CoreProjectCamp.Areas.Author.Models.Message;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Areas.Author.Controllers
{
    [Area("Author")]
    [AllowAnonymous]
    public class MessageController : Controller
    {
        #region Assignments
        AuthorManager arm = new AuthorManager(new EFAuthorDal());
        Message2Manager mm = new Message2Manager(new EFMessage2Dal());
        private readonly UserManager<AppUser> _userManager;
        public MessageController(UserManager<AppUser> userManager)
        {
            _userManager = userManager;
        }
        #endregion
        #region utilities

        [HttpGet]
        public IActionResult NewMessage(int? id)
        {
            if (id == null)
            {

                return View();
            }
            else
            {
                ViewBag.receiver = id;
                return View();
            }
        }
        [HttpPost]
        public IActionResult NewMessage(Message2 p)
        {
            //todo sender kısmı authentication'a bağlanacak
            p.MessageStatus = false;
            p.Sender = 1;
            p.IsDrafted=false;
            p.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            mm.TAdd(p);
            return RedirectToAction("Inbox");
        }
        [HttpGet]
        public IActionResult Reply(int id)
        {
            //todo spagetti gaming
            BaseClass bm = new BaseClass();
            MessageReply replyModel = new MessageReply();
            Message2 messageModel = new Message2();
            var message = mm.GetByIdWAuthor(id);
            replyModel.MessageDetails = message.MessageDetails;
            replyModel.MessageDate = DateTime.Parse(message.MessageDate.ToString());
            replyModel.MessageSubject = message.Subject;
            replyModel.SenderMail = message.SenderUser.AuthorMail;
            replyModel.SenderNameSurname = message.SenderUser.AuthorName + " " + message.SenderUser.AuthorSurname;
            replyModel.SenderImage = message.SenderUser.AuthorImage;
            messageModel.Subject = message.Subject;
            bm.Mmessage = messageModel;

            bm.Mreply = replyModel;
            ViewBag.receiver = message.Receiver;
            return View(bm);
        }
        [HttpPost]
        public IActionResult Reply(BaseClass p)
        {
            Message2 message = new Message2();
            message.Receiver = p.Mmessage.Receiver;
            message.MessageDetails = p.Mmessage.MessageDetails;
            message.Subject = p.Mmessage.Subject;
            message.Sender = 1;
            message.MessageStatus = false;
            message.MessageDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            mm.TAdd(message);
            return RedirectToAction("Inbox");
        }

        public IActionResult SetAsImportant(int id, string location)
        {
            mm.SetAsImportant(id);
            return RedirectToAction(location);
        }
        public IActionResult RemoveImportant(int id)
        {
            mm.RemoveImportant(id);
            return RedirectToAction("ImportantBox");
        }
        public IActionResult MessageChangeStatus(int id, bool status)
        {
            mm.SetMessageStatus(id, status);
            return RedirectToAction("Inbox");
        }
        public IActionResult SendToTrashReceiver(int id)
        {
            mm.SendToTrashReceiver(id);
            return RedirectToAction("Inbox");
        }
        public IActionResult SendToTrashSender(int id)
        {

            mm.SendToTrashSender(id);
            return RedirectToAction("Sendbox");
        }
        public IActionResult RecoverFromTrashBoxReceiver(int id)
        {
            mm.RecoverFromTrashboxReceiver(id);
            return RedirectToAction("Trashbox");
        }
        public IActionResult RecoverFromTrashBoxSender(int id)
        {
            mm.RecoverFromTrashboxSender(id);
            return RedirectToAction("Trashbox");
        }
        public IActionResult ConfirmDeleteForReceiver(int id)
        {
            mm.ConfirmDeleteForReceiver(id);
            return RedirectToAction("Trashbox");
        }
        public IActionResult ConfirmDeleteForSender(int id) 
        {
            mm.ConfirmDeleteForSender(id);
            return RedirectToAction("Trashbox");
        }
        #endregion
        #region Inbox
        public async Task<IActionResult> Inbox(bool? status)
        {
            //todo deneme yapmak için devre dışı bırakılmıştır düzeltilecek
            //var user = await _userManager.FindByNameAsync(User.Identity.Name);
            //var author = arm.FindByEmail(user.Email);
            var author = arm.GetById(1);
            if (status == null)
            {
                ViewBag.label = "Gelen Kutusu";
            }
            else
            {
                ViewBag.label = status == true ? "Okunan Mesajlar" : "Okunmamış Mesajlar";
            }
            var messages = mm.GetInboxMessageByAuthor(author.AuthorID, null, status);
            ViewBag.count = messages.Count();

            ViewBag.falseCount = mm.GetInboxMessageByAuthor(author.AuthorID, null, false).Count();
            ViewBag.trueCount = mm.GetInboxMessageByAuthor(author.AuthorID, null, true).Count();
            return View(messages);
        }
        public IActionResult MessageDetails(int id)
        {

            var message = mm.GetByIdWAuthor(id);
            mm.SetMessageStatus(id, true);
            return View(message);
        }
        #endregion
        #region sendbox
        public IActionResult Sendbox()
        {
            var author = arm.GetById(1);
            var messages = mm.GetSendboxMessageByAuthor(author.AuthorID, null);
            ViewBag.count = messages.Count();
            return View(messages);
        }
        public IActionResult SendboxMessageDetails(int id)
        {
            var message = mm.GetByIdWReceiverAuthor(id);
            return View(message);
        }
        #endregion
        #region Importants
        public IActionResult ImportantBox()
        {
            TempData["UserID"] = 1;
            var messages = mm.GetImportantBoxByAuthorForReceiver(1);
            var messages2 = mm.GetImportantBoxByAuthorForSender(1);
            var allMessage = messages.Union(messages2);
            ViewBag.count = allMessage.Count();
            return View(allMessage);
        }
        #endregion
        #region Draft
        public IActionResult DraftBox()
        {
            var messages = mm.GetDraftBoxByAuthor(1);
            ViewBag.count = messages.Count();
            return View(messages);
        }
        #endregion
        #region Trash
        public IActionResult TrashBox()
        {
            TempData["UserID"] = 1;
            var messages = mm.GetTrashBoxByAuthorForSender(1);
            var messages2 = mm.GetTrashBoxByAuthorForReceiver(1);            
            var allMessage = messages.Union(messages2);
            ViewBag.count = allMessage.Count();
            
            return View(allMessage);
        }
        #endregion
        #region
        [HttpGet]
        public IActionResult EditDraft(int id)
        {
            var message = mm.GetByIdWAuthor(id);
            return View(message);
        }        
        #endregion
    }
}
