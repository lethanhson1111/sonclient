#pragma checksum "F:\repos\R4Clothes.Server\R4CloThes.Client\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e5ca37b07f931bd7211056760577971bedd9c12"
// <auto-generated/>
#pragma warning disable 1591
namespace R4CloThes.Client.Shared
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
#line 4 "F:\repos\R4Clothes.Server\R4CloThes.Client\Shared\MainLayout.razor"
using R4CloThes.Client.Models.ViewModel;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase, IDisposable
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-yvfba47p25");
            __builder.AddMarkupContent(3, @"<div class=""search-wrapper section-padding-100"" b-yvfba47p25><div class=""search-close"" b-yvfba47p25><i class=""fa fa-close"" aria-hidden=""true"" b-yvfba47p25></i></div>
        <div class=""container"" b-yvfba47p25><div class=""row"" b-yvfba47p25><div class=""col-12"" b-yvfba47p25><div class=""search-content"" b-yvfba47p25><form action=""#"" method=""get"" b-yvfba47p25><input type=""search"" name=""search"" id=""search"" placeholder=""Type your keyword..."" b-yvfba47p25>
                            <button type=""submit"" b-yvfba47p25><img src=""template/img/core-img/search.png"" alt b-yvfba47p25></button></form></div></div></div></div></div>
    
    
    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "main-content-wrapper d-flex clearfix");
            __builder.AddAttribute(6, "b-yvfba47p25");
            __builder.AddMarkupContent(7, @"<div class=""mobile-nav"" b-yvfba47p25><div class=""amado-navbar-brand"" b-yvfba47p25><a href=""/"" b-yvfba47p25><img src=""template/img/core-img/logo.png"" alt b-yvfba47p25></a></div>
            
            <div class=""amado-navbar-toggler"" b-yvfba47p25><span b-yvfba47p25></span><span b-yvfba47p25></span><span b-yvfba47p25></span></div></div>
        
        ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "col-3");
            __builder.AddAttribute(10, "b-yvfba47p25");
            __builder.OpenElement(11, "header");
            __builder.AddAttribute(12, "class", "header-area clearfix");
            __builder.AddAttribute(13, "b-yvfba47p25");
            __builder.AddMarkupContent(14, "<div class=\"nav-close\" b-yvfba47p25><i class=\"fa fa-close\" aria-hidden=\"true\" b-yvfba47p25></i></div>\r\n                \r\n                ");
            __builder.AddMarkupContent(15, "<div class=\"logo\" b-yvfba47p25><a href=\"index.html\" b-yvfba47p25><img src=\"template/img/core-img/logo.png\" alt b-yvfba47p25></a></div>\r\n                \r\n                ");
            __builder.AddMarkupContent(16, @"<nav class=""amado-nav"" b-yvfba47p25><ul b-yvfba47p25><li class=""active"" b-yvfba47p25><a href=""/"" b-yvfba47p25>Trang Chủ</a></li>
                        <li b-yvfba47p25><a class=""active"" href=""/sanpham"" b-yvfba47p25>Sản Phẩm</a></li>
                        
                            <li b-yvfba47p25><a class=""active"" href=""/login"" b-yvfba47p25>Đăng Nhập</a></li>
                            <li b-yvfba47p25><a class=""active"" href=""/Dangky"" b-yvfba47p25>Đăng Ký</a></li>
                        
                        <li b-yvfba47p25><a class=""active"" href=""/About"" b-yvfba47p25>Giới Thiệu</a></li>
                        <li b-yvfba47p25><a class=""active"" href=""/quenmk"" b-yvfba47p25>Quên Mật Khẩu</a></li>
                       
                            <li b-yvfba47p25><a class=""active"" href=""/donhang"" b-yvfba47p25>Đơn Hàng</a></li>
                            <li b-yvfba47p25><a class=""active"" href=""/thongtin"" b-yvfba47p25>Thông Tin Khách Hàng</a></li>
                            <li b-yvfba47p25><a class=""active"" href=""/doimk"" b-yvfba47p25>Đổi Mật Khẩu</a></li>
                            <li b-yvfba47p25><a class=""active"" href=""/logout"" b-yvfba47p25>Đăng xuất</a></li></ul></nav>
                
                ");
            __builder.OpenElement(17, "div");
            __builder.AddAttribute(18, "class", "cart-fav-search mb-100");
            __builder.AddAttribute(19, "b-yvfba47p25");
            __builder.OpenElement(20, "a");
            __builder.AddAttribute(21, "href", "/cart");
            __builder.AddAttribute(22, "class", "cart-nav");
            __builder.AddAttribute(23, "b-yvfba47p25");
            __builder.AddMarkupContent(24, "<img src=\"template/img/core-img/cart.png\" alt=\"cart\" b-yvfba47p25> Cart ");
            __builder.OpenElement(25, "span");
            __builder.AddAttribute(26, "b-yvfba47p25");
            __builder.AddContent(27, "(");
            __builder.AddContent(28, 
#nullable restore
#line 72 "F:\repos\R4Clothes.Server\R4CloThes.Client\Shared\MainLayout.razor"
                                                                                                                        count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(29, ")");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                \r\n                ");
            __builder.AddMarkupContent(31, @"<div class=""social-info d-flex justify-content-between"" b-yvfba47p25><a href=""#"" b-yvfba47p25><i class=""fa fa-pinterest"" aria-hidden=""true"" b-yvfba47p25></i></a>
                    <a href=""#"" b-yvfba47p25><i class=""fa fa-instagram"" aria-hidden=""true"" b-yvfba47p25></i></a>
                    <a href=""#"" b-yvfba47p25><i class=""fa fa-facebook"" aria-hidden=""true"" b-yvfba47p25></i></a>
                    <a href=""#"" b-yvfba47p25><i class=""fa fa-twitter"" aria-hidden=""true"" b-yvfba47p25></i></a></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        \r\n        \r\n        ");
            __builder.AddContent(33, 
#nullable restore
#line 85 "F:\repos\R4Clothes.Server\R4CloThes.Client\Shared\MainLayout.razor"
         Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n\r\n    \r\n    \r\n    ");
            __builder.AddMarkupContent(35, @"<section class=""newsletter-area section-padding-100-0"" b-yvfba47p25><div class=""container"" b-yvfba47p25><div class=""row align-items-center"" b-yvfba47p25><div class=""col-12 col-lg-6 col-xl-7"" b-yvfba47p25><div class=""newsletter-text mb-100"" b-yvfba47p25><h2 b-yvfba47p25>Đăng ký để được giảm <span b-yvfba47p25>20%</span></h2>
                        <p b-yvfba47p25>Shop R4-CloThes </p></div></div>
                
                <div class=""col-12 col-lg-6 col-xl-5"" b-yvfba47p25><div class=""newsletter-form mb-100"" b-yvfba47p25><form action=""#"" method=""post"" b-yvfba47p25><input type=""email"" name=""email"" class=""nl-email"" placeholder=""Your E-mail"" b-yvfba47p25>
                            <input type=""submit"" value=""Subscribe"" b-yvfba47p25></form></div></div></div></div></section>
    
    
    ");
            __builder.AddMarkupContent(36, "<footer class=\"footer_area clearfix\" b-yvfba47p25><div class=\"container\" b-yvfba47p25><div class=\"row align-items-center\" b-yvfba47p25><div class=\"col-12 col-lg-4\" b-yvfba47p25><div class=\"single_widget_area\" b-yvfba47p25><div class=\"footer-logo mr-50\" b-yvfba47p25><a href=\"index.html\" b-yvfba47p25><img src=\"template/img/core-img/logo2.png\" alt b-yvfba47p25></a></div></div></div>\r\n                \r\n                <div class=\"col-12 col-lg-8\" b-yvfba47p25><div class=\"single_widget_area\" b-yvfba47p25><div class=\"footer_menu\" b-yvfba47p25><nav class=\"navbar navbar-expand-lg justify-content-end\" b-yvfba47p25><button class=\"navbar-toggler\" type=\"button\" data-toggle=\"collapse\" data-target=\"#footerNavContent\" aria-controls=\"footerNavContent\" aria-expanded=\"false\" aria-label=\"Toggle navigation\" b-yvfba47p25><i class=\"fa fa-bars\" b-yvfba47p25></i></button>\r\n                                <div class=\"collapse navbar-collapse\" id=\"footerNavContent\" b-yvfba47p25><ul class=\"navbar-nav ml-auto\" b-yvfba47p25><li class=\"nav-item active\" b-yvfba47p25><a class=\"nav-link\" href=\"index.html\" b-yvfba47p25>Home</a></li>\r\n                                        <li class=\"nav-item\" b-yvfba47p25><a class=\"nav-link\" href=\"shop.html\" b-yvfba47p25>Shop</a></li>\r\n                                        <li class=\"nav-item\" b-yvfba47p25><a class=\"nav-link\" href=\"product-details.html\" b-yvfba47p25>Product</a></li>\r\n                                        <li class=\"nav-item\" b-yvfba47p25><a class=\"nav-link\" href=\"cart.html\" b-yvfba47p25>Cart</a></li>\r\n                                        <li class=\"nav-item\" b-yvfba47p25><a class=\"nav-link\" href=\"checkout.html\" b-yvfba47p25>Checkout</a></li></ul></div></nav></div></div></div></div></div></footer>");
            __builder.CloseElement();
            __builder.AddMarkupContent(37, "\r\n");
            __builder.OpenComponent<MudBlazor.MudThemeProvider>(38);
            __builder.CloseComponent();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.OpenComponent<MudBlazor.MudDialogProvider>(40);
            __builder.CloseComponent();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.OpenComponent<MudBlazor.MudSnackbarProvider>(42);
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 167 "F:\repos\R4Clothes.Server\R4CloThes.Client\Shared\MainLayout.razor"
      
    public int count = 0;

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            var cart = await localStorage.GetItemAsync<List<SanPhamGioHang>>("cart");
            if (cart == null)
            {
                count = 0;
            }
            else
            {
                count = cart.Count;
            }
        }
        StateHasChanged();
    }

    protected override void OnInitialized()
    {
        cartService.OnChange += StateHasChanged;
    }
    public void Dispose()
    {
        cartService.OnChange -= StateHasChanged;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService cartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager nav { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591
