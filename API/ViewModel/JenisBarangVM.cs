using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.ViewModel
{
    public class JenisBarangVM
    {

        public int Id { get; set; }
        public string Jenis_Barang { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<DateTimeOffset> CreateDate { get; set; }
        public Nullable<DateTimeOffset> UpdateDate { get; set; }
        public Nullable<DateTimeOffset> DeleteDate { get; set; }

        public class Jenis_BarangJson
        {
            [JsonProperty("data")]
            public IList<JenisBarangVM> data { get; set; }
        }
    }
}
