using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	public class MonsterData
	{
		public int Id;

		public string Name;

		public string ModelPath;

		public string MonsterType;

		public MonsterClassData Class;

		public float Speed;

		public string MovementCurve;

		public float AttackRangeMin;

		public float AttackRangeMax;

		public int ActiveSkillId;

		public string PassiveSkillIds;

		public Elemental Elemental;

		public int BehaviourId;

		public float Scale;

		public float HpBarScale;

		public int DamageTextFontSize;

		public bool HasBossBar;

		public Vector2 ColliderOffset;

		public Vector2 ColliderSize;

		public Vector2 HpBarOffset;

		public Vector2 FloatingTextOffset;

		public string SpawnVfxName;

		public float SpawnVfxDuration;

		public float KnockbackResistance;

		public float KnockbackResistanceCooldown;

		public float StunResistance;

		public float StunResistanceCooldown;

		public float FireDamageResistance;

		public float IceDamageResistance;

		public float ElectricDamageResistance;

		public float PlantDamageResistance;

		public float GoldDropWeight;

		public List<DefaultSoundConfig.SoundData> DeathSfxs;

		public string MonsterPrefabPreview;

		public int GetMaxHp(int level, float spawnHpScale = 1f)
		{
			return 0;
		}

		public GameObject CreateInstance(GameObject modelPrefab, int level, Unit target, float spawnAtkScale = 1f, float spawnHpScale = 1f)
		{
			return null;
		}

		private void ApplyMonsterBuff(Unit unit)
		{
		}
	}
}
