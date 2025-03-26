namespace mau_assignment_3.Services
{
	class AlertService : IAlertService
	{
		/// <summary>
		/// Displays an alert based on the title, message and close button text provided
		/// </summary>
		/// <param name="title">The title of the alert</param>
		/// <param name="message">The message of the alert</param>
		/// <param name="closeButtonText">The text of the close button</param>
		/// <returns></returns>
		public async Task ShowAlert(string title, string message, string closeButtonText)
		{
			await Application.Current.Windows[0].Page.DisplayAlert(title, message, closeButtonText);
		}	
	}
}
