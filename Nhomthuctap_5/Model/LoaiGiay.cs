using System.Reflection.Metadata;

namespace Nhomthuctap_5.Model
{
	public class LoaiGiay
	{
		public Guid IdLoaiGiay { get; set; }
		public string TenLoaiGiay { get; set; }
		public virtual IEnumerable<SanPhamChiTiet> SanPhamct { get; set; }
	}
}
