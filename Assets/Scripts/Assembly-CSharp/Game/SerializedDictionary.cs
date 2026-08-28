using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	[Serializable]
	public class SerializedDictionary<TKey, TValue> : IDictionary<TKey, TValue>, ICollection<KeyValuePair<TKey, TValue>>, IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable, IReadOnlyDictionary<TKey, TValue>, IReadOnlyCollection<KeyValuePair<TKey, TValue>>, ISerializationCallbackReceiver
	{
		[Serializable]
		private struct Pair
		{
			public TKey Key;

			public TValue Value;
		}

		[SerializeField]
		private List<Pair> _serialized;

		private readonly Dictionary<TKey, TValue> _dictionary;

		private bool _isReady;

		public int Count => 0;

		public bool IsReadOnly => false;

		public TValue this[TKey key]
		{
			get
			{
				return default;
			}
			set
			{
			}
		}

		public IEnumerable<TKey> Keys => null;

		ICollection<TValue> IDictionary<TKey, TValue>.Values => null;

		ICollection<TKey> IDictionary<TKey, TValue>.Keys => null;

		public IEnumerable<TValue> Values => null;

		public void TryInit()
		{
		}

		public IEnumerator<KeyValuePair<TKey, TValue>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.Add(KeyValuePair<TKey, TValue> item)
		{
		}

		public void Clear()
		{
		}

		bool ICollection<KeyValuePair<TKey, TValue>>.Contains(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		void ICollection<KeyValuePair<TKey, TValue>>.CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex)
		{
		}

		public bool Remove(KeyValuePair<TKey, TValue> item)
		{
			return false;
		}

		public void Add(TKey key, TValue value)
		{
		}

		public bool ContainsKey(TKey key)
		{
			return false;
		}

		public bool Remove(TKey key)
		{
			return false;
		}

		public bool TryGetValue(TKey key, out TValue value)
		{
			value = default;
			return false;
		}

		public void OnBeforeSerialize()
		{
		}

		public void OnAfterDeserialize()
		{
		}
	}
}
