using API.Base;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API.Model
{
    [Table("TB_Karyawan")]
    public class Karyawan : IEntity
    {
        [Key]
        public int Id { get; set; }
        public string Nama { get; set; }
        public string Email { get; set; }
        public string NoHp { get; set; }
        public bool IsDelete { get; set; }
        public Nullable<DateTimeOffset> CreateDate { get; set; }
        public Nullable<DateTimeOffset> UpdateDate { get; set; }
        public Nullable<DateTimeOffset> DeleteDate { get; set; }

        public User User { get; set; }
        [ForeignKey("User")]
        public int Role_Id { get; set; }
    }
}
