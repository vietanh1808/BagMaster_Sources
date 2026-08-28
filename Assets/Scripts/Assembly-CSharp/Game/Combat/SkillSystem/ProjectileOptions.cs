using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class ProjectileOptions
	{
		public ShooterOptions ShooterOptions;

		public float AoeMultiplierBonus;

		public Vector2 TargetPositionOffset;

		public IEffectTarget Target;

		public Vector3 TargetPosition;

		public LayerMask TargetLayerMask;
	}
}
