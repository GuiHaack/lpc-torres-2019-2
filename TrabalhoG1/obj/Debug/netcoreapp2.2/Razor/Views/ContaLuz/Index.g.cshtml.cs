#pragma checksum "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a5699dec89cbca522fae6d6f39448d43f7a40032"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContaLuz_Index), @"mvc.1.0.view", @"/Views/ContaLuz/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ContaLuz/Index.cshtml", typeof(AspNetCore.Views_ContaLuz_Index))]
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
#line 1 "C:\Users\rober\Desktop\TrabalhoG1\Views\_ViewImports.cshtml"
using TrabalhoG1;

#line default
#line hidden
#line 2 "C:\Users\rober\Desktop\TrabalhoG1\Views\_ViewImports.cshtml"
using TrabalhoG1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5699dec89cbca522fae6d6f39448d43f7a40032", @"/Views/ContaLuz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618f78d8596c9d3f35ee661d34f27a42aac3a362", @"/Views/_ViewImports.cshtml")]
    public class Views_ContaLuz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrabalhoG1.ViewsModels.ContaLuzViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ContaLuz", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
  
    ViewData["Title"] = "Contas de Luz";

#line default
#line hidden
            BeginContext(96, 68, true);
            WriteLiteral("\n<h2 class=\"text-left\">Contas de Luz</h2>\n<p class=\"text-left\">\n    ");
            EndContext();
            BeginContext(165, 95, false);
#line 9 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
Write(Html.ActionLink("Adicionar Conta de Luz", "Create", new {}, new { @class = "btn btn-success" }));

#line default
#line hidden
            EndContext();
            BeginContext(260, 352, true);
            WriteLiteral(@"
</p>
<table class=""table table-hover table-striped text-center"">
    <thead>
        <tr>
            <th>ID</th>
            <th>Data Leitura</th>
            <th>KW Gasto</th>
            <th>Valor a pagar</th>
            <th>Data Pagamento</th>
            <th>Média Consumo</th>
            <th>Ações</th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 25 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
         foreach (var item in Model.listaContasLuz)
        {

#line default
#line hidden
            BeginContext(674, 37, true);
            WriteLiteral("            <tr>\n                <th>");
            EndContext();
            BeginContext(712, 7, false);
#line 28 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
               Write(item.id);

#line default
#line hidden
            EndContext();
            BeginContext(719, 26, true);
            WriteLiteral("</th>\n                <td>");
            EndContext();
            BeginContext(746, 39, false);
#line 29 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
               Write(item.dataLeitura.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(785, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(812, 12, false);
#line 30 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
               Write(item.kwGasto);

#line default
#line hidden
            EndContext();
            BeginContext(824, 29, true);
            WriteLiteral("</td>\n                <td>R$ ");
            EndContext();
            BeginContext(854, 16, false);
#line 31 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
                  Write(item.valorAPagar);

#line default
#line hidden
            EndContext();
            BeginContext(870, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(897, 41, false);
#line 32 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
               Write(item.dataPagamento.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(938, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(965, 17, false);
#line 33 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
               Write(item.mediaConsumo);

#line default
#line hidden
            EndContext();
            BeginContext(982, 145, true);
            WriteLiteral("</td>\n                <td class=\"text-center\">\n                    <div class=\"btn-group\" role=\"group\" aria-label=\"actions\">\n                    ");
            EndContext();
            BeginContext(1127, 205, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5699dec89cbca522fae6d6f39448d43f7a400328025", async() => {
                BeginContext(1301, 27, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 39 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
                          WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1332, 22, true);
            WriteLiteral("\n\n                    ");
            EndContext();
            BeginContext(1354, 210, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5699dec89cbca522fae6d6f39448d43f7a4003210657", async() => {
                BeginContext(1528, 32, true);
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
                          WriteLiteral(item.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1564, 72, true);
            WriteLiteral("\n                        </div>\n                </td>\n            </tr>\n");
            EndContext();
#line 48 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1646, 353, true);
            WriteLiteral(@"    </tbody>
</table>
<h3 class=""my-4"">Menor Consumo</h3>
<table class=""table table-hover table-striped text-center"">
    <thead>
        <tr>
            <th>Data Leitura</th>
            <th>KW Gasto</th>
            <th>Valor a pagar</th>
            <th>Data Pagamento</th>
            <th>Média Consumo</th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 64 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
         if (Model.listaContasLuz.Any())
        {

#line default
#line hidden
            BeginContext(2050, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(2080, 53, false);
#line 67 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
           Write(Model.menorConsumo.dataLeitura.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2133, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(2156, 26, false);
#line 68 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
           Write(Model.menorConsumo.kwGasto);

#line default
#line hidden
            EndContext();
            BeginContext(2182, 25, true);
            WriteLiteral("</td>\n            <td>R$ ");
            EndContext();
            BeginContext(2208, 30, false);
#line 69 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
              Write(Model.menorConsumo.valorAPagar);

#line default
#line hidden
            EndContext();
            BeginContext(2238, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(2261, 55, false);
#line 70 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
           Write(Model.menorConsumo.dataPagamento.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2316, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(2339, 31, false);
#line 71 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
           Write(Model.menorConsumo.mediaConsumo);

#line default
#line hidden
            EndContext();
            BeginContext(2370, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 73 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2400, 353, true);
            WriteLiteral(@"    </tbody>
</table>
<h3 class=""my-4"">Maior Consumo</h3>
<table class=""table table-hover table-striped text-center"">
    <thead>
        <tr>
            <th>Data Leitura</th>
            <th>KW Gasto</th>
            <th>Valor a pagar</th>
            <th>Data Pagamento</th>
            <th>Média Consumo</th>
        </tr>
    </thead>

    <tbody>
");
            EndContext();
#line 89 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
         if (Model.listaContasLuz.Any())
        {

#line default
#line hidden
            BeginContext(2804, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(2834, 53, false);
#line 92 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
           Write(Model.maiorConsumo.dataLeitura.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(2887, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(2910, 26, false);
#line 93 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
           Write(Model.maiorConsumo.kwGasto);

#line default
#line hidden
            EndContext();
            BeginContext(2936, 25, true);
            WriteLiteral("</td>\n            <td>R$ ");
            EndContext();
            BeginContext(2962, 30, false);
#line 94 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
              Write(Model.maiorConsumo.valorAPagar);

#line default
#line hidden
            EndContext();
            BeginContext(2992, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(3015, 55, false);
#line 95 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
           Write(Model.maiorConsumo.dataPagamento.ToString("dd/MM/yyyy"));

#line default
#line hidden
            EndContext();
            BeginContext(3070, 22, true);
            WriteLiteral("</td>\n            <td>");
            EndContext();
            BeginContext(3093, 31, false);
#line 96 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
           Write(Model.maiorConsumo.mediaConsumo);

#line default
#line hidden
            EndContext();
            BeginContext(3124, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 98 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(3154, 21, true);
            WriteLiteral("    </tbody>\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrabalhoG1.ViewsModels.ContaLuzViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591