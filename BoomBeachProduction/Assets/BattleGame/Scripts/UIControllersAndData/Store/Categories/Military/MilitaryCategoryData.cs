using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace UIControllersAndData.Store.Categories.Military
{
	[System.Serializable]
	public class MilitaryCategoryData : ScriptableObject
	{
		[FormerlySerializedAs("StoreCategoryId")] public string storeCategoryId;
		[FormerlySerializedAs("Category")] public List<MilitaryCategoryLevels> category;
	}
}
