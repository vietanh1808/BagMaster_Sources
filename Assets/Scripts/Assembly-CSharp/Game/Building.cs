using Game.Combat;
using UnityEngine;

namespace Game
{
	public class Building : MonoBehaviour, ICounterItem
	{
		[SerializeField]
		private SpriteRenderer _renderer;

		public KingdomBuildingData Data { get; private set; }

		public void Initialize(KingdomBuildingData data)
		{
		}

		public Transform GetTranform()
		{
			return null;
		}

		public float GetWidth()
		{
			return 0f;
		}

		public void OnDrop()
		{
		}
	}
}
