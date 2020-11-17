using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace UIControllersAndData.Store.Categories.Buildings
{
	[Serializable]
	public class BuildingsCategoryData:ScriptableObject 
	{
		[FormerlySerializedAs("StoreCategoryId")] 
		public string storeCategoryId;
		[FormerlySerializedAs("Category")] 
		[FormerlySerializedAs("BuildingsCategory")]
		public List<BuildingCategoryLevels> category;
	}
}
