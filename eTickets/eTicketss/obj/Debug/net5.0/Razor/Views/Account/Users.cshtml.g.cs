#pragma checksum "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Account\Users.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e05c5db03370f851628ec2a2981d1db77ffff82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Users), @"mvc.1.0.view", @"/Views/Account/Users.cshtml")]
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
#line 1 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\_ViewImports.cshtml"
using eTicketss;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\_ViewImports.cshtml"
using eTicketss.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Account\Users.cshtml"
using eTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e05c5db03370f851628ec2a2981d1db77ffff82", @"/Views/Account/Users.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a2333b3bcfa2a78a8de06313997a8e924076ace", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Account_Users : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ApplicationUser>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Account\Users.cshtml"
  
	ViewData["Title"] = "List of Users";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n\t<div class=\"col-md-6 offset-3\">\r\n\t\t<p>\r\n\t\t\t<h4>List of all users</h4>\r\n\t\t</p>\r\n\r\n\t\t<table class=\"table\">\r\n\r\n\t\t\t<thead>\r\n\t\t\t\t<tr class=\"text-center\">\r\n\t\t\t\t\t<th>");
#nullable restore
#line 24 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model=>model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
#nullable restore
#line 25 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model=>model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
#nullable restore
#line 26 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Account\Users.cshtml"
                   Write(Html.DisplayNameFor(model=>model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t</tr>\r\n\t\t\t</thead>\r\n\t\t\t<tbody>\r\n");
#nullable restore
#line 30 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Account\Users.cshtml"
                 foreach (var item in Model)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t\r\n\t\t\t\t\t\t<td class=\"align-middle\" >\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 35 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Account\Users.cshtml"
                       Write(Html.DisplayFor(modelItem=>item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td class=\"align-middle\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 38 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Account\Users.cshtml"
                       Write(Html.DisplayFor(modelItem=>item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td class=\"align-middle\"  >\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 41 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Account\Users.cshtml"
                       Write(Html.DisplayFor(modelItem=>item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t</tr>\n");
#nullable restore
#line 45 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Account\Users.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</tbody>\r\n\t\t\t\r\n\r\n\t\t</table>\r\n\r\n\r\n\t</div>\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ApplicationUser>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
