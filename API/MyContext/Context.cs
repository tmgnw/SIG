using API.Model;
using Microsoft.EntityFrameworkCore;

namespace API.MyContext
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Barang> Barangs { get; set; }
        public DbSet<JenisBarang> JenisBarangs { get; set; }
        public DbSet<User> User { get; set; }
        //public DbSet<BarangKeluar> BarangKeluars { get; set; }
        //public DbSet<BarangMasuk> BarangMasuks { get; set; }
        //public DbSet<Karyawan> Karyawans { get; set; }
        //public DbSet<Pembelian> Pembelians { get; set; }
        //public DbSet<Penjualan> penjualans { get; set; }
        //public DbSet<TipeBarang> tipeBarangs { get; set; }
    }
}