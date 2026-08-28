using UnityEngine;

namespace Game.Combat
{
	public class Wall : MonoBehaviour, IEffectTarget, INotHitVfxEffectTarget, INotCountBounceOnHit
	{
		public Vector2 Normal;
	}
}
