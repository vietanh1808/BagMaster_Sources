using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Combat.Dungeon;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using I2.Loc;
using MoreMountains.Feedbacks;
using MoreMountains.Tools;
using UnityEngine;
using UnityEngine.Serialization;

namespace Game.UI
{
	public class ExpBar : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDoRollOver_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public ExpBar _003C_003E4__this;

			public float targetValue;

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
		private MMProgressBar _progressBar;

		[SerializeField]
		private MMF_Player _expGainFeedback;

		[SerializeField]
		private MMF_Player _levelUpFeedback;

		[SerializeField]
		private LocalizationParamsManager _levelParamsManager;

		[FormerlySerializedAs("_expManager")]
		[SerializeField]
		private ExpManager _expManagerComponent;

		[SerializeField]
		[Tooltip("If true, the bar will automatically update when player gain exp")]
		private bool _autoUpdate;

		private int _currentExp;

		private CancellationTokenSource _cancelSource;

		private IExpManager _expManager;

		private void Start()
		{
		}

		public void UpdateExp(int discard = 0)
		{
		}

		private void OnExpGain(int totalExp)
		{
		}

		private void UpdateLevelText()
		{
		}

		private void SetProgressBar(int totalExp)
		{
		}

		[AsyncStateMachine(typeof(_003CDoRollOver_003Ed__14))]
		private UniTask DoRollOver(float targetValue)
		{
			return default;
		}

		private void OnMilestoneReached(int milestoneIndex)
		{
		}
	}
}
