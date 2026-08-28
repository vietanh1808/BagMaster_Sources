using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	[CreateAssetMenu(menuName = "Game/ListUnits")]
	public class ListUnits : ScriptableObject
	{
		private static ListUnits _playerListUnits;

		private static ListUnits _monsterListUnits;

		public List<Unit> Units;

		public Action<Unit> OnAdd;

		public Action<Unit> OnRemove;

		public void AddUnit(Unit unit)
		{
		}

		public void RemoveUnit(Unit unit)
		{
		}

		public void KillAll()
		{
		}

		public static ListUnits GetByTeam(Team team)
		{
			return null;
		}
	}
}
