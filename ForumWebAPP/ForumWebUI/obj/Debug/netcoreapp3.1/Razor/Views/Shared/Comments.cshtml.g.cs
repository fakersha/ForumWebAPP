#pragma checksum "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\Comments.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e426aac5a35b41f6b37adcb61c964a370589af0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Comments), @"mvc.1.0.view", @"/Views/Shared/Comments.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e426aac5a35b41f6b37adcb61c964a370589af0", @"/Views/Shared/Comments.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26aa5ed87d744f18f43ca35d44b5fb6a36e9a711", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Comments : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PostViewModel>
    {
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\Comments.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"Main2\">\r\n    <div class=\"container-fluid Plr\" id=\"AnotherCommentID\">\r\n        <div class=\"row\">\r\n            <div id=\"CommentBoxID\" class=\"d-block\">\r\n");
#nullable restore
#line 11 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\Comments.cshtml"
                 foreach (var comment in Model.Comments)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"d-flex MainComment pr-sm-0\">\r\n                        <img");
            BeginWriteAttribute("src", " src=\"", 382, "\"", 408, 1);
#nullable restore
#line 14 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\Comments.cshtml"
WriteAttributeValue("", 388, comment.User.ImgUrl, 388, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"30\" height=\"30\">\r\n                        <div class=\"col-lg-12 col-md-12 col-xs Grid d-flex IconsEffects\">\r\n                            <div id=\"CommentText\">\r\n                                <p>");
#nullable restore
#line 17 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\Comments.cshtml"
                              Write(comment.CommentDesctription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                <i class=\"fa fa-thumbs-up\"></i>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 22 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\Comments.cshtml"
                     foreach (var replayComments in comment.CommentReplies)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"d-flex ReplyComment pr-sm-0\">\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 1007, "\"", 1040, 1);
#nullable restore
#line 25 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\Comments.cshtml"
WriteAttributeValue("", 1013, replayComments.User.ImgUrl, 1013, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"30\" height=\"30\">\r\n                            <div class=\"col-lg-12 col-md-12 col-xs Grid d-flex IconsEffects\">\r\n                                <div id=\"CommentText2\">\r\n                                    <p>");
#nullable restore
#line 28 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\Comments.cshtml"
                                  Write(replayComments.ReplayDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                </div>\r\n                                <i class=\"fa fa-thumbs-up\"></i>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 33 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\Comments.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""d-flex ReplyComment BottomCorrect pr-sm-0"">
                        <img src=""https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png"" width=""30"" height=""30"">
                        <div class=""col-lg-12 col-md-12 col-xs Grid"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e426aac5a35b41f6b37adcb61c964a370589af07525", async() => {
                WriteLiteral(@"
                                <div class=""form-group d-flex IconsEffects"">
                                    <textarea class=""form-control"" id=""exampleFormControlTextarea2"" rows=""3""
                                              placeholder=""Write a comment...""></textarea>
                                    <i class=""fa fa-paper-plane""></i>
                                </div>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 46 "D:\ForumAspAPP\FinnalStep\ForumWebAPP\ForumWebAPP\ForumWebUI\Views\Shared\Comments.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>

<div class=""container-fluid Plr"" id=""WriteCommentID"">
    <div class=""row"">
        <div id=""CommentBoxID2"" class=""d-flex"">
            <img src=""https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png"" width=""30"" height=""30"">
            <div class=""col-lg-12 col-md-12 col-xs Grid"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e426aac5a35b41f6b37adcb61c964a370589af09869", async() => {
                WriteLiteral(@"
                    <div class=""form-group d-flex IconsEffects"">
                        <textarea class=""form-control"" id=""messageInput"" rows=""3""
                                  placeholder=""Write a comment...""></textarea>
                        <i class=""fa fa-paper-plane AddCommentBTN"" id=""sendButton""></i>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PostViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
