#pragma checksum "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\Post\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ba8fce94b9bb5d1e50d9fb8c9b7e22856d169ebb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Post_Details), @"mvc.1.0.view", @"/Pages/Post/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Post/Details.cshtml", typeof(AspNetCore.Pages_Post_Details))]
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
#line 1 "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\_ViewImports.cshtml"
using Blog.WEB;

#line default
#line hidden
#line 2 "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\_ViewImports.cshtml"
using Blog.BLL.Models;

#line default
#line hidden
#line 3 "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\_ViewImports.cshtml"
using Blog.BLL;

#line default
#line hidden
#line 4 "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\_ViewImports.cshtml"
using Blog.BLL.Rendering;

#line default
#line hidden
#line 5 "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\_ViewImports.cshtml"
using Blog.BLL.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba8fce94b9bb5d1e50d9fb8c9b7e22856d169ebb", @"/Pages/Post/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc16c27644d995d4c2ed5bb38743789cf1f728e0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Post_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SDSU.EDU.ProjectCore.BLL.Models.PostModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/StyleSheet.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("post_photo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\Post\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(93, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(95, 377, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ba8fce94b9bb5d1e50d9fb8c9b7e22856d169ebb5068", async() => {
                BeginContext(101, 307, true);
                WriteLiteral(@"

    <title></title>
    <link rel=""&lt;link rel=&quot;stylesheet&quot; href=&quot;https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css&quot; integrity=&quot;sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T&quot; crossorigin=&quot;anonymous&quot;&gt;"" />
    ");
                EndContext();
                BeginContext(408, 53, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ba8fce94b9bb5d1e50d9fb8c9b7e22856d169ebb5757", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(461, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(472, 45, true);
            WriteLiteral("\r\n\r\n<div class=\"container article\">\r\n    <div");
            EndContext();
            BeginWriteAttribute("class", " class=\"", 517, "\"", 525, 0);
            EndWriteAttribute();
            BeginContext(526, 11, true);
            WriteLiteral(">\r\n        ");
            EndContext();
            BeginContext(537, 57, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ba8fce94b9bb5d1e50d9fb8c9b7e22856d169ebb8160", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 547, "~/Images/", 547, 9, true);
#line 16 "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\Post\Details.cshtml"
AddHtmlAttributeValue("", 556, Model.FileName, 556, 15, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(594, 30, true);
            WriteLiteral("\r\n\r\n        <h3 class=\"title\">");
            EndContext();
            BeginContext(625, 11, false);
#line 18 "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\Post\Details.cshtml"
                     Write(Model.Title);

#line default
#line hidden
            EndContext();
            BeginContext(636, 32, true);
            WriteLiteral("</h3>\r\n        <h6 class=\"date\">");
            EndContext();
            BeginContext(669, 17, false);
#line 19 "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\Post\Details.cshtml"
                    Write(Model.DateCreated);

#line default
#line hidden
            EndContext();
            BeginContext(686, 45, true);
            WriteLiteral("</h6>\r\n        <p class=\"text\">\r\n            ");
            EndContext();
            BeginContext(732, 17, false);
#line 21 "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\Post\Details.cshtml"
       Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(749, 86, true);
            WriteLiteral("\r\n        </p>\r\n\r\n    </div>\r\n    <div class=\"view_more\">\r\n        <h5 class=\"author\">");
            EndContext();
            BeginContext(836, 20, false);
#line 26 "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\Post\Details.cshtml"
                      Write(Model.AuthorFullName);

#line default
#line hidden
            EndContext();
            BeginContext(856, 37, true);
            WriteLiteral("</h5>\r\n    </div>\r\n    <hr />\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SDSU.EDU.ProjectCore.BLL.Models.PostModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
