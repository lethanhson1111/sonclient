using Microsoft.AspNetCore.Components;
using Newtonsoft.Json;
using R4CloThes.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R4CloThes.Client.Pages
{
    public partial class GiamGia
    {
        public string id { get; set; }
        List<SanPhamViewModel> dsspgg = new List<SanPhamViewModel>();
        protected async Task loaddata(int giamgia)
        {
            dsspgg.Clear();
            var res = await _apiHelper.GetRequestAsync("Sanphams/spgiamgia?giamgia=" + giamgia, null);
            if (res != "-1")
            {
                dsspgg = JsonConvert.DeserializeObject<List<SanPhamViewModel>>(res);
            }
        }
        protected override async Task OnInitializedAsync()
        {
            var ros = await _apiHelper.GetRequestAsync("Sanphams/spgiamgia?giamgia=0", null);
            if (ros != "-1")
            {
                dsspgg = JsonConvert.DeserializeObject<List<SanPhamViewModel>>(ros);
            }
        }
    }
}
