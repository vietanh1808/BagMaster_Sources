namespace Game.Combat
{
	public struct EStatConvertParam
	{
		public object Source;

		public StatName FromStat;

		public StatName ToStat;

		public bool BaseStatOnly;

		public float ConvertRate;

		public bool UseRate;

		public ModificationType ModificationType;
	}
}
