using System.Collections.Generic;

namespace Game.Combat.SkillSystem
{
	public class EffectParams
	{
		private List<string> _data;

		public EffectParams(List<string> data)
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

		public bool GetBool(int index, bool defaultValueIfEmpty = false)
		{
			return false;
		}
	}
}
