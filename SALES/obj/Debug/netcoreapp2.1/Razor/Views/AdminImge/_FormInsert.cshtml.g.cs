#pragma checksum "C:\Users\khoai\Downloads\SALES\SALES\Views\AdminImge\_FormInsert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e0d12a363a2aea58b47f210a1e44ccca3e7ac42"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminImge__FormInsert), @"mvc.1.0.view", @"/Views/AdminImge/_FormInsert.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminImge/_FormInsert.cshtml", typeof(AspNetCore.Views_AdminImge__FormInsert))]
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
#line 1 "C:\Users\khoai\Downloads\SALES\SALES\Views\_ViewImports.cshtml"
using WEBAPP;

#line default
#line hidden
#line 2 "C:\Users\khoai\Downloads\SALES\SALES\Views\_ViewImports.cshtml"
using WEBAPP.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e0d12a363a2aea58b47f210a1e44ccca3e7ac42", @"/Views/AdminImge/_FormInsert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a6bc254dbf1cb356757ac8578a2ab2dd4255c0a", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminImge__FormInsert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SALES.Entities.Image>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 60, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div>\r\n        <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 89, "\"", 106, 1);
#line 5 "C:\Users\khoai\Downloads\SALES\SALES\Views\AdminImge\_FormInsert.cshtml"
WriteAttributeValue("", 97, Model.Id, 97, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(107, 563, true);
            WriteLiteral(@" id=""txtId"" />
    </div>
    <div class=""col-md-6"">
        <div class=""form-group"">
            <label class=""bmd-label-floating"">Tên hình sản phẩm</label>
            <input type=""text"" class=""form-control"" id=""txtName"">
        </div>
    </div>
    <div class=""col-md-6 text-center"" style=""padding-top: 15px;"">
        <input type=""file"" id=""FileUpload1"" multiple class=""form-file-upload"" />
    </div>
    <div class=""col-md-12"">
        <div class=""form-group"">
            <label class=""bmd-label-floating"">Chọn sản phẩm</label>
            ");
            EndContext();
            BeginContext(671, 157, false);
#line 19 "C:\Users\khoai\Downloads\SALES\SALES\Views\AdminImge\_FormInsert.cshtml"
       Write(Html.DropDownListFor(m => m.ProductId, new SelectList(ViewBag.Product, "Value", "Text"), "-- Chọn --", new { @class = "form-control", @id = "ddlProductId" }));

#line default
#line hidden
            EndContext();
            BeginContext(828, 262, true);
            WriteLiteral(@"
        </div>
    </div>
    <div class=""col-md-12"">
        <button name=""btnSave"" class=""btn btn-primary pull-right"">Lưu thông tin</button>
        <button name=""btnCancel"" class=""btn btn-warning pull-right"">Hủy thao tác</button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SALES.Entities.Image> Html { get; private set; }
    }
}
#pragma warning restore 1591
