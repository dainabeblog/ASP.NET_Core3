#pragma checksum "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleRazorApp/SampleRazorApp/Pages/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce972fa64fd28a7989baee0c74e44f64d9408b82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(SampleRazorApp.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace SampleRazorApp.Pages
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
#line 1 "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleRazorApp/SampleRazorApp/Pages/_ViewImports.cshtml"
using SampleRazorApp;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{num?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce972fa64fd28a7989baee0c74e44f64d9408b82", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd1a5a5d87f610613be114257584530dd9d0d92c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleRazorApp/SampleRazorApp/Pages/Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n    <h1 class=\"display-4\">Welcome</h1>\n    <p>");
#nullable restore
#line 9 "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleRazorApp/SampleRazorApp/Pages/Index.cshtml"
  Write(Model.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\n");
            WriteLiteral("\n");
            WriteLiteral("\n    <p class=\"display-4 mb-4\">");
#nullable restore
#line 66 "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleRazorApp/SampleRazorApp/Pages/Index.cshtml"
                         Write(Model.Num);

#line default
#line hidden
#nullable disable
            WriteLiteral(" は、\n        <b>");
#nullable restore
#line 67 "/Users/watanabedaichi/Desktop/github.com/dainabeblog/ASP.NET_Core3/SampleRazorApp/SampleRazorApp/Pages/Index.cshtml"
       Write(Model.Num % 2 == 0 ? "偶数" : "奇数");

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>です。\n    </p>\n</div>\n");
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