#pragma checksum "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c74fff3298978f5266d7e3d337583ea59626a6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ads_EditAds), @"mvc.1.0.view", @"/Views/Ads/EditAds.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c74fff3298978f5266d7e3d337583ea59626a6e", @"/Views/Ads/EditAds.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f58ca17a8b871dad742f7b6c821f1ef102e04ea7", @"/Views/_ViewImports.cshtml")]
    public class Views_Ads_EditAds : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ecommerce.Web.Models.Ads.CreateAdsModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:100px; width:100px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image img-thumbnail"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("EditAdsForm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/_LayoutAdmin.cshtml";
    var picture = Model.SecoundBannerPictureList;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<!-- Main content -->
<section class=""content"">
    <div class=""block-header"">
        <div class=""row"">
            <div class=""col-lg-7 col-md-6 col-sm-12"">
                <ul class=""breadcrumb"">
                    <li class=""breadcrumb-item""><a");
            BeginWriteAttribute("href", " href=\"", 447, "\"", 467, 1);
#nullable restore
#line 15 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml"
WriteAttributeValue("", 454, Url.Action(), 454, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""zmdi zmdi-home""></i> Dashboard</a></li>
                    <li class=""breadcrumb-item""><a href=""javascript:void(0);"">Ads</a></li>
                    <li class=""breadcrumb-item active"">Edit Ads Form</li>
                </ul>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-md-12"">
            <div class=""box box-info"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c74fff3298978f5266d7e3d337583ea59626a6e6097", async() => {
                WriteLiteral("\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("name", " name=\"", 987, "\"", 1003, 1);
#nullable restore
#line 26 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml"
WriteAttributeValue("", 994, Model.ID, 994, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 1004, "\"", 1021, 1);
#nullable restore
#line 26 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml"
WriteAttributeValue("", 1012, Model.ID, 1012, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    <div class=\"form-group form-float\">\r\n                        <label>Name of Ads</label>\r\n                        <input type=\"text\" class=\"form-control\" placeholder=\"Ads Name\" name=\"SBannerName\"");
                BeginWriteAttribute("value", " value=\"", 1241, "\"", 1267, 1);
#nullable restore
#line 29 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml"
WriteAttributeValue("", 1249, Model.SBannerName, 1249, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" required>
                    </div>
                    <!-- /.box-header -->
                    <div class=""box-body pad"">
                        <label>Description</label>
                        <textarea id=""Description"" class=""ckeditor"" name=""Description"" rows=""200"">");
#nullable restore
#line 34 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml"
                                                                                             Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</textarea>
                    </div>

                    <div class=""form-group"">
                        <label>
                            Select Pictures
                        </label>
                        <input class=""form-control"" name=""SecoundBannerPictures"" id=""secoundBannerPictures"" type=""file"" />
                        <div id=""picturesArea"" class=""form-group"" style=""margin-top:20px"">
");
#nullable restore
#line 43 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml"
                             if (picture != null && picture.Count>0)
                            {
                                foreach (var pictures in picture)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7c74fff3298978f5266d7e3d337583ea59626a6e9138", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
                AddHtmlAttributeValue("", 2295, "~/Images/", 2295, 9, true);
#nullable restore
#line 47 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml"
AddHtmlAttributeValue("", 2304, pictures.Picture.PictureURL, 2304, 28, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml"
                                                                                                                                                       Write(pictures.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("data-id", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 48 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        </div>
                        <input type=""hidden"" name=""SecoundBannerPictures"" id=""PictureIDs"" />
                    </div>
                    <div>
                        <button id=""EditAdsAddBtn"" class=""btn btn-raised btn-primary waves-effect"" type=""button"">SUBMIT</button>
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 25 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml"
AddHtmlAttributeValue("", 915, Url.Action("EditAds","Ads"), 915, 28, false);

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
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <!-- /.col-->\r\n    </div>\r\n    <!-- ./row -->\r\n</section>\r\n<!-- /.content -->\r\n<div id=\"imageTemplate\" style=\"display:none\">\r\n    <img class=\'image img-thumbnail\'");
            BeginWriteAttribute("src", " src=\'", 2997, "\'", 3003, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""height:100px; width:100px"" />
</div>
<script>
    RemoveImageOnClick()
    $('#EditAdsAddBtn').click(function () {
        debugger;
        var imageIDs = [];
        for (instance in CKEDITOR.instances)
            CKEDITOR.instances[instance].updateElement();
        $(""#picturesArea .image"").each(function () {
            var imageID = $(this).attr(""data-id"");
            imageIDs.push(imageID);
        });
        $(""#PictureIDs"").val(imageIDs.join())
         $.ajax({
         url: """);
#nullable restore
#line 80 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml"
          Write(Url.Action("EditAds", "Ads"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\",\r\n             type: \"post\",\r\n             data: $(\"#EditAdsForm\").serialize()\r\n     }).done(function (responses) {\r\n         debugger;\r\n         alert(\"Ads Save Succesfully\");\r\n         window.location.href = \"");
#nullable restore
#line 86 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml"
                            Write(Url.Action("Index", "Ads"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
     }).fail(function () {

     });
    });

    $(""#secoundBannerPictures"").change(function () {
          debugger;
          var pictures = this.files;
          var picsData = new FormData();
        for (var i = 0; i < pictures.length; i++) {
            picsData.append(""Picture"", pictures[i]);
        }
        $.ajax({
            url: """);
#nullable restore
#line 100 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml"
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

                AttachNewImage(picResponse.pictureUrl, picResponse.id);
            }
        }).fail(function () { });
    });

    function AttachNewImage(imageURL, imageID) {
        debugger;

        var $newImageHTML = $(""#imageTemplate"").clone();

        $newImageHTML.find("".image"").attr(""src"", """);
#nullable restore
#line 121 "G:\Web Development\Ecommerce\Ecommerce.Web\Views\Ads\EditAds.cshtml"
                                             Write(Url.Content("/Images/"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""" + imageURL);
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
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecommerce.Web.Models.Ads.CreateAdsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591