#pragma checksum "/Users/arossi/Projects/Datasets/Datasets/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "463571dcc33dae9b3e03c7e3c36c803bb0467ad7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/arossi/Projects/Datasets/Datasets/Views/_ViewImports.cshtml"
using Datasets;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/arossi/Projects/Datasets/Datasets/Views/_ViewImports.cshtml"
using Datasets.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"463571dcc33dae9b3e03c7e3c36c803bb0467ad7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5539b8a2eb03209c32b99b71597f42d0455bac32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "GET", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline tm-mb-80 tm-search-form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/arossi/Projects/Datasets/Datasets/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<!DOCTYPE html>\n<html lang=\"en\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "463571dcc33dae9b3e03c7e3c36c803bb0467ad74269", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Xtra Blog</title>
    <link rel=""stylesheet"" href=""fontawesome/css/all.min.css""> <!-- https://fontawesome.com/ -->
    <link href=""https://fonts.googleapis.com/css2?family=Source+Sans+Pro&display=swap"" rel=""stylesheet""> <!-- https://fonts.google.com/ -->
    <link href=""css/bootstrap.min.css"" rel=""stylesheet"">
    <link href=""css/templatemo-xtra-blog.css"" rel=""stylesheet"">
    <!--

    TemplateMo 553 Xtra Blog

    https://templatemo.com/tm-553-xtra-blog

    -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "463571dcc33dae9b3e03c7e3c36c803bb0467ad75821", async() => {
                WriteLiteral(@"
    <header class=""tm-header"" id=""tm-header"">
        <div class=""tm-header-wrapper"">
            <button class=""navbar-toggler"" type=""button"" aria-label=""Toggle navigation"">
                <i class=""fas fa-bars""></i>
            </button>
            <div class=""tm-site-header"">
                <div class=""mb-3 mx-auto tm-site-logo""><i class=""fas fa-times fa-2x""></i></div>
                <h1 class=""text-center"">Xtra Blog</h1>
            </div>
            <nav class=""tm-nav"" id=""tm-nav"">
                <ul>
                    <li class=""tm-nav-item active"">
                        <a href=""index.html"" class=""tm-nav-link"">
                            <i class=""fas fa-home""></i>
                            Blog Home
                        </a>
                    </li>
                    <li class=""tm-nav-item"">
                        <a href=""post.html"" class=""tm-nav-link"">
                            <i class=""fas fa-pen""></i>
                            Single Post
                        </a>
    ");
                WriteLiteral(@"                </li>
                    <li class=""tm-nav-item"">
                        <a href=""about.html"" class=""tm-nav-link"">
                            <i class=""fas fa-users""></i>
                            About Xtra
                        </a>
                    </li>
                    <li class=""tm-nav-item"">
                        <a href=""contact.html"" class=""tm-nav-link"">
                            <i class=""far fa-comments""></i>
                            Contact Us
                        </a>
                    </li>
                </ul>
            </nav>
            <div class=""tm-mb-65"">
                <a rel=""nofollow"" href=""https://fb.com/templatemo"" class=""tm-social-link"">
                    <i class=""fab fa-facebook tm-social-icon""></i>
                </a>
                <a href=""https://twitter.com"" class=""tm-social-link"">
                    <i class=""fab fa-twitter tm-social-icon""></i>
                </a>
                <a href=""https://instagram.com"" class=""tm-soc");
                WriteLiteral(@"ial-link"">
                    <i class=""fab fa-instagram tm-social-icon""></i>
                </a>
                <a href=""https://linkedin.com"" class=""tm-social-link"">
                    <i class=""fab fa-linkedin tm-social-icon""></i>
                </a>
            </div>
            <p class=""tm-mb-80 pr-5 text-white"">
                Xtra Blog is a multi-purpose HTML template from TemplateMo website. Left side is a sticky menu bar. Right side content will scroll up and down.
            </p>
        </div>
    </header>
    <div class=""container-fluid"">
        <main class=""tm-main"">
            <!-- Search form -->
            <div class=""row tm-row"">
                <div class=""col-12"">
                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "463571dcc33dae9b3e03c7e3c36c803bb0467ad79013", async() => {
                    WriteLiteral(@"
                        <input class=""form-control tm-search-input"" name=""query"" type=""text"" placeholder=""Search..."" aria-label=""Search"">
                        <button class=""tm-search-button"" type=""submit"">
                            <i class=""fas fa-search tm-search-icon"" aria-hidden=""true""></i>
                        </button>
                    ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
            </div>
            <div class=""row tm-row"">
                <article class=""col-12 col-md-6 tm-post"">
                    <hr class=""tm-hr-primary"">
                    <a href=""post.html"" class=""effect-lily tm-post-link tm-pt-60"">
                        <div class=""tm-post-link-inner"">
                            <img src=""img/img-01.jpg"" alt=""Image"" class=""img-fluid"">
                        </div>
                        <span class=""position-absolute tm-new-badge"">New</span>
                        <h2 class=""tm-pt-30 tm-color-primary tm-post-title"">Simple and useful HTML layout</h2>
                    </a>
                    <p class=""tm-pt-30"">
                        There is a clickable image with beautiful hover effect and active title link for each post item.
                        Left side is a sticky menu bar. Right side is a blog content that will scroll up and down.
                    </p>
                    <div class=""d-flex justify-content-between tm");
                WriteLiteral(@"-pt-45"">
                        <span class=""tm-color-primary"">Travel . Events</span>
                        <span class=""tm-color-primary"">June 24, 2020</span>
                    </div>
                    <hr>
                    <div class=""d-flex justify-content-between"">
                        <span>36 comments</span>
                        <span>by Admin Nat</span>
                    </div>
                </article>
                <article class=""col-12 col-md-6 tm-post"">
                    <hr class=""tm-hr-primary"">
                    <a href=""post.html"" class=""effect-lily tm-post-link tm-pt-60"">
                        <div class="" tm-post-link-inner"">
                            <img src=""img/img-02.jpg"" alt=""Image"" class=""img-fluid"">
                        </div>
                        <span class=""position-absolute tm-new-badge"">New</span>
                        <h2 class=""tm-pt-30 tm-color-primary tm-post-title"">Multi-purpose blog template</h2>
                    </a>
               ");
                WriteLiteral(@"     <p class=""tm-pt-30"">
                        <a rel=""nofollow"" href=""https://templatemo.com/tm-553-xtra-blog"" target=""_blank"">Xtra Blog</a>  is a multi-purpose HTML CSS template from TemplateMo website.
                        Blog list, single post, about, contact pages are included. Left sidebar fixed width and content area is a fluid full-width.
                    </p>
                    <div class=""d-flex justify-content-between tm-pt-45"">
                        <span class=""tm-color-primary"">Creative . Design . Business</span>
                        <span class=""tm-color-primary"">June 16, 2020</span>
                    </div>
                    <hr>
                    <div class=""d-flex justify-content-between"">
                        <span>48 comments</span>
                        <span>by Admin Sam</span>
                    </div>
                </article>
                <article class=""col-12 col-md-6 tm-post"">
                    <hr class=""tm-hr-primary"">
                    <a href");
                WriteLiteral(@"=""post.html"" class=""effect-lily tm-post-link tm-pt-20"">
                        <div class=""tm-post-link-inner"">
                            <img src=""img/img-03.jpg"" alt=""Image"" class=""img-fluid"">
                        </div>
                        <h2 class=""tm-pt-30 tm-color-primary tm-post-title"">How can you apply Xtra Blog</h2>
                    </a>
                    <p class=""tm-pt-30"">
                        You are <u>allowed</u> to convert this template as any kind of CMS theme or template for your custom website builder.
                        You can also use this for your clients. Thank you for choosing us.
                    </p>
                    <div class=""d-flex justify-content-between tm-pt-45"">
                        <span class=""tm-color-primary"">Music . Audio</span>
                        <span class=""tm-color-primary"">June 11, 2020</span>
                    </div>
                    <hr>
                    <div class=""d-flex justify-content-between"">
                   ");
                WriteLiteral(@"     <span>24 comments</span>
                        <span>by John Walker</span>
                    </div>
                </article>
                <article class=""col-12 col-md-6 tm-post"">
                    <hr class=""tm-hr-primary"">
                    <a href=""post.html"" class=""effect-lily tm-post-link tm-pt-20"">
                        <div class=""tm-post-link-inner"">
                            <img src=""img/img-04.jpg"" alt=""Image"" class=""img-fluid"">
                        </div>
                        <h2 class=""tm-pt-30 tm-color-primary tm-post-title"">A little restriction to apply</h2>
                    </a>
                    <p class=""tm-pt-30"">
                        You are <u>not allowed</u> to re-distribute this template as a downloadable ZIP file on any template collection
                        website. This is strongly prohibited as we worked hard for this template. Please contact TemplateMo for more information.
                        <br>For example, <a href=""https://www.free-c");
                WriteLiteral(@"ss.com/free-css-templates/page272/xtra-blog"" target=""_blank"">Free-CSS</a> redistributed this Xtra Blog template on their website without asking any permission. It is an illegal act by Free-CSS website doing an unauthorized reposting.
                    </p>
                    <div class=""d-flex justify-content-between tm-pt-45"">
                        <span class=""tm-color-primary"">Artworks . Design</span>
                        <span class=""tm-color-primary"">June 4, 2020</span>
                    </div>
                    <hr>
                    <div class=""d-flex justify-content-between"">
                        <span>72 comments</span>
                        <span>by Admin Sam</span>
                    </div>
                </article>
                <article class=""col-12 col-md-6 tm-post"">
                    <hr class=""tm-hr-primary"">
                    <a href=""post.html"" class=""effect-lily tm-post-link tm-pt-20"">
                        <div class=""tm-post-link-inner"">
                     ");
                WriteLiteral(@"       <img src=""img/img-05.jpg"" alt=""Image"" class=""img-fluid"">
                        </div>
                        <h2 class=""tm-pt-30 tm-color-primary tm-post-title"">Color hexa values of Xtra Blog</h2>
                    </a>
                    <p class=""tm-pt-30"">
                        If you wish to kindly support us, please contact us or contribute a small PayPal amount to info [at] templatemo.com that is helpful for us.
                        <br>
                        Title #099 New #0CC <br>
                        <span class=""tm-color-primary"">Text #999 Line #CCC Next #0CC Prev #F0F0F0</span>
                    </p>
                    <div class=""d-flex justify-content-between tm-pt-45"">
                        <span class=""tm-color-primary"">Creative . Video . Audio</span>
                        <span class=""tm-color-primary"">May 31, 2020</span>
                    </div>
                    <hr>
                    <div class=""d-flex justify-content-between"">
                        <s");
                WriteLiteral(@"pan>84 comments</span>
                        <span>by Admin Sam</span>
                    </div>
                </article>
                <article class=""col-12 col-md-6 tm-post"">
                    <hr class=""tm-hr-primary"">
                    <a href=""post.html"" class=""effect-lily tm-post-link tm-pt-20"">
                        <div class=""tm-post-link-inner"">
                            <img src=""img/img-06.jpg"" alt=""Image"" class=""img-fluid"">
                        </div>
                        <h2 class=""tm-pt-30 tm-color-primary tm-post-title"">Donec convallis varius risus</h2>
                    </a>
                    <p class=""tm-pt-30"">
                        Quisque id ipsum vel sem maximus vulputate sed quis velit. Nunc vel turpis eget orci elementum cursus vitae in eros. Quisque vulputate nulla ut dolor consectetur luctus.
                    </p>
                    <div class=""d-flex justify-content-between tm-pt-45"">
                        <span class=""tm-color-primary"">Visual . Art");
                WriteLiteral(@"works</span>
                        <span class=""tm-color-primary"">June 16, 2020</span>
                    </div>
                    <hr>
                    <div class=""d-flex justify-content-between"">
                        <span>96 comments</span>
                        <span>by Admin Sam</span>
                    </div>
                </article>
            </div>
            <div class=""row tm-row tm-mt-100 tm-mb-75"">
                <div class=""tm-prev-next-wrapper"">
                    <a href=""#"" class=""mb-2 tm-btn tm-btn-primary tm-prev-next disabled tm-mr-20"">Prev</a>
                    <a href=""#"" class=""mb-2 tm-btn tm-btn-primary tm-prev-next"">Next</a>
                </div>
                <div class=""tm-paging-wrapper"">
                    <span class=""d-inline-block mr-3"">Page</span>
                    <nav class=""tm-paging-nav d-inline-block"">
                        <ul>
                            <li class=""tm-paging-item active"">
                                <a href=""#"" class=""");
                WriteLiteral(@"mb-2 tm-btn tm-paging-link"">1</a>
                            </li>
                            <li class=""tm-paging-item"">
                                <a href=""#"" class=""mb-2 tm-btn tm-paging-link"">2</a>
                            </li>
                            <li class=""tm-paging-item"">
                                <a href=""#"" class=""mb-2 tm-btn tm-paging-link"">3</a>
                            </li>
                            <li class=""tm-paging-item"">
                                <a href=""#"" class=""mb-2 tm-btn tm-paging-link"">4</a>
                            </li>
                        </ul>
                    </nav>
                </div>
            </div>
            <footer class=""row tm-row"">
                <hr class=""col-12"">
                <div class=""col-md-6 col-12 tm-color-gray"">
                    Design: <a rel=""nofollow"" target=""_parent"" href=""https://templatemo.com"" class=""tm-external-link"">TemplateMo</a>
                </div>
                <div class=""col-md-6 col");
                WriteLiteral(@"-12 tm-color-gray tm-copyright"">
                    Copyright 2020 Xtra Blog Company Co. Ltd.
                </div>
            </footer>
        </main>
    </div>
    <script src=""js/jquery.min.js""></script>
    <script src=""js/templatemo-script.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>");
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
