#pragma checksum "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Departments\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad8fab5010b0766e8715b2fa5cea6266dbc28721"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departments_Index), @"mvc.1.0.view", @"/Views/Departments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Departments/Index.cshtml", typeof(AspNetCore.Views_Departments_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad8fab5010b0766e8715b2fa5cea6266dbc28721", @"/Views/Departments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d47f65a20e6f844f53af1deef077b39ebd34325", @"/Views/_ViewImports.cshtml")]
    public class Views_Departments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CoreDepartment.Models.Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Departments\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Sidebar.cshtml";

#line default
#line hidden
            BeginContext(136, 217, true);
            WriteLiteral("\r\n<br />\r\n\r\n<table class=\"table table-bordered\">\r\n\r\n    <tr class=\"bg-info\">\r\n        <th>ID</th>\r\n        <th>Department</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n        <th>Details</th>\r\n    </tr>\r\n\r\n");
            EndContext();
#line 19 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Departments\Index.cshtml"
     foreach(var x in Model)
    {

#line default
#line hidden
            BeginContext(390, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(421, 4, false);
#line 22 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Departments\Index.cshtml"
           Write(x.ID);

#line default
#line hidden
            EndContext();
            BeginContext(425, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(449, 16, false);
#line 23 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Departments\Index.cshtml"
           Write(x.DepartmentName);

#line default
#line hidden
            EndContext();
            BeginContext(465, 25, true);
            WriteLiteral("</td>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 490, "\"", 532, 2);
            WriteAttributeValue("", 497, "/Departments/DeleteDepartment/", 497, 30, true);
#line 24 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Departments\Index.cshtml"
WriteAttributeValue("", 527, x.ID, 527, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(533, 59, true);
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 592, "\"", 631, 2);
            WriteAttributeValue("", 599, "/Departments/GetDepartment/", 599, 27, true);
#line 25 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Departments\Index.cshtml"
WriteAttributeValue("", 626, x.ID, 626, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(632, 161, true);
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n            <td><a href=\"#\" class=\"btn btn-default\" style=\"background-color:aqua\">Details</a></td>\r\n\r\n\r\n        </tr>\r\n");
            EndContext();
#line 30 "C:\Users\Mahmut\source\repos\CoreDepartment\CoreDepartment\Views\Departments\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(800, 98, true);
            WriteLiteral("\r\n</table>\r\n<a href=\"/Departments/NewDepartment/\" class=\"btn btn-primary\">Add New Department</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CoreDepartment.Models.Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591
