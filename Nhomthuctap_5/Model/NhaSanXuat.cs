namespace Nhomthuctap_5.Model
{
	public class NhaSanXuat
	{
		public Guid IdNSX { get; set; }
		public string TenNSX { get; set; }
		public virtual IEnumerable<SanPhamChiTiet> SanPhamct { get; set; }
	}
}
