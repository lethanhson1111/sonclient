using Microsoft.AspNetCore.Components.Forms;
using Newtonsoft.Json;
using R4Clothes.Client.Models;
using R4Clothes.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace R4CloThes.Client.Pages
{
    public partial class ThongTinKhachHang
    {
        private bool isLogin = false;
        private string url;
        public KhachHang kh = new KhachHang();
        IList<IBrowserFile> files = new List<IBrowserFile>();

        protected override async Task OnInitializedAsync()
        {
            string id = await localStorage.GetItemAsync<string>("khachhangid");
            string token = await localStorage.GetItemAsync<string>("token");
            if (id != null || id != "0")
            {
                nav.NavigateTo("/");
            }
            else
            {
                string res = await _apiHelper.GetRequestAsync("khachhangs/{id}", token);
                if (res != "-1")
                {
                    kh = JsonConvert.DeserializeObject<KhachHang>(res);
                }
                else
                {
                    nav.NavigateTo("/");
                }
            }
        }
        
        private async Task UploadFiles(InputFileChangeEventArgs e)
        {
            foreach (var file in e.GetMultipleFiles())
            {
                files.Add(file);
                // process loading
                url = await _uploadImage.GetUrlImage(file);
            }
            //TODO upload the files to the server
        }
    }
}
