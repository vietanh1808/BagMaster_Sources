using System;
using Game;
using Game.Combat;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CampaignInfoPanelNoState : MonoBehaviour
{
	public GameObject CampaignInfoUI;

	public TextMeshProUGUI UITextChapterNumber;

	public TextMeshProUGUI UITextChapterName;

	[Obsolete("Logic was moved to EnvironmentEffectview")]
	public Image UIIconWeather;

	[Obsolete("Logic was moved to EnvironmentEffectview")]
	public Sprite UIWeatherDefault;

	[Header("States")]
	[SerializeField]
	private GameObject _locked;

	[SerializeField]
	private GameObject _cleared;

	[SerializeField]
	private GameObject _new;

	[SerializeField]
	private GameObject _best;

	private PlayerInfo PInfo => null;

	public void UpdateInfo(Campaign data, int currentIndex, int progressIndex)
	{
	}

	private int GetCampaignProgress(int campaignId)
	{
		return 0;
	}
}
