using API.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace API.Model
{
    [Table("TB_BarangKeluar")]
    public class TipeBarang : IEntity
    {
        [Key]
        public int Id { get; set; }
        public int Jumlah_Barang_Keluar { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<DateTimeOffset> CreateDate { get; set; }
        public Nullable<DateTimeOffset> UpdateDate { get; set; }
        public Nullable<DateTimeOffset> DeleteDate { get; set; }

        public JenisBarang JenisBarangs { get; set; }
        [ForeignKey("JenisBarangs")]
        public int Jenis_Id { get; set; }
    }
}
