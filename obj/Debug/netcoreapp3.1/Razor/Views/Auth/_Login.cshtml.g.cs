#pragma checksum "D:\Faridun's Projects\Faridun's\Back-End\ASP\PartialView\Views\Auth\_Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7bb81e9a324a7778e43448674da282fc3c4072e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Auth__Login), @"mvc.1.0.view", @"/Views/Auth/_Login.cshtml")]
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
#line 1 "D:\Faridun's Projects\Faridun's\Back-End\ASP\PartialView\Views\_ViewImports.cshtml"
using PartialView;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Faridun's Projects\Faridun's\Back-End\ASP\PartialView\Views\_ViewImports.cshtml"
using PartialView.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7bb81e9a324a7778e43448674da282fc3c4072e", @"/Views/Auth/_Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a7447ae80986a5cd61172c7f6e8f771eaf552cff", @"/Views/_ViewImports.cshtml")]
    public class Views_Auth__Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PartialView.Models.Login>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("  \r\n<section id=\"loginForm\">  \r\n");
#nullable restore
#line 4 "D:\Faridun's Projects\Faridun's\Back-End\ASP\PartialView\Views\Auth\_Login.cshtml"
     using (Html.BeginForm("Login", "Auth", FormMethod.Post))  
    {  
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Faridun's Projects\Faridun's\Back-End\ASP\PartialView\Views\Auth\_Login.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("        <h4>Use a local account to log in.</h4>  \r\n        <hr />  \r\n        <div class=\"form-group\">  \r\n            ");
#nullable restore
#line 10 "D:\Faridun's Projects\Faridun's\Back-End\ASP\PartialView\Views\Auth\_Login.cshtml"
       Write(Html.LabelFor(m => m.Email, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n            <div class=\"col-md-10\">  \r\n                ");
#nullable restore
#line 12 "D:\Faridun's Projects\Faridun's\Back-End\ASP\PartialView\Views\Auth\_Login.cshtml"
           Write(Html.TextBoxFor(m => m.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n            </div>  \r\n        </div>  \r\n        <div class=\"form-group\">  \r\n            ");
#nullable restore
#line 16 "D:\Faridun's Projects\Faridun's\Back-End\ASP\PartialView\Views\Auth\_Login.cshtml"
       Write(Html.LabelFor(m => m.Password, new { @class = "col-md-2 control-label" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n            <div class=\"col-md-10\">  \r\n                ");
#nullable restore
#line 18 "D:\Faridun's Projects\Faridun's\Back-End\ASP\PartialView\Views\Auth\_Login.cshtml"
           Write(Html.PasswordFor(m => m.Password, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  \r\n                ");
#nullable restore
#line 19 "D:\Faridun's Projects\Faridun's\Back-End\ASP\PartialView\Views\Auth\_Login.cshtml"
           Write(Html.ValidationMessageFor(m => m.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  
            </div>  
        </div>  
        <div class=""form-group"">  
            <div class=""col-md-offset-2 col-md-10"">  
                <input type=""submit"" value=""Log in"" class=""btn btn-default"" />  
            </div>  
        </div>          
");
#nullable restore
#line 27 "D:\Faridun's Projects\Faridun's\Back-End\ASP\PartialView\Views\Auth\_Login.cshtml"
    }  

#line default
#line hidden
#nullable disable
            WriteLiteral("</section>  ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PartialView.Models.Login> Html { get; private set; }
    }
}
#pragma warning restore 1591
