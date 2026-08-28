using TMPro;
using UnityEngine;

public class SynercyFloatingText : MonoBehaviour
{
	public enum TextType
	{
		None = 0,
		Attack = 1,
		Heal = 2,
		Defense = 3,
		Cooldown = 4
	}

	[SerializeField]
	private TextMeshPro _textMesh;

	public void UpdateInfo(string content, Color color = default(Color))
	{
	}
}
