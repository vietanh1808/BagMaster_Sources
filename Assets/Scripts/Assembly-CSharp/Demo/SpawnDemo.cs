using Game.Combat;
using UnityEngine;

namespace Demo
{
	[DefaultExecutionOrder(-1)]
	public class SpawnDemo : Spawner
	{
		[SerializeField]
		private int _spawnId;

		[SerializeField]
		private ListUnits _monsterList;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		public void KillRandomly()
		{
		}
	}
}
