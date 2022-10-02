using ClosedXML.Excel;
using CoreProjectCamp.Areas.Admin.Models;
using DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CoreProjectCamp.Areas.Admin.Controllers
{
    [Area("Admin")]
    [AllowAnonymous]
    public class BlogController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ExportDynamicExcelBlogList()
        {
            using (var workbook = new XLWorkbook())
            {
                var worksheet = workbook.Worksheets.Add("Blog Listesi");
                worksheet.Cell(1, 1).Value = "Blog ID";
                worksheet.Cell(1, 2).Value = "Blog Adı";

                int BloRowCount = 2;
                foreach (var item in GetBlogTitleList())
                {
                    worksheet.Cell(BloRowCount, 1).Value = item.ID;
                    worksheet.Cell(BloRowCount, 2).Value = item.BlogName;
                    BloRowCount++;
                }

                using (var stream = new MemoryStream())
                {
                    workbook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content, "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                        "Example.xlsx");
                }
            }
        }
        public List<BlogModel> GetBlogTitleList()
        {
            List<BlogModel> blogModels = new List<BlogModel>();
            using (var c = new Context())
            {
                blogModels = c.Blogs.Select(x => new BlogModel
                {
                    ID = x.BlogID,
                    BlogName = x.BlogTitle
                }).ToList();
                return blogModels;
            }
        }
        public IActionResult BlogTitleListExcel()
        {
            return View();
        }

    }
}
