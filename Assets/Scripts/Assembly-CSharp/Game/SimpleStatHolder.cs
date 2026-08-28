using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	public class SimpleStatHolder : MonoBehaviour, IStatHolder
	{
		[Serializable]
		private class StatDefault
		{
			public StatName StatName;

			public float Value;
		}

		[SerializeField]
		private List<StatDefault> _initList;

		private Dictionary<StatName, Stat> _stats;

		public Stat Get(StatName statName)
		{
			return null;
		}

		public void Set(StatName statName, Stat stat)
		{
		}

		public void TestLogStats()
		{
		}
	}
}
