#pragma checksum "C:\Users\Aranel\source\repos\MOVIEAPP\MOVIEAPP\Views\Admin\register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "970087b0097316522b8b8f1a1af8eb7a83ff74a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_register), @"mvc.1.0.view", @"/Views/Admin/register.cshtml")]
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
#line 1 "C:\Users\Aranel\source\repos\MOVIEAPP\MOVIEAPP\Views\_ViewImports.cshtml"
using MOVIEAPP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Aranel\source\repos\MOVIEAPP\MOVIEAPP\Views\_ViewImports.cshtml"
using MOVIEAPP.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970087b0097316522b8b8f1a1af8eb7a83ff74a8", @"/Views/Admin/register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7a68f52291901494e0bfe6b47c46001a76b5a5fc", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/adminpanel/admin/dist/styles.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("max-w-xl m-4 p-10 bg-white rounded shadow-xl"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("h-screen font-sans login bg-cover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Aranel\source\repos\MOVIEAPP\MOVIEAPP\Views\Admin\register.cshtml"
   Layout = null; 

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "970087b0097316522b8b8f1a1af8eb7a83ff74a85374", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "970087b0097316522b8b8f1a1af8eb7a83ff74a85766", async() => {
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
    <link rel=""stylesheet"" href=""https://use.fontawesome.com/releases/v5.0.13/css/all.css"" integrity=""sha384-DNOHZ68U8hZfKXOrtjWvjxusGo9WQnrNx2sqG0tfsghAvtVlRW3tvkXWZh58N9jp""
          crossorigin=""anonymous"">
    <style>
        .login {
            background: url('~/adminpanel/admin/dist/images/login-new.jpeg')
        }
    </style>
    <title>Register</title>
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "970087b0097316522b8b8f1a1af8eb7a83ff74a88031", async() => {
                WriteLiteral("\r\n    <div class=\"container mx-auto h-full flex flex-1 justify-center items-center\">\r\n        <div class=\"w-full max-w-lg\">\r\n            <div class=\"leading-loose\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "970087b0097316522b8b8f1a1af8eb7a83ff74a88481", async() => {
                    WriteLiteral("\r\n                    <p class=\"text-gray-800 font-medium\">Register</p>\r\n                    <div");
                    BeginWriteAttribute("class", " class=\"", 1027, "\"", 1035, 0);
                    EndWriteAttribute();
                    WriteLiteral(">\r\n                        <label class=\"block text-sm text-gray-00\" for=\"cus_name\">Name</label>\r\n                        <input class=\"w-full px-5 py-1 text-gray-700 bg-gray-200 rounded\" id=\"cus_name\" name=\"cus_name\" type=\"text\"");
                    BeginWriteAttribute("required", " required=\"", 1265, "\"", 1276, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" placeholder=""Your Name"" aria-label=""Name"">
                    </div>
                    <div class=""mt-2"">
                        <label class=""block text-sm text-gray-600"" for=""cus_email"">Email</label>
                        <input class=""w-full px-5  py-4 text-gray-700 bg-gray-200 rounded"" id=""cus_email"" name=""cus_email"" type=""text""");
                    BeginWriteAttribute("required", " required=\"", 1622, "\"", 1633, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" placeholder=""Your Email"" aria-label=""Email"">
                    </div>
                    <div class=""mt-2"">
                        <label class="" block text-sm text-gray-600"" for=""cus_email"">Address</label>
                        <input class=""w-full px-2 py-2 text-gray-700 bg-gray-200 rounded"" id=""cus_email"" name=""cus_email"" type=""text""");
                    BeginWriteAttribute("required", " required=\"", 1983, "\"", 1994, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" placeholder=""Street"" aria-label=""Email"">
                    </div>
                    <div class=""mt-2"">
                        <label class=""hidden text-sm block text-gray-600"" for=""cus_email"">City</label>
                        <input class=""w-full px-2 py-2 text-gray-700 bg-gray-200 rounded"" id=""cus_email"" name=""cus_email"" type=""text""");
                    BeginWriteAttribute("required", " required=\"", 2343, "\"", 2354, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" placeholder=""City"" aria-label=""Email"">
                    </div>
                    <div class=""inline-block mt-2 w-1/2 pr-1"">
                        <label class=""hidden block text-sm text-gray-600"" for=""cus_email"">Country</label>
                        <input class=""w-full px-2 py-2 text-gray-700 bg-gray-200 rounded"" id=""cus_email"" name=""cus_email"" type=""text""");
                    BeginWriteAttribute("required", " required=\"", 2728, "\"", 2739, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" placeholder=""Country"" aria-label=""Email"">
                    </div>
                    <div class=""inline-block mt-2 -mx-1 pl-1 w-1/2"">
                        <label class=""hidden block text-sm text-gray-600"" for=""cus_email"">Zip</label>
                        <input class=""w-full px-2 py-2 text-gray-700 bg-gray-200 rounded"" id=""cus_email"" name=""cus_email"" type=""text""");
                    BeginWriteAttribute("required", " required=\"", 3118, "\"", 3129, 0);
                    EndWriteAttribute();
                    WriteLiteral(@" placeholder=""Zip"" aria-label=""Email"">
                    </div>

                    <div class=""mt-4"">
                        <button class=""px-4 py-1 text-white font-light tracking-wider bg-gray-900 rounded"" type=""submit"">Register</button>
                    </div>
                    <a class=""inline-block right-0 align-baseline font-bold text-sm text-500 hover:text-blue-800"" href=""login.html"">
                        Already have an account ?
                    </a>
                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
