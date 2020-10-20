using API.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    [Table("TB_JenisBarang")]
    public class JenisBarang : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Jenis_Barang { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<DateTimeOffset> CreateDate { get; set; }
        public Nullable<DateTimeOffset> UpdateDate { get; set; }
        public Nullable<DateTimeOffset> DeleteDate { get; set; }

        public JenisBarang() { }

        public JenisBarang(JenisBarang JenisBarang)
        {
            this.Jenis_Barang = JenisBarang.Jenis_Barang;
            this.CreateDate = DateTimeOffset.Now;
            this.IsDelete = false;
        }

        public void Update(JenisBarang JenisBarang)
        {
            this.Jenis_Barang = JenisBarang.Jenis_Barang;
            this.UpdateDate = DateTimeOffset.Now;
        }

        public void Delete(JenisBarang JenisBarang)
        {
            this.IsDelete = true;
            this.DeleteDate = DateTimeOffset.Now;
        }
    }
}
