using System.Collections.Generic;
using UIControllersAndData.Models;
using UnityEngine;

namespace UIControllersAndData.Store.Categories.Ambient
{
	[System.Serializable]
	public class AmbientCategoryLevels:INamed, IId
	{
		public string name;
		public int id;
		public List<AmbientCategory> levels;
		
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
