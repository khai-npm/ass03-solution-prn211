#pragma checksum "C:\Users\pc\Desktop\FPTU work document\PRN211_work\Ass03Solution_NET1705_NguyenPhanManhKhai\eFURentingManagement\Views\Register\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "962ad47d51972f57219139d8fa00286afcef343c78c73559fdbaa4a853d1c215"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Index), @"mvc.1.0.view", @"/Views/Register/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\pc\Desktop\FPTU work document\PRN211_work\Ass03Solution_NET1705_NguyenPhanManhKhai\eFURentingManagement\Views\_ViewImports.cshtml"
using eFURentingManagement;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pc\Desktop\FPTU work document\PRN211_work\Ass03Solution_NET1705_NguyenPhanManhKhai\eFURentingManagement\Views\_ViewImports.cshtml"
using eFURentingManagement.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"962ad47d51972f57219139d8fa00286afcef343c78c73559fdbaa4a853d1c215", @"/Views/Register/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"a0daf9d11f44ea60e818ad48face4a485d18948e5469203aa991bad93593e92a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Register_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Submit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 60%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\pc\Desktop\FPTU work document\PRN211_work\Ass03Solution_NET1705_NguyenPhanManhKhai\eFURentingManagement\Views\Register\Index.cshtml"
  
    ViewData["Title"] = "Register";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"d-flex flex-column align-items-left\" style=\"width: 100%;\">\r\n    <h1 class=\"display-4 mb-5\">Register</h1>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "962ad47d51972f57219139d8fa00286afcef343c78c73559fdbaa4a853d1c2154958", async() => {
                WriteLiteral("\r\n        <div class=\"form-group d-flex align-items-center justify-content-left\">\r\n            <input class=\"form-control\" name=\"emailaddress\" style=\"width: 70%;\" placeholder=\"EmailAddress\" />\r\n        </div>\r\n        <div class=\"text-danger my-4\">");
#nullable restore
#line 14 "C:\Users\pc\Desktop\FPTU work document\PRN211_work\Ass03Solution_NET1705_NguyenPhanManhKhai\eFURentingManagement\Views\Register\Index.cshtml"
                                 Write(ViewBag.EmailExistError);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</div>
        <div class=""form-group d-flex align-items-center justify-content-left"">
            <input class=""form-control"" name=""username"" style=""width: 70%;"" placeholder=""UserName"" />
        </div>
        <div class=""form-group d-flex align-items-center justify-content-left"">
            <input class=""form-control"" name=""telephone"" style=""width: 70%;"" placeholder=""PhoneNumber"" />
        </div>
        <div class=""form-group d-flex align-items-center justify-content-left"">
            Birthday: <input class=""form-control"" type=""date"" name=""birthday"" style=""width: 70%;"" />
        </div>
        <div class=""form-group d-flex align-items-center justify-content-left"">
            <input class=""form-control"" type=""password"" name=""memberpassword"" style=""width: 70%;"" placeholder=""MemberPassword"" />
        </div>
        <div class=""form-group d-flex align-items-center justify-content-left"">
            <input class=""form-control"" type=""password"" name=""confirmpassword"" style=""width: 70%;"" place");
                WriteLiteral("holder=\"ConfirmMemberPassword\" />\r\n        </div>\r\n        <div class=\"text-danger my-4\">");
#nullable restore
#line 30 "C:\Users\pc\Desktop\FPTU work document\PRN211_work\Ass03Solution_NET1705_NguyenPhanManhKhai\eFURentingManagement\Views\Register\Index.cshtml"
                                 Write(ViewBag.ConfirmPasswordError);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n\r\n        <div class=\"d-flex justify-content-left\">\r\n            <input type=\"submit\" class=\"btn btn-primary px-3\" style=\"width: 30%;\" value=\"Register\" />\r\n        </div>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
