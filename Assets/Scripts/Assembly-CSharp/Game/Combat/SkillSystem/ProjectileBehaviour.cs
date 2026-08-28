using UnityEngine;

namespace Game.Combat.SkillSystem
{
	public class ProjectileBehaviour : MonoBehaviour
	{
		protected ProjectileOptions _options;

		protected ProjectileEvents _events;

		public virtual void UpdateData(ProjectileOptions options, ProjectileEvents events)
		{
		}

		public virtual void End()
		{
		}
	}
}
