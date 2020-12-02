#pragma checksum "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1da6826441c9089ae78573cbf48dcac1098d4f35"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1da6826441c9089ae78573cbf48dcac1098d4f35", @"/Areas/Admin/Views/AdminKullanici/Index.cshtml")]
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
            WriteLiteral("    <!-- TABLE HOVER -->\r\n    <div class=\"panel\">\r\n        <div class=\"panel-heading\">\r\n            <h3 class=\"panel-title\">Makale İşlemleri</h3>\r\n        </div>\r\n        <div class=\"col-md-12\">\r\n");
            WriteLiteral(@"        </div>
        <div class=""panel-body"">
            <table class=""table table-hover"">
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
#line 28 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                     using (Html.BeginForm("Guncelle", "AdminKullanici", new { area = "", @class = "form-control" }, FormMethod.Post))
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                         foreach (var item in Model.Kullanicilar)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n\r\n                                <td>");
#nullable restore
#line 33 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                               Write(item.KullaniciId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 34 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                                 if (!item.FotoUrl.Equals(null))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1da6826441c9089ae78573cbf48dcac1098d4f356137", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1368, "~/images/KulFoto/", 1368, 17, true);
#nullable restore
#line 36 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
AddHtmlAttributeValue("", 1385, item.FotoUrl, 1385, 13, false);

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
#line 37 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1da6826441c9089ae78573cbf48dcac1098d4f358221", async() => {
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
#line 41 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"

                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 43 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                               Write(item.KulAdSoyad);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 44 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                               Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 45 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                               Write(item.RolId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                                <td colspan=\"2\" align=\"right\">\r\n                                    ");
#nullable restore
#line 56 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                               Write(Html.Hidden("Id",item.KullaniciId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                  ");
#nullable restore
#line 57 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                             Write(Html.ActionLink("Güncelle", "Guncelle","AdminKullanici",item.KullaniciId, new {@class= "btn btn-warning" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("                                    &nbsp;&nbsp;\r\n                                    <button type=\"button\" class=\"btn btn-danger\"><span class=\"lnr lnr-trash\"></span></button>\r\n                                </td>\r\n\r\n                            </tr>\r\n");
#nullable restore
#line 64 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n    <!-- END TABLE HOVER -->\r\n");
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
