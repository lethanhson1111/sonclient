using R4CloThes.Client.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R4CloThes.Client.Pages
{
    public partial class Cart
    {
        private bool isLoading = false;
        private List<SanPhamGioHang> listSanPham = null;
        private string id = null;
        protected override async Task OnInitializedAsync()
        {
            listSanPham = await localStorage.GetItemAsync<List<SanPhamGioHang>>("cart");
            id = await localStorage.GetItemAsync<string>("khachhangid");
        }
        private async Task UpdateCart(SanPhamGioHang sp)
        {
            int index = listSanPham.IndexOf(sp);
            listSanPham[index].SoLuongMua = sp.SoLuongMua;
            await localStorage.SetItemAsync("cart", listSanPham);
        }
        private double TinhTien(SanPhamGioHang sp)
        {
            return sp.SanPham.Gia * (double)sp.SoLuongMua;
        }
        private double TongTien()
        {
            double tt = 0;
            foreach (var item in listSanPham)
            {
                tt += item.SanPham.Gia * item.SoLuongMua;
            }
            return tt;
        }
        private async Task DatHang()
        {
            isLoading = true;
            var token = await localStorage.GetItemAsync<string>("token");
            GioHang giohang = new GioHang();
            giohang.MaKhachHang = int.Parse(id);
            giohang.ListViewCart = listSanPham;
            giohang.TongTien = TongTien();
            var res = await _apiHelper.PostRequestAsync("hoadons", giohang, token);
            if (res == "1")
            {
                nav.NavigateTo("/");
                await localStorage.RemoveItemAsync("cart");
            }
            isLoading = false;
        }
    }
}
