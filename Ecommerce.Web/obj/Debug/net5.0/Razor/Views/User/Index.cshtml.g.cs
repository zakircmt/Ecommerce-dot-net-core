#pragma checksum "G:\Web Development\Ecommerce\Ecommerce.Web\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ce19008b3007a114d4634a4e817bcf7905ff746e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce19008b3007a114d4634a4e817bcf7905ff746e", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58ca17a8b871dad742f7b6c821f1ef102e04ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Ecommerce.Entities.User>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\User\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<section class=""content"">
    <div class=""body_scroll"">
        <div class=""block-header"">
            <div class=""row"">
                <div class=""col-lg-7 col-md-6 col-sm-12"">
                    <h2>Product List</h2>
                    <ul class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""index.html""><i class=""zmdi zmdi-home""></i> Aero</a></li>
                        <li class=""breadcrumb-item"">eCommerce</li>
                        <li class=""breadcrumb-item active"">List of Product Category</li>
                    </ul>
                    <button class=""btn btn-primary btn-icon mobile_menu"" type=""button""><i class=""zmdi zmdi-sort-amount-desc""></i></button>
                </div>
                <div class=""col-lg-5 col-md-6 col-sm-12"">
                    <button class=""btn btn-primary btn-icon float-right right_icon_toggle_btn"" type=""button""><i class=""zmdi zmdi-arrow-right""></i></button>
                </div>
            </div>
        </div>
        ");
            WriteLiteral("<div class=\"container-fluid\">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 1203, "\"", 1239, 1);
#nullable restore
#line 25 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\User\Index.cshtml"
WriteAttributeValue("", 1210, Url.Action("AddUser","User"), 1210, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class="" btn btn-info"">Add User</a>
            <div class=""row clearfix"">
                <div class=""col-lg-12"">
                    <div class=""card"">
                        <div class=""table-responsive"">
                            <table class=""table table-hover product_item_list c_table theme-color mb-0"">
                                <thead>
                                    <tr>
                                        <th>Image</th>
                                        <th>Name</th>
                                        <th data-breakpoints=""sm xs md"">Action</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 39 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\User\Index.cshtml"
                                     foreach (var item in Model)
                                    {
                                        var picURL = item.UserPictures != null && item.UserPictures.Count > 0 ?
                                                 "/Content/images/" +
                                                     item.UserPictures.First().Picture.PictureURL :
                                                            "~/Content/Theme/assets/images/ecommerce/1.png";

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td><img");
            BeginWriteAttribute("src", " src=\"", 2563, "\"", 2576, 1);
#nullable restore
#line 46 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\User\Index.cshtml"
WriteAttributeValue("", 2569, picURL, 2569, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"48\" alt=\"Product img\"></td>\r\n                                            <td><h5>");
#nullable restore
#line 47 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\User\Index.cshtml"
                                               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 47 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\User\Index.cshtml"
                                                               Write(item.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5></td>\r\n                                            <td>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 2808, "\"", 2867, 1);
#nullable restore
#line 49 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\User\Index.cshtml"
WriteAttributeValue("", 2815, Url.Action("EditBanner","Banner",new { ID=item.ID}), 2815, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default waves-effect waves-float btn-sm waves-green\"><i class=\"zmdi zmdi-edit\"></i></a>\r\n                                                <a");
            BeginWriteAttribute("href", " href=\"", 3023, "\"", 3085, 2);
#nullable restore
#line 50 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\User\Index.cshtml"
WriteAttributeValue("", 3030, Url.Action("DeleteBanner","Banner",new { ID=item.ID}), 3030, 54, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3084, ";", 3084, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-default waves-effect waves-float btn-sm waves-red\"><i class=\"zmdi zmdi-delete\"></i></a>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 53 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\User\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </tbody>
                            </table>
                        </div>
                    </div>
                    <div class=""card"">
                        <div class=""body"">
                            <ul class=""pagination pagination-primary m-b-0"">
                                <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);""><i class=""zmdi zmdi-arrow-left""></i></a></li>
                                <li class=""page-item active""><a class=""page-link"" href=""javascript:void(0);"">1</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);"">2</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);"">3</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);"">4</a></li>
                                <li class=""page-item""><a class=""page-link"" href=""javascript:void(0);""><i cla");
            WriteLiteral("ss=\"zmdi zmdi-arrow-right\"></i></a></li>\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Ecommerce.Entities.User>> Html { get; private set; }
    }
}
#pragma warning restore 1591