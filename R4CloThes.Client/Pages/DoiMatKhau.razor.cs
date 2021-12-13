using R4Clothes.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R4CloThes.Client.Pages
{
    public partial class DoiMatKhau
    {
        private string id = null;
        private string token = null;
        private KhachHang khachhang = null;
        private string matkhaucu = null;
        private string matkhaumoi = null;
        private string xacnhanmatkhau = null;
        private string Thongtin = null;
        protected override async Task OnInitializedAsync()
        {
            token = await _LocalService.GetItemAsync<string>("token");
            id = await _LocalService.GetItemAsync<string>("khachhangid");

            if(token == null)
            {
                _Nav.NavigateTo("/");
            }
            else
            {
                

            }
        }
        private void doimatkhau()
        {
            if(matkhaucu != matkhaumoi)
            {
                Thongtin = "Mat khau khong khop"; 
            }
            else
            {

            }
        }
    }
}
