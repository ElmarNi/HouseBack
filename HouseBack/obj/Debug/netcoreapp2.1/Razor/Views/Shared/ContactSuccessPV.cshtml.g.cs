#pragma checksum "C:\Users\User\Desktop\HouseBack\HouseBack\Views\Shared\ContactSuccessPV.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f45a14b53254884b11956b83fa78ec9de91e9f51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ContactSuccessPV), @"mvc.1.0.view", @"/Views/Shared/ContactSuccessPV.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ContactSuccessPV.cshtml", typeof(AspNetCore.Views_Shared_ContactSuccessPV))]
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
#line 1 "C:\Users\User\Desktop\HouseBack\HouseBack\Views\_ViewImports.cshtml"
using HouseBack;

#line default
#line hidden
#line 2 "C:\Users\User\Desktop\HouseBack\HouseBack\Views\_ViewImports.cshtml"
using HouseBack.Models;

#line default
#line hidden
#line 3 "C:\Users\User\Desktop\HouseBack\HouseBack\Views\_ViewImports.cshtml"
using HouseBack.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f45a14b53254884b11956b83fa78ec9de91e9f51", @"/Views/Shared/ContactSuccessPV.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cc0e072f6852a9b2bd04fd2ef4c11483a446dab", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ContactSuccessPV : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\User\Desktop\HouseBack\HouseBack\Views\Shared\ContactSuccessPV.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(27, 2452, true);
            WriteLiteral(@"<style>
    * {
        -webkit-box-sizing: border-box;
        box-sizing: border-box;
    }

    body {
        padding: 0;
        margin: 0;
    }

    #notfound {
        position: relative;
        height: 100vh;
    }

        #notfound .notfound {
            position: absolute;
            left: 50%;
            top: 50%;
            -webkit-transform: translate(-50%, -50%);
            -ms-transform: translate(-50%, -50%);
            transform: translate(-50%, -50%);
        }

    .notfound {
        max-width: 520px;
        width: 100%;
        line-height: 1.4;
        text-align: center;
    }

        .notfound .notfound-404 {
            position: relative;
            height: 300px;
            margin: 0px auto 20px;
            z-index: -1;
        }

            .notfound .notfound-404 h1 {
                font-family: 'Montserrat', sans-serif;
                font-size: 236px;
                font-weight: 200;
                margin: 0px;
     ");
            WriteLiteral(@"           color: #211b19;
                text-transform: uppercase;
                position: absolute;
                left: 50%;
                top: 50%;
                -webkit-transform: translate(-50%, -50%);
                -ms-transform: translate(-50%, -50%);
                transform: translate(-50%, -50%);
            }

            .notfound .notfound-404 h2 {
                font-family: 'Montserrat', sans-serif;
                font-size: 28px;
                font-weight: 400;
                text-transform: uppercase;
                color: #211b19;
                background: #fff;
                padding: 10px 5px;
                margin: auto;
                display: inline-block;
                position: absolute;
                bottom: -20px;
                left: 0;
                right: 0;
            }

        .notfound a {
            font-family: 'Montserrat', sans-serif;
            display: inline-block;
            font-weight: 700;
           ");
            WriteLiteral(@" text-decoration: none;
            color: #fff;
            text-transform: uppercase;
            padding: 13px 23px;
            background: #ff6300;
            font-size: 18px;
            -webkit-transition: 0.2s all;
            transition: 0.2s all;
        }

            .notfound a:hover {
                color: #ff6300;
                background: #211b19;
            }

    ");
            EndContext();
            BeginContext(2480, 139, true);
            WriteLiteral("@media only screen and (max-width: 1200px) {\r\n        .notfound .notfound-404 h1 {\r\n            font-size: 148px;\r\n        }\r\n    }\r\n\r\n    ");
            EndContext();
            BeginContext(2620, 353, true);
            WriteLiteral(@"@media only screen and (max-width: 768px) {
        .notfound .notfound-404 h1 {
            font-size: 100px;
        }
    }
</style>

<div id=""notfound"">
    <div class=""notfound"">
        <div class=""notfound-404"">
            <h1>Success</h1>
            <h2>Your message sent. We will reply you with email</h2>
        </div>
        ");
            EndContext();
            BeginContext(2973, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2aef1daa7d14e56b878793fafcbcb57", async() => {
                BeginContext(3017, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3025, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
