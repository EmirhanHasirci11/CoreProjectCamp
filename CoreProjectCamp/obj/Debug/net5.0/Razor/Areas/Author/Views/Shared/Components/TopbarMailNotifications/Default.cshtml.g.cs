#pragma checksum "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Shared\Components\TopbarMailNotifications\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e48d3f524f38e0ffafba15b53f6145ebf865d311"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Author_Views_Shared_Components_TopbarMailNotifications_Default), @"mvc.1.0.view", @"/Areas/Author/Views/Shared/Components/TopbarMailNotifications/Default.cshtml")]
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
#line 1 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\_ViewImports.cshtml"
using CoreProjectCamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\_ViewImports.cshtml"
using CoreProjectCamp.Areas.Author.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e48d3f524f38e0ffafba15b53f6145ebf865d311", @"/Areas/Author/Views/Shared/Components/TopbarMailNotifications/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41a961df6978e5bbb3af4877a94e8ff377d89b6", @"/Areas/Author/Views/_ViewImports.cshtml")]
    public class Areas_Author_Views_Shared_Components_TopbarMailNotifications_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Message2>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Shared\Components\TopbarMailNotifications\Default.cshtml"
  
    string time = "";
    DateTime now = DateTime.Now;

#line default
#line hidden
#nullable disable
            WriteLiteral("<li class=\"dropdown\">\r\n    <a class=\"dropdown-toggle count-info\" data-toggle=\"dropdown\" href=\"#\">\r\n        <i class=\"fa fa-envelope\"></i>  <span class=\"label label-warning\">");
#nullable restore
#line 8 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Shared\Components\TopbarMailNotifications\Default.cshtml"
                                                                     Write(ViewBag.message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </a>\r\n    <ul class=\"dropdown-menu dropdown-messages\">\r\n");
#nullable restore
#line 11 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Shared\Components\TopbarMailNotifications\Default.cshtml"
         foreach (var item in Model)
        {
            TimeSpan calculatedTime = now.Subtract(item.MessageDate);

            if (calculatedTime.Days == 0)
            {
                if (calculatedTime.Minutes == 0 && calculatedTime.Hours == 0)
                {
                    time = "Şimdi";
                }
                else if (calculatedTime.Minutes > 0 && calculatedTime.Hours == 0)
                {
                    time = calculatedTime.Minutes + " Dakika önce";
                }
                else
                {
                    time = calculatedTime.Hours + " Saat " + calculatedTime.Minutes + " Dakika önce";
                }
            }
            else
            {
                if (calculatedTime.Hours == 0)
                {
                    time = calculatedTime.Days + " Gün önce";
                }
                else
                {
                    time = calculatedTime.Days + " Gün " + calculatedTime.Hours + " Saat önce";
                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <div class=\"dropdown-messages-box\">\r\n                    <a class=\"dropdown-item float-left\"");
            BeginWriteAttribute("href", " href=\"", 1555, "\"", 1608, 2);
            WriteAttributeValue("", 1562, "/Author/Message/MessageDetails/", 1562, 31, true);
#nullable restore
#line 43 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Shared\Components\TopbarMailNotifications\Default.cshtml"
WriteAttributeValue("", 1593, item.MessageID, 1593, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <img alt=\"image\" class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 1675, "\"", 1709, 1);
#nullable restore
#line 44 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Shared\Components\TopbarMailNotifications\Default.cshtml"
WriteAttributeValue("", 1681, item.SenderUser.AuthorImage, 1681, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    </a>\r\n                    <div class=\"media-body\">\r\n                        <small class=\"float-right\"></small>\r\n                        <a class=\"small\" style=\"color:black\"");
            BeginWriteAttribute("href", " href=\"", 1906, "\"", 1959, 2);
            WriteAttributeValue("", 1913, "/Author/Message/MessageDetails/", 1913, 31, true);
#nullable restore
#line 48 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Shared\Components\TopbarMailNotifications\Default.cshtml"
WriteAttributeValue("", 1944, item.MessageID, 1944, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><strong>");
#nullable restore
#line 48 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Shared\Components\TopbarMailNotifications\Default.cshtml"
                                                                                                                      Write(item.SenderUser.AuthorName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 48 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Shared\Components\TopbarMailNotifications\Default.cshtml"
                                                                                                                                                  Write(item.SenderUser.AuthorSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></a>\r\n                        <br />\r\n                        <strong>");
#nullable restore
#line 50 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Shared\Components\TopbarMailNotifications\Default.cshtml"
                           Write(item.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </strong>\r\n                        <br>\r\n                        <small class=\"text-muted\">");
#nullable restore
#line 52 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Shared\Components\TopbarMailNotifications\Default.cshtml"
                                             Write(time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small>\r\n                    </div>\r\n                </div>\r\n            </li>\r\n            <li class=\"dropdown-divider\"></li>\r\n");
#nullable restore
#line 57 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Shared\Components\TopbarMailNotifications\Default.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <li>
            <div class=""text-center link-block"">
                <a href=""/Author/Message/Inbox"" class=""dropdown-item"">
                    <i class=""fa fa-envelope""></i> <strong>Bütün mesajları görüntüle</strong>
                </a>
            </div>
        </li>
    </ul>
</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Message2>> Html { get; private set; }
    }
}
#pragma warning restore 1591