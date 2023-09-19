namespace Nhomthuctap_5.ViewsModel
{
	public class ChiTietSPVM
	{
		public Guid Id { get; set; }
		public string TenSanPham { get; set; }
		public string MauSac { get; set; }
		public decimal Size { get; set; }
		public int? GiaTriSale { get; set; }
		public string NhaSanXuat { get; set; }
		public string LoaiGiay { get; set; }
		public decimal GiaBan { get; set; }
		public decimal GiaSale { get; set; }
		public int Soluong { get; set; }
		public string MoTa { get; set; }
		public int TrangThai { get; set; }
	}
}
