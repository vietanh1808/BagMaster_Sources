using System;
using Game.AssetManager;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class ShooterOptions
	{
		public IEffectCaster Caster;

		public IEffectGear Gear;

		public SimpleSkill Skill;

		private Transform _muzzle;

		public Sprite OverrideProjectileSprite;

		public Func<float> RangeGetter;

		public PrefabAddressable HitVFXPrefab;

		public PrefabAddressable HitAttachVFXPrefab;

		public PrefabAddressable TrailVFXPrefab;

		public PrefabAddressable AppearVFXPrefab;

		public Vector3 LastTargetPosition;

		public Transform Muzzle
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float GetStatValue(StatName statName)
		{
			return 0f;
		}

		public float GetCalculatedDuration()
		{
			return 0f;
		}

		public float CheckIncomingDamage()
		{
			return 0f;
		}

		public Sprite GetProjectileSprite()
		{
			return null;
		}
	}
}
