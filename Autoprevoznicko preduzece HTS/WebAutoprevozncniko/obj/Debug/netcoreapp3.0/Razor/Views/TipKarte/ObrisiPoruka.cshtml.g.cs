#pragma checksum "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\TipKarte\ObrisiPoruka.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c6f0d85e802ede849378b239d880a80d8defccd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TipKarte_ObrisiPoruka), @"mvc.1.0.view", @"/Views/TipKarte/ObrisiPoruka.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c6f0d85e802ede849378b239d880a80d8defccd2", @"/Views/TipKarte/ObrisiPoruka.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9a5b27814174e0fa7f9862e83c0fa58ad45f388", @"/Views/_ViewImports.cshtml")]
    public class Views_TipKarte_ObrisiPoruka : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\TipKarte\ObrisiPoruka.cshtml"
  
    ViewData["Title"] = "ObrisiPoruka";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"margin-top:100px\">Uspjesno ste obrisali ");
#nullable restore
#line 6 "C:\Users\Almin\Desktop\webapp\Autoprevoznicko preduzece HTS\WebAutoprevozncniko\Views\TipKarte\ObrisiPoruka.cshtml"
                                              Write(TempData["TipKarte"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" kartu</h1><br />\r\n<a href=\"/TipKarte/ListaTipovaKarata\">Lista svih tipova karata</a>\r\n\r\n");
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