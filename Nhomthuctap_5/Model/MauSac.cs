namespace Nhomthuctap_5.Model
{
	public class MauSac
	{
		public Guid IdMauSac { get; set; }
		public string TenMauSac { get; set; }
		public virtual IEnumerable<SanPhamChiTiet> SanPhamct { get; set; }
	}
}
