using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Assets.Scripts.OtherGameData
{
	[Serializable]
	public class RemovablesData:ScriptableObject 
	{
		public string RemovablesCategoryId;
		[FormerlySerializedAs("RemovablesCategory")]
		public List<GameObject> Category;
		public GameObject RemovableTimerPrefab;
		
	}
}