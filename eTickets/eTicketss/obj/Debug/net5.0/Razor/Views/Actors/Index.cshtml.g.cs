#pragma checksum "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cdac13c6953271e9b1c51039900bc666930f94fc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Actors_Index), @"mvc.1.0.view", @"/Views/Actors/Index.cshtml")]
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
#line 1 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
using eTickets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cdac13c6953271e9b1c51039900bc666930f94fc", @"/Views/Actors/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a2333b3bcfa2a78a8de06313997a8e924076ace", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Actors_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Actor>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger text-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 8 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
  
	ViewData["Title"] = "List of Actors";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n\t<div class=\"col-md-8 offset-md-2\">\r\n\t\t<table class=\"table\">\r\n\r\n\t\t\t<thead>\r\n\t\t\t\t<tr class=\"text-center\">\r\n\t\t\t\t\t<th>");
#nullable restore
#line 20 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(model=>model.ProfilePictureURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
#nullable restore
#line 21 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(model=>model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t\t<th>");
#nullable restore
#line 22 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
                   Write(Html.DisplayNameFor(model=>model.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n");
#nullable restore
#line 23 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
                     if(User.Identity.IsAuthenticated && User.IsInRole("Admin")){

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<th>Actions</th>\r\n");
#nullable restore
#line 25 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
					}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\r\n\t\t\t\t</tr>\r\n\t\t\t</thead>\r\n\t\t\t<tbody>\r\n");
#nullable restore
#line 30 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
                 foreach (var item in Model)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t<tr>\r\n\t\t\t\t\t\t<td class=\"align-middle\">\r\n\t\t\t\t\t\t\t<img class=\"rounded-circle\"");
            BeginWriteAttribute("src", " src=\"", 680, "\"", 709, 1);
#nullable restore
#line 34 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
WriteAttributeValue("", 686, item.ProfilePictureURL, 686, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 710, "\"", 730, 1);
#nullable restore
#line 34 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
WriteAttributeValue("", 716, item.FullName, 716, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width:150px\" />\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td class=\"align-middle\" >\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 37 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
                       Write(Html.DisplayFor(modelItem=>item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n\t\t\t\t\t\t<td class=\"align-middle\"  >\r\n\t\t\t\t\t\t\t");
#nullable restore
#line 40 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
                       Write(Html.DisplayFor(modelItem=>item.Bio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 42 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
                         if (User.Identity.IsAuthenticated && User.IsInRole("Admin")) { 

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t<td class=\"align-middle\">\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdac13c6953271e9b1c51039900bc666930f94fc9393", async() => {
                WriteLiteral("<i class=\"bi bi-pencil-square\"></i>Edit ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 44 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
                                                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdac13c6953271e9b1c51039900bc666930f94fc11714", async() => {
                WriteLiteral("<i class=\"bi bi-eye\"></i>Details ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
                                                                                    WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n\t\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdac13c6953271e9b1c51039900bc666930f94fc14030", async() => {
                WriteLiteral("<i class=\"bi bi-trash\"></i>Delete ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 46 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
                                                                                       WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t\t\t\t\t</td>\r\n");
#nullable restore
#line 48 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
						
						}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t\r\n\t\t\t\t\t</tr>\n");
#nullable restore
#line 52 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
				}

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t</tbody>\r\n\t\t\t\r\n\r\n\t\t</table>\r\n\r\n\r\n\t</div>\r\n\r\n</div>\r\n\r\n");
#nullable restore
#line 63 "C:\Users\HAKAN\source\repos\eTickets\eTicketss\Views\Actors\Index.cshtml"
Write(await Html.PartialAsync("_CreateItem","Actors"));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Actor>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
