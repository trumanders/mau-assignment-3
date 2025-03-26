namespace mau_assignment_3.Services;

public class ListService<T> : IListService<T>
{
	private readonly List<T> _list = [];

	public int Count
	{ 
		get => throw new NotImplementedException(); 
		set => throw new NotImplementedException();
	}

	public bool Add(T type)
	{
		throw new NotImplementedException();
	}

	public bool ChangeAt(T type, int index)
	{
		throw new NotImplementedException();
	}

	public bool CheckIndex(int index)
	{
		throw new NotImplementedException();
	}

	public void DeleteAll()
	{
		throw new NotImplementedException();
	}

	public void DeleteAt(int index)
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
