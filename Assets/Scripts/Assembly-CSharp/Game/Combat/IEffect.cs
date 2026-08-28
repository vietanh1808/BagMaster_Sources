namespace Game.Combat
{
	public interface IEffect
	{
		float Intensity { get; set; }

		void Execute(IEffectTarget target);
	}
}
