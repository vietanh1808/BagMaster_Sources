using System.Collections.Generic;
using Game;
using Game.Combat;
using UnityEngine;
using UnityEngine.UI;

public class FeatureItemPanel : MonoBehaviour
{
	public Image ShowingIcon;

	private PlayerInfo PInfo => null;

	private int MainProgressIndex => 0;

	public void UpdateInfo(Campaign campaignData, int currentIndex)
	{
	}

	private int GetCampaignProgress(int campaginID)
	{
		return 0;
	}

	public List<GearData> RetrieveGearUnlockedByCampaign(Campaign data)
	{
		return null;
	}
}
