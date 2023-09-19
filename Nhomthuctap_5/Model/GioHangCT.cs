namespace Nhomthuctap_5.Model
{
	public class GioHangCT
	{
		public Guid IdGioHangCT { get; set; }
		public Guid IdGioHang { get; set; }
		public Guid IdSPCT { get; set; }
		public int SoLuong { get; set; }
		public decimal TongTien { get; set; }
		public virtual GioHang GioHang { get; set; }
		public virtual SanPhamChiTiet SanPhamCT { get; set; }
	}
}
