#pragma checksum "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c90247e515f75cda6e802b365fbac9c7ad9686d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Email), @"mvc.1.0.view", @"/Views/Home/Email.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Email.cshtml", typeof(AspNetCore.Views_Home_Email))]
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
#line 1 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using TestExample;

#line default
#line hidden
#line 2 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using TestExample.Models;

#line default
#line hidden
#line 3 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using TestExample.MyModels;

#line default
#line hidden
#line 4 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using TestExample.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c90247e515f75cda6e802b365fbac9c7ad9686d6", @"/Views/Home/Email.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb5a412e3e2bbe721e48f20a5f04822cfaf45ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Email : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CitizenReport>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Email", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
  
    ViewData["Title"] = "Ծանուցում";

#line default
#line hidden
            BeginContext(82, 826, true);
            WriteLiteral(@"
<h2>Ծանուցում</h2>

<table border=""1"" >
    <thead>
        <tr>
            <th>
                Անուն
            </th>
            <th>
                Ազգանուն
            </th>
            <th>
                Հայրանուն
            </th>
            <th>
                Անձնագիր
            </th>
            <th>
                Հեռախոսահամար
            </th>
            <th>
                Թեստի միավոր
            </th>
            <th>
                Էլեկտրոցանց
            </th>
            <th>
                Խնդրի լրացման ամսաթիվը
            </th>
            <th>
                Հարցաշարի լրացման ամսաթիվը
            </th>
            <th>
                Ծանուցված
            </th>
            <th>

            </th>
        </tr>
    </thead>
    <tbody>
");
            EndContext();
#line 48 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
 foreach (var item in Model) {

    var TimeNotif = (item.NotificationData).ToString("dd/MM/yyyy HH:mm");
    var result = item.Result_Test1 + item.Result_Test2;

#line default
#line hidden
            BeginContext(1074, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1123, 44, false);
#line 54 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
           Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1223, 43, false);
#line 57 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
           Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1322, 45, false);
#line 60 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
           Write(Html.DisplayFor(modelItem => item.SecondName));

#line default
#line hidden
            EndContext();
            BeginContext(1367, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1423, 43, false);
#line 63 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
           Write(Html.DisplayFor(modelItem => item.Passport));

#line default
#line hidden
            EndContext();
            BeginContext(1466, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1522, 46, false);
#line 66 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
           Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
            EndContext();
            BeginContext(1568, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1624, 36, false);
#line 69 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
           Write(Html.DisplayFor(modelItem => result));

#line default
#line hidden
            EndContext();
            BeginContext(1660, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1716, 40, false);
#line 72 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
           Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(1756, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1812, 48, false);
#line 75 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
           Write(Html.DisplayFor(modelItem => item.Test1DataTime));

#line default
#line hidden
            EndContext();
            BeginContext(1860, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1916, 48, false);
#line 78 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
           Write(Html.DisplayFor(modelItem => item.Test2DataTime));

#line default
#line hidden
            EndContext();
            BeginContext(1964, 56, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n               \r\n");
            EndContext();
#line 82 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
                 if (item.Notification == true)
                {
                   

#line default
#line hidden
            BeginContext(2109, 64, true);
            WriteLiteral("                    <button class=\"btn btn-success\">Ծանուցվել է ");
            EndContext();
            BeginContext(2174, 9, false);
#line 85 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
                                                           Write(TimeNotif);

#line default
#line hidden
            EndContext();
            BeginContext(2183, 13, true);
            WriteLiteral("  </button>\r\n");
            EndContext();
#line 86 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(2256, 74, true);
            WriteLiteral("                    <button class=\"btn btn-danger\">Ծանուցված չէ</button>\r\n");
            EndContext();
#line 90 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
                }

#line default
#line hidden
            BeginContext(2349, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(2404, 112, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c90247e515f75cda6e802b365fbac9c7ad9686d611346", async() => {
                BeginContext(2504, 8, true);
                WriteLiteral("Ծանուցել");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 94 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
                                                                                              WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2516, 38, true);
            WriteLiteral("\r\n\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 98 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Home\Email.cshtml"
}

#line default
#line hidden
            BeginContext(2557, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CitizenReport>> Html { get; private set; }
    }
}
#pragma warning restore 1591
