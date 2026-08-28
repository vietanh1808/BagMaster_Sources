using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;

namespace Game.Combat
{
	public class GearSaveLoader : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStart_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public GearSaveLoader _003C_003E4__this;

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
		private CounterDropArea _counterDropArea;

		[SerializeField]
		private BenchDropArea _benchDropArea;

		[SerializeField]
		private bool doNotLoadSave;

		private Unit _player;

		private BagContentDropArea _bagDropArea;

		[AsyncStateMachine(typeof(_003CStart_003Ed__5))]
		private void Start()
		{
		}

		public void LoadData(CombatSaveData data)
		{
		}

		private void SetLockMerge(bool value)
		{
		}

		private void CreateGearInCounter(GearData gearData)
		{
		}

		private void CreateGearInBag(GearData gearData, Vector2Int[] gridPositions, float logValue)
		{
		}

		private void CreateGearInBench(GearData gearData, float logValue)
		{
		}

		private void DropGear(Gear gear, DropArea dropArea)
		{
		}
	}
}
