namespace Nhomthuctap_5.Model
{
	public class NguoiDung
	{
		public Guid Id { get; set; }
		public string Name { get; set; }
		public DateTime NgayTao { get; set; }
		public DateTime NgayCapNhap { get; set; }
		public string Email { get; set; }
		public string TenDangNhap {  get; set; }
		public string MatKhau { get; set; }
		public virtual IEnumerable<HoaDon> HoaDons { get; set; }
		public virtual IEnumerable<GioHang> GioHangs { get; set; }
		public virtual IEnumerable<Voucher> voucher { get; set; }
	}
}
