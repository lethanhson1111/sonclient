using Microsoft.AspNetCore.Components;
using Microsoft.Extensions.Configuration;
using Microsoft.JSInterop;
using Newtonsoft.Json;
using R4CloThes.Client.Helpers;
using R4CloThes.Client.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace R4CloThes.Client.Pages
{
    public partial class SanPham
    {
        [Inject] public HttpClient _client { get; set; }
        [Inject] public IConfiguration config { get; set; }
        [Inject] public IAPIHelper _apiHelper { get; set; }
        [Inject] public IJSRuntime jsRuntime { get; set; }
        public string loaisp { get; set; }
        public string giamgia { get; set; }
        List<SanPhamViewModel> dssp = null;
        private int totalPageQuantity { get; set; }
        private int currentPage = 1;
        protected override async Task OnInitializedAsync()
        {
            await LoadData();
        }
        private async Task SelectedPage(int page)
        {
            currentPage = page;
            await LoadData(page);
            await jsRuntime.InvokeVoidAsync("OnScrollEvent");
        }
        protected async Task LoadData(int page = 1, int quantityPerPage = 9)
        {
            var apiUrl = config.GetSection("API")["APIUrl"].ToString();
            HttpResponseMessage httpResponse = await _client.GetAsync(apiUrl + $"sanphams/dssanpham?page={page}&quantityPerPage={quantityPerPage}");
            var responseString = await httpResponse.Content.ReadAsStringAsync();
            totalPageQuantity = int.Parse(httpResponse.Headers.GetValues("soluongtrang").FirstOrDefault());
            dssp = System.Text.Json.JsonSerializer.Deserialize<List<SanPhamViewModel>>(responseString,
                new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }
        private async Task LocLoaiSanPham()
        {
            var res = await _apiHelper.GetRequestAsync("sanphams/splienquan?loaisp=" + loaisp, null);
            if (res != "-1")
            {
                dssp = JsonConvert.DeserializeObject<List<SanPhamViewModel>>(res);
            }
        }
        private async Task LocGiamGia()
        {
            var res = await _apiHelper.GetRequestAsync("sanphams/spgiamgia?giamgia=" + giamgia, null);
            if (res != "-1")
            {
                dssp = JsonConvert.DeserializeObject<List<SanPhamViewModel>>(res);
            }
            StateHasChanged();
        }

    }
}
