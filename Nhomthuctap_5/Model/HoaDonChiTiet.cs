namespace Nhomthuctap_5.Model
{
	public class HoaDonChiTiet
	{
		public Guid IdHoaDonChiTiet {  get; set; }
		public Guid IdHoaDon { get; set; }
		public Guid GiayChiTiet { get; set; }
		public int SoLuong { get; set; }
		public string DonGia { get; set; }
		public virtual HoaDon HoaDon { get; set; }
		public virtual SanPhamChiTiet SanPhamct { get; set; }
	}
}
