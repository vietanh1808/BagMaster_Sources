using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat.SkillSystem
{
	public class BombStyle : ProjectileBehaviour
	{
		[SerializeField]
		protected float _speed;

		[SerializeField]
		private float _minDuration;

		[SerializeField]
		private float _peakHeightMin;

		[SerializeField]
		private float _peakHeightMax;

		[SerializeField]
		protected AnimationCurve _tweenCurve;

		[SerializeField]
		private Vector2 _randomX;

		[Header("Event")]
		public UnityEvent OnImpact;

		private int _bounceCount;

		private Team _targetTeam;

		private Unit _lastestUnitTarget;

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		private void Do(IEffectTarget target)
		{
		}

		protected virtual void Throw(Vector3 end)
		{
		}

		public static Vector3 Parabola(Vector3 start, Vector3 end, float height, float t)
		{
			return default;
		}

		public void Impact()
		{
		}

		private void Hit(IEffectTarget target)
		{
		}

		private void BounceRandomTarget()
		{
		}

		private void OnDrawGizmosSelected()
		{
		}
	}
}
