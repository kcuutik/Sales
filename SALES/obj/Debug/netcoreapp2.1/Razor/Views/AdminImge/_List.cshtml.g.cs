#pragma checksum "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminImge\_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1d493d02881c395eb471e17875a1ce4fa71873f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminImge__List), @"mvc.1.0.view", @"/Views/AdminImge/_List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminImge/_List.cshtml", typeof(AspNetCore.Views_AdminImge__List))]
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
#line 1 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\_ViewImports.cshtml"
using WEBAPP;

#line default
#line hidden
#line 2 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\_ViewImports.cshtml"
using WEBAPP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1d493d02881c395eb471e17875a1ce4fa71873f", @"/Views/AdminImge/_List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a6bc254dbf1cb356757ac8578a2ab2dd4255c0a", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminImge__List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SALES.Entities.Image>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 335, true);
            WriteLiteral(@"
<div class=""table-responsive table-hover table-bordered"">
    <table class=""table"">
        <tr class="" text-primary"">
            <th class=""text-center"">STT</th>
            <th>Tên sản phẩm</th>
            <th class=""text-center"">Hình sản phẩm</th>
            <th style=""width: 25%""></th>
        </tr>
        <tbody>
");
            EndContext();
#line 12 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminImge\_List.cshtml"
              
                int index = 1;
                foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(489, 116, true);
            WriteLiteral("                        <tr>\r\n                            <td class=\"text-center\">\r\n                                ");
            EndContext();
            BeginContext(607, 7, false);
#line 18 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminImge\_List.cshtml"
                            Write(index++);

#line default
#line hidden
            EndContext();
            BeginContext(615, 69, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>");
            EndContext();
            BeginContext(685, 17, false);
#line 20 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminImge\_List.cshtml"
                           Write(item.Product.Name);

#line default
#line hidden
            EndContext();
            BeginContext(702, 97, true);
            WriteLiteral("</td>\r\n                            <td class=\"text-center\">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 799, "\"", 814, 1);
#line 22 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminImge\_List.cshtml"
WriteAttributeValue("", 805, item.Url, 805, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(815, 239, true);
            WriteLiteral(" alt=\"Hình sản phẩm\" width=\"100px\" />\r\n                            </td>\r\n                            <td>\r\n                                <button type=\"button\" class=\"btn btn-danger  btn-sm pull-right\" id=\"btnDelete\" data-delete-img-id=\"");
            EndContext();
            BeginContext(1055, 7, false);
#line 25 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminImge\_List.cshtml"
                                                                                                                              Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1062, 106, true);
            WriteLiteral("\"><i class=\"fa fa-trash\"></i></button>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 28 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminImge\_List.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1202, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SALES.Entities.Image>> Html { get; private set; }
    }
}
#pragma warning restore 1591
