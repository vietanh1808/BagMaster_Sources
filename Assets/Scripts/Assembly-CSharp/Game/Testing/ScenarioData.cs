using System;

namespace Game.Testing
{
	[Serializable]
	public class ScenarioData
	{
		public string ProfilePath;

		public float Atk;

		public float Hp;

		public int Loop;

		public string DataPath;

		public TestProfileData OverrideProfile;
	}
}
