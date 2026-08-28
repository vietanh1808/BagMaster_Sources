using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using EnhancedUI.EnhancedScroller;
using Game;
using Game.Arena;
using Game.AssetManager;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Page_ArenaMain : MonoBehaviour, IEnhancedScrollerDelegate
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass39_0
	{
		public Page_ArenaMain _003C_003E4__this;

		public int endScore;

		public int beginScore;

		internal void _003CFeedbackUpScore_003Eb__0(float value)
		{
		}
	}

	[CompilerGenerated]
	private sealed class _003CAutoHideLoading_003Ed__45 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

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
		public _003CAutoHideLoading_003Ed__45(int _003C_003E1__state)
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
	private sealed class _003CAutoTick_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Page_ArenaMain _003C_003E4__this;

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
		public _003CAutoTick_003Ed__52(int _003C_003E1__state)
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
	private sealed class _003CFeedbackUpScore_003Ed__39 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Page_ArenaMain _003C_003E4__this;

		public int endScore;

		public int beginScore;

		public float delay;

		private _003C_003Ec__DisplayClass39_0 _003C_003E8__1;

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
		public _003CFeedbackUpScore_003Ed__39(int _003C_003E1__state)
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
	private sealed class _003CScrollToTop_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Page_ArenaMain _003C_003E4__this;

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
		public _003CScrollToTop_003Ed__46(int _003C_003E1__state)
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
	private SpriteAddressable imgRankIcon;

	[SerializeField]
	private SpriteAddressable imgRankRibbon;

	[SerializeField]
	private PrefabAddressable backgroundPrefab;

	[SerializeField]
	private Color colorTicketChallengeEnough;

	[SerializeField]
	private Color colorTicketChallengeNotEnough;

	[SerializeField]
	private TextMeshProUGUI textTicketChallenge;

	[SerializeField]
	private TextMeshProUGUI textSuggest;

	[SerializeField]
	private ArenaLeaderboardTopPlayerItemView top1;

	[SerializeField]
	private ArenaLeaderboardTopPlayerItemView top2;

	[SerializeField]
	private ArenaLeaderboardTopPlayerItemView top3;

	[SerializeField]
	private Button btnChallenge;

	[SerializeField]
	private Button btnReward;

	[SerializeField]
	private Button btnShop;

	[SerializeField]
	private Button btnCurrency;

	[SerializeField]
	private TextMeshProUGUI textRank;

	[SerializeField]
	private TextMeshProUGUI textEndTime;

	[SerializeField]
	private ArenaLeaderboardItemView currentItemView;

	[Header("Upscore")]
	[SerializeField]
	private MMF_Player feedbackUpScore;

	[SerializeField]
	private GameObject objectUpScore;

	[SerializeField]
	private TextMeshProUGUI firstRankText;

	[SerializeField]
	private TextMeshProUGUI secondRankText;

	[SerializeField]
	private TextMeshProUGUI rankChangeText;

	[SerializeField]
	private Transform arrow;

	[SerializeField]
	private Color colorSecondRankTextIncrease;

	[SerializeField]
	private Color colorSecondRankTextDecrease;

	[SerializeField]
	private string rankUpText;

	[SerializeField]
	private string rankDownText;

	[Header("Element")]
	[SerializeField]
	private EnhancedScroller scroller;

	[SerializeField]
	private ArenaLeaderboardItemView itemViewPrefab;

	[SerializeField]
	private Button btnClose;

	private const int CHALLENGE_TICKET_REQUIRE = 1;

	private float itemHeight;

	private bool isInitialized;

	private Coroutine coroutine;

	private List<ArenaIndexData> leaderboard;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	[IteratorStateMachine(typeof(_003CFeedbackUpScore_003Ed__39))]
	private IEnumerator FeedbackUpScore(float delay, int beginScore, int endScore)
	{
		return null;
	}

	private void OnResourceChanged(OwnedResourceEntity arg1, int arg2)
	{
	}

	private void OpenCurrency()
	{
	}

	private void OpenChallenge()
	{
	}

	private void OpenShop()
	{
	}

	private void OpenReward()
	{
	}

	[IteratorStateMachine(typeof(_003CAutoHideLoading_003Ed__45))]
	private IEnumerator AutoHideLoading(float delay)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CScrollToTop_003Ed__46))]
	private IEnumerator ScrollToTop()
	{
		return null;
	}

	private void RefreshLeaderboard()
	{
	}

	private void RefreshPlayerData()
	{
	}

	private void RefreshBackgroundAndIcon()
	{
	}

	private void UpdateTopPlayer()
	{
	}

	private void UpdateBanner()
	{
	}

	[IteratorStateMachine(typeof(_003CAutoTick_003Ed__52))]
	private IEnumerator AutoTick()
	{
		return null;
	}

	private string FormatSeasonTime(long duration)
	{
		return null;
	}

	private void Refresh()
	{
	}

	private void RefreshSuggestText()
	{
	}

	private void Back()
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

	private void RefreshTicket()
	{
	}
}
