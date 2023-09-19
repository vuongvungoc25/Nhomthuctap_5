using System.Drawing;

namespace Nhomthuctap_5.Model
{
	public class SanPhamChiTiet
	{
		public Guid IdGiay { get; set; }
		public decimal GiaTien { get; set; }
		public int SoLuong { get; set; }
		public Guid? IdKhuyenMai { get; set; }
		public decimal GiaKM { get; set; }
		public string MoTa { get; set; }
		public DateTime ThoiGianBaoHanh { get; set; }
		public int TrangThai { get; set; }
		public Guid IdSize { get; set; }
		public Guid IdNSX { get; set; }
		public Guid IdLoaiGiay { get; set; }
		public Guid IdMauSac { get; set; }
		public virtual Giay giay { get; set; }
		public virtual MauSac Mau { get; set; }
		public virtual SizeGiay Size { get; set; }
		public virtual NhaSanXuat NSX { get; set; }
		public virtual LoaiGiay loaigiay { get; set; }
		public virtual KhuyenMai khuyenmai { get; set; }

		// cho khoa ngoai cua hoadonct va gio hang chi tiet
		public virtual IEnumerable<HoaDonChiTiet> HoaDonCT { get; set; }

		public virtual IEnumerable<GioHangCT> GioHangCTs { get; set; }

	}
}
