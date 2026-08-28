using System;

namespace Game
{
	public class GenericStringKeySaveListService
	{
		private readonly GenericStringKeySaveList _save;

		public GenericStringKeySaveListService(GenericStringKeySaveList save)
		{
		}

		public int GetIntValue(string key, int defaultValue = 0)
		{
			return 0;
		}

		public void SetIntValue(string key, int value)
		{
		}

		public void AddIntValue(string key, int valueToAdd)
		{
		}

		public DateTime GetDateTimeValue(string key, DateTime defaultValue)
		{
			return default;
		}

		public DateTime SetDateTimeValue(string key, DateTime value)
		{
			return default;
		}

		public bool Remove(string key)
		{
			return false;
		}

		private bool TryGetKeySave(string key, out GenericStringKeySave save)
		{
			save = null;
			return false;
		}
	}
}
