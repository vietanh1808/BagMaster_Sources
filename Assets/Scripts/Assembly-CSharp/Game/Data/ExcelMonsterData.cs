using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelMonsterData
	{
		public int ID;

		public string Asset;

		public string Name;

		public string Mons_type;

		public int Class_ID;

		public string Speed;

		public string MovementCurve;

		public float AttackRangeMin;

		public float AttackRangeMax;

		public int SkillActive_ID;

		public string SkillPassive_ID;

		public string Elemental;

		public int Behaviour_ID;

		public float Scale;

		public int DamageTextFontSize;

		public bool HasBossBar;

		public string ColliderOffset;

		public string ColliderSize;

		public string HpBarSize;

		public string HpBarOffset;

		public string FloatingTextOffset;

		public string SpawnVfx;

		public float SpawnVfxDuration;

		public float KnockbackResistance;

		public float KnockbackResCD;

		public float StunResistance;

		public float StunResCD;

		public float FireDamageResistance;

		public float IceDamageResistance;

		public float ElectricDamageResistance;

		public float PlantDamageResistance;

		public float GoldDropWeight;

		public string DeathSfx;

		public string MonsterPrefabPreview;
	}
}
