#pragma checksum "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Course\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2856c6c48f96b918b68617ba59d49a2b4f669ac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Course_Index), @"mvc.1.0.view", @"/Views/Course/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2856c6c48f96b918b68617ba59d49a2b4f669ac", @"/Views/Course/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"887719b2138050ea4347ec2a22b0645558cf289a", @"/Views/_ViewImports.cshtml")]
    public class Views_Course_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VmCourses>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Breadcrum", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("https://keenitsolutions.com/products/html/educavo/mailer.php"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/courses/1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/owl.carousel.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Course\Index.cshtml"
  
    ViewData["Title"] = "Index";
    VmBreadcrum vmBreadcrum = new VmBreadcrum
    {
        Title = "Course Grid 01",
        Path = "Course",
        Image = "1.jpg"
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<!-- Breadcrumbs Start -->\r\n");
            WriteLiteral("\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "f2856c6c48f96b918b68617ba59d49a2b4f669ac7378", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 31 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Course\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = vmBreadcrum;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!-- Breadcrumbs End -->
<!-- Popular Course Section Start -->
<div class=""rs-popular-courses style1 course-view-style orange-color rs-inner-blog white-bg pt-100 pb-100 md-pt-70 md-pb-70"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-12 order-last"">
                <div class=""widget-area"">
                    <div class=""search-widget mb-50"">
                        <h3 class=""widget-title"">Course Search</h3>
                        <div class=""search-wrap"">
                            <input type=""search"" placeholder=""Searching..."" name=""s"" class=""search-input""");
            BeginWriteAttribute("value", " value=\"", 1423, "\"", 1431, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                            <button type=""submit"" value=""Search""><i class="" flaticon-search""></i></button>
                        </div>
                    </div>
                    <div class=""widget-archives mb-50"">
                        <h3 class=""widget-title"">Filter By</h3>
                        <div class=""filter-widget"">
                            <!-- Skills Form -->
                            <div class=""filter-form"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2856c6c48f96b918b68617ba59d49a2b4f669ac10266", async() => {
                WriteLiteral(@"
                                    <div class=""single-filter mb-30"">
                                        <h5>Skill Level</h5>
                                        <!-- Radio Box -->
                                        <div class=""radio-box form-group"">
                                            <input type=""radio"" name=""skill"" id=""type1"" value=""beginer"" checked>
                                            <label for=""type1"">Beginner</label>
                                        </div>

                                        <!-- Radio Box -->
                                        <div class=""radio-box form-group"">
                                            <input type=""radio"" name=""skill"" id=""type2"" value=""intermediate"">
                                            <label for=""type2"">Intermediate</label>
                                        </div>

                                        <!-- Radio Box -->
                                        <div class=""radio-box form");
                WriteLiteral(@"-group"">
                                            <input type=""radio"" name=""skill"" id=""type3"" value=""expert"">
                                            <label for=""type3"">Expert</label>
                                        </div>
                                    </div>

                                    <div class=""single-filter mb-30"">
                                        <h5>Price Level</h5>
                                        <!-- Radio Box -->
                                        <div class=""radio-box form-group"">
                                            <input type=""radio"" name=""price"" id=""type4"" value=""free"" checked>
                                            <label for=""type4"">Free (14)</label>
                                        </div>

                                        <div class=""radio-box form-group"">
                                            <input type=""radio"" name=""price"" id=""type5"" value=""paid"">
                                            <");
                WriteLiteral(@"label for=""type5"">Paid (26)</label>
                                        </div>
                                    </div>

                                    <div class=""single-filter mb-30"">
                                        <h5>Duration Time</h5>
                                        <!-- Radio Box -->
                                        <div class=""radio-box form-group"">
                                            <input type=""radio"" name=""duration"" id=""type6"" value=""six"" checked>
                                            <label for=""type6"">5+ hours (30)</label>
                                        </div>

                                        <div class=""radio-box form-group"">
                                            <input type=""radio"" name=""duration"" id=""type7"" value=""paid"">
                                            <label for=""type7"">10+ hours (20)</label>
                                        </div>

                                        <div class=""ra");
                WriteLiteral(@"dio-box form-group"">
                                            <input type=""radio"" name=""duration"" id=""type8"" value=""paid"">
                                            <label for=""type8"">15+ hours (5)</label>
                                        </div>
                                    </div>

                                    <div class=""single-filter mb-30"">
                                        <h5>Course Type</h5>
                                        <div class=""check-box form-group mb-0"">
                                            <input type=""checkbox"" name=""course"" id=""check1"" value=""check1"" checked>
                                            <label for=""check1"">Backend (3)</label>
                                        </div>
                                        <div class=""check-box form-group mb-0"">
                                            <input type=""checkbox"" name=""course"" id=""check2"" value=""check2"">
                                            <label for=""chec");
                WriteLiteral(@"k2"">CSS (6)</label>
                                        </div>
                                        <div class=""check-box form-group mb-0"">
                                            <input type=""checkbox"" name=""course"" id=""check3"" value=""check3"">
                                            <label for=""check3"">Frontend (8)</label>
                                        </div>
                                        <div class=""check-box form-group mb-0"">
                                            <input type=""checkbox"" name=""course"" id=""check4"" value=""check4"">
                                            <label for=""check4"">General (3)</label>
                                        </div>
                                        <div class=""check-box form-group mb-0"">
                                            <input type=""checkbox"" name=""course"" id=""check5"" value=""check5"">
                                            <label for=""check5"">Photography (7)</label>
                          ");
                WriteLiteral(@"              </div>
                                        <div class=""check-box form-group mb-0"">
                                            <input type=""checkbox"" name=""course"" id=""check6"" value=""check6"">
                                            <label for=""check6"">Photography (4)</label>
                                        </div>
                                        <div class=""check-box form-group mb-0"">
                                            <input type=""checkbox"" name=""course"" id=""check7"" value=""check7"">
                                            <label for=""check7"">Technology (5)</label>
                                        </div>
                                    </div>

                                    <div class=""single-filter mb-30"">
                                        <h5>Instructor</h5>
                                        <div class=""check-box form-group mb-0"">
                                            <input type=""checkbox"" id=""check8"" name=""che");
                WriteLiteral(@"ck8"" value=""check8"" checked>
                                            <label for=""check8"">Stuard (5)</label>
                                        </div>
                                        <div class=""check-box form-group mb-0"">
                                            <input type=""checkbox"" id=""check9"" name=""check9"" value=""check9"">
                                            <label for=""check9"">Benjamin (4)</label>
                                        </div>
                                        <div class=""check-box form-group mb-0"">
                                            <input type=""checkbox"" id=""check10"" name=""check10"" value=""check10"">
                                            <label for=""check10"">Mickel (7)</label>
                                        </div>
                                        <div class=""check-box form-group mb-0"">
                                            <input type=""checkbox"" id=""check11"" name=""check11"" value=""check11"">
                ");
                WriteLiteral(@"                            <label for=""check11"">Johnson (2)</label>
                                        </div>
                                        <div class=""check-box form-group mb-0"">
                                            <input type=""checkbox"" id=""check12"" name=""check12"" value=""check12"">
                                            <label for=""check12"">Elijabeth (5)</label>
                                        </div>
                                        <div class=""check-box form-group mb-0"">
                                            <input type=""checkbox"" id=""check13"" name=""check13"" value=""check13"">
                                            <label for=""check13"">Rebeka (4)</label>
                                        </div>
                                    </div>

                                    <div class=""form-group mb-0"">
                                        <input class=""readon2 orange"" type=""submit"" value=""Submit Now"">
                               ");
                WriteLiteral("     </div>\r\n                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                        </div>
                    </div>
                    <div class=""widget-archives mb-50"">
                        <h3 class=""widget-title"">Course Categories</h3>
                        <ul class=""categories"">
                            <li><a href=""#"">College</a></li>
                            <li><a href=""#"">High School</a></li>
                            <li><a href=""#"">Primary</a></li>
                            <li><a href=""#"">School</a></li>
                            <li><a href=""#"">University</a></li>
                        </ul>
                    </div>
                </div>
            </div>
            <div class=""col-lg-8 pr-50 md-pr-15"">
                <div class=""course-search-part"">
                    <div class=""course-view-part"">
                        <div class=""view-icons"">
                            <a href=""#"" class=""view-grid mr-10""><i class=""fa fa-th-large""></i></a>
                         ");
            WriteLiteral(@"   <a href=""#"" class=""view-list""><i class=""fa fa-list-ul""></i></a>
                        </div>
                        <div class=""view-text"">Showing 1-9 of 11 results</div>
                    </div>
                    <div class=""type-form"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2856c6c48f96b918b68617ba59d49a2b4f669ac21944", async() => {
                WriteLiteral(@"
                            <!-- Form Group -->
                            <div class=""form-group mb-0"">
                                <div class=""custom-select-box"">
                                    <select id=""timing"">
                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2856c6c48f96b918b68617ba59d49a2b4f669ac22479", async() => {
                    WriteLiteral("Default");
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
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2856c6c48f96b918b68617ba59d49a2b4f669ac23535", async() => {
                    WriteLiteral("Newest");
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
                WriteLiteral("\r\n                                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2856c6c48f96b918b68617ba59d49a2b4f669ac24590", async() => {
                    WriteLiteral("Old");
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
                WriteLiteral("\r\n                                    </select>\r\n                                </div>\r\n                            </div>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n                <div class=\"course-part clearfix\">\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 214 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Course\Index.cshtml"
                     foreach (var item in Model.Courses)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"courses-item\">\r\n                            <div class=\"img-part\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f2856c6c48f96b918b68617ba59d49a2b4f669ac27602", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n                            <div class=\"content-part\">\r\n                                <ul class=\"meta-part\">\r\n                                    <li><span class=\"price\">$");
#nullable restore
#line 222 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Course\Index.cshtml"
                                                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></li>\r\n                                    <li><a class=\"categorie\" href=\"#\">");
#nullable restore
#line 223 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Course\Index.cshtml"
                                                                 Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                </ul>\r\n                                <h3 class=\"title\"><a href=\"course-single.html\">");
#nullable restore
#line 225 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Course\Index.cshtml"
                                                                           Write(item.Description.Length>50? item.Description.Substring(0,50): item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h3>\r\n                                <h3><a href=\"#\" class=\"addToCard\" data-courseid=\"");
#nullable restore
#line 226 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Course\Index.cshtml"
                                                                            Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">Add to cart</a></h3>
                                <div class=""bottom-part"">
                                    <div class=""info-meta"">
                                        <ul>
                                            <li class=""user""><i class=""fa fa-user""></i> 245</li>
                                            <li class=""ratings"">
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                                <i class=""fa fa-star""></i>
                                                (05)
                                            </li>
                                        </ul>
                                    </div>
                                    <div class=""btn-part"">
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2856c6c48f96b918b68617ba59d49a2b4f669ac31439", async() => {
                WriteLiteral("<i class=\"flaticon-right-arrow\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-CourseId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 240 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Course\Index.cshtml"
                                                                                                WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CourseId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-CourseId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["CourseId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 245 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\Course\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>
                <div class=""pagination-area orange-color text-center mt-30 md-mt-0"">
                    <ul class=""pagination-part"">
                        <li class=""active""><a href=""#"">1</a></li>
                        <li><a href=""#"">2</a></li>
                        <li><a href=""#"">Next <i class=""fa fa-long-arrow-right""></i></a></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Popular Course Section End -->

");
            DefineSection("owlcarousel", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f2856c6c48f96b918b68617ba59d49a2b4f669ac34967", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VmCourses> Html { get; private set; }
    }
}
#pragma warning restore 1591
