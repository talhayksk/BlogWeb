#pragma checksum "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c2389e2e6422b0e55df669005c3d42bfbd37b22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_Bildirim_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/Bildirim/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c2389e2e6422b0e55df669005c3d42bfbd37b22", @"/Areas/Admin/Views/Shared/Components/Bildirim/Default.cshtml")]
    public class Areas_Admin_Views_Shared_Components_Bildirim_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogWebUI.Areas.Admin.Models.AdminBildirimViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("24"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("24"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle avatar"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-circle"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<li class=\"dropdown\">\r\n                            <a href=\"#\" class=\"dropdown-toggle icon-menu\" data-toggle=\"dropdown\">\r\n                                <i class=\"lnr lnr-alarm\"></i>\r\n                                <span class=\"badge bg-danger\">\r\n");
#nullable restore
#line 8 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                       int say = 0;string sayi = "";

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                     foreach (var item in Model.Bildirimler)
                                    {
                                        if (item.Okundumu == false)
                                        {
                                            say = say + 1;

                                        }

                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                     if (say > 5)
                                    {
                                        
                                        sayi ="5+";
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                   Write(sayi);

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                             
                                    }
                                    else
                                    {
                                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                   Write(say);

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                            

                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </span>\r\n                            </a>\r\n<ul class=\"dropdown-menu notifications\">\r\n");
#nullable restore
#line 32 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
     foreach (var item in Model.Bildirimler.OrderByDescending(x=>x.GondermeTarihi).Take(5))
    {
        if (item.Gonderilen == Model.KulId)
        {
            if (item.Okundumu == false)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                 <li>\r\n                     <form enctype=\"multipart/form-data\" method=\"post\" action=\"/Admin/AdminBildirim/BildirimDetay\">\r\n                         <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 1722, "\"", 1738, 1);
#nullable restore
#line 40 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
WriteAttributeValue("", 1730, item.id, 1730, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                         <button type=\"submit\"  style=\"text-align:left;border:none;\"  class=\"notification-item btn btn-default  text-md-left\">\r\n\r\n                             <span");
            BeginWriteAttribute("class", " class=\"", 1924, "\"", 1932, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 44 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                  foreach (var kul in Model.Kullanicilar)
                                 {
                                     if (kul.KullaniciId == item.Gonderen)
                                     {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                         ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2c2389e2e6422b0e55df669005c3d42bfbd37b228679", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2214, "~/images/KulFoto/", 2214, 17, true);
#nullable restore
#line 48 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
AddHtmlAttributeValue("", 2231, kul.FotoUrl, 2231, 12, false);

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
            WriteLiteral("\r\n");
#nullable restore
#line 49 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                    Write(kul.KulAdSoyad);

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                                        
                                     }
                                 }

#line default
#line hidden
#nullable disable
            WriteLiteral("                             </span>\r\n");
#nullable restore
#line 53 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                              if (item.GondermeTarihi.ToShortDateString() == DateTime.Now.ToShortDateString())
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <span class=\"text-right\" style=\"font-size:11px;\">");
#nullable restore
#line 55 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                                                             Write(item.GondermeTarihi.ToLongTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 56 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"

                             }
                             else
                             {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <span class=\"text-right text-center right\" style=\"font-size:11px;\">");
#nullable restore
#line 60 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                                                                               Write(item.GondermeTarihi.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 61 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"

                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                             <br />\r\n");
#nullable restore
#line 64 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                              if (item.Mesaj.Length > 30)
                             {
                                 

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                            Write(item.Mesaj.Substring(0, 30));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <span class=\"dot bg-danger right\"></span>\r\n");
#nullable restore
#line 68 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"

                             }
                             else
                             {
                                 

#line default
#line hidden
#nullable disable
#nullable restore
#line 72 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                            Write(item.Mesaj);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                 <span class=\"dot  bg-danger\"></span>\r\n");
#nullable restore
#line 74 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                             }

#line default
#line hidden
#nullable disable
            WriteLiteral("                         </button>\r\n                     </form>\r\n                  </li>\r\n");
#nullable restore
#line 78 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <li>\r\n                    <form enctype=\"multipart/form-data\" method=\"post\" action=\"/Admin/AdminBildirim/BildirimDetay\">\r\n                        <input type=\"hidden\" name=\"id\"");
            BeginWriteAttribute("value", " value=\"", 3876, "\"", 3892, 1);
#nullable restore
#line 83 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
WriteAttributeValue("", 3884, item.id, 3884, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                        <button type=\"submit\" style=\"text-align:left;border:none;\" class=\"notification-item btn btn-default  text-md-left\">\r\n\r\n                            <span");
            BeginWriteAttribute("class", " class=\"", 4074, "\"", 4082, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n");
#nullable restore
#line 87 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                 foreach (var kul in Model.Kullanicilar)
                                {
                                    if (kul.KullaniciId == item.Gonderen)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2c2389e2e6422b0e55df669005c3d42bfbd37b2216129", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4359, "~/images/KulFoto/", 4359, 17, true);
#nullable restore
#line 91 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
AddHtmlAttributeValue("", 4376, kul.FotoUrl, 4376, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 92 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                   Write(kul.KulAdSoyad);

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                                       
                                    }
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            </span>\r\n");
#nullable restore
#line 96 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                             if (item.GondermeTarihi.ToShortDateString() == DateTime.Now.ToShortDateString())
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"text-right\" style=\"font-size:11px;\">");
#nullable restore
#line 98 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                                                            Write(item.GondermeTarihi.ToLongTimeString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 99 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"

                            }
                            else
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"text-right text-center right\" style=\"font-size:11px;\">");
#nullable restore
#line 103 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                                                                                              Write(item.GondermeTarihi.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 104 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <br />\r\n");
#nullable restore
#line 107 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                             if (item.Mesaj.Length > 30)
                            {

                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 110 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                           Write(item.Mesaj.Substring(0, 30));

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"dot  bg-transparent\"></span>\r\n");
#nullable restore
#line 112 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"

                            }
                            else
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 116 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
                           Write(item.Mesaj);

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <span class=\"dot bg-transparent\"></span>\r\n");
#nullable restore
#line 118 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"


                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </button>\r\n                </form>\r\n</li>\r\n");
#nullable restore
#line 125 "D:\GitHub\BlogWeb\Blog\BlogWebUI\Areas\Admin\Views\Shared\Components\Bildirim\Default.cshtml"
            }


        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li><a href=\"#\" class=\"more\">Tüm Bildirimleri Görüntüle</a></li>\r\n</ul>\r\n</li>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogWebUI.Areas.Admin.Models.AdminBildirimViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
