#pragma checksum "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\Settings.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b4437f8bcaeb1081f15d3a04d9b58b8623312f5"
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "header-area");
            __builder.AddAttribute(2, "id", "headerArea");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "container h-100 d-flex align-items-center justify-content-between");
            __builder.AddMarkupContent(6, "\r\n        \r\n        ");
            __builder.AddMarkupContent(7, "<div class=\"logo-wrapper\"><a href=\"home.html\"><img src=\"/img/core-img/logo-small.png\" alt></a></div>\r\n        \r\n        ");
            __builder.AddMarkupContent(8, @"<div class=""top-search-form"">
            <form action=""#"" method=""POST"">
                <input class=""form-control"" type=""search"" placeholder=""Enter your keyword"">
                <button type=""submit""><i class=""fa fa-search""></i></button>
            </form>
        </div>
        
        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "suha-navbar-toggler d-flex justify-content-between flex-wrap");
            __builder.AddAttribute(11, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\Settings.razor"
                                                                                            CallJSMethod

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "id", "suhaNavbarToggler");
            __builder.AddMarkupContent(13, "<span></span><span></span><span></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n<div class=\"sidenav-black-overlay\"></div>\r\n\r\n");
            __builder.AddMarkupContent(17, @"<div class=""suha-sidenav-wrapper"" id=""sidenavWrapper"">
    
    <div class=""sidenav-profile"">
        <div class=""user-profile""><img src=""/img/bg-img/9.jpg"" alt></div>
        <div class=""user-info"">
            <h6 class=""user-name mb-0"">Suha Jannat</h6>
            <p class=""available-balance"">Balance <span>$<span class=""counter"">379.23</span></span></p>
        </div>
    </div>
    
    <ul class=""sidenav-nav"">
        <li><a href=""profile.html""><i class=""lni-user""></i>My Profile</a></li>
        <li><a href=""notifications.html""><i class=""lni-alarm lni-tada-effect""></i>Notifications<span class=""ml-3 badge badge-warning"">3</span></a></li>
        <li><a href=""pages.html""><i class=""lni-empty-file""></i>All Pages</a></li>
        <li><a href=""wishlist-grid.html""><i class=""lni-heart-filled""></i>My Wishlist</a></li>
        <li><a href=""settings.html""><i class=""lni-cog""></i>Settings</a></li>
        <li><a href=""intro.html""><i class=""lni-power-switch""></i>Sign Out</a></li>
    </ul>
    
    <div class=""go-home-btn"" id=""goHomeBtn""><i class=""lni-arrow-left""></i></div>
</div>
");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "page-content-wrapper");
            __builder.AddMarkupContent(20, "\r\n    ");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "container");
            __builder.AddMarkupContent(23, "\r\n        \r\n        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "settings-wrapper py-3");
            __builder.AddMarkupContent(26, "\r\n            ");
            __builder.AddMarkupContent(27, @"<div class=""card settings-card"">
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
            __builder.AddMarkupContent(28, @"<div class=""card settings-card"">
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
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "card settings-card");
            __builder.AddMarkupContent(31, "\r\n                ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "card-body");
            __builder.AddMarkupContent(34, "\r\n                    \r\n                    ");
            __builder.OpenElement(35, "div");
            __builder.AddAttribute(36, "class", "single-settings d-flex align-items-center justify-content-between");
            __builder.AddMarkupContent(37, "\r\n                        ");
            __builder.AddMarkupContent(38, "<div class=\"title\"><i class=\"lni-night\"></i><span>Night Mode</span></div>\r\n                        ");
            __builder.OpenElement(39, "div");
            __builder.AddAttribute(40, "class", "data-content");
            __builder.AddMarkupContent(41, "\r\n                            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "toggle-button-cover");
            __builder.AddMarkupContent(44, "\r\n                                ");
            __builder.OpenElement(45, "div");
            __builder.AddAttribute(46, "class", "button r");
            __builder.AddMarkupContent(47, "\r\n                                    ");
            __builder.OpenElement(48, "input");
            __builder.AddAttribute(49, "class", "checkbox");
            __builder.AddAttribute(50, "id", "darkSwitch");
            __builder.AddAttribute(51, "type", "checkbox");
            __builder.AddAttribute(52, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 90 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\Settings.razor"
                                                                                                       darkMode

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n                                    <div class=\"knobs\"></div>\r\n                                    <div class=\"layer\"></div>\r\n                                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(54, "\r\n                            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(55, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(56, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.AddMarkupContent(60, @"<div class=""card settings-card"">
                <div class=""card-body"">
                    
                    <div class=""single-settings d-flex align-items-center justify-content-between"">
                        <div class=""title""><i class=""lni-world""></i><span>Language</span></div>
                        <div class=""data-content""><a href=""language.html"">English<i class=""lni-chevron-right""></i></a></div>
                    </div>
                </div>
            </div>
            ");
            __builder.AddMarkupContent(61, @"<div class=""card settings-card"">
                <div class=""card-body"">
                    
                    <div class=""single-settings d-flex align-items-center justify-content-between"">
                        <div class=""title""><i class=""lni-question-circle""></i><span>Support</span></div>
                        <div class=""data-content""><a class=""pl-4"" href=""support.html""><i class=""lni-chevron-right""></i></a></div>
                    </div>
                </div>
            </div>
            ");
            __builder.AddMarkupContent(62, @"<div class=""card settings-card"">
                <div class=""card-body"">
                    
                    <div class=""single-settings d-flex align-items-center justify-content-between"">
                        <div class=""title""><i class=""lni-protection""></i><span>Privacy</span></div>
                        <div class=""data-content""><a class=""pl-4"" href=""privacy-policy.html""><i class=""lni-chevron-right""></i></a></div>
                    </div>
                </div>
            </div>
            ");
            __builder.AddMarkupContent(63, @"<div class=""card settings-card"">
                <div class=""card-body"">
                    
                    <div class=""single-settings d-flex align-items-center justify-content-between"">
                        <div class=""title""><i class=""lni-lock""></i><span>Password<span>Updated 2 month ago</span></span></div>
                        <div class=""data-content""><a href=""change-password.html"">Change<i class=""lni-chevron-right""></i></a></div>
                    </div>
                </div>
            </div>
        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(64, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(65, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(66, "\r\n\r\n");
            __builder.AddMarkupContent(67, "<div>\r\n    <p id=\"demop\">Hello</p>\r\n</div>\r\n\r\n\r\n");
            __builder.AddMarkupContent(68, @"<div class=""footer-nav-area"" id=""footerNav"">
    <div class=""suha-footer-nav h-100"">
        <ul class=""h-100 d-flex align-items-center justify-content-between"">
            <li class=""active""><a href=""home.html""><i class=""lni-home""></i>Home</a></li>
            <li><a href=""message.html""><i class=""lni-support""></i>Support</a></li>
            <li><a href=""cart.html""><i class=""lni-cart""></i>Cart</a></li>
            <li><a href=""pages.html""><i class=""lni-heart""></i>Pages</a></li>
            <li><a href=""settings.html""><i class=""lni-cog""></i>Settings</a></li>
        </ul>
    </div>
</div>");
        }
        #pragma warning restore 1998
#nullable restore
#line 156 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\Settings.razor"
       
    protected async Task CallJSMethod()
    {
        await js.InvokeVoidAsync("x");
    }
    protected async Task darkMode()
    {
        await js.InvokeVoidAsync("darkMode");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
