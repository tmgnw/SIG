using API.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    [Table("TB_Barang")]
    public class Barang : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Nama_Barang { get; set; }
        public int Stok { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<DateTimeOffset> CreateDate { get; set; }
        public Nullable<DateTimeOffset> UpdateDate { get; set; }
        public Nullable<DateTimeOffset> DeleteDate { get; set; }

        public JenisBarang JenisBarang { get; set; }
        [ForeignKey("JenisBarang")]
        public int Jenis_Id { get; set; }
    }
}