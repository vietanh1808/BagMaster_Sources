using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;
using UnityEngine.SceneManagement;

namespace _KIT
{
	public class KitPool : MonoBehaviour
	{
		private class Pool : IDisposable
		{
			private GameObject instance;

			private readonly IObjectPool<GameObject> pool;

			private readonly HashSet<GameObject> inactives;

			public Pool(GameObject instance, int numberOfPreload)
			{
			}

			public void Release(GameObject target)
			{
			}

			public GameObject Reuse()
			{
				return null;
			}

			private void OnDestroy(GameObject go)
			{
			}

			private void OnRelease(GameObject go)
			{
			}

			private void OnReuse(GameObject go)
			{
			}

			private GameObject OnCreate()
			{
				return null;
			}

			public void Dispose()
			{
			}
		}

		private static string _lastLevelPath;

		public bool releaseOnLoadScene;

		private static KitPool instance;

		private static readonly Dictionary<string, Pool> unityPool;

		public static KitPool Instance => null;

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		public static void RegisterPool(GameObject ins, int numberOfPreload)
		{
		}

		public static void UnRegisterPool(GameObject ins)
		{
		}

		public new static T Instantiate<T>(T ins) where T : Component
		{
			return null;
		}

		public new static T Instantiate<T>(T ins, Transform parent) where T : Component
		{
			return null;
		}

		public static T Instantiate<T>(T ins, bool active) where T : Component
		{
			return null;
		}

		public static GameObject Instantiate(GameObject ins, bool active)
		{
			return null;
		}

		public static GameObject Instantiate(GameObject ins)
		{
			return null;
		}

		public static T Instantiate<T>(GameObject ins) where T : Component
		{
			return null;
		}

		public static void Destroy(GameObject ins)
		{
		}
	}
}
