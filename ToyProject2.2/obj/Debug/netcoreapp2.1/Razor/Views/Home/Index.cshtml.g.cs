#pragma checksum "C:\Users\user\source\repos\ToyProject2.2\ToyProject2.2\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6a1fe3fa8a12a36cded0d8426b667a1687c34710"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\user\source\repos\ToyProject2.2\ToyProject2.2\Views\_ViewImports.cshtml"
using ToyProject2._2;

#line default
#line hidden
#line 2 "C:\Users\user\source\repos\ToyProject2.2\ToyProject2.2\Views\_ViewImports.cshtml"
using ToyProject2._2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6a1fe3fa8a12a36cded0d8426b667a1687c34710", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a255efbe0c73c65a9386810b44622de87ef69b82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/dist/main.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("app-append-version", new global::Microsoft.AspNetCore.Html.HtmlString("true"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "C:\Users\user\source\repos\ToyProject2.2\ToyProject2.2\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 3854, true);
            WriteLiteral(@"

<div id=""vueapp"" class=""vue-app"">
    <kendo-datasource ref=""datasource1""
                      :transport-read-url=""'https://demos.telerik.com/kendo-ui/service/Products'""
                      :transport-read-data-type=""'jsonp'""
                      :transport-update-url=""'https://demos.telerik.com/kendo-ui/service/Products/Update'""
                      :transport-update-data-type=""'jsonp'""
                      :transport-destroy-url=""'https://demos.telerik.com/kendo-ui/service/Products/Destroy'""
                      :transport-destroy-data-type=""'jsonp'""
                      :transport-create-url=""'https://demos.telerik.com/kendo-ui/service/Products/Create'""
                      :transport-create-data-type=""'jsonp'""
                      :transport-parameter-map=""parameterMap""
                      :schema-model-id=""'ProductID'""
                      :schema-model-fields=""schemaModelFields""
                      :batch='true'
                      :page-size='30'
                   ");
            WriteLiteral(@"   :aggregate=""aggregateDefinition"">
    </kendo-datasource>

    <kendo-grid :height=""600""
                :data-source-ref=""'datasource1'""
                :reorderable=""true""
                :resizable=""true""
                :filterable=""true""
                :editable=""'popup'""
                :pageable=""true""
                :sortable-mode=""'multiple'""
                :groupable=""true""
                :sortable-allow-unsort=""true""
                :sortable-show-indexes=""true""
                :toolbar=""['create','excel','pdf']""
                :excel-file-name=""'Kendo UI Grid Export.xlsx'""
                :excel-proxy-URL=""'https://demos.telerik.com/kendo-ui/service/export'""
                :excel-filterable=""true"">
        <kendo-grid-column :field=""'ProductName'""
                           :filterable-multi=""true""
                           :filterable-search=""true""
                           :width=""300""
                           :attributes=""{style: 'text-align: left'}""></kendo-g");
            WriteLiteral(@"rid-column>

        <kendo-grid-column :field=""'UnitPrice'""
                           :title=""'Unit Price'""
                           :width=""130""
                           :headerAttributes=""{style: 'text-align: right'}""
                           :attributes=""{style: 'text-align: right'}""
                           :aggregates=""['sum']""
                           :footer-template=""'Total: #=kendo.toString(sum, `n5`)# '""
                           :group-footer-template=""'Total: #=kendo.toString(sum, `n2`)# '""
                           :format=""'{0:c}'""
                           :filterable-multi=""true""></kendo-grid-column>
        <kendo-grid-column :field=""'UnitsInStock'""
                           :title=""'Units In Stock'""
                           :width=""120""
                           :headerAttributes=""{style: 'text-align: right'}""
                           :attributes=""{style: 'text-align: right'}""
                           :aggregates=""['count']""
                          ");
            WriteLiteral(@" :footer-template=""'Count: #=count# '""
                           :filterable-multi=""true""></kendo-grid-column>
        <kendo-grid-column :field=""'Discontinued'""
                           :width=""120""
                           :headerAttributes=""{style: 'text-align: center'}""
                           :attributes=""{style: 'text-align: center'}""
                           :filterable-multi=""true""
                           :filterable-data-source=""discontinuedDs""></kendo-grid-column>
        <kendo-grid-column :command=""['edit', 'destroy']""
                           :title=""'&nbsp;'""
                           :width=""180""></kendo-grid-column>
    </kendo-grid>
</div>

<style>
    .k-header .k-link {
        text-align: center;
    }
</style>



");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(3916, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3922, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "941a6208221243e09449b3bb62312f64", async() => {
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
                BeginContext(3986, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
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
