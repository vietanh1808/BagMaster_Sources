using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Game.GearUpgrade
{
	public class GearCardStarBreakResultPanelUI : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GearCardStarBreakResultPanelUI _003C_003E4__this;

			public List<GearCardStarBreakRewardItem> rewards;

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
		private GearCardStarBreakResultItemUI _itemPrefab;

		[SerializeField]
		private Transform _itemContainer;

		[SerializeField]
		private Button _closeButton;

		[SerializeField]
		private float _delayToClose;

		private List<GearCardStarBreakResultItemUI> _activeItems;

		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__5))]
		public UniTask UpdateInfo(List<GearCardStarBreakRewardItem> rewards)
		{
			return default;
		}

		private void CreateRewardItem(GearCardStarBreakRewardItem rewardItem)
		{
		}

		private void ClearItems()
		{
		}

		private void OnDestroy()
		{
		}
	}
}
