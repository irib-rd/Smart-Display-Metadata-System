#pragma checksum "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1772f81e3f1a4ad74f62544835081dec1a0f394b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Videos_Player_990820), @"mvc.1.0.view", @"/Views/Videos/Player-990820.cshtml")]
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
#line 1 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\_ViewImports.cshtml"
using videoSitecore2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\_ViewImports.cshtml"
using videoSitecore2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1772f81e3f1a4ad74f62544835081dec1a0f394b", @"/Views/Videos/Player-990820.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ae90efb981cdeb45e846e794aff95ca85de3796", @"/Views/_ViewImports.cshtml")]
    public class Views_Videos_Player_990820 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<videoSitecore2.Models.Videoview>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline-danger btn-rounded btn-sm my-0 waves-effect"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
  
    ViewData["Title"] = "Player";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1772f81e3f1a4ad74f62544835081dec1a0f394b4114", async() => {
                WriteLiteral("\r\n    بازگشت\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n<div class=\"list-group-item list-group-item-action flex-column align-items-start\">\r\n\r\n    <div class=\"d-flex w-100 justify-content-between\">\r\n        <h4 class=\"mb-1\">   ");
#nullable restore
#line 17 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
                       Write(Model.First().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n\r\n    <small class=\"text-muted\">\r\n        ");
#nullable restore
#line 21 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
   Write(Model.First().Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </small>\r\n</div>\r\n\r\n\r\n<div style=\"height: 450px;\">\r\n    <div id=\"defaultPlayer\"></div>\r\n</div>\r\n<div id=\"timeline\"></div>\r\n\r\n");
#nullable restore
#line 31 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
 foreach (var item in Model)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("<script>\r\n\r\n    var location1 = \"");
#nullable restore
#line 36 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
                Write(Html.Raw((Model.First().Location).Replace("\\", "/")));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""";
   // var zsmpath = ""./Hoshno/"" + location1;


    var zsmpath2 = ""http://172.16.0.182/vp/Hoshno/"" + location1;
   //   var zsmpath2 = ""https://localhost/vp/Hoshno/"" + location1;
     //var zsmpath2 = url2+ ""/Hoshno/"" + location1;


   //  var location2 = """);
#nullable restore
#line 45 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
                   Write(Html.Raw((Model.First().Location).Replace("\\", "\\\\")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n   //  var zsmpathtest = \"C:\\\\Hoshno\\\\\" + location2;\r\n\r\n\r\n\r\n\r\n    var url1 = \"");
#nullable restore
#line 51 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
           Write(Context.Request.Host);

#line default
#line hidden
#nullable disable
#nullable restore
#line 51 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
                                Write(Context.Request.PathBase);

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    var id1 = \"");
#nullable restore
#line 52 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
          Write(Html.Raw(Model.First().Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n\r\n         if (");
#nullable restore
#line 54 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
        Write(Html.Raw(item.metaDataTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("== 2) {\r\n\r\n\r\n         var zsmlistline = [\r\n\r\n\r\n             { title: \"");
#nullable restore
#line 60 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
                  Write(Html.Raw(item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\", type: \'segment\', metadataId: ");
#nullable restore
#line 60 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
                                                                       Write(item.metadataTitleId);

#line default
#line hidden
#nullable disable
            WriteLiteral(", color: \'#F00\'},\r\n\r\n    ];\r\n\r\n\r\n        var zsmjsonfile = [\r\n         \r\n            \r\n                \'https://\' + url1 + \'/Videos/startTimeEventSegmenTtype/\' + ");
#nullable restore
#line 68 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
                                                                      Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + \'?metadataTitleId=\' + ");
#nullable restore
#line 68 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
                                                                                                       Write(item.metadataTitleId);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n            \r\n        \r\n    ];\r\n    }\r\n    else {\r\n\r\n     var zsmlistline = [\r\n\r\n\r\n             { title: \"");
#nullable restore
#line 78 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
                  Write(Html.Raw(item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\", type: \'cuepoint\', metadataId: ");
#nullable restore
#line 78 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
                                                                        Write(item.metadataTitleId);

#line default
#line hidden
#nullable disable
            WriteLiteral(", color: \'#3CF\', pointNav: true },\r\n\r\n    ];\r\n\r\n\r\n\r\n             var zsmjsonfile = [\r\n\r\n                \r\n           \'https://\' + url1 + \'/Videos/startTimeEventSegmenTtype/\' + ");
#nullable restore
#line 87 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
                                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + \'?metadataTitleId=\' + ");
#nullable restore
#line 87 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"
                                                                                                  Write(item.metadataTitleId);

#line default
#line hidden
#nullable disable
            WriteLiteral(@",

        


        ];
    }

    $(function () {

                $(""#defaultPlayer"").mediaPlayer({
                autoplay: false,
                 src: zsmpath2,
                controlBar:
                {
                    sticky: true
                },
                plugins: {
                    dataServices: zsmjsonfile,
                    list: [
                        {
                            'className': 'fr.ina.amalia.player.plugins.TimelinePlugin',
                            'container': '#timeline',
                            'parameters': {
                                listOfLines: zsmlistline
                            }
                        }
                    ]
                }

            });

    } );
</script>
");
#nullable restore
#line 121 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990820.cshtml"

}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<videoSitecore2.Models.Videoview>> Html { get; private set; }
    }
}
#pragma warning restore 1591
