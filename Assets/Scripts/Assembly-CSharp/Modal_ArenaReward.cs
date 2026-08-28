using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EnhancedUI.EnhancedScroller;
using Game;
using Game.Arena;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Modal_ArenaReward : MonoBehaviour, IEnhancedScrollerDelegate
{
	private class RewardData
	{
		public string IndexTitle;

		public List<ResourceRewardData> Rewards;
	}

	[CompilerGenerated]
	private sealed class _003CAutoTick_003Ed__17 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Modal_ArenaReward _003C_003E4__this;

		private WaitForSeconds _003Cwfs_003E5__2;

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
		public _003CAutoTick_003Ed__17(int _003C_003E1__state)
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
	private sealed class _003CScrollToPlayerRank_003Ed__24 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Modal_ArenaReward _003C_003E4__this;

		private int _003Cindex_003E5__2;

		private int _003Ccount_003E5__3;

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
		public _003CScrollToPlayerRank_003Ed__24(int _003C_003E1__state)
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
	private sealed class _003CScrollToTop_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Modal_ArenaReward _003C_003E4__this;

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
		public _003CScrollToTop_003Ed__23(int _003C_003E1__state)
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
	private ArenaButtonMenu[] tabsButton;

	[SerializeField]
	private Button buttonClose;

	[SerializeField]
	private Button areaClose;

	[SerializeField]
	private ArenaRewardItemView currentItem;

	[SerializeField]
	private TextMeshProUGUI textEndTime;

	[Header("RankView")]
	[SerializeField]
	private ScrollRect rankScrollRect;

	[SerializeField]
	private ArenaRewardRankItemView rankItemViewPrefab;

	[Header("ItemView")]
	[SerializeField]
	private EnhancedScroller scroller;

	[SerializeField]
	private ArenaRewardItemView itemViewPrefab;

	private RankType currentRankType;

	private ArenaSubTabType currentTab;

	private float itemHeight;

	private List<RewardData> rewards;

	private List<ArenaRewardRankItemView> rankItemViews;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CAutoTick_003Ed__17))]
	private IEnumerator AutoTick()
	{
		return null;
	}

	private void LoadRankData(RankType rankType)
	{
	}

	private void LoadTab(ArenaSubTabType subTabType)
	{
	}

	private void LoadRankTypePlayer()
	{
	}

	private string FormatSeasonTime(long duration)
	{
		return null;
	}

	private void LoadTabIgnoreCheck(ArenaSubTabType subTabType)
	{
	}

	[IteratorStateMachine(typeof(_003CScrollToTop_003Ed__23))]
	private IEnumerator ScrollToTop()
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CScrollToPlayerRank_003Ed__24))]
	private IEnumerator ScrollToPlayerRank()
	{
		return null;
	}

	private void Close()
	{
	}

	public int GetNumberOfCells(EnhancedScroller scroller)
	{
		return 0;
	}

	public float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
	{
		return 0f;
	}

	public EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
	{
		return null;
	}
}
