#pragma checksum "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/ORM/WeddingPlanner/Views/WeddingPlanner/Dashboard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "03a6fbd007a0c6248df2efa11d2b559b58223746"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WeddingPlanner_Dashboard), @"mvc.1.0.view", @"/Views/WeddingPlanner/Dashboard.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/WeddingPlanner/Dashboard.cshtml", typeof(AspNetCore.Views_WeddingPlanner_Dashboard))]
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
#line 1 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/ORM/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner;

#line default
#line hidden
#line 2 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/ORM/WeddingPlanner/Views/_ViewImports.cshtml"
using WeddingPlanner.Models;

#line default
#line hidden
#line 3 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/ORM/WeddingPlanner/Views/_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03a6fbd007a0c6248df2efa11d2b559b58223746", @"/Views/WeddingPlanner/Dashboard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f74b8ca08b40f37ad1199f2c8f4e56e10e34ca9b", @"/Views/_ViewImports.cshtml")]
    public class Views_WeddingPlanner_Dashboard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(12, 661, true);
            WriteLiteral(@"

    <div class=""container"">
        <div class=""row"">
            <div class=""col-8"">
                <h4 class=""border-bottom pb-3"">Check out these Weddings</h4>
                <div class=""list mt-3"">
                    <table class=""table table-dark"">
                        <thead>
                            <tr>
                                <th scope=""col"">Wedding</th>
                                <th scope=""col"">Date</th>
                                <th scope=""col"">Guests</th>
                                <th scope=""col"">Action</th>
                            </tr>
                        </thead>
                        <tbody>
");
            EndContext();
            BeginContext(1069, 202, true);
            WriteLiteral("                        </tbody>\n                            <h3><a href=\"/wedding\">Add Wedding</a></h3>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591