#pragma checksum "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Message\Reply.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "88f4bbbfbf5acb3bd1052851c652a66d5af53ea4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Author_Views_Message_Reply), @"mvc.1.0.view", @"/Areas/Author/Views/Message/Reply.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"88f4bbbfbf5acb3bd1052851c652a66d5af53ea4", @"/Areas/Author/Views/Message/Reply.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41a961df6978e5bbb3af4877a94e8ff377d89b6", @"/Areas/Author/Views/_ViewImports.cshtml")]
    public class Areas_Author_Views_Message_Reply : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreProjectCamp.Areas.Author.Models.Message.BaseClass>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Al??c?? maili"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Mail konusu"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("summernote"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Author/Message/Reply"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Message\Reply.cshtml"
  
    ViewData["Title"] = "Reply";
    Layout = "~/Areas/Author/Views/Shared/_Author_Layout_.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Message\Reply.cshtml"
  
    string time = "";
    DateTime now = DateTime.Now;
    TimeSpan calculatedTime = now.Subtract(Model.Mreply.MessageDate);

    if (calculatedTime.Days == 0)
    {
        if (calculatedTime.Minutes == 0 && calculatedTime.Hours == 0)
        {
            time = "??imdi";
        }

        else if (calculatedTime.Minutes > 0 && calculatedTime.Hours == 0)
        {
            time = calculatedTime.Minutes + " Dakika ??nce";
        }
        else
        {
            time = calculatedTime.Hours + " Saat " + calculatedTime.Minutes + " Dakika ??nce";
        }
    }
    else
    {
        if (calculatedTime.Hours == 0)
        {
            time = calculatedTime.Days + " G??n ??nce";
        }
        else
        {
            time = calculatedTime.Days + " G??n " + calculatedTime.Hours + " Saat ??nce";
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<html xmlns=\"http://www.w3.org/1999/xhtml\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88f4bbbfbf5acb3bd1052851c652a66d5af53ea47707", async() => {
                WriteLiteral(@"
    <!-- include libraries(jQuery, bootstrap) -->

    <script src=""https://code.jquery.com/jquery-3.4.1.slim.min.js"" integrity=""sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n"" crossorigin=""anonymous""></script>
    <link href=""https://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote-lite.min.css"" rel=""stylesheet"">
    <script src=""https://cdn.jsdelivr.net/npm/summernote@0.8.18/dist/summernote-lite.min.js""></script>
    <title></title>
");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88f4bbbfbf5acb3bd1052851c652a66d5af53ea49160", async() => {
                WriteLiteral("\r\n    <div class=\"wrapper wrapper-content\">\r\n        <div class=\"row\">\r\n            ");
#nullable restore
#line 53 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Message\Reply.cshtml"
       Write(await Component.InvokeAsync("MessageSidebar"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            <div class=""col-lg-9"">
                <div class=""mail-box-header"">
                    <div class=""float-right tooltip-demo"">
                        <a href=""mailbox.html"" class=""btn btn-white btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Taslak olarak kaydet""><i class=""fa fa-pencil""></i> Taslak</a>
                        <a href=""mailbox.html"" class=""btn btn-danger btn-sm"" data-toggle=""tooltip"" data-placement=""top"" title=""Maili iptal et""><i class=""fa fa-times""></i> ??ptal et</a>
                    </div>
                    <h2>
                        Cevapla
                    </h2>
                </div>
                <div class=""mail-tools mail-box-header"">
                    <h5>
                        <span class=""font-normal"">Konu: </span>");
#nullable restore
#line 66 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Message\Reply.cshtml"
                                                          Write(Model.Mreply.MessageSubject);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </h5>\r\n                    <h6>\r\n                        <span class=\"float-right font-normal\"></span>\r\n                        <span class=\"font-normal\">Kimden: <img style=\"width:50px\"");
                BeginWriteAttribute("src", " src=\"", 2753, "\"", 2785, 1);
#nullable restore
#line 70 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Message\Reply.cshtml"
WriteAttributeValue(" ", 2759, Model.Mreply.SenderImage, 2760, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"circle-border\" />");
#nullable restore
#line 70 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Message\Reply.cshtml"
                                                                                                                                      Write(Model.Mreply.SenderMail);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
#nullable restore
#line 70 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Message\Reply.cshtml"
                                                                                                                                                               Write(Model.Mreply.SenderNameSurname);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </span>");
#nullable restore
#line 70 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Message\Reply.cshtml"
                                                                                                                                                                                                      Write(time);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                    </h6>\r\n                    <h5>\r\n                        ");
#nullable restore
#line 74 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Message\Reply.cshtml"
                   Write(Html.Raw(Model.Mreply.MessageDetails));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </h5>\r\n                </div>\r\n                <div class=\"mail-box\">\r\n\r\n\r\n                    <div class=\"mail-body\">\r\n\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88f4bbbfbf5acb3bd1052851c652a66d5af53ea413385", async() => {
                    WriteLiteral("\r\n                            <div class=\"form-group row\">\r\n                                <label class=\"col-sm-2 col-form-label\">Kime:</label>\r\n\r\n                                <div class=\"col-sm-10\">");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "88f4bbbfbf5acb3bd1052851c652a66d5af53ea413865", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 86 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Message\Reply.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Mmessage.Receiver);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Message\Reply.cshtml"
                                                                                                 WriteLiteral(ViewBag.receiver);

#line default
#line hidden
#nullable disable
                    WriteLiteral(" ");
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                    __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("</div>\r\n                            </div>\r\n                            <div class=\"form-group row\">\r\n                                <label class=\"col-sm-2 col-form-label\">Konu:</label>\r\n\r\n                                <div class=\"col-sm-10\">");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "88f4bbbfbf5acb3bd1052851c652a66d5af53ea417260", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 91 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Message\Reply.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Mmessage.Subject);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    BeginWriteTagHelperAttribute();
                    __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                    __tagHelperExecutionContext.AddHtmlAttribute("readonly", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral("</div>\r\n                            </div>\r\n\r\n\r\n                            <div class=\"mail-text h-200\">\r\n\r\n                                ");
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("textarea", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "88f4bbbfbf5acb3bd1052851c652a66d5af53ea419725", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.TextAreaTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 97 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Message\Reply.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Mmessage.MessageDetails);

#line default
#line hidden
#nullable disable
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_TextAreaTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    WriteLiteral(@"
                                <div class=""clearfix""></div>
                            </div>
                            <div class=""mail-body text-right tooltip-demo"">
                                <button type=""submit"" class=""btn btn-primary""><i class=""fa fa-reply""></i> G??nder</button>
                                
                            </div>
                        ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                    </div>
                    <div class=""clearfix""></div>



                </div>
            </div>
        </div>
    </div>

    <script>
        $('#summernote').summernote({
            placeholder: 'Mail i??eri??ini buraya giriniz.',
            tabsize: 2,
            height: 120,
            toolbar: [
                ['style', ['style']],
                ['font', ['bold', 'underline', 'clear']],
                ['color', ['color']],
                ['para', ['ul', 'ol', 'paragraph']],
                ['table', ['table']],
                ['insert', ['link', 'picture', 'video']],
                ['view', ['fullscreen', 'codeview', 'help']]
            ]
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreProjectCamp.Areas.Author.Models.Message.BaseClass> Html { get; private set; }
    }
}
#pragma warning restore 1591
