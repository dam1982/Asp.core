#pragma checksum "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\Usuario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdfa7800099b1e4fe07714af021f32ac42664fb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Index), @"mvc.1.0.view", @"/Views/Usuario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Usuario/Index.cshtml", typeof(AspNetCore.Views_Usuario_Index))]
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
#line 1 "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\_ViewImports.cshtml"
using HolaMundo;

#line default
#line hidden
#line 2 "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\_ViewImports.cshtml"
using HolaMundo.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdfa7800099b1e4fe07714af021f32ac42664fb6", @"/Views/Usuario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6347fbb7baf218229e9b8364d3a4ea17a6caa847", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Registro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Usuario", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\Usuario\Index.cshtml"
  
    ViewData["Title"] = "Usuario Page";
    List<HolaMundo.Models.Usuario> usuarios = (List<HolaMundo.Models.Usuario>)ViewData["usuarios"];

#line default
#line hidden
            BeginContext(166, 27, true);
            WriteLiteral("\r\n<div class=\"container\">\r\n");
            EndContext();
            BeginContext(193, 453, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdfa7800099b1e4fe07714af021f32ac42664fb64206", async() => {
                BeginContext(246, 393, true);
                WriteLiteral(@"
    <div class=""formgroup col-md-6"">
            <label>Nombre</label>
            <input type=""text"" asp-for =""Nombre"" class=""form-control"" method=""post"">
            <label asp-validation-for=""Usuario"" class=""label label-danger""></label>                        
    </div>
    <div class=""row"">
            <button type=""submit"" class=""btn btn-primary"">Guardar</button>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(646, 37, true);
            WriteLiteral("   \r\n</div>\r\n\r\n\r\n\r\n<h1>Usuario</h1>\r\n");
            EndContext();
            BeginContext(684, 14, false);
#line 23 "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\Usuario\Index.cshtml"
Write(ViewBag.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(698, 8, true);
            WriteLiteral("\r\n<br>\r\n");
            EndContext();
            BeginContext(707, 20, false);
#line 25 "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\Usuario\Index.cshtml"
Write(ViewData["Apellido"]);

#line default
#line hidden
            EndContext();
            BeginContext(727, 9, true);
            WriteLiteral(";\r\n<br>\r\n");
            EndContext();
            BeginContext(737, 19, false);
#line 27 "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\Usuario\Index.cshtml"
Write(TempData["Usuario"]);

#line default
#line hidden
            EndContext();
            BeginContext(756, 15, true);
            WriteLiteral(";\r\n\r\n\r\n\r\n<ul>\r\n");
            EndContext();
#line 32 "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\Usuario\Index.cshtml"
     foreach(string fruta in (List<string>)ViewData["frutas"]){

#line default
#line hidden
            BeginContext(836, 29, true);
            WriteLiteral("        <li>\r\n           <h3>");
            EndContext();
            BeginContext(866, 5, false);
#line 34 "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\Usuario\Index.cshtml"
          Write(fruta);

#line default
#line hidden
            EndContext();
            BeginContext(871, 22, true);
            WriteLiteral("</h3>\r\n        </li>\r\n");
            EndContext();
#line 36 "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\Usuario\Index.cshtml"

    }

#line default
#line hidden
            BeginContext(902, 445, true);
            WriteLiteral(@"</ul>



<ul>
    <table class=""table table-bordered"">
        <thead scope=""row"">
                <td >
                <h4>Nombre</h4>
                </td>
                <td >
                <h4>Apellido</h4>
                </td>
                <td >
                <h4>Correo</h4>
                </td >
                <td >
                <h4>Edad</h4>
                </td>
        </thead>
    </table>    

");
            EndContext();
#line 60 "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\Usuario\Index.cshtml"
     foreach(Usuario v in @ViewBag.Usuarios){

#line default
#line hidden
            BeginContext(1394, 115, true);
            WriteLiteral("    <table class=\"table table-bordered\">\r\n        <tbody scope=\"row\" >\r\n                <td >\r\n                <h4>");
            EndContext();
            BeginContext(1510, 8, false);
#line 64 "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\Usuario\Index.cshtml"
               Write(v.Nombre);

#line default
#line hidden
            EndContext();
            BeginContext(1518, 73, true);
            WriteLiteral("</h4>\r\n                </td>\r\n                <td >\r\n                <h4>");
            EndContext();
            BeginContext(1592, 10, false);
#line 67 "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\Usuario\Index.cshtml"
               Write(v.Apellido);

#line default
#line hidden
            EndContext();
            BeginContext(1602, 73, true);
            WriteLiteral("</h4>\r\n                </td>\r\n                <td >\r\n                <h4>");
            EndContext();
            BeginContext(1676, 8, false);
#line 70 "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\Usuario\Index.cshtml"
               Write(v.Correo);

#line default
#line hidden
            EndContext();
            BeginContext(1684, 74, true);
            WriteLiteral("</h4>\r\n                </td >\r\n                <td >\r\n                <h4>");
            EndContext();
            BeginContext(1759, 6, false);
#line 73 "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\Usuario\Index.cshtml"
               Write(v.Edad);

#line default
#line hidden
            EndContext();
            BeginContext(1765, 62, true);
            WriteLiteral("</h4>\r\n                </td>\r\n        </tbody>\r\n    </table>\r\n");
            EndContext();
#line 77 "C:\Users\ADMIN\Documents\asp.core\HolaMundo\Views\Usuario\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1834, 15, true);
            WriteLiteral("</ul>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591
