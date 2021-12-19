using Newtonsoft.Json;
using R4CloThes.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R4CloThes.Client.Pages
{
    public partial class SanPham
    {
        List<SanPhamViewModel> dssp = new List<SanPhamViewModel>();
        protected override async Task OnInitializedAsync()
        {
            var res = await _apiHelper.GetRequestAsync("Sanphams/dssanpham", null);
            if (res != "-1")
            {
                dssp = JsonConvert.DeserializeObject<List<SanPhamViewModel>>(res);
            }
        }
    }
}
