#pragma checksum "C:\www\SaoDubasGit\SaoDubas\SaoDubas\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "028c8c6120ce591041f0e51ddfcd964930f135dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\www\SaoDubasGit\SaoDubas\SaoDubas\Views\_ViewImports.cshtml"
using SaoDubas;

#line default
#line hidden
#line 2 "C:\www\SaoDubasGit\SaoDubas\SaoDubas\Views\_ViewImports.cshtml"
using SaoDubas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"028c8c6120ce591041f0e51ddfcd964930f135dd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5b0dfa660611a63ea12cf68bde470cc9d00202fd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<SaoDubas.Domain.Models.Produto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\www\SaoDubasGit\SaoDubas\SaoDubas\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(90, 29, true);
            WriteLiteral("\r\n<div class=\"row Lanches\">\r\n");
            EndContext();
#line 7 "C:\www\SaoDubasGit\SaoDubas\SaoDubas\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {


#line default
#line hidden
            BeginContext(162, 100, true);
            WriteLiteral("        <div class=\"col-md-4\">\r\n            <div class=\"card mb-4 shadow-sm\">\r\n                <h3> ");
            EndContext();
            BeginContext(263, 9, false);
#line 12 "C:\www\SaoDubasGit\SaoDubas\SaoDubas\Views\Home\Index.cshtml"
                Write(item.Nome);

#line default
#line hidden
            EndContext();
            BeginContext(272, 280, true);
            WriteLiteral(@"</h3>
                <svg class=""bd-placeholder-img card-img-top"" width=""80%"" height=""200"" xmlns=""http://www.w3.org/2000/svg"" preserveAspectRatio=""xMidYMid slice"" focusable=""false"" role=""img"" aria-label=""Placeholder: Thumbnail"">
                    <title>Placeholder</title>
");
            EndContext();
#line 15 "C:\www\SaoDubasGit\SaoDubas\SaoDubas\Views\Home\Index.cshtml"
                     if (item.Imagem != null)
                    {
                        var base64 = Convert.ToBase64String(item.Imagem);
                        var imgSrc = String.Format("data:image/gif;base64,{0}", base64);


#line default
#line hidden
            BeginContext(789, 30, true);
            WriteLiteral("                        <image");
            EndContext();
            BeginWriteAttribute("xlink:href", " xlink:href=\"", 819, "\"", 839, 1);
#line 20 "C:\www\SaoDubasGit\SaoDubas\SaoDubas\Views\Home\Index.cshtml"
WriteAttributeValue("", 832, imgSrc, 832, 7, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(840, 70, true);
            WriteLiteral(" x=\"0\" y=\"0\" width=\"100%\" height=\"225\" preserveAspectRatio=\"none\" />\r\n");
            EndContext();
#line 21 "C:\www\SaoDubasGit\SaoDubas\SaoDubas\Views\Home\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(982, 81, true);
            WriteLiteral("                        <rect width=\"100%\" height=\"100%\" fill=\"#55595c\"></rect>\r\n");
            EndContext();
#line 25 "C:\www\SaoDubasGit\SaoDubas\SaoDubas\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
            BeginContext(1086, 108, true);
            WriteLiteral("\r\n                </svg>\r\n                <div class=\"card-body\">\r\n                    <p class=\"card-text\">");
            EndContext();
            BeginContext(1195, 14, false);
#line 29 "C:\www\SaoDubasGit\SaoDubas\SaoDubas\Views\Home\Index.cshtml"
                                    Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(1209, 556, true);
            WriteLiteral(@"</p>
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                            <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Adicionar a lista!</button>
                            <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Detalhes</button>
                        </div>
                        <small class=""text-muted"">9 mins</small>
                    </div>
                </div>
            </div>
        </div>
");
            EndContext();
#line 40 "C:\www\SaoDubasGit\SaoDubas\SaoDubas\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1772, 8, true);
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<SaoDubas.Domain.Models.Produto>> Html { get; private set; }
    }
}
#pragma warning restore 1591
