#pragma checksum "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf8577ad951a756660d9e72e3c91285c96687062"
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
#nullable restore
#line 3 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\Index.razor"
using R4CloThes.Client.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-9 mt-30");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "m-sm-auto");
            __builder.AddMarkupContent(4, @"<div class=""text-center""><h3 class=""h2"" style=""background-color:#ff6a00; color:aliceblue"">Sản phẩm đặt biệt</h3>
            <p style=""color:black"">
                Đây là những mặt hàng đang được ưa chuộng nhất hiện nay tại shop
            </p></div>
        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "d-inline-flex ml-30 ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "card-group");
#nullable restore
#line 15 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\Index.razor"
                 for (int i = 0; i < dssp.Count; i++)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "single-products-catagory clearfix");
            __builder.OpenElement(11, "a");
            __builder.AddAttribute(12, "href", "/chitietsanpham/" + (
#nullable restore
#line 18 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\Index.razor"
                                                  dssp[i].Masanpham

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(13, "img");
            __builder.AddAttribute(14, "src", "https://res.cloudinary.com/r4clothes/image/upload/" + (
#nullable restore
#line 19 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\Index.razor"
                                                                                         dssp[i].Hinh

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "alt");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                            \r\n                            ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "hover-content");
            __builder.AddMarkupContent(19, "<div class=\"line\"></div>\r\n                                ");
            __builder.OpenElement(20, "p");
            __builder.AddMarkupContent(21, "Giá: ");
            __builder.AddContent(22, 
#nullable restore
#line 23 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\Index.razor"
                                         dssp[i].Gia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                                ");
            __builder.OpenElement(24, "h4");
            __builder.AddContent(25, 
#nullable restore
#line 24 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\Index.razor"
                                     dssp[i].Tensanpham

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.AddMarkupContent(27, "<div class=\"text-center\"><h3 class=\"h2\" style=\"background-color:#ff6a00; color:aliceblue\">Sản phẩm bán chạy</h3>\r\n            <p style=\"color:black\">\r\n                Đây là những mặt hàng bán chạy nhất tại shop.\r\n            </p></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private R4CloThes.Client.Helpers.IAPIHelper _apiHelper { get; set; }
    }
}
#pragma warning restore 1591
