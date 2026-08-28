using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game
{
	[RequireComponent(typeof(RectMask2D))]
	[RequireComponent(typeof(VerticalLayoutGroup))]
	public class ExpandableGroupVertical : MonoBehaviour
	{
		[Header("Settings")]
		[SerializeField]
		private int _collapsedItemCount;

		[SerializeField]
		private float _animationDuration;

		[SerializeField]
		private bool _startExpanded;

		[SerializeField]
		private bool _autoAcquireChildrenOnStart;

		[Header("Toggle Buttons")]
		[SerializeField]
		private Button _expandButton;

		[SerializeField]
		private Button _collapseButton;

		[SerializeField]
		private bool _alignToggleToBottom;

		[SerializeField]
		private float _toggleButtonBottomOffset;

		[SerializeField]
		private bool _ignoreBotPaddingOnCollapse;

		[SerializeField]
		private bool _includeToggleButtonInHeight;

		[Header("References")]
		[SerializeField]
		private List<ExpandableGroupItem> _items;

		[SerializeField]
		private GameObject _collapsedNotification;

		[Header("Events")]
		public UnityEvent<bool> OnStateChanged;

		public UnityEvent OnExpandedEvent;

		public UnityEvent OnCollapsedEvent;

		public UnityEvent OnHasActiveItemEvent;

		public UnityEvent OnNoActiveItemEvent;

		private RectTransform _rectTransform;

		private VerticalLayoutGroup _layoutGroup;

		private bool _isExpanded;

		private bool _isDirty;

		private bool? _hasActiveItem;

		private List<ExpandableGroupItem> _activeItems;

		public bool IsExpanded => false;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void LateUpdate()
		{
		}

		public void Expand()
		{
		}

		public void Collapse()
		{
		}

		public void Toggle()
		{
		}

		public void AddItem(ExpandableGroupItem item)
		{
		}

		public void RemoveItem(ExpandableGroupItem item)
		{
		}

		public void RefreshLayout(bool animate = true)
		{
		}

		private void SetExpanded(bool expand)
		{
		}

		private void SetExpandedImmediate(bool expand)
		{
		}

		private void UpdateInteractability()
		{
		}

		private void AnimateToHeight(float targetHeight)
		{
		}

		private void SnapToHeight(float height)
		{
		}

		private void SnapToggleButtonPosition(float groupHeight)
		{
		}

		private float CalculateTargetHeight()
		{
			return 0f;
		}

		private float CalculateHeightForItems(List<ExpandableGroupItem> activeItems, int count)
		{
			return 0f;
		}

		private void MarkDirty()
		{
		}

		private void OnItemCustomActiveChanged(bool active)
		{
		}

		private void OnItemNotificationChanged()
		{
		}

		private void UpdateCollapsedNotification()
		{
		}

		private void SubscribeToItem(ExpandableGroupItem item)
		{
		}

		private void UnsubscribeFromItem(ExpandableGroupItem item)
		{
		}

		private void SubscribeToItems()
		{
		}

		private void UnsubscribeFromItems()
		{
		}

		private void AcquireChildItems()
		{
		}

		private List<ExpandableGroupItem> GetActiveItems()
		{
			return null;
		}
	}
}
