#pragma checksum "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\Shared\Error.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcdb6b116ee17da6b779c3e9089181d8ffca6664"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Shared_Error), @"mvc.1.0.view", @"/Pages/Shared/Error.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/Error.cshtml", typeof(AspNetCore.Pages_Shared_Error))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcdb6b116ee17da6b779c3e9089181d8ffca6664", @"/Pages/Shared/Error.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc16c27644d995d4c2ed5bb38743789cf1f728e0", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Error : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog.BLL.ViewModels.ErrorViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\Shared\Error.cshtml"
  
    ViewData["Title"] = "Error";

#line default
#line hidden
            BeginContext(84, 120, true);
            WriteLiteral("\r\n<h1 class=\"text-danger\">Error.</h1>\r\n<h2 class=\"text-danger\">An error occurred while processing your request.</h2>\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\Shared\Error.cshtml"
 if (Model.ShowRequestId)
{

#line default
#line hidden
            BeginContext(234, 52, true);
            WriteLiteral("    <p>\r\n        <strong>Request ID:</strong> <code>");
            EndContext();
            BeginContext(287, 15, false);
#line 12 "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\Shared\Error.cshtml"
                                      Write(Model.RequestId);

#line default
#line hidden
            EndContext();
            BeginContext(302, 19, true);
            WriteLiteral("</code>\r\n    </p>\r\n");
            EndContext();
#line 14 "C:\Users\Phoenix\source\repos\Blog.WEB\Blog.WEB\Pages\Shared\Error.cshtml"
}

#line default
#line hidden
            BeginContext(324, 577, true);
            WriteLiteral(@"
<h3>Development Mode</h3>
<p>
    Swapping to <strong>Development</strong> environment will display more detailed information about the error that occurred.
</p>
<p>
    <strong>The Development environment shouldn't be enabled for deployed applications.</strong>
    It can result in displaying sensitive information from exceptions to end users.
    For local debugging, enable the <strong>Development</strong> environment by setting the <strong>ASPNETCORE_ENVIRONMENT</strong> environment variable to <strong>Development</strong>
    and restarting the app.
</p>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog.BLL.ViewModels.ErrorViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
