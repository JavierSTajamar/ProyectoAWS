#pragma checksum "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "81ec0946ebaeeba5d450d59d083c1e34651ae1b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Usuario_Details), @"mvc.1.0.view", @"/Views/Usuario/Details.cshtml")]
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
#line 1 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\_ViewImports.cshtml"
using ProyectoAWS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\_ViewImports.cshtml"
using ProyectoAWS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81ec0946ebaeeba5d450d59d083c1e34651ae1b4", @"/Views/Usuario/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c68221c97f8915523a8680ab91d778121d2930ac", @"/Views/_ViewImports.cshtml")]
    public class Views_Usuario_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProyectoAWS.Models.Usuario>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 3 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
   ViewData["Title"] = "Details"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div>\n    <h4>Usuario</h4>\n    <hr />\n    <dl class=\"row\">\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 11 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 14 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdUsuario));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 17 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 20 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 23 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 26 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class=\"col-sm-2\">\n            ");
#nullable restore
#line 29 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fechaalta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class=\"col-sm-10\">\n            ");
#nullable restore
#line 32 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
       Write(Html.DisplayFor(model => model.fechaalta));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    <div class=\"container w-100 text-center\">\n\n\n");
#nullable restore
#line 40 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
         if (Model.Fotos.Count != 0)
        {

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
 foreach (Foto foto in Model.Fotos)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card\">\n    <div class=\"card-title\">");
#nullable restore
#line 45 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
                       Write(foto.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n    <img");
            BeginWriteAttribute("src", " src=\"", 1172, "\"", 1229, 2);
            WriteAttributeValue("", 1178, "https://bucketproyaws.s3.amazonaws.com/", 1178, 39, true);
#nullable restore
#line 46 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
WriteAttributeValue("", 1217, foto.Imagen, 1217, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\" />\n\n</div><br />");
#nullable restore
#line 48 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
              }
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>El usuario no tiene fotos</p>");
#nullable restore
#line 51 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </div>\n</div>\n<div>\n    ");
#nullable restore
#line 56 "E:\AWS\ProyectoAWS\ProyectoAWS\Views\Usuario\Details.cshtml"
Write(Html.ActionLink("Actualizar", "Update", new { id = Model.IdUsuario }, new { @class = "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" \n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "81ec0946ebaeeba5d450d59d083c1e34651ae1b48477", async() => {
                WriteLiteral("Volver a la Lista");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProyectoAWS.Models.Usuario> Html { get; private set; }
    }
}
#pragma warning restore 1591