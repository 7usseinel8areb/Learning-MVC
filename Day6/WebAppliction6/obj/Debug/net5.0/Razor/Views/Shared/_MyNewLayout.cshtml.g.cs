#pragma checksum "C:\100DayChallenge\MVC\Day6\WebAppliction6\Views\Shared\_MyNewLayout.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8ed437119a0cb7efd42369ebb1dc8e5f59dff89bfb49e538ce098f1e9a774c9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__MyNewLayout), @"mvc.1.0.view", @"/Views/Shared/_MyNewLayout.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\100DayChallenge\MVC\Day6\WebAppliction6\Views\_ViewImports.cshtml"
using WebApplication4;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\100DayChallenge\MVC\Day6\WebAppliction6\Views\_ViewImports.cshtml"
using WebApplication4.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\100DayChallenge\MVC\Day6\WebAppliction6\Views\_ViewImports.cshtml"
using WebApplication4.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"8ed437119a0cb7efd42369ebb1dc8e5f59dff89bfb49e538ce098f1e9a774c9c", @"/Views/Shared/_MyNewLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"35aa097fbb1e202e0c5d1a57df1ad4f095f2131cb2d6b0914d3ab1f6b8c97f76", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__MyNewLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ed437119a0cb7efd42369ebb1dc8e5f59dff89bfb49e538ce098f1e9a774c9c3621", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>");
#nullable restore
#line 6 "C:\100DayChallenge\MVC\Day6\WebAppliction6\Views\Shared\_MyNewLayout.cshtml"
      Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</title>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ed437119a0cb7efd42369ebb1dc8e5f59dff89bfb49e538ce098f1e9a774c9c4919", async() => {
                WriteLiteral("\r\n    <div style=\"width:100%; background-color:yellow;height:30% \">\r\n        <h1>Header Nav ");
#nullable restore
#line 10 "C:\100DayChallenge\MVC\Day6\WebAppliction6\Views\Shared\_MyNewLayout.cshtml"
                  Write(RenderSection("HeadAdd",false));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n    </div>\r\n\r\n    <div style=\"display:flex;width:100%;height:50%\">\r\n        <div style=\"width:30%;background-color:beige\">\r\n            <h1>Menu ");
#nullable restore
#line 15 "C:\100DayChallenge\MVC\Day6\WebAppliction6\Views\Shared\_MyNewLayout.cshtml"
                Write(RenderSection("MenuAdd"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        </div>\r\n        <div style=\"width:70%;background-color:brown\">\r\n            <h1>Menu ");
#nullable restore
#line 18 "C:\100DayChallenge\MVC\Day6\WebAppliction6\Views\Shared\_MyNewLayout.cshtml"
                Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        </div>\r\n    </div>\r\n\r\n    <div style=\"width:100%;background-color:aqua;height:20%\">\r\n        Footer ");
#nullable restore
#line 23 "C:\100DayChallenge\MVC\Day6\WebAppliction6\Views\Shared\_MyNewLayout.cshtml"
          Write(RenderSection("FooterAdd"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n");
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
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591