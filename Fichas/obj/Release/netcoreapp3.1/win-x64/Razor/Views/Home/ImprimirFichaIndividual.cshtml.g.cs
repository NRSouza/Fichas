#pragma checksum "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9208446567ad3f3ce830deaa703985d0e5bf123d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ImprimirFichaIndividual), @"mvc.1.0.view", @"/Views/Home/ImprimirFichaIndividual.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9208446567ad3f3ce830deaa703985d0e5bf123d", @"/Views/Home/ImprimirFichaIndividual.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f5b9e8418ae216a57354a789b18975e407f7dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ImprimirFichaIndividual : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ficha>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<style>
    div #printArea {
        display: inline-block;
        width: 100%;
        height: auto;
    }
</style>
<div class=""d-block d-print-block"">
        <div id=""printArea"">
            <p id=""inicio"" class=""text-justify"" style=""font-size:20px""><b>Nome:   ");
#nullable restore
#line 11 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                                                             Write(Model.Acampante.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></p>\r\n            <p class=\"text-justify\"><b>Equipe:   ");
#nullable restore
#line 12 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                            Write(Model.Acampante.Equipe);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - Cod:   ");
#nullable restore
#line 12 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                                                             Write(Model.Acampante.codAcampante);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                                                                                           Write(Model.Acampante.DesPacote);

#line default
#line hidden
#nullable disable
            WriteLiteral(" SEXO:    - Nasc:   ");
#nullable restore
#line 12 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                                                                                                                                         Write(Model.Acampante.DatNascto);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b></p>\r\n            <p style=\"font-size:18px;\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <b>Peso:  </b> ");
#nullable restore
#line 16 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  Write(Model.Peso);

#line default
#line hidden
#nullable disable
            WriteLiteral(" KG <br />\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <b>Altura:  </b> ");
#nullable restore
#line 19 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                    Write(Model.Altura);

#line default
#line hidden
#nullable disable
            WriteLiteral(" cm<br />\r\n                    </div>\r\n                </div>\r\n                <b>Ocorrencia Médica - ligar para:  </b> ");
