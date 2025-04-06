namespace mau_assignment_3.Pages;

public partial class FoodSchedulePage : ContentPage
{
	MainPageModel _mainPageModel;
	public FoodSchedulePage(MainPageModel mainPageModel)
	{
		InitializeComponent();
		_mainPageModel = mainPageModel;
		_mainPageModel.IsMainPageBlocked = true;
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
		_mainPageModel.OnFoodSchedulePageClose();
	}
}