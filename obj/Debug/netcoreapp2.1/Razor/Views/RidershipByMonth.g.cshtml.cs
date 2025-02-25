#pragma checksum "/home/codio/workspace/cta-web/Views/RidershipByMonth.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7b529ab0ae863a49a6102c8a4517c0a25705e558"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(program.Pages.Views_RidershipByMonth), @"mvc.1.0.razor-page", @"/Views/RidershipByMonth.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/RidershipByMonth.cshtml", typeof(program.Pages.Views_RidershipByMonth), null)]
namespace program.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/codio/workspace/cta-web/Views/_ViewImports.cshtml"
using program;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7b529ab0ae863a49a6102c8a4517c0a25705e558", @"/Views/RidershipByMonth.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e911b8447e269fac6d3a65c717afe71141f66421", @"/Views/_ViewImports.cshtml")]
    public class Views_RidershipByMonth : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/codio/workspace/cta-web/Views/RidershipByMonth.cshtml"
    
  var Labels = Newtonsoft.Json.JsonConvert.SerializeObject(Model.Months);
  var Totals = Newtonsoft.Json.JsonConvert.SerializeObject(Model.NumRiders);

  ViewData["Title"] = "Total Ridership by Month";

#line default
#line hidden
            BeginContext(246, 56, true);
            WriteLiteral("\n<h2>Total Ridership per Month</h2>  \n\n<br />\nRaw data: ");
            EndContext();
            BeginContext(303, 16, false);
#line 13 "/home/codio/workspace/cta-web/Views/RidershipByMonth.cshtml"
     Write(Html.Raw(Totals));

#line default
#line hidden
            EndContext();
            BeginContext(319, 16, true);
            WriteLiteral("\n<br />\n<br />\n\n");
            EndContext();
#line 17 "/home/codio/workspace/cta-web/Views/RidershipByMonth.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
            BeginContext(368, 37, true);
            WriteLiteral("\t   <br />\n\t\t <br />\n\t\t <h3>**ERROR: ");
            EndContext();
            BeginContext(406, 16, false);
#line 22 "/home/codio/workspace/cta-web/Views/RidershipByMonth.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
            EndContext();
            BeginContext(422, 46, true);
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
            EndContext();
#line 27 "/home/codio/workspace/cta-web/Views/RidershipByMonth.cshtml"
	 }

#line default
#line hidden
            BeginContext(474, 350, true);
            WriteLiteral(@"
<div class=""box-body"">  
  <div class=""chart-container"">  
     <canvas id=""myChart""></canvas>  
  </div>  
</div>  

<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.3/Chart.bundle.min.js""></script>

<script>
var ctx = document.getElementById(""myChart"");
var myChart = new Chart(ctx, {
    type: 'line',
    data: {
        labels: ");
            EndContext();
            BeginContext(825, 16, false);
#line 43 "/home/codio/workspace/cta-web/Views/RidershipByMonth.cshtml"
           Write(Html.Raw(Labels));

#line default
#line hidden
            EndContext();
            BeginContext(841, 77, true);
            WriteLiteral(",\n        datasets: [{\n            label: \"# of riders\",  \n            data: ");
            EndContext();
            BeginContext(919, 16, false);
#line 46 "/home/codio/workspace/cta-web/Views/RidershipByMonth.cshtml"
             Write(Html.Raw(Totals));

#line default
#line hidden
            EndContext();
            BeginContext(935, 342, true);
            WriteLiteral(@",
            borderColor: ""blue"",
            pointBackgroundColor: ""black"",
            backgroundColor: ""yellow"",
            borderWidth: 1
        }]
    },
    options: {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero:true
                }
            }]
        }
    }
});
</script>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RidershipByMonthModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RidershipByMonthModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RidershipByMonthModel>)PageContext?.ViewData;
        public RidershipByMonthModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
