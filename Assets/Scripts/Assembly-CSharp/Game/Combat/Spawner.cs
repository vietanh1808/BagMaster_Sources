using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Game.AssetManager;
using Game.EventDungeon;
using Game.Tools;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.SceneManagement;

namespace Game.Combat
{
	public class Spawner : MonoBehaviour, IUpdater
	{
		private struct SpawnMonsterParameter
		{
			public MonsterData monsterData;

			public int monsterLevel;

			public float atkModifier;

			public float HpModifier;

			public int portal;

			public float offsetXPerUnit;

			public float randomYFactor;

			[Obsolete("Use goldDrop")]
			public int goldDrop;

			public List<ResourceRewardData> rewardDrops;
		}

		private class SpawnGroupPoint
		{
			public float Time;

			public MonsterData MonsterData;

			public int MonsterLevel;

			public float AtkModifier;

			public float HpModifier;

			public int Portal;

			public float OffsetXPerUnit;

			public float RandomYFactor;

			[Obsolete("Use RewardDrop")]
			public int GoldDrop;

			public List<ResourceRewardData> RewardDrops;
		}

		[Serializable]
		public struct RewardCurrencyInfo
		{
			[NonSerialized]
			public int TotalAmount;

			[NonSerialized]
			public int DistributedAmount;

			public SerializedPosition FlyInTarget;

			public UnityEvent OnReachedFlyInTarget;

			public int UndistributedAmount => 0;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass46_0
		{
			public Spawner _003C_003E4__this;

			public SpawnGroupPoint spawnGroupPoint;

			internal bool _003CSpawn_003Eb__0()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadMonsterModel_003Ed__56 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public Awaitable.AwaitableAsyncMethodBuilder _003C_003Et__builder;

			public SpawnGroupPoint data;

			public Spawner _003C_003E4__this;

			private string _003CmodelPath_003E5__2;

			private AsyncOperationHandle<GameObject> _003CasyncOperationHandle_003E5__3;

			private TaskAwaiter<GameObject> _003C_003Eu__1;

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

		[CompilerGenerated]
		private sealed class _003CSpawn_003Ed__46 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Spawner _003C_003E4__this;

			public SpawnGroupPoint spawnGroupPoint;

			private _003C_003Ec__DisplayClass46_0 _003C_003E8__1;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSpawn_003Ed__46(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSpawnMonster_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public Spawner _003C_003E4__this;

			public SpawnMonsterParameter parameter;

			private GameObject _003Cmodel_003E5__2;

			private Vector3 _003CspawnPosition_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSpawnMonster_003Ed__47(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		public static GameObject[] StandAtEndFilterWithPortal;

		[SerializeField]
		[Range(0f, 1f)]
		private float _goldDropRateByEnemy;

		[SerializeField]
		private string _spawnVfxPrefabPath;

		[SerializeField]
		private float _spawnVfxDuration;

		[SerializeField]
		private GoldBar _combatGoldBar;

		[SerializeField]
		private GoldCaveCoinBar _goldCaveCoinBar;

		[SerializeField]
		private Transform _goldCaveBarPosition;

		[SerializeField]
		private CanvasGroup _uiCanvas;

		[SerializeField]
		private SerializedDictionary<int, RewardCurrencyInfo> _rewardMap;

		private List<GameObject> _monsterSpawneds;

		private List<SpawnGroupPoint> _spawnGroupPoints;

		private float _countTime;

		private Dictionary<string, GameObject> _monsterModels;

		private List<AsyncOperationHandle<GameObject>> _monsterModelOperations;

		private HashSet<string> _loadingModels;

		private Dictionary<string, PrefabAddressable> _spawnVfxLoaders;

		private Unit _player;

		private Transform[] _portals;

		public int SpawnId { get; set; }

		public int CurrentSpawnNumber => 0;

		public float TotalSpawningTime { get; private set; }

		public int TotalSpawnNumber { get; private set; }

		private void Start()
		{
		}

		public void SetPortals(Transform[] portals)
		{
		}

		private void OnDestroy()
		{
		}

		public void CustomUpdate(float dt)
		{
		}

		private void OnActiveSceneChanged(Scene arg0, Scene arg1)
		{
		}

		public void ShowUi(bool show)
		{
		}

		public void Spawn()
		{
		}

		public void Stop()
		{
		}

		public void CalculateTotalSpawnCount()
		{
		}

		private void DistributeCombatDropRewards()
		{
		}

		private void CalculateTotalSpawnCount(SpawnData spawnData)
		{
		}

		[IteratorStateMachine(typeof(_003CSpawn_003Ed__46))]
		private IEnumerator Spawn(SpawnGroupPoint spawnGroupPoint)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CSpawnMonster_003Ed__47))]
		private IEnumerator SpawnMonster(SpawnMonsterParameter parameter)
		{
			return null;
		}

		private int GetPortal(List<int> portals, int distributionType, int monsterIndex)
		{
			return 0;
		}

		private Vector3 GetRightSpawnPosition(int portal, float offsetXPerUnit)
		{
			return default;
		}

		private void DistributeCombatDropReward(ResourceRewardData rewardData, Func<MonsterData, float> weightGetter = null)
		{
		}

		private void DistributeDropRewards()
		{
		}

		private void DistributeDropRewardsEvenly(IEnumerable<IGrouping<MonsterData, SpawnGroupPoint>> monsterSpawnGroups, int rewardId, int rewardAmount)
		{
		}

		private void DistributeDropRewardsByMonsterWeight(IEnumerable<IGrouping<MonsterData, SpawnGroupPoint>> monsterSpawnGroups, int rewardId, int rewardAmount, float sumWeight)
		{
		}

		private void DistributeDropRewardsPerGroup(IGrouping<MonsterData, SpawnGroupPoint> group, int rewardId, int rewardAmount)
		{
		}

		private void LoadMonsterSpawnVfx(SpawnGroupPoint data)
		{
		}

		[AsyncStateMachine(typeof(_003CLoadMonsterModel_003Ed__56))]
		private Awaitable LoadMonsterModel(SpawnGroupPoint data)
		{
			return null;
		}

		private Unit GetPlayer()
		{
			return null;
		}

		public Vector3 GetFlyInPosition(int rewardId)
		{
			return default;
		}

		public int GetUndistributedReward(int rewardId)
		{
			return 0;
		}

		public RewardCurrencyInfo GetRewardInfo(int rewardId)
		{
			return default;
		}
	}
}
