using System.Collections.Generic;
using UIControllersAndData.Models;
using UnityEngine;

namespace UIControllersAndData.Store.Categories.Unit
{
	[System.Serializable]
	public class UnitCategoryLevels: INamed, IId 
	{
		public string name;
		public int id;
		public List<UnitCategory> levels;

		public string GetName()
		{
			return name;
		}

		public int GetId()
		{
			return id;
		}
	}
}
