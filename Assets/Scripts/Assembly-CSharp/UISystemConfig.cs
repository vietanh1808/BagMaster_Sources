using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "UISystemConfig", menuName = "Game/UISystemConfig")]
public class UISystemConfig : ScriptableObject
{
	public List<UIInfo> UIInfos;
}
