using System;
using System.Runtime.CompilerServices;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EventDungeon
{
	public class PageEventTabButton : MonoBehaviour
	{
		[CompilerGenerated]
		private static Action<PageEventTabButton, bool> m_onToggle;

		[SerializeField]
		private Image imageIcon;

		[SerializeField]
		private Image imageActive;

		[SerializeField]
		private TMP_Text textCategory;

		[SerializeField]
		private Toggle toggle;

		[SerializeField]
		private MMF_Player activeFeedback;

		[SerializeField]
		private GameObject notifyGO;

		[SerializeField]
		private GameObject notifyGO_green;

		[SerializeField]
		private TMP_Text notifyText_green;

		public string Category { get; private set; }

		public static event Action<PageEventTabButton, bool> onToggle
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

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnDungeonTicketChanged(EventDungeonUnlockViewState edState)
		{
		}

		private void OnEnable()
		{
		}

		private void CheckAndActiveNotification()
		{
		}

		private void OnToggleOn(PageEventTabButton button, bool isOn)
		{
		}

		private void OnToggle(bool value)
		{
		}

		public void SetData(Sprite icon, CategoryData category)
		{
		}

		public void ShowActive(bool value)
		{
		}
	}
}
