
using Newtonsoft.Json;
using R4CloThes.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R4CloThes.Client.Pages
{
    public partial class Yeuthich
    {
       
        private string token = null;
        private string idkhachhang;
        private List<SanPhamViewModel> sanPhams = new List<SanPhamViewModel>();
        protected override async Task OnInitializedAsync()
        {
            token = await localStorage.GetItemAsync<string>("token");
            idkhachhang = await localStorage.GetItemAsync<string>("khachhangid");

            if (token == null)
            {
                nav.NavigateTo("/");
            }
            else
            {
                string url = "YeuThichs/khachhang?idkhachhang=" + idkhachhang;
                var res = await _apiHelper.GetRequestAsync(url, token);
                if (res != "-1")
                {
                    sanPhams = JsonConvert.DeserializeObject<List<SanPhamViewModel>>(res);
                }
            }
        }
    }
}
