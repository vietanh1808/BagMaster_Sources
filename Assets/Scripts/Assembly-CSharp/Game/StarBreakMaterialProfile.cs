using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	[CreateAssetMenu(fileName = "StarBreakMaterialProfile", menuName = "Game/StarBreakMaterialProfile")]
	public class StarBreakMaterialProfile : ScriptableObject
	{
		[Serializable]
		public class StarBreakProfile
		{
			[SerializeField]
			public Material StarBreakTextMaterial;

			[SerializeField]
			public Material StarBreakBackgroundMaterial;
		}

		[Serializable]
		public class StarBreakColorData
		{
			[SerializeField]
			public int Index;

			[SerializeField]
			public List<StarBreakProfile> ProfileDatas;
		}

		[SerializeField]
		private List<StarBreakColorData> _starBreakColorDatas;

		public StarBreakProfile GetProfileAtIndex(int Index, int SizeIndex)
		{
			return null;
		}
	}
}
