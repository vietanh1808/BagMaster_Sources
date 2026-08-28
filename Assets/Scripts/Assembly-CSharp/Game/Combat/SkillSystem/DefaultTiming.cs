namespace Game.Combat.SkillSystem
{
	public class DefaultTiming : ITiming
	{
		private float _time;

		private int _useCount;

		private float _baseCooldown;

		public float ProgressSecond => 0f;

		public float Progress01 => 0f;

		public bool LimitReached => false;

		public float Cooldown => 0f;

		public float CooldownScale { get; set; }

		public int UseLimit { get; set; }

		public DefaultTiming(float cooldown, int useLimit)
		{
		}

		public virtual void ResetCooldown()
		{
		}

		public virtual void Reset()
		{
		}

		public virtual void Update()
		{
		}
	}
}
