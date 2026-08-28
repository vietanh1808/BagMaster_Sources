using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BattlePass.Model;
using BattlePass.Views;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using _Game.Events.Model;

namespace Game
{
	[RequireComponent(typeof(BattlePassListener))]
	public class EventEntry : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public EventEntry _003C_003E4__this;

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

		[SerializeField]
		private EventConfig[] configs;

		[CompilerGenerated]
		private Action<string> m_OnRefreshEvent;

		private const string key = "event_logger";

		private static string data;

		public static EventEntry Instance { get; private set; }

		public event Action<string> OnRefreshEvent
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

		[AsyncStateMachine(typeof(_003CAwake_003Ed__8))]
		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		private void OnDestroy()
		{
		}

		public void ForceRefreshEvent(string eventId)
		{
		}

		public void ForceRefreshAllEvent()
		{
		}

		private void ValidateEndAllEvent()
		{
		}

		private void ValidateEndBattlePass()
		{
		}

		private void SendSeasonEnd(BattlePassPayload payload)
		{
		}

		private void EnsureJoinAllEvent()
		{
		}

		private void EnsureJoinBattlePass()
		{
		}

		public static bool IsEventLogger(string eventId, int seasonId)
		{
			return false;
		}

		public static void LogEvent(string eventId, int seasonId)
		{
		}
	}
}
