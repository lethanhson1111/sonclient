#pragma checksum "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f443bdabbf3b9852dc922ef6f23c2ebac4394932"
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
#line 1 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
using R4CloThes.Client.Models;

#line default
#line hidden
#nullable disable
    public partial class DialogChiase : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<MudBlazor.MudDialog>(0);
            __builder.AddAttribute(1, "DialogContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudGrid>(2);
                __builder2.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenComponent<MudBlazor.MudItem>(4);
                    __builder3.AddAttribute(5, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 6 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                         6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(6, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenElement(7, "img");
                        __builder4.AddAttribute(8, "src", "https://res.cloudinary.com/r4clothes/image/upload/" + (
#nullable restore
#line 6 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                                                                                         sanpham.Hinh

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(9, "alt", "Alternate Text");
                        __builder4.CloseElement();
                    }
                    ));
                    __builder3.CloseComponent();
                    __builder3.AddMarkupContent(10, "\r\n            ");
                    __builder3.OpenComponent<MudBlazor.MudItem>(11);
                    __builder3.AddAttribute(12, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 7 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                         6

#line default
#line hidden
#nullable disable
                    ));
                    __builder3.AddAttribute(13, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.OpenComponent<MudBlazor.MudItem>(14);
                        __builder4.AddAttribute(15, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(17, "Tên sản phẩm: ");
                            __builder5.AddContent(18, 
#nullable restore
#line 8 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                                                sanpham.Tensanpham

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(19, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(20);
                        __builder4.AddAttribute(21, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 9 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(22, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(23, "Giá: ");
                            __builder5.AddContent(24, 
#nullable restore
#line 9 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                                       sanpham.Gia

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(25, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(26);
                        __builder4.AddAttribute(27, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 10 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(28, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(29, "Loại sản phẩm: ");
                            __builder5.AddContent(30, 
#nullable restore
#line 10 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                                                 sanpham.LoaiSanPhams

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(31, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(32);
                        __builder4.AddAttribute(33, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 11 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __builder5.AddMarkupContent(35, "Link sản phẩm: ");
                            __builder5.AddContent(36, 
#nullable restore
#line 11 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                                                 url

#line default
#line hidden
#nullable disable
                            );
                        }
                        ));
                        __builder4.CloseComponent();
                        __builder4.AddMarkupContent(37, "\r\n                ");
                        __builder4.OpenComponent<MudBlazor.MudItem>(38);
                        __builder4.AddAttribute(39, "xs", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 12 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                             12

#line default
#line hidden
#nullable disable
                        ));
                        __builder4.AddAttribute(40, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder5) => {
                            __Blazor.R4CloThes.Client.Pages.DialogChiase.TypeInference.CreateMudTextField_0(__builder5, 41, 42, 
#nullable restore
#line 12 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                                                                            Variant.Filled

#line default
#line hidden
#nullable disable
                            , 43, "Email người nhận", 44, 
#nullable restore
#line 12 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                                                            email

#line default
#line hidden
#nullable disable
                            , 45, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => email = __value, email)));
                        }
                        ));
                        __builder4.CloseComponent();
                    }
                    ));
                    __builder3.CloseComponent();
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.AddAttribute(46, "DialogActions", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.OpenComponent<MudBlazor.MudButton>(47);
                __builder2.AddAttribute(48, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                            Cancel

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(49, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(50, "Cancel");
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(51, "\r\n        ");
                __builder2.OpenComponent<MudBlazor.MudButton>(52);
                __builder2.AddAttribute(53, "Color", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<MudBlazor.Color>(
#nullable restore
#line 18 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                          Color.Primary

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(54, "OnClick", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 18 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
                                                  Submit

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(55, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(56, "Ok");
                }
                ));
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "F:\repos\R4Clothes.Client\R4CloThes.Client\Pages\DialogChiase.razor"
       
    [CascadingParameter] MudDialogInstance MudDialog { get; set; }
    private string url = null;
    [Inject] public NavigationManager nav { get; set; }
    [Inject] public ILocalStorageService localStorage { get; set; }
    [Inject] public IAPIHelper _apiHelper { get; set; }
    public string email { get; set; }
    public SanPhamViewModel sanpham = null;
    public ChiaSe chiase = null;
    public string id = null;
    public string token = null;

    protected override async Task OnInitializedAsync()
    {
        url = nav.Uri;
        sanpham = await localStorage.GetItemAsync<SanPhamViewModel>("sanpham");
        id = await localStorage.GetItemAsync<string>("khachhangid");
        token = await localStorage.GetItemAsync<string>("token");
    }

    private async Task Submit()
    {
        chiase.MaKhachHang = int.Parse(id);
        chiase.EmailNguoiNhan = email;
        chiase.HoTen = "aa";
        chiase.LinkSP = url;
        chiase.ThoiGian = DateTime.Now;
        chiase.MaSanPham = sanpham.Masanpham;
        var res = await _apiHelper.PostRequestAsync("sanphams/chiase", chiase, token);
    }
    void Cancel() => MudDialog.Cancel();

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.R4CloThes.Client.Pages.DialogChiase
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateMudTextField_0<T>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::MudBlazor.Variant __arg0, int __seq1, global::System.String __arg1, int __seq2, T __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<T> __arg3)
        {
        __builder.OpenComponent<global::MudBlazor.MudTextField<T>>(seq);
        __builder.AddAttribute(__seq0, "Variant", __arg0);
        __builder.AddAttribute(__seq1, "Label", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591