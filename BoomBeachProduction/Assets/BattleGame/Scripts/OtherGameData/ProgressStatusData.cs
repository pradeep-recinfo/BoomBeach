using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Assets.Scripts.OtherGameData
{
	[Serializable]
	public class ProgressStatusData :ScriptableObject 
	{
		public string ProgressStatusCategoryId;
		[FormerlySerializedAs("ProgressStatusCategory")]
		public List<GameObject> Category;
		
	}
}