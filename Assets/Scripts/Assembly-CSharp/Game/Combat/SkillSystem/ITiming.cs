namespace Game.Combat.SkillSystem
{
	public interface ITiming
	{
		float ProgressSecond { get; }

		float Progress01 { get; }

		bool LimitReached { get; }

		float Cooldown { get; }

		float CooldownScale { get; set; }

		int UseLimit { get; set; }

		void Update();

		void ResetCooldown();

		void Reset();
	}
}
