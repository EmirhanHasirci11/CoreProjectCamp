#pragma checksum "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Notification\AllNotifications.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd4f56a679cd48923e63374851e909ff62d2da25"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Notification_AllNotifications), @"mvc.1.0.view", @"/Views/Notification/AllNotifications.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd4f56a679cd48923e63374851e909ff62d2da25", @"/Views/Notification/AllNotifications.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bb32bb38a03635894266d8c6ff858af981ab78c", @"/Views/_ViewImports.cshtml")]
    public class Views_Notification_AllNotifications : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EntityLayer.Concrete.Notification>>
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
#line 2 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Notification\AllNotifications.cshtml"
  
    ViewData["Title"] = "AllNotifications";
    Layout = "~/Views/Shared/_Author_Layout_.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Notification\AllNotifications.cshtml"
   
    string time = "";
    DateTime now = DateTime.Now;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd4f56a679cd48923e63374851e909ff62d2da253952", async() => {
                WriteLiteral("\r\n    <title></title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cd4f56a679cd48923e63374851e909ff62d2da254941", async() => {
                WriteLiteral(@"
    <table class=""table table-dark"">
        <thead>
            <tr>
                <th>#</th>
                <th>Bildirim Türü</th>
                <th>Açıklama</th>
                <th>Tarih</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 26 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Notification\AllNotifications.cshtml"
             foreach (var item in Model)
            {
                TimeSpan calculatedTime = now.Subtract(item.NotificationDate);

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
                WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 57 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Notification\AllNotifications.cshtml"
                   Write(item.NotificationID);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 58 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Notification\AllNotifications.cshtml"
                   Write(item.NotificationType);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 59 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Notification\AllNotifications.cshtml"
                   Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 60 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Notification\AllNotifications.cshtml"
                   Write(time);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Gönderildi</td>\r\n                </tr>\r\n");
#nullable restore
#line 62 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Views\Notification\AllNotifications.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
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
            WriteLiteral("\r\n</html>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EntityLayer.Concrete.Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591