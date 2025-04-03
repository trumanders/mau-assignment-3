﻿namespace mau_assignment_3.Interfaces;
public interface IAlertService
{
	public Task ShowAlert(string title, string message, string closeButtonText);
	public Task ShowEditErrorAlert();
	public Task ShowInfoStringsAlert(IEnumerable<string> animalInfo);
	public Task ShowInvalidInputAlert(string message);
	public Task ShowDeleteErrorAlert();
	public Task ShowSuccessfulEditAlert();
	public Task ShowNoItemSelectedAlert();
}
