using System.Collections.Generic;

namespace Game.Combat.SkillSystem
{
	public interface IShooter
	{
		ShooterOptions Options { get; set; }

		void Fire(IReadOnlyCollection<IEffectTarget> targets);

		void Cancel();
	}
}
