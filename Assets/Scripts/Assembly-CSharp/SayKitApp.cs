using UnityEngine;

public class SayKitApp
{
	public const bool notificationsEnabled = true;

	public const string APP_NAME_CHINA_IOS = "<APP_NAME_CHINA_IOS or empty>";

	public const string APP_NAME_IOS = "BagMaster Isekai (iOS)";

	public const string APP_BUNDLE_CHINA_IOS = "<APP_BUNDLE_CHINA_IOS or empty>";

	public const string APP_BUNDLE_IOS = "com.DoorTeam.BagMaster";

	public static bool purchasesEnabled;

	public const string APP_KEY_IOS = "bgmstri";

	public const string APP_SECRET_IOS = "3NLQPdV3z3FT5mep1YA1K5abCHsUwgBQ";

	public const string APP_KEY_ANDROID = "bgmstra";

	public const string APP_SECRET_ANDROID = "cJBsHTJPARJ7tMoovY19adgW3RRQmvSo";

	public const string PROMO_KEY_IOS = "";

	public const string AD_INTERSTITIAL = "ad_interstitial";

	public const string AD_REWARDED = "ad_rewarded";

	[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.BeforeSceneLoad)]
	private static void init()
	{
	}
}
