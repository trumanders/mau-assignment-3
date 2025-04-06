namespace mau_assignment_3.Models.Mammals;

public class Bat : Mammal
{
	public int? WingAreaInCm2 { get; set; }

	private FoodSchedule? _foodSchedule;

	public void Echolocate()
	{
		throw new NotImplementedException();
	}
	public void Fly()
	{
		throw new NotImplementedException();
	}

	public override FoodSchedule GetFoodSchedule()
	{
		return _foodSchedule;
	}

	public override void MapFromPageModel(MainPageModel pageModel)
	{
		base.MapFromPageModel(pageModel);
		WingAreaInCm2 = string.IsNullOrEmpty(pageModel.WingAreaInCm2) ? null : int.Parse(pageModel.WingAreaInCm2!);
	}
	public override string ToString()
	{
		return
			$"{base.ToString()}" +
			$"Wing area: {(WingAreaInCm2 == null ? "" : WingAreaInCm2 + " cm²")}\n";
	}
}
