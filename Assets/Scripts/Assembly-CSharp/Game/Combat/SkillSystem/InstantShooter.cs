using System.Collections.Generic;

namespace Game.Combat.SkillSystem
{
	public class InstantShooter : IShooter
	{
		public ShooterOptions Options { get; set; }

		public void Fire(IReadOnlyCollection<IEffectTarget> targets)
		{
		}

		public void Cancel()
		{
		}
	}
}
