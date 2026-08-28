using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Combat;
using Game.StarBreaking;
using UnityEngine;

namespace Game.GearUpgrade
{
	public class GearCardStarBreakManager : MonoBehaviour
	{
		public class PresentData
		{
			public StarBreakResult Result;

			public List<GearCardStarBreakRewardItem> Rewards;

			public bool SkipAnimation;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPreroll_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public StarBreakPackData pack;

			public GearCardStarBreakManager _003C_003E4__this;

			public float multipleValue;

			private StarBreakResult _003Cresult_003E5__2;

			private List<GearCardStarBreakRewardItem> _003CcardRewards_003E5__3;

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
		private int _crackCount;

		[SerializeField]
		private bool _autoOpenRemainCurrency;

		[SerializeField]
		private int _minRewardCount;

		[SerializeField]
		private int _maxRewardCount;

		[Header("Runtime")]
		[SerializeField]
		private bool _isOpenning;

		private Dictionary<int, StarBreakPackData> _currencyMap;

		private Queue<PresentData> _openQueues;

		public static bool SkipNextAnimations { get; set; }

		public static GearCardStarBreakManager Instance { get; private set; }

		private PlayerInfo PInfo => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void InitializeCurrencyMap()
		{
		}

		private void AutoContinueRemainPacks(int currencyId, StarBreakPackData pack)
		{
		}

		private void OnResourceChanged(OwnedResourceEntity resourceEntity, int additionAmount, string placement)
		{
		}

		private IReadOnlyDictionary<int, StarBreakPackData> GetDatas()
		{
			return null;
		}

		[AsyncStateMachine(typeof(_003CPreroll_003Ed__26))]
		public UniTask Preroll(StarBreakPackData pack, float multipleValue = 1f)
		{
			return default;
		}

		private List<GearCardStarBreakRewardItem> DistributeGearCard(int totalCardNumber)
		{
			return null;
		}

		private List<GearCardStarBreakRewardItem> DistributeGearCardRandomly(int totalCardNumber)
		{
			return null;
		}

		private int[] DistributeCardsRandomly(int totalCards, int partCount)
		{
			return null;
		}

		private GearCardStarBreakRewardItem CreateRewardVisualData(GearData gearData, GearUpgradeData upgradeData, int cardNumber)
		{
			return null;
		}

		public StarBreakPackData GetCorrespondStarBreakData(int currencyId)
		{
			return null;
		}

		public bool HasStarInReward(IEnumerable<ResourceRewardData> rewardDatas)
		{
			return false;
		}

		public bool IsStarReward(int id)
		{
			return false;
		}
	}
}
