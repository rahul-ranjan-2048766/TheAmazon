#pragma checksum "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "921c789b5a1a3ce557006e4883237457da74923e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserCart), @"mvc.1.0.view", @"/Views/Home/UserCart.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"921c789b5a1a3ce557006e4883237457da74923e", @"/Views/Home/UserCart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ae72482a8c09ef427e6d80879f49fe3b978de91", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserCart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<List<Amazon_.Models.CartDetail>, List<Amazon_.Models.Category>>>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "921c789b5a1a3ce557006e4883237457da74923e3308", async() => {
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

        .bar {
            background: #6495edd0;
            color: #ffffff;
        }

        .input {
            font-size: 12px;
            letter-spacing: 1px;
            padding-left: 40px;
            font-weight: 400;
        }

        .search_btn {
            cursor: pointer;
            color: #c71585;
            font-size: 12px;
            letter-spacing: 1px;
            background: transparent;
            border: 1px solid #c71585;
            border-radius: 2px;
            outline: none;
        }

            .search_btn:hover {
                background: #c71585;
                color: #ffffff;
            }

        li {
            cursor: pointer;
            border-bottom: 2px solid trans");
                WriteLiteral(@"parent;
        }

            li:hover {
                border-bottom: 2px solid #ffffff;
            }

        .label_cover {
            padding: 8px;
            width: 100%;
            padding-left: 15px;
            color: #80808060;
            pointer-events: none;
        }

        .label_name {
            color: #808080;
            font-size: 12px;
            letter-spacing: 1px;
            font-weight: 400;
        }

        .image {
            width: 100%;
            height: 36vh;
        }

        .p_tag {
            color: #808080;
            font-size: 12px;
            letter-spacing: 1px;
        }

        .card_cover {
            background: #ffffff;
            box-shadow: rgba(9, 30, 66, 0.25) 0px 1px 1px, rgba(9, 30, 66, 0.13) 0px 0px 1px 1px;
        }

        .update_profile {
            cursor: pointer;
            padding: 10px 20px 10px 20px;
            font-size: 12px;
            color: #ffffff;
            border: none;");
                WriteLiteral(@"
            outline: none;
            box-shadow: rgba(0, 0, 0, 0.12) 0px 1px 3px, rgba(0, 0, 0, 0.24) 0px 1px 2px;
            letter-spacing: 1px;
            background: #c71585a0;
        }

            .update_profile:hover {
                background: #c71585d0;
            }
    </style>
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "921c789b5a1a3ce557006e4883237457da74923e8859", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 115 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
     if (ViewBag.User == null)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <nav class=""navbar navbar-expand-lg navbar-light bar p-0 fixed-top"">
            <div class=""container p-0"">
                <a class=""navbar-brand"" style=""color: #ffffff; letter-spacing: 1px; font-weight: 600; user-select: none; cursor: default;"" href=""#"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""40"" height=""40"" fill=""currentColor"" class=""bi bi-snow2"" viewBox=""0 0 16 16"">
                        <path d=""M8 16a.5.5 0 0 1-.5-.5v-1.293l-.646.647a.5.5 0 0 1-.707-.708L7.5 12.793v-1.086l-.646.647a.5.5 0 0 1-.707-.708L7.5 10.293V8.866l-1.236.713-.495 1.85a.5.5 0 1 1-.966-.26l.237-.882-.94.542-.496 1.85a.5.5 0 1 1-.966-.26l.237-.882-1.12.646a.5.5 0 0 1-.5-.866l1.12-.646-.884-.237a.5.5 0 1 1 .26-.966l1.848.495.94-.542-.882-.237a.5.5 0 1 1 .258-.966l1.85.495L7 8l-1.236-.713-1.849.495a.5.5 0 1 1-.258-.966l.883-.237-.94-.542-1.85.495a.5.5 0 0 1-.258-.966l.883-.237-1.12-.646a.5.5 0 1 1 .5-.866l1.12.646-.237-.883a.5.5 0 0 1 .966-.258l.495 1.849.94.542-.236-.883a.5.5 0 0 1 .966-.258l.");
                WriteLiteral(@"495 1.849 1.236.713V5.707L6.147 4.354a.5.5 0 1 1 .707-.708l.646.647V3.207L6.147 1.854a.5.5 0 1 1 .707-.708l.646.647V.5a.5.5 0 0 1 1 0v1.293l.647-.647a.5.5 0 1 1 .707.708L8.5 3.207v1.086l.647-.647a.5.5 0 1 1 .707.708L8.5 5.707v1.427l1.236-.713.495-1.85a.5.5 0 1 1 .966.26l-.236.882.94-.542.495-1.85a.5.5 0 1 1 .966.26l-.236.882 1.12-.646a.5.5 0 0 1 .5.866l-1.12.646.883.237a.5.5 0 1 1-.26.966l-1.848-.495-.94.542.883.237a.5.5 0 1 1-.26.966l-1.848-.495L9 8l1.236.713 1.849-.495a.5.5 0 0 1 .259.966l-.883.237.94.542 1.849-.495a.5.5 0 0 1 .259.966l-.883.237 1.12.646a.5.5 0 0 1-.5.866l-1.12-.646.236.883a.5.5 0 1 1-.966.258l-.495-1.849-.94-.542.236.883a.5.5 0 0 1-.966.258L9.736 9.58 8.5 8.866v1.427l1.354 1.353a.5.5 0 0 1-.707.708l-.647-.647v1.086l1.354 1.353a.5.5 0 0 1-.707.708l-.647-.647V15.5a.5.5 0 0 1-.5.5z"" />
                    </svg>&nbsp;Amazon
                </a>
                <button class=""navbar-toggler m-2"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""");
                WriteLiteral(@"navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""34"" height=""34"" fill=""#ffffff"" class=""bi bi-strava"" viewBox=""0 0 16 16"">
                        <path d=""M6.731 0 2 9.125h2.788L6.73 5.497l1.93 3.628h2.766L6.731 0zm4.694 9.125-1.372 2.756L8.66 9.125H6.547L10.053 16l3.484-6.875h-2.112z"" />
                    </svg>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                    <ul class=""navbar-nav ms-auto m-0 mb-lg-0"">
                        <li class=""nav-item p-0 mx-2""");
                BeginWriteAttribute("onclick", " onclick=\"", 7250, "\"", 7305, 5);
                WriteAttributeValue("", 7260, "location.href", 7260, 13, true);
                WriteAttributeValue(" ", 7273, "=", 7274, 2, true);
                WriteAttributeValue(" ", 7275, "\'", 7276, 2, true);
#nullable restore
#line 131 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
WriteAttributeValue("", 7277, Url.Action("Site", "Home"), 7277, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7304, "\'", 7304, 1, true);
                EndWriteAttribute();
                WriteLiteral(" style=\"border-bottom: 2px solid #ffffff;\"><a class=\"nav-link active\" style=\"color: #ffffff; letter-spacing: 1px; font-size: 13px; font-weight: 600;\" aria-current=\"page\" href=\"#\">Home</a></li>\r\n                        <li class=\"nav-item p-0 mx-2\"");
                BeginWriteAttribute("onclick", " onclick=\"", 7553, "\"", 7611, 3);
                WriteAttributeValue("", 7563, "location.href=\'", 7563, 15, true);
#nullable restore
#line 132 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
WriteAttributeValue("", 7578, Url.Action("UserLogin", "Home"), 7578, 32, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 7610, "\'", 7610, 1, true);
                EndWriteAttribute();
                WriteLiteral(@"><a class=""nav-link active"" style=""color: #ffffff; letter-spacing: 1px; font-size: 13px; font-weight: 600;"" aria-current=""page"" href=""#"">Sign In</a></li>
                        <li class=""nav-item dropdown p-0 mx-2"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" style=""color: #ffffff; letter-spacing: 1px; font-size: 13px; font-weight: 600;"" id=""navbarDropdown"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                Category
                            </a>
                            <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
");
#nullable restore
#line 138 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                                 foreach (var category in Model.Item2)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li");
                BeginWriteAttribute("onclick", " onclick=\"", 8380, "\"", 8480, 3);
                WriteAttributeValue("", 8390, "location.href=\'", 8390, 15, true);
#nullable restore
#line 140 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
WriteAttributeValue("", 8405, Url.Action("SearchProduct", "Home", new { word = category.CategoryName }), 8405, 74, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8479, "\'", 8479, 1, true);
                EndWriteAttribute();
                WriteLiteral("><a class=\"dropdown-item\" href=\"#\">");
#nullable restore
#line 140 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                                                                                                                                                                          Write(category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n");
#nullable restore
#line 141 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </ul>\r\n                        </li>\r\n                        <li class=\"nav-item p-0 mx-2\"");
                BeginWriteAttribute("onclick", " onclick=\"", 8703, "\"", 8764, 5);
                WriteAttributeValue("", 8713, "location.href", 8713, 13, true);
                WriteAttributeValue(" ", 8726, "=", 8727, 2, true);
                WriteAttributeValue(" ", 8728, "\'", 8729, 2, true);
#nullable restore
#line 144 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
WriteAttributeValue("", 8730, Url.Action("AdminPanel", "Home"), 8730, 33, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 8763, "\'", 8763, 1, true);
                EndWriteAttribute();
                WriteLiteral("><a class=\"nav-link active\" style=\"color: #ffffff; letter-spacing: 1px; font-size: 13px; font-weight: 600;\" aria-current=\"page\" href=\"#\">Are you Admin?</a></li>\r\n                    </ul>\r\n\r\n");
#nullable restore
#line 147 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                     using (Html.BeginForm("Search", "Home", FormMethod.Post, new { @class = "d-flex mt-3 col-lg-5 position-relative" }))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 149 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <input class=""form-control m-0 input"" type=""search"" placeholder=""Search"" name=""word"">
                        <label class=""position-absolute top-0 end-0 label_cover"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-search-heart-fill"" viewBox=""0 0 16 16"">
                                <path d=""M6.5 13a6.474 6.474 0 0 0 3.845-1.258h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.008 1.008 0 0 0-.115-.1A6.471 6.471 0 0 0 13 6.5 6.502 6.502 0 0 0 6.5 0a6.5 6.5 0 1 0 0 13Zm0-8.518c1.664-1.673 5.825 1.254 0 5.018-5.825-3.764-1.664-6.69 0-5.018Z"" />
                            </svg>
                        </label>
");
#nullable restore
#line 156 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </nav>\r\n");
#nullable restore
#line 161 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral(@"        <nav class=""navbar navbar-expand-lg navbar-light bar p-0 fixed-top"">
            <div class=""container p-0"">
                <a class=""navbar-brand"" style=""color: #ffffff; letter-spacing: 1px; font-weight: 600; user-select: none; cursor: default;"" href=""#"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""40"" height=""40"" fill=""currentColor"" class=""bi bi-snow2"" viewBox=""0 0 16 16"">
                        <path d=""M8 16a.5.5 0 0 1-.5-.5v-1.293l-.646.647a.5.5 0 0 1-.707-.708L7.5 12.793v-1.086l-.646.647a.5.5 0 0 1-.707-.708L7.5 10.293V8.866l-1.236.713-.495 1.85a.5.5 0 1 1-.966-.26l.237-.882-.94.542-.496 1.85a.5.5 0 1 1-.966-.26l.237-.882-1.12.646a.5.5 0 0 1-.5-.866l1.12-.646-.884-.237a.5.5 0 1 1 .26-.966l1.848.495.94-.542-.882-.237a.5.5 0 1 1 .258-.966l1.85.495L7 8l-1.236-.713-1.849.495a.5.5 0 1 1-.258-.966l.883-.237-.94-.542-1.85.495a.5.5 0 0 1-.258-.966l.883-.237-1.12-.646a.5.5 0 1 1 .5-.866l1.12.646-.237-.883a.5.5 0 0 1 .966-.258l.495 1.849.94.542-.236-.883a.5.5 0 0 1 .966-.258l.");
                WriteLiteral(@"495 1.849 1.236.713V5.707L6.147 4.354a.5.5 0 1 1 .707-.708l.646.647V3.207L6.147 1.854a.5.5 0 1 1 .707-.708l.646.647V.5a.5.5 0 0 1 1 0v1.293l.647-.647a.5.5 0 1 1 .707.708L8.5 3.207v1.086l.647-.647a.5.5 0 1 1 .707.708L8.5 5.707v1.427l1.236-.713.495-1.85a.5.5 0 1 1 .966.26l-.236.882.94-.542.495-1.85a.5.5 0 1 1 .966.26l-.236.882 1.12-.646a.5.5 0 0 1 .5.866l-1.12.646.883.237a.5.5 0 1 1-.26.966l-1.848-.495-.94.542.883.237a.5.5 0 1 1-.26.966l-1.848-.495L9 8l1.236.713 1.849-.495a.5.5 0 0 1 .259.966l-.883.237.94.542 1.849-.495a.5.5 0 0 1 .259.966l-.883.237 1.12.646a.5.5 0 0 1-.5.866l-1.12-.646.236.883a.5.5 0 1 1-.966.258l-.495-1.849-.94-.542.236.883a.5.5 0 0 1-.966.258L9.736 9.58 8.5 8.866v1.427l1.354 1.353a.5.5 0 0 1-.707.708l-.647-.647v1.086l1.354 1.353a.5.5 0 0 1-.707.708l-.647-.647V15.5a.5.5 0 0 1-.5.5z"" />
                    </svg>&nbsp;Amazon
                </a>
                <button class=""navbar-toggler m-2"" type=""button"" data-bs-toggle=""collapse"" data-bs-target=""#navbarSupportedContent"" aria-controls=""");
                WriteLiteral(@"navbarSupportedContent"" aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <svg xmlns=""http://www.w3.org/2000/svg"" width=""34"" height=""34"" fill=""#ffffff"" class=""bi bi-strava"" viewBox=""0 0 16 16"">
                        <path d=""M6.731 0 2 9.125h2.788L6.73 5.497l1.93 3.628h2.766L6.731 0zm4.694 9.125-1.372 2.756L8.66 9.125H6.547L10.053 16l3.484-6.875h-2.112z"" />
                    </svg>
                </button>
                <div class=""collapse navbar-collapse"" id=""navbarSupportedContent"">
                    <ul class=""navbar-nav ms-auto m-0 mb-lg-0"">
                        <li class=""nav-item p-0 mx-2""");
                BeginWriteAttribute("onclick", " onclick=\"", 12723, "\"", 12778, 5);
                WriteAttributeValue("", 12733, "location.href", 12733, 13, true);
                WriteAttributeValue(" ", 12746, "=", 12747, 2, true);
                WriteAttributeValue(" ", 12748, "\'", 12749, 2, true);
#nullable restore
#line 178 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
WriteAttributeValue("", 12750, Url.Action("Site", "Home"), 12750, 27, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 12777, "\'", 12777, 1, true);
                EndWriteAttribute();
                WriteLiteral("><a class=\"nav-link active\" style=\"color: #ffffff; letter-spacing: 1px; font-size: 13px; font-weight: 600;\" aria-current=\"page\" href=\"#\">Home</a></li>\r\n                        <li class=\"nav-item p-0 mx-2\"");
                BeginWriteAttribute("onclick", " onclick=\"", 12984, "\"", 13044, 3);
                WriteAttributeValue("", 12994, "location.href=\'", 12994, 15, true);
#nullable restore
#line 179 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
WriteAttributeValue("", 13009, Url.Action("UserProfile", "Home"), 13009, 34, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 13043, "\'", 13043, 1, true);
                EndWriteAttribute();
                WriteLiteral("><a class=\"nav-link active\" style=\"color: #ffffff; letter-spacing: 1px; font-size: 13px; font-weight: 600;\" aria-current=\"page\" href=\"#\">My Profile</a></li>\r\n                        <li class=\"nav-item p-0 mx-2\"");
                BeginWriteAttribute("onclick", " onclick=\"", 13256, "\"", 13313, 3);
                WriteAttributeValue("", 13266, "location.href=\'", 13266, 15, true);
#nullable restore
#line 180 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
WriteAttributeValue("", 13281, Url.Action("UserCart", "Home"), 13281, 31, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 13312, "\'", 13312, 1, true);
                EndWriteAttribute();
                WriteLiteral(@" style=""border-bottom: 2px solid #ffffff;""><a class=""nav-link active"" style=""color: #ffffff; letter-spacing: 1px; font-size: 13px; font-weight: 600;"" aria-current=""page"" href=""#"">My Cart</a></li>
                        <li class=""nav-item dropdown p-0 mx-2"">
                            <a class=""nav-link dropdown-toggle"" href=""#"" style=""color: #ffffff; letter-spacing: 1px; font-size: 13px; font-weight: 600;"" id=""navbarDropdown"" role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                Category
                            </a>
                            <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
");
#nullable restore
#line 186 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                                 foreach (var category in Model.Item2)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li");
                BeginWriteAttribute("onclick", " onclick=\"", 14124, "\"", 14224, 3);
                WriteAttributeValue("", 14134, "location.href=\'", 14134, 15, true);
#nullable restore
#line 188 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
WriteAttributeValue("", 14149, Url.Action("SearchProduct", "Home", new { word = category.CategoryName }), 14149, 74, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 14223, "\'", 14223, 1, true);
                EndWriteAttribute();
                WriteLiteral("><a class=\"dropdown-item\" href=\"#\">");
#nullable restore
#line 188 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                                                                                                                                                                          Write(category.CategoryName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</a></li>\r\n");
#nullable restore
#line 189 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </ul>\r\n                        </li>\r\n                        <li class=\"nav-item p-0 mx-2\"");
                BeginWriteAttribute("onclick", " onclick=\"", 14447, "\"", 14504, 5);
                WriteAttributeValue("", 14457, "location.href", 14457, 13, true);
                WriteAttributeValue(" ", 14470, "=", 14471, 2, true);
                WriteAttributeValue(" ", 14472, "\'", 14473, 2, true);
#nullable restore
#line 192 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
WriteAttributeValue("", 14474, Url.Action("LogOut", "Home"), 14474, 29, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 14503, "\'", 14503, 1, true);
                EndWriteAttribute();
                WriteLiteral("><a class=\"nav-link active\" style=\"color: #ffffff; letter-spacing: 1px; font-size: 13px; font-weight: 600;\" aria-current=\"page\" href=\"#\">Sign Out</a></li>\r\n                    </ul>\r\n\r\n");
#nullable restore
#line 195 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                     using (Html.BeginForm("Search", "Home", FormMethod.Post, new { @class = "d-flex mt-3 col-lg-5 position-relative" }))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 197 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <input class=""form-control m-0 input"" type=""search"" placeholder=""Search"" name=""word"">
                        <label class=""position-absolute top-0 end-0 label_cover"">
                            <svg xmlns=""http://www.w3.org/2000/svg"" width=""16"" height=""16"" fill=""currentColor"" class=""bi bi-search-heart-fill"" viewBox=""0 0 16 16"">
                                <path d=""M6.5 13a6.474 6.474 0 0 0 3.845-1.258h-.001c.03.04.062.078.098.115l3.85 3.85a1 1 0 0 0 1.415-1.414l-3.85-3.85a1.008 1.008 0 0 0-.115-.1A6.471 6.471 0 0 0 13 6.5 6.502 6.502 0 0 0 6.5 0a6.5 6.5 0 1 0 0 13Zm0-8.518c1.664-1.673 5.825 1.254 0 5.018-5.825-3.764-1.664-6.69 0-5.018Z"" />
                            </svg>
                        </label>
");
#nullable restore
#line 204 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </nav>\r\n");
#nullable restore
#line 209 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"p-5\"></div>\r\n");
#nullable restore
#line 211 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
     foreach(var d in Model.Item1)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("<div class=\"card_cover row m-auto p-2 col-lg-8 position-relative\">\r\n    <div class=\"col-lg-8 m-0 p-0\">\r\n        <p class=\"p_tag\">Product: ");
#nullable restore
#line 215 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                             Write(d.product.ProductName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p class=\"p_tag\">Category: ");
#nullable restore
#line 216 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                              Write(d.product.ProductCategory);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p class=\"p_tag\">Company: ");
#nullable restore
#line 217 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                             Write(d.product.Company);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p class=\"p_tag\">Price: Rs ");
#nullable restore
#line 218 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                              Write(d.product.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p class=\"p_tag\">Quantity Ordered: ");
#nullable restore
#line 219 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                                      Write(d.cart.QuantityOrdered);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n        <p class=\"p_tag\">Net Price: Rs ");
#nullable restore
#line 220 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                                  Write(d.cart.NetPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    </div>\r\n    <div class=\"col-lg-4 m-0 p-0\">\r\n        <img");
                BeginWriteAttribute("src", " src=\"", 16367, "\"", 16405, 1);
#nullable restore
#line 223 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
WriteAttributeValue("", 16373, Url.Content(d.product.ImageUrl), 16373, 32, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"img-fluid image\" />\r\n    </div>\r\n    <div class=\"p-1\"></div>\r\n    <div class=\"card-footer d-flex flex-row align-items-center justify-content-between\" style=\"font-size: 12px; letter-spacing: 1px; color: #808080;\">\r\n        <div>Date & Time: ");
#nullable restore
#line 227 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                     Write(d.cart.DateTime);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n        <svg xmlns=\"http://www.w3.org/2000/svg\" width=\"20\" height=\"20\" fill=\"#808080a0\" class=\"bi bi-x-lg\" viewBox=\"0 0 16 16\" style=\"cursor: pointer;\"");
                BeginWriteAttribute("onclick", " onclick=\"", 16829, "\"", 16914, 3);
                WriteAttributeValue("", 16839, "location.href=\'", 16839, 15, true);
#nullable restore
#line 228 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
WriteAttributeValue("", 16854, Url.Action("CancelCart", "Home", new { CartId=d.cart.Id }), 16854, 59, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 16913, "\'", 16913, 1, true);
                EndWriteAttribute();
                WriteLiteral(@">
            <path fill-rule=""evenodd"" d=""M13.854 2.146a.5.5 0 0 1 0 .708l-11 11a.5.5 0 0 1-.708-.708l11-11a.5.5 0 0 1 .708 0Z"" />
            <path fill-rule=""evenodd"" d=""M2.146 2.146a.5.5 0 0 0 0 .708l11 11a.5.5 0 0 0 .708-.708l-11-11a.5.5 0 0 0-.708 0Z"" />
        </svg>
    </div>
");
#nullable restore
#line 233 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
     if (d.cart.Status.ToLower().Equals("not delivered"))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"position-absolute top-0 end-0 col-lg-4 p-2 d-flex flex-row align-items-center justify-content-around\" style=\"background: #191970d0; color: #ffffff; font-size: 12px; letter-spacing: 1px;\">");
#nullable restore
#line 235 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                                                                                                                                                                                                          Write(d.cart.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 236 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"position-absolute top-0 end-0 col-lg-4 p-2 d-flex flex-row align-items-center justify-content-around\" style=\"background: #c71585d0; color: #ffffff; font-size: 12px; letter-spacing: 1px;\">");
#nullable restore
#line 239 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
                                                                                                                                                                                                          Write(d.cart.Status);

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n");
#nullable restore
#line 240 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("</div>\r\n                <div class=\"p-2\"></div>\r\n");
#nullable restore
#line 243 "C:\Users\2048766\AngularWebsites\FlipKart_2\Amazon_\Amazon_\Views\Home\UserCart.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

    <footer style=""width: 100%; height: 40vh; background: #6495edd0;"" class=""d-flex flex-column justify-content-end"">
        <div class=""p-4 text-center"">
            <svg xmlns=""http://www.w3.org/2000/svg"" width=""80"" height=""80"" fill=""#ffffff"" class=""bi bi-snow2"" viewBox=""0 0 16 16"">
                <path d=""M8 16a.5.5 0 0 1-.5-.5v-1.293l-.646.647a.5.5 0 0 1-.707-.708L7.5 12.793v-1.086l-.646.647a.5.5 0 0 1-.707-.708L7.5 10.293V8.866l-1.236.713-.495 1.85a.5.5 0 1 1-.966-.26l.237-.882-.94.542-.496 1.85a.5.5 0 1 1-.966-.26l.237-.882-1.12.646a.5.5 0 0 1-.5-.866l1.12-.646-.884-.237a.5.5 0 1 1 .26-.966l1.848.495.94-.542-.882-.237a.5.5 0 1 1 .258-.966l1.85.495L7 8l-1.236-.713-1.849.495a.5.5 0 1 1-.258-.966l.883-.237-.94-.542-1.85.495a.5.5 0 0 1-.258-.966l.883-.237-1.12-.646a.5.5 0 1 1 .5-.866l1.12.646-.237-.883a.5.5 0 0 1 .966-.258l.495 1.849.94.542-.236-.883a.5.5 0 0 1 .966-.258l.495 1.849 1.236.713V5.707L6.147 4.354a.5.5 0 1 1 .707-.708l.646.647V3.207L6.147 1.854a.5.5 0 1 1 .707-.708l.646.647V.5a.5.5 0 0 ");
                WriteLiteral(@"1 1 0v1.293l.647-.647a.5.5 0 1 1 .707.708L8.5 3.207v1.086l.647-.647a.5.5 0 1 1 .707.708L8.5 5.707v1.427l1.236-.713.495-1.85a.5.5 0 1 1 .966.26l-.236.882.94-.542.495-1.85a.5.5 0 1 1 .966.26l-.236.882 1.12-.646a.5.5 0 0 1 .5.866l-1.12.646.883.237a.5.5 0 1 1-.26.966l-1.848-.495-.94.542.883.237a.5.5 0 1 1-.26.966l-1.848-.495L9 8l1.236.713 1.849-.495a.5.5 0 0 1 .259.966l-.883.237.94.542 1.849-.495a.5.5 0 0 1 .259.966l-.883.237 1.12.646a.5.5 0 0 1-.5.866l-1.12-.646.236.883a.5.5 0 1 1-.966.258l-.495-1.849-.94-.542.236.883a.5.5 0 0 1-.966.258L9.736 9.58 8.5 8.866v1.427l1.354 1.353a.5.5 0 0 1-.707.708l-.647-.647v1.086l1.354 1.353a.5.5 0 0 1-.707.708l-.647-.647V15.5a.5.5 0 0 1-.5.5z"" />
            </svg>
        </div>
        <div class=""p-2""></div>
        <section style=""width: 100%; height: 10vh; background: #6495edd0; display: flex; align-items: center; justify-content: space-around; color: #ffffff; letter-spacing: 1px; font-size: 13px; line-height: 24px; font-weight: 600;"">
            Cognizant Technology ");
                WriteLiteral("Solution India Private Limited\r\n        </section>\r\n    </footer>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<List<Amazon_.Models.CartDetail>, List<Amazon_.Models.Category>>> Html { get; private set; }
    }
}
#pragma warning restore 1591