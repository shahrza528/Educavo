#pragma checksum "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\FAQ\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ddd43f2c4f33eef1177fa3b16e3656679544a3c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FAQ_Index), @"mvc.1.0.view", @"/Views/FAQ/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ddd43f2c4f33eef1177fa3b16e3656679544a3c7", @"/Views/FAQ/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"887719b2138050ea4347ec2a22b0645558cf289a", @"/Views/_ViewImports.cshtml")]
    public class Views_FAQ_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/breadcrumbs/2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Breadcrumbs Image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "E:\Code Academy\Teaching\Groupes\P121\Lessons\71.16.06.2021\Educavo\Educavo\Views\FAQ\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- Breadcrumbs Start -->\r\n<div class=\"rs-breadcrumbs breadcrumbs-overlay\">\r\n    <div class=\"breadcrumbs-img\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ddd43f2c4f33eef1177fa3b16e3656679544a3c74676", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
    </div>
    <div class=""breadcrumbs-text white-color"">
        <h1 class=""page-title"">Faq</h1>
        <ul>
            <li>
                <a class=""active"" href=""index.html"">Home</a>
            </li>
            <li>Faq Us</li>
        </ul>
    </div>
</div>
<!-- Breadcrumbs End -->

<div class=""rs-faq-part orange-color pt-100 pb-100 md-pt-70 md-pb-70"">
    <div class=""container"">
        <div class=""content-part mb-50 md-mb-30"">
            <div class=""title mb-40 md-mb-15"">
                <h3 class=""text-part"">Kindergarten</h3>
            </div>
            <div id=""accordion"" class=""accordion"">
                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""card-link"" data-toggle=""collapse"" href=""#collapseOne"">What do you mean by item and end product?</a>
                    </div>
                    <div id=""collapseOne"" class=""collapse show"" data-parent=""#accordion"">
                        <div class=""card-body"">
 ");
            WriteLiteral(@"                           Aenean massa. Cum sociis natoque penatibus et magnis dis partu rient to montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellen of the tesque services Donec quam felis, ultricies nec, pellentesque eu, pretium quis,pede justo, of fringilla vel, aliquet nec
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""card-link collapsed"" data-toggle=""collapse"" href=""#collapseTwo"" aria-expanded=""false"">What does non-exclusive mean?</a>
                    </div>
                    <div id=""collapseTwo"" class=""collapse"" data-parent=""#accordion""");
            BeginWriteAttribute("style", " style=\"", 1992, "\"", 2000, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""card-body"">
                            Aenean massa. Cum sociis natoque penatibus et magnis dis partu rient to montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellen of the tesque services Donec quam felis, ultricies nec, pellentesque eu, pretium quis,pede justo, of fringilla vel, aliquet nec
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""card-link collapsed"" data-toggle=""collapse"" href=""#collapseThree"" aria-expanded=""false"">What are some examples of permitted end products?</a>
                    </div>
                    <div id=""collapseThree"" class=""collapse"" data-parent=""#accordion""");
            BeginWriteAttribute("style", " style=\"", 2811, "\"", 2819, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""card-body"">
                            Aenean massa. Cum sociis natoque penatibus et magnis dis partu rient to montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellen of the tesque services Donec quam felis, ultricies nec, pellentesque eu, pretium quis,pede justo, of fringilla vel, aliquet nec.
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""content-part mb-50 md-mb-30"">
            <div class=""title mb-40 md-mb-15"">
                <h3 class=""text-part"">Primary School</h3>
            </div>
            <div id=""accordion2"" class=""accordion"">
                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""card-link collapsed"" data-toggle=""collapse"" href=""#collapseFour"" aria-expanded=""false"">What if I have an emergency?</a>
                    </div>
                    <div id=""collapseFour"" class=""col");
            WriteLiteral("lapse\" data-parent=\"#accordion2\"");
            BeginWriteAttribute("style", " style=\"", 3876, "\"", 3884, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""card-body"">
                            Hematology, also spelled haematology, is the branch of medicine concerned with the study of the cause, prognosis, treatment, and prevention of diseases related to blood. It involves treating diseases that affect the production of blood and its components, such as blood cells, hemoglobin, blood proteins, bone marrow, platelets, blood vessels, spleen, and the mechanism of coagulation.
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""card-link"" data-toggle=""collapse"" href=""#collapseFive"">What if my regular doctor is unavailable?</a>
                    </div>
                    <div id=""collapseFive"" class=""collapse show"" data-parent=""#accordion2"">
                        <div class=""card-body"">
                            Hematology, also spelled haematology, is the branch of m");
            WriteLiteral(@"edicine concerned with the study of the cause, prognosis, treatment, and prevention of diseases related to blood. It involves treating diseases that affect the production of blood and its components, such as blood cells, hemoglobin, blood proteins, bone marrow, platelets, blood vessels, spleen, and the mechanism of coagulation.
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""card-link collapsed"" data-toggle=""collapse"" href=""#collapseSix"" aria-expanded=""false""> What should I bring to my first appointment?</a>
                    </div>
                    <div id=""collapseSix"" class=""collapse"" data-parent=""#accordion2""");
            BeginWriteAttribute("style", " style=\"", 5690, "\"", 5698, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""card-body"">
                            Hematology, also spelled haematology, is the branch of medicine concerned with the study of the cause, prognosis, treatment, and prevention of diseases related to blood. It involves treating diseases that affect the production of blood and its components, such as blood cells, hemoglobin, blood proteins, bone marrow, platelets, blood vessels, spleen, and the mechanism of coagulation.
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""content-part mb-50 md-mb-30"">
            <div class=""title mb-40 md-mb-15"">
                <h3 class=""text-part"">High School</h3>
            </div>
            <div id=""accordion3"" class=""accordion"">
                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""card-link collapsed"" data-toggle=""collapse"" href=""#collapseSeven"" aria-expanded=""false"">How ");
            WriteLiteral("does the normal heart work?</a>\r\n                    </div>\r\n                    <div id=\"collapseSeven\" class=\"collapse\" data-parent=\"#accordion3\"");
            BeginWriteAttribute("style", " style=\"", 6870, "\"", 6878, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""card-body"">
                            The normal heart is composed of four chambers. The two upper chambers (called atriums or atria) are reservoirs which collect blood as it flows back to the heart. From the atriums, blood flows into the lower two chambers (called ventricles) which pump blood, with each heart beat, into the main arteries.
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""card-link"" data-toggle=""collapse"" href=""#collapseEight"" aria-expanded=""true"">What are the heart valves?</a>
                    </div>
                    <div id=""collapseEight"" class=""collapse show"" data-parent=""#accordion3""");
            BeginWriteAttribute("style", " style=\"", 7693, "\"", 7701, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""card-body"">
                            The normal heart is composed of four chambers. The two upper chambers (called atriums or atria) are reservoirs which collect blood as it flows back to the heart. From the atriums, blood flows into the lower two chambers (called ventricles) which pump blood, with each heart beat, into the main arteries.
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""collapsed card-link"" data-toggle=""collapse"" href=""#collapseNine"">Can a child acquire a heart problem?</a>
                    </div>
                    <div id=""collapseNine"" class=""collapse"" data-parent=""#accordion3"">
                        <div class=""card-body"">
                            The normal heart is composed of four chambers. The two upper chambers (called atriums or atria) are reservoirs which collect blood as it f");
            WriteLiteral(@"lows back to the heart. From the atriums, blood flows into the lower two chambers (called ventricles) which pump blood, with each heart beat, into the main arteries.
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""content-part"">
            <div class=""title mb-40 md-mb-15"">
                <h3 class=""text-part""> College/University</h3>
            </div>
            <div id=""accordion4"" class=""accordion"">
                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""card-link"" data-toggle=""collapse"" href=""#collapseTen"">What is Education?</a>
                    </div>
                    <div id=""collapseTen"" class=""collapse show"" data-parent=""#accordion4"">
                        <div class=""card-body"">
                            Orthopedics (alternatively, orthopaedics) is a specialty focused on the diagnosis and treatment of conditions, disorders, di");
            WriteLiteral(@"seases and injuries of the muscles, bones, joints, tendons, ligaments, and nerves.
                        </div>
                    </div>
                </div>
                <div class=""card"">
                    <div class=""card-header"">
                        <a class=""collapsed card-link"" data-toggle=""collapse"" href=""#collapseEleven""> What is the difference between a sprain and a fracture?</a>
                    </div>
                    <div id=""collapseEleven"" class=""collapse"" data-parent=""#accordion4"">
                        <div class=""card-body"">
                            The normal heart is composed of four chambers. The two upper chambers (called atriums or atria) are reservoirs which collect blood as it flows back to the heart. From the atriums, blood flows into the lower two chambers (called ventricles) which pump blood, with each heart beat, into the main arteries.
                        </div>
                    </div>
                </div>
                <div class");
            WriteLiteral(@"=""card"">
                    <div class=""card-header"">
                        <a class=""collapsed card-link"" data-toggle=""collapse"" href=""#collapseTwelve""> What is an Advanced Practitioner?</a>
                    </div>
                    <div id=""collapseTwelve"" class=""collapse"" data-parent=""#accordion4"">
                        <div class=""card-body"">
                            The normal heart is composed of four chambers. The two upper chambers (called atriums or atria) are reservoirs which collect blood as it flows back to the heart. From the atriums, blood flows into the lower two chambers (called ventricles) which pump blood, with each heart beat, into the main arteries.
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
