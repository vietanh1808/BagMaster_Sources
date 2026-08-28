using System.Collections.Generic;
using _Game.Events.Utils;

namespace Game
{
	public class EventPayloadStorageProvider : IStorageProvider
	{
		private static Dictionary<string, string> Store => null;

		public bool HasKey(string key)
		{
			return false;
		}

		public string GetString(string key, string defaultValue = "")
		{
			return null;
		}

		public void SetString(string key, string value)
		{
		}

		public void Delete(string key)
		{
		}
	}
}
