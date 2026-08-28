namespace Game.Combat
{
	public class SimpleTimer
	{
		private float _cooldown;

		private float _time;

		public bool IsFinished => false;

		public float RemainTime
		{
			get
			{
				return 0f;
			}
			set
			{
			}
		}

		public float Progress01 => 0f;

		public SimpleTimer(float cooldown)
		{
		}

		public void Update(float dt)
		{
		}
	}
}
