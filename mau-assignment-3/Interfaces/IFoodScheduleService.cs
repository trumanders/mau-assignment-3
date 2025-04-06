namespace mau_assignment_3.Interfaces;

public interface IFoodScheduleService : IListService<FoodSchedule>
{
	ObservableCollection<FoodSchedule> Items { get; }
}
