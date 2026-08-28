using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	public class RewardBubbleView : MonoBehaviour
	{
		[Header("References")]
		[SerializeField]
		private RectTransform _bubblePanel;

		[SerializeField]
		private RectTransform _pointer;

		[SerializeField]
		private RectTransform _contentArea;

		[SerializeField]
		private ResourceView _resourceViewPrefab;

		[Header("Settings")]
		[SerializeField]
		private Vector2 _panelOffset;

		[SerializeField]
		private float _screenPadding;

		[Tooltip("Minimum and maximum X position of pointer relative to bubble (normalized 0-1)")]
		[SerializeField]
		private Vector2 _pointerXRange;

		[Header("Auto Close")]
		[SerializeField]
		private bool _autoCloseOnTapOutside;

		private Canvas _canvas;

		private RectTransform _canvasRect;

		private Camera _uiCamera;

		private List<ResourceView> _activeViews;

		private Stack<ResourceView> _viewPool;

		public RectTransform ContentArea => null;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private bool IsPointerOverPanel()
		{
			return false;
		}

		public void Show(Vector3 targetWorldPosition, List<ResourceRewardData> rewards, bool isClaimed)
		{
		}

		public void Show(RectTransform target, List<ResourceRewardData> rewards, bool isClaimed)
		{
		}

		public void Hide()
		{
		}

		private void PopulateRewards(List<ResourceRewardData> rewards, bool isClaimed)
		{
		}

		private ResourceView GetViewFromPool()
		{
			return null;
		}

		private void ClearRewards()
		{
		}

		private void UpdatePosition(Vector3 targetWorldPosition)
		{
		}

		private void UpdatePointerPosition(Vector2 targetLocalPos, Vector2 bubblePos, Vector2 bubbleSize)
		{
		}
	}
}
