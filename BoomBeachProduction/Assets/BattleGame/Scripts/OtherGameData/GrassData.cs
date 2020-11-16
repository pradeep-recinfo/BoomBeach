using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

namespace Assets.Scripts.OtherGameData
{
	[Serializable]
	public class GrassData:ScriptableObject 
	{
		public string GrassCategoryId;
		[FormerlySerializedAs("GrassCategory")]
		public List<GameObject> Category;
		
	}
}