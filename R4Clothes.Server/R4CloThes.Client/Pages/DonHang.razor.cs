﻿//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Linq;
//using System.Net.Http;
//using System.Threading.Tasks;

//namespace R4CloThes.Client.Pages
//{
//    public partial class DonHang
//    {
//        List<HoaDon> sp = null;
//        public enum TrangthaiHD
//        {
//            [Display(Name = "Hủy")]
//            Huy = -1,
//            [Display(Name = "Đang chờ xử lí")]
//            Dangchoxuli = 0,
//            [Display(Name = "Đã xác nhận")]
//            Daxacnhan = 1,
//            [Display(Name = "Đang giao")]
//            Danggiao = 2,
//            [Display(Name = "Đã giao")]
//            Dagiao = 3,
//        }
//        public class HoaDon
//        {
//            [Key]
//            public int Mahoadon { get; set; }
//            [Required]
//            [ForeignKey("KhachHang")]
//            public int Makhachhang { get; set; }
//            [Required]
//            [ForeignKey("QuanTri")]
//            public int Nguoiquantri { get; set; }

//            [Required, Range(0, double.MaxValue, ErrorMessage = "Bạn cần nhập giá.")]
//            [Display(Name = "Tổng tiền")]
//            public double Tongtien { get; set; }

//            [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
//            [Required(ErrorMessage = "Bạn cần chọn ngày."), Display(Name = "Ngày đặt")]
//            public DateTime Ngaydat { get; set; }

//            [Display(Name = "Trạng thái")]
//            public TrangthaiHD Trangthai { get; set; }

//        }
//        protected override async Task OnInitializedAsync()
//        {
//            using (var client = new HttpClient())
//            {
//                var ss = await client.GetStringAsync("");
//                Console.WriteLine(ss);
//                sp = JsonConvert.DeserializeObject<List<HoaDon>>(ss);
//            }
//        }
//    }
//}
