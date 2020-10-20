using API.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    [Table("TB_Pembelian")]
    public class Pembelian : IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime TanggalPembelian { get; set; }
        public int Harga_Satuan { get; set; }
        public int Jumlah_Pembelian { get; set; }
        public int Harga_Total_Pembelian { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<DateTimeOffset> CreateDate { get; set; }
        public Nullable<DateTimeOffset> UpdateDate { get; set; }
        public Nullable<DateTimeOffset> DeleteDate { get; set; }

        public Barang Barang { get; set; }
        [ForeignKey("Barang")]
        public int Barang_Id { get; set; }
    }
}