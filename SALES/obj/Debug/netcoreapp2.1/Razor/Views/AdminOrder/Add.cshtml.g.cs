#pragma checksum "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminOrder\Add.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "153a9ecff846d6c70d47ad5db750ca97240ed020"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminOrder_Add), @"mvc.1.0.view", @"/Views/AdminOrder/Add.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminOrder/Add.cshtml", typeof(AspNetCore.Views_AdminOrder_Add))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"153a9ecff846d6c70d47ad5db750ca97240ed020", @"/Views/AdminOrder/Add.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a6bc254dbf1cb356757ac8578a2ab2dd4255c0a", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminOrder_Add : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminOrder\Add.cshtml"
  
    ViewData["Title"] = "Add";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(93, 3061, true);
            WriteLiteral(@"
    <div class=""content"">
        <div class=""container-fluid"">
            <div class=""card"">
                <div class=""card-header card-header-primary"">
                    <h4 class=""card-title"">Sản phẩm bán</h4>
                    <p class=""card-category"">Quản trị sản phẩm</p>
                </div>
                <div class=""card-body"">
                    <div style=""padding: 10px""></div>
                    <div id=""typography"">
                        <div class=""row"">
                            <div class=""col-md-12"">
                                <button type=""button"" class=""btn btn-primary btn-sm pull-right"">Danh sách</button>
                            </div>
                            <div class=""col-md-12"">
                                <hr />
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=""bmd-label-floating"">Tên sản phẩ");
            WriteLiteral(@"m</label>
                                    <input type=""text"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=""bmd-label-floating"">Số lượng </label>
                                    <input type=""text"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=""bmd-label-floating"">Giá</label>
                                    <input type=""text"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <div class=""form-group"">
                                    <label class=");
            WriteLiteral(@"""bmd-label-floating"">Giảm giá</label>
                                    <input type=""text"" class=""form-control"">
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <div class=""form-group"">
                                    <label class=""bmd-label-floating"">Tổng tiền</label>
                                    <input type=""text"" class=""form-control"" >
                                </div>
                            </div>
                            <div class=""col-md-12"">
                                <hr />
                            </div>
                            <div class=""col-md-12"">
                                <button type=""button"" class=""btn btn-primary pull-right"">Lưu thông tin</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
