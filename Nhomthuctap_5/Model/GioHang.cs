namespace Nhomthuctap_5.Model
{
	public class GioHang
	{
		public Guid IDGioHang { get; set; }
		public Guid IdNguoiDung { get; set; }
		public DateTime NgayTao { get; set; }
		public virtual NguoiDung NguoiDung { get; set; }
		public virtual IEnumerable<GioHangCT> GioHangcts { get; set; }
	}
}
