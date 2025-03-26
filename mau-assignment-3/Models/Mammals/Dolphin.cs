namespace mau_assignment_3.Models.Mammals;

public class Dolphin : Mammal
{
	public int? JumpHeightInCentimeters { get; set; }
	public bool HasUniqueMarkings { get; set; }

	private FoodSchedule? _foodSchedule;

	public Dolphin()
	{
		SetFoodSchedule();
	}

	public void Communicate()
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
		JumpHeightInCentimeters = string.IsNullOrEmpty(pageModel.JumpHeightInCentimeters) ? null : int.Parse(pageModel.JumpHeightInCentimeters!);
		HasUniqueMarkings = pageModel.HasUniqueMarkings;
	}

	public override string ToString()
	{
		return
			$"{base.ToString()}" +
			$"Jump height: {(JumpHeightInCentimeters == null
				? "" : (JumpHeightInCentimeters + (JumpHeightInCentimeters > 1 ? " centimeters" : " centimeter")))}\n" +
			$"Has unique markings: {(HasUniqueMarkings ? "Yes" : "No")}\n";
	}

	public override FoodSchedule GetFoodSchedule()
	{
		return _foodSchedule;
	}
	private void SetFoodSchedule()
	{
		_foodSchedule = new FoodSchedule();
		_foodSchedule.Add("Morning: Fish (sardines, mackerel, anchovies)");
		_foodSchedule.Add("Lunch: Squid, shrimp, or other shellfish");
		_foodSchedule.Add("Evening: Fish or squid, occasional enrichment feeding with larger prey");
	}
}
