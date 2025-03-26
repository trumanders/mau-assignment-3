namespace mau_assignment_3.Services;

public class FoodSchedule
{
	private List<string> _feedingScheduleDescriptions = []; // I changed the name from foodList, since it's not a list of foods.

	public void Add(string item)
	{
		_feedingScheduleDescriptions.Add(item);
	}

	/// <summary>
	/// Changes an item in the feeding schedule descriptions list
	/// </summary>
	/// <param name="index">The index of the feeding schedule description to change</param>
	/// <param name="newFeedingScheduleDescription">The new feeding schedule description</param>
	/// <returns>True: if the item was changed; False: if the index is out of range</returns>
	public bool ChangeAt(int index, string newFeedingScheduleDescription) // not implemented (not described in assignment)
	{
		if (!CheckIndex(index))
			return false;

		_feedingScheduleDescriptions[index] = newFeedingScheduleDescription;
		return true;
	}

	/// <summary>
	/// Checks if the index is out of range in the feeding schedule list
	/// </summary>
	/// <param name="index">The index of the feeding schedule description list to check</param>
	/// <returns>True: if the index is in range; False: if the index is out of range</returns>
	private bool CheckIndex(int index)
	{
		return
			index >= _feedingScheduleDescriptions.Count &&
			index < _feedingScheduleDescriptions.Count;
	}

	/// <summary>
	/// Deletes an item from the feeding schedule list
	/// </summary>
	/// <param name="index">The index of the feeding schedule description to remove from the list</param>
	/// <returns>True: if the item was deleted; False: if the index is out of range</returns>
	public bool DeleteAt(int index) // not implemented (not described in assignment)
	{
		if (!CheckIndex(index))
			return false;

		_feedingScheduleDescriptions.RemoveAt(index);
		return true;
	}

	/// <summary>
	/// Returns the list field content as a string array
	/// </summary>
	/// <returns>The feeding description list as a string array</returns>
	public string[] GetFoodListInfoStrings()
	{
		return _feedingScheduleDescriptions.ToArray();
	}

	public string Title() // not described in assignment
	{
		return "";
	}

	/// <summary>
	/// 
	/// </summary>
	/// <returns></returns>
	public override string ToString() // not described in assignment
	{
		return "";
	}
}
