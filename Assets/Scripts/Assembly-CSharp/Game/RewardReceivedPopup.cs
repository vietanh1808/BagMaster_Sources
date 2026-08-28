using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Game
{
	public class RewardReceivedPopup : MonoBehaviour
	{
		[CompilerGenerated]
		private static Action m_OnClosedEvent;

		[SerializeField]
		private GameObject _rewardItemPrefab;

		[SerializeField]
		private Transform _rewardItemContainer;

		[SerializeField]
		private GameObject _popupPanel;

		[SerializeField]
		private float _timeBetweenItemSpawn;

		[SerializeField]
		private FlyToBarProfile _flyToBarProfile;

		private List<GameObject> _rewardItems;

		private Action OnCloseCallback;

		private float _endAnimationTime;

		public static int VisibleCount { get; private set; }

		public static RewardReceivedPopup OpeningPopup { get; private set; }

		public static event Action OnClosedEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		private void OnDestroy()
		{
		}

		public void Test(int id)
		{
		}

		public void ShowPopup(int rewardId)
		{
		}

		public void ShowPopup(RewardPack rewardPack)
		{
		}

		public void HidePopup()
		{
		}

		public void UpdateInfo(int rewardId)
		{
		}

		public void UpdateInfo(RewardPack rewardPack)
		{
		}

		public IReadOnlyCollection<GameObject> GetRewardItemUis()
		{
			return null;
		}

		public static void Show(List<ResourceRewardData> rewardDatas)
		{
		}

		public static void Show(List<ResourceRewardData> rewardDatas, Action onClose = null, bool deliverytoBar = true)
		{
		}

		public static void Show(RewardPack rewardPack, Action onClose = null, bool deliverytoBar = true)
		{
		}

		private void DeliveryResourceToBars()
		{
		}
	}
}
