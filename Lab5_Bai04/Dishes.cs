using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5_Bai04
{
    internal class Dishes
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("ten_mon_an")]
        public string TenMonAn { get; set; }

        [JsonProperty("gia")]
        public decimal Gia { get; set; }

        [JsonProperty("mo_ta")]
        public string MoTa { get; set; }

        [JsonProperty("hinh_anh")]
        public string HinhAnh { get; set; }

        [JsonProperty("dia_chi")]
        public string DiaChi { get; set; }

        [JsonProperty("nguoi_dong_gop")]
        public string NguoiDongGop { get; set; }
    }
}
