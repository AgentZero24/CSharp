#pragma checksum "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/ORM/ChefsAndDishes/Views/Home/Dishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1506b857e9dee8d88324ed349fecb647894e0b17"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Dishes), @"mvc.1.0.view", @"/Views/Home/Dishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Dishes.cshtml", typeof(AspNetCore.Views_Home_Dishes))]
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
#line 1 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/ORM/ChefsAndDishes/Views/_ViewImports.cshtml"
using ChefsAndDishes;

#line default
#line hidden
#line 2 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/ORM/ChefsAndDishes/Views/_ViewImports.cshtml"
using ChefsAndDishes.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1506b857e9dee8d88324ed349fecb647894e0b17", @"/Views/Home/Dishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e01085002f792202768963d7d0c07b88e1c684e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Dishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Dish>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(18, 34, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(52, 361, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1506b857e9dee8d88324ed349fecb647894e0b173361", async() => {
                BeginContext(58, 348, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Dish List</title>
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"" integrity=""sha384-9aIt2nRpC12Uk9gS9baDl411NQApFmC26EwAOH8WgZl5MYYxFfc+NcPb1dKGj7Sk"" crossorigin=""anonymous"">
");
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
            BeginContext(413, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(414, 1479, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1506b857e9dee8d88324ed349fecb647894e0b174881", async() => {
                BeginContext(420, 860, true);
                WriteLiteral(@"
    <div class=""container"">
        <div class=""text-right"">
            <a href=""/new/dish"">Add a Dish</a>
        </div>
        <div class=""row text-center"">
            <h3><a href=""/"">Chefs</a> | Dishes</h3>
        </div>
        <div class=""row"">
            <div class=""col-8"">
                <h4 class=""border-bottom pb-3"">Check out these Dishes</h4>
                <div class=""list mt-3"">
                    <table class=""table table-dark"">
                        <thead>
                            <tr>
                                <th scope=""col"">Name</th>
                                <th scope=""col"">Chef</th>
                                <th scope=""col"">Tastiness</th>
                                <th scope=""col"">Calories</th>
                            </tr>
                        </thead>
                        <tbody>
");
                EndContext();
#line 33 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/ORM/ChefsAndDishes/Views/Home/Dishes.cshtml"
                             foreach (Dish dish in Model)
                            {

#line default
#line hidden
                BeginContext(1368, 77, true);
                WriteLiteral("                                <tr>\n                                    <th>");
                EndContext();
                BeginContext(1446, 15, false);
#line 36 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/ORM/ChefsAndDishes/Views/Home/Dishes.cshtml"
                                   Write(dish.NameOfDish);

#line default
#line hidden
                EndContext();
                BeginContext(1461, 46, true);
                WriteLiteral("</th>\n                                    <th>");
                EndContext();
                BeginContext(1508, 22, false);
#line 37 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/ORM/ChefsAndDishes/Views/Home/Dishes.cshtml"
                                   Write(dish.Creator.FirstName);

#line default
#line hidden
                EndContext();
                BeginContext(1530, 1, true);
                WriteLiteral(" ");
                EndContext();
                BeginContext(1532, 21, false);
#line 37 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/ORM/ChefsAndDishes/Views/Home/Dishes.cshtml"
                                                           Write(dish.Creator.LastName);

#line default
#line hidden
                EndContext();
                BeginContext(1553, 46, true);
                WriteLiteral("</th>\n                                    <th>");
                EndContext();
                BeginContext(1600, 14, false);
#line 38 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/ORM/ChefsAndDishes/Views/Home/Dishes.cshtml"
                                   Write(dish.Tastiness);

#line default
#line hidden
                EndContext();
                BeginContext(1614, 46, true);
                WriteLiteral("</th>\n                                    <th>");
                EndContext();
                BeginContext(1661, 21, false);
#line 39 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/ORM/ChefsAndDishes/Views/Home/Dishes.cshtml"
                                   Write(dish.NumberOfCalories);

#line default
#line hidden
                EndContext();
                BeginContext(1682, 44, true);
                WriteLiteral("</th>\n                                </tr>\n");
                EndContext();
#line 41 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/ORM/ChefsAndDishes/Views/Home/Dishes.cshtml"
                            }

#line default
#line hidden
                BeginContext(1756, 130, true);
                WriteLiteral("                        </tbody>\n                    </table>\n                </div>\n            </div>\n        </div>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1893, 8, true);
            WriteLiteral("\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Dish>> Html { get; private set; }
    }
}
#pragma warning restore 1591
