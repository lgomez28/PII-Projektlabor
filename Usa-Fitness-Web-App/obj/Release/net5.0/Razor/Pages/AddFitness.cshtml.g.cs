#pragma checksum "C:\Users\nboskamp\Desktop\Studium\PII\FitnessWebAppUSA18_02\fitnessappProjekt\Pages\AddFitness.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68403c2cc8be1d50044b80d32b549bc6fa0cfb2b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(newPII.Pages.Pages_AddFitness), @"mvc.1.0.razor-page", @"/Pages/AddFitness.cshtml")]
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
#nullable restore
#line 2 "C:\Users\nboskamp\Desktop\Studium\PII\FitnessWebAppUSA18_02\fitnessappProjekt\Pages\AddFitness.cshtml"
using newPII.Controllers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68403c2cc8be1d50044b80d32b549bc6fa0cfb2b", @"/Pages/AddFitness.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a024cc2807e594e78eb9e9ec71d29d09f287034e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_AddFitness : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Gewicht"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align: center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("K??rpergr????e"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\nboskamp\Desktop\Studium\PII\FitnessWebAppUSA18_02\fitnessappProjekt\Pages\AddFitness.cshtml"
  
    ViewData["Title"]="Fitness";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1><center>BMI-Rechner</center></h1></br></br>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68403c2cc8be1d50044b80d32b549bc6fa0cfb2b5620", async() => {
                WriteLiteral("\r\n  \r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "68403c2cc8be1d50044b80d32b549bc6fa0cfb2b5888", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 12 "C:\Users\nboskamp\Desktop\Studium\PII\FitnessWebAppUSA18_02\fitnessappProjekt\Pages\AddFitness.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Fitness.Gewicht);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "68403c2cc8be1d50044b80d32b549bc6fa0cfb2b7798", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 13 "C:\Users\nboskamp\Desktop\Studium\PII\FitnessWebAppUSA18_02\fitnessappProjekt\Pages\AddFitness.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Fitness.Koerpergroesse);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <button type =\"submit\">Submit</button><br/>\r\n    <asp:GridView ID=\"GridView1\" runat=\"server\" ></asp:GridView>\r\n    \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n<html>\r\n   ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68403c2cc8be1d50044b80d32b549bc6fa0cfb2b11042", async() => {
                WriteLiteral(@"
      <title>line chart with ChartJS</title>
      <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
      <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.2/Chart.min.js""></script>

      <style id=""compiled-css"" type=""text/css"">

.chartWrapper {
  position: relative;
}

.chartWrapper > canvas {
  position: absolute;
  left: 0;
  top: 0;
  pointer-events: none;
}

.chartAreaWrapper {
  width: 1000px;
  overflow-x: scroll;
}




    </style>
        <script type=""text/javascript"">

      var gewicht = ");
#nullable restore
#line 51 "C:\Users\nboskamp\Desktop\Studium\PII\FitnessWebAppUSA18_02\fitnessappProjekt\Pages\AddFitness.cshtml"
               Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.setValuesDatabase()[0])));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n      var koerpergroesse = ");
#nullable restore
#line 52 "C:\Users\nboskamp\Desktop\Studium\PII\FitnessWebAppUSA18_02\fitnessappProjekt\Pages\AddFitness.cshtml"
                      Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.setValuesDatabase()[1])));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n      var bmi = ");
#nullable restore
#line 53 "C:\Users\nboskamp\Desktop\Studium\PII\FitnessWebAppUSA18_02\fitnessappProjekt\Pages\AddFitness.cshtml"
           Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.setValuesDatabase()[2])));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\r\n      var timestamp = ");
