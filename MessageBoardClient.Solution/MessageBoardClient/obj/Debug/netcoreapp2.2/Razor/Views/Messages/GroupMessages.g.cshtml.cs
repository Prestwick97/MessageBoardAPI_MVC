#pragma checksum "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/GroupMessages.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3c12fd648122aa6ddc19cbd019d90e3a0b529026"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_GroupMessages), @"mvc.1.0.view", @"/Views/Messages/GroupMessages.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Messages/GroupMessages.cshtml", typeof(AspNetCore.Views_Messages_GroupMessages))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/GroupMessages.cshtml"
using MessageBoardClient.Models;

#line default
#line hidden
#line 2 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/GroupMessages.cshtml"
using System.Linq;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3c12fd648122aa6ddc19cbd019d90e3a0b529026", @"/Views/Messages/GroupMessages.cshtml")]
    public class Views_Messages_GroupMessages : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 40, true);
            WriteLiteral("\n\n<h1>All Messages in group:</h1>\n\n<ol>\n");
            EndContext();
#line 8 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/GroupMessages.cshtml"
 foreach (Message message in Model)
{
  

#line default
#line hidden
            BeginContext(133, 28, true);
            WriteLiteral("    <ul>\n        <h3>Group: ");
            EndContext();
            BeginContext(162, 13, false);
#line 12 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/GroupMessages.cshtml"
              Write(message.Group);

#line default
#line hidden
            EndContext();
            BeginContext(175, 21, true);
            WriteLiteral("</h3>\n        <p>ID: ");
            EndContext();
            BeginContext(197, 17, false);
#line 13 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/GroupMessages.cshtml"
          Write(message.MessageId);

#line default
#line hidden
            EndContext();
            BeginContext(214, 14, true);
            WriteLiteral(" - User Name: ");
            EndContext();
            BeginContext(229, 16, false);
#line 13 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/GroupMessages.cshtml"
                                          Write(message.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(245, 26, true);
            WriteLiteral("</p>\n        <li>Content: ");
            EndContext();
            BeginContext(272, 15, false);
#line 14 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/GroupMessages.cshtml"
                Write(message.Content);

#line default
#line hidden
            EndContext();
            BeginContext(287, 23, true);
            WriteLiteral("</li>\n\n    </ul>\n    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 310, "\"", 355, 2);
            WriteAttributeValue("", 317, "/Messages/Details/", 317, 18, true);
#line 17 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/GroupMessages.cshtml"
WriteAttributeValue("", 335, message.MessageId, 335, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(356, 34, true);
            WriteLiteral("><p>View Details</p></a>\n    <br>\n");
            EndContext();
#line 19 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/GroupMessages.cshtml"
  
}

#line default
#line hidden
            BeginContext(395, 10, true);
            WriteLiteral("</ol>\n\n<p>");
            EndContext();
            BeginContext(406, 40, false);
#line 23 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/GroupMessages.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(446, 4, true);
            WriteLiteral("</p>");
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
