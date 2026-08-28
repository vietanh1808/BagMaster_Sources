using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game;
using Game.Combat;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ChapterRewardPopup : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CReAlign_003Ed__29 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public ChapterRewardPopup _003C_003E4__this;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CReAlign_003Ed__29(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private TextMeshProUGUI chapterText;

	[SerializeField]
	private TextMeshProUGUI preWaveText;

	[SerializeField]
	private TextMeshProUGUI currentWaveText;

	[SerializeField]
	private TextMeshProUGUI[] nextWaveText;

	[SerializeField]
	private Transform content;

	[SerializeField]
	private Transform fakeContent;

	[SerializeField]
	private CurrencyView currencyViewPrefab;

	[SerializeField]
	private Animator animator;

	[SerializeField]
	private Button claimButton;

	[SerializeField]
	private TextMeshProUGUI nextRewardTxt;

	[SerializeField]
	private GameObject _lightEffect;

	[SerializeField]
	private CanvasGroup canvasGroupVFX;

	private RewardPack currentRewardPack;

	private LevelData currentLevelData;

	private List<ResourceRewardData> _rewardedThisOpen;

	private bool animShowReward;

	[SerializeField]
	private List<RectTransform> chapterItems;

	[SerializeField]
	private FlyToBarProfile _flyToBarProfile;

	private List<Transform> listRewardItems;

	private List<Vector2> originalPositions;

	private string _coomingSoonLocalizedStr;

	private PlayerInfo PInfo => null;

	private void Awake()
	{
	}

	private void InitPositions()
	{
	}

	private void OnDestroy()
	{
	}

	private void RestorePositions()
	{
	}

	public void OnEnable()
	{
	}

	public void PlayAnimationNext()
	{
	}

	[IteratorStateMachine(typeof(_003CReAlign_003Ed__29))]
	private IEnumerator ReAlign()
	{
		return null;
	}

	public void RefreshCurrentChapter()
	{
	}

	public void SetUpText()
	{
	}

	private Campaign GetCampaignByLevelId(int levelId)
	{
		return null;
	}

	public void CreateRewardItems(RewardPack rewardPack)
	{
	}

	public void OnButtonClaimed()
	{
	}

	public void RemoveRewardAnim()
	{
	}

	private void ShowRewardAnim()
	{
	}

	public void ChangeChapter()
	{
	}

	public void ClearPlayer()
	{
	}

	private string GetWaveText(int waveId)
	{
		return null;
	}
}
