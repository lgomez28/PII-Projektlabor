#pragma checksum "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\Privacy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9008e7d290d10faa26c0627add51ac91b6a26815"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(newPII.Pages.Pages_Privacy), @"mvc.1.0.razor-page", @"/Pages/Privacy.cshtml")]
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
#line 1 "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\_ViewImports.cshtml"
using newPII;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\Privacy.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\Privacy.cshtml"
using Microsoft.Identity.Web;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9008e7d290d10faa26c0627add51ac91b6a26815", @"/Pages/Privacy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a024cc2807e594e78eb9e9ec71d29d09f287034e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Privacy : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "AzureADB2C", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SignIn", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\Privacy.cshtml"
  
    ViewData["Title"] = "JSON Web Token";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 9 "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\Privacy.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\Privacy.cshtml"
 if(User.Identity.IsAuthenticated)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"nav navbar-nav navbar-right\">\r\n        <li class=\"navbar-text\">Hello ");
#nullable restore
#line 14 "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\Privacy.cshtml"
                                 Write(User.GetDisplayName());

#line default
#line hidden
#nullable disable
            WriteLiteral("!</li>\r\n        <table class=\"table-hover table-condensed table-striped\">\r\n\t        <tr>\r\n\t\t        <th>Claim Type</th>\r\n\t\t        <th>Claim Value</th>\r\n\t        </tr>\r\n\r\n");
#nullable restore
#line 21 "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\Privacy.cshtml"
             foreach (Claim claim in User.Claims)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 24 "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\Privacy.cshtml"
                   Write(claim.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 25 "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\Privacy.cshtml"
                   Write(claim.Value);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 27 "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\Privacy.cshtml"
               
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n        </table>\r\n        <li class=\"navbar-text\">ID: ");
#nullable restore
#line 31 "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\Privacy.cshtml"
                               Write(User.FindFirstValue(ClaimTypes.NameIdentifier));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n        <li class=\"navbar-text\">Country: ");
#nullable restore
#line 32 "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\Privacy.cshtml"
                                    Write(User.FindFirstValue("country"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n\r\n    </ul>\r\n");
#nullable restore
#line 35 "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\Privacy.cshtml"

   
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <ul class=\"nav navbar-nav navbar-right\">\r\n        <li>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9008e7d290d10faa26c0627add51ac91b6a268158105", async() => {
                WriteLiteral("Sign in");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n    </ul>\r\n");
#nullable restore
#line 43 "C:\Users\larae\Desktop\HS Mannheim\Master\1.Semester\03_PII\PII_Projekt\15_02_2022_EU\fitnessappProjekt\Pages\Privacy.cshtml"
}    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PrivacyModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<PrivacyModel>)PageContext?.ViewData;
        public PrivacyModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
