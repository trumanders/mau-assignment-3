namespace mau_assignment_3.Models.Birds;

public class Eagle : Bird
{

	public int? TalonsLengthInMillimeters { get; set; }
	public bool HasPermanentInjury { get; set; }
	private FoodSchedule? _foodSchedule;


	public Eagle()
	{
		SetFoodSchedule();
	}
	public void Soar()
	{
		throw new NotImplementedException();
	}
	public void Fly()
	{
		throw new NotImplementedException();
	}

	public override void MapFromPageModel(MainPageModel pageModel)
	{
		base.MapFromPageModel(pageModel);
		TalonsLengthInMillimeters = string.IsNullOrEmpty(pageModel.TalonsLengthInMillimeters) ? null : int.Parse(pageModel.TalonsLengthInMillimeters!);
		HasPermanentInjury = pageModel.HasPermanentInjury;
	}

	public override string ToString()
	{
		return
			$"{base.ToString()}" +
			$"Talons length: {(TalonsLengthInMillimeters == null
				? "" : (TalonsLengthInMillimeters + (TalonsLengthInMillimeters > 1 ? " millimeters" : " millimeter")))}\n" +
			$"Has permanent injury: {(HasPermanentInjury ? "Yes" : "No")}\n";
	}

	public override FoodSchedule? GetFoodSchedule()
	{
		return _foodSchedule;
	}

	private void SetFoodSchedule()
	{
		_foodSchedule = new FoodSchedule();
		_foodSchedule.Add("Lunch: Small bone-in meats (chicken necks, rabbit parts)");
		_foodSchedule.Add("Evening: Occasional fasting day to mimic natural hunting");
		_foodSchedule.Add("Morning: Whole prey (rats, quail, or fish)");
	}
}

