#pragma checksum "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\Profile.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74455afdc8a7689407c93e22397e4a4c69c4dcf3"
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
#nullable restore
#line 11 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Repositories.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using PWA.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using PWA.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/profile")]
    public partial class Profile : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<PWA.Client.Shared.Header>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.AddMarkupContent(2, "<div class=\"page-content-wrapper\">\r\n    <div class=\"container\">\r\n        \r\n        <div class=\"profile-wrapper-area py-3\">\r\n            \r\n            <div class=\"card user-info-card\">\r\n                <div class=\"card-body p-4 d-flex align-items-center\">\r\n                    <div class=\"user-profile mr-3\"><img src=\"img/bg-img/9.jpg\" alt></div>\r\n                    <div class=\"user-info\">\r\n                        <p class=\"mb-0 text-white\">designing-world</p>\r\n                        <h5 class=\"mb-0\">Suha Jannat</h5>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            \r\n            <div class=\"card user-data-card\">\r\n                <div class=\"card-body\">\r\n                    <div class=\"single-profile-data d-flex align-items-center justify-content-between\">\r\n                        <div class=\"title d-flex align-items-center\"><i class=\"lni-user\"></i><span>Username</span></div>\r\n                        <div class=\"data-content\">designing-world</div>\r\n                    </div>\r\n                    <div class=\"single-profile-data d-flex align-items-center justify-content-between\">\r\n                        <div class=\"title d-flex align-items-center\"><i class=\"lni-user\"></i><span>Full Name</span></div>\r\n                        <div class=\"data-content\">SUHA JANNAT</div>\r\n                    </div>\r\n                    <div class=\"single-profile-data d-flex align-items-center justify-content-between\">\r\n                        <div class=\"title d-flex align-items-center\"><i class=\"lni-phone-handset\"></i><span>Phone</span></div>\r\n                        <div class=\"data-content\">+880 000 111 222</div>\r\n                    </div>\r\n                    <div class=\"single-profile-data d-flex align-items-center justify-content-between\">\r\n                        <div class=\"title d-flex align-items-center\"><i class=\"lni-envelope\"></i><span>Email Address</span></div>\r\n                        <div class=\"data-content\">care@example.com                                </div>\r\n                    </div>\r\n                    <div class=\"single-profile-data d-flex align-items-center justify-content-between\">\r\n                        <div class=\"title d-flex align-items-center\"><i class=\"lni-map-marker\"></i><span>Shipping</span></div>\r\n                        <div class=\"data-content\">28/C Green Road, BD</div>\r\n                    </div>\r\n                    <div class=\"single-profile-data d-flex align-items-center justify-content-between\">\r\n                        <div class=\"title d-flex align-items-center\"><i class=\"lni-star\"></i><span>My Order</span></div>\r\n                        <div class=\"data-content\"><a class=\"btn btn-danger btn-sm\" href=\"my-order.html\">View</a></div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n            \r\n            <div class=\"edit-profile-btn mt-3\"><a class=\"btn btn-info w-100\" href=\"edit-profile.html\"><i class=\"lni-pencil mr-2\"></i>Edit Profile</a></div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            __builder.OpenComponent<PWA.Client.Shared.Footer>(3);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
