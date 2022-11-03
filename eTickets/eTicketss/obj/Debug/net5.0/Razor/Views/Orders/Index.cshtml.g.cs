#pragma checksum "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "13c5f03c1999358abc5052afff27b41dade63673"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Orders_Index), @"mvc.1.0.view", @"/Views/Orders/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"13c5f03c1999358abc5052afff27b41dade63673", @"/Views/Orders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a2333b3bcfa2a78a8de06313997a8e924076ace", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Orders_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml"
  
	ViewData["Title"] = "All orders";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"row\">\r\n\t<div class=\"col-md-8 offset-2\">\r\n\t\t<p>\r\n\t\t\t<h4>List of all your orders</h4>\r\n\t\t</p>\r\n\t\t<table class=\"table\">\r\n\t\t\t<thead>\r\n\t\t\t\t<tr>\r\n\t\t\t\t\t<th>Order ID</th>\r\n\t\t\t\t\t<th>Items</th>\r\n\t\t\t\t\t<th>Total</th>\r\n");
#nullable restore
#line 18 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml"
                     if(User.Identity.IsAuthenticated && User.IsInRole("Admin")){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<th>User</th>\r\n");
#nullable restore
#line 20 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\r\n\t\t\t\t</tr>\r\n\t\t\t</thead>\r\n\t\t\t<tbody>\r\n");
#nullable restore
#line 25 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml"
                 foreach (var order in Model)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\n\t\t\t\t\t\t<td class=\"align-middle\">");
#nullable restore
#line 28 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml"
                                            Write(order.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t\t\t<td class=\"align-middle\">\r\n\t\t\t\t\t\t\t<ul style=\"list-style-type:none\">\r\n");
#nullable restore
#line 31 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml"
                                 foreach (var item in order.OrderItems)
								{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\t<li>\r\n\t\t\t\t\t\t\t\t\t\t<div class=\"aletr alert-info\" role=\"alert\">\r\n\t\t\t\t\t\t\t\t\t\t\t<span class=\"badge bg-success\">");
#nullable restore
#line 35 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml"
                                                                      Write(item.Amount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>[");
#nullable restore
#line 35 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml"
                                                                                          Write(item.Price.ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("] - ");
#nullable restore
#line 35 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml"
                                                                                                                       Write(item.Movie.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t\t\t</li>\r\n");
#nullable restore
#line 38 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml"
								}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t\t\r\n\t\t\t\t\t\t\t</ul>\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td class=\"align-middle\">\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 43 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml"
                       Write(order.OrderItems.Select(m=>m.Movie.Price * m.Amount).Sum().ToString("c"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 45 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml"
                         if (User.Identity.IsAuthenticated && User.IsInRole("Admin"))
						{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\t<td class=\"align-middle\"> ");
#nullable restore
#line 47 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml"
                                                 Write(order.User.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n");
#nullable restore
#line 48 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml"
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t</tr>\n");
#nullable restore
#line 50 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Orders\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</tbody>\r\n\t\t</table>\r\n\t</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
