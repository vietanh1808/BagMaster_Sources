using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Combat
{
	public class BuySlotView : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCheckCTA_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BuySlotView _003C_003E4__this;

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
			public _003CCheckCTA_003Ed__24(int _003C_003E1__state)
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
		private Button _slotBuyBtn;

		[SerializeField]
		private Button _slotBuyAdsBtn;

		[SerializeField]
		private TextMeshProUGUI[] _slotBuyTxts;

		[SerializeField]
		private GameObject _notEnoughGoldButton;

		[SerializeField]
		private GameObject _alreadyMaxSlotButton;

		[SerializeField]
		private ButtonCTA _buySlotCTA;

		[SerializeField]
		private Transform _goldFloatingTextPosition;

		[Header("External References")]
		[SerializeField]
		private BagNewSlotManager _bagNewSlotManager;

		[Header("Events")]
		public UnityEvent OnBuySlotEvent;

		public UnityEvent OnBuySlotAdsTicketEvent;

		private OwnedResourceEntity CombatGold => null;

		private bool AdsBuySlotAvailable => false;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnCombatGoldChanged(int newGold)
		{
		}

		private void BuySlot()
		{
		}

		private void BuySlotAds()
		{
		}

		public void Refresh()
		{
		}

		private void UpdateStates()
		{
		}

		private bool EnoughSlotGold()
		{
			return false;
		}

		private float GetOffetGold()
		{
			return 0f;
		}

		[IteratorStateMachine(typeof(_003CCheckCTA_003Ed__24))]
		private IEnumerator CheckCTA()
		{
			return null;
		}

		private void OnOffCTA(bool on)
		{
		}

		private int GetGoldGapAdsThresold()
		{
			return 0;
		}
	}
}
