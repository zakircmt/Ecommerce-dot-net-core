#pragma checksum "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "340c16e45e5543ccc780b31afceefc292c80d9a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_AddProduct), @"mvc.1.0.view", @"/Views/Product/AddProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"340c16e45e5543ccc780b31afceefc292c80d9a7", @"/Views/Product/AddProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58ca17a8b871dad742f7b6c821f1ef102e04ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_AddProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form_validation"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""content"">
    <div class=""body_scroll"">
        <div class=""block-header"">
            <div class=""row"">
                <div class=""col-lg-7 col-md-6 col-sm-12"">
                    <h2>Form Validation</h2>
                    <ul class=""breadcrumb"">
                        <li class=""breadcrumb-item""><a href=""index.html""><i class=""zmdi zmdi-home""></i> Aero</a></li>
                        <li class=""breadcrumb-item""><a href=""javascript:void(0);"">Forms</a></li>
                        <li class=""breadcrumb-item active"">Form Validation</li>
                    </ul>
                    <button class=""btn btn-primary btn-icon mobile_menu"" type=""button""><i class=""zmdi zmdi-sort-amount-desc""></i></button>
                </div>
                <div class=""col-lg-5 col-md-6 col-sm-12"">
                    <button class=""btn btn-primary btn-icon float-right right_icon_toggle_btn"" type=""button""><i class=""zmdi zmdi-arrow-right""></i></button>
                </div>
            </div>");
            WriteLiteral(@"
        </div>

        <div class=""container-fluid"">
            <!-- Basic Validation -->
            <div class=""row clearfix"">
                <div class=""col-lg-12 col-md-12 col-sm-12"">
                    <div class=""card"">
                        <div class=""body"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "340c16e45e5543ccc780b31afceefc292c80d9a75691", async() => {
                WriteLiteral(@"
                                <div class=""form-group form-float"">
                                    <input type=""text"" class=""form-control"" placeholder=""Product Name"" name=""ProductName"" required>
                                </div>
                                <div class=""form-group form-float"">
                                    <input type=""text"" class=""form-control"" placeholder=""ProductSalePrice"" name=""ProductSalePrice"">
                                </div>
                                <div class=""form-group form-float"">
                                    <input type=""text"" class=""form-control"" placeholder=""ProductRegularPrice"" name=""ProductRegularPrice"">
                                </div>
                                <div class=""form-group"">
                                    <select class=""form-control"" name=""CategoryID"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "340c16e45e5543ccc780b31afceefc292c80d9a76899", async() => {
                    WriteLiteral("-- Please select Category --");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 45 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
                                         foreach (var item in ViewBag.category)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "340c16e45e5543ccc780b31afceefc292c80d9a78294", async() => {
#nullable restore
#line 47 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
                                                                Write(item.CategoryName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
                                               WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 48 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </select>
                                </div>
                                <br />
                                <div class=""form-group"">
                                    <select class=""form-control"" name=""BrandID"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "340c16e45e5543ccc780b31afceefc292c80d9a710743", async() => {
                    WriteLiteral("-- Please select Brand --");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 55 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
                                         foreach (var item in ViewBag.brand)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "340c16e45e5543ccc780b31afceefc292c80d9a712133", async() => {
#nullable restore
#line 57 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
                                                                Write(item.BrandName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 57 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
                                               WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 58 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </select>
                                </div>
                                <div class=""form-group"">
                                    <select class=""form-control"" name=""ManufacturerID"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "340c16e45e5543ccc780b31afceefc292c80d9a714547", async() => {
                    WriteLiteral("-- Please select Brand --");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 64 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
                                         foreach (var item in ViewBag.manufacture)
                                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "340c16e45e5543ccc780b31afceefc292c80d9a715943", async() => {
#nullable restore
#line 66 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
                                                                Write(item.ManufacturerName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 66 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
                                               WriteLiteral(item.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 67 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
                                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                                    </select>
                                </div>
                                <br />
                                <div class=""form-group form-float"">
                                    <input type=""text"" class=""form-control"" placeholder=""Product Code"" name=""ProductCode"">
                                </div>

                                <div class=""form-group form-float"">
                                    <textarea rows=""10"" class=""form-control"" placeholder=""Product Short Description"" name=""ProductShortDescription""></textarea>
                                </div>

                                <div class=""form-group form-float"">
                                    <textarea rows=""10"" class=""form-control"" placeholder=""Product Full Description"" name=""ProductDescription""></textarea>
                                </div>

                                <div class=""form-group"">
                                    <label>Select Image</label>
 ");
                WriteLiteral(@"                                   <input class=""form-control"" name=""ProductPictures"" id=""productPictures"" type=""file"" multiple />
                                    <div id=""picturesArea"" class=""form-group""></div>
                                    <input type=""hidden"" name=""ProductPictures"" id=""PictureIDs"" />
                                </div>

                                <div class=""form-group"">
                                    <div class=""radio inlineblock m-r-20"">
                                        <input type=""radio"" name=""IsFeatured"" id=""male"" class=""with-gap"" value=""True"">
                                        <label for=""male"">Is Featured</label>
                                    </div>
                                    <div class=""radio inlineblock"">
                                        <input type=""radio"" name=""Status"" id=""Female"" class=""with-gap"" value=""True"">
                                        <label for=""Female"">Status</label>
                        ");
                WriteLiteral("            </div>\r\n                                    <div");
                BeginWriteAttribute("class", " class=\"", 6049, "\"", 6057, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <input type=\"checkbox\" name=\"IsSlider\"");
                BeginWriteAttribute("id", " id=\"", 6139, "\"", 6144, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"with-gap\" value=\"True\">\r\n                                        <label");
                BeginWriteAttribute("for", " for=\"", 6224, "\"", 6230, 0);
                EndWriteAttribute();
                WriteLiteral(">Set Slider?</label>\r\n                                    </div>\r\n                                    <div");
                BeginWriteAttribute("class", " class=\"", 6337, "\"", 6345, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <input type=\"checkbox\" name=\"IsLatestcAds\"");
                BeginWriteAttribute("id", " id=\"", 6431, "\"", 6436, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"with-gap\" value=\"True\">\r\n                                        <label");
                BeginWriteAttribute("for", " for=\"", 6516, "\"", 6522, 0);
                EndWriteAttribute();
                WriteLiteral(">Set Latest Ads?</label>\r\n                                    </div>\r\n                                    <div class=\"check-mark\">\r\n                                        <input type=\"checkbox\" name=\"IsStaticAds\"");
                BeginWriteAttribute("id", " id=\"", 6736, "\"", 6741, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"with-gap\" value=\"True\">\r\n                                        <label");
                BeginWriteAttribute("for", " for=\"", 6821, "\"", 6827, 0);
                EndWriteAttribute();
                WriteLiteral(">Set Ads ? </label>\r\n                                    </div>\r\n                                    <div");
                BeginWriteAttribute("class", " class=\"", 6933, "\"", 6941, 0);
                EndWriteAttribute();
                WriteLiteral(">\r\n                                        <input type=\"checkbox\" name=\"IsFlashSale\"");
                BeginWriteAttribute("id", " id=\"", 7026, "\"", 7031, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"with-gap\" value=\"True\">\r\n                                        <label");
                BeginWriteAttribute("for", " for=\"", 7111, "\"", 7117, 0);
                EndWriteAttribute();
                WriteLiteral(@">Set FlashSale ? </label>
                                    </div>
                                </div>
                                <button id=""ProductAddBtn"" class=""btn btn-raised btn-primary waves-effect"" type=""button"">SUBMIT</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 32 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
AddHtmlAttributeValue("", 1475, Url.Action("AddProduct","Product"), 1475, 35, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<div id=\"imageTemplate\" style=\"display:none\">\r\n    <img class=\'image img-thumbnail\'");
            BeginWriteAttribute("src", " src=\'", 7631, "\'", 7637, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""height:100px; width:100px"" />
</div>
<script>
    $('#ProductAddBtn').click(function () {
        debugger;
        var imageIDs = [];
        $(""#picturesArea .image"").each(function () {
            var imageID = $(this).attr(""data-id"");
            imageIDs.push(imageID);
        });
        $(""#PictureIDs"").val(imageIDs.join())
         $.ajax({
         url: """);
#nullable restore
#line 138 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
          Write(Url.Action("AddProduct","Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n         type: \"post\",\r\n             data: $(\"#form_validation\").serialize()\r\n     }).done(function (responses) {\r\n         debugger;\r\n         alert(\"Product Save Succesfully\");\r\n         window.location.href = \"");
#nullable restore
#line 144 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
                            Write(Url.Action("Index", "Product"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
     }).fail(function () {

     });
    });

    $(""#productPictures"").change(function () {
          debugger;
          var pictures = this.files;
          var picsData = new FormData();
        for (var i = 0; i < pictures.length; i++) {
            picsData.append(""Picture"", pictures[i]);
        }
        $.ajax({
            url: """);
#nullable restore
#line 158 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Product\AddProduct.cshtml"
             Write(Url.Action("UploadPictures","Shared"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""",
            type: ""post"",
            data: picsData,
            datatype: ""json"",
            processData: false,
            contentType: false
        }).done(function (responses) {
            debugger;
            for (var i = 0; i < responses.length; i++) {
                var picResponse = responses[i];

                AttachNewImage(picResponse.pictureUrl, picResponse.ID);
            }
        }).fail(function () { });
    });

    function AttachNewImage(imageURL, imageID) {
        debugger;

        var $newImageHTML = $(""#imageTemplate"").clone();

        $newImageHTML.find("".image"").attr(""src"", ""/Content/images/"" + imageURL);
        $newImageHTML.find("".image"").attr(""data-id"", imageID);

        $(""#picturesArea"").append($newImageHTML.html());

        RemoveImageOnClick();

    }

    function RemoveImageOnClick() {
        $(""#picturesArea .image"").click(function () {

            debugger;
            $(this).remove();

        });
    }
</script>");
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
