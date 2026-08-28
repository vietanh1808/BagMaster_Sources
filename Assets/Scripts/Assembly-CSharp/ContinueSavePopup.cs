using System.Collections.Generic;
using Game;
using Game.Combat;
using MoreMountains.Tools;
using TMPro;
using UnityEngine;

public class ContinueSavePopup : MonoBehaviour
{
	[Header("UI")]
	[SerializeField]
	private TextMeshProUGUI _saveInfoText;

	[Header("Load scene")]
	[SerializeField]
	private MMAdditiveSceneLoadingManagerSettings _loadingSceneSettings;

	private Campaign _savedCampaign;

	private int _saveWaveReached;

	private List<int> _newGearThisWave;

	private CombatSaveData _saveData;

	private PlayerInfo PInfo => null;

	private void Start()
	{
	}

	public void Continue()
	{
	}

	public void Abandon()
	{
	}
}
