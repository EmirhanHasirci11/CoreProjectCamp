#pragma checksum "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b3db042d59fae1ca231af7303da79196acb08d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_BlogListByAuthor), @"mvc.1.0.view", @"/Views/Blog/BlogListByAuthor.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\_ViewImports.cshtml"
using CoreProjectCamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\_ViewImports.cshtml"
using CoreProjectCamp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b3db042d59fae1ca231af7303da79196acb08d7", @"/Views/Blog/BlogListByAuthor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb32bb38a03635894266d8c6ff858af981ab78c", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_BlogListByAuthor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Blog>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml"
  
    ViewData["Title"] = "BlogListByAuthor";
    Layout = "~/Views/Shared/_Author_Layout_.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b3db042d59fae1ca231af7303da79196acb08d73651", async() => {
                WriteLiteral("\r\n    <title>Yazar blokları</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b3db042d59fae1ca231af7303da79196acb08d74654", async() => {
                WriteLiteral(@"
    <table class=""table table-light"">
        <thead>
            <tr>
                <th>#</th>
                <th>Başlık</th>
                <th>Oluşturulma tarihi</th>
                <th>Kategori</th>
                <th>Blog Durumu</th>
                <th style=""text-align:center"" colspan=""2"">Araçlar</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 24 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml"
             foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml"
               Write(item.BlogID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml"
               Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml"
                Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                <td><span class=\"badge\"");
                BeginWriteAttribute("style", " style=\"", 919, "\"", 1000, 3);
                WriteAttributeValue("", 927, "background-color:", 927, 17, true);
#nullable restore
#line 30 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml"
WriteAttributeValue("", 944, item.Category.CategoryColor, 944, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 972, ";min-width:70px;color:white;", 972, 28, true);
                EndWriteAttribute();
                WriteLiteral(">");
#nullable restore
#line 30 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml"
                                                                                                                     Write(item.Category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span></td>\r\n                <td> ");
#nullable restore
#line 31 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml"
                Write(Html.Raw(item.BlogStatus == true ? "<span class='badge badge-success'>Aktif</span>" : "<span class='badge badge-danger'>Pasif</span>"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
#nullable restore
#line 32 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml"
                 switch (item.BlogStatus)
                {
                    case true:

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>\r\n                            <a id=\"DeleteBtnPasif\" onclick=\"return confirm(\'Blog yazısını Pasif hale getirmek istediğinize emin misiniz ?\');\" class=\"btn btn-danger btn-sm\"");
                BeginWriteAttribute("href", " href=\"", 1501, "\"", 1544, 2);
                WriteAttributeValue("", 1508, "/Blog/ChangeStatusFalse/", 1508, 24, true);
#nullable restore
#line 36 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml"
WriteAttributeValue("", 1532, item.BlogID, 1532, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <i class=\"fas fa-trash\">\r\n                                </i>\r\n                                Pasif Yap\r\n                            </a>\r\n                        </td>\r\n");
#nullable restore
#line 42 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml"
                        break;
                    case false:

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <td>\r\n                            <a id=\"DeleteBtnActive\" onclick=\"return confirm(\'Blog yazısını Aktif hale getirmek istediğinize emin misiniz ?\');\" class=\"btn btn-success btn-sm\"");
                BeginWriteAttribute("href", " href=\"", 2020, "\"", 2062, 2);
                WriteAttributeValue("", 2027, "/Blog/ChangeStatusTrue/", 2027, 23, true);
#nullable restore
#line 45 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml"
WriteAttributeValue("", 2050, item.BlogID, 2050, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                                <i class=\"fas fa-check\">\r\n                                </i>\r\n                                Aktif Yap\r\n                            </a>\r\n                        </td>\r\n");
#nullable restore
#line 51 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml"
                        break;
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                <td><a");
                BeginWriteAttribute("href", " href=\"", 2343, "\"", 2377, 2);
                WriteAttributeValue("", 2350, "/Blog/EditBlog/", 2350, 15, true);
#nullable restore
#line 53 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml"
WriteAttributeValue("", 2365, item.BlogID, 2365, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-warning btn-sm\">Güncelle</a> </td>\r\n            </tr>\r\n");
#nullable restore
#line 55 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Blog\BlogListByAuthor.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n    <br />\r\n    <a href=\"/Blog/AddBlog\" class=\"btn btn-primary\">Yeni blog girişi</a>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591