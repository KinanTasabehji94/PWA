#pragma checksum "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\Settings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7b742fb5dfba7228e1b5f3f1fa00a4c77bf5019"
// <auto-generated/>
#pragma warning disable 1591
namespace PWA.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using PWA.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/settings")]
    public partial class Settings : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<PWA.Client.Shared.Header>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "page-content-wrapper");
            __builder.AddMarkupContent(4, "\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.AddMarkupContent(7, "\r\n        \r\n        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "settings-wrapper py-3");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.AddMarkupContent(11, @"<div class=""card settings-card"">
                <div class=""card-body"">
                    
                    <div class=""single-settings d-flex align-items-center justify-content-between"">
                        <div class=""title""><i class=""lni-check-mark-circle""></i><span>Availability</span></div>
                        <div class=""data-content"">
                            <div class=""toggle-button-cover"">
                                <div class=""button r"">
                                    <input class=""checkbox"" type=""checkbox"" checked>
                                    <div class=""knobs""></div>
                                    <div class=""layer""></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            ");
            __builder.AddMarkupContent(12, @"<div class=""card settings-card"">
                <div class=""card-body"">
                    
                    <div class=""single-settings d-flex align-items-center justify-content-between"">
                        <div class=""title""><i class=""lni-alarm""></i><span>Notifications</span></div>
                        <div class=""data-content"">
                            <div class=""toggle-button-cover"">
                                <div class=""button r"">
                                    <input class=""checkbox"" type=""checkbox"" checked>
                                    <div class=""knobs""></div>
                                    <div class=""layer""></div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "card settings-card");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "card-body");
            __builder.AddMarkupContent(18, "\r\n                    \r\n                    ");
            __builder.OpenElement(19, "div");
            __builder.AddAttribute(20, "class", "single-settings d-flex align-items-center justify-content-between");
            __builder.AddMarkupContent(21, "\r\n                        ");
            __builder.AddMarkupContent(22, "<div class=\"title\"><i class=\"lni-night\"></i><span>Night Mode</span></div>\r\n                        ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "class", "data-content");
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "toggle-button-cover");
            __builder.AddMarkupContent(28, "\r\n                                ");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "button r");
            __builder.AddMarkupContent(31, "\r\n                                    ");
            __builder.OpenElement(32, "input");
            __builder.AddAttribute(33, "class", "checkbox");
            __builder.AddAttribute(34, "id", "darkSwitch");
            __builder.AddAttribute(35, "type", "checkbox");
            __builder.AddAttribute(36, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\Settings.razor"
                                                                                                       darkMode

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n                                    <div class=\"knobs\"></div>\r\n                                    <div class=\"layer\"></div>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n            ");
            __builder.AddMarkupContent(44, @"<div class=""card settings-card"">
                <div class=""card-body"">
                    
                    <div class=""single-settings d-flex align-items-center justify-content-between"">
                        <div class=""title""><i class=""lni-world""></i><span>Language</span></div>
                        <div class=""data-content""><a href=""language"">English<i class=""lni-chevron-right""></i></a></div>
                    </div>
                </div>
            </div>
            ");
            __builder.AddMarkupContent(45, @"<div class=""card settings-card"">
                <div class=""card-body"">
                    
                    <div class=""single-settings d-flex align-items-center justify-content-between"">
                        <div class=""title""><i class=""lni-question-circle""></i><span>Support</span></div>
                        <div class=""data-content""><a class=""pl-4"" href=""support.html""><i class=""lni-chevron-right""></i></a></div>
                    </div>
                </div>
            </div>
            ");
            __builder.AddMarkupContent(46, @"<div class=""card settings-card"">
                <div class=""card-body"">
                    
                    <div class=""single-settings d-flex align-items-center justify-content-between"">
                        <div class=""title""><i class=""lni-protection""></i><span>Privacy</span></div>
                        <div class=""data-content""><a class=""pl-4"" href=""privacy""><i class=""lni-chevron-right""></i></a></div>
                    </div>
                </div>
            </div>
            ");
            __builder.AddMarkupContent(47, @"<div class=""card settings-card"">
                <div class=""card-body"">
                    
                    <div class=""single-settings d-flex align-items-center justify-content-between"">
                        <div class=""title""><i class=""lni-lock""></i><span>Password<span>Updated 2 month ago</span></span></div>
                        <div class=""data-content""><a href=""changePassword"">Change<i class=""lni-chevron-right""></i></a></div>
                    </div>
                </div>
            </div>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n\r\n");
            __builder.OpenComponent<PWA.Client.Shared.Footer>(51);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 105 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\Settings.razor"
       

    protected async Task darkMode()
    {
        await js.InvokeVoidAsync("darkMode");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
