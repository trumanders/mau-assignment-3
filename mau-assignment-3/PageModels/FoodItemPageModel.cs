﻿namespace mau_assignment_3.PageModels
{
	public partial class FoodItemPageModel : INotifyPropertyChanged
	{
		private TaskCompletionSource<bool> _taskCompletionSource;

		public Task<bool> ShowDialogueAsync()
		{
			_taskCompletionSource = new TaskCompletionSource<bool>();
			return _taskCompletionSource.Task;
		}

		public event PropertyChangedEventHandler? PropertyChanged;
		public void OnPropertyChanged([CallerMemberName] string? propertyName = null)
			=> PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
