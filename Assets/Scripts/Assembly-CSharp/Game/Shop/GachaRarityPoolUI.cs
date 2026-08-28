using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Constant;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Shop
{
	public class GachaRarityPoolUI : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CUpdateInfo_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GachaRarityPoolUI _003C_003E4__this;

			public Rarity rarity;

			public int tier;

			public float rarityRate;

			public List<ItemData> items;

			private float _003CindividualRate_003E5__2;

			private int _003Cindex_003E5__3;

			private List<ItemData>.Enumerator _003C_003E7__wrap3;

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

		[Header("UI Elements")]
		[SerializeField]
		private TextMeshProUGUI _rarityTitleText;

		[SerializeField]
		private Image _headerImage1;

		[SerializeField]
		private Image _headerImage2;

		[SerializeField]
		private GameObject _SImage;

		[SerializeField]
		private TextMeshProUGUI _rarityRateText;

		[SerializeField]
		private List<GachaPoolItemUI> _items;

		[SerializeField]
		private GridLayoutGroup _gridLayoutGroup;

		[SerializeField]
		private RectTransform _rectTransform;

		[SerializeField]
		private GachaInfoRarityProfile _uiProfile;

		[AsyncStateMachine(typeof(_003CUpdateInfo_003Ed__9))]
		public UniTask UpdateInfo(Rarity rarity, float rarityRate, int tier, List<ItemData> items)
		{
			return default;
		}

		private void UpdateRarityUi(Rarity rarity, int tier)
		{
		}

		private void UpdateSize(int itemCount)
		{
		}

		private string GetRarityDisplayName(Rarity rarity)
		{
			return null;
		}
	}
}
