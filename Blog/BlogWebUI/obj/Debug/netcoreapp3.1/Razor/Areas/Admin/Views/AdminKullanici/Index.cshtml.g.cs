#pragma checksum "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8fe4061be920adf177cfe5fbb2c1e48167384f3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminKullanici_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminKullanici/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8fe4061be920adf177cfe5fbb2c1e48167384f3", @"/Areas/Admin/Views/AdminKullanici/Index.cshtml")]
    public class Areas_Admin_Views_AdminKullanici_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogWebUI.Areas.Admin.Models.AdminKullaniciViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("32"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/KulFoto/profil-1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("    <!-- TABLE HOVER -->\r\n    <div class=\"panel\">\r\n        <div class=\"panel-heading\">\r\n            <h3 class=\"panel-title\">Kullanıcı İşlemleri</h3>\r\n        </div>\r\n        <div class=\"col-md-12\">\r\n");
            WriteLiteral("        </div>\r\n        <div class=\"panel-body\">\r\n");
#nullable restore
#line 16 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
             if (ViewBag.GuncellendiMi == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-success\" role=\"alert\">\r\n                    Mesajınız başarıyla gönderilmiştir.En kısa zamanda Size Geri Dönüş Yapılacaktır...\r\n\r\n                </div>\r\n");
#nullable restore
#line 22 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <table class=""table table-hover"">
                <thead>
                    <tr>
                        <th>#</th>
                        <th>Foto</th>
                        <th>Ad Soyad</th>
                        <th>Email</th>
                        <th>Rol</th>

                        <th></th>
                    </tr>
                </thead>
                <tbody>
");
#nullable restore
#line 36 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                     using (Html.BeginForm("Guncelle", "AdminKullanici", new { enctype = "multipart/form-data" }, FormMethod.Post))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                         foreach (var item in Model.Kullanicilar)
                        {
                            if (!Model.KulId.Equals(item.KullaniciId))
                            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <tr>\r\n                                    <td>");
#nullable restore
#line 44 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                                   Write(item.KullaniciId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 46 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                                     if (@item.FotoUrl != "")
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8fe4061be920adf177cfe5fbb2c1e48167384f36924", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1760, "~/images/KulFoto/", 1760, 17, true);
#nullable restore
#line 48 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
AddHtmlAttributeValue("", 1777, item.FotoUrl, 1777, 13, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#nullable restore
#line 49 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"


                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c8fe4061be920adf177cfe5fbb2c1e48167384f39026", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</td>\r\n");
#nullable restore
#line 55 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
#nullable restore
#line 57 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                                   Write(item.KulAdSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                    <td>");
#nullable restore
#line 58 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                                   Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n");
#nullable restore
#line 60 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                                     foreach (var i in Model.Roller)
                                    {
                                        if (item.RolId == i.RolId)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <td>");
#nullable restore
#line 64 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                                           Write(i.RolAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 65 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                                        }


                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td colspan=\"2\" align=\"right\">\r\n                                        <button type=\"submit\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 2776, "\"", 2801, 1);
#nullable restore
#line 70 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
WriteAttributeValue("", 2784, item.KullaniciId, 2784, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("formaction", " formaction=", 2802, "", 2837, 1);
#nullable restore
#line 70 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
WriteAttributeValue("", 2814, Url.Action("Guncelle"), 2814, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" formmethod=""get"" class=""btn btn-warning"">
                                            <i class=""fa fa-pencil-square-o"" aria-hidden=""true""></i>
                                        </button>
                                        &nbsp;&nbsp;
                                        <button type=""submit"" name=""id""");
            BeginWriteAttribute("value", " value=\"", 3159, "\"", 3184, 1);
#nullable restore
#line 74 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
WriteAttributeValue("", 3167, item.KullaniciId, 3167, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("formaction", " formaction=", 3185, "", 3215, 1);
#nullable restore
#line 74 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
WriteAttributeValue("", 3197, Url.Action("Sil"), 3197, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" formmethod=""get"" class=""btn btn-danger"">
                                            <span class=""lnr lnr-trash""></span>
                                        </button>



                                    </td>

                                </tr>
");
#nullable restore
#line 83 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                            }

                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n    <!-- END TABLE HOVER -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogWebUI.Areas.Admin.Models.AdminKullaniciViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
