namespace mau_assignment_3.Models;

public class FoodItem
{
	private readonly IListService<string> _ingredients;

	public string Name { get; set; }
	public ListService<string> Ingredients { get; }

	public FoodItem(IListService<string> ingredients)
	{
		_ingredients = ingredients;
	}

	public override string ToString() { return Name; }
}
