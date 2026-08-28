using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Constant;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Shop
{
	public class GachaPoolUI : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CDisplayAllRarityPools_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GachaPoolUI _003C_003E4__this;

			private float _003CtotalWeight_003E5__2;

			private Dictionary<int, List<ItemData>> _003Cgroup_003E5__3;

			private List<int> _003Crarities_003E5__4;

			private int _003Cindex_003E5__5;

			private UniTask.Awaiter _003C_003Eu__1;

			private List<int>.Enumerator _003C_003E7__wrap5;

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

		[Header("UI Elements")]
		[SerializeField]
		private List<GachaRarityPoolUI> _items;

		[SerializeField]
		private ScrollRect _scrollRect;

		private GachaData _gachaData;

		private void Start()
		{
		}

		public void UpdateInfo(GachaData gachaData)
		{
		}

		[AsyncStateMachine(typeof(_003CDisplayAllRarityPools_003Ed__5))]
		private UniTask DisplayAllRarityPools()
		{
			return default;
		}

		private int GetRarityKey(Rarity rarity, int tier)
		{
			return 0;
		}

		private void ExtractKey(int key, out Rarity rarity, out int tier)
		{
			rarity = default;
			tier = default;
		}

		private void CreateRarityPoolUI(Rarity rarity, List<ItemData> itemDatas, float totalWeight, int tier, int index)
		{
		}

		private Rarity GetItemRarity(ItemData itemData, out int tier)
		{
			tier = default;
			return Rarity.Common;
		}
	}
}
