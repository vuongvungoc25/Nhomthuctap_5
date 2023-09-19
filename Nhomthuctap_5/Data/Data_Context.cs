using Microsoft.EntityFrameworkCore;
using Nhomthuctap_5.Model;
using System.Drawing;

namespace Nhomthuctap_5.Data
{
	public class Data_Context : DbContext
	{
		public Data_Context() { }
		public Data_Context(DbContextOptions<Data_Context> options) : base(options) { }
		public DbSet<KhuyenMai> khuyenmai { get; set; }
		public DbSet<Giay> giay { get; set; }
		public DbSet<SanPhamChiTiet> sanPhamCTs { get; set; }
		public DbSet<MauSac> maus { get; set; }
		public DbSet<NhaSanXuat> NSX { get; set; }
		public DbSet<SizeGiay> sizes { get; set; }
		public DbSet<LoaiGiay> LoaiGiay { get; set; }
		public DbSet<Voucher> voucher { get; set; }
		public DbSet<GioHang> gioHangs { get; set; }
		public DbSet<GioHangCT> gioHangCTs { get; set; }
		public DbSet<HoaDon> hoaDons { get; set; }
		public DbSet<HoaDonChiTiet> hoaDoncts { get; set; }
		public DbSet<NguoiDung> nguoiDungs { get; set; }

	}
}
