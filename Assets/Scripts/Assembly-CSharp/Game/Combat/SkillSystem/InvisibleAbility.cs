using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class InvisibleAbility : MonoBehaviour
	{
		public float FadeDuration;

		public float VisibleAlpha;

		public float InvisibleAlpha;

		private float _invisibleTime;

		private float _duration;

		private float _colorTime;

		private Unit _unit;

		public bool Invisible => false;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public void SetInvisible(float duration)
		{
		}

		private void UpdateLogic()
		{
		}

		private void UpdateModelColor()
		{
		}
	}
}
