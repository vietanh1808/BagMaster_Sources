using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.Combat
{
	public class FlyingGear : MonoBehaviour
	{
		[SerializeField]
		private SpriteRenderer _renderer;

		[SerializeField]
		private Transform _destination;

		[SerializeField]
		private MMF_Player _flyFeedback;

		private Gear _inBagGear;

		private OrbitingGear _floatGear;

		public PlayerCpUi PlayerCpUi;

		public void Initialized(Gear gear, Vector3 destination, float scale, OrbitingGear floatGear, float timeScale)
		{
		}

		public void OnCompletedFlying()
		{
		}
	}
}
