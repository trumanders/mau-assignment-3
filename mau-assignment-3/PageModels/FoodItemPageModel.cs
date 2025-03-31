using System.Threading.Tasks;

namespace mau_assignment_3.PageModels
{
	public class FoodItemPageModel : INotifyPropertyChanged
	{
		private TaskCompletionSource<bool> _taskCompletionSource;

		public Task<bool> ShowDialogueAsync()
		{
			_taskCompletionSource = new TaskCompletionSource<bool>();
			return _taskCompletionSource.Task;
		}

		//public Command OkCommand => new(() =>
		//{
		//	_taskCompletionSource?.TrySetResult(true);
		//	ClosePage();
		//});

		public event PropertyChangedEventHandler? PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
			=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
