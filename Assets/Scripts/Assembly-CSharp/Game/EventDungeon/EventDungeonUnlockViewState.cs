using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Game.Data;
using UnityEngine;

namespace Game.EventDungeon
{
	public class EventDungeonUnlockViewState
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetDungeonInfoLayout_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<EventDungeonInfoLayout> _003C_003Et__builder;

			public EventDungeonUnlockViewState _003C_003E4__this;

			public CancellationToken cancellationToken;

			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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
		private struct _003CLoadBannerInfo_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Sprite> _003C_003Et__builder;

			public EventDungeonUnlockViewState _003C_003E4__this;

			private TaskAwaiter<Sprite> _003C_003Eu__1;

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
		private struct _003CLoadInfoFrame_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<Sprite> _003C_003Et__builder;

			public EventDungeonUnlockViewState _003C_003E4__this;

			private TaskAwaiter<Sprite> _003C_003Eu__1;

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

		public static Action<EventDungeonUnlockViewState> onTicketsChanged;

		public readonly ExcelEventDungeonUnlockData item;

		[Obsolete]
		private Dictionary<int, int> buyTicketCurrencies;

		private List<(int id, int amount)> buyTicketPrices;

		private Task<Sprite> taskLoadBanner;

		private CancellationTokenSource loadBannerCts;

		private Task<Sprite> taskLoadFrame;

		private CancellationTokenSource loadFrameCts;

		public EventDungeonUnlockViewState(ExcelEventDungeonUnlockData item)
		{
		}

		public EventDungeonType GetEventType()
		{
			return (EventDungeonType)0;
		}

		public string GetEventCategory()
		{
			return null;
		}

		public CategoryData GetEventCategoryData()
		{
			return default;
		}

		public EventDungeonCategory GetEventCategoryType()
		{
			return EventDungeonCategory.undefined;
		}

		[AsyncStateMachine(typeof(_003CGetDungeonInfoLayout_003Ed__13))]
		public Task<EventDungeonInfoLayout> GetDungeonInfoLayout(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoadInfoFrame_003Ed__14))]
		public Task<Sprite> LoadInfoFrame()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CLoadBannerInfo_003Ed__15))]
		public Task<Sprite> LoadBannerInfo()
		{
			return null;
		}

		public IEnumerable<EventDungeonViewState> GetLevels()
		{
			return null;
		}

		public EventDungeonViewState GetLevel(int level)
		{
			return null;
		}

		public int GetDailyTickets()
		{
			return 0;
		}

		public void ReduceTicket()
		{
		}

		public void SetRemainTickets(int amount, bool notify = true, bool isIap = false)
		{
		}

		public int GetRemainTickets()
		{
			return 0;
		}

		public int GetAdsBuyTimes()
		{
			return 0;
		}

		public int GetBuyTicketTimes()
		{
			return 0;
		}

		public ResourceEntity GetTicketCurrencyData()
		{
			return null;
		}

		public void SetAdsBuyTicketTimes(int value, bool notify = true)
		{
		}

		public void SetBuyTicketTimes(int value, bool notify = true)
		{
		}

		public bool IsUnlocked()
		{
			return false;
		}

		public string GetLockedContent()
		{
			return null;
		}

		public string GetLockChallengeText()
		{
			return null;
		}

		public (int, int) GetBuyTicketPrices(int buyTime)
		{
			return default;
		}

		[Obsolete]
		public Dictionary<int, int> GetBuyTicketPrices()
		{
			return null;
		}

		public bool HasNotification()
		{
			return false;
		}

		public int CountRemainBuyAdsTicket()
		{
			return 0;
		}

		public int CountRemainBuyCurrencyTicket()
		{
			return 0;
		}

		public bool IsCurrentLevelPlayable()
		{
			return false;
		}

		public void Unlock()
		{
		}

		public bool IsElementalTrial()
		{
			return false;
		}

		private List<int> GetOtherElementalTrialIds()
		{
			return null;
		}
	}
}
