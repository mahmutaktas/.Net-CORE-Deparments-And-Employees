#pragma checksum "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Employees\NewEmployee.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1cd931671b3ef048ebedb7de20cf680ec7fdc512"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_NewEmployee), @"mvc.1.0.view", @"/Views/Employees/NewEmployee.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employees/NewEmployee.cshtml", typeof(AspNetCore.Views_Employees_NewEmployee))]
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
#line 1 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\_ViewImports.cshtml"
using CoreDepartment;

#line default
#line hidden
#line 2 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\_ViewImports.cshtml"
using CoreDepartment.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1cd931671b3ef048ebedb7de20cf680ec7fdc512", @"/Views/Employees/NewEmployee.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d47f65a20e6f844f53af1deef077b39ebd34325", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_NewEmployee : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreDepartment.Models.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
#line 2 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Employees\NewEmployee.cshtml"
  
    ViewData["Title"] = "NewDepartment";
    Layout = "~/Views/Shared/_Sidebar.cshtml";

#line default
#line hidden
            BeginContext(136, 10, true);
            WriteLiteral("\r\n<br />\r\n");
            EndContext();
            BeginContext(146, 604, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a834174d084b44928536c55216e36973", async() => {
                BeginContext(185, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(194, 29, false);
#line 10 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Employees\NewEmployee.cshtml"
Write(Html.LabelFor(x => x.EmpName));

#line default
#line hidden
                EndContext();
                BeginContext(223, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(230, 64, false);
#line 11 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Employees\NewEmployee.cshtml"
Write(Html.TextBoxFor(x => x.EmpName, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(294, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(303, 33, false);
#line 13 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Employees\NewEmployee.cshtml"
Write(Html.LabelFor(x => x.EmpLastname));

#line default
#line hidden
                EndContext();
                BeginContext(336, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(343, 68, false);
#line 14 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Employees\NewEmployee.cshtml"
Write(Html.TextBoxFor(x => x.EmpLastname, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(411, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(420, 29, false);
#line 16 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Employees\NewEmployee.cshtml"
Write(Html.LabelFor(x => x.EmpCity));

#line default
#line hidden
                EndContext();
                BeginContext(449, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(456, 64, false);
#line 17 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Employees\NewEmployee.cshtml"
Write(Html.TextBoxFor(x => x.EmpCity, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(520, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(529, 28, false);
#line 19 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Employees\NewEmployee.cshtml"
Write(Html.LabelFor(x => x.depart));

#line default
#line hidden
                EndContext();
                BeginContext(557, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(564, 114, false);
#line 20 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Employees\NewEmployee.cshtml"
Write(Html.DropDownListFor(x => x.depart.ID, (List<SelectListItem>) ViewBag.departList, new { @class = "form-control" }));

#line default
#line hidden
                EndContext();
                BeginContext(678, 65, true);
                WriteLiteral("\r\n\r\n    <br />\r\n    <button class=\"btn btn-info\">Add</button>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(750, 2, true);
            WriteLiteral("\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreDepartment.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
