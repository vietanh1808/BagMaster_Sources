using Game.Combat;
using UnityEngine;

namespace Game.GearUpgrade
{
	public class GearUIUpgradePopupCTANotification : MonoBehaviour
	{
		[SerializeField]
		private GameObject _upgradeableCTA;

		[SerializeField]
		private GameObject _masteryClaimableCTA;

		[SerializeField]
		private GameObject _collectionClaimableCTA;

		private GearData _gearData;

		public void UpdateInfo(GearData gearData)
		{
		}

		public void RefreshAll()
		{
		}

		public void RefreshUpgradeable()
		{
		}

		public void RefreshMasteryClaimable()
		{
		}

		public void RefreshCollectionClaimable()
		{
		}
	}
}
