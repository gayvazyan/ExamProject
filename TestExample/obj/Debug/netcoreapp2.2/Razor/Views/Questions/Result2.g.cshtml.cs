#pragma checksum "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "902bdb77f728f7f73e03973d6b53332a86210531"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Result2), @"mvc.1.0.view", @"/Views/Questions/Result2.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questions/Result2.cshtml", typeof(AspNetCore.Views_Questions_Result2))]
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
using TestExample.QAmodels;

#line default
#line hidden
#line 5 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using TestExample.ViewModels;

#line default
#line hidden
#line 6 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"902bdb77f728f7f73e03973d6b53332a86210531", @"/Views/Questions/Result2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"377696425e675c2a8630f5500b90f0610bf0632d", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Result2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Answer2>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Questions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Submit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
  
    ViewData["Title"] = "Հարցաշար 2";


#line default
#line hidden
            BeginContext(72, 94, true);
            WriteLiteral("\r\n<div style=\"text-align:center\">\r\n    <h3> <strong>Հարգելի <span style=\"color:forestgreen\">  ");
            EndContext();
            BeginContext(167, 20, false);
#line 9 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
                                                      Write(ViewBag.UserFullName);

#line default
#line hidden
            EndContext();
            BeginContext(187, 90, true);
            WriteLiteral(" </span> </strong> </h3>\r\n    <h3><strong>Դուք հավաքեցիք <span style=\"color:forestgreen\"> ");
            EndContext();
            BeginContext(278, 20, false);
#line 10 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
                                                           Write(ViewBag.Result_Test2);

#line default
#line hidden
            EndContext();
            BeginContext(298, 312, true);
            WriteLiteral(@" </span> միավոր </strong> </h3>
    <h3><strong>Ճիշտ պատասխանները նշված են <span style=""color:forestgreen"">կանաչ </span>  գույնով </strong></h3>
    <h3> <strong>Սխալ պատասխանները նշված են<span style=""color:red""> կարմիր</span> գույնով </strong></h3>
</div>


<h3 style=""text-align:center"">Հարցաշար 1</h3>
");
            EndContext();
            BeginContext(610, 1721, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "902bdb77f728f7f73e03973d6b53332a862105316135", async() => {
                BeginContext(663, 23, true);
                WriteLiteral("\r\n\r\n    <ol type=\"1\">\r\n");
                EndContext();
#line 20 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
         foreach (var question in ViewBag.Questions)
        {

#line default
#line hidden
                BeginContext(751, 69, true);
                WriteLiteral("            <li>\r\n                <strong style=\"text-align:center\"> ");
                EndContext();
                BeginContext(821, 24, false);
#line 23 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
                                              Write(question.QuestionContent);

#line default
#line hidden
                EndContext();
                BeginContext(845, 65, true);
                WriteLiteral("</strong>\r\n                <input type=\"hidden\" name=\"questionId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 910, "\"", 930, 1);
#line 24 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
WriteAttributeValue("", 918, question.Id, 918, 12, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(931, 38, true);
                WriteLiteral(" />\r\n                <ol type=\"a\">\r\n\r\n");
                EndContext();
#line 27 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
                     foreach (var answer in Model)
                    {
                        if (answer.QuestionId == question.Id)
                        {

#line default
#line hidden
                BeginContext(1134, 34, true);
                WriteLiteral("                            <li>\r\n");
                EndContext();
#line 32 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
                                 if (answer.CheckdAnswer == true)
                                {
                                    

#line default
#line hidden
#line 34 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
                                     if (answer.CorrectAnswer == true)
                                    {

#line default
#line hidden
                BeginContext(1381, 122, true);
                WriteLiteral("                                        <strong>\r\n                                            <span style=\"color:green\">  ");
                EndContext();
                BeginContext(1504, 29, false);
#line 37 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
                                                                   Write(answer.QuestionVariantContent);

#line default
#line hidden
                EndContext();
                BeginContext(1533, 61, true);
                WriteLiteral(" </span>\r\n                                        </strong>\r\n");
                EndContext();
#line 39 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
                BeginContext(1714, 120, true);
                WriteLiteral("                                        <strong>\r\n                                            <span style=\"color:red\">  ");
                EndContext();
                BeginContext(1835, 29, false);
#line 43 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
                                                                 Write(answer.QuestionVariantContent);

#line default
#line hidden
                EndContext();
                BeginContext(1864, 61, true);
                WriteLiteral(" </span>\r\n                                        </strong>\r\n");
                EndContext();
#line 45 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
                                    }

#line default
#line hidden
#line 45 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
                                     
                                }
                                else
                                {
                                    

#line default
#line hidden
                BeginContext(2109, 29, false);
#line 49 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
                               Write(answer.QuestionVariantContent);

#line default
#line hidden
                EndContext();
#line 49 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
                                                                  
                                }

#line default
#line hidden
                BeginContext(2175, 35, true);
                WriteLiteral("                            </li>\r\n");
                EndContext();
#line 52 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
                        }
                    }

#line default
#line hidden
                BeginContext(2260, 42, true);
                WriteLiteral("                </ol>\r\n            </li>\r\n");
                EndContext();
#line 56 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Questions\Result2.cshtml"
        }

#line default
#line hidden
                BeginContext(2313, 11, true);
                WriteLiteral("    </ol>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Answer2>> Html { get; private set; }
    }
}
#pragma warning restore 1591
