#pragma checksum "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserDashboard\MyOrderList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b28dddff023482fe6130685c89cce20cc04fd918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UserDashboard_MyOrderList), @"mvc.1.0.view", @"/Views/UserDashboard/MyOrderList.cshtml")]
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
#line 1 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\_ViewImports.cshtml"
using Ecommerce.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\_ViewImports.cshtml"
using Ecommerce.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserDashboard\MyOrderList.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b28dddff023482fe6130685c89cce20cc04fd918", @"/Views/UserDashboard/MyOrderList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58ca17a8b871dad742f7b6c821f1ef102e04ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_UserDashboard_MyOrderList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ecommerce.Web.ViewModels.UserOrderViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserDashboard\MyOrderList.cshtml"
  
    ViewBag.Title = "MyOrderList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- wishlist main wrapper start -->
<div class=""wishlist-main-wrapper"">
    <div class=""container"">
        <!-- Wishlist Page Content Start -->
        <div class=""row"">
            <div class=""col-lg-12"">
                <!-- Wishlist Table Area -->
                <div class=""cart-table table-responsive"">
                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th class=""pro-title"">ID</th>
                                <th class=""pro-price"">Order Date</th>
                                <th class=""pro-quantity"">Total Amount</th>
                                <th class=""pro-remove"">Details</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 27 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserDashboard\MyOrderList.cshtml"
                             if (Model != null && Model.Orders != null)
                            {
                                foreach (var order in Model.Orders)
                                {
                                    //var commentedProducts = Model.Orders != null ? Model.Orders.FirstOrDefault(x => x.ID == order.RecordID) : null;

                                    //var picURL = commentedProducts.ProductPictures != null && commentedProducts.ProductPictures.Count > 0 ?
                                    //             "/Content/images/" + commentedProducts.ProductPictures.First().Picture.PictureURL :
                                    //                "~/Content/theme/assets/img/product/product-img1.jpg";


#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <tr>\r\n\r\n                                        <td class=\"pro-price\"><span> ");
#nullable restore
#line 39 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserDashboard\MyOrderList.cshtml"
                                                                Write(order.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n\r\n");
            WriteLiteral("                                        <td class=\"pro-price\"><span>BDT ");
#nullable restore
#line 42 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserDashboard\MyOrderList.cshtml"
                                                                   Write(order.OrdereDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n                                        <td class=\"pro-quantity\"><span class=\"text-success\">");
#nullable restore
#line 43 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserDashboard\MyOrderList.cshtml"
                                                                                       Write(order.TotalAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></td>\r\n");
            WriteLiteral("                                        <td class=\"pro-remove\"><a");
            BeginWriteAttribute("href", " href=\"", 2761, "\"", 2882, 1);
#nullable restore
#line 45 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserDashboard\MyOrderList.cshtml"
WriteAttributeValue("", 2768, Url.Action("OrderDetail","Shop",new { ID=order.ID,UserID=HttpContextAccessor.HttpContext.Session.GetInt32("ID")}), 2768, 114, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa fa-trash-o\"></i>Order Details</a></td>\r\n                                    </tr>\r\n");
#nullable restore
#line 47 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserDashboard\MyOrderList.cshtml"
                                }

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"alert alert-primary\" role=\"alert\">\r\n                                    No Comments Found\r\n                                </div>\r\n");
#nullable restore
#line 55 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\UserDashboard\MyOrderList.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <!-- Wishlist Page Content End -->\r\n    </div>\r\n</div>\r\n<!-- wishlist main wrapper end -->\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Http.IHttpContextAccessor HttpContextAccessor { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecommerce.Web.ViewModels.UserOrderViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591