namespace mau_assignment_3.Models.Mammals;

public class Gorilla : Mammal
{
	public int? ArmSpanInCentimeters { get; set; }
	public bool IsAlphaMale { get; set; }

	private FoodSchedule? _foodSchedule;

	public void ChestDrum()
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
		ArmSpanInCentimeters = string.IsNullOrEmpty(pageModel.ArmSpanInCentimeters) ? null : int.Parse(pageModel.ArmSpanInCentimeters!);
		IsAlphaMale = pageModel.IsAlphaMale;
	}
	public override string ToString()
	{
		return
			$"{base.ToString()}" +
			$"Arm span: {(ArmSpanInCentimeters == null
				? "" : (ArmSpanInCentimeters + (ArmSpanInCentimeters > 1 ? " centimeters" : " centimeter")))}\n" +
			$"Alpha male: {(IsAlphaMale ? "Yes" : "No")}\n";
	}
}
