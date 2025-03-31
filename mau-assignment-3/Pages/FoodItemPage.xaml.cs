namespace mau_assignment_3.Pages;

public partial class FoodItemPage : ContentPage
{
	MainPageModel _mainPageModel;
	public FoodItemPage(MainPageModel mainPageModel)
	{
		InitializeComponent();
		_mainPageModel = mainPageModel;
		_mainPageModel.IsMainPageBlocked = true;
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
		_mainPageModel.OnFoodItemPageClose();
	}
}