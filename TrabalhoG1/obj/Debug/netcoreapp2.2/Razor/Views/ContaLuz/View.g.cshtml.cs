#pragma checksum "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "280d12864f7f05bcc7c800ee0a54b90c1013a3ff"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ContaLuz_View), @"mvc.1.0.view", @"/Views/ContaLuz/View.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ContaLuz/View.cshtml", typeof(AspNetCore.Views_ContaLuz_View))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"280d12864f7f05bcc7c800ee0a54b90c1013a3ff", @"/Views/ContaLuz/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"618f78d8596c9d3f35ee661d34f27a42aac3a362", @"/Views/_ViewImports.cshtml")]
    public class Views_ContaLuz_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TrabalhoG1.Models.ContaLuz>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\View.cshtml"
  
    ViewData["Title"] = "Contas de Luz";

#line default
#line hidden
            BeginContext(90, 205, true);
            WriteLiteral("\n<h2 class=\"text-center\">Contas de Luz</h2>\n\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n    <div class=\"editor-label\">\n        Data Leitura\n    </div>\n    <div class=\"editor-field\">\n        ");
            EndContext();
            BeginContext(296, 119, false);
#line 14 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\View.cshtml"
   Write(Html.EditorFor(model => model.dataLeitura, new { htmlAttributes = new { @class = "form-control", @disabled = "true"} }));

#line default
#line hidden
            EndContext();
            BeginContext(415, 45, true);
            WriteLiteral("\n        <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(461, 53, false);
#line 15 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.dataLeitura));

#line default
#line hidden
            EndContext();
            BeginContext(514, 184, true);
            WriteLiteral("</small>\n    </div>\n</div>\n\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n    <div class=\"editor-label\">\n        KW Gasto\n    </div>\n    <div class=\"editor-field\">\n        ");
            EndContext();
            BeginContext(699, 115, false);
#line 24 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\View.cshtml"
   Write(Html.EditorFor(model => model.kwGasto, new { htmlAttributes = new { @class = "form-control", @disabled = "true"} }));

#line default
#line hidden
            EndContext();
            BeginContext(814, 45, true);
            WriteLiteral("\n        <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(860, 49, false);
#line 25 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.kwGasto));

#line default
#line hidden
            EndContext();
            BeginContext(909, 189, true);
            WriteLiteral("</small>\n    </div>\n</div>\n\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n    <div class=\"editor-label\">\n        Valor a pagar\n    </div>\n    <div class=\"editor-field\">\n        ");
            EndContext();
            BeginContext(1099, 119, false);
#line 34 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\View.cshtml"
   Write(Html.EditorFor(model => model.valorAPagar, new { htmlAttributes = new { @class = "form-control", @disabled = "true"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1218, 45, true);
            WriteLiteral("\n        <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1264, 53, false);
#line 35 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.valorAPagar));

#line default
#line hidden
            EndContext();
            BeginContext(1317, 190, true);
            WriteLiteral("</small>\n    </div>\n</div>\n\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n    <div class=\"editor-label\">\n        Data Pagamento\n    </div>\n    <div class=\"editor-field\">\n        ");
            EndContext();
            BeginContext(1508, 121, false);
#line 44 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\View.cshtml"
   Write(Html.EditorFor(model => model.dataPagamento, new { htmlAttributes = new { @class = "form-control", @disabled = "true"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1629, 45, true);
            WriteLiteral("\n        <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1675, 55, false);
#line 45 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.dataPagamento));

#line default
#line hidden
            EndContext();
            BeginContext(1730, 192, true);
            WriteLiteral("</small>\n    </div>\n</div>\n\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\n    <div class=\"editor-label\">\n        Média de Consumo\n    </div>\n    <div class=\"editor-field\">\n        ");
            EndContext();
            BeginContext(1923, 120, false);
#line 54 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\View.cshtml"
   Write(Html.EditorFor(model => model.mediaConsumo, new { htmlAttributes = new { @class = "form-control", @disabled = "true"} }));

#line default
#line hidden
            EndContext();
            BeginContext(2043, 45, true);
            WriteLiteral("\n        <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(2089, 54, false);
#line 55 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.mediaConsumo));

#line default
#line hidden
            EndContext();
            BeginContext(2143, 66, true);
            WriteLiteral("</small>\n    </div>\n</div>\n\n<div class=\"d-block text-center\">\n    ");
            EndContext();
            BeginContext(2210, 98, false);
#line 60 "C:\Users\rober\Desktop\TrabalhoG1\Views\ContaLuz\View.cshtml"
Write(Html.ActionLink("Voltar para listagem", "Index", null, null, new { @class = "mt-4 btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(2308, 7, true);
            WriteLiteral("\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TrabalhoG1.Models.ContaLuz> Html { get; private set; }
    }
}
#pragma warning restore 1591
