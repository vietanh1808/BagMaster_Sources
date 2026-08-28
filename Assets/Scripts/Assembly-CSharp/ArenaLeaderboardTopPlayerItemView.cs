using Game;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ArenaLeaderboardTopPlayerItemView : MonoBehaviour
{
	[SerializeField]
	private Button button;

	[SerializeField]
	private TextMeshProUGUI pointText;

	[SerializeField]
	private TextMeshProUGUI nameText;

	[SerializeField]
	private CharacterSkinEquipmentBinder characterSkinBinder;

	private int userId;

	private void Awake()
	{
	}

	public void Initialize(int userId, string userName, int point)
	{
	}
}
