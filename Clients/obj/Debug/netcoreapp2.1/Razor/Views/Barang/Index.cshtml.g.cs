#pragma checksum "C:\Users\Thomas\Documents\SIG-master\Clients\Views\Barang\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a49f30b271804d194c562443df1cebe06ebca2b0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Barang_Index), @"mvc.1.0.view", @"/Views/Barang/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Barang/Index.cshtml", typeof(AspNetCore.Views_Barang_Index))]
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
#line 1 "C:\Users\Thomas\Documents\SIG-master\Clients\Views\_ViewImports.cshtml"
using Clients;

#line default
#line hidden
#line 2 "C:\Users\Thomas\Documents\SIG-master\Clients\Views\_ViewImports.cshtml"
using Clients.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a49f30b271804d194c562443df1cebe06ebca2b0", @"/Views/Barang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b4f664e12feef1cbf486080a94415f7cb12553e", @"/Views/_ViewImports.cshtml")]
    public class Views_Barang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/Barang.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\Thomas\Documents\SIG-master\Clients\Views\Barang\Index.cshtml"
  
    ViewData["Title"] = "Barang";

#line default
#line hidden
            BeginContext(40, 1042, true);
            WriteLiteral(@"
<h1>Data Barang</h1>

<div class=""my-3"">
    <button data-toggle=""modal"" data-target=""#modalBrg"" id=""BtnAdd"" class=""btn btn-primary"">
        <i class='fas fa-plus'></i> Barang
    </button>
</div>

<table id=""Barang"" class=""table table-hover"">
    <thead>
        <tr>
            <th>No</th>
            <th>Nama Barang</th>
            <th>Stock</th>
            <th>Jenis</th>
            <th>Action</th>
        </tr>
    </thead>
    <tbody>
    </tbody>
</table>

<!-- Modal -->
<div class=""modal fade"" id=""modalBrg"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""modalBrg""></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body""");
            WriteLiteral(">\n                ");
            EndContext();
            BeginContext(1082, 766, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3557337ee8e0407a8f2f1c140d4ca4f3", async() => {
                BeginContext(1088, 753, true);
                WriteLiteral(@"
                    <div class=""form-group"">
                        <label for=""namabarang"">Nama Barang</label>
                        <input type=""text"" class=""form-control"" id=""namabarang"" placeholder=""Masukan Nama Barang"" name=""NamaBarang"">
                    </div>
                    <div class=""form-group"">
                        <label for=""stok"">Stok</label>
                        <input type=""text"" class=""form-control"" id=""stok"" placeholder=""Masukan Stok"" name=""Stok"">
                    </div>
                    <div class=""form-group"">
                        <label for=""jenisbarang"">Jenis Barang</label>
                        <select id=""jenisbarang"" class=""form-control""></select>
                    </div>
                ");
                EndContext();
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
            EndContext();
            BeginContext(1848, 523, true);
            WriteLiteral(@"
            </div>
            <div class=""modal-footer"">
                <input type=""hidden"" id=""idbarang"" class=""form-control"" />
                <button type=""button"" class=""btn btn-secondary"" id=""Cancel"" data-dismiss=""modal"">Tutup</button>
                <button type=""submit"" class=""btn btn-success"" id=""Save"" onclick=""Save()"">Simpan</button>
                <button type=""submit"" class=""btn btn-warning"" id=""Update"" onclick=""Update()"">Simpan Perubahan</button>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2388, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(2393, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b11c8671b2644048fb1aa0ebfaa00b4", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2431, 1, true);
                WriteLiteral("\n");
                EndContext();
            }
            );
            BeginContext(2434, 1, true);
            WriteLiteral("\n");
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
