#pragma checksum "C:\Users\Pedro Milan Cocom\Desktop\CalcMVC-master\Views\Calculadora\Suma.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ecba8c94982f2f878d884d90a750d8df74abdcca"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calculadora_Suma), @"mvc.1.0.view", @"/Views/Calculadora/Suma.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Calculadora/Suma.cshtml", typeof(AspNetCore.Views_Calculadora_Suma))]
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
#line 1 "C:\Users\Pedro Milan Cocom\Desktop\CalcMVC-master\Views\_ViewImports.cshtml"
using Calculadora;

#line default
#line hidden
#line 2 "C:\Users\Pedro Milan Cocom\Desktop\CalcMVC-master\Views\_ViewImports.cshtml"
using Calculadora.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ecba8c94982f2f878d884d90a750d8df74abdcca", @"/Views/Calculadora/Suma.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b73bc683a9f979c652064084dbaeab0fe83a2029", @"/Views/_ViewImports.cshtml")]
    public class Views_Calculadora_Suma : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 50, true);
            WriteLiteral("<h2>Operaciones</h2>\r\n\r\n<br><h3>Suma</h3>\r\n\r\n<h4> ");
            EndContext();
            BeginContext(51, 16, false);
#line 5 "C:\Users\Pedro Milan Cocom\Desktop\CalcMVC-master\Views\Calculadora\Suma.cshtml"
Write(ViewData["Suma"]);

#line default
#line hidden
            EndContext();
            BeginContext(67, 8, true);
            WriteLiteral(" </h4>\r\n");
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
