namespace mau_assignment_3.Interfaces;

public interface IAnimal
{
	public int Id { get; set; }
	public string PersonalName { get; set; }
	public Gender? Gender { get; set; }
	public FoodSchedule? GetFoodSchedule();
	public string ToString();
}
