#pragma checksum "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\ImpressaoLote1.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e9d5185165dc22da0b4aa1c9121fc4750e429897"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Backoffice_ImpressaoLote1), @"mvc.1.0.view", @"/Views/Backoffice/ImpressaoLote1.cshtml")]
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
#line 1 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\_ViewImports.cshtml"
using Fichas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\_ViewImports.cshtml"
using Fichas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e9d5185165dc22da0b4aa1c9121fc4750e429897", @"/Views/Backoffice/ImpressaoLote1.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f5b9e8418ae216a57354a789b18975e407f7dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Backoffice_ImpressaoLote1 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Fichas.ViewModel.ImpressaoLote>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div>\r\n");
#nullable restore
#line 3 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\ImpressaoLote1.cshtml"
     foreach (var x in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <p class=\"text-justify\" style=\"font-size:20px\"><b>");
#nullable restore
#line 7 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\ImpressaoLote1.cshtml"
                                                         Write(x.Acampante.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 7 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\ImpressaoLote1.cshtml"
                                                                             Write(x.Acampante.Equipe);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 7 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\ImpressaoLote1.cshtml"
                                                                                                   Write(x.Acampante.codAcampante);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 7 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\ImpressaoLote1.cshtml"
                                                                                                                               Write(x.Acampante.DesPacote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n            <br />\r\n            <p>De: <b>");
#nullable restore
#line 9 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\ImpressaoLote1.cshtml"
                 Write(x.Terceiro.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n            <p style=\"font-size:16px;\">");
#nullable restore
#line 10 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\ImpressaoLote1.cshtml"
                                  Write(x.Message.Msg);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <br />\r\n            <p>------------------------------------------------------------------------------</p>\r\n        </div>\r\n");
#nullable restore
#line 14 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\ImpressaoLote1.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        window.onload = function () {\r\n            window.print();\r\n        }\r\n    </script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Fichas.ViewModel.ImpressaoLote>> Html { get; private set; }
    }
}
#pragma warning restore 1591
