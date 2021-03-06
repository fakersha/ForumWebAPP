#pragma checksum "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\BlockUsers.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83a13fcf63a30e3e61d3c3d966415a775259dd9b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_BlockUsers), @"mvc.1.0.view", @"/Views/Shared/BlockUsers.cshtml")]
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
#line 1 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\_ViewImports.cshtml"
using ForumWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\_ViewImports.cshtml"
using ForumWebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\_ViewImports.cshtml"
using ForumWebAPPUI.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\_ViewImports.cshtml"
using ForumWebAPPUI.Helper;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83a13fcf63a30e3e61d3c3d966415a775259dd9b", @"/Views/Shared/BlockUsers.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26aa5ed87d744f18f43ca35d44b5fb6a36e9a711", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_BlockUsers : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-sm btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "BlockUsers", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\BlockUsers.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1 id=\"BlockUserTitleId\" class=\"text-uppercase text-center text-danger\">Block User</h1>\r\n");
#nullable restore
#line 9 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\BlockUsers.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p class=\"text-warning text-uppercase text-center fs-5 fw-bold\">No users to block!</p>\r\n");
#nullable restore
#line 12 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\BlockUsers.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\r\n        <thead>\r\n            <tr class=\"text-center text-uppercase\">\r\n                <th scope=\"col\">Email</th>\r\n                <th scope=\"col\"></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 23 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\BlockUsers.cshtml"
              
                if (Model != null)
                {
                    foreach (var user in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr class=\"text-center text-uppercase\">\r\n                            <td>");
#nullable restore
#line 29 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\BlockUsers.cshtml"
                           Write(user.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83a13fcf63a30e3e61d3c3d966415a775259dd9b6373", async() => {
                WriteLiteral("Block");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\BlockUsers.cshtml"
                                                                                                                  WriteLiteral(user.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n                        </tr>\r\n");
#nullable restore
#line 32 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\BlockUsers.cshtml"
                    }
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 37 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\BlockUsers.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
