using Game.Tools;
using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class ProjectileRotator : ProjectileBehaviour, IUpdater
	{
		[SerializeField]
		private float _rotateSpeed;

		[SerializeField]
		private Transform _rotateObject;

		[SerializeField]
		private bool _resetInitialAngle;

		private Vector3 _initialRotate;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public override void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		void IUpdater.CustomUpdate(float dt)
		{
		}
	}
}
