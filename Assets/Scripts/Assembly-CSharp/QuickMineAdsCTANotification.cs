using Game;
using TMPro;
using UnityEngine;

public class QuickMineAdsCTANotification : MonoBehaviour
{
	[SerializeField]
	private GameObject _notification;

	[SerializeField]
	private TextMeshProUGUI _countText;

	private PlayerInfo PInfo => null;

	private bool OnetimeCTANotificationShown => false;

	private void Update()
	{
	}

	private void Check()
	{
	}
}
