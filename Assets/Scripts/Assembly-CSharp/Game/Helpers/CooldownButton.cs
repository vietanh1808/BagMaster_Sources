using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Helpers
{
	[RequireComponent(typeof(Button))]
	public class CooldownButton : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COnClicked_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public CooldownButton _003C_003E4__this;

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
		private int cooldown;

		[SerializeField]
		private int delay;

		private Button button;

		private CancellationTokenSource cts;

		private List<UnityAction> listButtonEvents;

		private bool isCoolingDown;

		public Button Button => null;

		public void AddListener(UnityAction action)
		{
		}

		public void RemoveListener(UnityAction action)
		{
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		[AsyncStateMachine(typeof(_003COnClicked_003Ed__12))]
		private void OnClicked()
		{
		}
	}
}
