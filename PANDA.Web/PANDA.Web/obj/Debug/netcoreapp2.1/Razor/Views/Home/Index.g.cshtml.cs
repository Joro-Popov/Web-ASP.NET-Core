#pragma checksum "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71bcf979a66560fb9344bffe564845b981bb4c9e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\_ViewImports.cshtml"
using PANDA.Models;

#line default
#line hidden
#line 2 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\_ViewImports.cshtml"
using PANDA.Models.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71bcf979a66560fb9344bffe564845b981bb4c9e", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d25b006d9edca456a2baaa3fb4fd012e0d8d84c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PackagesViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Packages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-panda text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Acquire", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 7 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
 if (this.User.Identity.IsAuthenticated)
{
    if (this.User.IsInRole("User"))
    {

#line default
#line hidden
            BeginContext(164, 50, true);
            WriteLiteral("        <h4 class=\"text-panda text-center\">Hello, ");
            EndContext();
            BeginContext(215, 16, false);
#line 11 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
                                             Write(ViewBag.Username);

#line default
#line hidden
            EndContext();
            BeginContext(231, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 12 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(262, 64, true);
            WriteLiteral("        <h4 class=\"text-panda text-center\">Hello, Administrator ");
            EndContext();
            BeginContext(327, 16, false);
#line 15 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
                                                           Write(ViewBag.Username);

#line default
#line hidden
            EndContext();
            BeginContext(343, 7, true);
            WriteLiteral("</h4>\r\n");
            EndContext();
#line 16 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(357, 297, true);
            WriteLiteral(@"    <hr class=""hr-2 bg-dark"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-sm"">
                <h2 class=""text-center text-panda"">Pending</h2>
                <div class=""border-panda"">
                    <div class=""container-fluid mt-4 mb-4"">
");
            EndContext();
#line 24 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
                         foreach (var package in @Model.PendingPackages)
                        {

#line default
#line hidden
            BeginContext(755, 129, true);
            WriteLiteral("                            <div class=\"button-holder d-flex justify-content-between mb-2\">\r\n                                <h3>");
            EndContext();
            BeginContext(885, 19, false);
#line 27 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
                               Write(package.Description);

#line default
#line hidden
            EndContext();
            BeginContext(904, 39, true);
            WriteLiteral("</h3>\r\n                                ");
            EndContext();
            BeginContext(943, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b28ca82eff774c7c867357a353b3e8a5", async() => {
                BeginContext(1052, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 28 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
                                                                                    WriteLiteral(package.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1063, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 30 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1128, 276, true);
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""col-sm"">
                <h2 class=""text-center text-panda"">Shipped</h2>
                <div class=""border-panda"">
                    <div class=""container-fluid mt-4 mb-4"">
");
            EndContext();
#line 38 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
                         foreach (var package in @Model.ShippedPackages)
                        {

#line default
#line hidden
            BeginContext(1505, 129, true);
            WriteLiteral("                            <div class=\"button-holder d-flex justify-content-between mb-2\">\r\n                                <h3>");
            EndContext();
            BeginContext(1635, 19, false);
#line 41 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
                               Write(package.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1654, 39, true);
            WriteLiteral("</h3>\r\n                                ");
            EndContext();
            BeginContext(1693, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f19f8c80d58b458b998958c7a1556124", async() => {
                BeginContext(1802, 7, true);
                WriteLiteral("Details");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 42 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
                                                                                    WriteLiteral(package.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1813, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 44 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(1878, 278, true);
            WriteLiteral(@"                    </div>
                </div>
            </div>
            <div class=""col-sm"">
                <h2 class=""text-center text-panda"">Delivered</h2>
                <div class=""border-panda"">
                    <div class=""container-fluid mt-4 mb-4"">
");
            EndContext();
#line 52 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
                         foreach (var package in @Model.DeliveredPackages)
                        {

#line default
#line hidden
            BeginContext(2259, 129, true);
            WriteLiteral("                            <div class=\"button-holder d-flex justify-content-between mb-2\">\r\n                                <h3>");
            EndContext();
            BeginContext(2389, 19, false);
#line 55 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
                               Write(package.Description);

#line default
#line hidden
            EndContext();
            BeginContext(2408, 39, true);
            WriteLiteral("</h3>\r\n                                ");
            EndContext();
            BeginContext(2447, 120, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d2d304c6ffc343fca67a788190ccf56a", async() => {
                BeginContext(2556, 7, true);
                WriteLiteral("Acquire");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 56 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
                                                                                    WriteLiteral(package.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2567, 38, true);
            WriteLiteral("\r\n                            </div>\r\n");
            EndContext();
#line 58 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(2632, 100, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 64 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(2744, 372, true);
            WriteLiteral(@"    <div class=""jumbotron mt-3 bg-panda"">
        <h1 class=""text-white"">Welcome to PANDA Delivery Services.</h1>
        <hr class=""bg-white hr-2"" />
        <h3 class=""text-white""><a href=""/identity/account/login"">Login</a> if you have an account.</h3>
        <h3 class=""text-white""><a href=""/identity/account/register"">Register</a> if you don't.</h3>
    </div>
");
            EndContext();
#line 73 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Home\Index.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PackagesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
