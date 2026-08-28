namespace Game.Combat
{
	public class EUpgrade : IEffect
	{
		private EUpgradeParams _params;

		public float Intensity { get; set; }

		public EUpgrade(EUpgradeParams param)
		{
		}

		public void Execute(IEffectTarget target)
		{
		}
	}
}
