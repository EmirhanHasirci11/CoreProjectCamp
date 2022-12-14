#pragma checksum "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Chart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44b7eec864efcc1732e43e10987a7fb588a69dcc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Author_Views_Chart_Index), @"mvc.1.0.view", @"/Areas/Author/Views/Chart/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44b7eec864efcc1732e43e10987a7fb588a69dcc", @"/Areas/Author/Views/Chart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f41a961df6978e5bbb3af4877a94e8ff377d89b6", @"/Areas/Author/Views/_ViewImports.cshtml")]
    public class Areas_Author_Views_Chart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\emir_\source\repos\CoreProjectCamp\CoreProjectCamp\Areas\Author\Views\Chart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Author/Views/Shared/_Author_Layout_.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12"">        
        <div id=""chartdiv"" style=""width:800px;height:600px""></div>
    </div>
</div>

<script type=""text/javascript"" src=""https://www.gstatic.com/charts/loader.js""></script>
<script type=""text/javascript"">
    google.charts.load('current', { 'packages': ['CoreChart'] });
    google.charts.setOnLoadCallback(DrawonLoad);
    function DrawonLoad() {
        $(function () {
            $.ajax({
                type: 'GET',
                url: '/Author/Chart/CategoryChart/',
                success: function (chartsdata) {
                    var Data = chartsdata.jsonlist;
                    var dataVirt = new google.visualization.DataTable();
                    dataVirt.addColumn('string', 'categoryname');
                    dataVirt.addColumn('number', 'categorycount');
                    for (var i = 0; i < Data.length; i++) {
                        dataVirt.addRow([Data[i].categoryname, Data[i].categorycount]);
               ");
            WriteLiteral(@"     }
                    var chart = new google.visualization.PieChart(document.getElementById('chartdiv'));
                    chart.draw(dataVirt,
                        {
                            title: ""Google Chart Core Projesi"",
                            position: ""top"",
                            fontsize: ""16px""
                        });
                }
            });
        });
    }
</script>
");
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
