#pragma checksum "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Pending.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2843564e18b85d0b299f5f7f513de09b16b5720f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Packages_Pending), @"mvc.1.0.view", @"/Views/Packages/Pending.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Packages/Pending.cshtml", typeof(AspNetCore.Views_Packages_Pending))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2843564e18b85d0b299f5f7f513de09b16b5720f", @"/Views/Packages/Pending.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d25b006d9edca456a2baaa3fb4fd012e0d8d84c", @"/Views/_ViewImports.cshtml")]
    public class Views_Packages_Pending : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PendingViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Packages", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Ship", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn bg-panda text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(38, 868, true);
            WriteLiteral(@"
<h1 class=""text-center"">Pending Shipment</h1>
<hr class=""hr-2 bg-panda"">

<div class=""d-flex justify-content-between"">
    <table class=""table table-hover table-bordered"">
        <thead>
        <tr class=""row"">
            <th scope=""col"" class=""col-lg-1 d-flex justify-content-center""><h3>#</h3></th>
            <th scope=""col"" class=""col-lg-3 d-flex justify-content-center""><h3>Description</h3></th>
            <th scope=""col"" class=""col-lg-2 d-flex justify-content-center""><h3>Weight</h3></th>
            <th scope=""col"" class=""col-lg-3 d-flex justify-content-center""><h3>Shipping Address</h3></th>
            <th scope=""col"" class=""col-lg-2 d-flex justify-content-center""><h3>Recipient</h3></th>
            <th scope=""col"" class=""col-lg-1 d-flex justify-content-center""><h3>Actions</h3></th>
        </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 19 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Pending.cshtml"
             foreach (var package in @Model)
            {

#line default
#line hidden
            BeginContext(967, 121, true);
            WriteLiteral("                <tr class=\"row\">\r\n                    <th scope=\"row\" class=\"col-lg-1 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1089, 10, false);
#line 22 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Pending.cshtml"
                                                                                  Write(package.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1099, 87, true);
            WriteLiteral("</h5></th>\r\n                    <td class=\"col-lg-3 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1187, 19, false);
#line 23 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Pending.cshtml"
                                                                      Write(package.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1206, 87, true);
            WriteLiteral("</h5></td>\r\n                    <td class=\"col-lg-2 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1294, 14, false);
#line 24 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Pending.cshtml"
                                                                      Write(package.Weight);

#line default
#line hidden
            EndContext();
            BeginContext(1308, 87, true);
            WriteLiteral("</h5></td>\r\n                    <td class=\"col-lg-3 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1396, 23, false);
#line 25 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Pending.cshtml"
                                                                      Write(package.ShippingAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1419, 87, true);
            WriteLiteral("</h5></td>\r\n                    <td class=\"col-lg-2 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1507, 17, false);
#line 26 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Pending.cshtml"
                                                                      Write(package.Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(1524, 109, true);
            WriteLiteral("</h5></td>\r\n                    <td class=\"col-lg-1 d-flex justify-content-center\">\r\n                        ");
            EndContext();
            BeginContext(1633, 114, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feb8d961236a4d7bb4e976e131e93a78", async() => {
                BeginContext(1739, 4, true);
                WriteLiteral("Ship");
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
#line 28 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Pending.cshtml"
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
            BeginContext(1747, 52, true);
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 31 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Pending.cshtml"
            }

#line default
#line hidden
            BeginContext(1814, 38, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PendingViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
