#pragma checksum "/Users/patrickdelaney/Desktop/MessageBoardAPI_MVC/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95d5f6ac301c0843adcf12e3986e4985c656db62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Create), @"mvc.1.0.view", @"/Views/Messages/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Messages/Create.cshtml", typeof(AspNetCore.Views_Messages_Create))]
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
#line 1 "/Users/patrickdelaney/Desktop/MessageBoardAPI_MVC/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml"
using MessageBoardClient.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d5f6ac301c0843adcf12e3986e4985c656db62", @"/Views/Messages/Create.cshtml")]
    public class Views_Messages_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(79, 24, true);
            WriteLiteral("\n<h1>New Message:</h1>\n\n");
            EndContext();
#line 5 "/Users/patrickdelaney/Desktop/MessageBoardAPI_MVC/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml"
  
string groupName = "";

#line default
#line hidden
            BeginContext(131, 227, true);
            WriteLiteral("\n<form action=\"/messages\" method=\"post\">\n  <label for=\"userName\">Username</label>\n  <input id=\"userName\" name=\"userName\" type=\"text\">\n  <label for=\"content\">Content</label>\n  <input id=\"content\" name=\"content\" type=\"text\">\n    ");
            EndContext();
            BeginContext(359, 27, false);
#line 14 "/Users/patrickdelaney/Desktop/MessageBoardAPI_MVC/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml"
Write(Html.Label("Select group:"));

#line default
#line hidden
            EndContext();
            BeginContext(386, 36, true);
            WriteLiteral("\n  <select id=\"group\" name=\"group\">\n");
            EndContext();
#line 16 "/Users/patrickdelaney/Desktop/MessageBoardAPI_MVC/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml"
      foreach (Message message in Model)
     {
        

#line default
#line hidden
#line 18 "/Users/patrickdelaney/Desktop/MessageBoardAPI_MVC/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml"
         if (groupName != message.Group)
        {

#line default
#line hidden
            BeginContext(521, 17, true);
            WriteLiteral("         <option>");
            EndContext();
            BeginContext(539, 13, false);
#line 20 "/Users/patrickdelaney/Desktop/MessageBoardAPI_MVC/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml"
            Write(message.Group);

#line default
#line hidden
            EndContext();
            BeginContext(552, 10, true);
            WriteLiteral("</option>\n");
            EndContext();
#line 21 "/Users/patrickdelaney/Desktop/MessageBoardAPI_MVC/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml"
        }

#line default
#line hidden
#line 21 "/Users/patrickdelaney/Desktop/MessageBoardAPI_MVC/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Create.cshtml"
         
        groupName = message.Group;
     }

#line default
#line hidden
            BeginContext(614, 12, true);
            WriteLiteral("  </select>\n");
            EndContext();
            BeginContext(727, 44, true);
            WriteLiteral("  <button type=\"submit\">Go!</button>\n</form>");
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
