#pragma checksum "E:\ASP.net\EduHome\Views\Shared\_LoadMorePartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26c241e06933439f74df1b0180f6fba8a5dfcefd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__LoadMorePartial), @"mvc.1.0.view", @"/Views/Shared/_LoadMorePartial.cshtml")]
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
#line 1 "E:\ASP.net\EduHome\Views\_ViewImports.cshtml"
using EduPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ASP.net\EduHome\Views\_ViewImports.cshtml"
using EduPage.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ASP.net\EduHome\Views\_ViewImports.cshtml"
using EduPage.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26c241e06933439f74df1b0180f6fba8a5dfcefd", @"/Views/Shared/_LoadMorePartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"647c2df877e25488994ca7a22377cbffb3837843", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__LoadMorePartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Course>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\ASP.net\EduHome\Views\Shared\_LoadMorePartial.cshtml"
 foreach (Course course in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-md-4 hidden-sm col-xs-12\">\r\n        <div class=\"single-course\">\r\n            <div class=\"course-img\">\r\n                <a href=\"course-details.html\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26c241e06933439f74df1b0180f6fba8a5dfcefd3919", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 260, "~/img/course/", 260, 13, true);
#nullable restore
#line 8 "E:\ASP.net\EduHome\Views\Shared\_LoadMorePartial.cshtml"
AddHtmlAttributeValue("", 273, course.Image, 273, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    <div class=""course-hover"">
                        <i class=""fa fa-link""></i>
                    </div>
                </a>
            </div>
            <div class=""course-content"">
                <h3><a href=""course-details.html"">");
#nullable restore
#line 15 "E:\ASP.net\EduHome\Views\Shared\_LoadMorePartial.cshtml"
                                             Write(course.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                <p>");
#nullable restore
#line 16 "E:\ASP.net\EduHome\Views\Shared\_LoadMorePartial.cshtml"
              Write(course.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <a class=\"default-btn\" href=\"course-details.html\">read more</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 21 "E:\ASP.net\EduHome\Views\Shared\_LoadMorePartial.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Course>> Html { get; private set; }
    }
}
#pragma warning restore 1591
