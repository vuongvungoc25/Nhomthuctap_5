namespace Nhomthuctap_5.Model
{
	public class Voucher
	{
		public Guid IDVoucher { get; set; }
		public Guid IdHoadon { get; set; }
		public Guid IdKhachHang { get; set; }
		public string MaVoucher { get; set; }
		public DateTime NgayTao { get; set; }
		public decimal Dieukien { get; set; }
		public DateTime NgayBatDau { get; set; }
		public DateTime NgayKetThuc { get; set; }
		public decimal GiaTriVoucher { get; set; }
		public int TrangThai { get; set; }
	}
}
