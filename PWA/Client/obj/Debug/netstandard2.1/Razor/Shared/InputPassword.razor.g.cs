#pragma checksum "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\InputPassword.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3b09ae69ae1c7a5c25b8c68f298ed2dae457bea"
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
    public partial class InputPassword : InputBase<string>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "password");
            __builder.AddAttribute(2, "class", 
#nullable restore
#line 3 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\InputPassword.razor"
                                                     CssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "placeholder", "***********");
            __builder.AddAttribute(4, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 3 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\InputPassword.razor"
                               CurrentValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => CurrentValue = __value, CurrentValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 5 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\InputPassword.razor"
        protected override bool TryParseValueFromString(string value, out string result,
            out string validationErrorMessage)
    {
        result = value;
        validationErrorMessage = null;
        return true;
    } 

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591