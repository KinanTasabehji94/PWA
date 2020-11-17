#pragma checksum "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Products\CreateProduct.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "afe359b8a1a70f0ae0f1f4a219d94593e5ba6253"
// <auto-generated/>
#pragma warning disable 1591
namespace PWA.Client.Pages.Products
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using PWA.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Auth;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Repositories.Interface;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using PWA.Shared.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using PWA.Shared.Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using PWA.Client.Repositories.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ENG\Desktop\PWA\PWA\Client\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/product/create")]
    public partial class CreateProduct : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<PWA.Client.Shared.Header>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenComponent<PWA.Client.Pages.Products.ProductForm>(2);
            __builder.AddAttribute(3, "product", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<PWA.Shared.Entities.Product>(
#nullable restore
#line 7 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Products\CreateProduct.razor"
                       product

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(4, "Action", "Create");
            __builder.AddAttribute(5, "onValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 7 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Products\CreateProduct.razor"
                                                               Create

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.AddMarkupContent(6, "\r\n\r\n");
            __builder.OpenComponent<PWA.Client.Shared.Footer>(7);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 11 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Products\CreateProduct.razor"
       
    private Product product = new Product();
    //private SubCategory subCategory = new SubCategory();


    private async Task Create()
    {
        try
        {
            await productRepository.CreateProduct(product);
            navigationManager.NavigateTo("products");
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProduct productRepository { get; set; }
    }
}
#pragma warning restore 1591
