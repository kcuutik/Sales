#pragma checksum "D:\KHOA\Other\SRC\SALE\Sales\SALES\Views\AdminCategory\_List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44da373201f7798bfbc0d66f77074b680a0f32ce"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminCategory__List), @"mvc.1.0.view", @"/Views/AdminCategory/_List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminCategory/_List.cshtml", typeof(AspNetCore.Views_AdminCategory__List))]
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
#line 1 "D:\KHOA\Other\SRC\SALE\Sales\SALES\Views\_ViewImports.cshtml"
using WEBAPP;

#line default
#line hidden
#line 2 "D:\KHOA\Other\SRC\SALE\Sales\SALES\Views\_ViewImports.cshtml"
using WEBAPP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44da373201f7798bfbc0d66f77074b680a0f32ce", @"/Views/AdminCategory/_List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a6bc254dbf1cb356757ac8578a2ab2dd4255c0a", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminCategory__List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SALES.Entities.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 336, true);
            WriteLiteral(@"
<div class=""table-responsive table-hover table-bordered"">
    <table class=""table"">
        <tr class="" text-primary"">
            <th class=""text-center"">STT</th>
            <th> Tên loại</th>
            <th>Mô tả</th>
            <th>Kích hoạt</th>
            <th style=""width: 25%""></th>
        </tr>
        <tbody>
");
            EndContext();
#line 13 "D:\KHOA\Other\SRC\SALE\Sales\SALES\Views\AdminCategory\_List.cshtml"
              
                int index = 1;
                foreach (var item in Model)
                {

#line default
#line hidden
            BeginContext(493, 104, true);
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-center\">\r\n                            ");
            EndContext();
            BeginContext(599, 7, false);
#line 19 "D:\KHOA\Other\SRC\SALE\Sales\SALES\Views\AdminCategory\_List.cshtml"
                        Write(index++);

#line default
#line hidden
            EndContext();
            BeginContext(607, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(699, 9, false);
#line 22 "D:\KHOA\Other\SRC\SALE\Sales\SALES\Views\AdminCategory\_List.cshtml"
                       Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(708, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(800, 16, false);
#line 25 "D:\KHOA\Other\SRC\SALE\Sales\SALES\Views\AdminCategory\_List.cshtml"
                       Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(816, 91, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            EndContext();
            BeginContext(908, 12, false);
#line 28 "D:\KHOA\Other\SRC\SALE\Sales\SALES\Views\AdminCategory\_List.cshtml"
                       Write(item.Ischeck);

#line default
#line hidden
            EndContext();
            BeginContext(920, 194, true);
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            <button type=\"submit\" class=\"btn btn-danger  btn-sm pull-right\" id=\"btnDelete\" data-delete-product-id=\"");
            EndContext();
            BeginContext(1115, 7, false);
#line 31 "D:\KHOA\Other\SRC\SALE\Sales\SALES\Views\AdminCategory\_List.cshtml"
                                                                                                                              Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1122, 146, true);
            WriteLiteral("\">Delete</button>\r\n                            <button type=\"button\" class=\"btn btn-success btn-sm pull-right\" id=\"btnEdit\" data-edit-product-id=\"");
            EndContext();
            BeginContext(1269, 7, false);
#line 32 "D:\KHOA\Other\SRC\SALE\Sales\SALES\Views\AdminCategory\_List.cshtml"
                                                                                                                          Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1276, 33, true);
            WriteLiteral("\" data-edit-product-description=\"");
            EndContext();
            BeginContext(1310, 16, false);
#line 32 "D:\KHOA\Other\SRC\SALE\Sales\SALES\Views\AdminCategory\_List.cshtml"
                                                                                                                                                                   Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1326, 26, true);
            WriteLiteral("\" data-edit-product-name=\"");
            EndContext();
            BeginContext(1353, 9, false);
#line 32 "D:\KHOA\Other\SRC\SALE\Sales\SALES\Views\AdminCategory\_List.cshtml"
                                                                                                                                                                                                              Write(item.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1362, 29, true);
            WriteLiteral("\" data-edit-product-ischeck=\"");
            EndContext();
            BeginContext(1392, 12, false);
#line 32 "D:\KHOA\Other\SRC\SALE\Sales\SALES\Views\AdminCategory\_List.cshtml"
                                                                                                                                                                                                                                                     Write(item.Ischeck);

#line default
#line hidden
            EndContext();
            BeginContext(1404, 75, true);
            WriteLiteral("\">Edit</button>\r\n                        </td>\r\n                    </tr>\r\n");
            EndContext();
#line 35 "D:\KHOA\Other\SRC\SALE\Sales\SALES\Views\AdminCategory\_List.cshtml"
                }
            

#line default
#line hidden
            BeginContext(1513, 38, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SALES.Entities.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
