#pragma checksum "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\AllTest.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53be6642bc342964fb3a24f95f411f3d85297ec5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_AllTest), @"mvc.1.0.view", @"/Views/Questions/AllTest.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questions/AllTest.cshtml", typeof(AspNetCore.Views_Questions_AllTest))]
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
#line 1 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using TestExample;

#line default
#line hidden
#line 2 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using TestExample.Models;

#line default
#line hidden
#line 3 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using TestExample.MyModels;

#line default
#line hidden
#line 4 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using TestExample.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53be6642bc342964fb3a24f95f411f3d85297ec5", @"/Views/Questions/AllTest.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb5a412e3e2bbe721e48f20a5f04822cfaf45ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_AllTest : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Answer>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-align:left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Questions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Submit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("myform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/submit.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\AllTest.cshtml"
  
    ViewData["Title"] = "Հարցաշար";


#line default
#line hidden
            BeginContext(69, 133, true);
            WriteLiteral("\r\n\r\n\r\n<span>Թեստի ավարտին մնաց:</span> <span id=\"countdown\" class=\"countdown\"> </span>\r\n<h3 style=\"text-align:center\">Հարցաշար</h3>\r\n");
            EndContext();
            BeginContext(202, 1907, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53be6642bc342964fb3a24f95f411f3d85297ec56566", async() => {
                BeginContext(267, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 13 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\AllTest.cshtml"
       var i = 0; 

#line default
#line hidden
                BeginContext(290, 39, true);
                WriteLiteral("    <ul style=\"list-style-type:none\">\r\n");
                EndContext();
#line 15 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\AllTest.cshtml"
         foreach (var question in ViewBag.Questions)
        {
            i++;

#line default
#line hidden
                BeginContext(412, 74, true);
                WriteLiteral("            <li>\r\n                <strong style=\"text-align:center\"> Հարց ");
                EndContext();
                BeginContext(487, 1, false);
#line 19 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\AllTest.cshtml"
                                                   Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(488, 3, true);
                WriteLiteral("   ");
                EndContext();
                BeginContext(492, 24, false);
#line 19 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\AllTest.cshtml"
                                                        Write(question.QuestionContent);

#line default
#line hidden
                EndContext();
                BeginContext(516, 65, true);
                WriteLiteral("</strong>\r\n                <input type=\"hidden\" name=\"questionId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 581, "\"", 602, 1);
#line 20 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\AllTest.cshtml"
WriteAttributeValue("", 589, question.QId, 589, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(603, 38, true);
                WriteLiteral(" />\r\n                <ol type=\"A\">\r\n\r\n");
                EndContext();
#line 23 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\AllTest.cshtml"
                     foreach (var answer in Model)
                    {
                        if (answer.QuestionId == question.QId)
                        {

#line default
#line hidden
                BeginContext(807, 85, true);
                WriteLiteral("                            <li>\r\n                                <input type=\"radio\"");
                EndContext();
                BeginWriteAttribute("name", " name=\"", 892, "\"", 921, 2);
                WriteAttributeValue("", 899, "question_", 899, 9, true);
#line 28 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\AllTest.cshtml"
WriteAttributeValue("", 908, question.QId, 908, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginWriteAttribute("value", "\r\n                                       value=\"", 922, "\"", 980, 1);
#line 29 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\AllTest.cshtml"
WriteAttributeValue("", 970, answer.Id, 970, 10, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(981, 37, true);
                WriteLiteral(" />\r\n                                ");
                EndContext();
                BeginContext(1019, 29, false);
#line 30 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\AllTest.cshtml"
                           Write(answer.QuestionVariantContent);

#line default
#line hidden
                EndContext();
                BeginContext(1048, 37, true);
                WriteLiteral("\r\n                            </li>\r\n");
                EndContext();
#line 32 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\AllTest.cshtml"

                        }

                    }

#line default
#line hidden
                BeginContext(1139, 44, true);
                WriteLiteral("\r\n                </ol>\r\n            </li>\r\n");
                EndContext();
#line 40 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\AllTest.cshtml"
             if (i > 31)
            {
                break;
            }

#line default
#line hidden
#line 43 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\AllTest.cshtml"
             
        }

#line default
#line hidden
                BeginContext(1276, 52, true);
                WriteLiteral("    </ul>\r\n    <div style=\"text-align:center\">\r\n\r\n\r\n");
                EndContext();
                BeginContext(1473, 543, true);
                WriteLiteral(@"        <span id=""confirmSubmitSpan"" style=""display:none"">
            <span>Դուք համոզված եք որ ցանկանում եք Ավատրել</span>
            <br />
            <button type=""submit"" style=""text-align:center"" class=""btn btn-success"">Այո</button>
            <a href=""#"" class=""btn btn-primary""
               onclick=""confirmSubmit(false)"">Ոչ</a>
        </span>

        <span id=""submitSpan"">
            <a href=""#"" class=""btn btn-success""
               onclick=""confirmSubmit(true)"">Ավատրել</a>
        </span>

    </div>

    ");
                EndContext();
                BeginContext(2016, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("div", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53be6642bc342964fb3a24f95f411f3d85297ec512312", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ValidationSummaryTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper);
#line 65 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\AllTest.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary = global::Microsoft.AspNetCore.Mvc.Rendering.ValidationSummary.All;

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-validation-summary", __Microsoft_AspNetCore_Mvc_TagHelpers_ValidationSummaryTagHelper.ValidationSummary, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2100, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2109, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2130, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(2136, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53be6642bc342964fb3a24f95f411f3d85297ec515917", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2174, 2, true);
                WriteLiteral("\r\n");
                EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Answer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
