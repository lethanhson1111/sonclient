using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using R4CloThes.Client.Models.ViewModel;
using R4CloThes.Client.Models;
using MudBlazor;
using R4Clothes.Client.Models;

namespace R4CloThes.Client.Pages
{
    public partial class ChiTietSanPham
    {
        [Parameter]
        public string id { get; set; }
        public int soLuongMua { get; set; } = 1;
        public double SauGiamGia = 0;
        public SanPhamViewModel sanPham = new SanPhamViewModel();
        List<DanhGiaSanPham> dsdanhgia = new List<DanhGiaSanPham>();

        protected override async Task OnInitializedAsync()
        {
            var res = await _apihelper.GetRequestAsync("sanphams/" + id, null);
            sanPham = JsonConvert.DeserializeObject<SanPhamViewModel>(res);
            SauGiamGia = sanPham.Gia - (sanPham.Gia * (double)sanPham.Giamgia / 100);
            var ros = await _apihelper.GetRequestAsync("DanhGiaSanPhams/" + id, null);
            dsdanhgia = JsonConvert.DeserializeObject<List<DanhGiaSanPham>>(ros);
        }

        private async Task AddToCart()
        {
            await _cartService.AddToCart(new SanPhamGioHang {SanPham = sanPham, SoLuongMua = soLuongMua });
        }
    }
}