#nullable restore
#line 55 "C:\Users\nboskamp\Desktop\Studium\PII\FitnessWebAppUSA18_02\fitnessappProjekt\Pages\AddFitness.cshtml"
                 Write(Html.Raw(Newtonsoft.Json.JsonConvert.SerializeObject(Model.setValuesDatabase()[3])));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";

        window.onload=function(){
            $(document).ready(function () {
        var data = {
            labels: timestamp,
            datasets: [
                {
                    label: ""Gewicht"",
                    fill: true,
                    borderColor: ""rgba(135,206,235,1)"",
                    backgroundColor: ""rgba(135,206,235,1)"",
                    pointBackgroundColor: ""rgba(135,206,235,1)"",
                    pointBorderColor: ""rgba(135,206,235,1)"",
                    pointHoverBackgroundColor: ""rgba(135,206,235,1)"",
                    pointHoverBorderColor: ""rgba(135,206,235,1)"",
                    data: gewicht
                },
                {
                    label: ""Koerpergroesse"",
                    fill: true,
                    borderColor: ""rgba(34,139,34,1)"",
                    backgroundColor: ""rgba(34,139,34,1)"",
                    pointBackgroundColor: ""rgba(34,139,34,1)"",
                    pointBorderColor: ""rgba(34,139,34,");
                WriteLiteral(@"1)"",
                    pointHoverBackgroundColor: ""rgba(34,139,34,1)"",
                    pointHoverBorderColor: ""rgba(34,139,34,1)"",
                    data: koerpergroesse
                },
                {
                    label: ""BMI"",
                    fill: true,
                    borderColor: ""rgba(255,64,64,1)"",
                    backgroundColor: ""rgba(255,64,64,1)"",
                    pointBackgroundColor: ""rgba(255,64,64,1)"",
                    pointBorderColor: ""rgba(255,64,64,1)"",
                    pointHoverBackgroundColor: ""rgba(255,64,64,1)"",
                    pointHoverBorderColor: ""rgba(255,64,64,1)"",
                    data: bmi
                }
            ]
        };

                $(function () {
                    var rectangleSet = false;

                    var canvasTest = $('#chart-Test');
                    var chartTest = new Chart(canvasTest, {
                        type: 'line',
                        data: data,
         ");
                WriteLiteral(@"               maintainAspectRatio: false,
                        responsive: true,
                        options: {
                            tooltips: {
                                titleFontSize: 0,
                                titleMarginBottom: 0,
                                bodyFontSize: 20
                                
                            },
                            
                            legend: {
                                display: false
                            },
                            scales: {
                                xAxes: [{
                                    ticks: {
                                        fontSize: 12,
                                        display: true
                                    }
                                }],
                                yAxes: [{
                                    ticks: {
                                        fontSize: 22,
                               ");
                WriteLiteral(@"         beginAtZero: true
                                    }
                                }]
                            },
                            animation: {
                                onComplete: function () {
                                    if (!rectangleSet) {
                                        var scale = window.devicePixelRatio;

                                        var sourceCanvas = chartTest.chart.canvas;
                                        var copyWidth = chartTest.scales['y-axis-0'].width - 10;
                                        var copyHeight = chartTest.scales['y-axis-0'].height + chartTest.scales['y-axis-0'].top + 10;

                                        var targetCtx = document.getElementById(""axis-Test"").getContext(""2d"");

                                        targetCtx.scale(scale, scale);
                                        targetCtx.canvas.width = copyWidth * scale;
                                        targetCtx.canvas.hei");
                WriteLiteral(@"ght = copyHeight * scale;

                                        targetCtx.canvas.style.width = `${copyWidth}px`;
                                        targetCtx.canvas.style.height = `${copyHeight}px`;
                                        targetCtx.drawImage(sourceCanvas, 0, 0, copyWidth * scale, copyHeight * scale, 0, 0, copyWidth * scale, copyHeight * scale);

                                        var sourceCtx = sourceCanvas.getContext('2d');

                                        // Normalize coordinate system to use css pixels.

                                        sourceCtx.clearRect(0, 0, copyWidth * scale, copyHeight * scale);
                                        rectangleSet = true;
                                    }
                                },
                                onProgress: function () {
                                    if (rectangleSet === true) {
                                        var copyWidth = chartTest.scales['y-axis-0'].width;
");
                WriteLiteral(@"                                        var copyHeight = chartTest.scales['y-axis-0'].height + chartTest.scales['y-axis-0'].top + 10;

                                        var sourceCtx = chartTest.chart.canvas.getContext('2d');
                                        sourceCtx.clearRect(0, 0, copyWidth, copyHeight);
                                    }
                                }
                            }
                        }
                    });
                    var newwidth = $('.chartAreaWrapper2').width() + 1500;
                    $('.chartAreaWrapper2').width(newwidth);
                });
            });
        }

      </script>
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
            WriteLiteral(@"

</html>



                          <div class=""card-footer"">
                <div class=""row text-center"">
                    <div class=""col-sm-12 col-md mb-sm-2 mb-0"">
                        <strong>K??rpergr????e</strong>
                        <div class=""progress progress-xs mt-2"">
                            <div class=""progress-bar bg-success"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>
                    <div class=""col-sm-12 col-md mb-sm-2 mb-0"">
                        <strong>Gewicht</strong>
                        <div class=""progress progress-xs mt-2"">
                            <div class=""progress-bar bg-info"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>
                    
                    <div class=""col-sm-12 col-md mb-sm-2 mb-0""");
            WriteLiteral(@">
                        <strong>BMI</strong>
                        <div class=""progress progress-xs mt-2"">
                            <div class=""progress-bar bg-danger"" role=""progressbar"" style=""width: 100%"" aria-valuenow=""100"" aria-valuemin=""0"" aria-valuemax=""100""></div>
                        </div>
                    </div>
                </div>
            </div>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68403c2cc8be1d50044b80d32b549bc6fa0cfb2b21541", async() => {
                WriteLiteral(@" 
                        <div class=""chartWrapper"">
                        <div class=""chartAreaWrapper"">
                        <div class=""chartAreaWrapper2"">
                            <canvas id=""chart-Test"" height=""300"" width=""1800""></canvas>
                        </div>
                        </div>
                        <canvas id=""axis-Test"" height=""300"" width=""0""></canvas>
                        </div>
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
            WriteLiteral("\r\n\r\n}\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<newPII.AddFitnessModels> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<newPII.AddFitnessModels> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<newPII.AddFitnessModels>)PageContext?.ViewData;
        public newPII.AddFitnessModels Model => ViewData.Model;
    }
}
#pragma warning restore 1591
