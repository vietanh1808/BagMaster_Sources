using System.Collections.Generic;
using UnityEngine;

namespace Game.GUI
{
	public class CurrencyObtainInfo : MonoBehaviour
	{
		[SerializeField]
		private ResourceView _resourceView;

		[SerializeField]
		private List<GotoFunctionView> _gotoItems;

		[SerializeField]
		private FeatureNavigationConfig _config;

		public void UpdateInfo(ResourceEntityHasVisual resource, List<DTO_GoToFunctionData> sources)
		{
		}

		public static void Show(ResourceEntityHasVisual resource, List<DTO_GoToFunctionData> sources)
		{
		}
	}
}
