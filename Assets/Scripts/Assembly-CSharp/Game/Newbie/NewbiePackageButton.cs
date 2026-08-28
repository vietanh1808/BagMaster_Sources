using System;
using R3;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Newbie
{
	public class NewbiePackageButton : MonoBehaviour
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

		private long _duration;

		private IDisposable _intervalDisposable;

		private bool _invokedNotification;

		public static NewbiePackageButton Instance { get; private set; }

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

		public void OnEnable()
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

		public void ShowPopup()
		{
		}
	}
}
