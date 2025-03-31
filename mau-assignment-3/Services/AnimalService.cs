namespace mau_assignment_3.Services;

public class AnimalService : IAnimalService
{
	#region Private fields
	private IPropertyValidator _propertyValidator;
	private IAlertService _alertService;
	private static SortOption _previousSortOption;
	private static bool _isReverseOrder = false;
	private static bool _isAnimalAdded;

	private ObservableCollection<Animal> _animals = [];

	#endregion

	public ObservableCollection<Animal> Animals => _animals;

	#region Public methods
	public AnimalService(IPropertyValidator propertyValidator, IAlertService alertService)
	{
		_propertyValidator = propertyValidator;
		_alertService = alertService;
	}	

	/// <summary>
	/// Adds a validated animal to the list of animals based on the data from the page model
	/// </summary>
	/// <param name="pageModel">The page model containing the selected species and other properties</param>
	/// <returns>True: if the animal was added; False: if the animal was not added</returns>
	public bool Add(MainPageModel pageModel)
	{
		if (!ValidateProperties(pageModel))
			return false;

		try
		{
			var animal = CreateAnimal(pageModel);

			if (animal == null)
			{
				return false;
			}

			Animals.Add(animal);
			_isAnimalAdded = true;

			return true;
		}
		catch (Exception ex)
		{
			_alertService.ShowAlert("Error when adding animal!", ex.Message,"OK");
			return false;
		}
	}

	/// <summary>
	/// Creates an animal instance based on the selected species
	/// and calls the Animal instance's MapFromPageModel method to set its properties.
	/// </summary>
	/// <param name="pageModel">The page model containing the selected species and other properties</param>
	/// <returns>An animal instance with its properties set</returns>
	/// <exception cref="ArgumentException">An exception is thrown if the selected species is invalid</exception>
	public static Animal CreateAnimal(MainPageModel pageModel)
	{
		var species = pageModel.SelectedSpecies!;
		Animal animal = species switch
		{
			BirdEnum.Eagle => new Eagle(),
			BirdEnum.Parrot => new Parrot(),
			BirdEnum.Penguin => new Penguin(),
			MammalEnum.Gorilla => new Gorilla(),
			MammalEnum.Bat => new Bat(),
			MammalEnum.Dolphin => new Dolphin(),
			ReptileEnum.Alligator => new Alligator(),
			ReptileEnum.Komodo => new Komodo(),
			ReptileEnum.Chameleon => new Chameleon(),
			_ => throw new ArgumentException("Invalid species")
		};
		animal.MapFromPageModel(pageModel);
		return animal;
	}

	/// <summary>
	/// Edits the specified animal with the data from the page model
	/// </summary>
	/// <param name="animal">The animal to be edited</param>
	/// <param name="pageModel">The page model containing the updated data</param>
	/// <returns></returns>
	public bool Edit(Animal animal, MainPageModel pageModel)
	{
		if (!ValidateProperties(pageModel))
			return false;

		try
		{
			if (pageModel.SelectedSpecies?.ToString() != animal.Species.ToString())
			{
				var changedAnimal = CreateAnimal(pageModel);
				var originalIndex = _animals.IndexOf(animal);
				if (originalIndex != -1)
				{
					_animals[originalIndex] = changedAnimal;
				}
			}
			else
			{
				animal.MapFromPageModel(pageModel);
			}
				
			_alertService.ShowAlert("Changes saved!", "Changes sucessfully saved.", "OK");
			return true;
		}
		catch (Exception ex)
		{
			_alertService.ShowAlert("Error while editing animal!", ex.Message, "OK");
			return false;
		}
	}

	/// <summary>
	/// Removes the specified animal from the list
	/// </summary>
	/// <param name="animal">The animal to be removed from the list</param>
	public void Delete(Animal animal)
	{
		if (animal == null)
		{
			_alertService.ShowAlert("", "Please select an animal to delete.", "OK");

		}
		try
		{
			_animals.Remove(animal);
		}
		catch (Exception ex)
		{
			_alertService.ShowAlert("Error while deleting animal!", ex.Message, "OK");

		}
	}

	/// <summary>
	/// Sorts the list of animals based on the specified sort option
	/// and reverses the order if the sort option is the same as the previous.
	/// </summary>
	/// <param name="sortOption">The sort option that determines how the list should be sorted</param>
	public void SortAnimals(SortOption sortOption)
	{
		if (_isAnimalAdded)
		{
			_isReverseOrder = false;
			_isAnimalAdded = false;
		}
		else
		{
			if (sortOption == _previousSortOption)
				_isReverseOrder = !_isReverseOrder;
			else
				_isReverseOrder = false;
		}

		var sortedAnimals = _animals.ToList();
		sortedAnimals.Sort(new AnimalComparer(sortOption, _isReverseOrder));
		_animals = [.. sortedAnimals];
		_previousSortOption = sortOption;
	}



	/// <summary>
	/// Provides the animal at the specified index
	/// </summary>
	/// <param name="index">The index of the animal</param>
	/// <returns>The animal at the specified index</returns>
	public Animal GetAnimalAt(int index) // Not implemented (not described in assignment)
	{
		return Animals[index];
	}

	/// <summary>
	/// Calls the IAlertService.ShowAlert method to display all animals' info
	/// </summary>
	public void ShowAnimalInfoStrings()
	{
		var animalaInfoStrings = GetAnimalInfoStrings();
		_alertService.ShowAlert("All animal info", string.Join("", animalaInfoStrings), "OK");
	}
	#endregion

	/// <summary>
	/// Calls the IPropertyValidator.ValidateProperties method to validate the properties of
	/// the MainPageModel instance.
	/// </summary>
	/// <param name="pageModel">The MainPageModel instance to be validated</param>
	/// <returns>True: if validation is successful; False: if validation fails</returns>
	public bool ValidateProperties(MainPageModel pageModel)
	{
		if (!_propertyValidator.ValidateProperties(pageModel))
		{
			var errorMsg = _propertyValidator.GetValidationErrorMessages();
			_alertService.ShowAlert("Invalid input!", errorMsg, "OK");
			return false;
		}
		return true;
	}

	/// <summary>
	/// Gathers all animals' info from its ToString()-method and returns them as a string array
	/// </summary>
	/// <returns>A string array containing all animals' info</returns>
	private string[] GetAnimalInfoStrings()
	{
		var allAnimalInfo = _animals.Select(animal => GetAnimalInfo(animal) + Environment.NewLine + Environment.NewLine).ToArray();
		return allAnimalInfo;
	}

	/// <summary>
	/// 
	/// </summary>
	/// <param name="animal"></param>
	/// <returns></returns>
	private string GetAnimalInfo(Animal animal) // Not implemented (not described in assignment)
	{
		return animal.ToString();
	}
}
