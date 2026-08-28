namespace Game.Combat
{
	public class GearSimulation : IEffectGear, IStatOwner
	{
		public IStatHolder StatHolder { get; private set; }

		public GearSimulation(GearData gearData)
		{
		}
	}
}
