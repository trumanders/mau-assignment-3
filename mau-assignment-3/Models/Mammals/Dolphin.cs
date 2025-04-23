﻿namespace mau_assignment_3.Models.Mammals;

public class Dolphin : Mammal
{
	public int? JumpHeightInCentimeters { get; set; }
	public bool HasUniqueMarkings { get; set; }

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
}
