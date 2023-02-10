#pragma checksum "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "50422837ca1e3e8ada72080a30a45629aabb9618"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_News_List), @"mvc.1.0.view", @"/Views/News/List.cshtml")]
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
#line 1 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\_ViewImports.cshtml"
using BlogWebDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\_ViewImports.cshtml"
using BlogWebDemo.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
using PagedList.Core.Mvc;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"50422837ca1e3e8ada72080a30a45629aabb9618", @"/Views/News/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7334d4c2014b6b6d980322d938782cec241592f6", @"/Views/_ViewImports.cshtml")]
    public class Views_News_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PagedList.Core.PagedList<BlogWebDemo.Models.News>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
  
    Category category = ViewBag.DanhMuc;
    ViewData["Title"] = category.Title;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""page-header"">
    <div class=""container-xl"">
        <div class=""text-center"">
            <h1 class=""mt-0 mb-2"">Lifestyle</h1>
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb justify-content-center mb-0"">
                    <li class=""breadcrumb-item""><a href=""#"">Home</a></li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Lifestyle</li>
                </ol>
            </nav>
        </div>
    </div>
</section>

<!-- section main content -->
<section class=""main-content"">
    <div class=""container-xl"">

        <div class=""row gy-4"">

            <div class=""col-lg-8"">

                <div class=""row gy-4"">
