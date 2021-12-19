using Newtonsoft.Json;
using R4CloThes.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R4CloThes.Client.Pages
{
    public partial class Index
    {
        List<SanPhamViewModel> dsspdb = new List<SanPhamViewModel>();
        List<SanPhamViewModel> dsspgg = new List<SanPhamViewModel>();
        protected override async Task OnInitializedAsync()
        {
            var res = await _apiHelper.GetRequestAsync("Sanphams/spdacbiet", null);
            var ros = await _apiHelper.GetRequestAsync("Sanphams/spgiamgia", null);
            if (res != "-1")
            {
                dsspdb = JsonConvert.DeserializeObject<List<SanPhamViewModel>>(res);
            }
            if (ros != "-1")
            {
                dsspgg = JsonConvert.DeserializeObject<List<SanPhamViewModel>>(ros);
            }
        }
    }
}
