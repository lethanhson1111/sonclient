#pragma checksum "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7301bd665e1301444a3eebf0dc8ccb2cdbbbda75"
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
#nullable restore
#line 3 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"
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
#nullable restore
#line 5 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"
 if (dssp == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>Loading ...</p>");
#nullable restore
#line 8 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "mt-30");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "m-sm-auto");
            __builder.AddMarkupContent(5, @"<div class=""text-center""><h3 class=""h2"" style=""background-color:#ff6a00; color:aliceblue"">S???n ph???m ?????c bi???t</h3>
            <p style=""color:black"">
                ????y l?? nh???ng m???t h??ng ??ang ???????c ??a chu???ng nh???t hi???n nay t???i shop
            </p></div>
        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "d-inline-flex ml-30 ");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-group");
#nullable restore
#line 21 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"
                 for (int i = 0; i < dssp.Count; i++)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "single-products-catagory clearfix");
            __builder.OpenElement(12, "a");
            __builder.AddAttribute(13, "href", "/chitietsanpham/" + (
#nullable restore
#line 24 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"
                                                  dssp[i].Masanpham

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", "https://res.cloudinary.com/r4clothes/image/upload/" + (
#nullable restore
#line 25 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"
                                                                                         dssp[i].Hinh

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "alt", "productImg");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                            \r\n                            ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "hover-content");
            __builder.AddMarkupContent(20, "<div class=\"line\"></div>\r\n                                ");
            __builder.OpenElement(21, "p");
            __builder.AddMarkupContent(22, "Gi??: ");
            __builder.AddContent(23, 
#nullable restore
#line 29 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"
                                         string.Format("{0:#,##0.00}", dsspgg[i].Gia)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(24, "??");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                                ");
            __builder.OpenElement(26, "h4");
            __builder.AddContent(27, 
#nullable restore
#line 30 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"
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
#line 34 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"

                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.AddMarkupContent(29, @"<div class=""text-center mt-3""><h3 class=""h2"" style=""background-color:#ff6a00; color:aliceblue"">S???n ph???m gi???m gi??</h3>
            <p style=""color:black"">
                ????y l?? nh???ng m???t h??ng ??ang ???????c gi???m gi?? ?????c bi???t trong  ng??y h??m nay
            </p></div>
        ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "d-inline-flex ml-30 ");
            __builder.OpenElement(32, "div");
            __builder.AddAttribute(33, "class", "card-group");
#nullable restore
#line 46 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"
                 for (int i = 0; i < dsspgg.Count; i++)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(34, "div");
            __builder.AddAttribute(35, "class", "single-products-catagory clearfix");
            __builder.OpenElement(36, "a");
            __builder.AddAttribute(37, "href", "/chitietsanpham/" + (
#nullable restore
#line 49 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"
                                                  dsspgg[i].Masanpham

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenElement(38, "img");
            __builder.AddAttribute(39, "src", "https://res.cloudinary.com/r4clothes/image/upload/" + (
#nullable restore
#line 50 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"
                                                                                         dsspgg[i].Hinh

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(40, "alt");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                            \r\n                            ");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "hover-content");
            __builder.AddMarkupContent(44, "<div class=\"line\"></div>\r\n                                ");
            __builder.OpenElement(45, "p");
            __builder.AddMarkupContent(46, "Gi??: ");
            __builder.AddContent(47, 
#nullable restore
#line 54 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"
                                         string.Format("{0:#,##0.00}", dsspgg[i].Gia)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(48, "??");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                                ");
            __builder.OpenElement(50, "h4");
            __builder.AddContent(51, 
#nullable restore
#line 55 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"
                                     dsspgg[i].Tensanpham

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 59 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 64 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\Index.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private R4CloThes.Client.Helpers.IAPIHelper _apiHelper { get; set; }
    }
}
#pragma warning restore 1591