");
#nullable restore
#line 33 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
                     if (Model != null && Model.Count > 0)
                    {
                        foreach (var item in Model)
                        {
                            string url = $"/{item.Alias}.html";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <div class=""col-sm-6"">
                                <!-- post -->
                                <div class=""post post-grid rounded bordered"">
                                    <div class=""thumb top-rounded"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 1464, "\"", 1487, 2);
            WriteAttributeValue("", 1471, "/", 1471, 1, true);
#nullable restore
#line 42 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
WriteAttributeValue("", 1472, item.Cat.Alias, 1472, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"category-badge position-absolute\">");
#nullable restore
#line 42 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
                                                                                                       Write(item.Cat.CatName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                        <span class=\"post-format\">\r\n                                            <i class=\"icon-picture\"></i>\r\n                                        </span>\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 1786, "\"", 1797, 1);
#nullable restore
#line 46 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
WriteAttributeValue("", 1793, url, 1793, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                            <div class=\"inner\">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "50422837ca1e3e8ada72080a30a45629aabb96186794", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1924, "~/images/posts/", 1924, 15, true);
#nullable restore
#line 48 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
AddHtmlAttributeValue("", 1939, item.Thumb, 1939, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 48 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
AddHtmlAttributeValue("", 1957, item.Title, 1957, 11, false);

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
            WriteLiteral(@"
                                            </div>
                                        </a>
                                    </div>
                                    <div class=""details"">
                                        <ul class=""meta list-inline mb-0"">
                                            <li class=""list-inline-item""><a href=""#""><img src=""images/other/author-sm.png"" class=""author""");
            BeginWriteAttribute("alt", " alt=\"", 2388, "\"", 2405, 1);
#nullable restore
#line 54 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
WriteAttributeValue("", 2394, item.Title, 2394, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />");
#nullable restore
#line 54 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
                                                                                                                                                         Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n                                            <li class=\"list-inline-item\">");
#nullable restore
#line 55 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
                                                                    Write(item.CreatedAt.Value.ToString("dd MMMM yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        </ul>\r\n                                        <h5 class=\"post-title mb-3 mt-3\"><a");
            BeginWriteAttribute("href", " href=\"", 2680, "\"", 2691, 1);
#nullable restore
#line 57 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
WriteAttributeValue("", 2687, url, 2687, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 57 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
                                                                                   Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                                        <p class=\"excerpt mb-0\">");
#nullable restore
#line 58 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
                                                           Write(item.Scontents);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                    </div>
                                    <div class=""post-bottom clearfix d-flex align-items-center"">
                                        <div class=""social-share me-auto"">
                                            <button class=""toggle-button icon-share""></button>
                                            <ul class=""icons list-unstyled list-inline mb-0"">
                                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-linkedin-in""></i></a></li>
                                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-pinterest""></i></a></li>
                                                <li class=""list-inline-item""><a ");
            WriteLiteral(@"href=""#""><i class=""fab fa-telegram-plane""></i></a></li>
                                                <li class=""list-inline-item""><a href=""#""><i class=""far fa-envelope""></i></a></li>
                                            </ul>
                                        </div>
                                        <div class=""more-button float-end"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 4228, "\"", 4239, 1);
#nullable restore
#line 73 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
WriteAttributeValue("", 4235, url, 4235, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><span class=\"icon-options\"></span></a>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 78 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>

                <nav>
                    <ul class=""pagination justify-content-center"">
                        <li class=""page-item active"" aria-current=""page"">
                            <span class=""page-link"">1</span>
                        </li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">2</a></li>
                        <li class=""page-item""><a class=""page-link"" href=""#"">3</a></li>
                    </ul>
                </nav>

            </div>

            <div class=""col-lg-4"">

                <!-- sidebar -->
                <div class=""sidebar"">
                    <!-- widget about -->
                    <div class=""widget rounded"">
                        <div class=""widget-about data-bg-image text-center"" data-bg-image=""images/map-bg.png"">
                            <img src=""images/logo.svg"" alt=""logo"" class=""mb-4"" />
                            <p class=""mb-4"">Hello, We’re content writer who is fascinated");
            WriteLiteral(@" by content fashion, celebrity and lifestyle. We helps clients bring the right content to the right people.</p>
                            <ul class=""social-icons list-unstyled list-inline mb-0"">
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-facebook-f""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-twitter""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-instagram""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-pinterest""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-medium""></i></a></li>
                                <li class=""list-inline-item""><a href=""#""><i class=""fab fa-youtube""></i></a></li>
                            </ul>
                        </div>
                    </div>

                    <!-- widget popula");
            WriteLiteral("r posts -->\r\n                    ");
#nullable restore
#line 115 "E:\.NET BE\BlogWeb\BlogWebDemo\BlogWebDemo\Views\News\List.cshtml"
               Write(await Component.InvokeAsync("Popular"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                    <!-- widget categories -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Explore Topics</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <ul class=""list"">
                                <li><a href=""#"">Lifestyle</a><span>(5)</span></li>
                                <li><a href=""#"">Inspiration</a><span>(2)</span></li>
                                <li><a href=""#"">Fashion</a><span>(4)</span></li>
                                <li><a href=""#"">Politic</a><span>(1)</span></li>
                                <li><a href=""#"">Trending</a><span>(7)</span></li>
                                <li><a href=""#"">Culture</a><span>(3)</span></li>
                            </ul>
                        </div>

            WriteLiteral(@"
                    </div>

                    <!-- widget newsletter -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Newsletter</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <span class=""newsletter-headline text-center mb-3"">Join 70,000 subscribers!</span>
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50422837ca1e3e8ada72080a30a45629aabb961817763", async() => {
                WriteLiteral(@"
                                <div class=""mb-2"">
                                    <input class=""form-control w-100 text-center"" placeholder=""Email address…"" type=""email"">
                                </div>
                                <button class=""btn btn-default btn-full"" type=""submit"">Sign Up</button>
                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            <span class=""newsletter-privacy text-center mt-3"">By signing up, you agree to our <a href=""#"">Privacy Policy</a></span>
                        </div>
                    </div>

                    <!-- widget post carousel -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Celebration</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <div class=""post-carousel-widget"">
                                <!-- post -->
                                <div class=""post post-carousel"">
                                    <div class=""thumb rounded"">
                                        <a href=""category.html"" class=""category-badge position-absolute"">How to</a>
                                        <a hre");
            WriteLiteral(@"f=""blog-single.html"">
                                            <div class=""inner"">
                                                <img src=""images/widgets/widget-carousel-1.jpg"" alt=""post-title"" />
                                            </div>
                                        </a>
                                    </div>
                                    <h5 class=""post-title mb-0 mt-4""><a href=""blog-single.html"">5 Easy Ways You Can Turn Future Into Success</a></h5>
                                    <ul class=""meta list-inline mt-2 mb-0"">
                                        <li class=""list-inline-item""><a href=""#"">Katen Doe</a></li>
                                        <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
                                <!-- post -->
                                <div class=""post post-carousel"">
                                    <div class=""thumb rounded"">");
            WriteLiteral(@"
                                        <a href=""category.html"" class=""category-badge position-absolute"">Trending</a>
                                        <a href=""blog-single.html"">
                                            <div class=""inner"">
                                                <img src=""images/widgets/widget-carousel-2.jpg"" alt=""post-title"" />
                                            </div>
                                        </a>
                                    </div>
                                    <h5 class=""post-title mb-0 mt-4""><a href=""blog-single.html"">Master The Art Of Nature With These 7 Tips</a></h5>
                                    <ul class=""meta list-inline mt-2 mb-0"">
                                        <li class=""list-inline-item""><a href=""#"">Katen Doe</a></li>
                                        <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
           ");
            WriteLiteral(@"                     <!-- post -->
                                <div class=""post post-carousel"">
                                    <div class=""thumb rounded"">
                                        <a href=""category.html"" class=""category-badge position-absolute"">How to</a>
                                        <a href=""blog-single.html"">
                                            <div class=""inner"">
                                                <img src=""images/widgets/widget-carousel-1.jpg"" alt=""post-title"" />
                                            </div>
                                        </a>
                                    </div>
                                    <h5 class=""post-title mb-0 mt-4""><a href=""blog-single.html"">5 Easy Ways You Can Turn Future Into Success</a></h5>
                                    <ul class=""meta list-inline mt-2 mb-0"">
                                        <li class=""list-inline-item""><a href=""#"">Katen Doe</a></li>
                  ");
            WriteLiteral(@"                      <li class=""list-inline-item"">29 March 2021</li>
                                    </ul>
                                </div>
                            </div>
                            <!-- carousel arrows -->
                            <div class=""slick-arrows-bot"">
                                <button type=""button"" data-role=""none"" class=""carousel-botNav-prev slick-custom-buttons"" aria-label=""Previous""><i class=""icon-arrow-left""></i></button>
                                <button type=""button"" data-role=""none"" class=""carousel-botNav-next slick-custom-buttons"" aria-label=""Next""><i class=""icon-arrow-right""></i></button>
                            </div>
                        </div>
                    </div>

                    <!-- widget advertisement -->
                    <div class=""widget no-container rounded text-md-center"">
                        <span class=""ads-title"">- Sponsored Ad -</span>
                        <a href=""#"" class=""widget-ads");
            WriteLiteral(@""">
                            <img src=""images/ads/ad-360.png"" alt=""Advertisement"" />
                        </a>
                    </div>

                    <!-- widget tags -->
                    <div class=""widget rounded"">
                        <div class=""widget-header text-center"">
                            <h3 class=""widget-title"">Tag Clouds</h3>
                            <img src=""images/wave.svg"" class=""wave"" alt=""wave"" />
                        </div>
                        <div class=""widget-content"">
                            <a href=""#"" class=""tag"">#Trending</a>
                            <a href=""#"" class=""tag"">#Video</a>
                            <a href=""#"" class=""tag"">#Featured</a>
                            <a href=""#"" class=""tag"">#Gallery</a>
                            <a href=""#"" class=""tag"">#Celebrities</a>
                        </div>
                    </div>

                </div>

            </div>

        </div>

    </div>
</sec");
            WriteLiteral("tion>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PagedList.Core.PagedList<BlogWebDemo.Models.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591