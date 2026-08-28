namespace Game.Combat.SkillSystem
{
	public class ValueParams
	{
		private string[] _data;

		public int Count => 0;

		public ValueParams(string[] data)
		{
		}

		public float GetFloat(int index)
		{
			return 0f;
		}

		public int GetInt(int index)
		{
			return 0;
		}

		public string GetString(int index)
		{
			return null;
		}

		public float GetFloat(int index, float defaultValueIfEmpty)
		{
			return 0f;
		}

		public int GetInt(int index, int defaultValueIfEmpty)
		{
			return 0;
		}

		public string GetString(int index, string defaultValueIfEmpty)
		{
			return null;
		}

		public string[] GetTags(int index)
		{
			return null;
		}

		public T GetEnum<T>(int index, T defaultIfEmtpy = default(T))
		{
			return default;
		}

		public bool GetBool(int index, bool defaultValueIfEmpty = false)
		{
			return false;
		}
	}
}
