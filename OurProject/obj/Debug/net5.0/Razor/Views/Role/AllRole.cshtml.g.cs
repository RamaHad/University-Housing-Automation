#pragma checksum "C:\Users\العبه جي\Desktop\projects\MyFirstProject\OurProject\Views\Role\AllRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c2e6264bf8d8fbe00a7344b9aa9a2dfa2f5341d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Role_AllRole), @"mvc.1.0.view", @"/Views/Role/AllRole.cshtml")]
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
#line 1 "C:\Users\العبه جي\Desktop\projects\MyFirstProject\OurProject\Views\_ViewImports.cshtml"
using OurProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\العبه جي\Desktop\projects\MyFirstProject\OurProject\Views\_ViewImports.cshtml"
using OurProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c2e6264bf8d8fbe00a7344b9aa9a2dfa2f5341d6", @"/Views/Role/AllRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"193bc447c39a388d333e62c588de4d76e5bb95fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Role_AllRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<OurProject.Dto.RoleDto.GetAllRoleDto>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n\r\n");
            WriteLiteral("<table class=\"table\">\r\n   \r\n");
#nullable restore
#line 13 "C:\Users\العبه جي\Desktop\projects\MyFirstProject\OurProject\Views\Role\AllRole.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\العبه جي\Desktop\projects\MyFirstProject\OurProject\Views\Role\AllRole.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\العبه جي\Desktop\projects\MyFirstProject\OurProject\Views\Role\AllRole.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 19 "C:\Users\العبه جي\Desktop\projects\MyFirstProject\OurProject\Views\Role\AllRole.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<OurProject.Dto.RoleDto.GetAllRoleDto>> Html { get; private set; }
    }
}
#pragma warning restore 1591