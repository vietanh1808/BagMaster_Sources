using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game.Arena;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Modal_ArenaChallenge : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CAutoRefreshTimeIE_003Ed__21 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public Modal_ArenaChallenge _003C_003E4__this;

		private long _003Cduration_003E5__2;

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
		public _003CAutoRefreshTimeIE_003Ed__21(int _003C_003E1__state)
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
	private sealed class _003CScrollToTop_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float delay;

		public Modal_ArenaChallenge _003C_003E4__this;

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
		public _003CScrollToTop_003Ed__18(int _003C_003E1__state)
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
	private Button buttonRefresh;

	[SerializeField]
	private Button buttonCooldown;

	[SerializeField]
	private TextMeshProUGUI textCooldown;

	[SerializeField]
	private Button buttonClose;

	[SerializeField]
	private Button areaClose;

	[SerializeField]
	private Button btnCurrency;

	[SerializeField]
	private TextMeshProUGUI textPower;

	[SerializeField]
	private ScrollRect scrollRect;

	[SerializeField]
	private ArenaChallengeItemView itemViewPrefab;

	[SerializeField]
	private MMF_Player openFeedback;

	private List<ArenaChallengeItemView> itemViews;

	private Dictionary<int, ArenaIndexData> indexDictionary;

	private Coroutine coroutine;

	private void Awake()
	{
	}

	private void ClickCooldown()
	{
	}

	private void OpenCurrency()
	{
	}

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	[IteratorStateMachine(typeof(_003CScrollToTop_003Ed__18))]
	private IEnumerator ScrollToTop(float delay = 0.2f)
	{
		return null;
	}

	private void Close()
	{
	}

	private void ForceRefresh()
	{
	}

	[IteratorStateMachine(typeof(_003CAutoRefreshTimeIE_003Ed__21))]
	private IEnumerator AutoRefreshTimeIE()
	{
		return null;
	}

	private void Refresh()
	{
	}

	private void _Refresh(bool forceRefresh)
	{
	}

	private void RefreshOpponent(bool forceRefresh)
	{
	}
}