#nullable restore
#line 22 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                                    Write(Model.OcorrenciaMedica);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <b>Tipo sanguíneo:  </b> ");
#nullable restore
#line 25 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                            Write(Model.Tip_Sanguineo);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <b>Convênio:  </b> ");
#nullable restore
#line 28 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                      Write(Model.Convenio);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n                <b>Contato pediatra:  </b> ");
#nullable restore
#line 31 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                      Write(Model.Nome_Pediatra_Contato);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <b>Sabe nadar :  </b> ");
#nullable restore
#line 34 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                               if (Model.Nadar == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 35 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 37 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <b>Usar boia :  </b> ");
#nullable restore
#line 40 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                              if (Model.Boia == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 41 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 43 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n\r\n                <b>Acompanhamento psicológico :   </b>");
#nullable restore
#line 47 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                                       if (Model.Acomp_Psicologico == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 48 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 50 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Motivo :   </b> ");
#nullable restore
#line 51 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                              Write(Model.Motivo_Acomp_Psicologico);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-4\">\r\n                        <b>Vacinas válidas :   </b>");
#nullable restore
#line 54 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                                    if (Model.Vacinas_Validas == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 55 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 57 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <b>Alopatia :   </b>");
#nullable restore
#line 60 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                             if (Model.Alopatia == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 61 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 63 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <b>Homeopatia :   </b>");
#nullable restore
#line 66 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                               if (Model.Homeopatia == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 67 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 69 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-4\">\r\n                        <b>H1N1 :   </b>");
#nullable restore
#line 75 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                         if (Model.H1N1 == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 76 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 78 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <b>Menigite C :   </b>");
#nullable restore
#line 81 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                               if (Model.MenigiteC == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 82 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 84 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-4\">\r\n                        <b>Covid :   </b>");
#nullable restore
#line 87 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          if (Model.Covid == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 88 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 90 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <b>Beliche inferior :   </b>");
#nullable restore
#line 96 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                                     if (Model.BelicheInferior == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 97 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 99 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <b>Aparelho dental :   </b>");
#nullable restore
#line 102 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                                    if (Model.Aparelho_Dental == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 103 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 105 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-6\">\r\n                        <b>Dramin :   </b>");
#nullable restore
#line 110 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                           if (Model.Dramin == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 111 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 113 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                    <div class=\"col-md-6\">\r\n                        <b>Vonal :   </b>");
#nullable restore
#line 116 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          if (Model.Vonal == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 117 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 119 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                    </div>\r\n                </div>\r\n                <hr />\r\n                <b>Orientação Febre :   </b> ");
#nullable restore
#line 123 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                        Write(Model.Orientacao_Febre);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Orientação Barriga :   </b> ");
#nullable restore
#line 124 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          Write(Model.Orientacao_Barriga);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Orientação Cabeça :   </b> ");
#nullable restore
#line 125 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                         Write(Model.Orientacao_Cabeca);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Orientação Ouvido :   </b> ");
#nullable restore
#line 126 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                         Write(Model.Orientacao_Ouvido);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Orientação Cólica :   </b> ");
#nullable restore
#line 127 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                         Write(Model.Orientacao_Colica);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Orientação Garganta :   </b> ");
#nullable restore
#line 128 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                           Write(Model.Orientacao_Garganta);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <hr />\r\n                <b>Diabetes  :   </b>");
#nullable restore
#line 130 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                      if (Model.Diabetes == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 131 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 133 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Tratamento Diabetes  :   </b> ");
#nullable restore
#line 134 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                            Write(Model.Tratamento_Diabetes);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Convulsão  :   </b>");
#nullable restore
#line 135 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                       if (Model.Convulsao == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 136 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 138 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Tratamento Convulsão  :   </b> ");
#nullable restore
#line 139 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                             Write(Model.Tratamento_Convulsao);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Asma  :   </b>");
#nullable restore
#line 140 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  if (Model.Asma == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 141 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 143 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Tratamento Asma  :  </b> ");
#nullable restore
#line 144 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                       Write(Model.Tratamento_Asma);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Bronquite  :   </b>");
#nullable restore
#line 145 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                       if (Model.Bronquite == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 146 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 148 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Tratamento Bronquite  :  </b> ");
#nullable restore
#line 149 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                            Write(Model.Tratamento_Bronquite);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Sonambulismo  :   </b>");
#nullable restore
#line 150 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                          if (Model.Sonambulismo == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 151 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 153 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Enurese noturna :   </b>");
#nullable restore
#line 154 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                            if (Model.Enurese_Noturna == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 155 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 157 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Restrição atividade fisica:   </b>");
#nullable restore
#line 158 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                                      if (Model.RestricaoAttFisica == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 159 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 161 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Obs :  </b> ");
#nullable restore
#line 162 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                          Write(Model.Obs_RestricaoAttFisica);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>**Alergia:   </b>");
#nullable restore
#line 163 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                     if (Model.Alergia_Medicamento == "Sim")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 164 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 166 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Obs :  </b> ");
#nullable restore
#line 167 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                          Write(Model.Obs_Alergia_Medicamento);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Necessidade especial:   </b>");
#nullable restore
#line 168 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                                if (Model.Necessidade_Especial == "Sim")
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 169 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 171 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Obs :  </b> ");
#nullable restore
#line 172 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                          Write(Model.Obs_Necessidade_Especial);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Restrição alimentar:   </b>");
#nullable restore
#line 173 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                               if (Model.Restricao_Alimentar == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 174 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 176 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Obs :  </b> ");
#nullable restore
#line 177 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                          Write(Model.Obs_Restricao_Alimentar);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Medo ou fobia:   </b>");
#nullable restore
#line 178 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                         if (Model.Medo_Fobia == true)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("<span>Sim</span> ");
#nullable restore
#line 179 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>Não</span>");
#nullable restore
#line 181 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Obs :  </b> ");
#nullable restore
#line 182 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                          Write(Model.Obs_Medo_Fobia);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <b>Observação Geral :  </b> ");
#nullable restore
#line 183 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Home\ImprimirFichaIndividual.cshtml"
                                       Write(Model.Obs_Geral);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n            </p>\r\n        </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ficha> Html { get; private set; }
    }
}
#pragma warning restore 1591
