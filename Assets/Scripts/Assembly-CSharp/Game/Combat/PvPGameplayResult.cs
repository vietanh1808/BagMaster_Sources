using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class PvPGameplayResult : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPlayAnimation_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public PvPGameplayResult _003C_003E4__this;

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
		private PvPArenaPointChangeAnimator _animator;

		[SerializeField]
		private CanvasGroup _interactableGroup;

		[SerializeField]
		private Button _homeButton;

		private int _player1Score;

		private int _player2Score;

		private int _player1ScoreNew;

		private int _player2ScoreNew;

		private bool _started;

		private bool _dataReady;

		protected virtual void Start()
		{
		}

		public void UpdateInfo(string player1Name, string player2Name, int player1Score, int player2Score, int player1ScoreNew, int player2ScoreNew)
		{
		}

		[AsyncStateMachine(typeof(_003CPlayAnimation_003Ed__11))]
		private UniTask PlayAnimation()
		{
			return default;
		}

		private void GoHome()
		{
		}
	}
}
