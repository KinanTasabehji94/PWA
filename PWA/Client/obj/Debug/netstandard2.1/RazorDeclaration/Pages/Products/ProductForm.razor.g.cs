#pragma checksum "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Products\ProductForm.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e098584061ad6a2ed7ec1a70cd703a9f9052ae7e"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class ProductForm : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 96 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Products\ProductForm.razor"
       
    [Parameter] public SubCategory subCategory { get; set; }
    [Parameter] public Product product { get; set; }

    [Parameter] public string Action { get; set; }
    [Parameter] public EventCallback onValidSubmit { get; set; }
    private string imageURL;
    private int categoryId;
    private List<Category> categories;
    private List<SubCategory> subCategories;
    private List<SubCategory> newsubCategories;


    protected override void OnInitialized()
    {
        if (!string.IsNullOrEmpty(product.Image))
        {
            imageURL = product.Image;
            product.Image = null;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        categories = await categoryRepository.GetCategories();
        subCategories = await subCategoryRepository.GetSubCategories();
    }
    private async Task OnChange(int categoryId)
    {
        Console.WriteLine("Hello");
        newsubCategories =subCategories.Where(s => s.CategoryId == categoryId).ToList();
        foreach (var item in newsubCategories)
        {
            Console.WriteLine(item.Name);

        }
        Console.WriteLine("World");


    }



    private void PictureSelected(string imageBase64)
    {
        product.Image = imageBase64;
        imageURL = null;
        Console.WriteLine(imageBase64);
    }



    protected async Task GetSubByCat()
    {
        subCategories = await subCategoryRepository.GetSubCategoriesByCategory(8);
        await Task.Delay(3000);
        foreach (var item in subCategories)
        {
            Console.WriteLine(item.Name);

        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime js { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProduct productRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISubCategory subCategoryRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategory categoryRepository { get; set; }
    }
}
#pragma warning restore 1591
