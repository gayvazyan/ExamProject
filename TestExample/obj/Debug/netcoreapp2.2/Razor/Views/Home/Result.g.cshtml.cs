#pragma checksum "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6410186c7714618a566b394a2c4aa71c23ebe94e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Result.cshtml", typeof(AspNetCore.Views_Home_Result))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6410186c7714618a566b394a2c4aa71c23ebe94e", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"377696425e675c2a8630f5500b90f0610bf0632d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CitizenReport>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MyEmail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(22, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
  
    ViewData["Title"] = "Իմ տվյալները";

#line default
#line hidden
            BeginContext(72, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
   var sumResult = Model.Result_Test1 + Model.Result_Test2; 

#line default
#line hidden
            BeginContext(137, 104, true);
            WriteLiteral("\r\n<div style=\"text-align:center\">\r\n    <h3> <strong>Ամբողրական անուն: <span style=\"color:forestgreen\">  ");
            EndContext();
            BeginContext(242, 14, false);
#line 10 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                                Write(Model.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(256, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(258, 15, false);
#line 10 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                                                Write(Model.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(273, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(275, 16, false);
#line 10 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                                                                 Write(Model.SecondName);

#line default
#line hidden
            EndContext();
            BeginContext(291, 104, true);
            WriteLiteral(" </span> </strong> </h3>\r\n    <h3> <strong> Անձը հաստատող պաստաթուղթ: <span style=\"color:forestgreen\">  ");
            EndContext();
            BeginContext(396, 14, false);
#line 11 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                                         Write(Model.Passport);

#line default
#line hidden
            EndContext();
            BeginContext(410, 93, true);
            WriteLiteral(" </span> </strong> </h3>\r\n    <h3> <strong> Հեռախոսահամար: <span style=\"color:forestgreen\">  ");
            EndContext();
            BeginContext(504, 17, false);
#line 12 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                              Write(Model.PhoneNumber);

#line default
#line hidden
            EndContext();
            BeginContext(521, 30, true);
            WriteLiteral(" </span> </strong> </h3>\r\n\r\n\r\n");
            EndContext();
#line 15 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
     if (Model.Test1Check == true)
    {

#line default
#line hidden
            BeginContext(594, 60, true);
            WriteLiteral("        <h3><strong>Խնդրը լրացնելու վերջին փորձը կատարել եք ");
            EndContext();
            BeginContext(655, 19, false);
#line 17 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                       Write(Model.Test1DataTime);

#line default
#line hidden
            EndContext();
            BeginContext(674, 64, true);
            WriteLiteral("-ին, որի արդյունքում ստացել եք <span style=\"color:forestgreen\"> ");
            EndContext();
            BeginContext(739, 18, false);
#line 17 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                                                                                                           Write(Model.Result_Test1);

#line default
#line hidden
            EndContext();
            BeginContext(757, 32, true);
            WriteLiteral("</span> միավոր </strong> </h3>\r\n");
            EndContext();
#line 18 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"

    }
    else
    {

#line default
#line hidden
            BeginContext(815, 58, true);
            WriteLiteral("        <h3><strong>Խնդրը դեռ չէք լրացրել</strong> </h3>\r\n");
            EndContext();
#line 23 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
    }

#line default
#line hidden
            BeginContext(880, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 25 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
     if (Model.Test2Check == true)
    {

#line default
#line hidden
            BeginContext(925, 65, true);
            WriteLiteral("        <h3><strong>Հարցաշարիը լրացնելու վերջին փորձը կատարել եք ");
            EndContext();
            BeginContext(991, 19, false);
#line 27 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                            Write(Model.Test2DataTime);

#line default
#line hidden
            EndContext();
            BeginContext(1010, 64, true);
            WriteLiteral("-ին, որի արդյունքում ստացել եք <span style=\"color:forestgreen\"> ");
            EndContext();
            BeginContext(1075, 18, false);
#line 27 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                                                                                                                Write(Model.Result_Test2);

#line default
#line hidden
            EndContext();
            BeginContext(1093, 32, true);
            WriteLiteral("</span> միավոր </strong> </h3>\r\n");
            EndContext();
#line 28 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"

    }
    else
    {

#line default
#line hidden
            BeginContext(1151, 62, true);
            WriteLiteral("        <h3><strong>Հարցաշարը դեռ չէք լրացրել</strong> </h3>\r\n");
            EndContext();
#line 33 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
    }

#line default
#line hidden
            BeginContext(1220, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 36 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
     if ((Model.Test2Check == true) && (Model.Test2Check == true))
    {

#line default
#line hidden
            BeginContext(1299, 111, true);
            WriteLiteral("        <h3><strong>Խնդրի և հարցաշարի պատասխանների արդյունքում դուք ստացել եք <span style=\"color:forestgreen\"> ");
            EndContext();
            BeginContext(1411, 9, false);
#line 38 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                                                                          Write(sumResult);

#line default
#line hidden
            EndContext();
            BeginContext(1420, 33, true);
            WriteLiteral(" </span> միավոր </strong> </h3>\r\n");
            EndContext();
#line 39 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"

        if (Model.Notification != "Ծանուցվել է")
        {

#line default
#line hidden
            BeginContext(1516, 77, true);
            WriteLiteral("            <span>Թեստի արդյունքների մասնին ինֆորմացիան </span>\r\n            ");
            EndContext();
            BeginContext(1593, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6410186c7714618a566b394a2c4aa71c23ebe94e12439", async() => {
                BeginContext(1696, 8, true);
                WriteLiteral("Ուղարկել");
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
#line 43 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                                                            WriteLiteral(Model.Id);

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
            BeginContext(1708, 21, true);
            WriteLiteral("\r\n            <span> ");
            EndContext();
            BeginContext(1730, 11, false);
#line 44 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
              Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1741, 20, true);
            WriteLiteral(" էլ հասցեին</span>\r\n");
            EndContext();
#line 45 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1797, 138, true);
            WriteLiteral("            <span>Թեստի արդյունքների մասնին ինֆորմացիան </span>\r\n            <a class=\"btn btn-success\">Ուղարկվեց</a>\r\n            <span> ");
            EndContext();
            BeginContext(1936, 11, false);
#line 50 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
              Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1947, 20, true);
            WriteLiteral(" էլ հասցեին</span>\r\n");
            EndContext();
#line 51 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
        }

    }

#line default
#line hidden
            BeginContext(1987, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CitizenReport> Html { get; private set; }
    }
}
#pragma warning restore 1591
