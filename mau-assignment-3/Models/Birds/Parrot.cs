﻿namespace mau_assignment_3.Models.Birds;

public class Parrot : Bird
{
	public int? VocabularySize { get; set; }
	public bool IsTrainedForPerformance { get; set; }
	private FoodSchedule? _foodSchedule;

	public void Mimic()
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
		VocabularySize = string.IsNullOrEmpty(pageModel.VocabularySize) ? null : int.Parse(pageModel.VocabularySize!);
		IsTrainedForPerformance = pageModel.IsTrainedForPerformance;
	}
	public override string ToString()
	{
		return
			$"{base.ToString()}" +
			$"Vocabulary size: {(VocabularySize == null
				? "" : (VocabularySize + (VocabularySize > 1 ? " words" : " word")))}\n" +
			$"Trained for performance: {(IsTrainedForPerformance ? "Yes" : "No")}\n";
	}

	public override FoodSchedule GetFoodSchedule()
	{
		return _foodSchedule;
	}
}
