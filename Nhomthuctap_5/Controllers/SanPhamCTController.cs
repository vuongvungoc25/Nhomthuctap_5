using Microsoft.AspNetCore.Mvc;
using Nhomthuctap_5.Data;
using Nhomthuctap_5.IAllRepositories;
using Nhomthuctap_5.Model;
using Nhomthuctap_5.ViewsModel;
using System.Drawing;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Nhomthuctap_5.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class SanPhamCTController : ControllerBase
	{
		private IAllRepositories<SanPhamChiTiet> iresposspct;
		private IAllRepositories<MauSac> iresposmausac;
		private IAllRepositories<SizeGiay> irespossize;
		private IAllRepositories<Giay> iresposgiay;
		private IAllRepositories<NhaSanXuat> iresposnsx;
		private IAllRepositories<LoaiGiay> iresposloaigiay;
		private IAllRepositories<KhuyenMai> iresposKM;

		private Data_Context _Context = new Data_Context();
		public SanPhamCTController(IAllRepositories<SanPhamChiTiet> iresposspct, IAllRepositories<MauSac> iresposmausac, IAllRepositories<SizeGiay> irespossize, IAllRepositories<Giay> iresposgiay, IAllRepositories<NhaSanXuat> iresposnsx, IAllRepositories<LoaiGiay> iresposloaigiay, IAllRepositories<KhuyenMai> iresposKM)
		{
			this.iresposspct = iresposspct;
			this.iresposmausac = iresposmausac;
			this.irespossize = irespossize;
			this.iresposgiay = iresposgiay;
			this.iresposnsx = iresposnsx;
			this.iresposloaigiay = iresposloaigiay;
			this.iresposKM = iresposKM;
		}
		[HttpGet]
		public IEnumerable<SanPhamChiTiet> GetAll()
		{
			return iresposspct.GetAll();
		}
		[HttpGet("[action]")]
		public IEnumerable<ChiTietSPVM> GetSanPhamChiTiet()
		{
			var spct = from a in _Context.sanPhamCTs
					   join b in _Context.giay on a.IdGiay equals b.IdGiay
					   join c in _Context.maus on a.IdMauSac equals c.IdMauSac
					   join d in _Context.sizes on a.IdSize equals d.ID_SizeGiay
					   join e in _Context.LoaiGiay on a.IdLoaiGiay equals e.IdLoaiGiay
					   join f in _Context.NSX on a.IdNSX equals f.IdNSX
					   join h in _Context.khuyenmai on a.IdKhuyenMai equals h.IdKhuyenMai
		}
	}
}
