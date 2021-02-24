#pragma checksum "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17b844b88151ce3cb269edbea13de2dbe4636a92"
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
#line 1 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\_ViewImports.cshtml"
using Fichas;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\_ViewImports.cshtml"
using Fichas.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17b844b88151ce3cb269edbea13de2dbe4636a92", @"/Views/Home/Ficha.cshtml")]
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
#line 2 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
  
    ViewData["Title"] = "Ficha";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\">\r\n    <div class=\"text-center\">\r\n        <h1 class=\"display-4\">FICHA DE SAÚDE</h1>\r\n        <hr />\r\n        <h3>Olá ");
#nullable restore
#line 9 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
           Write(ViewBag.resp.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("  - Ficha de ");
#nullable restore
#line 9 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
                                          Write(ViewBag.acamp.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    </div>\r\n    <div class=\"container\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "17b844b88151ce3cb269edbea13de2dbe4636a924325", async() => {
                WriteLiteral("\r\n            <h5>");
#nullable restore
#line 13 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
           Write(ViewBag.erro);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Peso do acampante(kg)</label>\r\n                    ");
#nullable restore
#line 17 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.EditorFor(e => e.Peso, new { htmlAttributes = new { @class = "form-control", @placeholder = "(kg)" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Altura do acampante</label>\r\n                    ");
#nullable restore
#line 21 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.EditorFor(e => e.Altura,  new { htmlAttributes = new { @class = "form-control", @placeholder = "(m)" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Tipo Sanguíneo</label>\r\n                    ");
#nullable restore
#line 27 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Tip_Sanguineo, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Convênio Médico e número da carteirinha</label>\r\n                    ");
#nullable restore
#line 31 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Convenio, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Nome do Pediatra - Telefone de contato</label>\r\n                    ");
#nullable restore
#line 37 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Nome_Pediatra_Contato, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Em caso de ocorrência médica ligar para</label>\r\n                    ");
#nullable restore
#line 41 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.OcorrenciaMedica, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
            <hr />
            <div class=""text-center"">
                <h3>Assinale os itens que se aplicam ao acampante.</h3>
            </div>
            <hr />
            <div class=""row"">
                <div class=""form-group col-md-6 align-self-center"">
                    ");
#nullable restore
#line 51 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Nadar, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Sabe nadar com desenvoltura.</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 55 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Boia, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Deverá usar boia.</label>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 61 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Dramin, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Autorizado a receber tratamento com DRAMIN.</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 65 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 71 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Infeccao_Recente, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Nos últimos dois meses teve algum tipo de infecção.</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 75 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Enurese_Noturna, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Apresenta perda de urina durante a noite.</label>
                </div>
            </div>
            <div class=""row"">
                <div class=""form-group col-md-6 align-self-center"">
                    ");
#nullable restore
#line 81 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Sonambulismo, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Tem sonambulismo.</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 85 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Vacinas_Validas, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Tem todas as vacinas válidas.</label>
                </div>
            </div>

            <div class=""row"">
                <div class=""form-group col-md-6 align-self-center"">
                    ");
#nullable restore
#line 92 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.BelicheInferior, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Faz questão do beliche inferior.</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 96 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Aparelho_Dental, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Faz uso de aparelho ortodôntico móvel.</label>
                </div>
            </div>
            <div class=""row"">
                <div class=""form-group col-md-6 align-self-center"">
                    ");
#nullable restore
#line 102 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Diabetes, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Tem Diabetes Mellitus.</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Favor informar como é realizado o tratamento.</label>
                    ");
#nullable restore
#line 107 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Tratamento_Diabetes, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 112 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Convulsao, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Tem Convulsões.</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Favor informar como é realizado o tratamento.</label>
                    ");
#nullable restore
#line 117 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Tratamento_Convulsao, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 122 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Asma, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Tem Asma.</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Favor informar como é realizado o tratamento.</label>
                    ");
#nullable restore
#line 127 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Tratamento_Asma, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 132 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Bronquite, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Tem Bronquite.</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Favor informar como é realizado o tratamento.</label>
                    ");
#nullable restore
#line 137 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Tratamento_Bronquite, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 142 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Acomp_Psicologico, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Faz ou fez acompanhamento médico ou psicológico.</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Motivo do acompanhamento psicológico.</label>
                    ");
#nullable restore
#line 147 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Motivo_Acomp_Psicologico, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 152 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.H1N1, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Tomou a vacina Influenza H1N1.</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Informar a data da imunização.</label>
                    ");
#nullable restore
#line 157 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Dat_H1N1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 162 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.MenigiteC, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Tomou a vacina Meningite C.</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Informar a data da imunização.</label>
                    ");
#nullable restore
#line 167 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Dat_MenigiteC, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 172 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.MenigiteC, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Teve COVID-19</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Informar a data.</label>\r\n                    ");
#nullable restore
#line 177 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Dat_MenigiteC, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 182 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.RestricaoAttFisica, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Tem restrição à prática de atividade física.</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Informar qual a restrição e o motivo.</label>
                    ");
#nullable restore
#line 187 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Obs_RestricaoAttFisica, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 192 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Restricao_Alimentar, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Apresenta alguma restrição alimentar.</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Especifique.</label>
                    ");
#nullable restore
#line 197 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Obs_Restricao_Alimentar, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 202 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Medo_Fobia, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    <label class=""col-form-label-lg"">Apresenta algum tipo de medo ou fobia</label>
                </div>
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Especifique.</label>
                    ");
#nullable restore
#line 207 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Obs_Medo_Fobia, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
            <div class=""row"">
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Algum tipo de alergia ao uso de algum medicamento?</label>
                    ");
#nullable restore
#line 213 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.DropDownListFor(e => e.Necessidade_Especial, new SelectList(Enum.GetValues(typeof(Ficha.Talvez))), "Selecione", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Em caso positivo favor nos informar.</label>\r\n                    ");
#nullable restore
#line 217 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Obs_Alergia_Medicamento, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
            <div class=""row"">
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">O acampante apresenta alguma necessidade especial?</label>
                    ");
#nullable restore
#line 223 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.DropDownListFor(e => e.Necessidade_Especial, new SelectList(Enum.GetValues(typeof(Ficha.Selecione))), "Selecione", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Em caso positivo favor nos informar.</label>\r\n                    ");
#nullable restore
#line 227 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Obs_Necessidade_Especial, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                </div>
            </div>
            <hr />
            <div class=""row"">
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">O acampante trata-se preferencialmente com:</label>
                    <div class=""col-md-6"">
                        ALOPATIA ");
#nullable restore
#line 236 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
                            Write(Html.CheckBoxFor(e => e.Necessidade_Especial, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        HOMEOPATIA ");
#nullable restore
#line 237 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
                              Write(Html.CheckBoxFor(e => e.Necessidade_Especial, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Como costuma ser medicado em caso de dor de garganta?</label>\r\n                    ");
#nullable restore
#line 242 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Orientacao_Garganta, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Como costuma ser medicado em caso de febre?</label>\r\n                    ");
#nullable restore
#line 248 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Orientacao_Febre, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Como costuma ser medicado em caso de dor de barriga?</label>\r\n                    ");
#nullable restore
#line 252 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Orientacao_Barriga, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
            <div class=""row"">
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Como costuma ser medicado em caso de dor de cabeça?</label>
                    ");
#nullable restore
#line 258 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Orientacao_Cabeca, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Como costuma ser medicado em caso de dor de ouvido?</label>\r\n                    ");
#nullable restore
#line 262 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Orientacao_Ouvido, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                </div>
            </div>
            <div class=""row"">
                <div class=""form-group col-md-6"">
                    <label class=""col-form-label-lg"">Como costuma ser medicado em caso de cólicas?</label>
                    ");
#nullable restore
#line 268 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Orientacao_Colica, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Alguma observação que deseje acrescentar ?</label>\r\n                    ");
#nullable restore
#line 272 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Obs_Geral, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\" style=\"display:none\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <input type=\"text\" name=\"acampID\" id=\"acampID\"");
                BeginWriteAttribute("value", " value=\"", 16223, "\"", 16248, 1);
#nullable restore
#line 277 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
WriteAttributeValue("", 16231, ViewBag.acamp.ID, 16231, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <input type=\"text\" name=\"respID\" id=\"respID\"");
                BeginWriteAttribute("value", " value=\"", 16393, "\"", 16417, 1);
#nullable restore
#line 280 "C:\Users\Leu\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
WriteAttributeValue("", 16401, ViewBag.resp.ID, 16401, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n            </div>\r\n            <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Finalizar\" class=\"btn btn-primary\" />\r\n            </div>\r\n        ");
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
                WriteLiteral(@"
    <script>
        $(document).ready(function () {
            $(""#Peso"").mask(""##99.99"", {reverse:true});
            $(""#Altura"").mask(""9.99"");
            $('#Dat_H1N1').mask('00/00/0000');
            $('#Dat_MenigiteC').mask('00/00/0000');

        });
        $(""#Asma"").change(function () {
            if ($(""#Asma"").is(':checked')) {
                $(""#Tratamento_Asma"").prop('readonly', false);
            } else {
                $(""#Tratamento_Asma"").prop('readonly', true);
            }
        })
        $(""#Bronquite"").change(function () {
            if ($(""#Bronquite"").is(':checked')) {
                $(""#Tratamento_Bronquite"").prop('readonly', false);
            } else {
                $(""#Tratamento_Bronquite"").prop('readonly', true);
            }
        })
        $(""#Convulsao"").change(function () {
            if ($(""#Convulsao"").is(':checked')) {
                $(""#Tratamento_Convulsao"").prop('readonly', false);
            } else {
                $(""#");
                WriteLiteral(@"Tratamento_Convulsao"").prop('readonly', true);
            }
        })
        $(""#Diabetes"").change(function () {
            if ($(""#Diabetes"").is(':checked')) {
                $(""#Tratamento_Diabetes"").prop('readonly', false);
            } else {
                $(""#Tratamento_Diabetes"").prop('readonly', true);
            }
        })
    </script>
");
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
