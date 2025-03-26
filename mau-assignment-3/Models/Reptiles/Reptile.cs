﻿namespace mau_assignment_3.Models.Reptiles;

public abstract class Reptile : Animal
{
	public int? TypicalNumberOfEggsLaid { get; set; }
	public override abstract FoodSchedule GetFoodSchedule();

	public void ShedSkin()
	{
		throw new NotImplementedException();
	}

	public override void MapFromPageModel(MainPageModel pageModel)
	{
		base.MapFromPageModel(pageModel);
		TypicalNumberOfEggsLaid = string.IsNullOrEmpty(pageModel.TypicalNumberOfEggsLaid) ? null : int.Parse(pageModel.TypicalNumberOfEggsLaid!);
	}
	public override string ToString()
	{
		return
			$"{base.ToString()}" +
			$"Typical number of eggs laid: {TypicalNumberOfEggsLaid}\n";
	}


}
