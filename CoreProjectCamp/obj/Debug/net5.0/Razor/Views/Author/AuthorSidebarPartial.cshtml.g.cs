#pragma checksum "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Author\AuthorSidebarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8ca374aaef4402449f23dd3b828401116c4f54e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_AuthorSidebarPartial), @"mvc.1.0.view", @"/Views/Author/AuthorSidebarPartial.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a8ca374aaef4402449f23dd3b828401116c4f54e", @"/Views/Author/AuthorSidebarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb32bb38a03635894266d8c6ff858af981ab78c", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_AuthorSidebarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<nav class=\"sidebar sidebar-offcanvas\" id=\"sidebar\">\n    <ul class=\"nav\">\n        ");
#nullable restore
#line 3 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Author\AuthorSidebarPartial.cshtml"
   Write(await Component.InvokeAsync("AuthorSidebarInfo"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Dashboard/Index"">
                <span class=""menu-title"">Dashboard</span>
                <i class=""mdi mdi-home menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Author/AuthorEditProfile"">
                <span class=""menu-title"">Profilim</span>
                <i class=""mdi mdi-contacts menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/BlogListByAuthor"">
                <span class=""menu-title"">Bloglarım</span>
                <i class=""mdi mdi-format-list-bulleted menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/AddBlog"">
                <span class=""menu-title"">Yeni Blog</span>
                <i class=""mdi mdi-new-box menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" hre");
            WriteLiteral(@"f=""/Message/InboxMessages"">
                <span class=""menu-title"">Mesajlarım</span>
                <i class=""mdi mdi-message menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Notification/AllNotifications"">
                <span class=""menu-title"">Bildirimler</span>
                <i class=""mdi mdi-bell-ring menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Blog/Index"">
                <span class=""menu-title"">Siteye Git</span>
                <i class=""mdi mdi-door-open menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""pages/tables/basic-table.html"">
                <span class=""menu-title"">Ayarlar</span>
                <i class=""mdi mdi-settings menu-icon""></i>
            </a>
        </li>
        <li class=""nav-item"">
            <a class=""nav-link"" href=""/Login/Logout"">
                <span class=""menu-");
            WriteLiteral("title\">Çıkış Yap</span>\n                <i class=\"mdi mdi-logout menu-icon\"></i>\n            </a>\n        </li>\n\n\n    </ul>\n</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591