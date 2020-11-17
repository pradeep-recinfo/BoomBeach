using UnityEngine;
using UnityEngine.UI;

namespace Army
{
	public class ArmyItem:MonoBehaviour
	{
		[SerializeField] private Text _count;

		public void Initialize(int count)
		{
			_count.text = count.ToString();
		}
	}
}
