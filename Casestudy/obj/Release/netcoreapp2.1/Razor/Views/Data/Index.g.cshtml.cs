#pragma checksum "\\Mac\Home\Desktop\Casestudy\Casestudy\Views\Data\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "67e2bb211c74a0f9275f8e1e82acc8187d6ebd6e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Data_Index), @"mvc.1.0.view", @"/Views/Data/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Data/Index.cshtml", typeof(AspNetCore.Views_Data_Index))]
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
#line 1 "\\Mac\Home\Desktop\Casestudy\Casestudy\Views\_ViewImports.cshtml"
using Casestudy;

#line default
#line hidden
#line 2 "\\Mac\Home\Desktop\Casestudy\Casestudy\Views\_ViewImports.cshtml"
using Casestudy.Models;

#line default
#line hidden
#line 3 "\\Mac\Home\Desktop\Casestudy\Casestudy\Views\_ViewImports.cshtml"
using Casestudy.Utils;

#line default
#line hidden
#line 4 "\\Mac\Home\Desktop\Casestudy\Casestudy\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#line 5 "\\Mac\Home\Desktop\Casestudy\Casestudy\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67e2bb211c74a0f9275f8e1e82acc8187d6ebd6e", @"/Views/Data/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac70a976d3203dfcf91f60a6a4b5fc18ad0cc3fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Data_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "\\Mac\Home\Desktop\Casestudy\Casestudy\Views\Data\Index.cshtml"
  
    ViewData["Title"] = "Data Results Page";

#line default
#line hidden
            BeginContext(53, 97, true);
            WriteLiteral("<div class=\"text-center\">\r\n    <h3>Data Utilities</h3>\r\n    <div class=\"m-4\" id=\"busy\">\r\n        ");
            EndContext();
            BeginContext(151, 17, false);
#line 7 "\\Mac\Home\Desktop\Casestudy\Casestudy\Views\Data\Index.cshtml"
   Write(ViewBag.LoadedMsg);

#line default
#line hidden
            EndContext();
            BeginContext(168, 311, true);
            WriteLiteral(@"
    </div>
    <div class=""col-2 mb-1"">
        <button id=""jsondatartns"" class=""btn btn-outline-dark"" style=""width:150px;"">Menu Json</button>
    </div>
    <div class=""col-2 mb-5"">
        <button id=""csvdatartns"" class=""btn btn-outline-dark"" style=""width:150px;"">Store CSV</button>
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
