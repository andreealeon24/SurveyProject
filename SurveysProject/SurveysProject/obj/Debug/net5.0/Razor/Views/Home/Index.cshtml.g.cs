#pragma checksum "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffba2d01f8725bf9bc0c802138a82c0153e16dc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\_ViewImports.cshtml"
using SurveysProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\_ViewImports.cshtml"
using SurveysProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Home\Index.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ffba2d01f8725bf9bc0c802138a82c0153e16dc3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c33ba8ee87c433da5d483d41fdcb4aef9c08436c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SurveysProject.Models.Survey>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 7 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ffba2d01f8725bf9bc0c802138a82c0153e16dc33761", async() => {
                WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr class=\"text-white\" style=\"background-color: #4d90ba \">\r\n\r\n                <th>\r\n                    ");
#nullable restore
#line 17 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Home\Index.cshtml"
               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </th>\r\n\r\n                <th>\r\n\r\n                </th>\r\n\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 27 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 31 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Home\Index.cshtml"
               Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </td>\r\n\r\n                <td>\r\n");
#nullable restore
#line 35 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Home\Index.cshtml"
                     if (@HttpContextAccessor.HttpContext.Session.GetString("Role") == "Admin" || @HttpContextAccessor.HttpContext.Session.GetString("Role") == "Teacher")
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 953, "\"", 1024, 1);
#nullable restore
#line 37 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 960, Url.Action("ViewSurvey", "Statistics", new {surveyId= item.Id}), 960, 64, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-info\" style=\"margin-left:2%\" id=\"view\">View</a>\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 1124, "\"", 1199, 1);
#nullable restore
#line 38 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 1131, Url.Action("DeleteSurvey", "CreateSurvey", new {surveyId= item.Id}), 1131, 68, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-info\" style=\"margin-left:2%\" id=\"delete\">Delete</a>\r\n");
#nullable restore
#line 39 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <a");
                BeginWriteAttribute("href", " href=\"", 1375, "\"", 1445, 1);
#nullable restore
#line 42 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 1382, Url.Action("Index", "CompleteSurvey", new {surveyId= item.Id}), 1382, 63, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-outline-info\" id=\"complete\">Complete</a>\r\n");
#nullable restore
#line 43 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </td>\r\n            </tr>\r\n");
#nullable restore
#line 46 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n\r\n    </table>\r\n\r\n");
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
            WriteLiteral("\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SurveysProject.Models.Survey>> Html { get; private set; }
    }
}
#pragma warning restore 1591
