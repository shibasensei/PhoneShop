#pragma checksum "\\Mac\Home\Desktop\Casestudy\Casestudy\Views\Tray\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5be86a87aebe27eb54b8e69888a081e604169c98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Tray_List), @"mvc.1.0.view", @"/Views/Tray/List.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Tray/List.cshtml", typeof(AspNetCore.Views_Tray_List))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5be86a87aebe27eb54b8e69888a081e604169c98", @"/Views/Tray/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac70a976d3203dfcf91f60a6a4b5fc18ad0cc3fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Tray_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/vuemodal.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/traylist.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "\\Mac\Home\Desktop\Casestudy\Casestudy\Views\Tray\List.cshtml"
  
    ViewData["Title"] = "List";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(87, 135, true);
            WriteLiteral("<!-- development version, includes helpful console warnings -->\r\n<script src=\"https://cdn.jsdelivr.net/npm/vue/dist/vue.js\"></script>\r\n");
            EndContext();
            BeginContext(222, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "671be036d8e04c81b72a94bf7b1263ac", async() => {
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
            EndContext();
            BeginContext(273, 1083, true);
            WriteLiteral(@"
<div id=""trays"">
    <div class=""mt-5"">
        <div class=""card"">
            <div class=""card-title text-center mt-3"">
                <h3>Trays You've Ordered</h3>
            </div>
            <div class=""card-body"">
                <table class=""table table-bordered table-striped"">
                    <thead>
                        <tr>
                            <td class=""text-left"">Id</td>
                            <th class=""text-center"">Date</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr href=""#"" v-for=""tray in trays"" v-on:click=""trayForModal=tray;loadAndShowModal();"">
                            <td>{{tray.id}}</td>
                            <td class=""text-center"">{{formatDate(tray.dateCreated)}}</td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
    <modal v-if=""showModal"" v-on:close=""showModal = false"" :tray=""");
            WriteLiteral("trayForModal\" :details=\"detailsForModal\"></modal>\r\n</div>\r\n");
            EndContext();
            BeginContext(1356, 40, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "abef1babcc964dc49097d812f9b38883", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1396, 3061, true);
            WriteLiteral(@"
<!-- template for the modal component -->
<script type=""text/x-template"" id=""modal-template"">
    <transition name=""modal"">
        <div class=""modal-mask"">
            <div class=""modal-wrapper"">
                <div class=""modal-container"">
                    <button type=""button"" class=""close"" style=""font-size:xx-large;"" v-on:click=""$emit('close')"">
                        X
                    </button>
                    <div class=""text-center"" style=""font-size:larger;"">
                        <h3>Tray:{{tray.id}}</h3>
                        {{formatDate(tray.dateCreated)}}<p></p>
                        <img src=""../images/Tray.png"" style=""height:60px;width:60px;margin:10px;"" />
                        <ul class=""list-group vuerow"">
                            <li class=""list-group-item vuerow"" style=""background-color:lightgray;"">
                                <span class=""vuecol20 text-center"">Name</span>
                                <span class=""vuecol20"">MSRP</span>
     ");
            WriteLiteral(@"                           <span class=""vuecol20"">Qty S</span>
                                <span class=""vuecol20"">Qty O</span>
                                <span class=""vuecol20"">Qty B</span>
                                <span class=""vuecol20"">Extended</span>
                            </li>
                            <li v-for=""detail in details"" class=""list-group-item vuerow"">
                                <span class=""vuecol20 text-center"">{{detail.description}}</span>
                                <span class=""vuecol20 text-center"">{{detail.price | toCurrency}}</span>
                                <span class=""vuecol20 text-center"">{{detail.qtyS}}</span>
                                <span class=""vuecol20 text-center"">{{detail.qtyO}}</span>
                                <span class=""vuecol20 text-center"">{{detail.qtyB}}</span>
                                <span class=""vuecol20 text-center"">{{detail.totalOne | toCurrency}}</span>
                            </li>
     ");
            WriteLiteral(@"                   </ul>
                        <div v-if=""details[0]"" class=""text-right"">
                            <div class=""vuerow"">
                                <div class=""vuecol80"">Sub:</div>
                                <div class=""vuecol20 pr-2"">{{details[0].totalPrice | toCurrency}}</div>
                            </div>
                            <div class=""vuerow"">
                                <div class=""vuecol80"">Tax:</div>
                                <div class=""vuecol20 pr-2"">{{details[0].totalTax | toCurrency}}</div>
                            </div>
                            <div class=""vuerow"">
                                <div class=""vuecol80"">Total:</div>
                                <div class=""vuecol20 pr-2"">{{details[0].totalAll | toCurrency}}</div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </transition>
</script>
");
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