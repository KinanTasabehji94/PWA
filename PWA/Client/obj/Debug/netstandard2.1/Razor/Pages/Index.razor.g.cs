#pragma checksum "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ea7b404aec7866c0f7b9bba75727faf7f28fbb1f"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/index")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<PWA.Client.Shared.Header>(0);
            __builder.CloseComponent();
            __builder.AddMarkupContent(1, "\r\n\r\n");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "page-content-wrapper");
            __builder.AddMarkupContent(4, "\r\n    \r\n    ");
            __builder.AddMarkupContent(5, @"<div id=""carouselExampleInterval"" class=""carousel slide"" data-ride=""carousel"">
        <div class=""carousel-inner"">
            <div class=""carousel-item active"" data-interval=""10000"">
                <img src=""/img/bg-img/3.jpg"" class=""d-block w-100"" alt=""..."">
            </div>
            <div class=""carousel-item"" data-interval=""2000"">
                <img src=""/img/bg-img/3.jpg"" class=""d-block w-100"" alt=""..."">
            </div>
            <div class=""carousel-item"">
                <img src=""/img/bg-img/3.jpg"" class=""d-block w-100"" alt=""..."">
            </div>
        </div>
        <a class=""carousel-control-prev"" href=""#carouselExampleInterval"" role=""button"" data-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Previous</span>
        </a>
        <a class=""carousel-control-next"" href=""#carouselExampleInterval"" role=""button"" data-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""sr-only"">Next</span>
        </a>
    </div>
    
    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "product-catagories-wrapper pt-3");
            __builder.AddMarkupContent(8, "\r\n        ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "container");
            __builder.AddMarkupContent(11, "\r\n            ");
            __builder.AddMarkupContent(12, "<div class=\"section-heading\">\r\n                <h6 class=\"ml-1\">Product Category</h6>\r\n            </div>\r\n            ");
            __Blazor.PWA.Client.Pages.Index.TypeInference.CreateGenericList_0(__builder, 13, 14, 
#nullable restore
#line 37 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                               categories

#line default
#line hidden
#nullable disable
            , 15, (__builder2) => {
                __builder2.AddMarkupContent(16, "\r\n                    ");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "product-catagory-wrap");
                __builder2.AddMarkupContent(19, "\r\n                        ");
                __builder2.OpenElement(20, "div");
                __builder2.AddAttribute(21, "class", "row");
                __builder2.AddMarkupContent(22, "\r\n");
#nullable restore
#line 41 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                             foreach (var category in categories)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(23, "                                ");
                __builder2.OpenElement(24, "div");
                __builder2.AddAttribute(25, "class", "col-4");
                __builder2.AddMarkupContent(26, "\r\n                                    ");
                __builder2.OpenElement(27, "div");
                __builder2.AddAttribute(28, "class", "card mb-3 catagory-card");
                __builder2.AddMarkupContent(29, "\r\n                                        ");
                __builder2.OpenElement(30, "div");
                __builder2.AddAttribute(31, "class", "card-body");
                __builder2.AddMarkupContent(32, "\r\n                                            ");
                __builder2.OpenElement(33, "a");
                __builder2.AddAttribute(34, "href", "category/" + (
#nullable restore
#line 46 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                                                               category.Id

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(35, "\r\n                                                ");
                __builder2.OpenElement(36, "img");
                __builder2.AddAttribute(37, "src", 
#nullable restore
#line 47 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                                                           category.Image

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(38, "alt", 
#nullable restore
#line 47 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                                                                                 category.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(39, "class", "img-thumbnail img");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                                                ");
                __builder2.OpenElement(41, "span");
                __builder2.AddContent(42, 
#nullable restore
#line 48 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                                                       category.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(46, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(47, "\r\n");
#nullable restore
#line 53 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                            }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(48, "                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(49, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(50, "\r\n                ");
            }
            );
            __builder.AddMarkupContent(51, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(53, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(54, "div");
            __builder.AddAttribute(55, "class", "top-products-area clearfix");
            __builder.AddMarkupContent(56, "\r\n        ");
            __builder.OpenElement(57, "div");
            __builder.AddAttribute(58, "class", "container");
            __builder.AddMarkupContent(59, "\r\n            ");
            __builder.AddMarkupContent(60, "<div class=\"section-heading d-flex align-items-center justify-content-between\">\r\n                <h6 class=\"ml-1\">Top Products</h6><a class=\"btn btn-danger btn-sm\" href=\"/products\">View All</a>\r\n            </div>\r\n            ");
            __Blazor.PWA.Client.Pages.Index.TypeInference.CreateGenericList_1(__builder, 61, 62, 
#nullable restore
#line 67 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                               products

#line default
#line hidden
#nullable disable
            , 63, (__builder2) => {
                __builder2.AddMarkupContent(64, "\r\n                    ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "row");
                __builder2.AddMarkupContent(67, "\r\n                        \r\n");
#nullable restore
#line 71 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                         foreach (var product in products)
                        {

#line default
#line hidden
#nullable disable
                __builder2.AddContent(68, "                            ");
                __builder2.OpenElement(69, "div");
                __builder2.AddAttribute(70, "class", "col-6 col-sm-4");
                __builder2.AddMarkupContent(71, "\r\n                                ");
                __builder2.OpenElement(72, "div");
                __builder2.AddAttribute(73, "class", "card top-product-card mb-3");
                __builder2.AddMarkupContent(74, "\r\n                                    ");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "card-body");
                __builder2.AddMarkupContent(77, "\r\n                                        ");
                __builder2.AddMarkupContent(78, "<span class=\"badge badge-success\">Sale</span>\r\n                                        ");
                __builder2.AddMarkupContent(79, "<a class=\"wishlist-btn\" href=\"#\">\r\n                                            <i class=\"lni-heart-filled\"></i>\r\n                                        </a>\r\n                                        ");
                __builder2.OpenElement(80, "a");
                __builder2.AddAttribute(81, "class", "product-thumbnail d-block");
                __builder2.AddAttribute(82, "href", "single-product.html");
                __builder2.AddMarkupContent(83, "\r\n                                            ");
                __builder2.OpenElement(84, "img");
                __builder2.AddAttribute(85, "src", 
#nullable restore
#line 81 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                                                       product.Image

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(86, "alt", 
#nullable restore
#line 81 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                                                                            product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(87, "class", "img-thumbnail img");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(88, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(89, "\r\n                                        ");
                __builder2.OpenElement(90, "a");
                __builder2.AddAttribute(91, "class", "product-title d-block");
                __builder2.AddAttribute(92, "href", "single-product.html");
                __builder2.AddMarkupContent(93, "\r\n                                            ");
                __builder2.AddContent(94, 
#nullable restore
#line 84 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                                             product.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(95, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(96, "\r\n                                        ");
                __builder2.OpenElement(97, "a");
                __builder2.AddAttribute(98, "class", "product-title d-block");
                __builder2.AddAttribute(99, "href", "single-product.html");
                __builder2.AddMarkupContent(100, "\r\n                                            ");
                __builder2.AddContent(101, 
#nullable restore
#line 87 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                                             product.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(102, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(103, "\r\n                                        ");
                __builder2.OpenElement(104, "p");
                __builder2.AddAttribute(105, "class", "sale-price");
                __builder2.AddMarkupContent(106, "\r\n");
#nullable restore
#line 90 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                                               
                                                var salePrice = product.Price / 2;
                                            

#line default
#line hidden
#nullable disable
                __builder2.AddContent(107, "                                            ");
                __builder2.AddContent(108, 
#nullable restore
#line 93 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                                             salePrice

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(109, "\r\n                                            ");
                __builder2.OpenElement(110, "span");
                __builder2.AddMarkupContent(111, "\r\n                                                ");
                __builder2.AddContent(112, 
#nullable restore
#line 95 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                                                 product.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(113, "\r\n                                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(114, "\r\n                                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(115, "\r\n                                        ");
                __builder2.AddMarkupContent(116, "<div class=\"product-rating\"><i class=\"lni-star-filled\"></i><i class=\"lni-star-filled\"></i><i class=\"lni-star-filled\"></i><i class=\"lni-star-filled\"></i><i class=\"lni-star-filled\"></i></div>");
                __builder2.AddMarkupContent(117, "<a class=\"btn btn-success btn-sm add2cart-notify\" href=\"#\"><i class=\"lni-plus\"></i></a>\r\n                                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n                                ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(120, "\r\n");
#nullable restore
#line 102 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
                        }

#line default
#line hidden
#nullable disable
                __builder2.AddContent(121, "                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(122, "\r\n                ");
            }
            );
            __builder.AddMarkupContent(123, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(124, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(126, "\r\n\r\n");
            __builder.OpenComponent<PWA.Client.Shared.Footer>(127);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 112 "C:\Users\ENG\Desktop\PWA\PWA\Client\Pages\Index.razor"
      
    private List<Category> categories;
    private List<Product> products;


    protected override async Task OnInitializedAsync()
    {
        try
        {
            categories = await categoryRepository.GetCategories();
            products = await productRepository.GetProducts();
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IProduct productRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICategory categoryRepository { get; set; }
    }
}
namespace __Blazor.PWA.Client.Pages.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateGenericList_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::PWA.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "WholeListTemplate", __arg1);
        __builder.CloseComponent();
        }
        public static void CreateGenericList_1<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.List<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1)
        {
        __builder.OpenComponent<global::PWA.Client.Shared.GenericList<TItem>>(seq);
        __builder.AddAttribute(__seq0, "List", __arg0);
        __builder.AddAttribute(__seq1, "WholeListTemplate", __arg1);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
