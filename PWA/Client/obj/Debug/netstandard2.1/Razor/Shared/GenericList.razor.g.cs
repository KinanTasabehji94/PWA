#pragma checksum "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "480d8441ea3ada4ff5995130fc77568fa96bc36b"
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
    public partial class GenericList<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
 if (List == null)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
     if (NullTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, 
#nullable restore
#line 7 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
         NullTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 7 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
                     
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "        \r\n        ");
            __builder.AddMarkupContent(2, "<div class=\"preloader\" id=\"preloader\">\r\n            <div class=\"spinner-grow text-secondary\" role=\"status\">\r\n                <div class=\"sr-only\">Loading...</div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 17 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
     
}
else if (List.Count == 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
     if (EmptyTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, 
#nullable restore
#line 23 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
         EmptyTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 23 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
                      
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "There are no data to show");
#nullable restore
#line 27 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
                                              
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
     
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
     if (ElementTemplate != null)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
         foreach (var element in List)
        {
            

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, 
#nullable restore
#line 36 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
             ElementTemplate(element)

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 36 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
                                     
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
         
    }
    else
    {
        

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, 
#nullable restore
#line 41 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
         WholeListTemplate

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 41 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
                          
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Shared\GenericList.razor"
       
    [Parameter] public RenderFragment NullTemplate { get; set; }
    [Parameter] public RenderFragment EmptyTemplate { get; set; }
    [Parameter] public RenderFragment<TItem> ElementTemplate { get; set; }
    [Parameter] public RenderFragment WholeListTemplate { get; set; }
    [Parameter] public List<TItem> List { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591