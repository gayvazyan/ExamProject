#pragma checksum "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92a8b90552f32f7ba6683c308d152549ff7291d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92a8b90552f32f7ba6683c308d152549ff7291d4", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb5a412e3e2bbe721e48f20a5f04822cfaf45ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CitizenTestResults>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(27, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 4 "C:\Users\gareg\source\repos\ExamProject\TestExample\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Խնդիրներ";


#line default
#line hidden
            BeginContext(77, 669, true);
            WriteLiteral(@"
<div class=""text-center"">
    <span>Թեստը լրացնելու համար սահմանվում է մինչև </span>
    <button class=""btn btn-info"">40</button>
    <span>րոպե: </span>
    <br />
    <span>Ստուգարքը գնահատվում է առավելագույնը </span>
    <button class=""btn btn-info"">35</button>
    <span>միավոր: Թեստի յուրաքանչյուր ճիշտ պատասխանը 1 միավոր է,սխալ պատասխանը զրո:</span>
    <br />
    <span>Քվեարկության արդյունքների արձանագրություն կազմելու վերաբերյալ խնդրի լուծումը գնահատվում է առավելագույնը  </span>
    <button class=""btn btn-info"">5</button>
    <span>միավոր: </span>
    <br />
    <br />
    <button class=""btn btn-info"">Անցնել թեստին</button>
</div>



");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CitizenTestResults> Html { get; private set; }
    }
}
#pragma warning restore 1591
