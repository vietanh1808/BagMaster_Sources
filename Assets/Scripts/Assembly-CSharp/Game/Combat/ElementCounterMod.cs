namespace Game.Combat
{
	public class ElementCounterMod
	{
		private float[][] _modTable;

		public ElementCounterMod(float[][] floats)
		{
		}

		public float GetMod(Elemental attacker, Elemental defender)
		{
			return 0f;
		}

		public float[] GetMod(Elemental elemental)
		{
			return null;
		}
	}
}
