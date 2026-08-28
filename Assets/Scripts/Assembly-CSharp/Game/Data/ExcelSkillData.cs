using System;

namespace Game.Data
{
	[Serializable]
	public struct ExcelSkillData
	{
		public int ID;

		public string Description;

		public string Active_Skill_Icon;

		public bool ManualCast;

		public float InitialDelay;

		public string CD;

		public string MinCD;

		public int Time_Group_ID;

		public string Time_Between_In_Group;

		public string Use_Limit;

		public string Use_Limit_Per_Wave;

		public string Target_type;

		public float DetectTargetRangeBonus;

		public string Range;

		public string ProjectileAppearChance;

		public string Projectile_Behaviour;

		public string ProjectileSprite;

		public string ProjectileStartPositionType;

		public string ProjectileStartPositionOffset;

		public string ProjectileStartRotationType;

		public float ProjectileStartRotationOffset;

		public int Pierce;

		public int Bounce;

		public int Follow;

		public string ConsecutiveProjectileNumber;

		public string ConsecutiveInterval;

		public string SpreadType;

		public string SpreadProjectileNumber;

		public float SpreadArcBetween;

		public float SpreadArcBetweenRandomFactor;

		public string SpreadEndPositionBetween;

		public float SpreadProjectileInterval;

		public string ProjectileSpeedScale;

		public string PassiveOptions;

		public float ProjectileOverrideSize;

		public float ProjectileRotationSpeed;

		public string ProjectileDuration;

		public string MeleeSlashRadiusUp;

		public string MeleeSlashRadiusDown;

		public float CastingTime;

		public string EffectDatas;

		public string ScreenShakeOnHit;

		public string ActivateSfx;

		public string HitSfx;

		public string ActivateVfx;

		public string ActivateVfxPlayer2;

		public string ActivateVfxPositionType;

		public string ActivateVfxPositionOffset;

		public float ActivateVfxDelayAppear;

		public string ProjectileAppearVfx;

		public string ProjectileAppearVfxPositionType;

		public string ProjectileAppearVfxPositionOffset;

		public string TrailVfx;

		public string HitVfx;

		public string HitAttachVfx;

		public bool KeepEffectNextWave;

		public string ProjectileColliderType;

		public string ProjectileColliderOffset;

		public string ProjectileColliderSize;

		public string NearbyPositions;

		public string SynercyText;

		public string ProjectileImpactVfxPositionType;

		public string ProjectileImpactVfxPositionOffset;

		public string DpsMod;

		public string AttackMod;

		public bool StopSoundOnEndProjectile;

		public string FloatingTextScale;

		public string FloatGearAnimation;

		public string FloatGearAnimationSpeedScale;

		public float FloatGearAnimationDuration;

		public float Projectile_Max_Range;

		public bool Stop_On_Target;

		public float Stop_Time;

		public string ProjectileSkills;

		public bool IgnoreHitWall;

		public string DisplaySkillName;

		public string DisplaySkillDescription;

		public bool FreezeTimeOnCast;

		public string ProjectileAppearSfx;

		public bool MonsterBounce;

		public bool WallBounce;

		public int MaxActiveProjectile;

		public float ProjectileFlyRadius;

		public int FloatingTextChannel;
	}
}
