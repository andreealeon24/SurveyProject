#pragma checksum "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\CompleteSurvey\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e6d897f639b8699f0e7c786c8cb8448eee4111d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CompleteSurvey_Index), @"mvc.1.0.view", @"/Views/CompleteSurvey/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e6d897f639b8699f0e7c786c8cb8448eee4111d", @"/Views/CompleteSurvey/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c33ba8ee87c433da5d483d41fdcb4aef9c08436c", @"/Views/_ViewImports.cshtml")]
    public class Views_CompleteSurvey_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SurveysProject.Models.Data.DataModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\CompleteSurvey\Index.cshtml"
  
    ViewData["Title"] = "Complete Survey";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card bg-light text-dark\">\r\n    <h1 class=\"card-body\">");
#nullable restore
#line 8 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\CompleteSurvey\Index.cshtml"
                     Write(Model.Survey.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<br />\r\n");
#nullable restore
#line 11 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\CompleteSurvey\Index.cshtml"
 foreach (var question in @Model.Survey.Questions)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h2>");
#nullable restore
#line 13 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\CompleteSurvey\Index.cshtml"
   Write(question.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <br />\r\n    <div class=\"form-check\">\r\n        <div>\r\n            <label class=\"form-check-label\">\r\n                <input type=\"radio\" class=\"form-check-input\" name=\"optradio\">");
#nullable restore
#line 18 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\CompleteSurvey\Index.cshtml"
                                                                        Write(question.Options[0]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n        </div>\r\n\r\n        <div>\r\n            <label class=\"form-check-label\">\r\n                <input type=\"radio\" class=\"form-check-input\" name=\"optradio\">");
#nullable restore
#line 24 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\CompleteSurvey\Index.cshtml"
                                                                        Write(question.Options[1]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n        </div>\r\n\r\n        <div>\r\n            <label class=\"form-check-label\">\r\n                <input type=\"radio\" class=\"form-check-input\" name=\"optradio\">");
#nullable restore
#line 30 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\CompleteSurvey\Index.cshtml"
                                                                        Write(question.Options[2]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </label>\r\n        </div>\r\n\r\n    </div>\r\n    <br />\r\n");
#nullable restore
#line 36 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\CompleteSurvey\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n<button type=\"submit\" class=\"btn btn-outline-warning\">Next Question</button>\r\n<button type=\"submit\" class=\"btn btn-outline-success\" disabled>Final Submit</button>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SurveysProject.Models.Data.DataModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
