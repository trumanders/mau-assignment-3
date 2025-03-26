namespace mau_assignment_3.Interfaces;

public interface IPropertyValidator
{
	public string GetValidationErrorMessages();
	public bool ValidateProperties(MainPageModel pageModel);
}
