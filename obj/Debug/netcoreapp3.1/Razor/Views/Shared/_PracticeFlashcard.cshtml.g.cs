#pragma checksum "/Users/jonmi/Projects/Flashcards/Flashcards/Views/Shared/_PracticeFlashcard.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fd4eddb6eef4cfaebb8ceebb132b8fd397d5c6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__PracticeFlashcard), @"mvc.1.0.view", @"/Views/Shared/_PracticeFlashcard.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fd4eddb6eef4cfaebb8ceebb132b8fd397d5c6a", @"/Views/Shared/_PracticeFlashcard.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad05e717392139bb8f98907f242f97013cdfe3a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__PracticeFlashcard : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Flashcard>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div class=\"practice-flashcard\">\n    <div class=\"practice-front\">\n        <p class=\"practice-flashcard-text\">\n            ");
#nullable restore
#line 6 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/Shared/_PracticeFlashcard.cshtml"
       Write(Model.FrontText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <span class=\"sr-only\">");
#nullable restore
#line 8 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/Shared/_PracticeFlashcard.cshtml"
                         Write(Model.FrontText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n    </div>\n    <div class=\"practice-back\">\n        <p class=\"practice-flashcard-text\">\n            ");
#nullable restore
#line 12 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/Shared/_PracticeFlashcard.cshtml"
       Write(Model.BackText);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n        <span class=\"sr-only\">");
#nullable restore
#line 14 "/Users/jonmi/Projects/Flashcards/Flashcards/Views/Shared/_PracticeFlashcard.cshtml"
                         Write(Model.BackText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Flashcard> Html { get; private set; }
    }
}
#pragma warning restore 1591
