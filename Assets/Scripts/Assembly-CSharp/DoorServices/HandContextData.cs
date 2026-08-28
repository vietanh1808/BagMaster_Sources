using System;

namespace DoorServices
{
	[Serializable]
	public class HandContextData
	{
		public int usage;

		public int remaining;

		public string item;

		public static HandContextData BuildCurrent(bool isWholeLevel = false)
		{
			return null;
		}
	}
}
