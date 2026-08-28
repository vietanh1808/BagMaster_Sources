using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "TextVisualData", menuName = "Game/FoatingTextVisualData", order = 0)]
public class TextVisualData : ScriptableObject
{
	[field: SerializeField]
	public Color Color { get; private set; }

	[field: SerializeField]
	public int FontSize { get; private set; }

	[field: SerializeField]
	public FontStyles FontStyles { get; private set; }

	[field: SerializeField]
	public float DurationScale { get; private set; }
}
