#pragma checksum "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Groups.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3cde54087a8b8353f8364892612915d64a19615"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Messages_Groups), @"mvc.1.0.view", @"/Views/Messages/Groups.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Messages/Groups.cshtml", typeof(AspNetCore.Views_Messages_Groups))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Groups.cshtml"
using MessageBoardClient.Models;

#line default
#line hidden
#line 2 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Groups.cshtml"
using System.Linq;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3cde54087a8b8353f8364892612915d64a19615", @"/Views/Messages/Groups.cshtml")]
    public class Views_Messages_Groups : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 22, true);
            WriteLiteral("<h1>All Groups:</h1>\n\n");
            EndContext();
#line 5 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Groups.cshtml"
  
string groupName = "";

#line default
#line hidden
            BeginContext(102, 6, true);
            WriteLiteral("\n<ol>\n");
            EndContext();
#line 10 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Groups.cshtml"
 foreach (Message message in Model)
{
  

#line default
#line hidden
#line 12 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Groups.cshtml"
   if (groupName != message.Group)
  {

#line default
#line hidden
            BeginContext(185, 21, true);
            WriteLiteral("    <ul>\n        <h3>");
            EndContext();
            BeginContext(207, 97, false);
#line 15 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Groups.cshtml"
       Write(Html.ActionLink($"{message.Group}", "GroupMessages", "Messages", new {groupName = message.Group}));

#line default
#line hidden
            EndContext();
            BeginContext(304, 25, true);
            WriteLiteral("</h3>\n    </ul>\n    <br>\n");
            EndContext();
#line 18 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Groups.cshtml"
  }

#line default
#line hidden
#line 18 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Groups.cshtml"
   
  groupName = message.Group;
}

#line default
#line hidden
            BeginContext(364, 10, true);
            WriteLiteral("</ol>\n\n<p>");
            EndContext();
            BeginContext(375, 40, false);
#line 23 "/Users/patrickdelaney/Desktop/MessageBoardAPI/MessageBoardClient.Solution/MessageBoardClient/Views/Messages/Groups.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
            EndContext();
            BeginContext(415, 4, true);
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
