#pragma checksum "C:\Users\nboskamp\Desktop\Studium\PII\FitnessWebAppUSA18_02\fitnessappProjekt\Pages\Shared\_NavBar.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e079cb473c88ee06750a6e726ee1dd905a203da1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(newPII.Pages.Shared.Pages_Shared__NavBar), @"mvc.1.0.view", @"/Pages/Shared/_NavBar.cshtml")]
namespace newPII.Pages.Shared
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e079cb473c88ee06750a6e726ee1dd905a203da1", @"/Pages/Shared/_NavBar.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a024cc2807e594e78eb9e9ec71d29d09f287034e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__NavBar : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_LoginPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<header class=""app-header navbar"">
    <button class=""navbar-toggler sidebar-toggler d-lg-none mr-auto"" type=""button"" data-toggle=""sidebar-show"">
        <span class=""navbar-toggler-icon""></span>
    </button>
    <a class=""navbar-brand"" href=""/#"">
        <img class=""navbar-brand-full"" src=""/img/brand/faultier.jpg"" width=""200"" height=""35"" alt=""CoreUI Logo"">
    </a>
    <button class=""navbar-toggler sidebar-toggler d-md-down-none"" type=""button"" data-toggle=""sidebar-lg-show"">
        <span class=""navbar-toggler-icon""></span>
    </button>
    <ul class=""nav navbar-nav flex-grow-1"">
");
#nullable restore
#line 12 "C:\Users\nboskamp\Desktop\Studium\PII\FitnessWebAppUSA18_02\fitnessappProjekt\Pages\Shared\_NavBar.cshtml"
         if (User.Identity.IsAuthenticated){

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"nav-item nav-link px-3\">\r\n            <a class=\"nav-link\" href=\"/index\"> Workout-Tagebuch </a>\r\n        </li>\r\n");
            WriteLiteral("        <li class=\"nav-item nav-link px-3\">\r\n            <a class=\"nav-link\" href=\"/AddFitness\"> BMI-Rechner </a>\r\n        </li>\r\n        <li class=\"nav-item nav-link px-3\">\r\n            <a class=\"nav-link\" href=\"/Privacy\"> Profil </a>\r\n        </li>\r\n");
#nullable restore
#line 23 "C:\Users\nboskamp\Desktop\Studium\PII\FitnessWebAppUSA18_02\fitnessappProjekt\Pages\Shared\_NavBar.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </ul>\r\n    <text>&nbsp;</text>\r\n    \r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e079cb473c88ee06750a6e726ee1dd905a203da14893", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n \r\n</header>");
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
