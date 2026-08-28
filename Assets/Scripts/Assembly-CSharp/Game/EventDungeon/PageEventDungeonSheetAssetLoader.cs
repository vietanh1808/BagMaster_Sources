using System.Collections.Generic;
using UnityEngine;
using UnityScreenNavigator.Runtime.Foundation.AssetLoader;

namespace Game.EventDungeon
{
	public class PageEventDungeonSheetAssetLoader : IAssetLoader
	{
		private Dictionary<string, object> cache;

		private int _nextControlId;

		public AssetLoadHandle<T> Load<T>(string key) where T : Object
		{
			return null;
		}

		public AssetLoadHandle<T> LoadAsync<T>(string key) where T : Object
		{
			return null;
		}

		public void Release(AssetLoadHandle handle)
		{
		}

		public void Preload<T>(IEnumerable<string> keys) where T : Object
		{
		}
	}
}
