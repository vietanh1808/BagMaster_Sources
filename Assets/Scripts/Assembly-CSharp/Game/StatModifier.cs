namespace Game
{
	public struct StatModifier
	{
		public readonly float Value;

		public readonly ModificationType Type;

		public readonly int Order;

		public readonly object Source;

		public bool CanTransfered;

		public StatModifier(float value, ModificationType type, int order, object source, bool canTransfered)
		{
			Value = 0f;
			Type = ModificationType.Flat;
			Order = 0;
			Source = null;
			CanTransfered = false;
		}

		public StatModifier(float value, ModificationType type, object source, bool canTransfered = false)
		{
			Value = 0f;
			Type = ModificationType.Flat;
			Order = 0;
			Source = null;
			CanTransfered = false;
		}

		public bool FromSource(object source)
		{
			return false;
		}
	}
}
