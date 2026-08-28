using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using _Game.Events.Model;

namespace BattlePass.Model
{
	public class BattlePassService
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDelayedSaveAsync_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public CancellationToken token;

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

		public const int BATTLE_POINT_ID = 703;

		private static BattlePassPayload instance;

		private static CancellationTokenSource cts;

		private static BattlePassPayload lastSavedPayload;

		public static void InitPayload(CycleLifeSnapshot snapshot)
		{
		}

		public static void SavePayload(BattlePassPayload payload, bool forceSave = false)
		{
		}

		[AsyncStateMachine(typeof(_003CDelayedSaveAsync_003Ed__6))]
		private static UniTaskVoid DelayedSaveAsync(CancellationToken token)
		{
			return default;
		}

		public static bool TryGetPayload(out BattlePassPayload payload)
		{
			payload = null;
			return false;
		}

		public static int CurrentStage(BattlePassPayload payload)
		{
			return 0;
		}

		public static int CurrentStage(BattlePassPayload payload, int point)
		{
			return 0;
		}

		public static (int, int) GetPoint(BattlePassPayload payload, int stage)
		{
			return default;
		}

		public static (int, int) GetPoint(int point, BattlePassPayload payload, int stage)
		{
			return default;
		}

		public static int ThresholdAt(BattlePassPayload payload, int stage)
		{
			return 0;
		}

		public static int CurrentExtraStage(BattlePassPayload payload)
		{
			return 0;
		}

		public static int CurrentExtraStage(BattlePassPayload payload, int extraPoint)
		{
			return 0;
		}

		public static (int, int) GetExtraPoint(BattlePassPayload payload)
		{
			return default;
		}

		public static (int, int) GetExtraPoint(BattlePassPayload payload, int extraPoint)
		{
			return default;
		}

		public static bool IsMaximumLevel(out BattlePassPayload payload, out int currentStage)
		{
			payload = null;
			currentStage = default;
			return false;
		}

		public static bool IsMaximumLevel(int pb, out BattlePassPayload payload, out int currentStage)
		{
			payload = null;
			currentStage = default;
			return false;
		}

		public static bool CanClaimAnyQuest()
		{
			return false;
		}

		public static bool CanClaimAnyStage()
		{
			return false;
		}

		public static bool CanClaimChest()
		{
			return false;
		}

		public static bool IsUnlockEvent()
		{
			return false;
		}

		public static int GetPassIndex(int eventId)
		{
			return 0;
		}
	}
}
