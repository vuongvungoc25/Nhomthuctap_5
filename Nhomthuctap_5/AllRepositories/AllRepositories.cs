using Microsoft.EntityFrameworkCore;
using Nhomthuctap_5.Data;
using Nhomthuctap_5.IAllRepositories;

namespace Nhomthuctap_5.AllRepositories
{
	public class AllRepositories<T> : IAllRepositories<T> where T : class
	{
		Data_Context _Context;
		DbSet<T> _dbSet;
		public AllRepositories(Data_Context context, DbSet<T> dbSet)
		{
			_Context = context;
			_dbSet = dbSet;
		}
		public AllRepositories() { }
		public bool CreateNewItem(T item)
		{
			try
			{
				_dbSet.Add(item);
				_Context.SaveChanges();
				return true;
			}
			catch 
			{
				return false;
			}
		}

		public bool DeleteItem(T item)
		{
			try
			{
				_dbSet.Remove(item);
				_Context.SaveChanges();
				return true;
			}
			catch 
			{
				return false;
			}
		}

		public bool DeleteItemByID(Guid id)
		{
			try
			{
				var idcartdetail = _Context.gioHangCTs.FirstOrDefault(p => p.IdGioHangCT == id);
				_Context.Remove(idcartdetail);
				_Context.SaveChanges();
				return true;
			}
			catch 
			{
				return false;
			}
		}

		public IEnumerable<T> GetAll()
		{
			return _dbSet.ToList();
		}

		public bool UpdateItem(T item)
		{
			try
			{
				_dbSet.Update(item);
				_Context.SaveChanges();
				return true;
			}
			catch 
			{
				return false;
			}
		}
	}
}
