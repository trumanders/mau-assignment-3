namespace mau_assignment_3.Models.Reptiles;

public class Alligator : Reptile
{
	public int? JawStrengthPSI { get; set; }
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
}