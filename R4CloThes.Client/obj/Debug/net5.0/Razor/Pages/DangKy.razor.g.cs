#pragma checksum "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DangKy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "665b152e56529bf7501bd46482fa67340bd317a0"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Dangky")]
    public partial class DangKy : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<style>\r\n    \r\n.login-block{\r\nbackground: #DE6262;  /* fallback for old browsers */\r\nbackground: -webkit-linear-gradient(to bottom, #FFB88C, #DE6262);  /* Chrome 10-25, Safari 5.1-6 */\r\nbackground: linear-gradient(to bottom, #FFB88C, #DE6262); /* W3C, IE 10+/ Edge, Firefox 16+, Chrome 26+, Opera 12+, Safari 7+ */\r\nfloat:left;\r\nwidth:100%;\r\npadding : 50px 0;\r\n}\r\n.banner-sec{background:url(https://static.pexels.com/photos/33972/pexels-photo.jpg)  no-repeat left bottom; background-size:cover; min-height:500px; border-radius: 0 10px 10px 0; padding:0;}\r\n.set{background:#fff; border-radius: 10px; box-shadow:15px 20px 0px rgba(0,0,0,0.1);}\r\n.carousel-inner{border-radius:0 10px 10px 0;}\r\n.carousel-caption{text-align:left; left:5%;}\r\n.login-sec{padding: 50px 30px; position:relative;}\r\n.login-sec .copy-text{position:absolute; width:80%; bottom:20px; font-size:13px; text-align:center;}\r\n.login-sec .copy-text i{color:#FEB58A;}\r\n.login-sec .copy-text a{color:#E36262;}\r\n.login-sec h2{margin-bottom:30px; font-weight:800; font-size:30px; color: #DE6262;}\r\n.login-sec h2:after{content:\" \"; width:100px; height:5px; background:#FEB58A; display:block; margin-top:20px; border-radius:3px; margin-left:auto;margin-right:auto}\r\n.btn-login{background: #DE6262; color:#fff; font-weight:600;}\r\n.banner-text{width:70%; position:absolute; bottom:40px; padding-left:20px;}\r\n.banner-text h2{color:#fff; font-weight:600;}\r\n.banner-text h2:after{content:\" \"; width:100px; height:5px; background:#FFF; display:block; margin-top:20px; border-radius:3px;}\r\n.banner-text p{color:#fff;}\r\n</style>\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "cart-table-area mt-50");
            __builder.OpenElement(3, "section");
            __builder.AddAttribute(4, "class", "login-block");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "set");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "row");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "col-md-4 login-sec");
            __builder.AddMarkupContent(11, "<h2 class=\"text-center\">Đăng Ký</h2>\r\n                    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "login-form");
            __builder.OpenElement(14, "div");
            __builder.AddAttribute(15, "class", "form-group");
            __builder.AddMarkupContent(16, "<label for=\"exampleInputEmail1\" class=\"text-uppercase\">Họ và tên</label>\r\n                            ");
            __builder.OpenElement(17, "input");
            __builder.AddAttribute(18, "type", "text");
            __builder.AddAttribute(19, "class", "form-control");
            __builder.AddAttribute(20, "placeholder", "");
            __builder.AddAttribute(21, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 40 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DangKy.razor"
                                                                            khachhang.Tenkhachhang

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(22, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.Tenkhachhang = __value, khachhang.Tenkhachhang));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "form-group");
            __builder.AddMarkupContent(26, "<label for=\"exampleInputEmail1\" class=\"text-uppercase\">Email</label>\r\n                            ");
            __builder.OpenElement(27, "input");
            __builder.AddAttribute(28, "type", "text");
            __builder.AddAttribute(29, "class", "form-control");
            __builder.AddAttribute(30, "placeholder", "");
            __builder.AddAttribute(31, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 44 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DangKy.razor"
                                                                                           khachhang.Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(32, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.Email = __value, khachhang.Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n                        ");
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "form-group");
            __builder.AddMarkupContent(36, "<label class=\"control-label\">Số điện thoại</label>\r\n                            ");
            __builder.OpenElement(37, "input");
            __builder.AddAttribute(38, "class", "form-control");
            __builder.AddAttribute(39, "type", "password");
            __builder.AddAttribute(40, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 48 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DangKy.razor"
                                                                khachhang.Sodienthoai

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(41, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.Sodienthoai = __value, khachhang.Sodienthoai));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                        ");
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "form-check");
            __builder.OpenComponent<MudBlazor.MudDatePicker>(45);
            __builder.AddAttribute(46, "Label", "Ngay sinh");
            __builder.AddAttribute(47, "Editable", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 51 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DangKy.razor"
                                                                           true

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(48, "Placeholder", "Select Date");
            __builder.AddAttribute(49, "Date", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.DateTime?>(
#nullable restore
#line 51 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DangKy.razor"
                                                                                             date

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(50, "DateChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.DateTime?>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.DateTime?>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => date = __value, date))));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n                        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "form-group");
            __builder.AddMarkupContent(54, "<label for=\"exampleInputPassword1\" class=\"text-uppercase\">Mật khẩu</label>\r\n                            ");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "type", "password");
            __builder.AddAttribute(57, "class", "form-control");
            __builder.AddAttribute(58, "placeholder", "");
            __builder.AddAttribute(59, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 55 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DangKy.razor"
                                                                                               khachhang.Matkhau

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(60, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => khachhang.Matkhau = __value, khachhang.Matkhau));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n                        ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "form-group");
            __builder.AddMarkupContent(64, "<label class=\"control-label\">Nhập lại mật khẩu</label>\r\n                            ");
            __builder.OpenElement(65, "input");
            __builder.AddAttribute(66, "class", "form-control");
            __builder.AddAttribute(67, "type", "password");
            __builder.AddAttribute(68, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 59 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DangKy.razor"
                                                                confirmpwd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => confirmpwd = __value, confirmpwd));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n                        ");
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", "form-check");
            __builder.OpenElement(73, "button");
            __builder.AddAttribute(74, "class", "btn btn-login float-right");
            __builder.AddAttribute(75, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 62 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DangKy.razor"
                                                                                 Regis

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(76, "Đăng Ký");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(77, "\r\n                        <div class=\"form-check\"></div>\r\n                        ");
            __builder.OpenElement(78, "h6");
            __builder.AddAttribute(79, "class", "text-danger");
            __builder.AddContent(80, 
#nullable restore
#line 67 "F:\repos\R4Clothes.Server\R4CloThes.Client\Pages\DangKy.razor"
                                                 info

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                ");
            __builder.AddMarkupContent(82, "<div class=\"col-md-8 banner-sec\"><div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\"><div class=\"carousel-inner\" role=\"listbox\"><div class=\"carousel-item active\"></div></div></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ISnackbar _snackBar { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAPIHelper _apiHelper { get; set; }
    }
}
#pragma warning restore 1591
