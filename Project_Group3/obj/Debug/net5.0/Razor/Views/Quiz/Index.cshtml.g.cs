#pragma checksum "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "2e1438b3ea2f754f13f20daff29edaaba3bb725a7188a9523df3bc77639f90d8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Quiz_Index), @"mvc.1.0.view", @"/Views/Quiz/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\SWP\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\SWP\Project_Group3\Views\_ViewImports.cshtml"
using Project_Group3.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"2e1438b3ea2f754f13f20daff29edaaba3bb725a7188a9523df3bc77639f90d8", @"/Views/Quiz/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"6925787e4d23fd4cbbfa572d9e9b5c1189eba9ade7d7bab7b284e3bc23eda31c", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Quiz_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Tuple<IEnumerable<WebLibrary.Models.Quiz>, IEnumerable<WebLibrary.Models.Answer>, WebLibrary.Models.Chapter,
WebLibrary.Models.Course>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/fonts/boxicons.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
  
    ViewData["Title"] = "Index";
   Layout = "~/Views/Shared/_LayoutCourse.cshtml";

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2e1438b3ea2f754f13f20daff29edaaba3bb725a7188a9523df3bc77639f90d85029", async() => {
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
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2e1438b3ea2f754f13f20daff29edaaba3bb725a7188a9523df3bc77639f90d86167", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<h1>List Quiz</h1>\r\n<a class=\"btn btn-success mb-2\"");
            BeginWriteAttribute("href", "\r\n    href=\"", 398, "\"", 516, 1);
#nullable restore
#line 14 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 410, Url.Action("Create", "Quiz", new { chapterId = @Model.Item3.ChapterId, courseId = @Model.Item4.CourseId}), 410, 106, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Add\r\n    Quiz</a>\r\n<a class=\"btn btn-success mb-2\"");
            BeginWriteAttribute("href", " href=\"", 568, "\"", 647, 1);
#nullable restore
#line 16 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 575, Url.Action("Index", "Chapter", new { courseId = @Model.Item4.CourseId}), 575, 72, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">Back to
    Chapter</a>

<table class=""table"">
    <thead>
        <tr>
            <th>CourseName</th>
            <th>ChapterName</th>
            <th>Quiz1</th>
            <th>DapAnA</th>
            <th>DapAnB</th>
            <th>DapAnC</th>
            <th>DapAnD</th>
            <th>DapAn</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 33 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
         if (Model != null)
        {
            foreach (var quiz in Model.Item1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 38 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
                   Write(Model.Item4.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 39 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
                   Write(Model.Item3.ChapterName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
                   Write(quiz.Quiz1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
                   Write(quiz.DapAnA);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
                   Write(quiz.DapAnB);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 43 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
                   Write(quiz.DapAnC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 44 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
                   Write(quiz.DapAnD);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 45 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
                      
                        string answerName = "";
                        foreach (var answer in Model.Item2)
                        {
                            if (quiz.AnswerId == answer.AnswerId)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>");
#nullable restore
#line 51 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
                               Write(answer.Answer1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 52 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
                            }
                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td class=\"text-theme\">\r\n                        <div class=\"action-icon d-flex text-center\">\r\n                            <a class=\"btn btn-warning mr-2\"");
            BeginWriteAttribute("href", " href=\"", 2027, "\"", 2086, 1);
#nullable restore
#line 57 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 2034, Url.Action("Edit", "Quiz", new {id = @quiz.QuizId}), 2034, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                title=\"Edit\">\r\n                                <i class=\'bx bxs-edit\'></i>\r\n                            </a>\r\n                            <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 2284, "\"", 2345, 1);
#nullable restore
#line 61 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
WriteAttributeValue("", 2291, Url.Action("Delete", "Quiz", new {id = @quiz.QuizId}), 2291, 54, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                title=\"Delete\">\r\n                                <i class=\'bx bxs-trash-alt\'></i>\r\n                            </a>\r\n                        </div>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 68 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
            }
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td colspan=\"8\">No Quiz found.</td>\r\n            </tr>\r\n");
#nullable restore
#line 75 "D:\SWP\Project_Group3\Views\Quiz\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "2e1438b3ea2f754f13f20daff29edaaba3bb725a7188a9523df3bc77639f90d813428", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
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
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Tuple<IEnumerable<WebLibrary.Models.Quiz>, IEnumerable<WebLibrary.Models.Answer>, WebLibrary.Models.Chapter,
WebLibrary.Models.Course>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
