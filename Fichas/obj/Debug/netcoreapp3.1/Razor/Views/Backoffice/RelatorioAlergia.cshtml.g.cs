#pragma checksum "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\RelatorioAlergia.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "41771409a4ac31f05a43d15be4f4c44eea084343"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Backoffice_RelatorioAlergia), @"mvc.1.0.view", @"/Views/Backoffice/RelatorioAlergia.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"41771409a4ac31f05a43d15be4f4c44eea084343", @"/Views/Backoffice/RelatorioAlergia.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f5b9e8418ae216a57354a789b18975e407f7dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Backoffice_RelatorioAlergia : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ficha>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AcampantesLista", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportarExcel", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-tiporelatorio", "Alergia", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\RelatorioAlergia.cshtml"
  
    ViewData["Title"] = "Relatorio Alergia";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">");
#nullable restore
#line 8 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\RelatorioAlergia.cshtml"
                         Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41771409a4ac31f05a43d15be4f4c44eea0843435016", async() => {
                WriteLiteral("Acampantes Geral");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "41771409a4ac31f05a43d15be4f4c44eea0843436272", async() => {
                WriteLiteral("Exportar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-tiporelatorio", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["tiporelatorio"] = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <br />
    <div class=""container"">
        <div id=""grid"">
            <table class=""table"">
                <thead>
                    <tr>
                        <th scope=""col"">Nome</th>
                        <th scope=""col"" class=""text-center"">Equipe</th>
                        <th scope=""col"" class=""text-center"">Pacote</th>
                        <th scope=""col"" class=""text-center"">Cod. Acampante</th>
                        <th scope=""col"" class=""text-center"">Alergia</th>
                        <th scope=""col"" class=""text-center"">Obs</th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 29 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\RelatorioAlergia.cshtml"
                     foreach (var x in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td><b>");
#nullable restore
#line 32 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\RelatorioAlergia.cshtml"
                              Write(x.Acampante.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                            <td class=\"text-center\"><b>");
#nullable restore
#line 33 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\RelatorioAlergia.cshtml"
                                                  Write(x.Acampante.Equipe);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                            <td class=\"text-center\"><b>");
#nullable restore
#line 34 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\RelatorioAlergia.cshtml"
                                                  Write(x.Acampante.DesPacote);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                            <td class=\"text-center\"><b>");
#nullable restore
#line 35 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\RelatorioAlergia.cshtml"
                                                  Write(x.Acampante.codAcampante);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                            <td class=\"text-center\"><b>");
#nullable restore
#line 36 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\RelatorioAlergia.cshtml"
                                                  Write(x.Alergia_Medicamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                            <td>");
#nullable restore
#line 37 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\RelatorioAlergia.cshtml"
                           Write(x.Obs_Alergia_Medicamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    </tr>\r\n");
#nullable restore
#line 39 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Backoffice\RelatorioAlergia.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ficha>> Html { get; private set; }
    }
}
#pragma warning restore 1591