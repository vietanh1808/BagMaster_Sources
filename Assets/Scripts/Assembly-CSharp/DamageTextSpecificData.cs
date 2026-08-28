using TMPro;
using UnityEngine;

[CreateAssetMenu(fileName = "DamageTextSpecificData", menuName = "Game/DamageTextSpecificData", order = 0)]
public class DamageTextSpecificData : ScriptableObject
{
	[Header("Critical")]
	[field: SerializeField]
	public float CriticalFontsizeScale { get; private set; }

	[field: SerializeField]
	public FontStyles CriticalFontStyles { get; private set; }

	[Header("Effective")]
	[field: SerializeField]
	public float EffectiveFontSizeScale { get; private set; }

	[field: SerializeField]
	public FontStyles EffectiveFontStyles { get; private set; }

	[Header("Effective And Critical")]
	[field: SerializeField]
	public float EffectiveAndCriticalFontSizeScale { get; private set; }

	[field: SerializeField]
	public FontStyles EffectiveAndCriticalFontStyles { get; private set; }
}
