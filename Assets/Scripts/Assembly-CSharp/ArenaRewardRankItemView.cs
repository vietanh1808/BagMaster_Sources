using System;
using System.Runtime.CompilerServices;
using Game.Arena;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ArenaRewardRankItemView : MonoBehaviour
{
	[SerializeField]
	private Button button;

	[SerializeField]
	private TextMeshProUGUI textRank;

	[SerializeField]
	private Image imgIcon;

	[SerializeField]
	private GameObject currentRank;

	[SerializeField]
	private GameObject highlightObject;

	private Vector3 imgOriginScale;

	private RankType rankType;

	[CompilerGenerated]
	private Action<RankType> m_OnClick;

	public RankType RankType => RankType.None;

	public event Action<RankType> OnClick
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	public void Initialize(RankType rankType)
	{
	}

	public void SetPlayerRank(bool value)
	{
	}

	public void SetHighlight(bool value)
	{
	}

	private void OnDisable()
	{
	}
}
