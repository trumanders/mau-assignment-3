namespace mau_assignment_3.Models.Reptiles;

public class Komodo : Reptile
{
	public bool IsPartOfBreedingProgram { get; set; }

	private FoodSchedule? _foodSchedule;

	public Komodo()
	{
		SetFoodSchedule();
	}

	public void Venomize()
	{
		throw new NotImplementedException();
	}

	public override void MapFromPageModel(MainPageModel pageModel)
	{
		base.MapFromPageModel(pageModel);
		IsPartOfBreedingProgram = pageModel.IsPartOfBreedingProgram;
	}
	public override string ToString()
	{
		return
			$"{base.ToString()}" +
			$"Part of breeding program: {(IsPartOfBreedingProgram ? "Yes" : "No")}\n";
	}

	public override FoodSchedule? GetFoodSchedule()
	{
		return _foodSchedule;
	}

	private void SetFoodSchedule()
	{
		_foodSchedule = new FoodSchedule();
		_foodSchedule.Add("Morning: Whole prey (rats, rabbits, chickens)");
		_foodSchedule.Add("Lunch: Whole rodents, eggs, small goats");
		_foodSchedule.Add("Evening: Larger mammals (deer, wild boar), occasional fish");
	}
}
