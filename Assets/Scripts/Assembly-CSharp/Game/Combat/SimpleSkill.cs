using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game.AssetManager;
using Game.Combat.SkillSystem;
using Game.Tools;
using R3;
using UnityEngine;

namespace Game.Combat
{
	public class SimpleSkill : MonoBehaviour, IHasEffectTags, IOnKillListener, IUpdater
	{
		[CompilerGenerated]
		private sealed class _003CCastWithCastingTime_003Ed__149 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public SimpleSkill _003C_003E4__this;

			public bool isResetCooldown;

			private float _003Cduration_003E5__2;

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
			public _003CCastWithCastingTime_003Ed__149(int _003C_003E1__state)
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

		public SkillData Data;

		public Unit Owner;

		public Gear Gear;

		public bool HasUpdate;

		public ISkilLCondition Condition;

		public List<ISkillComponent> Components;

		public float ProjectileDuration;

		public LayerMask TargetLayerMask;

		public List<DefaultSoundConfig.SoundData> HitSfxsRandomList;

		public DefaultSoundConfig.SoundData ProjectileAppearSfx;

		private SimpleTimer _cooldownTimer;

		private LimitCounter _limitWholeMapCounter;

		private LimitCounter _limitPerWaveCounter;

		private float _attackSpeed;

		private bool _randomTarget;

		private Func<List<IEffectTarget>> _targetFinder;

		private List<IEffectTarget> _targets;

		private List<IEffectTarget> _inObserverTargets;

		private Subject<SkillCastData> _onCasted;

		private Subject<SkillExecuteData> _onExecuted;

		private EffectController _effectController;

		private IShooter _shooter;

		private AudioSource _activateSfx;

		private DisposableBag _initializeDisposables;

		private SkillAnimationService _skillAnimationService;

		private VFXService _appearVfxService;

		private PrefabAddressable _activateVfxLoader;

		private PrefabAddressable _hitVfxLoader;

		private PrefabAddressable _hitAttachVfxLoader;

		private PrefabAddressable _trailVfxLoader;

		private PrefabAddressable _projectileAppearVfxLoader;

		private SpriteAddressable _projectileSpriteLoader;

		[SerializeField]
		private List<GameObject> _projectiles;

		private List<string> _castSkillVfxRegisteredPaths;

		private const float TO_FREEZE_LERP_SPEED = 4f;

		private const float TO_UNFREEZE_LERP_SPEED = 2f;

		private bool _inFreeze;

		private static readonly WaitForSeconds _waitToFreeze;

		private WaitForSeconds _castingDurationWait;

		private float _lastCastingDuration;

		public List<string> Tags { get; }

		public bool InCastingTime { get; private set; }

		public float StartCastingTime { get; private set; }

		public Observable<SkillCastData> OnCast => null;

		public Observable<SkillExecuteData> OnExecute => null;

		public float CooldownCalculated => 0f;

		public float RemainTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public SkillTargeType TargetType { get; private set; }

		public IShooter Shooter => null;

		public IEffectTarget CurrentTarget => null;

		public IReadOnlyList<IEffectTarget> Targets => null;

		public IReadOnlyList<IEffectTarget> InObserverTargets => null;

		public bool Initialized { get; private set; }

		public bool ReachedLimit => false;

		public bool CooldownReady => false;

		public float Cooldown01 => 0f;

		public float Range => 0f;

		public float AttackSpeed => 0f;

		public EffectController EffectController => null;

		public AudioSource ActivateSfx => null;

		public float CastingDuration { get; private set; }

		public PlayerProfile PlayerProfile { get; private set; }

		public Bag Bag => null;

		public string SynercyText { get; private set; }

		public bool IsPlayer2 => false;

		public int CooldownCounter { get; private set; }

		public int CooldownAdsCounter { get; private set; }

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		void IUpdater.CustomUpdate(float dt)
		{
		}

		public void Initialize()
		{
		}

		private void RegisterCastSkillVfxToPooler()
		{
		}

		private void RegisterSkillVfxToPooler(string vfxPath)
		{
		}

		private void UnregisterCastSkillVfxFromPooler()
		{
		}

		protected void InitializePlayer()
		{
		}

		protected void InitializeLimitCounters()
		{
		}

		protected void InitializeAnimation()
		{
		}

