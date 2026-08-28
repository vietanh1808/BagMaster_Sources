using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;
using UnityScreenNavigator.Runtime.Core.Modal;

namespace Game.EventDungeon
{
	public class ModalEventDungeonInfo : Modal
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGetInfoLayoutPrefab_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncTaskMethodBuilder<EventDungeonInfoLayout> _003C_003Et__builder;

			public CancellationToken cancellationToken;

			public ModalEventDungeonInfo _003C_003E4__this;

			private TaskAwaiter<EventDungeonInfoLayout> _003C_003Eu__1;

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
		private struct _003CLoadInfoLayout_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public ModalEventDungeonInfo _003C_003E4__this;

			public List<EventDungeonViewState> levels;

			public EventDungeonProgressData currentProgress;

			private TaskAwaiter<EventDungeonInfoLayout> _003C_003Eu__1;

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
		private struct _003CTriggerDelayBeginGame_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

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

		private static bool allowedChangeDifficult;

		private static int targetLevel;

		[CompilerGenerated]
		private static Action m_onTriggerRefresh;

		[SerializeField]
		private Button buttonClose;

		[SerializeField]
		private Transform layoutPlaceHolder;

		[SerializeField]
		private EventDungeonInfoLayout defaultLayoutPrefab;

		private int lastLayoutKey;

		private EventDungeonInfoLayout currentLayout;

		private CancellationTokenSource loadInfoLayoutCts;

		public static bool IsDelayBeginGame { get; private set; }

		public static EventDungeonUnlockViewState EventDungeon { get; private set; }

		private static event Action onTriggerRefresh
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

		public static void AssignViewState(EventDungeonUnlockViewState vs, bool canChangeDifficult = true, int targetLevel = 0)
		{
		}

		[AsyncStateMachine(typeof(_003CTriggerDelayBeginGame_003Ed__20))]
		public static void TriggerDelayBeginGame()
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public static void TriggerRefresh()
		{
		}

		public override Task WillPushEnter()
		{
			return null;
		}

		private void OnCloseClicked()
		{
		}

		private void UpdateData()
		{
		}

		private void RenderView()
		{
		}

		[AsyncStateMachine(typeof(_003CLoadInfoLayout_003Ed__28))]
		private void LoadInfoLayout(List<EventDungeonViewState> levels, EventDungeonProgressData currentProgress)
		{
		}

		[AsyncStateMachine(typeof(_003CGetInfoLayoutPrefab_003Ed__29))]
		private Task<EventDungeonInfoLayout> GetInfoLayoutPrefab(CancellationToken cancellationToken = default(CancellationToken))
		{
			return null;
		}

		public override void DidPushEnter()
		{
		}
	}
}
