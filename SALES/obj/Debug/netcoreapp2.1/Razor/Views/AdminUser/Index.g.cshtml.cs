#pragma checksum "D:\KHOA\Other\SRC\APP\SALES\SALES\Views\AdminUser\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8fc94fe55c53a1de87a6b43d56ee48caa2522063"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminUser_Index), @"mvc.1.0.view", @"/Views/AdminUser/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminUser/Index.cshtml", typeof(AspNetCore.Views_AdminUser_Index))]
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
#line 1 "D:\KHOA\Other\SRC\APP\SALES\SALES\Views\_ViewImports.cshtml"
using WEBAPP;

#line default
#line hidden
#line 2 "D:\KHOA\Other\SRC\APP\SALES\SALES\Views\_ViewImports.cshtml"
using WEBAPP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8fc94fe55c53a1de87a6b43d56ee48caa2522063", @"/Views/AdminUser/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a6bc254dbf1cb356757ac8578a2ab2dd4255c0a", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminUser_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\KHOA\Other\SRC\APP\SALES\SALES\Views\AdminUser\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
            BeginContext(95, 3126, true);
            WriteLiteral(@"

<div class=""content"">
    <div class=""container-fluid"">
        <div class=""card"">
            <div class=""card-header card-header-primary"">
                <h4 class=""card-title"">Thành viên</h4>
                <p class=""card-category"">Quản trị thành viên</p>
            </div>
            <div class=""card-body"">
                <div style=""padding: 20px"">

                </div>
                <div id=""typography"">
                    <div class=""row"">
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Họ & tên</label>
                                <input type=""text"" class=""form-control"">
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Ngày sinh</label>
                                ");
            WriteLiteral(@"<input type=""text"" class=""form-control"">
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Số điện thoại</label>
                                <input type=""text"" class=""form-control"">
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Tên đăng nhập</label>
                                <input type=""text"" class=""form-control"">
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Mật khẩu</label>
                                <input type=""text"" class=""form");
            WriteLiteral(@"-control"">
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Nhập lại mật khẩu</label>
                                <input type=""text"" class=""form-control"">
                            </div>
                        </div>
                        <div class=""col-md-4"">
                            <div class=""form-group"">
                                <label class=""bmd-label-floating"">Email</label>
                                <input type=""text"" class=""form-control"">
                            </div>
                        </div>
                        <div class=""col-md-12"">
                            <hr />
                            <button type=""submit"" class=""btn btn-primary pull-right"">Lưu thông tin</button>
                        </div>
                    </div>
                </div>
    ");
            WriteLiteral("        </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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