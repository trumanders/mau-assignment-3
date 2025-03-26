namespace mau_assignment_3.Models.Reptiles;

public class Chameleon : Reptile
{
	public int? TongueLengthInMillimeters { get; set; }
	public bool HasRegrownTail { get; set; }

	private FoodSchedule? _foodSchedule;

	public Chameleon()
	{
		SetFoodSchedule();
	}

	public void Camouflage()
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
		TongueLengthInMillimeters = string.IsNullOrEmpty(pageModel.TongueLengthInMillimeters) ? null : int.Parse(pageModel.TongueLengthInMillimeters!);
		HasRegrownTail = pageModel.HasRegrownTail;
	}
	public override string ToString()
	{
		return
			$"{base.ToString()}" +
			$"Tongue length : {(TongueLengthInMillimeters == null
				? "" : (TongueLengthInMillimeters + (TongueLengthInMillimeters > 1 ? " millimeters" : " millimeter")))}\n" +
			$"Regrown tail: {(HasRegrownTail ? "Yes" : "No")}\n";
	}
	private void SetFoodSchedule()
	{
		_foodSchedule = new FoodSchedule();
		_foodSchedule.Add("Morning: Insects (crickets, roaches, locusts)");
		_foodSchedule.Add("Lunch: Leafy greens (dandelion greens, collard greens)");
		_foodSchedule.Add("Evening: Small insects, occasional fruit (berries, mangoes)");
	}
}
