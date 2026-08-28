using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu(fileName = "RarityConfig", menuName = "Game/RarityConfig")]
	public class RarityConfig : ScriptableObject
	{
		public List<RarityInfo> Infos;
	}
}
