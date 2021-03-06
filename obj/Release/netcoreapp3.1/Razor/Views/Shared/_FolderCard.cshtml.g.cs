#pragma checksum "/Users/jonmi/Projects/Flashcards/Flashcards/Views/Shared/_FolderCard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fdee3275fa3ab608d06086097193a1b8be3becc4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__FolderCard), @"mvc.1.0.view", @"/Views/Shared/_FolderCard.cshtml")]
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
#line 1 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/_ViewImports.cshtml"
using Flashcards;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/_ViewImports.cshtml"
using Flashcards.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/_ViewImports.cshtml"
using Flashcards.Models.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/_ViewImports.cshtml"
using Flashcards.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fdee3275fa3ab608d06086097193a1b8be3becc4", @"/Views/Shared/_FolderCard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad05e717392139bb8f98907f242f97013cdfe3a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__FolderCard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FlashcardFolder>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "FolderDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFolder", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"card w-10\">\n    <div class=\"card-body\">\n        <h4 class=\"card-title\">");
#nullable restore
#line 5 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/Shared/_FolderCard.cshtml"
                          Write(Model.FolderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n        <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 6 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/Shared/_FolderCard.cshtml"
                                             Write(Model.Subject);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\n        <p class=\"card-text\">\n            ");
#nullable restore
#line 8 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/Shared/_FolderCard.cshtml"
       Write(Model.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdee3275fa3ab608d06086097193a1b8be3becc45551", async() => {
                WriteLiteral("Open Folder");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/Shared/_FolderCard.cshtml"
             WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <a href=\"#\" class=\"card-link float-right text-danger\"");
            BeginWriteAttribute("onclick", " onclick=\"", 487, "\"", 543, 3);
            WriteAttributeValue("", 497, "removeCardWarning(\'confirm-dialog-", 497, 34, true);
#nullable restore
#line 14 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/Shared/_FolderCard.cshtml"
WriteAttributeValue("", 531, Model.Id, 531, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 540, "\');", 540, 3, true);
            EndWriteAttribute();
            WriteLiteral(" id=\"remove-button\">Remove Folder</a>\n    </div>\n</div>\n\n<!--popup box to confirm removal of a folder, hidden by default, links are made using modelId to open one box at a time.-->\n<div");
            BeginWriteAttribute("id", " id=\"", 729, "\"", 758, 2);
            WriteAttributeValue("", 734, "confirm-dialog-", 734, 15, true);
#nullable restore
#line 19 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/Shared/_FolderCard.cshtml"
WriteAttributeValue("", 749, Model.Id, 749, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" title=\"Remove folder\" class=\"modal\">\n    <div class=\"modal-content\">\n        <p>Are you sure you want to delete the folder \"");
#nullable restore
#line 21 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/Shared/_FolderCard.cshtml"
                                                  Write(Model.FolderName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"?</p>\n        <menu>\n            <button id=\"cancel\" class=\"close\"");
            BeginWriteAttribute("onclick", " onclick=\"", 968, "\"", 1023, 3);
            WriteAttributeValue("", 978, "closeCardWarning(\'confirm-dialog-", 978, 33, true);
#nullable restore
#line 23 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/Shared/_FolderCard.cshtml"
WriteAttributeValue("", 1011, Model.Id, 1011, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1020, "\');", 1020, 3, true);
            EndWriteAttribute();
            WriteLiteral(">Cancel</button>\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fdee3275fa3ab608d06086097193a1b8be3becc410111", async() => {
                WriteLiteral("Remove Folder");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/Shared/_FolderCard.cshtml"
                 WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        </menu>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FlashcardFolder> Html { get; private set; }
    }
}
#pragma warning restore 1591
