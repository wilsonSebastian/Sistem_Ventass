#pragma checksum "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c21b5e775b58aafb02b5195055a1ad010c58a1af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Sistem_Ventas.Areas.Compras.Pages.Compras.Areas_Compras_Pages_Compras_Detalles), @"mvc.1.0.razor-page", @"/Areas/Compras/Pages/Compras/Detalles.cshtml")]
namespace Sistem_Ventas.Areas.Compras.Pages.Compras
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
#line 1 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c21b5e775b58aafb02b5195055a1ad010c58a1af", @"/Areas/Compras/Pages/Compras/Detalles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7f1f0ed86e2a85895f1bbc62b1fdecd156b69cd", @"/Areas/Compras/Pages/_ViewImports.cshtml")]
    public class Areas_Compras_Pages_Compras_Detalles : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString(" responsive-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Ticket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
  
    string imagen = null;
    string codigo = Model.Input.TComprasTemp.Codigo;
    if (Model.AvatarImage != null || codigo != null)
    {
        imagen = codigo + ".png";

    }
    else
    {
        imagen = "default.png";
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container2"">
    <div class=""row"">
        <div class=""panel  panel-primary"">
            <div class=""panel-heading"">
                <center>
                    <h5 class=""panel-title"">Detalles de compra</h5>
                </center>
            </div>
            <div class=""row"">
                <div class=""col s11 m3"">
                    <div class=""card "">
                        <div class=""card-content white-text"">
                            <center>
                                <span class=""card-title blue-grey-text  "">Imagen</span>
                                <output id=""productoCompra"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c21b5e775b58aafb02b5195055a1ad010c58a1af5512", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 991, "~/images/fotos/Compras/", 991, 23, true);
#nullable restore
#line 31 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
AddHtmlAttributeValue("", 1014, imagen, 1014, 7, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                </output>
                            </center>
                        </div>
                    </div>
                </div>

                <div class=""col s11 m9"">
                    <div id=""ImprimirCompra"">
                        <div class=""card "">
                            <div class=""card-content black-text"">
                                <center>
                                    <span class=""card-title"">Proveedor: ");
#nullable restore
#line 43 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
                                                                   Write(Html.Raw(Model.Input.TComprasTemp.Proveedor));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                </center>
                                <table class=""table"">
                                    <thead>
                                        <tr>
                                            <th>
                                                Producto
                                            </th>
                                            <th>
                                                Precio
                                            </th>
                                            <th>
                                                Cantidad
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
                                                <span>");
#nullable restore
#line 62 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
                                                 Write(Html.Raw(Model.Input.TComprasTemp.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </td>\r\n                                            <td>\r\n                                                <span>");
#nullable restore
#line 65 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
                                                 Write(Html.Raw(Model.Input.TComprasTemp.Precio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </td>\r\n                                            <td>\r\n                                                <span>");
#nullable restore
#line 68 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
                                                 Write(Html.Raw(Model.Input.TComprasTemp.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                            </td>
                                        </tr>
                                    </tbody>
                                    <thead>
                                        <tr>
                                            <th>
                                                Credito
                                            </th>
                                            <th>
                                                Importe
                                            </th>
                                            <th>
                                                Fecha
                                            </th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>
");
#nullable restore
#line 88 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
                                                 if (Model.Input.TComprasTemp.Credito)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"green-text text-darken-3\">Activo</span>\r\n");
#nullable restore
#line 91 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"deep-orange-text text-darken-4\">No disponible</span>\r\n");
#nullable restore
#line 95 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"

                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            </td>\r\n                                            <td>\r\n                                                <span>");
#nullable restore
#line 99 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
                                                 Write(Html.Raw(Model.Input.TComprasTemp.Importe));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </td>\r\n                                            <td>\r\n                                                <span>");
#nullable restore
#line 102 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
                                                 Write(Html.Raw(Model.Input.TComprasTemp.Fecha));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                    <label id=""Message"" class=""red-text text-darken-4 "">");
#nullable restore
#line 110 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
                                                                   Write(Html.Raw(Model.Input.ErrorMessage));

#line default
#line hidden
#nullable disable
            WriteLiteral("  </label>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c21b5e775b58aafb02b5195055a1ad010c58a1af13989", async() => {
                WriteLiteral(@"
                        <div class=""row"">
                            <div class=""input-field col s4"">
                                <a class=""waves-effect waves-light orange darken-2 btn-small"" onclick=""printThisDiv('ImprimirCompra')"">Imprimir</a>
                            </div>
");
#nullable restore
#line 116 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
                             if (Model.Valor) { 

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"input-field col s4\">\r\n                                    <button type=\"submit\" class=\"waves-effect waves-light btn-small grey darken-3\">Aceptar</button>\r\n                                </div>\r\n");
#nullable restore
#line 120 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 121 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
                             if (Model.Input.TComprasTemp.Credito && Model.Valor)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"input-field col s4\">\r\n                                    <a class=\"waves-effect waves-light orange darken-2 btn-small\" onclick=\"printThisDiv(\'ticket\')\">Ticket</a>\r\n                                </div>\r\n");
#nullable restore
#line 126 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"row\">\r\n");
#nullable restore
#line 130 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
                         if (Model.Input.TComprasTemp.Credito && Model.Valor)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c21b5e775b58aafb02b5195055a1ad010c58a1af17720", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 133 "C:\Users\AJpag\Downloads\Sistem_Ventas\Sistem_Ventas\Areas\Compras\Pages\Compras\Detalles.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DetallesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetallesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<DetallesModel>)PageContext?.ViewData;
        public DetallesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
