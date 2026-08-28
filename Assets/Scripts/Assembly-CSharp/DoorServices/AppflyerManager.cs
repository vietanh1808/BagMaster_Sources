using System.Collections.Generic;

namespace DoorServices
{
	internal class AppflyerManager
	{
		internal static bool Initialized => false;

		internal static void SendEvent(string eventName, Dictionary<string, string> values)
		{
		}

		internal static void SendEvent(string eventName)
		{
		}
	}
}
