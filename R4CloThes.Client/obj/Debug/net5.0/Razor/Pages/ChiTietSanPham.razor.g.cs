#pragma checksum "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\ChiTietSanPham.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "090c575feb1bc436fe1d62ba18eac86c6da7f97d"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/chitietsanpham/{id}")]
    public partial class ChiTietSanPham : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n        import url(https://fonts.googleapis.com/css?family=Sniglet|Raleway:900);\r\n\r\n        h1 {\r\n            font-weight: normal;\r\n            font-size: 4em;\r\n            font-family: \'Raleway\', sans-serif;\r\n            margin: 0 auto;\r\n            margin-top: 30px;\r\n            width: 500px;\r\n            color: #F90;\r\n            text-align: center;\r\n        }\r\n\r\n        /* Animation webkit */\r\n        -webkit-keyframes myfirst {\r\n            0%\r\n        }\r\n\r\n        {\r\n            margin-left: -235px\r\n        }\r\n\r\n        90% {\r\n            margin-left: 100%;\r\n        }\r\n\r\n        100% {\r\n            margin-left: 100%;\r\n        }\r\n\r\n\r\n        /* Animation */\r\n        keyframes myfirst {\r\n            0%\r\n        }\r\n\r\n        {\r\n            margin-left: -235px\r\n        }\r\n\r\n        70% {\r\n            margin-left: 100%;\r\n        }\r\n\r\n        100% {\r\n            margin-left: 100%;\r\n        }\r\n\r\n\r\n        label, input, textarea {\r\n            display: block;\r\n        }\r\n\r\n        input, textarea {\r\n            width: 500px;\r\n            border: none;\r\n            border-radius: 20px;\r\n            outline: none;\r\n            padding: 10px;\r\n            font-family: \'Sniglet\', cursive;\r\n            font-size: 1em;\r\n            color: #676767;\r\n            transition: border 0.5s;\r\n            -webkit-transition: border 0.5s;\r\n            -moz-transition: border 0.5s;\r\n            -o-transition: border 0.5s;\r\n            border: solid 3px #98d4f3;\r\n            -webkit-box-sizing: border-box;\r\n            -moz-box-sizing: border-box;\r\n            box-sizing: border-box;\r\n        }\r\n\r\n            input[type=\"submit\"]:hover {\r\n                background-color: #e58f0e;\r\n            }\r\n\r\n        label {\r\n            font-size: 1.5em;\r\n            margin-top: 20px;\r\n            padding-left: 20px;\r\n        }\r\n\r\n        .formgroup, .formgroup-active, .formgroup-error {\r\n            background-repeat: no-repeat;\r\n            background-position: right bottom;\r\n            background-size: 10.5%;\r\n            transition: background-image 0.7s;\r\n            -webkit-transition: background-image 0.7s;\r\n            -moz-transition: background-image 0.7s;\r\n            -o-transition: background-image 0.7s;\r\n            width: 566px;\r\n            padding-top: 2px;\r\n        }\r\n\r\n        .formgroup {\r\n            background-image: url(\'http://www.geertjanhendriks.nl/codepen/form/pixel.gif\');\r\n        }\r\n\r\n        .formgroup-active {\r\n            background-image: url(\'http://www.geertjanhendriks.nl/codepen/form/octo.png\');\r\n        }\r\n\r\n        .formgroup-error {\r\n            background-image: url(\'http://www.geertjanhendriks.nl/codepen/form/octo-error.png\');\r\n            color: red;\r\n        }\r\n    </style>\r\n    ");
            __builder.OpenElement(1, "div");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row  mt-50");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "col-12 col-lg-7 ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "single_product_thumb");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "id", "product_details_slider");
            __builder.AddAttribute(10, "class", "carousel slide");
            __builder.AddAttribute(11, "data-ride", "carousel");
            __builder.AddMarkupContent(12, "<ol class=\"carousel-indicators\"><li class=\"active\" data-target=\"#product_details_slider\" data-slide-to=\"0\" ;></li></ol>\r\n                        ");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "carousel-inner");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "carousel-item active");
            __builder.OpenElement(17, "a");
            __builder.AddAttribute(18, "class", "gallery_img");
            __builder.OpenElement(19, "img");
            __builder.AddAttribute(20, "class", "d-block w-100");
            __builder.AddAttribute(21, "style", "width:200px; height: 500px");
            __builder.AddAttribute(22, "src", "https://res.cloudinary.com/r4clothes/image/upload/" + (
#nullable restore
#line 127 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\ChiTietSanPham.razor"
                                                                                                                                                          sanPham.Hinh

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "alt", "imgProduct");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n            ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "col-12 col-lg-5");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "single_product_desc");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "product-meta-data");
            __builder.AddMarkupContent(31, "<div class=\"line\"></div>\r\n                        ");
            __builder.OpenElement(32, "p");
            __builder.AddAttribute(33, "class", "product-price");
            __builder.AddMarkupContent(34, "Giảm giá: ");
            __builder.AddContent(35, 
#nullable restore
#line 139 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\ChiTietSanPham.razor"
                                                            sanPham.Giamgia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                        ");
            __builder.OpenElement(37, "p");
            __builder.AddAttribute(38, "class", "product-price");
            __builder.AddMarkupContent(39, "Giá: ");
            __builder.AddContent(40, 
#nullable restore
#line 140 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\ChiTietSanPham.razor"
                                                       SauGiamGia

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "a");
            __builder.OpenElement(43, "h6");
            __builder.AddContent(44, 
#nullable restore
#line 142 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\ChiTietSanPham.razor"
                                 sanPham.Tensanpham

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                        \r\n                        ");
            __builder.OpenElement(46, "div");
            __builder.AddAttribute(47, "class", "ratings-review mb-15 d-flex align-items-center justify-content-between");
            __builder.OpenComponent<MudBlazor.MudCardActions>(48);
            __builder.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudIconButton>(50);
                __builder2.AddAttribute(51, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 147 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\ChiTietSanPham.razor"
                                                      Icons.Material.Filled.Favorite

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(52, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 147 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\ChiTietSanPham.razor"
                                                                                             Color.Default

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(53, "\r\n                                ");
                __builder2.OpenComponent<MudBlazor.MudIconButton>(54);
                __builder2.AddAttribute(55, "Icon", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 148 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\ChiTietSanPham.razor"
                                                      Icons.Material.Filled.Share

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 148 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\ChiTietSanPham.razor"
                                                                                          Color.Default

#line default
#line hidden
#nullable disable
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\r\n                    ");
            __builder.AddMarkupContent(58, "<div class=\"short_overview my-5\"><p>Một vài điểm nổi bật của sản phẩm</p></div>\r\n                    \r\n                        ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "cart-btn d-flex mb-50");
            __builder.AddMarkupContent(61, "<p>Số Lượng</p>\r\n                            ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "quantity ml-3");
            __builder.OpenElement(64, "input");
            __builder.AddAttribute(65, "type", "number");
            __builder.AddAttribute(66, "class", "qty-text w-100");
            __builder.AddAttribute(67, "id", "qty");
            __builder.AddAttribute(68, "step", "1");
            __builder.AddAttribute(69, "min", "1");
            __builder.AddAttribute(70, "max", "300");
            __builder.AddAttribute(71, "name", "quantity");
            __builder.AddAttribute(72, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 160 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\ChiTietSanPham.razor"
                                                                                                                                        soLuongMua

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(73, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => soLuongMua = __value, soLuongMua, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(74, "\r\n                        ");
            __builder.OpenElement(75, "button");
            __builder.AddAttribute(76, "type", "submit");
            __builder.AddAttribute(77, "name", "addtocart");
            __builder.AddAttribute(78, "class", "btn amado-btn");
            __builder.AddAttribute(79, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 163 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\ChiTietSanPham.razor"
                                                                                               AddToCart

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(80, "Thêm vào giỏ hàng");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n        ");
            __builder.AddMarkupContent(82, @"<div class=""row m-sm-2 ml-50 ""><div id=""form""><form id=""waterform"" method=""post""><div class=""formgroup"" id=""message-form""><label for=""message"">Nhận Xét</label>
                        <textarea id=""message"" name=""message""></textarea></div>

                    <input class=""mt-2"" type=""submit"" value=""Góp ý""></form></div></div>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ICartService _cartService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackbar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private R4CloThes.Client.Helpers.IAPIHelper _apihelper { get; set; }
    }
}
#pragma warning restore 1591
