#pragma checksum "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Opstina\OpstinaPoruka.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ac59e70243198ff2d6871dcf50717050cd542f6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Opstina_OpstinaPoruka), @"mvc.1.0.view", @"/Views/Opstina/OpstinaPoruka.cshtml")]
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
#line 1 "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\_ViewImports.cshtml"
using WebAutoprevozncniko;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\_ViewImports.cshtml"
using WebAutoprevozncniko.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ac59e70243198ff2d6871dcf50717050cd542f6", @"/Views/Opstina/OpstinaPoruka.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a5b27814174e0fa7f9862e83c0fa58ad45f388", @"/Views/_ViewImports.cshtml")]
    public class Views_Opstina_OpstinaPoruka : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Opstina\OpstinaPoruka.cshtml"
  
    ViewData["Title"] = "OpstinaPoruka";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"margin-top:100px\">Uspjesno ste dodali opstinu ");
#nullable restore
#line 6 "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\Opstina\OpstinaPoruka.cshtml"
                                                    Write(TempData["opstina"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1><br />\r\n<a href=\"/Opstina/PrikaziOpstine\">Lista svih opstina</a>\r\n");
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
