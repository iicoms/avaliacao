#pragma checksum "C:\Sistemas\Sistemas\DotNetCore\Nova Vida Tecnologia - Teste Programador ASP.NET\Nova Vida Tecnologia - Teste Programador ASP.NET\Views\Home\ImportarAlunos.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c318f5d868a270a51b7521d8084552e200ab40b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ImportarAlunos), @"mvc.1.0.view", @"/Views/Home/ImportarAlunos.cshtml")]
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
#line 1 "C:\Sistemas\Sistemas\DotNetCore\Nova Vida Tecnologia - Teste Programador ASP.NET\Nova Vida Tecnologia - Teste Programador ASP.NET\Views\_ViewImports.cshtml"
using Nova_Vida_Tecnologia___Teste_Programador_ASP.NET;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Sistemas\Sistemas\DotNetCore\Nova Vida Tecnologia - Teste Programador ASP.NET\Nova Vida Tecnologia - Teste Programador ASP.NET\Views\_ViewImports.cshtml"
using Nova_Vida_Tecnologia___Teste_Programador_ASP.NET.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c318f5d868a270a51b7521d8084552e200ab40b5", @"/Views/Home/ImportarAlunos.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fe2611600e978c7e467ec2acfbf2f931697b84c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ImportarAlunos : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Home/Upload"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/home/Alunos.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
#nullable restore
#line 1 "C:\Sistemas\Sistemas\DotNetCore\Nova Vida Tecnologia - Teste Programador ASP.NET\Nova Vida Tecnologia - Teste Programador ASP.NET\Views\Home\ImportarAlunos.cshtml"
  
    ViewData["Title"] = "Importar Alunos";

#line default
#line hidden
#nullable disable
            DefineSection("styles", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdnjs.cloudflare.com/ajax/libs/twitter-bootstrap/4.5.2/css/bootstrap.css"" />
    <link rel=""stylesheet"" type=""text/css"" href=""https://cdn.datatables.net/1.10.22/css/dataTables.bootstrap4.min.css"" />
");
            }
            );
            WriteLiteral("\r\n\r\n<input type=\"hidden\" id=\"ProfessorID\"");
            BeginWriteAttribute("value", " value=\"", 372, "\"", 395, 1);
#nullable restore
#line 10 "C:\Sistemas\Sistemas\DotNetCore\Nova Vida Tecnologia - Teste Programador ASP.NET\Nova Vida Tecnologia - Teste Programador ASP.NET\Views\Home\ImportarAlunos.cshtml"
WriteAttributeValue("", 380, ViewData["id"], 380, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<div class=\"text-center\">\r\n    <h1>Importar alunos para professor (");
#nullable restore
#line 12 "C:\Sistemas\Sistemas\DotNetCore\Nova Vida Tecnologia - Teste Programador ASP.NET\Nova Vida Tecnologia - Teste Programador ASP.NET\Views\Home\ImportarAlunos.cshtml"
                                   Write(ViewData["id"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(") ");
#nullable restore
#line 12 "C:\Sistemas\Sistemas\DotNetCore\Nova Vida Tecnologia - Teste Programador ASP.NET\Nova Vida Tecnologia - Teste Programador ASP.NET\Views\Home\ImportarAlunos.cshtml"
                                                    Write(ViewData["nome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-12 d-flex justify-content-center\">\r\n");
#nullable restore
#line 17 "C:\Sistemas\Sistemas\DotNetCore\Nova Vida Tecnologia - Teste Programador ASP.NET\Nova Vida Tecnologia - Teste Programador ASP.NET\Views\Home\ImportarAlunos.cshtml"
         if (@ViewData["bloqueado"] == "Não")
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c318f5d868a270a51b7521d8084552e200ab40b57830", async() => {
                WriteLiteral(@"
                <div class=""form-group"">
                    <div class=""col-md-10"">
                        <p>Selecione um arquivo CSV para enviar:</p>
                        <input type=""file"" name=""file"" />
                        <input type=""hidden"" name=""professorid"" id=""professorid""");
                BeginWriteAttribute("value", " value=\"", 1036, "\"", 1059, 1);
#nullable restore
#line 25 "C:\Sistemas\Sistemas\DotNetCore\Nova Vida Tecnologia - Teste Programador ASP.NET\Nova Vida Tecnologia - Teste Programador ASP.NET\Views\Home\ImportarAlunos.cshtml"
WriteAttributeValue("", 1044, ViewData["id"], 1044, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <input type=\"hidden\" name=\"nomeprofessor\" id=\"nomeprofessor\"");
                BeginWriteAttribute("value", " value=\"", 1149, "\"", 1174, 1);
#nullable restore
#line 26 "C:\Sistemas\Sistemas\DotNetCore\Nova Vida Tecnologia - Teste Programador ASP.NET\Nova Vida Tecnologia - Teste Programador ASP.NET\Views\Home\ImportarAlunos.cshtml"
WriteAttributeValue("", 1157, ViewData["nome"], 1157, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@" />
                    </div>
                </div>
                <div class=""form-group"">
                    <div class=""col-md-10"">
                        <input type=""submit"" value=""Enviar"" />
                    </div>
                </div>
            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Sistemas\Sistemas\DotNetCore\Nova Vida Tecnologia - Teste Programador ASP.NET\Nova Vida Tecnologia - Teste Programador ASP.NET\Views\Home\ImportarAlunos.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h1 style=\"color: red\">Professor bloqueado temporariamente de importar novos alunos. Aguarde o término do prazo.</h1>\r\n");
#nullable restore
#line 39 "C:\Sistemas\Sistemas\DotNetCore\Nova Vida Tecnologia - Teste Programador ASP.NET\Nova Vida Tecnologia - Teste Programador ASP.NET\Views\Home\ImportarAlunos.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 44 "C:\Sistemas\Sistemas\DotNetCore\Nova Vida Tecnologia - Teste Programador ASP.NET\Nova Vida Tecnologia - Teste Programador ASP.NET\Views\Home\ImportarAlunos.cshtml"
     if (ViewBag.Message != null)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-success\" style=\"margin-top:20px\">\r\n            ");
#nullable restore
#line 47 "C:\Sistemas\Sistemas\DotNetCore\Nova Vida Tecnologia - Teste Programador ASP.NET\Nova Vida Tecnologia - Teste Programador ASP.NET\Views\Home\ImportarAlunos.cshtml"
       Write(ViewBag.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 49 "C:\Sistemas\Sistemas\DotNetCore\Nova Vida Tecnologia - Teste Programador ASP.NET\Nova Vida Tecnologia - Teste Programador ASP.NET\Views\Home\ImportarAlunos.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.22/js/jquery.dataTables.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.22/js/dataTables.bootstrap4.min.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/plug-ins/1.10.21/dataRender/datetime.js""></script>
    <script type=""text/javascript"" src=""https://cdnjs.cloudflare.com/ajax/libs/moment.js/2.18.1/moment.min.js""></script>
    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c318f5d868a270a51b7521d8084552e200ab40b513407", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
