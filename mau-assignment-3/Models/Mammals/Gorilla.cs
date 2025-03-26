namespace mau_assignment_3.Models.Mammals;

public class Gorilla : Mammal
{
	public int? ArmSpanInCentimeters { get; set; }
	public bool IsAlphaMale { get; set; }

	private FoodSchedule? _foodSchedule;

	public Gorilla()
	{
		SetFoodSchedule();
	}

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
	private void SetFoodSchedule()
	{
		_foodSchedule = new FoodSchedule();
		_foodSchedule.Add("Morning: Fresh fruits (bananas, apples, pineapple), leafy greens");
		_foodSchedule.Add("Lunch: Vegetables (carrots, corn, yams), nuts, seeds");
		_foodSchedule.Add("Evening: Leafy greens (kale, spinach), protein-rich items (tofu, beans)");
	}
}
