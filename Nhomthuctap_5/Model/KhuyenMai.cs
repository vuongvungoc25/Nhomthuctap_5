namespace Nhomthuctap_5.Model
{
	public class KhuyenMai
	{
		public Guid IdKhuyenMai { get; set; }
		public DateTime NgayBatDau { get; set; }
		public DateTime NgayKetThuc { get; set; }
		public int TrangThai { get; set; }
		public virtual IEnumerable<HoaDonChiTiet> HoaDonCT { get; set; } 
	}
}
