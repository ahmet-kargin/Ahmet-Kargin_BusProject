#pragma checksum "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c0beda4cd9cca604fe46014142ff17b55cba552"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_RoleEdit), @"mvc.1.0.view", @"/Views/Admin/RoleEdit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c0beda4cd9cca604fe46014142ff17b55cba552", @"/Views/Admin/RoleEdit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2ce4aa023477b591c40aed568c16a78555b7a62", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_RoleEdit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleDetails>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RoleEdit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h5 class=\"display-4\">Edit Role</h5>\r\n<hr />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c0beda4cd9cca604fe46014142ff17b55cba5525245", async() => {
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"RoleId\"");
                BeginWriteAttribute("value", " value=\"", 171, "\"", 193, 1);
#nullable restore
#line 5 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 179, Model.Role.Id, 179, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <input type=\"hidden\" name=\"RoleName\"");
                BeginWriteAttribute("value", " value=\"", 239, "\"", 263, 1);
#nullable restore
#line 6 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 247, Model.Role.Name, 247, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n    <div class=\"row\">\r\n        <div class=\"col-md-6\">\r\n            <h6 class=\"bg-info text-white p-1\">Add to ");
#nullable restore
#line 9 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
                                                 Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n            <table class=\"table table-sm table-bordered\">\r\n");
#nullable restore
#line 11 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
                 if (Model.NonMembers.Count() == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td colspan=\"2\">All users belong to this role!</td>\r\n                    </tr>\r\n");
#nullable restore
#line 16 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
                     foreach (var user in Model.NonMembers)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 22 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
                           Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>\r\n                                <input type=\"checkbox\" name=\"IdsToAdd\"");
                BeginWriteAttribute("value", " value=\"", 993, "\"", 1009, 1);
#nullable restore
#line 24 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 1001, user.Id, 1001, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 27 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n\r\n            <button type=\"submit\" class=\"btn btn-primary\">Save Changes</button>\r\n\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <h6 class=\"bg-info text-white p-1\">Remove from ");
#nullable restore
#line 35 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
                                                      Write(Model.Role.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h6>\r\n            <table class=\"table table-sm table-bordered\">\r\n");
#nullable restore
#line 37 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
                 if (Model.Members.Count() == 0)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n                        <td colspan=\"2\">There are no users for this role!</td>\r\n                    </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
                }
                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
                     foreach (var user in Model.Members)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 48 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
                           Write(user.UserName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                            <td>\r\n                                <input type=\"checkbox\" name=\"IdsToDelete\"");
                BeginWriteAttribute("value", " value=\"", 1952, "\"", 1968, 1);
#nullable restore
#line 50 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
WriteAttributeValue("", 1960, user.Id, 1960, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 53 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "C:\Users\Wissen\Desktop\Web7\Ahmet-Kargin\BusReservation_Project\BusReservation.WebUI\Views\Admin\RoleEdit.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n\r\n        </div>\r\n    </div>\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleDetails> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
