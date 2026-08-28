using System.Collections.Generic;
using UnityEngine;

namespace Game.Combat
{
	[CreateAssetMenu(menuName = "Game/GameObjectCollection")]
	public class GameObjectCollection : ScriptableObject
	{
		[SerializeField]
		private List<GameObject> collection;

		public List<GameObject> Collection => null;
	}
}
