#pragma checksum "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Playerbak990430.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2b8ca4485efbbf98284f2de8106d7b8449a287c4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Videos_Playerbak990430), @"mvc.1.0.view", @"/Views/Videos/Playerbak990430.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b8ca4485efbbf98284f2de8106d7b8449a287c4", @"/Views/Videos/Playerbak990430.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ae90efb981cdeb45e846e794aff95ca85de3796", @"/Views/_ViewImports.cshtml")]
    public class Views_Videos_Playerbak990430 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<videoSitecore2.Models.Videoview>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Playerbak990430.cshtml"
  
    ViewData["Title"] = "Play";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Play</h1>\r\n\r\n<div>\r\n    <h4>Videos</h4>\r\n    <hr />\r\n\r\n\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            name:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Playerbak990430.cshtml"
       Write(Model.First().Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            location:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Playerbak990430.cshtml"
       Write(Model.First().Location);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n        <dt class=\"col-sm-2\">\r\n            discription:\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Playerbak990430.cshtml"
       Write(Model.First().Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n\r\n    </dl>\r\n</div>\r\n\r\n\r\n<script type=\"text/javascript\">\r\n\r\n    //var students = \"");
#nullable restore
#line 43 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Playerbak990430.cshtml"
                 Write(Html.Raw(Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\";\r\n  //  var students = JSON.parse(\'");
#nullable restore
#line 44 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Playerbak990430.cshtml"
                            Write(Html.Raw(Model.ToList()));

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n\r\n   // var StartTime = \'");
#nullable restore
#line 46 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Playerbak990430.cshtml"
                  Write(Html.Raw(Model.First().StartTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n    //alert(\'StartTime: \' + StartTime);\r\n\r\n\r\n   // var data = JSON.parse(students);\r\n  //  alert(\'data.length: \' + data.length);\r\n  //  for (var i = 0; i < data.length; i++) {\r\n    //    var student = data[i];\r\n\r\n\r\n\r\n   // var students = ");
#nullable restore
#line 57 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Playerbak990430.cshtml"
                Write(Html.Raw(Json.Serialize(Model)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n  //  var students = JSON.parse(\'");
#nullable restore
#line 58 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Playerbak990430.cshtml"
                            Write(Html.Raw(Json.Serialize(@Model)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"');
  //  for (var i = 0; i < students.length; i++) {
   //     var student = students[i];
   //  alert('StartTime: ' + student.StartTime + ' Location:' + student.Location);

  //  }



</script>


   

<div style=""height: 450px;"">
    <div id=""defaultPlayer""></div>
</div>
<div id=""timeline""></div>

<script>

    //var location1 = '");
#nullable restore
#line 79 "C:\Users\Administrator\source\repos\videoSitecore2\videoSitecore2\Views\Videos\Playerbak990430.cshtml"
                  Write(Html.Raw(Model.First().Location));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"';


    $(function () {
        $(""#defaultPlayer"").mediaPlayer({
            autoplay: false,
          //  src: location1,
            src: ""amalia01.mp4"",
            controlBar:
            {
                sticky: true
            },
            plugins: {
                dataServices: [
                    //'amalia01-events.json',
                    'https://localhost:44380/Videos/startTimeEvent/1',
                    'amalia01-kf.json',
                    'amalia01-ball.json'
                ],
                list: [
                    {
                        'className': 'fr.ina.amalia.player.plugins.TimelinePlugin',
                        'container': '#timeline',
                        'parameters': {
                            listOfLines: [
                                {
                                    title: 'Events 1',
                                    type: 'cuepoint',
                                    metadataId: 'events-amalia01',
         ");
            WriteLiteral(@"                           color: '#3CF',
                                    pointNav: true
                                },
                                {
                                    title: 'Events 2',
                                    type: 'cuepoint',
                                    metadataId: 'events-amalia02',
                                    color: '#3CF',
                                    pointNav: true
                                },
                                {
                                    title: 'Events 3',
                                    type: 'cuepoint',
                                    metadataId: 'events-amalia03',
                                    color: '#3CF',
                                    pointNav: true
                                }

                            ]
                        }
                    }
                ]
            }
        });
    });
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
