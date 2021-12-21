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
        [Inject] public IDialogService dialogService { get; set; }
        public string token { get; set; }
        public bool isLogin = false;
        public bool isLoading = false;
        public bool checkFav = false;
        public string mau = "Color.Default";
        public string icon = "@Icons.Filled.FavoriteBorder";
        public string idkhachhang { get; set; }
        public string imgKhachhang { get; set; }
        public int soLuongMua { get; set; } = 1;
        public double SauGiamGia = 0;
        public SanPhamViewModel sanPham = new SanPhamViewModel();
        public List<DanhGiaSanPhamReturn> dsdanhgia = new List<DanhGiaSanPhamReturn>();
        public KhachHang khachhang = new KhachHang();
        public DanhGiaSanPham dgsp = new DanhGiaSanPham();
        protected override async Task OnInitializedAsync()
        {
            isLoading = true;
            await LoadKhachHang();
            idkhachhang = await localStorage.GetItemAsync<string>("khachhangid");
            token = await localStorage.GetItemAsync<string>("token");
            if (idkhachhang != null)
            {
                var re = await _apihelper.PostRequestAsync("yeuthichs/checkyeuthich?makhachhang=" + idkhachhang + "&masanpham=" + id, null, token);
                if (re != "-1")
                {
                    if (re == "true")
                    {
                        checkFav = true;
                        icon = "@Icons.Filled.Favorite";
                    }
                }
            }
            var res = await _apihelper.GetRequestAsync("sanphams/" + id, null);
            sanPham = JsonConvert.DeserializeObject<SanPhamViewModel>(res);
            SauGiamGia = sanPham.Gia - (sanPham.Gia * (double)sanPham.Giamgia / 100);

            var ros = await _apihelper.GetRequestAsync("DanhGiaSanPhams/" + id, null);
            if (ros != "-1")
            {
                dsdanhgia = JsonConvert.DeserializeObject<List<DanhGiaSanPhamReturn>>(ros);
            }
            isLoading = false;
        }
        private async Task BinhLuan()
        {
            isLoading = true;
            dgsp.MaDanhGiaSanPham = 0;
            dgsp.Makhachhang = int.Parse(idkhachhang);
            dgsp.Masanpham = int.Parse(id);
            dgsp.Thoigian = DateTime.Now;
            var res = await _apihelper.PostRequestAsync("danhgiasanphams", dgsp, token);
            if (res != "-1")
            {
                _snackbar.Add("Đã thêm thành công!", Severity.Success);

            }
            else
            {
                _snackbar.Add("Lỗi server", Severity.Error);
            }
            isLoading = false;
        }
        private async Task LoadKhachHang()
        {
            var res = await _apihelper.GetRequestAsync("khachhangs/" + idkhachhang, token);
            if (res != "-1")
            {
                isLogin = true;
                khachhang = JsonConvert.DeserializeObject<KhachHang>(res);
                imgKhachhang = "https://res.cloudinary.com/r4clothes/image/upload/" + khachhang.Hinh;
            }
        }
        private async Task AddToCart()
        {
            await _cartService.AddToCart(new SanPhamGioHang {SanPham = sanPham, SoLuong = soLuongMua });
        }
        private async Task AddFav()
        {
            if (checkFav == false)
            {
                //var res = await _apihelper.PostRequestAsync("")
            }
        }
        private async Task chiase()
        {

        }
        private async Task OpenDialog()
        {
            await localStorage.SetItemAsync("sanpham", sanPham);
            dialogService.Show<DialogChiase>("Chia sẻ sản phẩm này đến với bạn bè của bạn");
        }
    }
}
