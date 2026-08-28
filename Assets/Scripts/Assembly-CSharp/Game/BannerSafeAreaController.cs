using UnityEngine;

namespace Game
{
	public static class BannerSafeAreaController
	{
		private const float SimulatedBannerHeight = 180f;

		[RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
		private static void Initialize()
		{
		}

		private static void HandleBannerShown()
		{
		}

		private static void HandleBannerHidden()
		{
		}

		private static float GetBannerHeight()
		{
			return 0f;
		}
	}
}
