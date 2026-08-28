using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu(fileName = "FeatureNavigationConfig", menuName = "Game/Feature Navigation Config")]
	public class FeatureNavigationConfig : ScriptableObject
	{
		[Serializable]
		public class FeatureNavigationData
		{
			public FeatureNavigationType Type;

			public string LocalizeKey;

			public Sprite Icon;
		}

		[SerializeField]
		private List<FeatureNavigationData> _items;

		public FeatureNavigationData GetData(FeatureNavigationType type)
		{
			return null;
		}
	}
}
