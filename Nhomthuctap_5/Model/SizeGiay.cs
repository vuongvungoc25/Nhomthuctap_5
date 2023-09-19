namespace Nhomthuctap_5.Model
{
	public class SizeGiay
	{
		public Guid ID_SizeGiay { get; set; }
		public decimal Sizegiay { get; set; }
		public virtual IEnumerable<SanPhamChiTiet> SanPhamct { get; set; }
	}
}
