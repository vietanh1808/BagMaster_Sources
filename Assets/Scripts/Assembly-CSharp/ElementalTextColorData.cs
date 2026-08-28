using Game.Combat;
using UnityEngine;

[CreateAssetMenu(fileName = "ElementalTextColorData", menuName = "Game/ElementalTextColorData", order = 0)]
public class ElementalTextColorData : ScriptableObject
{
	[SerializeField]
	private Color _physicalColor;

	[SerializeField]
	private Color _fireColor;

	[SerializeField]
	private Color _plantColor;

	[SerializeField]
	private Color _electricColor;

	[SerializeField]
	private Color _iceColor;

	public Color GetColor(Elemental elemental)
	{
		return default;
	}
}
