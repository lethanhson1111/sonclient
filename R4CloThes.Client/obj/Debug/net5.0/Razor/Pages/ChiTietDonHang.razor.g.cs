#pragma checksum "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\ChiTietDonHang.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fe46b0a458fc74b89ca88641e1a38d2d7b0e54c"
// <auto-generated/>
#pragma warning disable 1591
namespace R4CloThes.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using R4CloThes.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using R4CloThes.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using CloudinaryDotNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using CloudinaryDotNet.Actions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "F:\repos\R4Clothes.Client\R4CloThes.Client\_Imports.razor"
using R4CloThes.Client.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/chitietdonhang/{id}")]
    public partial class ChiTietDonHang : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    .product-image {\r\n        float: left;\r\n        width: 15%;\r\n    }\r\n\r\n    .product-ngaydat {\r\n        float: left;\r\n        width: 15%;\r\n    }\r\n\r\n    .product-day {\r\n        float: left;\r\n        width: 15%;\r\n    }\r\n\r\n    .product-trangthai {\r\n        float: left;\r\n        width: 15%;\r\n    }\r\n\r\n    .product-quantity {\r\n        float: left;\r\n        width: 15%;\r\n    }\r\n\r\n    .product-removal {\r\n        float: left;\r\n        width: 9%;\r\n    }\r\n\r\n    .product-line-price {\r\n        float: left;\r\n        width: 12%;\r\n        text-align: right;\r\n    }\r\n\r\n    /* This is used as the traditional .clearfix class */\r\n    .group:before, .shopping-cart:before, .column-labels:before, .product:before, .totals-item:before,\r\n    .group:after,\r\n    .shopping-cart:after,\r\n    .column-labels:after,\r\n    .product:after,\r\n    .totals-item:after {\r\n        content: \'\';\r\n        display: table;\r\n    }\r\n\r\n    .group:after, .shopping-cart:after, .column-labels:after, .product:after, .totals-item:after {\r\n        clear: both;\r\n    }\r\n\r\n    .group, .shopping-cart, .column-labels, .product, .totals-item {\r\n        zoom: 1;\r\n    }\r\n\r\n\r\n    h1 {\r\n        font-weight: 100;\r\n    }\r\n\r\n    label {\r\n        color: #aaa;\r\n    }\r\n\r\n    .shopping-cart {\r\n        margin-top: -45px;\r\n    }\r\n\r\n    /* Column headers */\r\n    .column-labels label {\r\n        padding-bottom: 15px;\r\n        margin-bottom: 15px;\r\n        border-bottom: 1px solid #eee;\r\n    }\r\n\r\n    .column-labels .product-image, .column-labels .product-details, .column-labels .product-removal {\r\n        text-indent: -9999px;\r\n    }\r\n\r\n    /* Product entries */\r\n    .product {\r\n        margin-bottom: 20px;\r\n        padding-bottom: 10px;\r\n        border-bottom: 1px solid #eee;\r\n    }\r\n\r\n        .product .product-image {\r\n            text-align: center;\r\n        }\r\n\r\n            .product .product-image img {\r\n                width: 100px;\r\n            }\r\n\r\n        .product .product-details .product-title {\r\n            margin-right: 20px;\r\n            font-family: \"HelveticaNeue-Medium\", \"Helvetica Neue Medium\";\r\n        }\r\n\r\n        .product .product-details .product-description {\r\n            margin: 5px 20px 5px 0;\r\n            line-height: 1.4em;\r\n        }\r\n\r\n        .product .product-quantity input {\r\n            width: 40px;\r\n        }\r\n\r\n        .product .remove-product {\r\n            border: 0;\r\n            padding: 4px 8px;\r\n            background-color: #c66;\r\n            color: #fff;\r\n            font-family: \"HelveticaNeue-Medium\", \"Helvetica Neue Medium\";\r\n            font-size: 12px;\r\n            border-radius: 3px;\r\n        }\r\n\r\n            .product .remove-product:hover {\r\n                background-color: #a44;\r\n            }\r\n\r\n    /* Totals section */\r\n    .totals .totals-item {\r\n        float: right;\r\n        clear: both;\r\n        width: 100%;\r\n        margin-bottom: 10px;\r\n    }\r\n\r\n        .totals .totals-item label {\r\n            float: left;\r\n            clear: both;\r\n            width: 79%;\r\n            text-align: right;\r\n        }\r\n\r\n        .totals .totals-item .totals-value {\r\n            float: right;\r\n            width: 21%;\r\n            text-align: right;\r\n        }\r\n\r\n    .totals .totals-item-total {\r\n        font-family: \"HelveticaNeue-Medium\", \"Helvetica Neue Medium\";\r\n    }\r\n\r\n    .checkout {\r\n        float: right;\r\n        border: 0;\r\n        margin-top: 20px;\r\n        padding: 6px 25px;\r\n        background-color: #6b6;\r\n        color: #fff;\r\n        font-size: 25px;\r\n        border-radius: 3px;\r\n    }\r\n\r\n        .checkout:hover {\r\n            background-color: #494;\r\n        }\r\n\r\n    /* Make adjustments for tablet */\r\n    media screen and (max-width: 650px) {\r\n        .shopping-cart\r\n\r\n    {\r\n        margin: 0;\r\n        padding-top: 20px;\r\n        border-top: 1px solid #eee;\r\n    }\r\n\r\n    .column-labels {\r\n        display: none;\r\n    }\r\n\r\n    .product-details {\r\n        float: none;\r\n        margin-bottom: 10px;\r\n        width: auto;\r\n    }\r\n\r\n\r\n    .product-quantity {\r\n        width: 100px;\r\n    }\r\n\r\n        .product-quantity input {\r\n            margin-left: 20px;\r\n        }\r\n\r\n        .product-quantity:before {\r\n            content: \'x\';\r\n        }\r\n\r\n    .product-removal {\r\n        width: auto;\r\n    }\r\n\r\n    .product-line-price {\r\n        float: right;\r\n        width: 70px;\r\n    }\r\n    }\r\n</style>\r\n");
            __Blazor.R4CloThes.Client.Pages.ChiTietDonHang.TypeInference.CreateMudTable_0(__builder, 1, 2, 
#nullable restore
#line 215 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\ChiTietDonHang.razor"
                  sanPhamCTs

#line default
#line hidden
#nullable disable
            , 3, (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTh>(4);
                __builder2.AddAttribute(5, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(6, "T??n S???n Ph???m ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(8);
                __builder2.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(10, "H??nh");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(11, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(12);
                __builder2.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(14, "S??? L?????ng ");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTh>(16);
                __builder2.AddAttribute(17, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddMarkupContent(18, " Gi??");
                }
                ));
                __builder2.CloseComponent();
            }
            , 19, (context) => (__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudTd>(20);
                __builder2.AddAttribute(21, "DataLabel", "Maloai");
                __builder2.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(23, 
#nullable restore
#line 227 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\ChiTietDonHang.razor"
                                   context.TenSanPham

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(25);
                __builder2.AddAttribute(26, "DataLabel", "Tenloai");
                __builder2.AddAttribute(27, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(28, "img");
                    __builder3.AddAttribute(29, "src", "https://res.cloudinary.com/r4clothes/image/upload/" + (
#nullable restore
#line 228 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\ChiTietDonHang.razor"
                                                                                                context.Hinh

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(30, "width", "100px");
                    __builder3.AddAttribute(31, "height", "100px");
                    __builder3.AddAttribute(32, "alt", "Alternate Text");
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(34);
                __builder2.AddAttribute(35, "DataLabel", "Tenloai");
                __builder2.AddAttribute(36, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(37, 
#nullable restore
#line 229 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\ChiTietDonHang.razor"
                                    context.SoLuongMua

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudTd>(39);
                __builder2.AddAttribute(40, "DataLabel", "Tenloai");
                __builder2.AddAttribute(41, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(42, 
#nullable restore
#line 230 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\ChiTietDonHang.razor"
                                    context.Gia

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private R4CloThes.Client.Helpers.IAPIHelper _apiHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService _cartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
    }
}
namespace __Blazor.R4CloThes.Client.Pages.ChiTietDonHang
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTable_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<T> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.RenderFragment __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment<T> __arg2)
        {
        __builder.OpenComponent<global::MudBlazor.MudTable<T>>(seq);
        __builder.AddAttribute(__seq0, "Items", __arg0);
        __builder.AddAttribute(__seq1, "HeaderContent", __arg1);
        __builder.AddAttribute(__seq2, "RowTemplate", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
