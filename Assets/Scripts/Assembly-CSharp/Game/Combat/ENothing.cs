namespace Game.Combat
{
	public class ENothing : IEffect
	{
		public float Intensity { get; set; }

		public void Execute(IEffectTarget target)
		{
		}
	}
}
