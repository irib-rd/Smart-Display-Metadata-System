#pragma checksum "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94f9daba9b8c0b5a5679ff1e285685f7cf95c804"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Videos_Player_990513), @"mvc.1.0.view", @"/Views/Videos/Player-990513.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94f9daba9b8c0b5a5679ff1e285685f7cf95c804", @"/Views/Videos/Player-990513.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ae90efb981cdeb45e846e794aff95ca85de3796", @"/Views/_ViewImports.cshtml")]
    public class Views_Videos_Player_990513 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<videoSitecore2.Models.Videoview>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
  
    ViewData["Title"] = "Play";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Play</h1>\r\n\r\n\r\n<div>\r\n    <h4>Videos</h4>\r\n    <hr />\r\n");
#nullable restore
#line 12 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
     foreach (var item in Model)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("<dl class=\"row\">\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 18 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
   Write(Html.DisplayNameFor(model => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 21 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
   Write(Html.DisplayFor(model => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 24 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
   Write(Html.DisplayNameFor(model => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 27 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
   Write(Html.DisplayFor(model => item.Location));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 30 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
   Write(Html.DisplayNameFor(model => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 33 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
   Write(Html.DisplayFor(model => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n\r\n\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 38 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
   Write(Html.DisplayNameFor(model => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 41 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
   Write(Html.DisplayFor(model => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n\r\n    <dt class=\"col-sm-2\">\r\n        ");
#nullable restore
#line 45 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
   Write(Html.DisplayNameFor(model => item.metadataTitleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dt>\r\n    <dd class=\"col-sm-10\">\r\n        ");
#nullable restore
#line 48 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
   Write(Html.DisplayFor(model => item.metadataTitleId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </dd>\r\n    \r\n\r\n</dl>\r\n");
#nullable restore
#line 53 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "94f9daba9b8c0b5a5679ff1e285685f7cf95c8047565", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n<div>\r\n    <h4>Videos</h4>\r\n    <hr />\r\n\r\n\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            name:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
       Write(Model.First().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            location:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 80 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
       Write(Model.First().Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </dd>\r\n\r\n\r\n        <dt class=\"col-sm-2\">\r\n            discription:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
       Write(Model.First().Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n    </dl>\r\n</div>\r\n\r\n\r\n<script type=\"text/javascript\">\r\n\r\n\r\n\r\n    var videos = [\r\n");
#nullable restore
#line 102 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
       foreach (var item in Model)
      {


#line default
#line hidden
#nullable disable
            WriteLiteral("          ");
            WriteLiteral("{ id1: ");
#nullable restore
#line 105 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
              Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,title1:\"");
#nullable restore
#line 105 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
                                Write(Html.Raw(item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\", metadatatitleId1:  ");
#nullable restore
#line 105 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
                                                                           Write(item.metadataTitleId);

#line default
#line hidden
#nullable disable
            WriteLiteral(" },\r\n");
#nullable restore
#line 106 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"



      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    ];\r\n\r\n\r\n    var zsmlistline = [\r\n");
#nullable restore
#line 114 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
          foreach (var item in Model)
         {


#line default
#line hidden
#nullable disable
            WriteLiteral("             ");
            WriteLiteral("{ title: \"");
#nullable restore
#line 117 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
                    Write(Html.Raw(item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\", type: \'cuepoint\', metadataId: ");
#nullable restore
#line 117 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
                                                                          Write(item.metadataTitleId);

#line default
#line hidden
#nullable disable
            WriteLiteral(", color: \'#3CF\', pointNav: true },\r\n");
#nullable restore
#line 118 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    ];




          alert(' videos.length:' + videos.length);
         /* for (var i = 0; i < videos.length; i++) {
              var vid = videos[i];
              alert(' id1:' + vid.id1);
              alert(' title1:' + vid.title1);
              alert(' metadatatitleId1:' + vid.metadatatitleId1);

          }*/


</script>




<div style=""height: 450px;"">
    <div id=""defaultPlayer""></div>
</div>
<div id=""timeline""></div>

<script>

 // var location1 = """);
#nullable restore
#line 146 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
                Write(Html.Raw((Model.First().Location).Replace("\\", "/").Replace(".mp4", "")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    var location1 = \"");
#nullable restore
#line 147 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
                Write(Html.Raw((Model.First().Location).Replace("\\", "/")));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    var path = \"./Hoshno/\" + location1;\r\n\r\n    var url1 = window.location.host;\r\n    var id1 = \"");
#nullable restore
#line 151 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
          Write(Html.Raw(Model.First().Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n    var jsonfile = \'https://\'+url1+\'/Videos/startTimeEvent/\' + id1;\r\n\r\n    var jsonfile2 = \'https://\' + url1 + \'/Videos/startTimeEvent/\' + id1 + \'?metadataTitleId=14\';\r\n\r\n    var zsmjsonfile = [\r\n");
#nullable restore
#line 157 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
          foreach (var item in Model)
         {

#line default
#line hidden
#nullable disable
            WriteLiteral("           ");
            WriteLiteral("\'https://\' + url1 + \'/Videos/startTimeEvent2/\' + ");
#nullable restore
#line 159 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
                                                         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + \'?metadataTitleId=\'+ ");
#nullable restore
#line 159 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"
                                                                                         Write(item.metadataTitleId);

#line default
#line hidden
#nullable disable
            WriteLiteral(",\r\n");
#nullable restore
#line 160 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Player-990513.cshtml"

        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    ];
     


  //  alert(jsonfile);
    //alert(""The URL of this page is: "" + url1);
    $(function () {

                $(""#defaultPlayer"").mediaPlayer({
                autoplay: false,
                //  src: location1,
                src: path,
                controlBar:
                {
                    sticky: true
                },
                plugins: {
                    dataServices: [

                        jsonfile
                    ],
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