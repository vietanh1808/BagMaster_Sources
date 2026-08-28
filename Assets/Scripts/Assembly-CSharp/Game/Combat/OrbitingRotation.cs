using UnityEngine;

namespace Game.Combat
{
	public class OrbitingRotation : MonoBehaviour
	{
		[SerializeField]
		private float _angularSpeed;

		public float TargetAngle;

		public bool Locked;

		private Gear _gear;

		private bool IsMelee => false;

		private void OnDestroy()
		{
		}

		public void SetAimTarget(Gear gear)
		{
		}

		private void Update()
		{
		}

		private void QuickRotateTowardTarget(SkillCastData data)
		{
		}
	}
}
