#pragma checksum "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Trip\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cc057e740a7bc35cf77c5573b45a4a5cbf9669ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Trip_Details), @"mvc.1.0.view", @"/Views/Trip/Details.cshtml")]
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
#line 1 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\_ViewImports.cshtml"
using BusReservation.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\_ViewImports.cshtml"
using BusReservation.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\_ViewImports.cshtml"
using BusReservation.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\_ViewImports.cshtml"
using BusReservation.WebUI.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc057e740a7bc35cf77c5573b45a4a5cbf9669ab", @"/Views/Trip/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2ce4aa023477b591c40aed568c16a78555b7a62", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Trip_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ticket>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/trip/details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Trip\Details.cshtml"
   var Price = Model.Price; 

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Trip\Details.cshtml"
 if (ViewBag.Sayi < 5)
{
    Price = Price;
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Trip\Details.cshtml"
 if (ViewBag.Number > 10 && ViewBag.Number <= 15)
{
    Price = Price + Price*0.05;
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Trip\Details.cshtml"
 if (ViewBag.Sayi > 15 && ViewBag.Sayi <= 20)
{
    Price = Price + Price * 0.10;
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Trip\Details.cshtml"
 if (ViewBag.Sayi > 20 && ViewBag.Sayi <= 30)
{
    Price = Price + Price * 0.20;
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Trip\Details.cshtml"
 if (ViewBag.Sayi > 30)
{
    Price = Price + Price * 0.30;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n");
#nullable restore
#line 29 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Trip\Details.cshtml"
   var Price1 = @Price * 0.8;
    var Price2 = @Price * 0.7;
    var Price3 = @Price * 0.6;
    var Price4 = @Price * 0.5;
    var Price5 = @Price * 0.45;

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"card mb-3 shadow\">\r\n\r\n    <div class=\"card-title pl-3 pt-3\">\r\n");
            WriteLiteral("    </div>\r\n    <div class=\"card-body\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc057e740a7bc35cf77c5573b45a4a5cbf9669ab7588", async() => {
                WriteLiteral("\r\n            <div class=\"row no-gutters\">\r\n                <div class=\"col-md-8\">\r\n");
                WriteLiteral(@"


                </div>

                <div class=""row no-gutters"">

                    <div class=""col-md-12"">
                        <br /><br /><hr /><br />
                        <div class=""form-group"">
                            <input type=""email"" name=""email"" class=""form-control"" id=""exampleInputEmail1"" aria-describedby=""emailHelp"" placeholder=""E-Mail"" required=""required"" style=""width: 1000px; margin-left: 30px;"">
                        </div>
                        <div class=""form-group"">
                            <input type=""text"" name=""name"" class=""form-control""");
                BeginWriteAttribute("id", " id=\"", 2647, "\"", 2652, 0);
                EndWriteAttribute();
                BeginWriteAttribute("aria-describedby", " aria-describedby=\"", 2653, "\"", 2672, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"İsim\" required=\"required\" style=\"width: 1000px; margin-left: 30px;\">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n                            <input type=\"text\" name=\"surname\" class=\"form-control\"");
                BeginWriteAttribute("id", " id=\"", 2921, "\"", 2926, 0);
                EndWriteAttribute();
                BeginWriteAttribute("aria-describedby", " aria-describedby=\"", 2927, "\"", 2946, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Soyisim\" required=\"required\" style=\"width: 1000px;margin-left: 30px;\">\r\n                        </div>\r\n                        <div class=\"form-group\">\r\n");
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cc057e740a7bc35cf77c5573b45a4a5cbf9669ab9703", async() => {
                    WriteLiteral("Select a Seat");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("disabled", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                            </select>
                        </div>
                    </div>
                    <button type=""submit"" class=""btn btn-danger btn-lg"" style=""color: white;margin-left: 38px;"">Buy Ticket</button>
                    <br />
                </div><br />
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
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
            WriteLiteral("\r\n    </div><br />\r\n\r\n</div>\r\n<br />");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ticket> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591