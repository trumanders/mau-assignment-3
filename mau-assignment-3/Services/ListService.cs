namespace mau_assignment_3.Services;

public class ListService<T> : IListService<T>
{
	private readonly ObservableCollection<T> _items = [];

	public ObservableCollection<T> Items => _items;

	public int Count
	{ 
		get => throw new NotImplementedException(); 
		set => throw new NotImplementedException();
	}

	public bool Add(T objectToAdd)
	{
		if (objectToAdd == null || _items ==  null || _items.Contains(objectToAdd))
			return false;

		_items.Add(objectToAdd);
		return true;
	}

	public bool ChangeAt(T newItem, int index)
	{
		if (index < 0 || index >= _items.Count)
			return false;

		_items[index] = newItem;
		return true;
	}

	public bool CheckIndex(int index)
	{
		return index >= 0 && index < _items.Count;
	}

	public bool DeleteAt(int index)
	{
		if (!CheckIndex(index))
			return false;

		_items.RemoveAt(index);
		return true;
	}
	public void DeleteAll()
	{
		throw new NotImplementedException();
	}

	public T GetAt(int index)
	{
		throw new NotImplementedException();
	}

	public string[] ToStringArray()
	{
		throw new NotImplementedException();
	}

	public List<string> ToStringList()
	{
		throw new NotImplementedException();
	}


}
