using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.RewardBundle
{
	public class RewardBundleRewardItem : MonoBehaviour
	{
		[SerializeField]
		private List<ResourceView> _resourceViews;

		[SerializeField]
		private CanvasGroup _resourceViewGroup;

		[SerializeField]
		private GameObject _selectedOverlay;

		[SerializeField]
		private Button _button;

		[Header("Events")]
		public UnityEvent<RewardBundleRewardItem> OnClickedEvent;

		private readonly List<GameObject> _spawnedViews;

		public bool IsSelected { get; private set; }

		public RewardBundleSubPack SubPack { get; private set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void UpdateInfo(RewardBundleSubPack subPack)
		{
		}

		public void SetResourceViewInteractable(bool interactable)
		{
		}

		public void SetSelected(bool selected)
		{
		}

		private void OnClick()
		{
		}
	}
}
