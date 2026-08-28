using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Pool;

namespace Game
{
	public class Pool<T> where T : Component
	{
		public readonly T Prefab;

		public readonly Transform Container;

		private List<T> _entities;

		private IObjectPool<T> _pool;

		public List<T> Entities => null;

		public Pool(T prefab, Transform container, int defaultCapacity = 10, int maxSize = 20)
		{
		}

		public T GetNew()
		{
			return null;
		}

		public T Find(Predicate<T> match)
		{
			return null;
		}

		public bool Remove(T entity)
		{
			return false;
		}

		public bool Remove(Predicate<T> match)
		{
			return false;
		}

		public void RemoveAll()
		{
		}

		public void Sort(Comparison<T> comparison)
		{
		}

		public void Sort(IComparer<T> comparer)
		{
		}

		public void Dispose()
		{
		}

		private T CreateFunc()
		{
			return null;
		}

		private void GetFunc(T obj)
		{
		}

		private void ReleaseFunc(T obj)
		{
		}

		private void DestroyFun(T obj)
		{
		}
	}
}
