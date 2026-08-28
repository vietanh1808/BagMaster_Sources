using System.Collections.Generic;
using Game.Combat;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.GearUpgrade
{
	public class GearUICollectionItem : MonoBehaviour
	{
		[SerializeField]
		private Image _gearIcon;

		[SerializeField]
		private Button _claimButton;

		[SerializeField]
		private GameObject _giftIcon;

		[SerializeField]
		private GameObject _unknown;

		[SerializeField]
		private Image _background;

		[SerializeField]
		private GearUITierUiProfile _tierProfile;

		[SerializeField]
		private FlyToBarProfile _flyToBarProfile;

		[SerializeField]
		private ShowFloatingWhenResourceChanged _showFloating;

		[SerializeField]
		private float _floatingScale;

		[Header("Events")]
		public UnityEvent OnClaimedEvent;

		[Header("Runtime")]
		[SerializeField]
		private bool _isClaimed;

		[SerializeField]
		private bool _known;

		private GearData _gearData;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		private void Claim()
		{
		}

		private void DeliverToBar(List<ResourceRewardData> rewards)
		{
		}

		public void UpdateInfo(GearData gearData)
		{
		}
	}
}
