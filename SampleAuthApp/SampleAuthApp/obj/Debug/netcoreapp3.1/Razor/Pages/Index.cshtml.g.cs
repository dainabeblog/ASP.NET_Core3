#pragma checksum "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleAuthApp/SampleAuthApp/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22e3492bb78ed7a2a79dbee7739f079a919530c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SampleAuthApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace SampleAuthApp.Pages
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
#line 1 "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleAuthApp/SampleAuthApp/Pages/_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleAuthApp/SampleAuthApp/Pages/_ViewImports.cshtml"
using SampleAuthApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleAuthApp/SampleAuthApp/Pages/_ViewImports.cshtml"
using SampleAuthApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleAuthApp/SampleAuthApp/Pages/_ViewImports.cshtml"
using SampleAuthApp.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22e3492bb78ed7a2a79dbee7739f079a919530c8", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95010d0fe461430bac7719d94f8a2aa0e3bddd13", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
        private global::SampleAuthApp.TagHelpers.SampleTagHelper __SampleAuthApp_TagHelpers_SampleTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleAuthApp/SampleAuthApp/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

    var data = new List<string>();
    data.Add("One");
    data.Add("2");
    data.Add("3");
    data.Add("4");

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"text-center\">\n    <h1 class=\"display-4\">Welcome</h1>\n    <p>");
#nullable restore
#line 15 "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleAuthApp/SampleAuthApp/Pages/Index.cshtml"
  Write(Model.SampleData);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("sample", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "22e3492bb78ed7a2a79dbee7739f079a919530c84232", async() => {
            }
            );
            __SampleAuthApp_TagHelpers_SampleTagHelper = CreateTagHelper<global::SampleAuthApp.TagHelpers.SampleTagHelper>();
            __tagHelperExecutionContext.Add(__SampleAuthApp_TagHelpers_SampleTagHelper);
#nullable restore
#line 16 "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleAuthApp/SampleAuthApp/Pages/Index.cshtml"
__SampleAuthApp_TagHelpers_SampleTagHelper.items = data;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("items", __SampleAuthApp_TagHelpers_SampleTagHelper.items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\n\n    <p class=\"h4\">\n        ID:\n        ");
#nullable restore
#line 21 "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleAuthApp/SampleAuthApp/Pages/Index.cshtml"
    Write(User.Identity.Name==null ? "nodata" : User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        ");
#nullable restore
#line 22 "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleAuthApp/SampleAuthApp/Pages/Index.cshtml"
    Write(User.Identity.IsAuthenticated + "/" + User.Identity.AuthenticationType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n    </p>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591