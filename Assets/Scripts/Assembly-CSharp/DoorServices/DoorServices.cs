using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace DoorServices
{
	public static class DoorServices
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLogin_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public bool forceAuthenticate;

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

		private static DoorServiceLogin _serviceLogin;

		public static DoorServiceLogin ServiceLogin => null;

		[AsyncStateMachine(typeof(_003CLogin_003Ed__3))]
		public static UniTask Login(bool forceAuthenticate = false)
		{
			return default;
		}

		public static void ShowRatingPopup()
		{
		}

		public static void EnablePremium()
		{
		}

		public static void DisablePremium()
		{
		}

		public static bool HasAdsRemoval1()
		{
			return false;
		}

		public static string CostToJson(int id, int amount)
		{
			return null;
		}

		public static string CostToJson<T>(IEnumerable<T> values, Func<T, (int, int)> parseFunc)
		{
			return null;
		}

		public static string GetEvtModeContext(string m, int l, int ch)
		{
			return null;
		}
	}
}
