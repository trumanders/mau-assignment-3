namespace mau_assignment_3.Interfaces;

public interface IListService<T>
{
	public int Count { get; set; }
	public bool Add(T type);

	public bool ChangeAt(T type, int index);

	public bool CheckIndex(int index);

	public void DeleteAll();

	public void DeleteAt(int index);

	public T GetAt(int index);

	public string[] ToStringArray();

	public List<string> ToStringList();
}