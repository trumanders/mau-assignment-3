namespace mau_assignment_3.Models.Reptiles;

public class Alligator : Reptile
{
	public int? JawStrengthPSI { get; set; }

	private FoodSchedule? _foodSchedule;

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
}