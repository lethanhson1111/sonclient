#pragma checksum "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DonHang.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8da09af6e90f5d62f443a70475aee252ac36127"
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
#line 1 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using R4CloThes.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using R4CloThes.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using CloudinaryDotNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using CloudinaryDotNet.Actions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "F:\repos\R4Clothes.Server\R4CloThes.Client\_Imports.razor"
using R4CloThes.Client.Helpers;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/donhang")]
    public partial class DonHang : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n        .product-name {\r\n            float: left;\r\n            width: 20%;\r\n        }\r\n\r\n        .product-ngaydat {\r\n            float: left;\r\n            width: 20%;\r\n        }\r\n\r\n        .product-trangthai {\r\n            float: left;\r\n            width: 20%;\r\n        }\r\n\r\n        .product-quantity {\r\n            float: left;\r\n            width: 10%;\r\n        }\r\n\r\n        .product-removal {\r\n            float: left;\r\n            width: 9%;\r\n        }\r\n\r\n        .product-line-price {\r\n            float: left;\r\n            width: 12%;\r\n            text-align: right;\r\n        }\r\n\r\n        /* This is used as the traditional .clearfix class */\r\n        .group:before, .shopping-cart:before, .column-labels:before, .product:before, .totals-item:before,\r\n        .group:after,\r\n        .shopping-cart:after,\r\n        .column-labels:after,\r\n        .product:after,\r\n        .totals-item:after {\r\n            content: \'\';\r\n            display: table;\r\n        }\r\n\r\n        .group:after, .shopping-cart:after, .column-labels:after, .product:after, .totals-item:after {\r\n            clear: both;\r\n        }\r\n\r\n        .group, .shopping-cart, .column-labels, .product, .totals-item {\r\n            zoom: 1;\r\n        }\r\n\r\n\r\n        h1 {\r\n            font-weight: 100;\r\n        }\r\n\r\n        label {\r\n            color: #aaa;\r\n        }\r\n\r\n        .shopping-cart {\r\n            margin-top: -45px;\r\n        }\r\n\r\n        /* Column headers */\r\n        .column-labels label {\r\n            padding-bottom: 15px;\r\n            margin-bottom: 15px;\r\n            border-bottom: 1px solid #eee;\r\n        }\r\n\r\n        .column-labels .product-image, .column-labels .product-details, .column-labels .product-removal {\r\n            text-indent: -9999px;\r\n        }\r\n\r\n        /* Product entries */\r\n        .product {\r\n            margin-bottom: 20px;\r\n            padding-bottom: 10px;\r\n            border-bottom: 1px solid #eee;\r\n        }\r\n\r\n            .product .product-image {\r\n                text-align: center;\r\n            }\r\n\r\n                .product .product-image img {\r\n                    width: 100px;\r\n                }\r\n\r\n            .product .product-details .product-title {\r\n                margin-right: 20px;\r\n                font-family: \"HelveticaNeue-Medium\", \"Helvetica Neue Medium\";\r\n            }\r\n\r\n            .product .product-details .product-description {\r\n                margin: 5px 20px 5px 0;\r\n                line-height: 1.4em;\r\n            }\r\n\r\n            .product .product-quantity input {\r\n                width: 40px;\r\n            }\r\n\r\n            .product .remove-product {\r\n                border: 0;\r\n                padding: 4px 8px;\r\n                background-color: #c66;\r\n                color: #fff;\r\n                font-family: \"HelveticaNeue-Medium\", \"Helvetica Neue Medium\";\r\n                font-size: 12px;\r\n                border-radius: 3px;\r\n            }\r\n\r\n                .product .remove-product:hover {\r\n                    background-color: #a44;\r\n                }\r\n\r\n        /* Totals section */\r\n        .totals .totals-item {\r\n            float: right;\r\n            clear: both;\r\n            width: 100%;\r\n            margin-bottom: 10px;\r\n        }\r\n\r\n            .totals .totals-item label {\r\n                float: left;\r\n                clear: both;\r\n                width: 79%;\r\n                text-align: right;\r\n            }\r\n\r\n            .totals .totals-item .totals-value {\r\n                float: right;\r\n                width: 21%;\r\n                text-align: right;\r\n            }\r\n\r\n        .totals .totals-item-total {\r\n            font-family: \"HelveticaNeue-Medium\", \"Helvetica Neue Medium\";\r\n        }\r\n\r\n        .checkout {\r\n            float: right;\r\n            border: 0;\r\n            margin-top: 20px;\r\n            padding: 6px 25px;\r\n            background-color: #6b6;\r\n            color: #fff;\r\n            font-size: 25px;\r\n            border-radius: 3px;\r\n        }\r\n\r\n            .checkout:hover {\r\n                background-color: #494;\r\n            }\r\n\r\n        /* Make adjustments for tablet */\r\n        media screen and (max-width: 650px) {\r\n            .shopping-cart\r\n\r\n        {\r\n            margin: 0;\r\n            padding-top: 20px;\r\n            border-top: 1px solid #eee;\r\n        }\r\n\r\n        .column-labels {\r\n            display: none;\r\n        }\r\n\r\n        .product-details {\r\n            float: none;\r\n            margin-bottom: 10px;\r\n            width: auto;\r\n        }\r\n\r\n\r\n        .product-quantity {\r\n            width: 100px;\r\n        }\r\n\r\n            .product-quantity input {\r\n                margin-left: 20px;\r\n            }\r\n\r\n            .product-quantity:before {\r\n                content: \'x\';\r\n            }\r\n\r\n        .product-removal {\r\n            width: auto;\r\n        }\r\n\r\n        .product-line-price {\r\n            float: right;\r\n            width: 70px;\r\n        }\r\n        }\r\n    </style>\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "cart-table-area mt-100");
            __builder.AddMarkupContent(3, @"<div class=""column-labels""><label class=""product-name"">Mã đơn hàng</label>
            <label class=""product-ngaydat"">Ngày Đặt</label>
            <label class=""product-trangthai"">Trạng Thái</label>
            <label class=""product-line-price"">Tổng Tiền</label></div>");
#nullable restore
#line 216 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DonHang.razor"
         foreach (var item in hoadon)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "product");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "product-name");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "product-title");
            __builder.AddContent(10, 
#nullable restore
#line 220 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DonHang.razor"
                                                item.Mahoadon

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "product-ngaydat");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "product-title");
            __builder.AddContent(16, 
#nullable restore
#line 223 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DonHang.razor"
                                                 item.Ngaydat

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "product-trangthai");
            __builder.OpenElement(20, "div");
            __builder.AddAttribute(21, "class", "product-title");
            __builder.AddContent(22, 
#nullable restore
#line 226 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DonHang.razor"
                                                item.Trangthai

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                ");
            __builder.AddMarkupContent(24, "<div class=\"product-removal\"><a class=\"btn btn-info product-title\" href=\"/chitietdonhang\">Chi Tiết</a></div>\r\n                ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "product-line-price");
            __builder.AddContent(27, 
#nullable restore
#line 231 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DonHang.razor"
                                                 item.Tongtien

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 233 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DonHang.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAPIHelper _apiHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
    }
}
#pragma warning restore 1591
