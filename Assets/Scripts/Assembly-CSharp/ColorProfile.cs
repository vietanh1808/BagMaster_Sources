using UnityEngine;

[CreateAssetMenu(fileName = "ColorProfile", menuName = "Game/ColorProfile", order = 0)]
public class ColorProfile : ScriptableObject
{
	[SerializeField]
	private Color[] _colors;

	public Color GetColor(int index)
	{
		return default;
	}
}
