#pragma checksum "C:\Users\rober\Desktop\CrudContaRefatorada\ToDoList.MVC\Views\ContaLuz\View.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2927aaaceed342e3fb925a299c87d93a9aef6b0b"
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
#line 1 "C:\Users\rober\Desktop\CrudContaRefatorada\ToDoList.MVC\Views\_ViewImports.cshtml"
using ToDoList.MVC;

#line default
#line hidden
#line 2 "C:\Users\rober\Desktop\CrudContaRefatorada\ToDoList.MVC\Views\_ViewImports.cshtml"
using ToDoList.MVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2927aaaceed342e3fb925a299c87d93a9aef6b0b", @"/Views/ContaLuz/View.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c36d4c0be2e4f40a96807888a0ffefd5088f6501", @"/Views/_ViewImports.cshtml")]
    public class Views_ContaLuz_View : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoList.classes.ContaLuz>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\rober\Desktop\CrudContaRefatorada\ToDoList.MVC\Views\ContaLuz\View.cshtml"
  
    ViewData["Title"] = "Contas de Luz";

#line default
#line hidden
            BeginContext(86, 213, true);
            WriteLiteral("\r\n<h2 class=\"text-center\">Contas de Luz</h2>\r\n\r\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n    <div class=\"editor-label\">\r\n        Data Leitura\r\n    </div>\r\n    <div class=\"editor-field\">\r\n        ");
            EndContext();
            BeginContext(300, 119, false);
#line 14 "C:\Users\rober\Desktop\CrudContaRefatorada\ToDoList.MVC\Views\ContaLuz\View.cshtml"
   Write(Html.EditorFor(model => model.dataLeitura, new { htmlAttributes = new { @class = "form-control", @disabled = "true"} }));

#line default
#line hidden
            EndContext();
            BeginContext(419, 46, true);
            WriteLiteral("\r\n        <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(466, 53, false);
#line 15 "C:\Users\rober\Desktop\CrudContaRefatorada\ToDoList.MVC\Views\ContaLuz\View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.dataLeitura));

#line default
#line hidden
            EndContext();
            BeginContext(519, 193, true);
            WriteLiteral("</small>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n    <div class=\"editor-label\">\r\n        KW Gasto\r\n    </div>\r\n    <div class=\"editor-field\">\r\n        ");
            EndContext();
            BeginContext(713, 115, false);
#line 24 "C:\Users\rober\Desktop\CrudContaRefatorada\ToDoList.MVC\Views\ContaLuz\View.cshtml"
   Write(Html.EditorFor(model => model.kwGasto, new { htmlAttributes = new { @class = "form-control", @disabled = "true"} }));

#line default
#line hidden
            EndContext();
            BeginContext(828, 46, true);
            WriteLiteral("\r\n        <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(875, 49, false);
#line 25 "C:\Users\rober\Desktop\CrudContaRefatorada\ToDoList.MVC\Views\ContaLuz\View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.kwGasto));

#line default
#line hidden
            EndContext();
            BeginContext(924, 198, true);
            WriteLiteral("</small>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n    <div class=\"editor-label\">\r\n        Valor a pagar\r\n    </div>\r\n    <div class=\"editor-field\">\r\n        ");
            EndContext();
            BeginContext(1123, 119, false);
#line 34 "C:\Users\rober\Desktop\CrudContaRefatorada\ToDoList.MVC\Views\ContaLuz\View.cshtml"
   Write(Html.EditorFor(model => model.valorAPagar, new { htmlAttributes = new { @class = "form-control", @disabled = "true"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1242, 46, true);
            WriteLiteral("\r\n        <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1289, 53, false);
#line 35 "C:\Users\rober\Desktop\CrudContaRefatorada\ToDoList.MVC\Views\ContaLuz\View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.valorAPagar));

#line default
#line hidden
            EndContext();
            BeginContext(1342, 199, true);
            WriteLiteral("</small>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n    <div class=\"editor-label\">\r\n        Data Pagamento\r\n    </div>\r\n    <div class=\"editor-field\">\r\n        ");
            EndContext();
            BeginContext(1542, 121, false);
#line 44 "C:\Users\rober\Desktop\CrudContaRefatorada\ToDoList.MVC\Views\ContaLuz\View.cshtml"
   Write(Html.EditorFor(model => model.dataPagamento, new { htmlAttributes = new { @class = "form-control", @disabled = "true"} }));

#line default
#line hidden
            EndContext();
            BeginContext(1663, 46, true);
            WriteLiteral("\r\n        <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(1710, 55, false);
#line 45 "C:\Users\rober\Desktop\CrudContaRefatorada\ToDoList.MVC\Views\ContaLuz\View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.dataPagamento));

#line default
#line hidden
            EndContext();
            BeginContext(1765, 201, true);
            WriteLiteral("</small>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"form-group col-12 col-sm-8 col-md-6 mx-auto\">\r\n    <div class=\"editor-label\">\r\n        Média de Consumo\r\n    </div>\r\n    <div class=\"editor-field\">\r\n        ");
            EndContext();
            BeginContext(1967, 120, false);
#line 54 "C:\Users\rober\Desktop\CrudContaRefatorada\ToDoList.MVC\Views\ContaLuz\View.cshtml"
   Write(Html.EditorFor(model => model.mediaConsumo, new { htmlAttributes = new { @class = "form-control", @disabled = "true"} }));

#line default
#line hidden
            EndContext();
            BeginContext(2087, 46, true);
            WriteLiteral("\r\n        <small class=\"form-text text-muted\">");
            EndContext();
            BeginContext(2134, 54, false);
#line 55 "C:\Users\rober\Desktop\CrudContaRefatorada\ToDoList.MVC\Views\ContaLuz\View.cshtml"
                                       Write(Html.ValidationMessageFor(model => model.mediaConsumo));

#line default
#line hidden
            EndContext();
            BeginContext(2188, 71, true);
            WriteLiteral("</small>\r\n    </div>\r\n</div>\r\n\r\n<div class=\"d-block text-center\">\r\n    ");
            EndContext();
            BeginContext(2260, 98, false);
#line 60 "C:\Users\rober\Desktop\CrudContaRefatorada\ToDoList.MVC\Views\ContaLuz\View.cshtml"
Write(Html.ActionLink("Voltar para listagem", "Index", null, null, new { @class = "mt-4 btn btn-info" }));

#line default
#line hidden
            EndContext();
            BeginContext(2358, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoList.classes.ContaLuz> Html { get; private set; }
    }
}
#pragma warning restore 1591
