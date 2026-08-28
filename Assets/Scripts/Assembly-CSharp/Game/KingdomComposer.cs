using Game.Combat;
using UnityEngine;

namespace Game
{
	[DefaultExecutionOrder(-10)]
	public class KingdomComposer : MonoBehaviour
	{
		[SerializeField]
		private BagLayoutManager _bagLayoutManager;

		[SerializeField]
		private BagNewSlotManager _bagNewSlotManager;

		[SerializeField]
		private KingdomBagSaveInitializer _bagSaveInitializer;

		[SerializeField]
		private GameplayBagInitializer _bagInitializer;

		[SerializeField]
		private Bag _bag;

		[SerializeField]
		private KingdomBuildingManager _kingdomBuildingManager;

		[SerializeField]
		private CounterDropArea _counterDropArea;

		private void Awake()
		{
		}
	}
}
