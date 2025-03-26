namespace mau_assignment_3.Interfaces
{
    public interface IAlertService
    {
		public Task ShowAlert(string title, string message, string closeButtonText);
    }
}
