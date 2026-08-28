using System.Collections.Generic;

public class UISystemLoader
{
	public enum UIType
	{
		None = 0,
		Sheet = 1,
		Page = 2,
		Modal = 3
	}

	public enum ScreenLocation
	{
		None = 0,
		Home = 1,
		Gameplay = 2
	}

	private static Dictionary<string, UIInfo> _uiTables;

	public static bool IsInitialized { get; private set; }

	public static void Initialize()
	{
	}

	public static void ReloadConfig(UISystemConfig config)
	{
	}

	public static List<string> GetPaths(UIType type, ScreenLocation location = ScreenLocation.None)
	{
		return null;
	}

	public static bool TryGetPath(string name, out string loadPath, out UIType type)
	{
		loadPath = null;
		type = default;
		return false;
	}
}
