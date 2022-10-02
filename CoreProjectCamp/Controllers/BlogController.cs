using BusinessLayer.Abstract;
using BusinessLayer.Concrete;
using BusinessLayer.ValidationRules;
using DataAccessLayer.Concrete.EntityFramework;
using EntityLayer.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CoreProjectCamp.Controllers
{
    public class BlogController : Controller
    {
        private readonly IAuthorService _authorService;
        private readonly ICategoryService _categoryService;
        private readonly IBlogService _blogService;
        private readonly UserManager<AppUser> _userManager;

        public BlogController(IAuthorService authorService, ICategoryService categoryService, IBlogService blogService, UserManager<AppUser> userManager)
        {
            _authorService = authorService;
            _categoryService = categoryService;
            _blogService = blogService;
            _userManager = userManager;
        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            var blogs = _blogService.GetBlogListWithCategory();
            return View(blogs);
        }
        [AllowAnonymous]
        public IActionResult BlogDetails(int id)
        {
            ViewBag.blogID = id;
            var blog = _blogService.GetById(id);
            return View(blog);
        }
        [AllowAnonymous]
        public async Task<IActionResult> BlogListByAuthor()
        {
            //todo yanlış yer
            List<SelectListItem> values = (from x in _blogService.GetBlogListWithCategory()
                                           select new SelectListItem
                                           {
                                               Value = x.CategoryID.ToString(),
                                               Text = x.Category.CategoryName
                                           }).ToList();
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var author = _authorService.FindByEmail(user.Email);
            ViewBag.category = values;

            var blogs = _blogService.AuthorGetBloglistWithCategory(author.AuthorID);
            return View(blogs);
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult AddBlog()
        {
            List<SelectListItem> categories = (from x in _categoryService.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.category = categories;
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<IActionResult> AddBlog(Blog p)
        {

            List<SelectListItem> categories = (from x in _categoryService.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.category = categories;
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            var author = _authorService.FindByEmail(user.Email);
            BlogValidator validationRules = new BlogValidator();
            ValidationResult result = validationRules.Validate(p);
            if (result.IsValid)
            {
                p.BlogCreateDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                p.AuthorID = author.AuthorID;
                p.BlogStatus = true;
                _blogService.TAdd(p);
                return RedirectToAction("BlogListByAuthor", "Blog");
            }
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();

        }
        [AllowAnonymous]
        public IActionResult ChangeStatusFalse(int id)
        {
            _blogService.AuthorBlogStatusToFalse(id);
            return RedirectToAction("BlogListByAuthor", "Blog");
        }
        [AllowAnonymous]
        public IActionResult ChangeStatusTrue(int id)
        {
            _blogService.AuthorBlogStatusToTrue(id);
            return RedirectToAction("BlogListByAuthor", "Blog");
        }
        [AllowAnonymous]
        [HttpGet]
        public IActionResult EditBlog(int id)
        {
            List<SelectListItem> categories = (from x in _categoryService.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.category = categories;
            var blog = _blogService.GetById(id);
            return View(blog);
        }
        [AllowAnonymous]
        [HttpPost]
        public IActionResult EditBlog(Blog p)
        {
            List<SelectListItem> categories = (from x in _categoryService.GetList()
                                               select new SelectListItem
                                               {
                                                   Text = x.CategoryName,
                                                   Value = x.CategoryID.ToString()
                                               }).ToList();
            ViewBag.category = categories;
            var unchangedBlog = _blogService.GetById(p.BlogID);
            p.BlogCreateDate = unchangedBlog.BlogCreateDate;
            p.AuthorID = unchangedBlog.AuthorID;
            p.BlogStatus = true;
            _blogService.TUpdate(p);
            return RedirectToAction("BlogListByAuthor", "Blog");
        }
    }
}
