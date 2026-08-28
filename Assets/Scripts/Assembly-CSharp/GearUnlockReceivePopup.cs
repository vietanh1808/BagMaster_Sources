using System;
using System.Collections.Generic;
using Game.Combat;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

[Obsolete]
public class GearUnlockReceivePopup : MonoBehaviour
{
	public Image _gearSpawnImage;

	public TextMeshProUGUI _gearSpawnName;

	public TextMeshProUGUI _gearDesc;

	public Vector2 _starSpacing;

	public List<GameObject> _stars;

	[Header("UI - Gear Tags")]
	[SerializeField]
	private List<GameObject> _tagItems;

	public Action OnPopupClosed;

	public void Init(GearData gearUnlock)
	{
	}

	private void GenerateGearTag(GearData gearData)
	{
	}

	public void DestroyPopup()
	{
	}
}
