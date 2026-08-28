using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class SkillData
	{
		public int Id;

		public string Description;

		public string Icon;

		public bool ManualCast;

		public float InitialDelay;

		public float Cooldown;

		public float MinCooldown;

		public int TimeGroupId;

		public Vector2 TimeBetweenInGroup;

		public int UseLimit;

		public int UseLimitPerWave;

		public string TargetType;

		public float DetectTargetRangeBonus;

		public float Range;

		public float ProjectileAppearChance;

		public string ProjectileBehaviour;

		public string ProjectileSpriteName;

		public ProjectilePositionAnchor ProjectileStartPositionType;

		public Vector2 ProjectileStartPositionOffset;

		public ProjectileAngleAnchor ProjectileStartRotationType;

		public float ProjectileStartRotationOffset;

		public int Pierce;

		public int Bounce;

		public int Follow;

		public int ConsecutiveProjectileNumber;

		public float ConsecutiveInterval;

		public SpreadType SpreadType;

		public int SpreadProjectileNumber;

		public float SpreadArcBetween;

		public float SpreadArcBetweenRandomFactor;

		public Vector2 SpreadEndPositionBetween;

		public float SpreadProjectileInterval;

		public float ProjectileSpeedScale;

		public float ProjectileRotationSpeed;

		public float ProjectileDuration;

		public float MeleeSlashRadiusUp;

		public float MeleeSlashRadiusDown;

		public ValueParams PassiveOptions;

		public string ComponentData;

		public List<EffectData> EffectDatas;

		public float ProjectileScale;

		public float CastingTime;

		public int ScreenShakeOnHit;

		public AudioClip ActivateSfx;

		public string HitSfxs;

		public bool KeepEffectNextWave;

		public string ProjectileColliderType;

		public Vector2 ProjectileColliderOffset;

		public Vector2 ProjectileColliderSize;

		public List<Vector2Int> NearbyPositions;

		public string SynercyText;

		public VfxPosition ProjectileImpactVfxPositionType;

		public Vector2 ProjectileImpactVfxPositionOffset;

		public string ActivateVfx;

		public string ActivateVfxPlayer2;

		public VfxPosition ActivateVfxPositionType;

		public Vector2 ActivateVfxPositionOffset;

		public float ActivateVfxDelayAppear;

		public string ProjectileAppearVfx;

		public VfxPosition ProjectileAppearVfxPositionType;

		public Vector2 ProjectileAppearVfxPositionOffset;

		public string TrailVfx;

		public string HitVfx;

		public string HitAttachVfx;

		public float DpsMod;

		public float AttackMod;

		public bool StopSoundOnEndProjectile;

		public float FloatingTextScale;

		public string FloatGearAnimation;

		public float FloatGearAnimationSpeedScale;

		public float FloatGearAnimationDuration;

		public float ProjectileMaxRange;

		public bool StopOnTarget;

		public float StopTime;

		public int[] ProjectileSkills;

		public bool IgnoreHitWall;

		public string DisplaySkillName;

		public string DisplaySkillDescription;

		public bool FreezeTimeOnCast;

		public string ProjectileAppearSfx;

		public bool MonsterBounce;

		public bool WallBounce;

		public int MaxActiveProjectileNumber;

		public float ProjectileFlyRadius;

		public int FloatingTextChannel;

		private static Dictionary<int, float> _activeTimes;

		public string LocalizedDescription => null;

		public string LocalizedSynercyText => null;

		public string LocalizedDisplaySkillName => null;

		public string LocalizedDisplaySkillDescription => null;

		public static void ClearActiveTimes()
		{
		}

		public void InitTime()
		{
		}

		public float GetNextTimeCanActive()
		{
			return 0f;
		}

		public void SetNextTimeCanActive()
		{
		}

		public SimpleSkill CreateSkill(SkillCreationParams param, Action<SimpleSkill> beforePassiveOptionFunc = null)
		{
			return null;
		}

		public void InitializePassiveOptions(SimpleSkill skill)
		{
		}

		public bool IsMelee()
		{
			return false;
		}

		public bool IsStatEffect()
		{
			return false;
		}

		public float GetEffectsDuration()
		{
			return 0f;
		}
	}
}
