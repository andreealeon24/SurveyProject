#pragma checksum "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Statistics\ViewSurvey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "54754d04c9d136f546f4be14b2c94fe88ad4c3d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Statistics_ViewSurvey), @"mvc.1.0.view", @"/Views/Statistics/ViewSurvey.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"54754d04c9d136f546f4be14b2c94fe88ad4c3d5", @"/Views/Statistics/ViewSurvey.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c33ba8ee87c433da5d483d41fdcb4aef9c08436c", @"/Views/_ViewImports.cshtml")]
    public class Views_Statistics_ViewSurvey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SurveysProject.Models.ViewModels.StatisticsModel>
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
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Statistics\ViewSurvey.cshtml"
  
    ViewData["Title"] = "View Survey";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54754d04c9d136f546f4be14b2c94fe88ad4c3d53597", async() => {
                WriteLiteral("\r\n\r\n    <h2 id=\"survey\">");
#nullable restore
#line 10 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Statistics\ViewSurvey.cshtml"
               Write(Model.Survey.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Statistics\ViewSurvey.cshtml"
     foreach (var question in Model.Questions)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <h3 id=\"question\">");
#nullable restore
#line 14 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Statistics\ViewSurvey.cshtml"
                     Write(question.Text);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n");
#nullable restore
#line 17 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Statistics\ViewSurvey.cshtml"
         foreach (var option in question.Options)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <input type=\"radio\" class=\"form-check-input\" name=\"optradio\" disabled>");
#nullable restore
#line 19 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Statistics\ViewSurvey.cshtml"
                                                                             Write(option.QuestionOptionText);

#line default
#line hidden
#nullable disable
                WriteLiteral("            <br />\r\n");
#nullable restore
#line 21 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Statistics\ViewSurvey.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("        <br /><br />\r\n");
#nullable restore
#line 24 "C:\Users\Andreea\Desktop\Facultate\Anul III\Practica\SurveyProject\SurveysProject\SurveysProject\Views\Statistics\ViewSurvey.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SurveysProject.Models.ViewModels.StatisticsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
