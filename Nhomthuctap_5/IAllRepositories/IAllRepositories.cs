namespace Nhomthuctap_5.IAllRepositories
{
	public interface IAllRepositories<T>
	{
		public IEnumerable<T> GetAll();
		public bool CreateNewItem(T item);
		public bool DeleteItem(T item);
		public bool DeleteItemByID(Guid id);
		public bool UpdateItem(T item);
	}
}
