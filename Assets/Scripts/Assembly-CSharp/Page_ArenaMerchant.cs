using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game.Arena;
using Game.AssetManager;
using Game.Shop;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Page_ArenaMerchant : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAutoRefreshTimeIE_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public long refreshTimeInSeconds;

		public Page_ArenaMerchant _003C_003E4__this;

		public ArenaSubTabType subTabType;

		private WaitForSeconds _003CwaitForSeconds_003E5__2;

		private long _003Cduration_003E5__3;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CAutoRefreshTimeIE_003Ed__19(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CScrollToTop_003Ed__20 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Page_ArenaMerchant _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CScrollToTop_003Ed__20(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private TextMeshProUGUI textTitle;

	[SerializeField]
	private TextMeshProUGUI textRefreshTime;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private VendorPackShopItem shopItemPrefab;

	[SerializeField]
	private Button buttonClose;

	[SerializeField]
	private PrefabAddressable prefabAddressable;

	[SerializeField]
	private ArenaButtonMenu[] tabsButton;

	private ArenaSubTabType currentTab;

	private Coroutine refreshTimeCoroutine;

	private List<VendorPackShopItem> shopItems;

	private List<ArenaVendorPurchased> vendorItemsPurchased;

	private bool triggerNewTab;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void LoadTab(ArenaSubTabType subTabType)
	{
	}

	private void LoadTabIgnoreCheck(ArenaSubTabType subTabType, bool shouldPlayFeedback = true)
	{
	}

	private void RefreshVendorPurchased(ArenaSubTabType subTabType)
	{
	}

	private void RefreshVendorTime(ArenaSubTabType subTabType)
	{
	}

	[IteratorStateMachine(typeof(_003CAutoRefreshTimeIE_003Ed__19))]
	private IEnumerator AutoRefreshTimeIE(ArenaSubTabType subTabType, long refreshTimeInSeconds)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CScrollToTop_003Ed__20))]
	private IEnumerator ScrollToTop()
	{
		return null;
	}

	private string FormatSeasonTime(long duration)
	{
		return null;
	}

	private void RefreshItem(ArenaSubTabType subTabType, bool shouldPlayFeedback)
	{
	}

	private int GetPurchased(int bundleId)
	{
		return 0;
	}

	private void OnClaimedPack(int bundleId, int quantity)
	{
	}

	private void Back()
	{
	}
}
