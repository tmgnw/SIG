using API.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    [Table("TB_Penjualan")]
    public class Penjualan : IEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime TanggalPenjualan { get; set; }
        public int Harga_Satuan { get; set; }
        public int Jumlah_Penjualan { get; set; }
        public int Harga_Total_Penjualan { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<DateTimeOffset> CreateDate { get; set; }
        public Nullable<DateTimeOffset> UpdateDate { get; set; }
        public Nullable<DateTimeOffset> DeleteDate { get; set; }

        public Barang Barangs { get; set; }
        [ForeignKey("Barangs")]
        public int Barang_Id { get; set; }
    }
    }