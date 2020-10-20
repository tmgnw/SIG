using API.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    [Table("TB_BarangMasuk")]
    public class BarangMasuk : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Jumlah_Barang_Masuk { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<DateTimeOffset> CreateDate { get; set; }
        public Nullable<DateTimeOffset> UpdateDate { get; set; }
        public Nullable<DateTimeOffset> DeleteDate { get; set; }

        public Pembelian Pembelian { get; set; }
        [ForeignKey("Pembelian")]
        public int Pembelian_Id { get; set; }
    }
}