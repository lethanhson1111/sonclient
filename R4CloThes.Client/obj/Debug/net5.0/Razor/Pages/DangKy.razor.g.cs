#pragma checksum "D:\trinhduyet\sonclient\R4CloThes.Client\Pages\DangKy.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "443a8052666d19b073321eee6a8d291415461f58"
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
#line 1 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
using R4CloThes.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
using R4CloThes.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
using CloudinaryDotNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
using CloudinaryDotNet.Actions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "D:\trinhduyet\sonclient\R4CloThes.Client\_Imports.razor"
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
            __builder.AddMarkupContent(0, "<style>\r\n    \r\n.login-block{\r\n  /* fallback for old browsers */\r\nbackground: -webkit-linear-gradient(to bottom, #FFB88C, #DE6262);  /* Chrome 10-25, Safari 5.1-6 */\r\nfloat:left;\r\nwidth:100%;\r\npadding : 50px 0;\r\n}\r\n    .banner-sec {\r\n        background: url(https://i.bloganchoi.com/bloganchoi.com/wp-content/uploads/2020/09/hinh-nen-dien-thoai-dep-moi-nhat-63.jpg?fit=564%2C20000&quality=95&ssl=1) no-repeat left bottom;\r\n        background-size: cover;\r\n        min-height: 500px;\r\n        border-radius: 0 10px 10px 0;\r\n        padding: 0;\r\n    }\r\n.set{background:#fff; border-radius: 10px; box-shadow:15px 20px 0px rgba(0,0,0,0.1);}\r\n.carousel-inner{border-radius:0 10px 10px 0;}\r\n.carousel-caption{text-align:left; left:5%;}\r\n.login-sec{padding: 50px 30px; position:relative;}\r\n.login-sec .copy-text{position:absolute; width:80%; bottom:20px; font-size:13px; text-align:center;}\r\n.login-sec .copy-text i{color:#FEB58A;}\r\n.login-sec .copy-text a{color:#E36262;}\r\n.login-sec h2{margin-bottom:30px; font-weight:800; font-size:30px; color: #000000;}\r\n.login-sec h2:after{content:\" \"; width:100px; height:5px; background:#000000; display:block; margin-top:20px; border-radius:3px; margin-left:auto;margin-right:auto}\r\n    .btn-login {\r\n        background: #ce642e;\r\n        color: #fff;\r\n        font-weight: 600;\r\n        border-radius: 50px;\r\n    }\r\n.banner-text{width:70%; position:absolute; bottom:40px; padding-left:20px;}\r\n.banner-text h2{color:#fff; font-weight:600;}\r\n.banner-text h2:after{content:\" \"; width:100px; height:5px; background:#FFF; display:block; margin-top:20px; border-radius:3px;}\r\n.banner-text p{color:#fff;}\r\n</style>\r\n");
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
            __builder.AddMarkupContent(14, "<div class=\"form-group\"><label for=\"exampleInputEmail1\" class=\"text-uppercase\">Họ và tên</label>\r\n                            <input type=\"text\" class=\"form-control\" placeholder></div>\r\n                        ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "form-group");
            __builder.AddMarkupContent(17, "<label for=\"exampleInputEmail1\" class=\"text-uppercase\">Username</label>\r\n                            ");
            __builder.OpenElement(18, "input");
            __builder.AddAttribute(19, "type", "text");
            __builder.AddAttribute(20, "class", "form-control");
            __builder.AddAttribute(21, "placeholder", "");
            __builder.AddAttribute(22, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 52 "D:\trinhduyet\sonclient\R4CloThes.Client\Pages\DangKy.razor"
                                                                                           email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(23, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => email = __value, email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                        ");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "form-group");
            __builder.AddMarkupContent(27, "<label for=\"exampleInputPassword1\" class=\"text-uppercase\">Password</label>\r\n                            ");
            __builder.OpenElement(28, "input");
            __builder.AddAttribute(29, "type", "password");
            __builder.AddAttribute(30, "class", "form-control");
            __builder.AddAttribute(31, "placeholder", "");
            __builder.AddAttribute(32, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 56 "D:\trinhduyet\sonclient\R4CloThes.Client\Pages\DangKy.razor"
                                                                                               password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                        ");
            __builder.AddMarkupContent(35, "<div class=\"form-group\"><label class=\"control-label\">Ngày sinh</label>\r\n                            <input class=\"form-control\" type=\"date\"></div>\r\n                        ");
            __builder.OpenElement(36, "div");
            __builder.AddAttribute(37, "class", "form-check");
            __builder.OpenElement(38, "button");
            __builder.AddAttribute(39, "class", "btn btn-login float-right");
            __builder.AddAttribute(40, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 63 "D:\trinhduyet\sonclient\R4CloThes.Client\Pages\DangKy.razor"
                                                                                 Regis

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(41, "Đăng Ký");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.AddMarkupContent(43, "<div class=\"col-md-8 banner-sec\"><div id=\"carouselExampleIndicators\" class=\"carousel slide\" data-ride=\"carousel\"><div class=\"carousel-inner\" role=\"listbox\"><div class=\"carousel-item active\"></div></div></div></div>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\r\n");
            __builder.OpenElement(45, "h1");
            __builder.AddContent(46, "Loio : ");
            __builder.AddContent(47, 
#nullable restore
#line 80 "D:\trinhduyet\sonclient\R4CloThes.Client\Pages\DangKy.razor"
            res

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
