#pragma checksum "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserLogin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "296f8c0f7b5106553b86770f79e9df2fcd5c9317"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserLogin), @"mvc.1.0.view", @"/Views/Home/UserLogin.cshtml")]
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
#line 1 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\_ViewImports.cshtml"
using Amazon_;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\_ViewImports.cshtml"
using Amazon_.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"296f8c0f7b5106553b86770f79e9df2fcd5c9317", @"/Views/Home/UserLogin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ae72482a8c09ef427e6d80879f49fe3b978de91", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserLogin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Amazon_.Models.Category>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/dawn_of_the_tiger.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid icon"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/forest.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "296f8c0f7b5106553b86770f79e9df2fcd5c93174861", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM"" crossorigin=""anonymous""></script>
    <link rel=""preconnect"" href=""https://fonts.googleapis.com"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"" crossorigin>
    <link href=""https://fonts.googleapis.com/css2?family=Baskervville&family=EB+Garamond:ital,wght@0,400;0,500;0,600;0,700;0,800;1,400;1,500;1,600;1,700;1,800&family=Lora:ital,wght@0,400;0,500;0,600;0,700;1,400;1,500;1,600;1,700&family=Montserrat:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,60");
                WriteLiteral(@"0;1,700;1,800;1,900&family=Nanum+Gothic&family=Nanum+Myeongjo&family=Noto+Serif+Devanagari:wght@100;200;300;400;500;600;700;800;900&family=Open+Sans:ital,wght@0,300;0,400;0,500;0,600;0,700;0,800;1,300;1,400;1,500;1,600;1,700;1,800&family=Quicksand&family=Raleway:ital,wght@0,100;0,200;0,300;0,400;0,500;0,600;0,700;0,800;0,900;1,100;1,200;1,300;1,400;1,500;1,600;1,700;1,800;1,900&family=Roboto:wght@100;300;400;500&family=Source+Sans+Pro:wght@300&display=swap"" rel=""stylesheet"">
    <script src=""https://code.jquery.com/jquery-3.6.0.min.js"" integrity=""sha256-/xUj+3OJU5yExlq6GSYGSHk7tPXikynS7ogEvDej/m4="" crossorigin=""anonymous""></script>
    <style>
        * {
            font-family: 'Baskervville', serif;
            font-family: 'EB Garamond', serif;
            font-family: 'Lora', serif;
            font-family: 'Montserrat', sans-serif;
            font-family: 'Nanum Gothic', sans-serif;
            font-family: 'Nanum Myeongjo', serif;
            font-family: 'Noto Serif Devanagari', serif;
   ");
                WriteLiteral(@"         font-family: 'Open Sans', sans-serif;
            font-family: 'Quicksand', sans-serif;
            font-family: 'Raleway', sans-serif;
            font-family: 'Roboto', sans-serif;
            font-family: 'Source Sans Pro', sans-serif;
        }

        .card_cover {
            box-shadow: rgba(0, 0, 0, 0.12) 0px 1px 3px, rgba(0, 0, 0, 0.24) 0px 1px 2px;
            background: #ffffff;
        }

        .image{
            width: 100%;
            height: 40vh;
        }

        .h1_tag{
            color: #2f4f4f;
            font-size: 20px;
            letter-spacing: 1px;
            
        }

        .p_tag{
            color: #2f4f4f;
            font-size: 12px;
            letter-spacing: 1px;
            line-height: 24px;
        }

        .sign_in {
            padding: 10px 20px 10px 20px;
            cursor: pointer;
            color: #ffffff;
            border: none;
            outline: none;
            box-shadow: rgba(0, 0, 0, 0.12) ");
                WriteLiteral(@"0px 1px 3px, rgba(0, 0, 0, 0.24) 0px 1px 2px;
            background: #008000a0;
            font-size: 12px;
            letter-spacing: 1px;
        }

        .sign_in:hover{
            background: #008000d0;
        }

        .label_name{
            color: #808080;
            font-size: 12px;
            letter-spacing: 1px;

        }

        .input{
            font-size: 12px;
            letter-spacing: 1px;
            padding-left: 40px;
            font-weight: 100;
        }

        .label_cover{
            width: 100%;
            padding: 8px;
            padding-left: 15px;
            color: #80808060;
            pointer-events: none;
        }

        .home {
            cursor: pointer;
            color: #6495ed;
            text-decoration: none;
            font-size: 12px;
            letter-spacing: 1px;
        }

        .home:hover{
            color: blue;
        }

        .icon{
            width: 50px;
            height: 50");
                WriteLiteral("px;\r\n        }\r\n\r\n        .anchor{\r\n            font-size: 12px;\r\n            letter-spacing: 1px;\r\n            text-decoration: none;\r\n\r\n        }\r\n    </style>\r\n");
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "296f8c0f7b5106553b86770f79e9df2fcd5c931710284", async() => {
                WriteLiteral("\r\n    <div class=\"p-lg-2\"></div>\r\n");
#nullable restore
#line 117 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserLogin.cshtml"
       
        if(ViewBag.message != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <div class=""alert alert-primary m-auto col-lg-8"" style=""font-size: 12px; letter-spacing: 1px;"">
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-cloud-rain-heavy-fill"" viewBox=""0 0 16 16"">
                <path d=""M4.176 11.032a.5.5 0 0 1 .292.643l-1.5 4a.5.5 0 0 1-.936-.35l1.5-4a.5.5 0 0 1 .644-.293zm3 0a.5.5 0 0 1 .292.643l-1.5 4a.5.5 0 0 1-.936-.35l1.5-4a.5.5 0 0 1 .644-.293zm3 0a.5.5 0 0 1 .292.643l-1.5 4a.5.5 0 0 1-.936-.35l1.5-4a.5.5 0 0 1 .644-.293zm3 0a.5.5 0 0 1 .292.643l-1.5 4a.5.5 0 0 1-.936-.35l1.5-4a.5.5 0 0 1 .644-.293zm.229-7.005a5.001 5.001 0 0 0-9.499-1.004A3.5 3.5 0 1 0 3.5 10H13a3 3 0 0 0 .405-5.973z"" />
            </svg>&nbsp;");
#nullable restore
#line 123 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserLogin.cshtml"
                   Write(ViewBag.message);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 125 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserLogin.cshtml"
            }
    

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"p-lg-2\"></div>\r\n    <div class=\"col-lg-10 card_cover row m-auto p-0\">\r\n\r\n");
#nullable restore
#line 130 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserLogin.cshtml"
         using (Html.BeginForm("UserLogin", "Home", FormMethod.Post, new { @class = "col-lg-6 m-0 p-5" }))
        {
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 132 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserLogin.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"            <svg xmlns=""http://www.w3.org/2000/svg"" width=""40"" height=""40"" fill=""#80808060"" class=""bi bi-tree-fill"" viewBox=""0 0 16 16"">
                <path d=""M8.416.223a.5.5 0 0 0-.832 0l-3 4.5A.5.5 0 0 0 5 5.5h.098L3.076 8.735A.5.5 0 0 0 3.5 9.5h.191l-1.638 3.276a.5.5 0 0 0 .447.724H7V16h2v-2.5h4.5a.5.5 0 0 0 .447-.724L12.31 9.5h.191a.5.5 0 0 0 .424-.765L10.902 5.5H11a.5.5 0 0 0 .416-.777l-3-4.5z"" />
            </svg>
            <h1 style=""color: #80808080; letter-spacing: 1px;"">Cognizant</h1>
            <div class=""p-2""></div>
            <p style=""color: #808080; letter-spacing: 1px; font-size: 12px; line-height: 24px;"">This is the user login page. We welcome our users to login in order to place orders for products.</p>
            <div class=""p-2""></div>
            <div class=""row m-0 p-0"">
                <div class=""col-lg-4 m-0 p-0""><label class=""label_name"">Username</label></div>
                <div class=""col-lg-8 m-0 p-0 position-relative"">
                    <input type=""text"" c");
                WriteLiteral(@"lass=""form-control input"" placeholder=""Please enter your username"" name=""Username"" required />
                    <div class=""position-absolute top-0 end-0 label_cover"">
                        <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-person-fill"" viewBox=""0 0 16 16"">
                            <path d=""M3 14s-1 0-1-1 1-4 6-4 6 3 6 4-1 1-1 1H3zm5-6a3 3 0 1 0 0-6 3 3 0 0 0 0 6z"" />
                        </svg>
                    </div>
                </div>
            </div>
            <div class=""p-2""></div>
            <div class=""row m-0 p-0"">
                <div class=""col-lg-4 m-0 p-0""><label class=""label_name"">Password</label></div>
                <div class=""col-lg-8 m-0 p-0 position-relative"">
                    <input type=""password"" class=""form-control input"" placeholder=""Please enter your password"" name=""Password"" required />
                    <div class=""position-absolute top-0 end-0 label_cover"">
                    ");
                WriteLiteral(@"    <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-key-fill"" viewBox=""0 0 16 16"">
                            <path d=""M3.5 11.5a3.5 3.5 0 1 1 3.163-5H14L15.5 8 14 9.5l-1-1-1 1-1-1-1 1-1-1-1 1H6.663a3.5 3.5 0 0 1-3.163 2zM2.5 9a1 1 0 1 0 0-2 1 1 0 0 0 0 2z"" />
                        </svg>
                    </div>
                </div>
            </div>
            <div class=""p-2""></div>
            <button class=""sign_in"">Sign In</button>
            <div class=""p-2""></div>
            <div class=""d-flex flex-row justify-content-between"">
                <div class=""d-flex flex-row align-items-center"">
                    ");
#nullable restore
#line 168 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserLogin.cshtml"
               Write(Html.ActionLink("Create a new account", "UserRegister", "Home", null, new { @class = "anchor" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n                <div class=\"d-flex flex-row align-items-center home\"");
                BeginWriteAttribute("onclick", " onclick=\"", 8384, "\"", 8438, 3);
                WriteAttributeValue("", 8394, "location.href=\'", 8394, 15, true);
#nullable restore
#line 170 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserLogin.cshtml"
WriteAttributeValue("", 8409, Url.Action("Index", "Home"), 8409, 28, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8437, "\'", 8437, 1, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n                    Let Us Go Home&nbsp;");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "296f8c0f7b5106553b86770f79e9df2fcd5c931716679", async() => {
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
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 174 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserLogin.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        <div class=\"col-lg-6 m-0 p-4\" style=\"background: #00800020;\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "296f8c0f7b5106553b86770f79e9df2fcd5c931718210", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            <div class=""p-2""></div>
            <h1 class=""h1_tag"">Spring Quotes</h1>
            <div class=""p-2""></div>
            <p class=""p_tag"">
                And into the forest I go, to lose my mind and find my soul. Hide yourself in God, so when a man wants to find you he will have to go there first. A cold wind was blowing from the north,
                and it made the trees rustle like living things. The clearest way into the Universe is through a forest wilderness.
            </p>
        </div>
    </div>
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Amazon_.Models.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
