#pragma checksum "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5055d6125811174b23ac80344f62359af57f13b"
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
using TestExample.ViewModels;

#line default
#line hidden
#line 5 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d5055d6125811174b23ac80344f62359af57f13b", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb5a412e3e2bbe721e48f20a5f04822cfaf45ae", @"/Views/_ViewImports.cshtml")]
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
        var Time1 = (Model.Test1DataTime).ToString("dd/MM/yyyy HH:mm");

#line default
#line hidden
            BeginContext(667, 103, true);
            WriteLiteral("        <span>Խնդրը լրացնելու վերջին փորձը կատարել եք  <button class=\"btn btn-outline-success\"><strong>");
            EndContext();
            BeginContext(771, 5, false);
#line 18 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                                                                  Write(Time1);

#line default
#line hidden
            EndContext();
            BeginContext(776, 97, true);
            WriteLiteral("</strong></button>-ին, որի արդյունքում ստացել եք <button class=\"btn btn-outline-success\"><strong>");
            EndContext();
            BeginContext(874, 18, false);
#line 18 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                                                                                                                                                                         Write(Model.Result_Test1);

#line default
#line hidden
            EndContext();
            BeginContext(892, 36, true);
            WriteLiteral("</strong></button> միավոր: </span>\r\n");
            EndContext();
#line 19 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"

    }
    else
    {

#line default
#line hidden
            BeginContext(954, 44, true);
            WriteLiteral("        <span>Խնդրը դեռ չէք լրացրել</span>\r\n");
            EndContext();
#line 24 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
    }

#line default
#line hidden
            BeginContext(1005, 24, true);
            WriteLiteral("    <br />\r\n    <br />\r\n");
            EndContext();
#line 27 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
     if (Model.Test2Check == true)
    {
        var Time2 = (Model.Test2DataTime).ToString("dd/MM/yyyy HH:mm");

#line default
#line hidden
            BeginContext(1145, 108, true);
            WriteLiteral("        <span>Հարցաշարիը լրացնելու վերջին փորձը կատարել եք <button class=\"btn btn-outline-success\"><strong> ");
            EndContext();
            BeginContext(1254, 5, false);
#line 30 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                                                                       Write(Time2);

#line default
#line hidden
            EndContext();
            BeginContext(1259, 98, true);
            WriteLiteral("</strong></button>-ին, որի արդյունքում ստացել եք <button class=\"btn btn-outline-success\"><strong> ");
            EndContext();
            BeginContext(1358, 18, false);
#line 30 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                                                                                                                                                                               Write(Model.Result_Test2);

#line default
#line hidden
            EndContext();
            BeginContext(1376, 36, true);
            WriteLiteral("</strong></button> միավոր: </span>\r\n");
            EndContext();
#line 31 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"


    }
    else
    {

#line default
#line hidden
            BeginContext(1440, 48, true);
            WriteLiteral("        <span>Հարցաշարը դեռ չէք լրացրել</span>\r\n");
            EndContext();
#line 37 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
    }

#line default
#line hidden
            BeginContext(1495, 26, true);
            WriteLiteral("    <br />\r\n    <br />\r\n\r\n");
            EndContext();
#line 41 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
     if ((Model.Test2Check == true) && (Model.Test2Check == true))
    {
        var TimeNotif = (Model.NotificationData).ToString("dd/MM/yyyy HH:mm");

#line default
#line hidden
            BeginContext(1676, 105, true);
            WriteLiteral("        <span>Խնդրի և հարցաշարի պատասխանների արդյունքում դուք ստացել եք <button class=\"btn btn-success\"> ");
            EndContext();
            BeginContext(1782, 9, false);
#line 44 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                                                                    Write(sumResult);

#line default
#line hidden
            EndContext();
            BeginContext(1791, 28, true);
            WriteLiteral(" </button> միավոր: </span>\r\n");
            EndContext();
#line 45 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
       
        if (sumResult < 30)
        {

#line default
#line hidden
            BeginContext(1868, 80, true);
            WriteLiteral("            <button class=\"btn btn-danger\"> Դուք ստացել եք անբավարար </button>\r\n");
            EndContext();
#line 49 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1984, 108, true);
            WriteLiteral("            <button class=\"btn btn-success\"> Շնորհավորում եմ Դուք եք հաջղությամբ հանձնեցիք թեստը </button>\r\n");
            EndContext();
#line 53 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
        }



#line default
#line hidden
            BeginContext(2107, 16, true);
            WriteLiteral("        <br />\r\n");
            EndContext();
#line 57 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
        if (Model.Notification != true)
        {

#line default
#line hidden
            BeginContext(2175, 77, true);
            WriteLiteral("            <span>Թեստի արդյունքների մասնին ինֆորմացիան </span>\r\n            ");
            EndContext();
            BeginContext(2252, 115, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5055d6125811174b23ac80344f62359af57f13b13841", async() => {
                BeginContext(2355, 8, true);
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
#line 60 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
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
            BeginContext(2367, 21, true);
            WriteLiteral("\r\n            <span> ");
            EndContext();
            BeginContext(2389, 11, false);
#line 61 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
              Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(2400, 20, true);
            WriteLiteral(" էլ հասցեին</span>\r\n");
            EndContext();
#line 62 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(2456, 70, true);
            WriteLiteral("            <span>Թեստի արդյունքների մասնին ինֆորմացիան  ծանուցվէլ է  ");
            EndContext();
            BeginContext(2527, 9, false);
#line 65 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
                                                                 Write(TimeNotif);

#line default
#line hidden
            EndContext();
            BeginContext(2536, 56, true);
            WriteLiteral(" -ին:  </span>\r\n            <br />\r\n            <br />\r\n");
            EndContext();
            BeginContext(2594, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(2606, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d5055d6125811174b23ac80344f62359af57f13b17759", async() => {
                BeginContext(2709, 14, true);
                WriteLiteral("Կրկին ծանուցել");
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
#line 69 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"
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
            BeginContext(2727, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 70 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Result.cshtml"

        }

    }

#line default
#line hidden
            BeginContext(2751, 8, true);
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
