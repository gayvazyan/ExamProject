#pragma checksum "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a3398f60b17d16d52d79763e3d8639e942b8c11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Questions_Random), @"mvc.1.0.view", @"/Views/Questions/Random.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Questions/Random.cshtml", typeof(AspNetCore.Views_Questions_Random))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a3398f60b17d16d52d79763e3d8639e942b8c11", @"/Views/Questions/Random.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb5a412e3e2bbe721e48f20a5f04822cfaf45ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Questions_Random : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CurrentAttempt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Questions", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Test", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RandomT", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Result", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"
  
    ViewData["Title"] = "Հարցաշար";

#line default
#line hidden
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"
  
    var endTime = ViewBag.TiemExasise;
    var timeRemaining = TimeSpan.FromTicks(endTime.Ticks - DateTime.UtcNow.Ticks).TotalSeconds.ToString("#");

#line default
#line hidden
            BeginContext(204, 29, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n");
            EndContext();
#line 11 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"
     if ((ViewBag.QestEnd != true) || (ViewBag.TestEnd != true))
    {

#line default
#line hidden
            BeginContext(306, 154, true);
            WriteLiteral("        <button class=\"btn btn-primary\"> Թեստի ավարտին մնաց :  <span id=\"minRemaining\"></span>:<span id=\"secRemaining\"></span> </button>\r\n        <br />\r\n");
            EndContext();
#line 15 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"
    }

#line default
#line hidden
            BeginContext(467, 714, true);
            WriteLiteral(@"
    <br />
    <span>Տվյալների բազայում այժմ առկա է <button class=""btn btn-info"">103</button> հարց, որնք առանձնացված են մի քանի խմբի, յուրաքանչյուր խմբից</span>
    <br />
    <span>յուրաքանչյուր խմբից պատահականության սկզբունքվ ընտրվում են չկրկնվող հարցեր  </span>
    <span>և ձևավորվում է <button class=""btn btn-info"">30</button> հարցից բաղկացած հարցաշար </span>
    <br />
    <span>Տվյալների բազայում  առկա է <button class=""btn btn-info"">7</button> խնդիր, յուրքանչյուրը <button class=""btn btn-info"">5</button> միավոր </span>
    <br />
    <span>Խնդրհի լուծման  և հարցաշարին պատասխանելու արդյունքում դուք կարող եք վաստակել առավելագույնը  <button class=""btn btn-success"">35</button>  միավոր </span>

");
            EndContext();
#line 27 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"
     if ((ViewBag.CurrentID > 0) && (ViewBag.CurrentID < 30))
    {

        

#line default
#line hidden
            BeginContext(1407, 40, true);
            WriteLiteral("        <br />\r\n        <br />\r\n        ");
            EndContext();
            BeginContext(1447, 111, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a3398f60b17d16d52d79763e3d8639e942b8c118584", async() => {
                BeginContext(1534, 20, true);
                WriteLiteral("Շարունակել հարցաշարը");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1558, 18, true);
            WriteLiteral("\r\n        <br />\r\n");
            EndContext();
#line 38 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"

    }
    else
    {
        

#line default
#line hidden
#line 42 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"
         if (ViewBag.QestEnd == true)
        {

#line default
#line hidden
            BeginContext(1652, 142, true);
            WriteLiteral("            <br />\r\n            <br />\r\n            <a style=\"color:white\" class=\"btn btn-info\">Հարցաշարը ավարտված է</a>\r\n            <br />\r\n");
            EndContext();
#line 48 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(1830, 52, true);
            WriteLiteral("            <br />\r\n            <br />\r\n            ");
            EndContext();
            BeginContext(1882, 89, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a3398f60b17d16d52d79763e3d8639e942b8c1111195", async() => {
                BeginContext(1959, 8, true);
                WriteLiteral("Հարցաշար");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1971, 22, true);
            WriteLiteral("\r\n            <br />\r\n");
            EndContext();
#line 55 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"
        }

#line default
#line hidden
#line 55 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"
         
    }

#line default
#line hidden
            BeginContext(2011, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 59 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"
     if (ViewBag.TestEnd == true)
    {

#line default
#line hidden
            BeginContext(2057, 122, true);
            WriteLiteral("        <br />\r\n        <br />\r\n        <a style=\"color:white\" class=\"btn btn-info\">Խնդիր ավարտված է</a>\r\n        <br />\r\n");
            EndContext();
#line 65 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(2203, 24, true);
            WriteLiteral("        <br />\r\n        ");
            EndContext();
            BeginContext(2227, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a3398f60b17d16d52d79763e3d8639e942b8c1113956", async() => {
                BeginContext(2302, 5, true);
                WriteLiteral("Խնդիր");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2311, 34, true);
            WriteLiteral("\r\n        <br />\r\n        <br />\r\n");
            EndContext();
#line 72 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"
    }

#line default
#line hidden
            BeginContext(2352, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 74 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"
     if ((ViewBag.QestEnd == true) && (ViewBag.TestEnd == true))
    {

#line default
#line hidden
            BeginContext(2427, 43, true);
            WriteLiteral("        <br />\r\n        <span>Մուտք գործեք ");
            EndContext();
            BeginContext(2470, 93, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1a3398f60b17d16d52d79763e3d8639e942b8c1116238", async() => {
                BeginContext(2547, 12, true);
                WriteLiteral("Իմ տվյալները");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2563, 53, true);
            WriteLiteral(" բաժին թեստի արդյունքներին ծանոթանալու համար</span>\r\n");
            EndContext();
            BeginContext(2626, 32, true);
            WriteLiteral("        <br />\r\n        <br />\r\n");
            EndContext();
#line 81 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"
    }

#line default
#line hidden
            BeginContext(2665, 50, true);
            WriteLiteral("\r\n\r\n\r\n</div>\r\n\r\n\r\n<script>\r\n\r\n    var remSeconds =");
            EndContext();
            BeginContext(2716, 13, false);
#line 90 "C:\Users\Garegin\Source\Repos\ExamProject\TestExample\Views\Questions\Random.cshtml"
               Write(timeRemaining);

#line default
#line hidden
            EndContext();
            BeginContext(2729, 1331, true);
            WriteLiteral(@";
    var secondsCounter = remSeconds % 60;

    function formatNumber(number) {
        if (number < 10)
            return '0' + number;
        else return '' + number;
    }

    function startTick() {

        document.getElementById('secRemaining').innerText = formatNumber(parseInt(secondsCounter));
        document.getElementById('minRemaining').innerText = formatNumber(parseInt(remSeconds / 60));


        var _tick = setInterval(function()
        {

            if (remSeconds > 0) {



                remSeconds = remSeconds - 1;
                secondsCounter = secondsCounter - 1;
                document.getElementById('secRemaining').innerText = formatNumber(parseInt(secondsCounter));
                document.getElementById('minRemaining').innerText = formatNumber(parseInt(remSeconds / 60));

                if (secondsCounter == 0)
                    secondsCounter = 60;
            }
            else
            {
                alert('Թեստին հատկացված ժամանակը");
            WriteLiteral(@" ավարտվել է!!!' + '\n' + 'Նոր թեստ սկսելու համար վերադարձեք Սկիզբ');
                window.location.href = ""../Home/Index"";
                clearInterval(_tick);
              //  document.getElementById(""myform"").submit();

            }

        }, 1000);

    }
    startTick();


</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
