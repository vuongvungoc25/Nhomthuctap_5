namespace Nhomthuctap_5.Model
{
	public class HoaDon
	{
		public Guid Id { get; set; }	
		public Guid IdND { get; set; }
		public string MaHd { get; set; }
		public DateTime NgayTao { get; set; }
		public string DiaChiShip { get; set; }
		public string SoDienThoai { get; set; }
		public string TenNguoiNhan { get; set; }
		public int TrangThai { get; set; }
		public virtual NguoiDung NguoiDung { get; set; }
		public virtual Voucher Voucher { get; set; }

		public virtual IEnumerable<HoaDonChiTiet> HoaDonCTs { get; set; }
	}
}
