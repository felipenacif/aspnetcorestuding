#pragma checksum "C:\Users\Felipe\Desktop\GIT\AppStartCMD\AppStartCMD\AppStartCMD\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "baf4922c7e34a62323be675c9eec7ccf21ae981f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AppStartCMD.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace AppStartCMD.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Felipe\Desktop\GIT\AppStartCMD\AppStartCMD\AppStartCMD\Pages\_ViewImports.cshtml"
using AppStartCMD;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"baf4922c7e34a62323be675c9eec7ccf21ae981f", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bcada2b9dec2fd337f1f206909be9e86328b0a5", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\Felipe\Desktop\GIT\AppStartCMD\AppStartCMD\AppStartCMD\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home page";

#line default
#line hidden
            WriteLiteral(@"
<div class=""text-center"">
    <h1 class=""display-4"">Welcome</h1>
    <p>Learn about <a href=""https://docs.microsoft.com/aspnet/core"">building Web apps with ASP.NET Core</a>.</p>
</div>

<div>
    <h3>Ultimas matérias cadastradas</h3>
    <table class=""table"" id=""tableMaterias"">
        <thead>
            <tr>
                <th>Titulo</th>
                <th>Resumo</th>
            </tr>
        </thead>
        <tbody>
            
        </tbody>
    </table>
</div>


");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"

    <script>
        $(document).ready(function () {

            $.get(""/api/materias"", function (data) {
                $('#tableMaterias').DataTable({
                    data: data,
                    columns: [
                        { data: 'titulo' },
                        { data: 'resumo' }
                    ]
                });
            });
        });


        

    </script>

");
            }
            );
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
