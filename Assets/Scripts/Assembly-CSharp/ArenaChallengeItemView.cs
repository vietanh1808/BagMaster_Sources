using System;
using System.Collections.Generic;
using Game;
using Game.Arena;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ArenaChallengeItemView : MonoBehaviour
{
	[SerializeField]
	private Button buttonInformation;

	[SerializeField]
	private Button buttonChallenge;

	[SerializeField]
	private TextMeshProUGUI textTicketChallenge;

	[SerializeField]
	private Color colorTicketChallengeEnough;

	[SerializeField]
	private Color colorTicketChallengeNotEnough;

	[SerializeField]
	private TextMeshProUGUI textUserName;

	[SerializeField]
	private TextMeshProUGUI textCup;

	[SerializeField]
	private TextMeshProUGUI textPower;

	[SerializeField]
	private TextMeshProUGUI textWinPoint;

	[SerializeField]
	private TextMeshProUGUI textLosePoint;

	private const int CHALLENGE_TICKET_REQUIRE = 1;

	private bool isEnoughTicket;

	private int userId;

	private void Awake()
	{
	}

	private void Information()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnResourceChanged(OwnedResourceEntity arg1, int arg2)
	{
	}

	private void DoAction(Action action)
	{
	}

	private void Challenge()
	{
	}

	private void Consume()
	{
	}

	public void Initialize(int userId, string userName, int point, int power, int winPoint, int losePoint)
	{
	}

	private void RefreshTicket()
	{
	}

	private void EnterCombat()
	{
	}

	private void SendEnterCombatTracking()
	{
	}

	private List<ArenaCombatData> GetArenaCombatData(PlayerInfo playerInfo)
	{
		return null;
	}

	private bool IsArenaCombatDataValid(List<ArenaCombatData> combatData, PlayerInfo playerInfo)
	{
		return false;
	}

	private bool IsArenaCombatDataValid(ArenaCombatData arenaCombatData, PlayerInfo playerInfo)
	{
		return false;
	}
}
