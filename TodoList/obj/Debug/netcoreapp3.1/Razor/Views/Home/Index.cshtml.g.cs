#pragma checksum "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "702292a79d0b3a782736a4742acb771a76c3202b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
using TodoList.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"702292a79d0b3a782736a4742acb771a76c3202b", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TodoList.Models.TodoListItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/JavaScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin: 20px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702292a79d0b3a782736a4742acb771a76c3202b4828", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>TODO List</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "702292a79d0b3a782736a4742acb771a76c3202b5154", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "702292a79d0b3a782736a4742acb771a76c3202b6333", async() => {
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
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702292a79d0b3a782736a4742acb771a76c3202b7511", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("async", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "702292a79d0b3a782736a4742acb771a76c3202b9634", async() => {
                WriteLiteral("\r\n    <h1 class=\"text-center\">ToDo (");
#nullable restore
#line 15 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
                             Write(Model.Count(item => !item.IsDone));

#line default
#line hidden
#nullable disable
                WriteLiteral(")</h1>\r\n    <table class=\"table table-bordered\">\r\n        <thead class=\"table-dark\">\r\n            <tr>\r\n                <td colspan=\"4\">\r\n");
#nullable restore
#line 20 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
                     using (Html.BeginForm("Create", "Home", FormMethod.Post))
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
                   Write(Html.HiddenFor(model => new TodoListItem().Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"input-group\">\r\n                            ");
#nullable restore
#line 24 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
                       Write(Html.TextBoxFor(model => new TodoListItem().Title, new { @class = "form-control", @placeholder = "Type something todo" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                            <div class=\"input-group-append\">\r\n                                <button type=\"submit\" class=\"btn btn-success\">Add</button>\r\n                            </div>\r\n                        </div>\r\n");
#nullable restore
#line 29 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </td>\r\n            </tr>\r\n        </thead>\r\n        <tbody class=\"table-hover\">\r\n");
#nullable restore
#line 34 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
             foreach (var item in Model)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr");
                BeginWriteAttribute("class", " class=", 1375, "", 1431, 1);
#nullable restore
#line 36 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
WriteAttributeValue("", 1382, item.IsDone ? "table-success" : "table-danger", 1382, 49, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                    <td>\r\n                        <input type=\"checkbox\"");
                BeginWriteAttribute("id", " id=\"", 1506, "\"", 1519, 1);
#nullable restore
#line 38 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
WriteAttributeValue("", 1511, item.Id, 1511, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("checked", " checked=\"", 1520, "\"", 1542, 1);
#nullable restore
#line 38 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
WriteAttributeValue("", 1530, item.IsDone, 1530, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("onclick", " onclick=\"", 1543, "\"", 1606, 5);
                WriteAttributeValue("", 1553, "window.location.href", 1553, 20, true);
                WriteAttributeValue(" ", 1573, "=", 1574, 2, true);
                WriteAttributeValue(" ", 1575, "\'/Home/ToggleIsDone/", 1576, 21, true);
#nullable restore
#line 38 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
WriteAttributeValue("", 1596, item.Id, 1596, 8, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 1604, "\';", 1604, 2, true);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                        <label");
                BeginWriteAttribute("for", " for=\"", 1642, "\"", 1656, 1);
#nullable restore
#line 39 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
WriteAttributeValue("", 1648, item.Id, 1648, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("style", " style=\"", 1657, "\"", 1744, 1);
#nullable restore
#line 39 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
WriteAttributeValue("", 1665, item.IsDone ? "color: green; text-decoration: line-through;" : "color: red;", 1665, 79, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            ");
#nullable restore
#line 40 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
                       Write(item.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                        </label>\r\n                        <div style=\"display: none;\"");
                BeginWriteAttribute("id", " id=\"", 1874, "\"", 1899, 1);
#nullable restore
#line 42 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
WriteAttributeValue("", 1879, $"idDiv{item.Id}", 1879, 20, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 43 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
                             using (Html.BeginForm("Edit", "Home", FormMethod.Post))
                            {
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
                           Write(Html.HiddenFor(model => @item.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
                           Write(Html.HiddenFor(model => @item.IsDone));

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <div class=\"input-group\">\r\n                                    ");
#nullable restore
#line 48 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
                               Write(Html.TextBoxFor(model => @item.Title, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                                    <div class=""input-group-append"">
                                        <button type=""submit"" class=""btn btn-sm btn-success"">Save</button>
                                    </div>
                                </div>
");
#nullable restore
#line 53 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </div>\r\n                    </td>\r\n                    <td class=\"cell text-center\">\r\n                        ");
#nullable restore
#line 57 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
                   Write(item.AddDate.ToShortDateString());

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n                    <td class=\"cell text-center\">\r\n                        <button class=\"btn btn-sm btn-warning\"");
                BeginWriteAttribute("onclick", " onclick=\"", 2930, "\"", 2973, 3);
                WriteAttributeValue("", 2940, "toggleDiv(\'", 2940, 11, true);
#nullable restore
#line 60 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
WriteAttributeValue("", 2951, $"idDiv{item.Id}", 2951, 20, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2971, "\')", 2971, 2, true);
                EndWriteAttribute();
                WriteLiteral(">Edit</button>\r\n                    </td>\r\n                    <td class=\"cell text-center\">\r\n                        <a");
                BeginWriteAttribute("href", " href=\"", 3094, "\"", 3122, 2);
                WriteAttributeValue("", 3101, "/Home/Delete/", 3101, 13, true);
#nullable restore
#line 63 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
WriteAttributeValue("", 3114, item.Id, 3114, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-sm btn-danger\">Delete</a>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 66 "D:\SublimeProject\web\TodoList\TodoList\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TodoList.Models.TodoListItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
