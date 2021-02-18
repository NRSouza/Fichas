#pragma checksum "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e16632e4671dbbd087f5af0a6161e445cec01e4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Ficha), @"mvc.1.0.view", @"/Views/Home/Ficha.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e16632e4671dbbd087f5af0a6161e445cec01e4", @"/Views/Home/Ficha.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f5b9e8418ae216a57354a789b18975e407f7dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Ficha : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ficha>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
  
    ViewData["Title"] = "Ficha";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">FICHA DE SAÚDE</h1>\r\n        <hr />\r\n        <h3>Olá ");
#nullable restore
#line 9 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
           Write(ViewBag.resp.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("  - Ficha de ");
#nullable restore
#line 9 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
                                          Write(ViewBag.acamp.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"container\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e16632e4671dbbd087f5af0a6161e445cec01e44337", async() => {
                WriteLiteral("\r\n            <h5>");
#nullable restore
#line 13 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
           Write(ViewBag.erro);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Peso</label>\r\n                    ");
#nullable restore
#line 17 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.EditorFor(e => e.Peso, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Altura</label>\r\n                    ");
#nullable restore
#line 21 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.EditorFor(e => e.Altura, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Tipo Sanguíneo</label>\r\n                    ");
#nullable restore
#line 27 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Tip_Sanguineo, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Convenio - Numero da carteirinha</label>\r\n                    ");
#nullable restore
#line 31 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Convenio, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Pediatra - Contato</label>\r\n                    ");
#nullable restore
#line 37 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Nome_Pediatra_Contato, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Em caso de ocorrência médica ligar para ?</label>\r\n                    ");
#nullable restore
#line 41 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.OcorrenciaMedica, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <hr />\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 47 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Nadar, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Sabe nadar com desenvoltura?</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 51 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Boia, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Deverá usar Boia?</label>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 57 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Dramin, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Autorizado a receber tratamento com DRAMIN</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 61 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Vonal, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Autorizado a receber tratamento com VONAU.</label>
                </div>
            </div>

            <div class=""row"">
                <div class=""form-group col-md-6 align-self-center"">
                    ");
#nullable restore
#line 68 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Diabetes, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Tem Diabetes Mellitus</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 72 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Convulsao, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Tem Convulsões</label>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 78 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Asma, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Tem Asma</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 82 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Bronquite, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Tem Bronquite</label>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 88 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Infeccao_Recente, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Nos últimos dois meses teve algum tipo de infecção?</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 92 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Enurese_Noturna, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Apresenta perda de urina durante a noite?</label>
                </div>
            </div>
            <div class=""row"">
                <div class=""form-group col-md-6 align-self-center"">
                    ");
#nullable restore
#line 98 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Sonambulismo, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Tem sonambulismo?</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 102 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Vacinas_Validas, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Tem todas as vacinas válidas?</label>
                </div>
            </div>

            <div class=""row"">
                <div class=""form-group col-md-6 align-self-center"">
                    ");
#nullable restore
#line 109 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.BelicheInferior, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Faz questão do beliche inferior?</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 113 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Aparelho_Dental, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Faz uso de aparelho ortodôntico móvel?</label>
                </div>
            </div>
            <hr />
            <div class=""row"">
                <div class=""form-group col-md-6"">
                    ");
#nullable restore
#line 120 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Acomp_Psicologico, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Faz ou fez acompanhamento médico ou psicológico?</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Motivo do acompanhamento psicologico?</label>
                    ");
#nullable restore
#line 125 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Motivo_Acomp_Psicologico, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 130 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.H1N1, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Tomou a vacina Influenza H1N1?</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Em caso positivo anotar a data da imunização.</label>
                    ");
#nullable restore
#line 135 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.EditorFor(e => e.Dat_H1N1, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 140 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.MenigiteC, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Tomou a vacina Meningite C?</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Em caso positivo anotar a data da imunização.</label>
                    ");
#nullable restore
#line 145 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.EditorFor(e => e.Dat_MenigiteC, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 150 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.RestricaoAttFisica, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Tem restrição à prática de atividade física?</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Em caso positivo favor nos informar.</label>
                    ");
#nullable restore
#line 155 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Obs_RestricaoAttFisica, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 160 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Alergia_Medicamento, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Algum tipo de alergia ao uso de algum medicamento?</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Em caso positivo favor nos informar.</label>
                    ");
#nullable restore
#line 165 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Obs_Alergia_Medicamento, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 170 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Necessidade_Especial, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">O acampante apresenta alguma necessidade especial?</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Em caso positivo favor nos informar.</label>
                    ");
#nullable restore
#line 175 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Obs_Necessidade_Especial, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 180 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Restricao_Alimentar, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Tem alguma restrição alimentar?</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Em caso positivo favor nos informar.</label>
                    ");
#nullable restore
#line 185 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Obs_Restricao_Alimentar, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 190 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Medo_Fobia, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">O acampante tem algum tipo de medo ou fobia?</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Em caso positivo favor nos informar.</label>
                    ");
#nullable restore
#line 195 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Obs_Medo_Fobia, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
            <hr />
            <div class=""row"">
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Alguma observação que deseja acrescentar ?</label>
                    ");
#nullable restore
#line 202 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Obs_Geral, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Como deve ser medicado em caso de Dor de garganta?</label>\r\n                    ");
#nullable restore
#line 206 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Orientacao_Garganta, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Como deve ser medicado em caso de Febre?</label>\r\n                    ");
#nullable restore
#line 212 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Orientacao_Febre, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Como deve ser medicado em caso de Dor de barriga?</label>\r\n                    ");
#nullable restore
#line 216 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Orientacao_Barriga, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
            <div class=""row"">
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Como deve ser medicado em caso de Dor de cabeça?</label>
                    ");
#nullable restore
#line 222 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Orientacao_Cabeca, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Como deve ser medicado em caso de Dor de ouvido?</label>\r\n                    ");
#nullable restore
#line 226 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Orientacao_Ouvido, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Como deve ser medicado em caso de Cólicas?</label>\r\n                    ");
#nullable restore
#line 232 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Orientacao_Colica, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Finalizar\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        $(document).ready(function () {\r\n            $(\"#Peso\").mask(\"##99.99\", {reverse:true});\r\n            $(\"#Altura\").mask(\"9.99\");\r\n        });\r\n    </script>\r\n");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ficha> Html { get; private set; }
    }
}
#pragma warning restore 1591
