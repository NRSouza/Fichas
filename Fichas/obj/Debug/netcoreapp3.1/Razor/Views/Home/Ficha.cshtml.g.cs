#pragma checksum "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c2007d088473cd0a53fd3fa8075ca881991d827"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c2007d088473cd0a53fd3fa8075ca881991d827", @"/Views/Home/Ficha.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2c2007d088473cd0a53fd3fa8075ca881991d8274337", async() => {
                WriteLiteral("\r\n            <div class=\"text-center\">\r\n                <h5 style=\"color:green\">");
#nullable restore
#line 14 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
                                   Write(ViewBag.ok);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                <h5 style=\"color:red\">");
#nullable restore
#line 15 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
                                 Write(ViewBag.error);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            </div>\r\n            <div class=\"row\">\r\n            <div class=\"form-group col-md-6\">\r\n                <label class=\"col-form-label-lg\">Peso do acampante(kg)</label>\r\n                ");
#nullable restore
#line 20 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
           Write(Html.EditorFor(e => e.Peso, new { htmlAttributes = new { @class = "form-control", @placeholder = "(kg)" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <div class=\"form-group col-md-6\">\r\n                <label class=\"col-form-label-lg\">Altura do acampante</label>\r\n                ");
#nullable restore
#line 24 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
           Write(Html.EditorFor(e => e.Altura, new { htmlAttributes = new { @class = "form-control", @placeholder = "(m)" } }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Tipo Sanguíneo</label>\r\n                    ");
#nullable restore
#line 30 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Tip_Sanguineo, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Convênio Médico e número da carteirinha</label>\r\n                    ");
#nullable restore
#line 34 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Convenio, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Nome do Pediatra - Telefone de contato</label>\r\n                    ");
#nullable restore
#line 40 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Nome_Pediatra_Contato, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Em caso de ocorrência médica ligar para</label>\r\n                    ");
#nullable restore
#line 44 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 54 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Nadar, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Sabe nadar com desenvoltura.</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 58 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Boia, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Deverá usar boia.</label>\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 64 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Dramin, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Autorizado a receber tratamento com DRAMIN.</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 68 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 74 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Infeccao_Recente, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Nos últimos dois meses teve algum tipo de infecção.</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 78 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 84 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Sonambulismo, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Tem sonambulismo.</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 88 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 95 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.BelicheInferior, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Faz questão do beliche inferior.</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 99 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 105 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 110 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Tratamento_Diabetes, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 115 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 120 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Tratamento_Convulsao, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 125 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 130 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Tratamento_Asma, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 135 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 140 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Tratamento_Bronquite, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 145 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 150 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Motivo_Acomp_Psicologico, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 155 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 160 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Dat_H1N1, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 165 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 170 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Dat_MenigiteC, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6 align-self-center\">\r\n                    ");
#nullable restore
#line 175 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.CheckBoxFor(e => e.Covid, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    <label class=\"col-form-label-lg\">Teve COVID-19</label>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Informar a data.</label>\r\n                    ");
#nullable restore
#line 180 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextBoxFor(e => e.Dat_Covid, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 185 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 190 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Obs_RestricaoAttFisica, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 195 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 200 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Obs_Restricao_Alimentar, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    ");
#nullable restore
#line 205 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 210 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 216 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.DropDownListFor(e => e.Alergia_Medicamento, new SelectList(Enum.GetValues(typeof(Ficha.Talvez))), "Selecione", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Em caso positivo favor nos informar.</label>\r\n                    ");
#nullable restore
#line 220 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 226 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.DropDownListFor(e => e.Necessidade_Especial, new SelectList(Enum.GetValues(typeof(Ficha.Selecione))), "Selecione", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Em caso positivo favor nos informar.</label>\r\n                    ");
#nullable restore
#line 230 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 239 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
                            Write(Html.CheckBoxFor(e => e.Alopatia, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        HOMEOPATIA ");
#nullable restore
#line 240 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
                              Write(Html.CheckBoxFor(e => e.Homeopatia, new { @class = "form-check-label" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Como costuma ser medicado em caso de dor de garganta?</label>\r\n                    ");
#nullable restore
#line 245 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Orientacao_Garganta, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Como costuma ser medicado em caso de febre?</label>\r\n                    ");
#nullable restore
#line 251 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Orientacao_Febre, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Como costuma ser medicado em caso de dor de barriga?</label>\r\n                    ");
#nullable restore
#line 255 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 261 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Orientacao_Cabeca, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Como costuma ser medicado em caso de dor de ouvido?</label>\r\n                    ");
#nullable restore
#line 265 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
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
#line 271 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Orientacao_Colica, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <label class=\"col-form-label-lg\">Alguma observação que deseje acrescentar ?</label>\r\n                    ");
#nullable restore
#line 275 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
               Write(Html.TextAreaFor(e => e.Obs_Geral, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"row\" style=\"display:none\">\r\n                <div class=\"form-group col-md-6\">\r\n                    <input type=\"text\" name=\"acampID\" id=\"acampID\"");
                BeginWriteAttribute("value", " value=\"", 16296, "\"", 16321, 1);
#nullable restore
#line 280 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
WriteAttributeValue("", 16304, ViewBag.acamp.ID, 16304, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"form-group col-md-6\">\r\n                    <input type=\"text\" name=\"respID\" id=\"respID\"");
                BeginWriteAttribute("value", " value=\"", 16466, "\"", 16490, 1);
#nullable restore
#line 283 "C:\Users\leuel\source\repos\Fichas\Fichas\Views\Home\Ficha.cshtml"
WriteAttributeValue("", 16474, ViewBag.resp.ID, 16474, 16, false);

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
            $('#Dat_Covid').mask('00/00/0000');
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
                $(""#Tratamento_Convulsao"").prop('readonly', fa");
                WriteLiteral(@"lse);
            } else {
                $(""#Tratamento_Convulsao"").prop('readonly', true);
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
