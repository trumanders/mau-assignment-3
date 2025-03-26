namespace mau_assignment_3.Models.Reptiles;

public class Alligator : Reptile
{
	public int? JawStrengthPSI { get; set; }

	private FoodSchedule? _foodSchedule;

	public Alligator()
	{
		SetFoodSchedule();
	}

	public void Float()
	{
		throw new NotImplementedException();
	}

	public void Swim()
	{
		throw new NotImplementedException();
	}

	public override void MapFromPageModel(MainPageModel pageModel)
	{
		base.MapFromPageModel(pageModel);
		JawStrengthPSI = string.IsNullOrEmpty(pageModel.JawStrengthPSI) ? null : int.Parse(pageModel.JawStrengthPSI!);
	}
	public override string ToString()
	{
		return
			$"{base.ToString()}" +
			$"Jaw strength: {(JawStrengthPSI == null ? "" : JawStrengthPSI + " PSI")}\n";
	}

	public override FoodSchedule GetFoodSchedule()
	{
		return _foodSchedule;
	}
	private void SetFoodSchedule()
	{
		_foodSchedule = new FoodSchedule();
		_foodSchedule.Add("Morning: Whole fish (catfish, carp, tilapia)");
		_foodSchedule.Add("Lunch: Chicken or turkey (whole or parts, like wings, necks)");
		_foodSchedule.Add("Evening: Occasional mammal meat (rabbits, rodents)");
	}
}
