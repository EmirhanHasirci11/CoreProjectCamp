#pragma checksum "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Admin\Views\Blog\BlogTitleListExcel.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d62fda8fda829e7e23c64ae6dd3fef1e53ad2e0a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blog_BlogTitleListExcel), @"mvc.1.0.view", @"/Areas/Admin/Views/Blog/BlogTitleListExcel.cshtml")]
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
#line 1 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Admin\Views\_ViewImports.cshtml"
using CoreProjectCamp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Admin\Views\_ViewImports.cshtml"
using CoreProjectCamp.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d62fda8fda829e7e23c64ae6dd3fef1e53ad2e0a", @"/Areas/Admin/Views/Blog/BlogTitleListExcel.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e4a1b3075e00ee910f509fa0feb5432a07f3efc", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Blog_BlogTitleListExcel : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Admin\Views\Blog\BlogTitleListExcel.cshtml"
  
    ViewData["Title"] = "BlogTitleListExcel";
    Layout = "~/Areas/Admin/Views/Shared/_Admin_Layout_.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<button class=""btn btn-warning"" onclick=""DownloadExcelBlogList()"">Open in window</button>
<a href=""/Admin/Blog/ExportDynamicExcelBlogList"" class=""btn btn-primary"">Excel listesini indir</a>

<script>
    function DownloadExcelBlogList() {
        window.open(""/Admin/Blog/ExportDynamicExcelBlogList"")
    }
</script>");
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
