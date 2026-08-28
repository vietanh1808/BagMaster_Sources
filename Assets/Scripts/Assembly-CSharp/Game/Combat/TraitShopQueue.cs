using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;

namespace Game.Combat
{
	public static class TraitShopQueue
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CReleaseQueue_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

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

		private static readonly List<(Action Callback, int Priority)> Queue;

		public static bool IsBuffShopOpened { get; private set; }

		[RuntimeInitializeOnLoadMethod]
		private static void Init()
		{
		}

		private static void OnBuffShopEvent(PlayerActionEventData eventData)
		{
		}

		private static void HandleBuffShopExit()
		{
		}

		[AsyncStateMachine(typeof(_003CReleaseQueue_003Ed__8))]
		private static UniTask ReleaseQueue()
		{
			return default;
		}

		public static void PushView<T>(string prefabPath, Action<T> viewPushedCallback, int priority = -2147483648)
		{
		}

		private static void OpenView<T>(string prefabPath, Action<T> viewLoadCallback)
		{
		}

		public static void AddToQueue(Action callback, int priority = -2147483648)
		{
		}
	}
}
