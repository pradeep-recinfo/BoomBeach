using UnityEngine;

namespace Weapons.Projectiles
{
	public class ActivatorDestrorProjectile:MonoBehaviour 
	{
		void OnTriggerEnter(Collider target)
		{
			if (target.gameObject.CompareTag("Unit"))
			{
				Destroy(gameObject.transform.parent.gameObject);
			}
		}
	}
}
