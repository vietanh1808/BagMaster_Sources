using System;
using System.Collections.Generic;
using UnityEngine;

[Obsolete]
[CreateAssetMenu(fileName = "GearRarityConfig", menuName = "Game/GearRarityConfig")]
public class GearRarityConfig : ScriptableObject
{
	public List<GearRarityInfo> GearInfos;
}
