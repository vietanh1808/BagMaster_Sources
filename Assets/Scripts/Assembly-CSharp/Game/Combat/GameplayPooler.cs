using System;
using System.Collections.Generic;
using Game.AssetManager;
using Game.Tools;
using UnityEngine;

namespace Game.Combat
{
	[DefaultExecutionOrder(-10)]
	public class GameplayPooler : MonoBehaviour
	{
		[Serializable]
		public class PoolData
		{
			public string PrefabPath;

			public int Initial;

			public int Max;
		}

		[Serializable]
		public class Handler
		{
			public bool Original;

			public int RefCount;

			public SimpleObjectPoolAuto Pooler;

			public PrefabAddressable Prefab;

			public bool Ready;
		}

		[SerializeField]
		private PoolData[] _datas;

		private Dictionary<string, Handler> _pools;

		public static GameplayPooler Instance { get; private set; }

		public static bool HasInstance { get; private set; }

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public bool Has(string prefabPath)
		{
			return false;
		}

		public bool IsReady(string prefabPath)
		{
			return false;
		}

		public GameObject Get(string prefabPath, float scale = 1f)
		{
			return null;
		}

		public GameObject Get(string prefabPath, out GameObject prefab, float scale = 1f)
		{
			prefab = null;
			return null;
		}

		public void Register(string prefabPath, int initial, int max)
		{
		}

		public void Unregister(string prefabPath)
		{
		}

		private void CreateHandler(string prefabPath, bool original, int initial, int max)
		{
		}

		public void ClearZeroCount()
		{
		}
	}
}
