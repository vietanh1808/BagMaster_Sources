using System.Collections.Generic;
using Game.Combat;
using UnityEngine;

namespace Game.Testing
{
	public static class ToolGlobal
	{
		public static string ScenarioName;

		public static List<ScenarioData> ScenarioDatas;

		public static int CurrentScenarioIndex;

		public static int CurrentProfileIndex;

		public static int LoopCounter;

		public static AutoPlayBot Bot;

		public static TestProfileData Profiles;

		public static OwnedResourceEntity CustomProgress;

		public static bool ReturnMenu;

		public static TestProfileData OverrideProfileData;

		public static string GetReportPath()
		{
			return null;
		}

		public static bool IsFinalLoop()
		{
			return false;
		}

		public static bool IsFinalProfileIndex()
		{
			return false;
		}

		public static void Next()
		{
		}

		private static void NewTestProfiles()
		{
		}

		private static void NewScenarioSetup()
		{
		}

		private static void HandleScene()
		{
		}

		public static void Play()
		{
		}

		public static CombatSaveData GetSaveData()
		{
			return null;
		}

		private static void SetStat(float value, StatName statName)
		{
		}

		public static void AutoTest()
		{
		}

		public static GameObject CreateRecorder()
		{
			return null;
		}

		public static void SetAutoTestSave(bool on)
		{
		}
	}
}
