using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Game.Combat;
using UnityEngine;

namespace Game.GearUpgrade
{
	public class GearUpgradePanel : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAwake_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public GearUpgradePanel _003C_003E4__this;

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
		private List<GearUIItem> _activeGears;

		[SerializeField]
		private List<GearUIItem> _passiveGears;

		private List<GearData> _activeGearDatas;

		private List<GearData> _passiveGearDatas;

		private PlayerInfo PInfo => null;

		[AsyncStateMachine(typeof(_003CAwake_003Ed__6))]
		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void CreateItem(List<GearData> gearDatas, List<GearUIItem> gearUIItems)
		{
		}

		private int SortGearData(GearData x, GearData y)
		{
			return 0;
		}
	}
}
