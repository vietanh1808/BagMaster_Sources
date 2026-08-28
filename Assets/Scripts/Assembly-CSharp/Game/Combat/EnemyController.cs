using System;
using System.Collections.Generic;
using DG.Tweening;
using Game.CodedAnimation;
using Game.EventDungeon;
using Game.Tools;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.Combat
{
	public class EnemyController : MonoBehaviour, IUpdater
	{
		public DotweenAnimation3 _deathAnimation;

		public DotweenAnimation3 _deathAnimationBoss;

		public string DropGoldSoundName;

		[Header("Runtime")]
		public Transform Rotator;

		public float SpawnAtkScale;

		[SerializeField]
		private bool _inKnockback;

		public int PortalFrom;

		public IStatHolder StatHolder;

		public SimpleSkill ActiveSkill;

		public List<SimpleSkill> PassiveSkills;

		public float ActiveSkillCooldown;

		public Unit MoveTo;

		public Unit Unit;

		public MonsterData MonsterData;

		public MonsterLevelData LevelData;

		public AnimationCurveSO MovementCurve;

		[Obsolete("Use RewardDrop")]
		public int GoldDrop;

		[SerializeField]
		private ElementalIcon _elementalIcon;

		public List<ResourceRewardData> RewardDrops;

		public GoldBar GoldBar;

		public GoldCaveCoinBar goldCaveCoinBar;

		public Vector3 goldCaveCoinBarPosition;

		public Spawner Spawner;

		public float LastKnockbackTime;

		private EnemyState _currentState;

		private Sequence _deathSequence;

		private Transform _meleeVirtualProjectile;

		private const string StaggerLabel = "Stagger";

		public MonsterClassData ClassData => null;

		public bool CanBeKnockedback => false;

		public bool IsBoss => false;

		public EnemyMovingState MovingState { get; private set; }

		public EnemyIdleState IdleState { get; private set; }

		public EnemyAttackState AttackState { get; private set; }

		public EnemyInKnockbackState InKnockbackState { get; private set; }

		public float SkillCooldownTime { get; set; }

		public Stat MoveSpeedStat { get; private set; }

		public MMF_Feedback Stagger { get; private set; }

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		void IUpdater.CustomUpdate(float dt)
		{
		}

		public void TransitionTo(EnemyState newState)
		{
		}

		public void SetKnockbackState(bool value)
		{
		}

		private EnemyState DetermineRecoveryState()
		{
			return null;
		}

		private void SetUpAnimation()
		{
		}

		public void SetModelVisible(bool visible)
		{
		}

		public void CheckLastStandByPortal()
		{
		}

		public bool Reached()
		{
			return false;
		}

		private void PlayDeathAnimation()
		{
		}

		private void OnAttackCompleted()
		{
		}

		public void Cast()
		{
		}

		private void OnDie(Health health)
		{
		}

		private void DropRewards()
		{
		}

		private void CreateCombatDrop(ResourceRewardData reward, CurrencyData currencyData)
		{
		}

		private void OnRevive(Health health)
		{
		}

		public Transform CreateMeleeVirtualProjectile()
		{
			return null;
		}
	}
}
