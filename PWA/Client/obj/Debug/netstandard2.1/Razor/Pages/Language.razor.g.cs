#pragma checksum "C:\Users\ENG\Source\Repos\PWANew\PWA\Client\Pages\Language.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "991c8367568903a22dcd500399abacdee0af8910"
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
#line 1 "C:\Users\ENG\Source\Repos\PWANew\PWA\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ENG\Source\Repos\PWANew\PWA\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ENG\Source\Repos\PWANew\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ENG\Source\Repos\PWANew\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ENG\Source\Repos\PWANew\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ENG\Source\Repos\PWANew\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ENG\Source\Repos\PWANew\PWA\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ENG\Source\Repos\PWANew\PWA\Client\_Imports.razor"
using PWA.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ENG\Source\Repos\PWANew\PWA\Client\_Imports.razor"
using PWA.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ENG\Source\Repos\PWANew\PWA\Client\_Imports.razor"
using PWA.Client.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ENG\Source\Repos\PWANew\PWA\Client\_Imports.razor"
using PWA.Client.Repositories.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ENG\Source\Repos\PWANew\PWA\Client\_Imports.razor"
using PWA.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ENG\Source\Repos\PWANew\PWA\Client\_Imports.razor"
using PWA.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ENG\Source\Repos\PWANew\PWA\Client\_Imports.razor"
using PWA.Client.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/language")]
    public partial class Language : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<PWA.Client.Shared.Header>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n    ");
            __builder.AddMarkupContent(2, "<div class=\"page-content-wrapper\">\r\n        <div class=\"container\">\r\n            \r\n            <div class=\"language-area-wrapper py-3\">\r\n                <ul>\r\n                    <li>\r\n                        <input id=\"eng\" type=\"radio\" name=\"selector\" checked>\r\n                        <label for=\"eng\">English</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Afrikaans\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Afrikaans\">Afrikaans</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Albanian\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Albanian\">Albanian</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Arabic\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Arabic\">Arabic</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Azerbaijani\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Azerbaijani\">Azerbaijani</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Belarusian\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Belarusian\">Belarusian</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Bengali\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Bengali\">Bengali</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Bulgarian\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Bulgarian\">Bulgarian</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Catalan\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Catalan\">Catalan</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Cebuano\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Cebuano\">Cebuano</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Chichewa\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Chichewa\">Chichewa</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Dutch\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Dutch\">Dutch</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Filipino\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Filipino\">Filipino</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"French\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"French\">French</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"German\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"German\">German</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Hebrew\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Hebrew\">Hebrew</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Hindi\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Hindi\">Hindi</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Indonesian\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Indonesian\">Indonesian</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Italian\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Italian\">Italian</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Latvian\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Latvian\">Latvian</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                    <li>\r\n                        <input id=\"Malayalam\" type=\"radio\" name=\"selector\">\r\n                        <label for=\"Malayalam\">Malayalam</label>\r\n                        <div class=\"check\"></div>\r\n                    </li>\r\n                </ul>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n    ");
            __builder.OpenComponent<PWA.Client.Shared.Footer>(3);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
