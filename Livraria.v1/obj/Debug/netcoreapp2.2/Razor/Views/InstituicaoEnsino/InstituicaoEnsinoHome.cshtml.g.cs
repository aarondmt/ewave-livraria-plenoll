#pragma checksum "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b204795fab5ea2dc7def8da8fdbeccd6cf724d12"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_InstituicaoEnsino_InstituicaoEnsinoHome), @"mvc.1.0.view", @"/Views/InstituicaoEnsino/InstituicaoEnsinoHome.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/InstituicaoEnsino/InstituicaoEnsinoHome.cshtml", typeof(AspNetCore.Views_InstituicaoEnsino_InstituicaoEnsinoHome))]
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
#line 1 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\_ViewImports.cshtml"
using Livraria.v1;

#line default
#line hidden
#line 2 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\_ViewImports.cshtml"
using Livraria.v1.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b204795fab5ea2dc7def8da8fdbeccd6cf724d12", @"/Views/InstituicaoEnsino/InstituicaoEnsinoHome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7ff178510f01fc5a1cc34bfb000de32f9029024f", @"/Views/_ViewImports.cshtml")]
    public class Views_InstituicaoEnsino_InstituicaoEnsinoHome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InstituicaoEnsino>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Inserir", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Editar", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Editar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detalhes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Detalhes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
  
    ViewData["Title"] = "Instituições de Ensino";

#line default
#line hidden
            BeginContext(100, 47, true);
            WriteLiteral("\r\n<h2>Instituições de Ensinos</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(147, 75, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b204795fab5ea2dc7def8da8fdbeccd6cf724d126013", async() => {
                BeginContext(192, 26, true);
                WriteLiteral("Nova Instituição de Ensino");
                EndContext();
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
            EndContext();
            BeginContext(222, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(315, 40, false);
#line 16 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
           Write(Html.DisplayNameFor(model => model.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(355, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(411, 40, false);
#line 19 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
           Write(Html.DisplayNameFor(model => model.Cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(451, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(507, 44, false);
#line 22 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
           Write(Html.DisplayNameFor(model => model.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(551, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(607, 44, false);
#line 25 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
           Write(Html.DisplayNameFor(model => model.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(651, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(707, 41, false);
#line 28 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
           Write(Html.DisplayNameFor(model => model.Ativo));

#line default
#line hidden
            EndContext();
            BeginContext(748, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 34 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(883, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(932, 39, false);
#line 38 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
           Write(Html.DisplayFor(modelItem => item.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(971, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1027, 39, false);
#line 41 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cnpj));

#line default
#line hidden
            EndContext();
            BeginContext(1066, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1122, 43, false);
#line 44 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
           Write(Html.DisplayFor(modelItem => item.Telefone));

#line default
#line hidden
            EndContext();
            BeginContext(1165, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1221, 43, false);
#line 47 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
           Write(Html.DisplayFor(modelItem => item.Endereco));

#line default
#line hidden
            EndContext();
            BeginContext(1264, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1321, 26, false);
#line 50 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
            Write(item.Ativo ? "Sim" : "Não");

#line default
#line hidden
            EndContext();
            BeginContext(1348, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(1403, 117, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b204795fab5ea2dc7def8da8fdbeccd6cf724d1212275", async() => {
                BeginContext(1489, 27, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 53 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1520, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(1540, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b204795fab5ea2dc7def8da8fdbeccd6cf724d1214855", async() => {
                BeginContext(1627, 34, true);
                WriteLiteral("<i class=\"fas fa-book-reader\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 54 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
                                                                WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1665, 41, true);
            WriteLiteral(" |\r\n                <button type=\"button\"");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1706, "\"", 1762, 2);
            WriteAttributeValue("", 1714, "btn", 1714, 3, true);
#line 55 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
WriteAttributeValue(" ", 1717, item.Ativo ? "btn-danger" : "btn-success", 1718, 44, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginWriteAttribute("onclick", " onclick=\"", 1763, "\"", 1813, 4);
            WriteAttributeValue("", 1773, "livro.clickAlterarStatus(", 1773, 25, true);
#line 55 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
WriteAttributeValue("", 1798, item.Id, 1798, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 1806, ",", 1806, 1, true);
            WriteAttributeValue(" ", 1807, "this)", 1808, 6, true);
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1814, "\"", 1860, 1);
#line 55 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
WriteAttributeValue("", 1822, item.Ativo ? "Desativar" : "Ativar", 1822, 38, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1861, 25, true);
            WriteLiteral(">\r\n                    <i");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 1886, "\"", 1950, 2);
            WriteAttributeValue("", 1894, "fas", 1894, 3, true);
#line 56 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
WriteAttributeValue(" ", 1897, item.Ativo ? "fa-minus-circle" : "fa-plus-circle", 1898, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1951, 68, true);
            WriteLiteral("></i>\r\n                </button>\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 60 "D:\projects\ewave\Livraria.v1\Livraria.v1\Views\InstituicaoEnsino\InstituicaoEnsinoHome.cshtml"
        }

#line default
#line hidden
            BeginContext(2030, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InstituicaoEnsino>> Html { get; private set; }
    }
}
#pragma warning restore 1591
