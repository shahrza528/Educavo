#pragma checksum "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9dc44354ed60f0d57987eec3aac12f99a4b0ea3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Footer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Footer/Default.cshtml")]
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
#line 1 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\_ViewImports.cshtml"
using Educavo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\_ViewImports.cshtml"
using Educavo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\_ViewImports.cshtml"
using Educavo.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9dc44354ed60f0d57987eec3aac12f99a4b0ea3d", @"/Views/Shared/Components/Footer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"887719b2138050ea4347ec2a22b0645558cf289a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Footer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmFooter>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<footer id=""rs-footer"" class=""rs-footer home9-style main-home"">
    <div class=""footer-top"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-3 col-md-12 col-sm-12 footer-widget"">
                    <div class=""footer-logo mb-30"">
                        <a href=""index.html"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9dc44354ed60f0d57987eec3aac12f99a4b0ea3d4593", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 387, "~/assets/images/", 387, 16, true);
#nullable restore
#line 12 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
AddHtmlAttributeValue("", 403, Model.Setting.Logo2, 403, 20, false);

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
            WriteLiteral("</a>\r\n                    </div>\r\n                    <div class=\"textwidget white-color pr-60 md-pr-15\">\r\n                        <p>");
#nullable restore
#line 15 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
                      Write(Model.Setting.About);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                    <ul class=\"footer_social\">\r\n");
#nullable restore
#line 18 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
                         foreach (var item in Model.Socials)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <li>\r\n                                <a href=\"#\" target=\"_blank\"");
            BeginWriteAttribute("title", " title=\"", 850, "\"", 868, 1);
#nullable restore
#line 21 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 858, item.Name, 858, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span><i");
            BeginWriteAttribute("class", " class=\"", 878, "\"", 896, 1);
#nullable restore
#line 21 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 886, item.Icon, 886, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i></span></a>\r\n                            </li>\r\n");
#nullable restore
#line 23 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    </ul>
                </div>
                <div class=""col-lg-3 col-md-12 col-sm-12 footer-widget md-mb-50"">
                    <h3 class=""widget-title"">Address</h3>
                    <ul class=""address-widget"">
                        <li>
                            <i class=""flaticon-location""></i>
                            <div class=""desc"">");
#nullable restore
#line 31 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
                                         Write(Model.Setting.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </li>\r\n                        <li>\r\n                            <i class=\"flaticon-call\"></i>\r\n                            <div class=\"desc\">\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1590, "\"", 1621, 2);
            WriteAttributeValue("", 1597, "tel:", 1597, 4, true);
#nullable restore
#line 36 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
WriteAttributeValue("", 1601, Model.Setting.Phone, 1601, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 36 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
                                                              Write(Model.Setting.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </div>
                        </li>
                        <li>
                            <i class=""flaticon-email""></i>
                            <div class=""desc"">
                                <a href=""mailto:"" ");
#nullable restore
#line 42 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
                                             Write(Model.Setting.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(">");
#nullable restore
#line 42 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
                                                                  Write(Model.Setting.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                            </div>
                        </li>
                    </ul>
                </div>
                <div class=""col-lg-3 col-md-12 col-sm-12 pl-50 md-pl-15 footer-widget md-mb-50"">
                    <h3 class=""widget-title"">Courses</h3>
                    <ul class=""site-map"">
                        <li><a href=""#"">Courses</a></li>
                        <li><a href=""#"">Course Two</a></li>
                        <li><a href=""#"">Single Course</a></li>
                        <li><a href=""#"">Profile</a></li>
                        <li><a href=""#"">Login/Register</a></li>
                    </ul>
                </div>
                <div class=""col-lg-3 col-md-12 col-sm-12 footer-widget"">
                    <h3 class=""widget-title"">Recent Posts</h3>
");
#nullable restore
#line 59 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
                     foreach (var item in Model.RecentBlogs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"recent-post mb-20\">\r\n                            <div class=\"post-img\">\r\n");
            WriteLiteral("                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "9dc44354ed60f0d57987eec3aac12f99a4b0ea3d12248", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3078, "~/assets/images/blog/", 3078, 21, true);
#nullable restore
#line 64 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
AddHtmlAttributeValue("", 3099, item.Image, 3099, 11, false);

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
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"post-item\">\r\n                                <div class=\"post-desc\">\r\n                                    <a href=\"#\">");
#nullable restore
#line 68 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
                                           Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                </div>
                                <span class=""post-date"">
                                    <i class=""fa fa-calendar""></i>
                                    September 20, 2020
                                </span>
                            </div>
                        </div>
");
#nullable restore
#line 76 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Shared\Components\Footer\Default.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"                </div>
            </div>
        </div>
    </div>
    <div class=""footer-bottom"">
        <div class=""container"">
            <div class=""row y-middle"">
                <div class=""col-lg-6 md-mb-20"">
                    <div class=""copyright"">
                        <p>&copy; 2020 All Rights Reserved. Developed By <a href=""http://rstheme.com/"">RSTheme</a></p>
                    </div>
                </div>
                <div class=""col-lg-6 text-right md-text-left"">
                    <ul class=""copy-right-menu"">
                        <li><a href=""#"">Event</a></li>
                        <li><a href=""#"">Blog</a></li>
                        <li><a href=""#"">Contact</a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</footer>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmFooter> Html { get; private set; }
    }
}
#pragma warning restore 1591
