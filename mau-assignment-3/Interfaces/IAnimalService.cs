namespace mau_assignment_3.Services
{
	public interface IAnimalService
	{
		public ObservableCollection<Animal> Animals { get; }
		public bool Add(MainPageModel pageModel);
		public Animal GetAnimalAt(int index);
		public void SortAnimals(SortOption sortOptíon);
		public bool Edit(Animal animal, MainPageModel pageModel);
		public void Delete(Animal animal);
		public void ShowAnimalInfoStrings();
	}
}
