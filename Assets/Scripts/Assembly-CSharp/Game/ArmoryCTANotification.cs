using UnityEngine;

namespace Game
{
	public class ArmoryCTANotification : MonoBehaviour
	{
		[SerializeField]
		private GameObject _notification;

		private bool _dirty;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnGearUpgraded(int upgradeId, int level)
		{
		}

		private void OnGearMasteryLevelClaimed(int masteryId, int level)
		{
		}

		private void OnGearCollectionClaimed(int gearId)
		{
		}

		private void OnResourceChanged(OwnedResourceEntity resource, int amount)
		{
		}

		private bool IsUnlocked()
		{
			return false;
		}

		public void SetDirty()
		{
		}

		public void Check()
		{
		}

		private bool AnyUpgradeableNClaimable()
		{
			return false;
		}
	}
}
