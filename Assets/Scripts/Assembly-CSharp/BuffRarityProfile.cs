using UnityEngine;

[CreateAssetMenu(fileName = "BuffRarityProfile", menuName = "Game/SimpleListString")]
public class BuffRarityProfile : ScriptableObject
{
	[SerializeField]
	public string[] _keys;
}
