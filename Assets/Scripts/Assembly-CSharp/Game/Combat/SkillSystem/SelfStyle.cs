using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class SelfStyle : ProjectileBehaviour
	{
		[SerializeField]
		[Range(0f, 2f)]
		private float _duration;

		[SerializeField]
		private Vector3 _aimOffset;

		[SerializeField]
		[Range(0f, 5f)]
		private float _minHeight;

		[SerializeField]
		[Range(0f, 5f)]
		private float _maxHeight;

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		private void JumpTo(Vector3 position, IEffectTarget target)
		{
		}

		private void Hit(IEffectTarget target)
		{
		}
	}
}
