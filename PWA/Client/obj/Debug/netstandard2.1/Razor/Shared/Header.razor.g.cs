#pragma checksum "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\Header.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57f23775f31d70dfd23cae00b31dcbe3644788bc"
// <auto-generated/>
#pragma warning disable 1591
namespace PWA.Client.Shared
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
    public partial class Header : Microsoft.AspNetCore.Components.ComponentBase
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
            __builder.AddMarkupContent(7, "<div class=\"logo-wrapper\"><a href=\"home.html\"><img src=\"img/core-img/logo-small.png\" alt></a></div>\r\n        \r\n        ");
            __builder.AddMarkupContent(8, @"<div class=""top-search-form"">
            <form action=""#"" method=""POST"">
                <input class=""form-control"" type=""search"" placeholder=""Enter your keyword"">
                <button type=""submit""><i class=""fa fa-search""></i></button>
            </form>
        </div>
        
        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "suha-navbar-toggler d-flex justify-content-between flex-wrap");
            __builder.AddAttribute(11, "id", "suhaNavbarToggler");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\Header.razor"
                                                                                                                   NavbarToggler

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "<span></span><span></span><span></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n\r\n");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "sidenav-black-overlay");
            __builder.AddAttribute(19, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\Header.razor"
                                             SidenavBlackOverlay

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n\r\n");
            __builder.OpenElement(21, "div");
            __builder.AddAttribute(22, "class", "suha-sidenav-wrapper");
            __builder.AddAttribute(23, "id", "sidenavWrapper");
            __builder.AddMarkupContent(24, "\r\n    \r\n    ");
            __builder.AddMarkupContent(25, @"<div class=""sidenav-profile"">
        <div class=""user-profile""><img src=""img/bg-img/9.jpg"" alt></div>
        <div class=""user-info"">
            <h6 class=""user-name mb-0"">Suha Jannat</h6>
            <p class=""available-balance"">Balance <span>$<span class=""counter"">379.23</span></span></p>
        </div>
    </div>
    
    ");
            __builder.AddMarkupContent(26, @"<ul class=""sidenav-nav"">
        <li><a href=""profile""><i class=""lni-user""></i>My Profile</a></li>
        <li><a href=""notifications.html""><i class=""lni-alarm lni-tada-effect""></i>Notifications<span class=""ml-3 badge badge-warning"">3</span></a></li>
        <li><a href=""pages.html""><i class=""lni-empty-file""></i>All Pages</a></li>
        <li><a href=""wishlist-grid.html""><i class=""lni-heart-filled""></i>My Wishlist</a></li>
        <li><a href=""settings""><i class=""lni-cog""></i>Settings</a></li>
        <li><a href=""intro.html""><i class=""lni-power-switch""></i>Sign Out</a></li>
    </ul>
    
    ");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "go-home-btn");
            __builder.AddAttribute(29, "id", "goHomeBtn");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 41 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\Header.razor"
                                                      goHomeBtn

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "<i class=\"lni-arrow-left\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\Header.razor"
       
    protected async Task NavbarToggler()
    {
        await js.InvokeVoidAsync("NavbarToggler");
    }
    protected async Task goHomeBtn()
    {
        await js.InvokeVoidAsync("goHomeBtn");
    }
    protected async Task SidenavBlackOverlay()
    {
        await js.InvokeVoidAsync("SidenavBlackOverlay");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
    }
}
#pragma warning restore 1591
