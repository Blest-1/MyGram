#pragma checksum "/Users/blest/Desktop/Projects/Instagram/Views/Home/UserProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b26470f1831c02121d38410549aacfe59d9f7073"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_UserProfile), @"mvc.1.0.view", @"/Views/Home/UserProfile.cshtml")]
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
#line 1 "/Users/blest/Desktop/Projects/Instagram/Views/_ViewImports.cshtml"
using InstaSlam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/blest/Desktop/Projects/Instagram/Views/_ViewImports.cshtml"
using InstaSlam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b26470f1831c02121d38410549aacfe59d9f7073", @"/Views/Home/UserProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"be8f36ca1116e41274d4479eaeded26939b54513", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_UserProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/blest/Desktop/Projects/Instagram/Views/Home/UserProfile.cshtml"
   ViewData["Title"] = "My Gram"; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b26470f1831c02121d38410549aacfe59d9f70733415", async() => {
                WriteLiteral(@"
    <fieldset>
        <ledgend>User personal information</ledgend>
    <table>
        <tbody>
            <tr>
                <td>
                    <label for=""FirstName"">First Name:</label>
                    <input type=""text"" placeholder=""Add your First Name"" id=""FirstName"" />

                    <label for=""LastName"">Last Name:</label>
                    <input type=""text"" placeholder=""Add your Last Name"" id=""LastName"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>Gender:</label>
                    <input type=""radio"" id=""MaleGender"" name=""gender"" />
                    <label for=""MaleGender"">Male</label>

                    <input type=""radio"" id=""FemaleGender"" name=""gender"" />
                    <label for=""FemaleGender"">Female</label>

                    <input type=""radio"" id=""NoResponseGender"" name=""gender"" />
                    <label for=""NoResponseGender"">Prefer not to respond</label>
                </td>
              ");
                WriteLiteral(@"</tr>
           </tbody>
         </table>
        <table>
            <tbody>
            <tr>
                <td>
                    <label>Select your favorite color:</label>
                    <input type=""color"" id=""FavoriteColor"" />
                </td>
                <td>
                    <label for=""Birthday"">Birthday:</label>
                    <input type=""date"" id=""Birthday"" />
                </td>
            </tr>
                </tbody>
            </table>
        <table>
            <tbody>
            <tr>
                <td>
                    <label for=""EmailAddress"">Email Address:</label>
                    <input type=""text"" placeholder=""Add your Email Address"" size=""55"" id=""EmailAddress"" />
                </td>
            </tr>
            <tr>
                <td>
                    <label>Country Of Residence:</label>
                    <select>
                        <optgroup label=""Country Of Residence"">
                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b26470f1831c02121d38410549aacfe59d9f70735783", async() => {
                    WriteLiteral("USA");
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
                WriteLiteral(@"
                        </optgroup>
                    </select>
                </td>
            <tr>
                <td>
                    <label>Select profile image:</label>
                    <input type=""file"" id=""ChooseFiles"" />
                </td>
            <tr>
                <td>
                   <button>Update User Information</button>
                </td>
            </tr>
        </tbody>
    </table>
        </fieldset>
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
