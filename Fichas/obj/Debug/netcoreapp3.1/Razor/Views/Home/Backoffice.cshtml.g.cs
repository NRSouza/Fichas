#pragma checksum "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "86355a9ff19c1963be24c596563d45783d706024"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Backoffice), @"mvc.1.0.view", @"/Views/Home/Backoffice.cshtml")]
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
#line 1 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\_ViewImports.cshtml"
using Fichas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\_ViewImports.cshtml"
using Fichas.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml"
using Fichas.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"86355a9ff19c1963be24c596563d45783d706024", @"/Views/Home/Backoffice.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f5b9e8418ae216a57354a789b18975e407f7dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Backoffice : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AcampanteResponsavel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Ficha", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml"
  
    ViewData["Title"] = "BackOffice";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container"">
    <div class=""text-center"">
        <h1 class=""display-4"">BACK OFFICE</h1>
        <hr />
    </div>
    <div class=""container"">
        <!--<form asp-action=""Backoffice"">
            <div class=""row"">
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Nome acampante</label>-->
");
            WriteLiteral("                <!--</div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Nome Responsavel</label>-->\r\n");
            WriteLiteral(@"                <!--</div>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Checar Ficha"" class=""btn btn-primary"" />
            </div>
        </form>-->
        <div id=""grid"">
            <div class=""text-center"">
                <h4>Total - ");
#nullable restore
#line 32 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml"
                       Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h4>
            </div>
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Responsavel</th>
                        <th scope=""col"">Acampante</th>
                        <th scope=""col"">Ficha</th>
                        <th scope=""col"">Preenchida?</th>
                        <th scope=""col"">WhatsApp</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 45 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml"
                     foreach (var x in Model)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td><b>");
#nullable restore
#line 49 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml"
                          Write(x.NomResponsavel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                        <td><b>");
#nullable restore
#line 50 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml"
                          Write(x.NomAcampante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                        <td><b>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "86355a9ff19c1963be24c596563d45783d7060246280", async() => {
                WriteLiteral("FICHA");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CodResponsavel", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml"
                                                                   WriteLiteral(x.CodResponsavel);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CodResponsavel"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CodResponsavel", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CodResponsavel"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 51 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml"
                                                                                                              WriteLiteral(x.CodAcampante);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CodAcampante"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CodAcampante", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CodAcampante"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</b></td>\r\n                        <td>");
#nullable restore
#line 52 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml"
                             if (x.FichaRespondida) {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <b>SIM</b> ");
#nullable restore
#line 52 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml"
                                                                 } else {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <b>NÃO</b> ");
#nullable restore
#line 52 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml"
                                                                                     }

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 2190, "\"", 2465, 6);
            WriteAttributeValue("", 2197, "https://api.whatsapp.com/send?phone=", 2197, 36, true);
#nullable restore
#line 53 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml"
WriteAttributeValue("", 2233, x.Telefone, 2233, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2244, "&text=Sua%20ficha%20de%20saude%20ainda%20esta%20pendente%20porfavor%20preencher%20a%20ficha%20atraves%20do%20link%3A%20https%3A%2F%2Ffichas.nrops.com.br%2F%3FCodResponsavel=", 2244, 173, true);
#nullable restore
#line 53 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml"
WriteAttributeValue("", 2417, x.CodResponsavel, 2417, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2434, "%26CodAcampante=", 2434, 16, true);
#nullable restore
#line 53 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml"
WriteAttributeValue("", 2450, x.CodAcampante, 2450, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" target=\"_blank\">WhatsApp</a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 55 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Backoffice.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AcampanteResponsavel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
