#pragma checksum "C:\Users\hsyna\Desktop\QaurterProject\Quarter\Quarter\Views\Shared\_WishlistPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8d9982f4dfac3f3b0950a85394920eca732a5ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Quarter.Views.Shared.Views_Shared__WishlistPartial), @"mvc.1.0.view", @"/Views/Shared/_WishlistPartial.cshtml")]
namespace Quarter.Views.Shared
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
#line 5 "C:\Users\hsyna\Desktop\QaurterProject\Quarter\Quarter\Views\_ViewImports.cshtml"
using Business.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hsyna\Desktop\QaurterProject\Quarter\Quarter\Views\_ViewImports.cshtml"
using DAL.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hsyna\Desktop\QaurterProject\Quarter\Quarter\Views\_ViewImports.cshtml"
using DAL.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8d9982f4dfac3f3b0950a85394920eca732a5ab", @"/Views/Shared/_WishlistPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"caf0433d5e1aad8bfae708aa46d9253883223789", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared__WishlistPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Wishlist>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\hsyna\Desktop\QaurterProject\Quarter\Quarter\Views\Shared\_WishlistPartial.cshtml"
 if (Model is not null) {
    foreach (var product in @Model.Products)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td class=\"cart-product-remove\"><a class=\"delete-wishlist\" data-id=\"");
#nullable restore
#line 7 "C:\Users\hsyna\Desktop\QaurterProject\Quarter\Quarter\Views\Shared\_WishlistPartial.cshtml"
                                                                           Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">x</a></td>\r\n            <td class=\"cart-product-image\">\r\n                <a href=\"product-details.html\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e8d9982f4dfac3f3b0950a85394920eca732a5ab4533", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 318, "~/assets/uploads/images/", 318, 24, true);
#nullable restore
#line 9 "C:\Users\hsyna\Desktop\QaurterProject\Quarter\Quarter\Views\Shared\_WishlistPartial.cshtml"
AddHtmlAttributeValue("", 342, product.Images.Where(n => n.IsMain == true).FirstOrDefault().Url, 342, 65, false);

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
            WriteLiteral("</a>\r\n            </td>\r\n            <td class=\"cart-product-info\">\r\n                <h4><a href=\"product-details.html\">");
#nullable restore
#line 12 "C:\Users\hsyna\Desktop\QaurterProject\Quarter\Quarter\Views\Shared\_WishlistPartial.cshtml"
                                              Write(product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h4>\r\n            </td>\r\n            <td class=\"cart-product-price\">$");
#nullable restore
#line 14 "C:\Users\hsyna\Desktop\QaurterProject\Quarter\Quarter\Views\Shared\_WishlistPartial.cshtml"
                                       Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td class=\"cart-product-add-cart\">\r\n                <a class=\"add-basket\" title=\"Add to Cart\" data-id=\"");
#nullable restore
#line 16 "C:\Users\hsyna\Desktop\QaurterProject\Quarter\Quarter\Views\Shared\_WishlistPartial.cshtml"
                                                              Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-bs-toggle=\"modal\" data-bs-target=\"#add_to_cart_modal\">Add to Cart</a>\r\n            </td>\r\n        </tr>\n");
#nullable restore
#line 19 "C:\Users\hsyna\Desktop\QaurterProject\Quarter\Quarter\Views\Shared\_WishlistPartial.cshtml"
    }
}

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Wishlist> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591