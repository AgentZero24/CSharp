#pragma checksum "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/aSP.net/DojoSurvey/Views/Hello/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d20b03369d4806fd1175dfd04d6a2f0593f6f6e8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hello_Index), @"mvc.1.0.view", @"/Views/Hello/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Hello/Index.cshtml", typeof(AspNetCore.Views_Hello_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d20b03369d4806fd1175dfd04d6a2f0593f6f6e8", @"/Views/Hello/Index.cshtml")]
    public class Views_Hello_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DojoSurvey.Models.Survey>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(32, 34, true);
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            EndContext();
            BeginContext(66, 358, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d20b03369d4806fd1175dfd04d6a2f0593f6f6e83244", async() => {
                BeginContext(72, 345, true);
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css"" integrity=""sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T"" crossorigin=""anonymous"">
    <title>Survey</title>
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
            BeginContext(424, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(425, 772, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d20b03369d4806fd1175dfd04d6a2f0593f6f6e84760", async() => {
                BeginContext(452, 201, true);
                WriteLiteral("\n    <div class=\"col-8\" >\n    <form action=\"/surveyresults\" method=\"POST\">\n        <label for=\"name\">Name:</label>\n        <input type=\"text\"name=\"name\">\n        <br>\n        <select name=\"location\" >\n");
                EndContext();
#line 18 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/aSP.net/DojoSurvey/Views/Hello/Index.cshtml"
             foreach(var local in ViewBag.locations)
            {

#line default
#line hidden
                BeginContext(720, 23, true);
                WriteLiteral("                <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 743, "\"", 757, 1);
#line 20 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/aSP.net/DojoSurvey/Views/Hello/Index.cshtml"
WriteAttributeValue("", 751, local, 751, 6, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(758, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(760, 5, false);
#line 20 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/aSP.net/DojoSurvey/Views/Hello/Index.cshtml"
                                  Write(local);

#line default
#line hidden
                EndContext();
                BeginContext(765, 10, true);
                WriteLiteral("</option>\n");
                EndContext();
#line 21 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/aSP.net/DojoSurvey/Views/Hello/Index.cshtml"
            }

#line default
#line hidden
                BeginContext(789, 66, true);
                WriteLiteral("\n        </select>\n        <br>\n        <select name=\"language\" >\n");
                EndContext();
#line 26 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/aSP.net/DojoSurvey/Views/Hello/Index.cshtml"
             foreach(var lang in ViewBag.language)
            {

#line default
#line hidden
                BeginContext(920, 23, true);
                WriteLiteral("                <option");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 943, "\"", 956, 1);
#line 28 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/aSP.net/DojoSurvey/Views/Hello/Index.cshtml"
WriteAttributeValue("", 951, lang, 951, 5, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(957, 1, true);
                WriteLiteral(">");
                EndContext();
                BeginContext(959, 4, false);
#line 28 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/aSP.net/DojoSurvey/Views/Hello/Index.cshtml"
                                 Write(lang);

#line default
#line hidden
                EndContext();
                BeginContext(963, 10, true);
                WriteLiteral("</option>\n");
                EndContext();
#line 29 "/Users/paul_kramer/Desktop/dojo_assignments/cSharp/aSP.net/DojoSurvey/Views/Hello/Index.cshtml"
            }

#line default
#line hidden
                BeginContext(987, 203, true);
                WriteLiteral("\n        </select>\n        <br>\n    \n        <p>Comments (Optional): <input name=\"comment\" type=\"text\"></p>\n\n        <button class= \"btn btn-success\" type=\"submit\">Submit</button>\n    </form>\n    </div>\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1197, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DojoSurvey.Models.Survey> Html { get; private set; }
    }
}
#pragma warning restore 1591
