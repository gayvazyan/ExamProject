#pragma checksum "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "30e5c11b3a033834573926c376e92a385ee3bc50"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Result), @"mvc.1.0.view", @"/Views/Questions/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questions/Result.cshtml", typeof(AspNetCore.Views_Questions_Result))]
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
#line 1 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using TestExample;

#line default
#line hidden
#line 2 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using TestExample.Models;

#line default
#line hidden
#line 3 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using TestExample.MyModels;

#line default
#line hidden
#line 4 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using TestExample.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"30e5c11b3a033834573926c376e92a385ee3bc50", @"/Views/Questions/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb5a412e3e2bbe721e48f20a5f04822cfaf45ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Answer>>
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
            BeginContext(21, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
  
    ViewData["Title"] = "Հարցաշար";


#line default
#line hidden
            BeginContext(69, 94, true);
            WriteLiteral("\r\n<div style=\"text-align:center\">\r\n    <h3> <strong>Հարգելի <span style=\"color:forestgreen\">  ");
            EndContext();
            BeginContext(164, 20, false);
#line 9 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
                                                      Write(ViewBag.UserFullName);

#line default
#line hidden
            EndContext();
            BeginContext(184, 82, true);
            WriteLiteral(" </span> </strong> </h3>\r\n    <h5>Դուք հավաքեցիք <span style=\"color:forestgreen\"> ");
            EndContext();
            BeginContext(267, 20, false);
#line 10 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
                                                   Write(ViewBag.Result_Test2);

#line default
#line hidden
            EndContext();
            BeginContext(287, 450, true);
            WriteLiteral(@" </span> միավոր  </h5>
    <h5>Ձեր ճիշտ  պատասխանները նշված են <strong><span style=""color:green"">կանաչ </span></strong>  գույնով </h5>
    <h5>Ձեր սխալ պատասխանները նշված են <strong><span style=""color:red""> կարմիր</span></strong> գույնով</h5>
    <h5>Ձեր սխալ պատասխանի դեպքում ճիշտ պատասխանները նշված են <strong><span style=""color:green"">  (*ճիշտ պատասխան) </span></strong> նշումով</h5>
</div>


<h3 style=""text-align:center"">Հարցաշար </h3>
");
            EndContext();
            BeginContext(737, 2478, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "30e5c11b3a033834573926c376e92a385ee3bc506097", async() => {
                BeginContext(790, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 19 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
       var i = 0; 

#line default
#line hidden
                BeginContext(813, 39, true);
                WriteLiteral("    <ul style=\"list-style-type:none\">\r\n");
                EndContext();
#line 21 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
         foreach (var question in ViewBag.Questions)
        {
            i++;

#line default
#line hidden
                BeginContext(935, 74, true);
                WriteLiteral("            <li>\r\n                <strong style=\"text-align:center\"> Հարց ");
                EndContext();
                BeginContext(1010, 1, false);
#line 25 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
                                                   Write(i);

#line default
#line hidden
                EndContext();
                BeginContext(1011, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1013, 24, false);
#line 25 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
                                                      Write(question.QuestionContent);

#line default
#line hidden
                EndContext();
                BeginContext(1037, 65, true);
                WriteLiteral("</strong>\r\n                <input type=\"hidden\" name=\"questionId\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1102, "\"", 1123, 1);
#line 26 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
WriteAttributeValue("", 1110, question.QId, 1110, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1124, 38, true);
                WriteLiteral(" />\r\n                <ol type=\"A\">\r\n\r\n");
                EndContext();
#line 29 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
                     foreach (var answer in Model)
                    {
                        if (answer.QuestionId == question.QId)
                        {

#line default
#line hidden
                BeginContext(1328, 34, true);
                WriteLiteral("                            <li>\r\n");
                EndContext();
#line 34 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
                                 if ((answer.CheckdAnswer == true) && (answer.CorrectAnswer == true) && (answer.CheckCorrectAnswer == true))
                                {

#line default
#line hidden
                BeginContext(1539, 93, true);
                WriteLiteral("                                    <button class=\"btn btn-success\" style=\"text-align:left\"> ");
                EndContext();
                BeginContext(1633, 29, false);
#line 36 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
                                                                                        Write(answer.QuestionVariantContent);

#line default
#line hidden
                EndContext();
                BeginContext(1662, 12, true);
                WriteLiteral(" </button>\r\n");
                EndContext();
#line 37 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"

                                }

#line default
#line hidden
                BeginContext(1711, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 40 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
                                 if ((answer.CheckdAnswer == true) && (answer.CorrectAnswer == false) && (answer.CheckCorrectAnswer == false))
                                {


#line default
#line hidden
                BeginContext(1894, 68, true);
                WriteLiteral("                                    <button class=\"btn btn-danger\"> ");
                EndContext();
                BeginContext(1963, 29, false);
#line 43 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
                                                               Write(answer.QuestionVariantContent);

#line default
#line hidden
                EndContext();
                BeginContext(1992, 12, true);
                WriteLiteral(" </button>\r\n");
                EndContext();
#line 44 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"


                                }

#line default
#line hidden
                BeginContext(2043, 32, true);
                WriteLiteral("                                ");
                EndContext();
#line 47 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
                                 if ((answer.CheckdAnswer == false) && (answer.CorrectAnswer == true) && (answer.CheckCorrectAnswer == false))
                                {
                                    

#line default
#line hidden
                BeginContext(2489, 67, true);
                WriteLiteral("                                    <button class=\"btn btn-info\">  ");
                EndContext();
                BeginContext(2557, 29, false);
#line 54 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
                                                              Write(answer.QuestionVariantContent);

#line default
#line hidden
                EndContext();
                BeginContext(2586, 103, true);
                WriteLiteral("  </button>\r\n                                    <span style=\"color:green\"> (*ճիշտ պատասխան)  </span>\r\n");
                EndContext();
#line 56 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"

                                }

#line default
#line hidden
                BeginContext(2726, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 59 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
                                 if ((answer.CheckdAnswer == false) && (answer.CorrectAnswer == false) && (answer.CheckCorrectAnswer == false))
                                {


#line default
#line hidden
                BeginContext(2910, 44, true);
                WriteLiteral("                                    <span>  ");
                EndContext();
                BeginContext(2955, 29, false);
#line 62 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
                                       Write(answer.QuestionVariantContent);

#line default
#line hidden
                EndContext();
                BeginContext(2984, 10, true);
                WriteLiteral(" </span>\r\n");
                EndContext();
#line 63 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"

                                }

#line default
#line hidden
                BeginContext(3031, 35, true);
                WriteLiteral("                            </li>\r\n");
                EndContext();
#line 66 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"

                        }
                    }

#line default
#line hidden
                BeginContext(3118, 42, true);
                WriteLiteral("                </ol>\r\n            </li>\r\n");
                EndContext();
#line 71 "C:\Users\gareg\Source\Repos\ExamProject\TestExample\Views\Questions\Result.cshtml"
            
        }

#line default
#line hidden
                BeginContext(3185, 23, true);
                WriteLiteral("        </ul>\r\n      \r\n");
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
            BeginContext(3215, 12, true);
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Answer>> Html { get; private set; }
    }
}
#pragma warning restore 1591