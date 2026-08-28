using Game;
using UnityEngine;

public class GearManager : MonoBehaviour
{
	[SerializeField]
	private GameObject _receivePopup;

	public static GearManager Instance { get; private set; }

	private PlayerInfo PInfo => null;

	private void Awake()
	{
	}

	public void AddGear(int gearIdTxt)
	{
	}
}
