#pragma checksum "C:\Users\57321\Desktop\Prueba Desarrollador\Travel\Travel\Views\Biblioteca\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dea0ddb91207578496458b1781a55873f34c084a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Biblioteca_Index), @"mvc.1.0.view", @"/Views/Biblioteca/Index.cshtml")]
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
#line 1 "C:\Users\57321\Desktop\Prueba Desarrollador\Travel\Travel\Views\_ViewImports.cshtml"
using Travel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\57321\Desktop\Prueba Desarrollador\Travel\Travel\Views\_ViewImports.cshtml"
using Travel.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dea0ddb91207578496458b1781a55873f34c084a", @"/Views/Biblioteca/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9023ae7305b6c0831be002755157d19f27dd0631", @"/Views/_ViewImports.cshtml")]
    public class Views_Biblioteca_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Travel.Models.Detail>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\57321\Desktop\Prueba Desarrollador\Travel\Travel\Views\Biblioteca\Index.cshtml"
  
    ViewData["Title"] = "Books";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container p-3"">
    <div class=""row pt-4"">
        <div class=""col-6"">
            <h2 class=""text-primary"">Detalle de Libros</h2>
        </div>
    </div>
    <br />

    <table class=""table table-bordered table-striped"" style=""width:100%"">
        <thead>
            <tr>
                <th>
                    Nombre
                </th>
                <th>
                    Apellido
                </th>
                <th>
                    Libro
                </th>
                <th>
                    Sinopsis
                </th>
                <th>
                    # Paginas
                </th>
                <th>
                    ISBN
                </th>
                <th>
                    Editorial
                </th>
            </tr>
        </thead>
        <tbody>

");
#nullable restore
#line 43 "C:\Users\57321\Desktop\Prueba Desarrollador\Travel\Travel\Views\Biblioteca\Index.cshtml"
             foreach (var detalle in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td width=\"30%\">");
#nullable restore
#line 46 "C:\Users\57321\Desktop\Prueba Desarrollador\Travel\Travel\Views\Biblioteca\Index.cshtml"
                               Write(detalle.Nombre);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"30%\">");
#nullable restore
#line 47 "C:\Users\57321\Desktop\Prueba Desarrollador\Travel\Travel\Views\Biblioteca\Index.cshtml"
                               Write(detalle.Apellidos);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"30%\">");
#nullable restore
#line 48 "C:\Users\57321\Desktop\Prueba Desarrollador\Travel\Travel\Views\Biblioteca\Index.cshtml"
                               Write(detalle.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"100%\">");
#nullable restore
#line 49 "C:\Users\57321\Desktop\Prueba Desarrollador\Travel\Travel\Views\Biblioteca\Index.cshtml"
                                Write(detalle.Sinopsis);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"30%\">");
#nullable restore
#line 50 "C:\Users\57321\Desktop\Prueba Desarrollador\Travel\Travel\Views\Biblioteca\Index.cshtml"
                               Write(detalle.N_paginas);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"30%\">");
#nullable restore
#line 51 "C:\Users\57321\Desktop\Prueba Desarrollador\Travel\Travel\Views\Biblioteca\Index.cshtml"
                               Write(detalle.Isbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td width=\"30%\">");
#nullable restore
#line 52 "C:\Users\57321\Desktop\Prueba Desarrollador\Travel\Travel\Views\Biblioteca\Index.cshtml"
                               Write(detalle.Editorial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 54 "C:\Users\57321\Desktop\Prueba Desarrollador\Travel\Travel\Views\Biblioteca\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Travel.Models.Detail>> Html { get; private set; }
    }
}
#pragma warning restore 1591
