using System;
using System.Collections.Generic;
using Game;
using Game.Combat;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class CampaignInfoPanel : MonoBehaviour
{
	public GameObject HardLevelUI;

	public GameObject EasyLevelUI;

	public List<TextMeshProUGUI> UITextChapterInfoList;

	public List<TextMeshProUGUI> UITextProgressionList;

	[Obsolete("Logic was moved to EnvironmentEffectview")]
	public List<Image> UIIconWeatherList;

	[Obsolete("Logic was moved to EnvironmentEffectview")]
	public Sprite UIWeatherDefault;

	private string _chapterProgressLocked;

	private string _chapterProgressNew;

	private string _chapterProgressCleared;

	private string _chapterProgressMid;

	private PlayerInfo PInfo => null;

	private int MainProgressIndex => 0;

	public void UpdateInfo(Campaign data, int currentIndex)
	{
	}

	private int GetCampaignProgress(int campaignId)
	{
		return 0;
	}
}
