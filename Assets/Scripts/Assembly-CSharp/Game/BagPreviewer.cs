using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Combat;
using UnityEngine;

namespace Game
{
	public class BagPreviewer : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CInitBag_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public BagPreviewer _003C_003E4__this;

			public CombatSaveData saveData;

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
		private Bag _bag;

		[SerializeField]
		private PlayerUnit _playerUnit;

		[SerializeField]
		private BagLayoutManager _bagLayoutManager;

		[SerializeField]
		private GameplayBagSaveInitializer _bagSaveInitializer;

		[SerializeField]
		private GearSaveLoader _gearLoader;

		[SerializeField]
		private Vector3 _hidePosition;

		private Vector3 _showPosition;

		private CombatSaveData _saveData;

		private void Awake()
		{
		}

		public void Init(CombatSaveData saveData)
		{
		}

		public void SetBagStatus(bool isShown)
		{
		}

		private void ShowBag()
		{
		}

		private void TryInit()
		{
		}

		[AsyncStateMachine(typeof(_003CInitBag_003Ed__13))]
		private UniTask InitBag(CombatSaveData saveData)
		{
			return default;
		}

		public void HideBag()
		{
		}
	}
}
