#pragma checksum "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\EmployeeTest\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2f725283dfd68502987d9f5fc14ed5da7ea8a8c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_EmployeeTest_Index), @"mvc.1.0.view", @"/Views/EmployeeTest/Index.cshtml")]
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
#nullable restore
#line 1 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\EmployeeTest\Index.cshtml"
using CoreProjectCamp.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2f725283dfd68502987d9f5fc14ed5da7ea8a8c8", @"/Views/EmployeeTest/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb32bb38a03635894266d8c6ff858af981ab78c", @"/Views/_ViewImports.cshtml")]
    public class Views_EmployeeTest_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<EmployeeTestController.Class1>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\EmployeeTest\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Admin_Layout_.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Ad?? Soyad??</th>\r\n        <th colspan=\"2\">Ara??lar</th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\EmployeeTest\Index.cshtml"
     foreach(var item in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 16 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\EmployeeTest\Index.cshtml"
                   Write(item.EmployeeID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 17 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\EmployeeTest\Index.cshtml"
                   Write(item.EmployeeName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 526, "\"", 578, 2);
            WriteAttributeValue("", 533, "/EmployeeTest/DeleteEmployee/", 533, 29, true);
#nullable restore
#line 18 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\EmployeeTest\Index.cshtml"
WriteAttributeValue("", 562, item.EmployeeID, 562, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Sil</a></td>\r\n                    <td><a");
            BeginWriteAttribute("href", " href=\"", 644, "\"", 694, 2);
            WriteAttributeValue("", 651, "/EmployeeTest/EditEmployee/", 651, 27, true);
#nullable restore
#line 19 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\EmployeeTest\Index.cshtml"
WriteAttributeValue("", 678, item.EmployeeID, 678, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">D??zenle</a></td>\r\n                </tr>\r\n");
#nullable restore
#line 21 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\EmployeeTest\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</table>\r\n<a href=\"/EmployeeTest/AddEmployee\" class=\"btn btn-primary\">Yeni ??al????an Giri??i</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<EmployeeTestController.Class1>> Html { get; private set; }
    }
}
#pragma warning restore 1591
