using DG.Tweening;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game
{
	public class ExpandableGroupItem : MonoBehaviour
	{
		[SerializeField]
		private CanvasGroup _canvasGroup;

		[SerializeField]
		private bool _fadeOnInteractableChanged;

		[SerializeField]
		private float _fadeDuration;

		[SerializeField]
		private Ease _fadeEase;

		[Header("Events")]
		public UnityEvent OnExpandedEvent;

		public UnityEvent OnCollapsedEvent;

		public UnityEvent OnEnabledEvent;

		public UnityEvent OnDisabledEvent;

		public UnityEvent<bool> OnCustomActiveChangedEvent;

		public UnityEvent OnNotificationChangedEvent;

		[Header("Runtime")]
		[SerializeField]
		private bool _customActive;

		[SerializeField]
		private bool _isCollapsed;

		private bool _hasNotification;

		private Tweener _fadeTweener;

		private LayoutElement _layoutElement;

		public bool IsActive => false;

		public bool IsInteractable => false;

		public bool IsCollapsed => false;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Awake()
		{
		}

		public void SetInteractable(bool value)
		{
		}

		public void InvokeOnExpanded()
		{
		}

		public void InvokeOnCollapsed()
		{
		}

		public void SetCustomActive(bool value)
		{
		}

		public bool HasNotification()
		{
			return false;
		}

		public void SetHasNotification(bool value)
		{
		}

		public void CheckExpandableGroupToSeeThis()
		{
		}
	}
}
