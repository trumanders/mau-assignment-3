﻿
using CommunityToolkit.Mvvm.ComponentModel;

namespace mau_assignment_3.Models;

public partial class FoodSchedule : ObservableObject
{
	[ObservableProperty]
	private string? _name;

	public ObservableCollection<string> FoodScheduleEvents { get; set; } = [];
}
