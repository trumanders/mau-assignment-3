namespace mau_assignment_3.Interfaces;

public interface IListService<T>
{
	public ObservableCollection<T> Items { get; set; }
	public int Count { get; set; }
	public bool Add(T type); 
	public bool ChangeAt(T type, int index);
	public bool CheckIndex(int index);
	public void DeleteAll();
	public bool DeleteAt(int index);
	public T GetAt(int index);
	public string[] ToStringArray();
}