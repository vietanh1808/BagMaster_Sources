using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;

namespace Game.Combat
{
	public class PvPArenaPointChangeAnimator : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPlayAnimation_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public int point1New;

			public int point1;

			public int point2New;

			public int point2;

			public PvPArenaPointChangeAnimator _003C_003E4__this;

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

		[Header("Names")]
		[SerializeField]
		private TextMeshProUGUI _player1NameText;

		[SerializeField]
		private TextMeshProUGUI _player2NameText;

		[Header("Points")]
		[SerializeField]
		private TextMeshProUGUI _point1Text;

		[SerializeField]
		private TextMeshProUGUI _point2Text;

		[SerializeField]
		private TextMeshProUGUI _point1Changes;

		[SerializeField]
		private TextMeshProUGUI _point2Changes;

		[Header("Animation")]
		[SerializeField]
		private float _pointTextDuration;

		[SerializeField]
		private float _changesTextDuration;

		public void SetPlayerNames(string player1Name, string player2Name)
		{
		}

		[AsyncStateMachine(typeof(_003CPlayAnimation_003Ed__9))]
		public UniTask PlayAnimation(int point1, int point2, int point1New, int point2New)
		{
			return default;
		}

		private void AnimatePoint(TextMeshProUGUI pointText, TextMeshProUGUI changesText, int from, int to, int change)
		{
		}

		private string FormatChange(int change)
		{
			return null;
		}
	}
}
