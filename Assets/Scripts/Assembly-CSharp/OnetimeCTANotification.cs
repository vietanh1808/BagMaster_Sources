using System.Collections.Generic;
using R3;
using UnityEngine;

public class OnetimeCTANotification : MonoBehaviour
{
	[SerializeField]
	private OnetimeCTANotificationType _key;

	[SerializeField]
	private GameObject _notification;

	private static List<OnetimeCTANotificationType> _shownKeys;

	public static Subject<OnetimeCTANotificationType> OnCTANotificationShown;

	public static bool HasBeenShown(OnetimeCTANotificationType key)
	{
		return false;
	}

	private void Start()
	{
	}
}
