using System;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Game.Helpers;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityScreenNavigator.Runtime.Core.Modal;

namespace Game.EventDungeon
{
	public class ModalEventDungeonAdsOptions : Modal
	{
		[CompilerGenerated]
		private static Action<ModalEventDungeonAdsOptions> m_onWatchFreeAds;

		[CompilerGenerated]
		private static Action<ModalEventDungeonAdsOptions> m_onUseAdsSkipTicket;

		private static Transform anchor;

		[SerializeField]
		private Vector2 offset;

		[SerializeField]
		private Transform popupContent;

		[SerializeField]
		private CooldownButton buttonFree;

		[SerializeField]
		private CooldownButton buttonSkipAd;

		[SerializeField]
		private Button buttonClose;

		[SerializeField]
		private TMP_Text textTicketRemain;

		[SerializeField]
		private Color ticketSufficientColor;

		[SerializeField]
		private Color ticketInsufficientColor;

		private OwnedResourceEntity adsTicket;

		public static ModalEventDungeonAdsOptions Instance { get; private set; }

		public static event Action<ModalEventDungeonAdsOptions> onWatchFreeAds
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

		public static event Action<ModalEventDungeonAdsOptions> onUseAdsSkipTicket
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

		private void OnEnable()
		{
		}

		public override Task WillPushEnter()
		{
			return null;
		}

		public override void DidPushExit()
		{
		}

		private void OnDestroy()
		{
		}

		private void UpdateTextTicketRemain()
		{
		}

		private void OnTicketValueChanged(int amount)
		{
		}

		private void OnFreeAds()
		{
		}

		private void OnSkipAds()
		{
		}

		public void Close()
		{
		}

		public static void Show(Transform anchor)
		{
		}
	}
}
