using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public static class EffectFactory
	{
		private static readonly string[] DamageNames;

		private static readonly string[] HealNames;

		private static readonly string[] ShieldNames;

		private static readonly string[] ResourceGainNames;

		public static bool IsDamage(string type)
		{
			return false;
		}

		public static bool IsHeal(string type)
		{
			return false;
		}

		public static bool IsShield(string type)
		{
			return false;
		}

		public static bool IsResourceGain(string type)
		{
			return false;
		}

		public static IEffect CreateEffect(EffectCreationParams param)
		{
			return null;
		}

		public static EDamage CreateDamage(EffectCreationParams param)
		{
			return null;
		}

		public static EDamageByMaxHp CreateDamageByMaxhp(EffectCreationParams param)
		{
			return null;
		}

		public static EDamageByTargetMaxHp CreateDamageByTargetMaxhp(EffectCreationParams param)
		{
			return null;
		}

		private static EDamageParams GetEDamageParams(object EffectSource, EffectParams effectParams, EDamageFormula formula, Vector3 position, bool nonCrit, bool dodgeable)
		{
			return default;
		}

		public static EBlast CreateBlast(EffectCreationParams param)
		{
			return null;
		}

		public static EPoision CreatePoison(EffectCreationParams param)
		{
			return null;
		}

		public static EHeal CreateHeal(EffectCreationParams param)
		{
			return null;
		}

		public static EStatBuff CreateSlow(EffectCreationParams param)
		{
			return null;
		}

		public static EStatBuff CreateStatBuff(EffectCreationParams param)
		{
			return null;
		}

		public static EShield CreateShield(EffectCreationParams param)
		{
			return null;
		}

		public static EShield CreateInstantShield(EffectCreationParams param)
		{
			return null;
		}

		public static EGold CreateGold(EffectCreationParams param)
		{
			return null;
		}

		public static EFreeze CreateFreeze(EffectCreationParams param)
		{
			return null;
		}

		public static EAoe CreateAoe(EffectCreationParams param)
		{
			return null;
		}

		public static EFreeGearRoll CreateFreeReroll(EffectCreationParams param)
		{
			return null;
		}

		public static IEffect CreateUpgrade(EffectCreationParams param)
		{
			return null;
		}

		private static IEffect CreateSwapSkill(EffectCreationParams param)
		{
			return null;
		}

		private static IEffect CreateAddTag(EffectCreationParams param)
		{
			return null;
		}

		private static IEffect CreateKnockback(EffectCreationParams param)
		{
			return null;
		}

		private static IEffect CreateBuffDpsMod(EffectCreationParams param)
		{
			return null;
		}

		public static IEffect CreateCastSkill(EffectCreationParams param)
		{
			return null;
		}

		private static IEffect CreateStatConvert(EffectCreationParams param)
		{
			return null;
		}

		private static IEffect CreateChangeModel(EffectCreationParams param)
		{
			return null;
		}

		private static IEffect CreateNothing(EffectCreationParams param)
		{
			return null;
		}

		public static float GetDuration(EffectData effectData)
		{
			return 0f;
		}
	}
}
