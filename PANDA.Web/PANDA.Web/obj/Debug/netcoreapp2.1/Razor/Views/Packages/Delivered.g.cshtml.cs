#pragma checksum "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Delivered.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98617c7451a27bffe4b9096a2746f740473109af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Packages_Delivered), @"mvc.1.0.view", @"/Views/Packages/Delivered.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Packages/Delivered.cshtml", typeof(AspNetCore.Views_Packages_Delivered))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98617c7451a27bffe4b9096a2746f740473109af", @"/Views/Packages/Delivered.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d25b006d9edca456a2baaa3fb4fd012e0d8d84c", @"/Views/_ViewImports.cshtml")]
    public class Views_Packages_Delivered : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DeliveredViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(40, 893, true);
            WriteLiteral(@"
<h1 class=""text-center"">Delivered</h1>
<hr class=""hr-2 bg-panda"">

<div class=""d-flex justify-content-between"">
    <table class=""table table-hover table-bordered"">
        <thead>
            <tr class=""row"">
                <th scope=""col"" class=""col-lg-1 d-flex justify-content-center""><h3>#</h3></th>
                <th scope=""col"" class=""col-lg-2 d-flex justify-content-center""><h3>Description</h3></th>
                <th scope=""col"" class=""col-lg-2 d-flex justify-content-center""><h3>Weight</h3></th>
                <th scope=""col"" class=""col-lg-4 d-flex justify-content-center""><h3>Shipping Address</h3></th>
                <th scope=""col"" class=""col-lg-2 d-flex justify-content-center""><h3>Recipient</h3></th>
                <th scope=""col"" class=""col-lg-1 d-flex justify-content-center""><h3>Actions</h3></th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 19 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Delivered.cshtml"
             foreach (var package in @Model)
            {

#line default
#line hidden
            BeginContext(994, 121, true);
            WriteLiteral("                <tr class=\"row\">\r\n                    <th scope=\"row\" class=\"col-lg-1 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1116, 10, false);
#line 22 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Delivered.cshtml"
                                                                                  Write(package.Id);

#line default
#line hidden
            EndContext();
            BeginContext(1126, 87, true);
            WriteLiteral("</h5></th>\r\n                    <td class=\"col-lg-2 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1214, 19, false);
#line 23 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Delivered.cshtml"
                                                                      Write(package.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1233, 87, true);
            WriteLiteral("</h5></td>\r\n                    <td class=\"col-lg-2 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1321, 14, false);
#line 24 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Delivered.cshtml"
                                                                      Write(package.Weight);

#line default
#line hidden
            EndContext();
            BeginContext(1335, 87, true);
            WriteLiteral("</h5></td>\r\n                    <td class=\"col-lg-4 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1423, 23, false);
#line 25 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Delivered.cshtml"
                                                                      Write(package.ShippingAddress);

#line default
#line hidden
            EndContext();
            BeginContext(1446, 87, true);
            WriteLiteral("</h5></td>\r\n                    <td class=\"col-lg-2 d-flex justify-content-center\"><h5>");
            EndContext();
            BeginContext(1534, 17, false);
#line 26 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Delivered.cshtml"
                                                                      Write(package.Recipient);

#line default
#line hidden
            EndContext();
            BeginContext(1551, 111, true);
            WriteLiteral("</h5></td>\r\n                    <td class=\"col-lg-1 d-flex justify-content-center\">\r\n                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1662, "\"", 1701, 2);
            WriteAttributeValue("", 1669, "/Packages/Details?id=", 1669, 21, true);
#line 28 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Delivered.cshtml"
WriteAttributeValue("", 1690, package.Id, 1690, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1702, 96, true);
            WriteLiteral(" class=\"btn bg-panda text-white\">Details</a>\r\n                    </td>\r\n                </tr>\r\n");
            EndContext();
#line 31 "C:\Users\JORO\Desktop\Web-ASP.NET-Core\PANDA.Web\PANDA.Web\Views\Packages\Delivered.cshtml"
            }

#line default
#line hidden
            BeginContext(1813, 38, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DeliveredViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
