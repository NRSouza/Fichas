#pragma checksum "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ae8a1ac312188084d78b1362668f459898bb5715"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_FichasPorPacote), @"mvc.1.0.view", @"/Views/Home/FichasPorPacote.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae8a1ac312188084d78b1362668f459898bb5715", @"/Views/Home/FichasPorPacote.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f5b9e8418ae216a57354a789b18975e407f7dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_FichasPorPacote : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ficha>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<style>\r\n    div #printArea {\r\n        display: inline-block;\r\n        width: 100%;\r\n        height: auto;\r\n    }\r\n</style>\r\n<div class=\"d-block d-print-block\">\r\n");
#nullable restore
#line 10 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div id=\"printArea\">\r\n            <p id=\"inicio\" class=\"text-justify\" style=\"font-size:20px\"><b>Nome:   ");
#nullable restore
#line 13 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                                                             Write(x.Acampante.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n            <p class=\"text-justify\"><b>Equipe:   ");
#nullable restore
#line 14 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                            Write(x.Acampante.Equipe);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Cod:   ");
#nullable restore
#line 14 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                                                         Write(x.Acampante.codAcampante);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                                                                                   Write(x.Acampante.DesPacote);

#line default
#line hidden
#nullable disable
            WriteLiteral(" SEXO:    - Nasc:   ");
#nullable restore
#line 14 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                                                                                                                             Write(x.Acampante.DatNascto);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b></p>\r\n            <p style=\"font-size:18px;\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <b>Peso:  </b> ");
#nullable restore
#line 18 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  Write(x.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral(" KG <br />\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <b>Altura:  </b> ");
#nullable restore
#line 21 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                    Write(x.Altura);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm<br />\r\n                    </div>\r\n                </div>\r\n                <b>Ocorrencia Médica - ligar para:  </b> ");
#nullable restore
#line 24 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                                    Write(x.OcorrenciaMedica);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <b>Tipo sanguíneo:  </b> ");
#nullable restore
#line 27 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                            Write(x.Tip_Sanguineo);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <b>Convênio:  </b> ");
#nullable restore
#line 30 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                      Write(x.Convenio);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n                <b>Contato pediatra:  </b> ");
#nullable restore
#line 33 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                      Write(x.Nome_Pediatra_Contato);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <b>Sabe nadar :  </b> ");
#nullable restore
#line 36 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                               if (x.Nadar == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 37 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 39 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <b>Usar boia :  </b> ");
#nullable restore
#line 42 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                              if (x.Boia == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 43 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 45 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n\r\n                <b>Acompanhamento psicológico :   </b>");
#nullable restore
#line 49 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                                       if (x.Acomp_Psicologico == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 50 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 52 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Motivo :   </b> ");
#nullable restore
#line 53 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                              Write(x.Motivo_Acomp_Psicologico);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-4\">\r\n                        <b>Vacinas válidas :   </b>");
#nullable restore
#line 56 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                                    if (x.Vacinas_Validas == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 57 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 59 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <b>Alopatia :   </b>");
#nullable restore
#line 62 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                             if (x.Alopatia == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 63 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 65 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <b>Homeopatia :   </b>");
#nullable restore
#line 68 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                               if (x.Homeopatia == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 69 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 71 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-4\">\r\n                        <b>H1N1 :   </b>");
#nullable restore
#line 77 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                         if (x.H1N1 == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 78 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 80 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <b>Menigite C :   </b>");
#nullable restore
#line 83 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                               if (x.MenigiteC == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 84 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 86 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <b>Covid :   </b>");
#nullable restore
#line 89 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          if (x.Covid == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 90 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 92 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <b>Beliche inferior :   </b>");
#nullable restore
#line 98 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                                     if (x.BelicheInferior == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 99 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 101 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <b>Aparelho dental :   </b>");
#nullable restore
#line 104 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                                    if (x.Aparelho_Dental == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 105 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 107 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <b>Dramin :   </b>");
#nullable restore
#line 112 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                           if (x.Dramin == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 113 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 115 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <b>Vonal :   </b>");
#nullable restore
#line 118 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          if (x.Vonal == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 119 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 121 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n                <b>Orientação Febre :   </b> ");
#nullable restore
#line 125 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                        Write(x.Orientacao_Febre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Orientação Barriga :   </b> ");
#nullable restore
#line 126 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                          Write(x.Orientacao_Barriga);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Orientação Cabeça :   </b> ");
#nullable restore
#line 127 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                         Write(x.Orientacao_Cabeca);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Orientação Ouvido :   </b> ");
#nullable restore
#line 128 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                         Write(x.Orientacao_Ouvido);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Orientação Cólica :   </b> ");
#nullable restore
#line 129 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                         Write(x.Orientacao_Colica);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Orientação Garganta :   </b> ");
#nullable restore
#line 130 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                           Write(x.Orientacao_Garganta);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <hr />\r\n                <b>Diabetes :   </b>");
#nullable restore
#line 132 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                     if (x.Diabetes == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 133 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 135 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Tratamento Diabetes :   </b> ");
#nullable restore
#line 136 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                           Write(x.Tratamento_Diabetes);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Convulsão :   </b>");
#nullable restore
#line 137 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                      if (x.Convulsao == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 138 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 140 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Tratamento Convulsão :   </b> ");
#nullable restore
#line 141 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                            Write(x.Tratamento_Convulsao);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Asma :   </b>");
#nullable restore
#line 142 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                 if (x.Asma == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 143 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 145 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Tratamento Asma :  </b> ");
#nullable restore
#line 146 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                      Write(x.Tratamento_Asma);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Bronquite :   </b>");
#nullable restore
#line 147 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                      if (x.Bronquite == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 148 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 150 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Tratamento Bronquite :  </b> ");
#nullable restore
#line 151 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                           Write(x.Tratamento_Bronquite);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Sonambulismo :   </b>");
#nullable restore
#line 152 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                         if (x.Sonambulismo == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 153 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 155 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Enurese noturna :   </b>");
#nullable restore
#line 156 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                            if (x.Enurese_Noturna == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 157 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 159 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Restrição atividade fisica:   </b>");
#nullable restore
#line 160 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                                      if (x.RestricaoAttFisica == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 161 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 163 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Obs :  </b> ");
#nullable restore
#line 164 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                          Write(x.Obs_RestricaoAttFisica);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>**Alergia:   </b>");
#nullable restore
#line 165 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                     if (x.Alergia_Medicamento == "Sim")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 166 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 168 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Obs :  </b> ");
#nullable restore
#line 169 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                          Write(x.Obs_Alergia_Medicamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Necessidade especial:   </b>");
#nullable restore
#line 170 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                                if (x.Necessidade_Especial == "Sim")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 171 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 173 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Obs :  </b> ");
#nullable restore
#line 174 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                          Write(x.Obs_Necessidade_Especial);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Restrição alimentar:   </b>");
#nullable restore
#line 175 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                               if (x.Restricao_Alimentar == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 176 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 178 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Obs :  </b> ");
#nullable restore
#line 179 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                          Write(x.Obs_Restricao_Alimentar);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Medo ou fobia:   </b>");
#nullable restore
#line 180 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                         if (x.Medo_Fobia == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 181 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 183 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Obs :  </b> ");
#nullable restore
#line 184 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                          Write(x.Obs_Medo_Fobia);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Observação Geral :  </b> ");
#nullable restore
#line 185 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
                                       Write(x.Obs_Geral);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            </p>\r\n        </div>\r\n");
#nullable restore
#line 188 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\FichasPorPacote.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ficha>> Html { get; private set; }
    }
}
#pragma warning restore 1591
