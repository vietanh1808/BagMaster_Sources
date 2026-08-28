using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game;
using Game.EventDungeon;
using Game.GUI;
using UnityEngine;
using UnityScreenNavigator.Runtime.Core.Page;

public class PostHomeOpenScreens : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass31_0
	{
		public PostHomeOpenScreens _003C_003E4__this;

		public ModalEventDungeonUnlocked openingModal;

		internal bool _003CShowNewUnlockEventDungeons_003Eb__0()
		{
			return false;
		}

		internal bool _003CShowNewUnlockEventDungeons_003Eb__3()
		{
			return false;
		}
	}

	[CompilerGenerated]
	private sealed class _003C_003Ec__DisplayClass37_0
	{
		public PostHomeOpenScreens _003C_003E4__this;

		public bool isPageLoadDone;

		public NoAdsOfferPopup noAdPopup;

		public int offerType;

		internal bool _003CCheckAdsRemovalOffer_003Eb__0()
		{
			return false;
		}

		internal void _003CCheckAdsRemovalOffer_003Eb__1(NoAdsOfferPopup popup)
		{
		}

		internal bool _003CCheckAdsRemovalOffer_003Eb__2()
		{
			return false;
		}

		internal bool _003CCheckAdsRemovalOffer_003Eb__3()
		{
			return false;
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCheckAdsRemovalOffer_003Ed__37 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public PostHomeOpenScreens _003C_003E4__this;

		private _003C_003Ec__DisplayClass37_0 _003C_003E8__1;

		private bool _003CisDiscountOffer_003E5__2;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCheckAndShowContinueSave_003Ed__25 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PostHomeOpenScreens _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCheckAndShowUnlockedEventDungeons_003Ed__30 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public PostHomeOpenScreens _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private IEnumerator<EventDungeonUnlockViewState> _003C_003E7__wrap1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCheckShowChapterPackOffer_003Ed__32 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public PostHomeOpenScreens _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CCheckShowRatingPopup_003Ed__29 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public PostHomeOpenScreens _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReOpenPvpArenaScreen_003Ed__28 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder<bool> _003C_003Et__builder;

		public PostHomeOpenScreens _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CReopenEventDungeonScreen_003Ed__27 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder<bool> _003C_003Et__builder;

		public PostHomeOpenScreens _003C_003E4__this;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CShowNewUnlockEventDungeons_003Ed__31 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncUniTaskMethodBuilder _003C_003Et__builder;

		public PostHomeOpenScreens _003C_003E4__this;

		public EventDungeonUnlockViewState ed;

		private _003C_003Ec__DisplayClass31_0 _003C_003E8__1;

		private UniTask.Awaiter _003C_003Eu__1;

		private TaskAwaiter _003C_003Eu__2;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CStart_003Ed__17 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncVoidMethodBuilder _003C_003Et__builder;

		public PostHomeOpenScreens _003C_003E4__this;

		private TaskAwaiter<bool> _003C_003Eu__1;

		private UniTask<bool>.Awaiter _003C_003Eu__2;

		private UniTask.Awaiter _003C_003Eu__3;

		private TaskAwaiter _003C_003Eu__4;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	private static bool forceDontShowSuggestionAgainThisTime;

	private static int? reopenEventDungeonId;

	private static bool reopenPvpArena;

	private static bool showRatingPopup;

	private static ChapterPackOfferLogic chapterPackOffer;

	private static bool showAdRemovalOffer;

	private static bool _hasCheckedCombatSave;

	[SerializeField]
	private PageContainer pageContainer;

	[SerializeField]
	private UnlockPopup unlockPopup;

	[SerializeField]
	private Transform shopButton;

	private static DateTime lastShowAdsRemovalDiscountOfferTime;

	private bool DontShowStrongerSuggestionsAgain
	{
		get
		{
			return false;
		}
		set
		{
		}
	}

	public static bool IsOpeningPriority { get; private set; }

	[AsyncStateMachine(typeof(_003CStart_003Ed__17))]
	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public static void SetReopenEventDungeon(int id)
	{
	}

	public static void SetReopenPvpArena()
	{
	}

	public static void SetForceDontShowSuggestionAgainThisTime(bool value)
	{
	}

	public static void SetShowRatingPopup()
	{
	}

	public static void SetShouldOfferChapterPack(ChapterPackOfferLogic value)
	{
	}

	public static void SetShouldOfferAdsRemoval()
	{
	}

	[AsyncStateMachine(typeof(_003CCheckAndShowContinueSave_003Ed__25))]
	private Task CheckAndShowContinueSave()
	{
		return null;
	}

	private UniTask CheckAndShowStrongerSuggestions()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CReopenEventDungeonScreen_003Ed__27))]
	private Task<bool> ReopenEventDungeonScreen()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CReOpenPvpArenaScreen_003Ed__28))]
	private UniTask<bool> ReOpenPvpArenaScreen()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CCheckShowRatingPopup_003Ed__29))]
	private UniTask CheckShowRatingPopup()
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CCheckAndShowUnlockedEventDungeons_003Ed__30))]
	private Task CheckAndShowUnlockedEventDungeons()
	{
		return null;
	}

	[AsyncStateMachine(typeof(_003CShowNewUnlockEventDungeons_003Ed__31))]
	private UniTask ShowNewUnlockEventDungeons(EventDungeonUnlockViewState ed)
	{
		return default;
	}

	[AsyncStateMachine(typeof(_003CCheckShowChapterPackOffer_003Ed__32))]
	private UniTask CheckShowChapterPackOffer()
	{
		return default;
	}

	private UniTask CheckShowEventBanner()
	{
		return default;
	}

	private UniTask CheckAndShowPendingRewards()
	{
		return default;
	}

	private bool CheckForPageReady()
	{
		return false;
	}

	[AsyncStateMachine(typeof(_003CCheckAdsRemovalOffer_003Ed__37))]
	private UniTask CheckAdsRemovalOffer()
	{
		return default;
	}

	public void TestTriggerShowOffer()
	{
	}

	public void TestShowNoAdsOffer()
	{
	}

	public void TestShowEventDungeonUnlock()
	{
	}
}
