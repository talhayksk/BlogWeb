#pragma checksum "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Guncelle.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3e134984e25ff2ab11ae2de8401dec39e36d481"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_AdminKullanici_Guncelle), @"mvc.1.0.view", @"/Areas/Admin/Views/AdminKullanici/Guncelle.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3e134984e25ff2ab11ae2de8401dec39e36d481", @"/Areas/Admin/Views/AdminKullanici/Guncelle.cshtml")]
    public class Areas_Admin_Views_AdminKullanici_Guncelle : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogWebUI.Areas.Admin.Models.AdminKullaniciViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div class=\"panel\">\r\n        <div class=\"panel-heading\">\r\n            <h3 class=\"panel-title\">Makale Oluştur</h3>\r\n        </div>\r\n        <div class=\"panel-body\">\r\n");
#nullable restore
#line 8 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Guncelle.cshtml"
             using (Html.BeginForm("Guncelle", "AdminKullanici", new { area = "", @class = "form-control" }, FormMethod.Post))
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Guncelle.cshtml"
           Write(Html.ValidationSummary(true));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Guncelle.cshtml"
           Write(Html.TextBox("AdSoyad", "", new { @class = "form-control", @placeholder = "AdSoyad" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br>\r\n");
#nullable restore
#line 14 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Guncelle.cshtml"
           Write(Html.TextBox("Email", "", new { @class = "form-control", @placeholder = "Email" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br> ");
#nullable restore
#line 15 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Guncelle.cshtml"
                Write(Html.TextBox("Parola", "", new { @class = "form-control", @placeholder = "Parola" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br> ");
#nullable restore
#line 16 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Guncelle.cshtml"
                Write(Html.TextBox("RolId", "", new { @class = "form-control", @placeholder = "RolId(1-2-3)" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br>\r\n                <input type=\"file\" class=\"form-control\">\r\n                <br>\r\n");
            WriteLiteral("                <br>\r\n                <input type=\"hidden\"");
            BeginWriteAttribute("asp-for", " asp-for=\"", 1039, "\"", 1077, 1);
#nullable restore
#line 23 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Guncelle.cshtml"
WriteAttributeValue("", 1049, Model.Kullanici.KullaniciId, 1049, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <button type=\"submit\" class=\"btn btn-primary btn-lg  \">Güncelle</button>\r\n");
#nullable restore
#line 25 "D:\GitHub\BlogWebs\Blog\BlogWebUI\Areas\Admin\Views\AdminKullanici\Guncelle.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n");
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
