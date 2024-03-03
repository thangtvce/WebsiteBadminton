#pragma checksum "D:\.NET\WebApplication1\WebApplication1\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98a951583931350c38989d9a90bc9af63acc89ae"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Details), @"mvc.1.0.view", @"/Views/Blog/Details.cshtml")]
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
#line 1 "D:\.NET\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\.NET\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98a951583931350c38989d9a90bc9af63acc89ae", @"/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.TbTinTuc>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "D:\.NET\WebApplication1\WebApplication1\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = Model.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";
    string url = $"/tin-tuc/{Model.Alias}-{Model.PostId}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""blog-details-hero set-bg"" data-setbg=""img/blog/details/details-hero.jpg"">
    <div class=""container"">
        <div class=""row"">
         
            <div class=""col-lg-12"">
                <div class=""blog__details__hero__text"">
                    <h2>");
#nullable restore
#line 15 "D:\.NET\WebApplication1\WebApplication1\Views\Blog\Details.cshtml"
                   Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <ul>\r\n                        <li>");
#nullable restore
#line 17 "D:\.NET\WebApplication1\WebApplication1\Views\Blog\Details.cshtml"
                       Write(Model.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                        <li>");
#nullable restore
#line 18 "D:\.NET\WebApplication1\WebApplication1\Views\Blog\Details.cshtml"
                       Write(Model.CreatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</li>
                        <li>8 Comments</li>
                    </ul>
                </div>
            </div>
                    
        </div>
    </div>
</section>
<!-- Blog Details Hero End -->
<!-- Blog Details Section Begin -->
<section class=""blog-details spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-4 col-md-5 order-md-1 order-2"">
                <div class=""blog__sidebar"">
                    <div class=""blog__sidebar__search"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "98a951583931350c38989d9a90bc9af63acc89ae5994", async() => {
                WriteLiteral("\r\n                            <input type=\"text\" placeholder=\"Search...\">\r\n                            <button type=\"submit\"><span class=\"icon_search\"></span></button>\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </div>
                    <div class=""blog__sidebar__item"">
                        <h4>Categories</h4>
                        <ul>
                            <li><a href=""#"">All</a></li>
                            <li><a href=""#"">Beauty (20)</a></li>
                            <li><a href=""#"">Food (5)</a></li>
                            <li><a href=""#"">Life Style (9)</a></li>
                            <li><a href=""#"">Travel (10)</a></li>
                        </ul>
                    </div>
                    <div class=""blog__sidebar__item"">
                        <h4>Recent News</h4>
                        <div class=""blog__sidebar__recent"">
                            <a href=""#"" class=""blog__sidebar__recent__item"">
                                <div class=""blog__sidebar__recent__item__pic"">
                                    <img src=""img/blog/sidebar/sr-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2303, "\"", 2309, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""blog__sidebar__recent__item__text"">
                                    <h6>09 Kinds Of Vegetables<br /> Protect The Liver</h6>
                                    <span>MAR 05, 2019</span>
                                </div>
                            </a>
                            <a href=""#"" class=""blog__sidebar__recent__item"">
                                <div class=""blog__sidebar__recent__item__pic"">
                                    <img src=""img/blog/sidebar/sr-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 2894, "\"", 2900, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""blog__sidebar__recent__item__text"">
                                    <h6>Tips You To Balance<br /> Nutrition Meal Day</h6>
                                    <span>MAR 05, 2019</span>
                                </div>
                            </a>
                            <a href=""#"" class=""blog__sidebar__recent__item"">
                                <div class=""blog__sidebar__recent__item__pic"">
                                    <img src=""img/blog/sidebar/sr-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3483, "\"", 3489, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""blog__sidebar__recent__item__text"">
                                    <h6>4 Principles Help You Lose <br />Weight With Vegetables</h6>
                                    <span>MAR 05, 2019</span>
                                </div>
                            </a>
                        </div>
                    </div>
                    <div class=""blog__sidebar__item"">
                        <h4>Search By</h4>
                        <div class=""blog__sidebar__item__tags"">
                            <a href=""#"">Apple</a>
                            <a href=""#"">Beauty</a>
                            <a href=""#"">Vegetables</a>
                            <a href=""#"">Fruit</a>
                            <a href=""#"">Healthy Food</a>
                            <a href=""#"">Lifestyle</a>
                        </div>
                    </div>
                </div>
            </div>
          ");
            WriteLiteral("  <div class=\"col-lg-8 col-md-7 order-md-1 order-1\">\r\n                <div class=\"blog__details__text\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "98a951583931350c38989d9a90bc9af63acc89ae11274", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 4649, "~/images/tbTinTucs/", 4649, 19, true);
#nullable restore
#line 97 "D:\.NET\WebApplication1\WebApplication1\Views\Blog\Details.cshtml"
AddHtmlAttributeValue("", 4668, Model.Thumb, 4668, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <p>\r\n                        ");
#nullable restore
#line 99 "D:\.NET\WebApplication1\WebApplication1\Views\Blog\Details.cshtml"
                   Write(Model.Scontents);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                    <h3>\r\n                        ");
#nullable restore
#line 102 "D:\.NET\WebApplication1\WebApplication1\Views\Blog\Details.cshtml"
                   Write(Model.Contents);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    </h3>
                    
                </div>
                <div class=""blog__details__content"">
                    <div class=""row"">
                        <div class=""col-lg-6"">
                            <div class=""blog__details__author"">
                                <div class=""blog__details__author__pic"">
                                    <img src=""img/blog/details/details-author.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 5288, "\"", 5294, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                </div>
                                <div class=""blog__details__author__text"">
                                    <h6>Michael Scofield</h6>
                                    <span>Admin</span>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-6"">
                            <div class=""blog__details__widget"">
                                <ul>
                                    <li><span>Categories:</span> Food</li>
                                    <li><span>Tags:</span> All, Trending, Cooking, Healthy Food, Life Style</li>
                                </ul>
                                <div class=""blog__details__social"">
                                    <a href=""#""><i class=""fa fa-facebook""></i></a>
                                    <a href=""#""><i class=""fa fa-twitter""></i></a>
                                    <a href=""#""><i class=""fa fa");
            WriteLiteral(@"-google-plus""></i></a>
                                    <a href=""#""><i class=""fa fa-linkedin""></i></a>
                                    <a href=""#""><i class=""fa fa-envelope""></i></a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Blog Details Section End -->
<!-- Related Blog Section Begin -->
<section class=""related-blog spad"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-lg-12"">
                <div class=""section-title related-blog-title"">
                    <h2>Post You May Like</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog__item"">
                    <div class=""blog__item__pic"">
                        <img src=""img/blog/blog-1.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 7333, "\"", 7339, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""blog__item__text"">
                        <ul>
                            <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                            <li><i class=""fa fa-comment-o""></i> 5</li>
                        </ul>
                        <h5><a href=""#"">Cooking tips make cooking simple</a></h5>
                        <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog__item"">
                    <div class=""blog__item__pic"">
                        <img src=""img/blog/blog-2.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8111, "\"", 8117, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""blog__item__text"">
                        <ul>
                            <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                            <li><i class=""fa fa-comment-o""></i> 5</li>
                        </ul>
                        <h5><a href=""#"">6 ways to prepare breakfast for 30</a></h5>
                        <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                    </div>
                </div>
            </div>
            <div class=""col-lg-4 col-md-4 col-sm-6"">
                <div class=""blog__item"">
                    <div class=""blog__item__pic"">
                        <img src=""img/blog/blog-3.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 8891, "\"", 8897, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                    </div>
                    <div class=""blog__item__text"">
                        <ul>
                            <li><i class=""fa fa-calendar-o""></i> May 4,2019</li>
                            <li><i class=""fa fa-comment-o""></i> 5</li>
                        </ul>
                        <h5><a href=""#"">Visit the clean farm in the US</a></h5>
                        <p>Sed quia non numquam modi tempora indunt ut labore et dolore magnam aliquam quaerat </p>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.TbTinTuc> Html { get; private set; }
    }
}
#pragma warning restore 1591
