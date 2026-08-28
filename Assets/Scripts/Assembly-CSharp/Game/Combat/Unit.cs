using Game.Combat.SkillSystem;
using Game.Tools;
using R3;
using UnityEngine;

namespace Game.Combat
{
	public class Unit : MonoBehaviour, IEffectCaster, IStatOwner, IEffectTarget, IUpdater, ISkillSwapOwner
	{
		public int Id;

		public ListUnits channel;

		public Health health;

		public GoldBar inventory;

		public Team team;

		public UnitType unitType;

		public Vector3 aimOffset;

		public CharacterModel Model;

		public float attackRange;

		public bool Visible;

		public bool IsSummoned;

		public IStatHolder UnitStats;

		public bool DontAddToTeam;

		public Stat TimeScaleStat;

		public Stat SkillTimeScaleStat;

		public Stat StunStat;

		public IStatHolder StatHolder => null;

		public Subject<DealDamageData> DealDamageEvent { get; private set; }

		public float TimeScale => 0f;

		public bool IsStun => false;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected virtual void Awake()
		{
		}

		public virtual void CustomUpdate(float dt)
		{
		}

		public void InvokeDealDamageEvent(DamageData damageData, Health target)
		{
		}

		void ISkillSwapOwner.Swap(SkillData from, SkillData to)
		{
		}

		void ISkillSwapOwner.Revert(SkillData to)
		{
		}

		public float GetAngle()
		{
			return 0f;
		}

		public float GetDirection()
		{
			return 0f;
		}

		public Vector3 GetTransformDirection()
		{
			return default;
		}

		public Vector3 GetVectorDirection()
		{
			return default;
		}
	}
}
