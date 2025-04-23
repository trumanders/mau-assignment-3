namespace mau_assignment_3.Models.Reptiles;

public class Komodo : Reptile
{
	public bool IsPartOfBreedingProgram { get; set; }

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
}
