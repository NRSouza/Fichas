#pragma checksum "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Message\InboxTerceiros.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7d9ec0fe9b5dca2f401b721c7f450ac04bd1017"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Message_InboxTerceiros), @"mvc.1.0.view", @"/Views/Message/InboxTerceiros.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7d9ec0fe9b5dca2f401b721c7f450ac04bd1017", @"/Views/Message/InboxTerceiros.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37f5b9e8418ae216a57354a789b18975e407f7dc", @"/Views/_ViewImports.cshtml")]
    public class Views_Message_InboxTerceiros : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Fichas.ViewModel.MensagensDoTerceiro>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "IndexTerceiros", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VisualizaMsg", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Message\InboxTerceiros.cshtml"
  
    ViewData["Title"] = "Inbox";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">");
#nullable restore
#line 7 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Message\InboxTerceiros.cshtml"
                     Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d9ec0fe9b5dca2f401b721c7f450ac04bd10174622", async() => {
                WriteLiteral("Voltar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</div>
<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">De</th>
            <th scope=""col"">Para</th>
            <th scope=""col"">Data de envio</th>
            <th scope=""col"">Visualizar</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Message\InboxTerceiros.cshtml"
         foreach (var x in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td><b>");
#nullable restore
#line 25 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Message\InboxTerceiros.cshtml"
                  Write(x.From.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                <td><b>");
#nullable restore
#line 26 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Message\InboxTerceiros.cshtml"
                  Write(x.To.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Message\InboxTerceiros.cshtml"
               Write(x.CreateAt.Day);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 27 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Message\InboxTerceiros.cshtml"
                               Write(x.CreateAt.Month);

#line default
#line hidden
#nullable disable
            WriteLiteral("/");
#nullable restore
#line 27 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Message\InboxTerceiros.cshtml"
                                                 Write(x.CreateAt.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 27 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Message\InboxTerceiros.cshtml"
                                                                    Write(x.CreateAt.Hour);

#line default
#line hidden
#nullable disable
            WriteLiteral(":");
#nullable restore
#line 27 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Message\InboxTerceiros.cshtml"
                                                                                     Write(x.CreateAt.Minute);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d7d9ec0fe9b5dca2f401b721c7f450ac04bd10178326", async() => {
                WriteLiteral("Visualizar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-MessageId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Message\InboxTerceiros.cshtml"
                                                                                  WriteLiteral(x.MessageId.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MessageId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-MessageId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["MessageId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\leuel\source\repos\FichasPRD\Fichas\Views\Message\InboxTerceiros.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Fichas.ViewModel.MensagensDoTerceiro>> Html { get; private set; }
    }
}
#pragma warning restore 1591