		protected virtual void InitializeTargetFinder()
		{
		}

		protected void SetTargetFinderOwner()
		{
		}

		protected void SetTargetFinderGear()
		{
		}

		protected void SetTargetFinderGearNearby()
		{
		}

		protected TargetFinderGearNearby CreateTargetFinderGearNearby(string data)
		{
			return null;
		}

		protected void SetTargetFinderAllGears(bool onlyInBag)
		{
		}

		protected void SetTargetFinderByTeam()
		{
		}

		protected void SetTargetFinderMonster(FilterMethod method)
		{
		}

		protected void SetTargetFinderPlayer()
		{
		}

		protected void InitializeEffectController()
		{
		}

		protected void InitializeShooter()
		{
		}

		protected void InitializeProjectileSprite()
		{
		}

		private PrefabAddressable InitVfxLoader(ref PrefabAddressable loader, string vfxName)
		{
			return null;
		}

		protected void InitializeActivateVfx()
		{
		}

		private void InitializeSfxs()
		{
		}

		public void PlayHitSfx()
		{
		}

		public void PlayProjectileSfx()
		{
		}

		public void UpdateAttackSpeed()
		{
		}

		public float GetAttackSpeed(Stat.GetValueCustomDelegate statModifierFilter)
		{
			return 0f;
		}

		private float CapAttackSpeedWithMinCooldown()
		{
			return 0f;
		}

		public bool InAnimation()
		{
			return false;
		}

		protected bool NoTarget()
		{
			return false;
		}

		protected bool TargetOutRange()
		{
			return false;
		}

		public void Cast(bool isResetCooldown = true)
		{
		}

		[IteratorStateMachine(typeof(_003CCastWithCastingTime_003Ed__149))]
		protected IEnumerator CastWithCastingTime(bool isResetCooldown)
		{
			return null;
		}

		protected void CastNoCastingTime(bool isResetCooldown)
		{
		}

		protected void PreCast()
		{
		}

		protected void PostCast()
		{
		}

		public void Execute(IReadOnlyList<IEffectTarget> targets, bool isResetCooldown = true)
		{
		}

		public void FindTarget()
		{
		}

		public void SetTarget(List<IEffectTarget> targets)
		{
		}

		public void ClearTargets()
		{
		}

		public void SetCooldown(float normalized)
		{
		}

		public void SetCooldownInFloat(float cooldown)
		{
		}

		public int GetSpreadProjectileCount()
		{
			return 0;
		}

		public void DoActivateOrCast()
		{
		}

		public void DoActivateOrCast(bool isResetCooldown)
		{
		}

		private void ExecuteActivateOrCast(bool isCheckCooldown, bool isResetCooldown)
		{
		}

		public void UndoActivateOrCast()
		{
		}

		public void Active()
		{
		}

		public void Deactive()
		{
		}

		public void Cancel()
		{
		}

		public void Destroy()
		{
		}

		public bool HasComponent<T>() where T : ISkillComponent
		{
			return false;
		}

		public void ComponentsDo<T>(Action<T> action)
		{
		}

		public void ClearSkillComponents()
		{
		}

		public void OnKill(Health target)
		{
		}

		public void GetLimitCount(out int waveCount, out int wholeMapCount)
		{
			waveCount = default;
			wholeMapCount = default;
		}

		public void SetWaveActivateLimit(int count)
		{
		}

		public void SetWholeMapActivateLimit(int count)
		{
		}

		public void RegisterProjectile(GameObject projectile)
		{
		}

		public void UnregisterProjectile(GameObject projectile)
		{
		}

		public int GetActiveProjectileCount()
		{
			return 0;
		}

		public bool IsReachLimitProjectile()
		{
			return false;
		}

		public Sprite GetProjectileSprite()
		{
			return null;
		}

		public Sprite GetProjectileSpriteOfSkill()
		{
			return null;
		}

		public string GetActivateVfxName(SkillData skillData)
		{
			return null;
		}

		public void RestoreCooldownCounter(int value)
		{
		}

		public void RestoreCooldownAdsCounter(int value)
		{
		}

		public void IncrementCooldownCount()
		{
		}

		public void IncrementCooldownAdsCounter()
		{
		}

		public void ResetCooldownAdsCounter()
		{
		}
	}
}
