#pragma checksum "C:\Users\khoai\OneDrive\Máy tính\SALES\SALES\Views\AdminProduct\_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7407df7b488b55c2eaeb950a6b21f2768810a20c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminProduct__List), @"mvc.1.0.view", @"/Views/AdminProduct/_List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminProduct/_List.cshtml", typeof(AspNetCore.Views_AdminProduct__List))]
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
#line 1 "C:\Users\khoai\OneDrive\Máy tính\SALES\SALES\Views\_ViewImports.cshtml"
using WEBAPP;

#line default
#line hidden
#line 2 "C:\Users\khoai\OneDrive\Máy tính\SALES\SALES\Views\_ViewImports.cshtml"
using WEBAPP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7407df7b488b55c2eaeb950a6b21f2768810a20c", @"/Views/AdminProduct/_List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a6bc254dbf1cb356757ac8578a2ab2dd4255c0a", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminProduct__List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SALES.Entities.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 412, true);
            WriteLiteral(@"
<div class=""table-responsive table-hover table-bordered"">
    <table class=""table"">
        <tr class="" text-primary"">
            <th class=""text-center"">STT</th>
            <th> Tên sản phẩm</th>
            <th>Giá bán</th>
            <th>Số lượng tồn</th>
            <th>Số lượng bán</th>
            <th>Kích hoạt</th>
            <th style=""width: 25%""></th>
        </tr>
        <tbody>
");
            EndContext();
#line 15 "C:\Users\khoai\OneDrive\Máy tính\SALES\SALES\Views\AdminProduct\_List.cshtml"
              
                int index = 1;
                foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(568, 116, true);
            WriteLiteral("                        <tr>\r\n                            <td class=\"text-center\">\r\n                                ");
            EndContext();
            BeginContext(686, 7, false);
#line 21 "C:\Users\khoai\OneDrive\Máy tính\SALES\SALES\Views\AdminProduct\_List.cshtml"
                            Write(index++);

#line default
#line hidden
            EndContext();
            BeginContext(694, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(798, 9, false);
#line 24 "C:\Users\khoai\OneDrive\Máy tính\SALES\SALES\Views\AdminProduct\_List.cshtml"
                           Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(807, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(911, 13, false);
#line 27 "C:\Users\khoai\OneDrive\Máy tính\SALES\SALES\Views\AdminProduct\_List.cshtml"
                           Write(item.PriceOut);

#line default
#line hidden
            EndContext();
            BeginContext(924, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1028, 15, false);
#line 30 "C:\Users\khoai\OneDrive\Máy tính\SALES\SALES\Views\AdminProduct\_List.cshtml"
                           Write(item.QuantilyIn);

#line default
#line hidden
            EndContext();
            BeginContext(1043, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1147, 16, false);
#line 33 "C:\Users\khoai\OneDrive\Máy tính\SALES\SALES\Views\AdminProduct\_List.cshtml"
                           Write(item.QuantilyOut);

#line default
#line hidden
            EndContext();
            BeginContext(1163, 103, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
            EndContext();
            BeginContext(1267, 13, false);
#line 36 "C:\Users\khoai\OneDrive\Máy tính\SALES\SALES\Views\AdminProduct\_List.cshtml"
                           Write(item.IsActive);

#line default
#line hidden
            EndContext();
            BeginContext(1280, 206, true);
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <button type=\"submit\" class=\"btn btn-danger  btn-sm pull-right\" id=\"btnDelete\" data-delete-product-id=\"");
            EndContext();
            BeginContext(1487, 7, false);
#line 39 "C:\Users\khoai\OneDrive\Máy tính\SALES\SALES\Views\AdminProduct\_List.cshtml"
                                                                                                                                  Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1494, 150, true);
            WriteLiteral("\">Delete</button>\r\n                                <button type=\"button\" class=\"btn btn-success btn-sm pull-right\" id=\"btnEdit\" data-edit-product-id=\"");
            EndContext();
            BeginContext(1645, 7, false);
#line 40 "C:\Users\khoai\OneDrive\Máy tính\SALES\SALES\Views\AdminProduct\_List.cshtml"
                                                                                                                              Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1652, 33, true);
            WriteLiteral("\" data-edit-product-description=\"");
            EndContext();
            BeginContext(1686, 16, false);
#line 40 "C:\Users\khoai\OneDrive\Máy tính\SALES\SALES\Views\AdminProduct\_List.cshtml"
                                                                                                                                                                       Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1702, 26, true);
            WriteLiteral("\" data-edit-product-name=\"");
            EndContext();
            BeginContext(1729, 9, false);
#line 40 "C:\Users\khoai\OneDrive\Máy tính\SALES\SALES\Views\AdminProduct\_List.cshtml"
                                                                                                                                                                                                                  Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1738, 83, true);
            WriteLiteral("\">Edit</button>\r\n                            </td>\r\n                        </tr>\r\n");
            EndContext();
#line 43 "C:\Users\khoai\OneDrive\Máy tính\SALES\SALES\Views\AdminProduct\_List.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1855, 38, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SALES.Entities.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
