#pragma checksum "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "212b8cabcfd131c2b6ff99f60dc3915f243f8265"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Sistem_Ventas.Areas.Proveedores.Models.Historiales.Areas_Proveedores_Views_Historiales_HistoryTickets), @"mvc.1.0.view", @"/Areas/Proveedores/Views/Historiales/HistoryTickets.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Proveedores/Views/Historiales/HistoryTickets.cshtml", typeof(Sistem_Ventas.Areas.Proveedores.Models.Historiales.Areas_Proveedores_Views_Historiales_HistoryTickets))]
namespace Sistem_Ventas.Areas.Proveedores.Models.Historiales
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\_ViewImports.cshtml"
using Sistem_Ventas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"212b8cabcfd131c2b6ff99f60dc3915f243f8265", @"/Areas/Proveedores/Views/Historiales/HistoryTickets.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d12b07366653a908792840e6059f1a0de21b997", @"/Areas/Proveedores/Views/_ViewImports.cshtml")]
    public class Areas_Proveedores_Views_Historiales_HistoryTickets : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DataPaginador<TTickets>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Buscar ticket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Proveedores", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Historiales", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "HistoryTickets", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ExportHistory", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/iconos/Proveedores2.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
  
    ViewData["Title"] = "HistoryTickets";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(129, 143, true);
            WriteLiteral("\r\n<div class=\"container2\">\r\n    <h5>Histiriales de tickets</h5>\r\n    <div class=\"row\">\r\n        <div class=\"input-field col s12\">\r\n            ");
            EndContext();
            BeginContext(272, 527, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "212b8cabcfd131c2b6ff99f60dc3915f243f82657541", async() => {
                BeginContext(371, 115, true);
                WriteLiteral("\r\n                <div class=\"row\">\r\n                    <div class=\"input-field col s6\">\r\n                        ");
                EndContext();
                BeginContext(486, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "212b8cabcfd131c2b6ff99f60dc3915f243f82658045", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 14 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Search);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(538, 254, true);
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"input-field col s6\">\r\n                        <button type=\"submit\" class=\"waves-effect waves-light btn-small\">Buscar</button>\r\n                    </div>\r\n                </div>\r\n            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(799, 34, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    ");
            EndContext();
            BeginContext(833, 366, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "212b8cabcfd131c2b6ff99f60dc3915f243f826511939", async() => {
                BeginContext(962, 230, true);
                WriteLiteral("\r\n        <div class=\"row\">\r\n            <div class=\"col-md-8\" style=\"padding-top:10px;\">\r\n                <button class=\"waves-effect waves-light btn-small amber darken-3\">Export</button>\r\n            </div>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1199, 108, true);
            WriteLiteral("\r\n    <ul class=\"collapsible\">\r\n        <li>\r\n            <div class=\"collapsible-header\">\r\n                ");
            EndContext();
            BeginContext(1307, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "212b8cabcfd131c2b6ff99f60dc3915f243f826514638", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1372, 236, true);
            WriteLiteral("Ticket\r\n            </div>\r\n            <div class=\"collapsible-body\">\r\n                <table class=\"table\">\r\n                    <thead>\r\n                        <tr>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1609, 47, false);
#line 40 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
                           Write(Html.DisplayNameFor(model => model.Input.Deuda));

#line default
#line hidden
            EndContext();
            BeginContext(1656, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1760, 52, false);
#line 43 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
                           Write(Html.DisplayNameFor(model => model.Input.FechaDeuda));

#line default
#line hidden
            EndContext();
            BeginContext(1812, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(1916, 46, false);
#line 46 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
                           Write(Html.DisplayNameFor(model => model.Input.Pago));

#line default
#line hidden
            EndContext();
            BeginContext(1962, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(2066, 51, false);
#line 49 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
                           Write(Html.DisplayNameFor(model => model.Input.FechaPago));

#line default
#line hidden
            EndContext();
            BeginContext(2117, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(2221, 48, false);
#line 52 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
                           Write(Html.DisplayNameFor(model => model.Input.Ticket));

#line default
#line hidden
            EndContext();
            BeginContext(2269, 103, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th>\r\n                                ");
            EndContext();
            BeginContext(2373, 47, false);
#line 55 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
                           Write(Html.DisplayNameFor(model => model.Input.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2420, 166, true);
            WriteLiteral("\r\n                            </th>\r\n                            <th></th>\r\n                        </tr>\r\n                    </thead>\r\n                    <tbody>\r\n");
            EndContext();
#line 61 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
                         foreach (var item in Model.List)
                        {

#line default
#line hidden
            BeginContext(2672, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2781, 40, false);
#line 65 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Deuda));

#line default
#line hidden
            EndContext();
            BeginContext(2821, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(2937, 45, false);
#line 68 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FechaDeuda));

#line default
#line hidden
            EndContext();
            BeginContext(2982, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3098, 39, false);
#line 71 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Pago));

#line default
#line hidden
            EndContext();
            BeginContext(3137, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3253, 44, false);
#line 74 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
                               Write(Html.DisplayFor(modelItem => item.FechaPago));

#line default
#line hidden
            EndContext();
            BeginContext(3297, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3413, 41, false);
#line 77 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Ticket));

#line default
#line hidden
            EndContext();
            BeginContext(3454, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3570, 40, false);
#line 80 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(3610, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 83 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
                        }

#line default
#line hidden
            BeginContext(3713, 129, true);
            WriteLiteral("                    </tbody>\r\n                </table>\r\n                <div class=\"pagination\">\r\n                    Resultados ");
            EndContext();
            BeginContext(3843, 25, false);
#line 87 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
                          Write(Html.Raw(Model.Pagi_info));

#line default
#line hidden
            EndContext();
            BeginContext(3868, 51, true);
            WriteLiteral(";\r\n                    <br />\r\n                    ");
            EndContext();
            BeginContext(3920, 31, false);
#line 89 "C:\Users\CETECOM\Desktop\Sistem_Ventas\Sistem_Ventas\Areas\Proveedores\Views\Historiales\HistoryTickets.cshtml"
               Write(Html.Raw(Model.Pagi_navegacion));

#line default
#line hidden
            EndContext();
            BeginContext(3951, 80, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </li>\r\n    </ul>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DataPaginador<TTickets>> Html { get; private set; }
    }
}
#pragma warning restore 1591