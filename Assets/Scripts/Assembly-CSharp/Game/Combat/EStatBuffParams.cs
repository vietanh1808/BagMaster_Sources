namespace Game.Combat
{
	public struct EStatBuffParams
	{
		public object Source;

		public StatName StatName;

		public ModificationType ModificationType;

		public float Value;

		public float Duration;

		public bool Permanent;

		public bool AllowStackSameSource;

		public StatusType OverrideStatusType;

		public StatusType GetStatusType()
		{
			return StatusType.None;
		}
	}
}
