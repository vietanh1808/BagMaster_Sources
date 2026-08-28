namespace Game.Combat
{
	public class AlwaysCondition : ISkilLCondition
	{
		private bool _return;

		public AlwaysCondition(bool value)
		{
		}

		public bool IsReady()
		{
			return false;
		}
	}
}
