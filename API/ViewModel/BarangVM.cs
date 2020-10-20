using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModel
{
    public class BarangVM
    {
        public int Id { get; set; }
        public string Nama_Barang { get; set; }
        public int Stok { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<DateTimeOffset> CreateDate { get; set; }
        public Nullable<DateTimeOffset> UpdateDate { get; set; }
        public Nullable<DateTimeOffset> DeleteDate { get; set; }
        public int Jenis_Id { get; set; }
        public string Jenis_Barang { get; set; }

        public class BarangJson
        {
            [JsonProperty("data")]
            public IList<BarangVM> data { get; set; }
        }
    }
}