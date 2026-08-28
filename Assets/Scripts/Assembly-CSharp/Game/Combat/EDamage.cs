using System;
using System.Collections.Generic;

namespace Game.Combat
{
	public class EDamage : SafeDisposeable, IEffect
	{
		protected EDamageParams _params;

		protected EDamageCasterData _casterData;

		protected EDamageGearData _gearData;

		protected float _calculatedDamage;

		protected float _targetDodgeMod;

		protected bool _isCrit;

		[Obsolete("Use ElementCounterMod instead")]
		protected bool _isEffective;

		protected bool _isImmune;

		protected bool _invokedDealDamageEvent;

		protected bool _isDodged;

		protected float ElementCounterMod;

		public float Intensity { get; set; }

		public float CalculatedDamage => 0f;

		public EDamage(EDamageParams param)
		{
		}

		public EDamage(IEffectCaster caster, Stat.GetValueCustomDelegate statModifierFilter, EDamageParams param)
		{
		}

		public EDamage(IEffectCaster caster, IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter, EDamageParams param)
		{
		}

		protected virtual void InitializeCasterData(IEffectCaster caster, Stat.GetValueCustomDelegate statModifierFilter)
		{
		}

		protected virtual void InitializeGearData(IEffectGear gear, Stat.GetValueCustomDelegate statModifierFilter)
		{
		}

		protected void CheckCrit()
		{
		}

		public virtual float CalculateDamage(EDamageFormula formula, EnemyController enemy, Unit player, float intensity = 1f)
		{
			return 0f;
		}

		protected virtual float CalculateDamagingPlayer(Unit player, float intensity = 1f)
		{
			return 0f;
		}

		protected virtual float CalculateDamagingMonster(EnemyController monster, float intensity = 1f)
		{
			return 0f;
		}

		protected virtual float CalculateDamagingPvP(Unit target, float intensity = 1f)
		{
			return 0f;
		}

		public virtual float CalculateDamageAverage(float mod1, List<float> mod2)
		{
			return 0f;
		}

		protected float Dodge(Unit unit)
		{
			return 0f;
		}

		protected float GetElementMod(IStatHolder statHolder, Elemental elemental, Stat.GetValueCustomDelegate filter = null)
		{
			return 0f;
		}

		protected float GetElemetalDamageBonus(IStatHolder statHolder, Elemental elemental, Stat.GetValueCustomDelegate filter = null)
		{
			return 0f;
		}

		protected float GetAttackTypeResistance(IStatHolder statHolder, EDamageAttackType attackType, Stat.GetValueCustomDelegate filter = null)
		{
			return 0f;
		}

		protected float GetElementResistance(IStatHolder statHolder, Elemental elemental, Stat.GetValueCustomDelegate filter = null)
		{
			return 0f;
		}

		protected bool CanDealDamageAlthoughCasterAlreadyDead()
		{
			return false;
		}

		public virtual void Execute(IEffectTarget target)
		{
		}

		protected virtual void DealDamage(Unit targetUnit)
		{
		}

		protected EDamageFormula GetDamageFormula(Unit targetUnit)
		{
			return EDamageFormula.DamagingMonster;
		}

		protected virtual bool VerifyTarget(IEffectTarget target, out Unit targetUnit)
		{
			targetUnit = null;
			return false;
		}

		protected virtual bool VerifyTarget(Unit targetUnit)
		{
			return false;
		}

		protected virtual void HealByLifesteal(float damageAmount)
		{
		}

		protected override void DoDispose()
		{
		}
	}
}
