#pragma checksum "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f179e27b4414614e8841d7c38e2a6d1b5601aed0"
// <auto-generated/>
#pragma warning disable 1591
namespace PWA.Client.Pages.SubCategories
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/SubCategories")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/SubCategories/index")]
    public partial class IndexSubCategory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<PWA.Client.Shared.Header>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n<br>\r\n<br>\r\n<br>\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "container");
            __builder.AddMarkupContent(4, "\r\n    ");
            __Blazor.PWA.Client.Pages.SubCategories.IndexSubCategory.TypeInference.CreateTelerikListView_0(__builder, 5, 6, 
#nullable restore
#line 11 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                           subCategories

#line default
#line hidden
#nullable disable
            , 7, 
#nullable restore
#line 11 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                   true

#line default
#line hidden
#nullable disable
            , 8, 
#nullable restore
#line 11 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                                   5

#line default
#line hidden
#nullable disable
            , 9, (__builder2) => {
                __builder2.AddMarkupContent(10, "\r\n            ");
                __builder2.OpenElement(11, "a");
                __builder2.AddAttribute(12, "href", "/subcategory/create");
                __builder2.AddAttribute(13, "style", "margin-left:20px;");
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikButton>(14);
                __builder2.AddAttribute(15, "Icon", "add");
                __builder2.AddAttribute(16, "Class", "btn-primary");
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(18, "Add");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(19, "\r\n            ");
                __builder2.AddMarkupContent(20, "<h3 style=\"text-align:center; color:black\">\r\n                Subcategories\r\n            </h3>\r\n        ");
            }
            , 21, (context) => (__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n            ");
                __builder2.OpenElement(23, "div");
                __builder2.AddAttribute(24, "class", "k-card k-card-horizontal");
                __builder2.AddMarkupContent(25, "\r\n                ");
                __builder2.OpenElement(26, "div");
                __builder2.AddAttribute(27, "class", "k-vbox k-column");
                __builder2.AddMarkupContent(28, "\r\n                    ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "k-card-body");
                __builder2.AddMarkupContent(31, "\r\n                        ");
                __builder2.OpenElement(32, "h3");
                __builder2.AddAttribute(33, "class", "k-card-title");
                __builder2.AddAttribute(34, "style", "color:black");
                __builder2.AddContent(35, 
#nullable restore
#line 22 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                                      context.Category.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(36, "\r\n                        ");
                __builder2.OpenElement(37, "h4");
                __builder2.AddAttribute(38, "class", "k-card-title");
                __builder2.AddAttribute(39, "style", "color:black");
                __builder2.AddContent(40, 
#nullable restore
#line 23 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                                      context.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                        ");
                __builder2.OpenElement(42, "h5");
                __builder2.AddAttribute(43, "class", "k-card-subtitle");
                __builder2.AddAttribute(44, "style", "color:grey");
                __builder2.AddContent(45, 
#nullable restore
#line 24 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                                        context.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n                    ");
                __builder2.OpenElement(48, "div");
                __builder2.AddAttribute(49, "class", "k-card-actions k-card-actions-horizontal k-card-actions-start");
                __builder2.AddMarkupContent(50, "\r\n                        ");
                __builder2.OpenElement(51, "a");
                __builder2.AddAttribute(52, "href", "/subcategory/Edit/" + (
#nullable restore
#line 28 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                    context.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.OpenComponent<Telerik.Blazor.Components.TelerikButton>(53);
                __builder2.AddAttribute(54, "Icon", "edit");
                __builder2.AddAttribute(55, "Class", "btn-dark");
                __builder2.AddAttribute(56, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(57, "Edit");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(58, "\r\n                        &nbsp;&nbsp;\r\n                        ");
                __builder2.OpenComponent<PWA.Client.Shared.ConfirmButton>(59);
                __builder2.AddAttribute(60, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 30 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                  () => DeleteRow(@context.Id)

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(61, "ConfirmText", "Are you sure you want to delete this subcategory?");
                __builder2.AddAttribute(62, "ButtonText", "Delete");
                __builder2.AddAttribute(63, "ConfirmTitle", "Delete subcategory!");
                __builder2.AddAttribute(64, "Icon", "delete");
                __builder2.AddAttribute(65, "ButtonType", "btn-danger");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(66, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(67, "\r\n                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(68, "\r\n                ");
                __builder2.OpenElement(69, "img");
                __builder2.AddAttribute(70, "class", "k-card-image img-thumbnail");
                __builder2.AddAttribute(71, "alt", "SubCategory Image");
                __builder2.AddAttribute(72, "src", 
#nullable restore
#line 33 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
                                                                                      context.Image

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(73, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(74, "\r\n        ");
            }
            );
            __builder.AddMarkupContent(75, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(76, "\r\n\r\n");
            __builder.OpenComponent<PWA.Client.Shared.Footer>(77);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "C:\Users\kinan\Desktop\Blzaor\PWA\PWA\PWA\Client\Pages\SubCategories\IndexSubCategory.razor"
      
    private List<SubCategory> subCategories;

    protected override async Task OnInitializedAsync()
    {
        subCategories = await subCategoryRepository.GetSubCategories();
    }
    private async Task DeleteRow(int id)
    {
        await subCategoryRepository.DeleteSubCategory(id);
        subCategories = await subCategoryRepository.GetSubCategories();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISubCategory subCategoryRepository { get; set; }
    }
}
namespace __Blazor.PWA.Client.Pages.SubCategories.IndexSubCategory
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikListView_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::System.Boolean __arg1, int __seq2, global::System.Int32 __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3, int __seq4, global::Microsoft.AspNetCore.Components.RenderFragment<TItem> __arg4)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikListView<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "Pageable", __arg1);
        __builder.AddAttribute(__seq2, "PageSize", __arg2);
        __builder.AddAttribute(__seq3, "HeaderTemplate", __arg3);
        __builder.AddAttribute(__seq4, "Template", __arg4);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
