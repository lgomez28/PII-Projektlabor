#pragma checksum "C:\Users\nboskamp\Desktop\Studium\PII\FitnessWebAppUSA18_02\fitnessappProjekt\Pages\charts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "008a0a3f57e9a766ebe0a27d15e9f85b1b2c3bf6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(newPII.Pages.Pages_charts), @"mvc.1.0.razor-page", @"/Pages/charts.cshtml")]
namespace newPII.Pages
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
#line 1 "C:\Users\nboskamp\Desktop\Studium\PII\FitnessWebAppUSA18_02\fitnessappProjekt\Pages\_ViewImports.cshtml"
using newPII;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"008a0a3f57e9a766ebe0a27d15e9f85b1b2c3bf6", @"/Pages/charts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a024cc2807e594e78eb9e9ec71d29d09f287034e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_charts : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/chart.js/dist/Chart.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/coreui/js/custom-tooltips.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/coreui/js/charts.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\nboskamp\Desktop\Studium\PII\FitnessWebAppUSA18_02\fitnessappProjekt\Pages\charts.cshtml"
  
    ViewData["Title"] = "Charts";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container-fluid"">
    <div class=""animated fadeIn"">
        <div class=""card-columns cols-2"">
            <div class=""card"">
                <div class=""card-header"">
                    Line Chart
                    <div class=""card-header-actions"">
                        <a class=""card-header-action"" href=""http://www.chartjs.org"" target=""_blank"">
                            <small class=""text-muted"">docs</small>
                        </a>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""chart-wrapper"">
                        <canvas id=""canvas-1""></canvas>
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"">
                    Bar Chart
                    <div class=""card-header-actions"">
                        <a class=""card-header-action"" href=""http://www.chartjs.org"" target=""_blank"">
                   ");
            WriteLiteral(@"         <small class=""text-muted"">docs</small>
                        </a>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""chart-wrapper"">
                        <canvas id=""canvas-2""></canvas>
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"">
                    Doughnut Chart
                    <div class=""card-header-actions"">
                        <a class=""card-header-action"" href=""http://www.chartjs.org"" target=""_blank"">
                            <small class=""text-muted"">docs</small>
                        </a>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""chart-wrapper"">
                        <canvas id=""canvas-3""></canvas>
                    </div>
                </div>
            </div>
            <div class=""card"">
     ");
            WriteLiteral(@"           <div class=""card-header"">
                    Radar Chart
                    <div class=""card-header-actions"">
                        <a class=""card-header-action"" href=""http://www.chartjs.org"" target=""_blank"">
                            <small class=""text-muted"">docs</small>
                        </a>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""chart-wrapper"">
                        <canvas id=""canvas-4""></canvas>
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"">
                    Pie Chart
                    <div class=""card-header-actions"">
                        <a class=""card-header-action"" href=""http://www.chartjs.org"" target=""_blank"">
                            <small class=""text-muted"">docs</small>
                        </a>
                    </div>
                </div>
              ");
            WriteLiteral(@"  <div class=""card-body"">
                    <div class=""chart-wrapper"">
                        <canvas id=""canvas-5""></canvas>
                    </div>
                </div>
            </div>
            <div class=""card"">
                <div class=""card-header"">
                    Polar Area Chart
                    <div class=""card-header-actions"">
                        <a class=""card-header-action"" href=""http://www.chartjs.org"" target=""_blank"">
                            <small class=""text-muted"">docs</small>
                        </a>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""chart-wrapper"">
                        <canvas id=""canvas-6""></canvas>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "008a0a3f57e9a766ebe0a27d15e9f85b1b2c3bf68523", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "008a0a3f57e9a766ebe0a27d15e9f85b1b2c3bf69622", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "008a0a3f57e9a766ebe0a27d15e9f85b1b2c3bf610721", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pages_charts> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_charts> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Pages_charts>)PageContext?.ViewData;
        public Pages_charts Model => ViewData.Model;
    }
}
#pragma warning restore 1591