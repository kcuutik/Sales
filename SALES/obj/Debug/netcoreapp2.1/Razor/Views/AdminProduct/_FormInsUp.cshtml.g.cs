#pragma checksum "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminProduct\_FormInsUp.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1128c0f95923be5ab3e283a42b0113ed93aeb35"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminProduct__FormInsUp), @"mvc.1.0.view", @"/Views/AdminProduct/_FormInsUp.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/AdminProduct/_FormInsUp.cshtml", typeof(AspNetCore.Views_AdminProduct__FormInsUp))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1128c0f95923be5ab3e283a42b0113ed93aeb35", @"/Views/AdminProduct/_FormInsUp.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a6bc254dbf1cb356757ac8578a2ab2dd4255c0a", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminProduct__FormInsUp : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SALES.Entities.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/js/jquery-3.4.1.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/js/jquery-3.4.1.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/tinymce.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/init-tinymce.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 64, true);
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n    <div>\r\n        <input type=\"hidden\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 95, "\"", 112, 1);
#line 7 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminProduct\_FormInsUp.cshtml"
WriteAttributeValue("", 103, Model.Id, 103, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(113, 170, true);
            WriteLiteral(" id=\"txtId\" />\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <div class=\"form-group\">\r\n            <label class=\"bmd-label-floating\">Tên sản phẩm</label>\r\n            ");
            EndContext();
            BeginContext(284, 82, false);
#line 12 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminProduct\_FormInsUp.cshtml"
       Write(Html.TextBoxFor(m => Model.Name, new { @class = "form-control", @id = "txtName" }));

#line default
#line hidden
            EndContext();
            BeginContext(366, 215, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <div class=\"form-group\">\r\n            <label class=\"bmd-label-floating\">Loại sản phẩm</label>\r\n            ");
            EndContext();
            BeginContext(582, 158, false);
#line 21 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminProduct\_FormInsUp.cshtml"
       Write(Html.DropDownListFor(m => m.CategoryId, new SelectList(ViewBag.Category, "Value", "Text"), "-- Chọn --", new { @class = "form-control", @id = "ddlCategory" }));

#line default
#line hidden
            EndContext();
            BeginContext(740, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(853, 165, true);
            WriteLiteral("        </div>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <div class=\"form-group\">\r\n            <label class=\"bmd-label-floating\">Tiêu đề</label>\r\n            ");
            EndContext();
            BeginContext(1019, 84, false);
#line 28 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminProduct\_FormInsUp.cshtml"
       Write(Html.TextBoxFor(m => Model.Title, new { @class = "form-control", @id = "txtTitle" }));

#line default
#line hidden
            EndContext();
            BeginContext(1103, 173, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6\">      \r\n        <div class=\"form-group\">\r\n            <label class=\"bmd-label-floating\">Giá mua</label>\r\n            ");
            EndContext();
            BeginContext(1277, 88, false);
#line 34 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminProduct\_FormInsUp.cshtml"
       Write(Html.TextBoxFor(m => Model.PriceIn, new { @class = "form-control", @id = "txtPriceIn" }));

#line default
#line hidden
            EndContext();
            BeginContext(1365, 167, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <div class=\"form-group\">\r\n            <label class=\"bmd-label-floating\">Giá bán</label>\r\n            ");
            EndContext();
            BeginContext(1533, 90, false);
#line 40 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminProduct\_FormInsUp.cshtml"
       Write(Html.TextBoxFor(m => Model.PriceOut, new { @class = "form-control", @id = "txtPriceOut" }));

#line default
#line hidden
            EndContext();
            BeginContext(1623, 177, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <div class=\"form-group\">\r\n            <label class=\"bmd-label-floating\">Số lượng nhập kho</label>\r\n            ");
            EndContext();
            BeginContext(1801, 94, false);
#line 46 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminProduct\_FormInsUp.cshtml"
       Write(Html.TextBoxFor(m => Model.QuantilyIn, new { @class = "form-control", @id = "txtQuantilyIn" }));

#line default
#line hidden
            EndContext();
            BeginContext(1895, 175, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <div class=\"form-group\">\r\n            <label class=\"bmd-label-floating\">Số lượng đã bán</label>\r\n            ");
            EndContext();
            BeginContext(2071, 96, false);
#line 52 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminProduct\_FormInsUp.cshtml"
       Write(Html.TextBoxFor(m => Model.QuantilyOut, new { @class = "form-control", @id = "txtQuantilyOut" }));

#line default
#line hidden
            EndContext();
            BeginContext(2167, 168, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <div class=\"form-group\">\r\n            <label class=\"bmd-label-floating\">Giảm giá</label>\r\n            ");
            EndContext();
            BeginContext(2336, 90, false);
#line 58 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminProduct\_FormInsUp.cshtml"
       Write(Html.TextBoxFor(m => Model.Discount, new { @class = "form-control", @id = "txtDiscount" }));

#line default
#line hidden
            EndContext();
            BeginContext(2426, 168, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-6\">\r\n        <div class=\"form-group\">\r\n            <label class=\"bmd-label-floating\">Contentt</label>\r\n            ");
            EndContext();
            BeginContext(2595, 90, false);
#line 64 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminProduct\_FormInsUp.cshtml"
       Write(Html.TextBoxFor(m => Model.Contentt, new { @class = "form-control", @id = "txtContentt" }));

#line default
#line hidden
            EndContext();
            BeginContext(2685, 168, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div class=\"col-md-12\">\r\n        <div class=\"form-group\">\r\n            <label class=\"bmd-label-floating\">Keyword</label>\r\n            ");
            EndContext();
            BeginContext(2854, 90, false);
#line 70 "C:\Users\khoai\OneDrive\Máy tính\ThuocLaThom\Sales\SALES\Views\AdminProduct\_FormInsUp.cshtml"
       Write(Html.TextBoxFor(m => Model.Keywords, new { @class = "form-control", @id = "txtKeywords" }));

#line default
#line hidden
            EndContext();
            BeginContext(2944, 530, true);
            WriteLiteral(@"
        </div>
    </div>
    <div class=""col-md-12"">
        <div class=""form-group"">
            <label class=""bmd-label-floating"">Mô tả sản phẩm</label>
        </div>
        <textarea id=""txtDesciption""></textarea>
    </div>
    <div class=""col-md-12"">
        <hr />
    </div>
    <div class=""col-md-12"">
        <button name=""btnSave"" class=""btn btn-primary pull-right"">Lưu thông tin</button>
        <button name=""btnCancel"" class=""btn btn-warning pull-right"">Hủy thao tác</button>
    </div>
</div>

");
            EndContext();
            BeginContext(3474, 48, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7a359ca37a5b4eb9a7ee95a7d2cd19ce", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3522, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3524, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bbd036d89a0846e2b1bf2b70f54d4f34", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3576, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3578, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad9182235a3c4adf918de0945375ced2", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3621, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3623, 44, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b771b8afd13548e4bbec5512fe350a3e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3667, 68, true);
            WriteLiteral("\r\n\r\n<script>\r\n    tinymce.init({ selector: \'textarea\' });\r\n</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SALES.Entities.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
