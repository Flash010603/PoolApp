#pragma checksum "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f657927ad388ddd6548883cbfa168f2abb5b58d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Config_Index), @"mvc.1.0.view", @"/Views/Config/Index.cshtml")]
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
#line 1 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\_ViewImports.cshtml"
using Pool.WebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\_ViewImports.cshtml"
using Pool.WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f657927ad388ddd6548883cbfa168f2abb5b58d", @"/Views/Config/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4facb3cf4f05db64fab12301019ab5e08d04350c", @"/Views/_ViewImports.cshtml")]
    public class Views_Config_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Pool.WebApp.Models.ConfigData>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/config.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Config", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("active"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Table", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
  
    ViewData["Title"] = "Config Page";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f657927ad388ddd6548883cbfa168f2abb5b58d6216", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"" />
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.1/dist/css/bootstrap.min.css""
          rel=""stylesheet""
          integrity=""sha384-+0n0xVW2eSR5OomGNYDnhzAbDsOXxcvSN1TPprVMTNDbiYZCxYbOOl7+AMvyTG2x""
          crossorigin=""anonymous"" />
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5f657927ad388ddd6548883cbfa168f2abb5b58d6915", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <title>Config</title>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f657927ad388ddd6548883cbfa168f2abb5b58d8826", async() => {
                WriteLiteral("\r\n    <nav>\r\n        <div class=\"logo\">\r\n            <h1>Logo</h1>\r\n        </div>\r\n\r\n        <div class=\"items_menu\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f657927ad388ddd6548883cbfa168f2abb5b58d9230", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f657927ad388ddd6548883cbfa168f2abb5b58d10881", async() => {
                    WriteLiteral("Configuración");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5f657927ad388ddd6548883cbfa168f2abb5b58d12629", async() => {
                    WriteLiteral("Registro");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        </div>\r\n\r\n        <div class=\"cont_btn\">\r\n            <button>");
#nullable restore
#line 29 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
               Write(Html.ActionLink("Salir", "Salir", "Config", "", new { @class = "text-white text-decoration-none" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(" <i class=\"fas fa-sign-out-alt\"></i></button>\r\n        </div>\r\n    </nav>\r\n\r\n    <div class=\"contenedor\">\r\n\r\n\r\n\r\n        <h2 class=\"title_con\">Formulario de configuracion</h2>\r\n");
#nullable restore
#line 38 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
         using (Html.BeginForm("Guardar", "Config", FormMethod.Post))
        {


#line default
#line hidden
#nullable disable
                WriteLiteral("            <label");
                BeginWriteAttribute("for", " for=\"", 1444, "\"", 1450, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"subtitle_config\">Tipo de dato</label>\r\n            <p class=\"m-0\" >Usted selecciono: ");
#nullable restore
#line 42 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
                                         Write(ViewBag.Grados);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <div class=\"input\">\r\n                <div class=\"icono\"><i class=\"fas fa-temperature-low\"></i></div>\r\n");
#nullable restore
#line 45 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
                  
                    List<SelectListItem> listItems = new List<SelectListItem>();
                    listItems.Add(new SelectListItem
                    {
                        Text = "Celsius",
                        Value = "c",
                        Selected = true
                    });
                    listItems.Add(new SelectListItem
                    {
                        Text = "Fahrenheit",
                        Value = "f",

                    });
                    listItems.Add(new SelectListItem
                    {
                        Text = "Kelvin",
                        Value = "k"
                    });
                

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                ");
#nullable restore
#line 66 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
           Write(Html.DropDownListFor(model => model.Grados, listItems, "-- Select Status --", new { @class = "select" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(";\r\n\r\n\r\n            </div>\r\n");
                WriteLiteral("            <label");
                BeginWriteAttribute("for", " for=\"", 2563, "\"", 2569, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"subtitle_config\">Temperatura</label>\r\n");
                WriteLiteral("            <p class=\"m-0\">Usted selecciono: ");
#nullable restore
#line 73 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
                                        Write(ViewBag.Temp_min);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <div class=\"input\">\r\n                <div class=\"icono\"><i class=\"fas fa-thermometer-quarter\"></i></div>\r\n                ");
#nullable restore
#line 76 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
           Write(Html.TextBoxFor(d => d.Temp_min, "", new { @class = "inputitem", @type = "number", @placeholder = "Temperatura minima", @value = ViewBag.Temp_min }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <p class=\"m-0\">Usted selecciono: ");
#nullable restore
#line 78 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
                                        Write(ViewBag.Temp_min);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <div class=\"input\">\r\n                <div class=\"icono\"><i class=\"fas fa-thermometer-three-quarters\"></i></div>\r\n                ");
#nullable restore
#line 81 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
           Write(Html.TextBoxFor(d => d.Temp_max, "", new { @class = "inputitem", @type = "number", @placeholder = "Temperatura maxima" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n");
                WriteLiteral("            <label");
                BeginWriteAttribute("for", " for=\"", 3370, "\"", 3376, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"subtitle_config\">pH</label>\r\n            <p class=\"m-0\">Usted selecciono: ");
#nullable restore
#line 88 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
                                        Write(ViewBag.Ph_min);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <div class=\"input\">\r\n                <div class=\"icono\"><i class=\"fas fa-tint\"></i></div>\r\n                ");
#nullable restore
#line 91 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
           Write(Html.TextBoxFor(d => d.Ph_min, "", new { @class = "inputitem", @type = "number", @placeholder = "pH minimo", @min = "-7", @max = "7" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n            <p class=\"m-0\">Usted selecciono: ");
#nullable restore
#line 93 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
                                        Write(ViewBag.Ph_max);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <div class=\"input\">\r\n                <div class=\"icono\"><i class=\"fas fa-tint\"></i></div>\r\n                ");
#nullable restore
#line 96 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
           Write(Html.TextBoxFor(d => d.Ph_max, "", new { @class = "inputitem", @type = "number", @placeholder = "pH minimo", @min = "-7", @max = "7" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n");
                WriteLiteral("            <label");
                BeginWriteAttribute("for", " for=\"", 4122, "\"", 4128, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"subtitle_config\">Datos de la piscina</label>\r\n");
                WriteLiteral("            <p class=\"m-0\">Usted selecciono: ");
#nullable restore
#line 102 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
                                        Write(ViewBag.PoolName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <div class=\"input\">\r\n                <div class=\"icono\"><i class=\"fas fa-swimming-pool\"></i></div>\r\n                ");
#nullable restore
#line 105 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
           Write(Html.TextBoxFor(d => d.Name_Pool, "", new { @class = "inputitem", @type = "text", @placeholder = "Nombre de la piscina" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n");
                WriteLiteral("            <p class=\"m-0\">Usted selecciono: ");
#nullable restore
#line 108 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
                                        Write(ViewBag.Location);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n            <div class=\"input\">\r\n                <div class=\"icono\"><i class=\"fas fa-map-marker-alt\"></i></div>\r\n                ");
#nullable restore
#line 111 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"
           Write(Html.TextBoxFor(d => d.Location, "", new { @class = "inputitem", @type = "text", @placeholder = "Locación de la piscina" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n");
                WriteLiteral("            <button class=\"btn_Save\">Guardar configuracion <i class=\"fas fa-save\"></i></button>\r\n");
#nullable restore
#line 116 "C:\Users\frank\Desktop\web\Pool\Pool.WebApp\Views\Config\Index.cshtml"

        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    </div>

    <div class=""area"">
        <ul class=""circles"">
            <li></li>
            <li></li>
            <li></li>
            <li></li>
            <li></li>
            <li></li>
            <li></li>
            <li></li>
            <li></li>
            <li></li>
        </ul>
    </div>
    <script src=""https://kit.fontawesome.com/5fa83d646f.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/sweetalert2@11.0.18/dist/sweetalert2.all.min.js""></script>
    <script>

        document.addEventListener('DOMContentLoaded', () => {

           

");
                WriteLiteral("        }\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Pool.WebApp.Models.ConfigData> Html { get; private set; }
    }
}
#pragma warning restore 1591
