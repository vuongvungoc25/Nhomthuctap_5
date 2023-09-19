namespace Nhomthuctap_5.Model
{
	public class Giay
	{
		public Guid IdGiay { get; set; }
		public string TenGiay { get; set; }
		public virtual IEnumerable<SanPhamChiTiet> SanPhamct { get; set; }
	}
}
