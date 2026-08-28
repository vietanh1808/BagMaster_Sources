namespace Game.Newbie
{
	public static class NewbieTabMethod
	{
		public static int GetTabIndex(this NewbieTabType tab)
		{
			return 0;
		}

		public static NewbieTabType ToTabIndex(this int index)
		{
			return NewbieTabType.Tab1;
		}
	}
}
