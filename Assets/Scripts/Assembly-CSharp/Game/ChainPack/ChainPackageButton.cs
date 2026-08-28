using System;
using R3;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.ChainPack
{
	public class ChainPackageButton : MonoBehaviour
	{
		[SerializeField]
		private Button button;

		[SerializeField]
		private GameObject notify;

		[SerializeField]
		private FeatureUI featureUI;

		[SerializeField]
		private TextMeshProUGUI textRemainTime;

		[SerializeField]
		private UnityEvent<bool> onNotificationEvent;

		[SerializeField]
		private Color _lastChanceColor;

		private long _duration;

		private IDisposable _intervalDisposable;

		private bool _invokedNotification;

		public static ChainPackageButton Instance { get; private set; }

		public static bool HasInstance()
		{
			return false;
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDestroy()
		{
		}

		public void Refresh()
		{
		}

		private void RefreshDuration(long duration)
		{
		}

		private void RefreshByInterval(Unit _)
		{
		}

		public void RefreshNotification()
		{
		}

		public bool CheckHasClaimedAll()
		{
			return false;
		}

		private void ShowPopup()
		{
		}

		private void OnDisable()
		{
		}
	}
}
