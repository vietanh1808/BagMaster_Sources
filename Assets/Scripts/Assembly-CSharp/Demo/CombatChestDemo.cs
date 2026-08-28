using Game.Combat;
using UnityEngine;

namespace Demo
{
	[DefaultExecutionOrder(-1)]
	public class CombatChestDemo : MonoBehaviour
	{
		public string GearId;

		public string GearLevel;

		private Unit Player;

		private void Awake()
		{
		}

		private void OnGUI()
		{
		}

		public int GetNumberItems()
		{
			return 0;
		}
	}
}
