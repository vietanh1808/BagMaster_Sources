using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BattlePass.Views
{
	public class BattlePassExtraReward : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI textTitle;

		[SerializeField]
		private TextMeshProUGUI textDescription;

		[SerializeField]
		private TextMeshProUGUI textProgress;

		[SerializeField]
		private Image imageFill;

		[SerializeField]
		private Button button;

		[SerializeField]
		private TextMeshProUGUI textRewardProgress;

		[SerializeField]
		private GameObject notifyObject;

		public Action OnClaim;

		public Action OnOpenExtraReward;

		private Vector3 originAnchorPosition;

		private int prevCurrentPosition;

		private int extraStage;

		private int currentPoint;

		private int targetPoint;

		private bool isClaimedReward;

		private bool canClick;

		private void Awake()
		{
		}

		private void Click()
		{
		}

		public void SaveAnchorPosition()
		{
		}

		public void SetPositionWithOffset(float y, float duration)
		{
		}

		public void SetProgress(int stage, int currentProgress, int targetProgress, int totalChestClaimed, int totalChest, bool isMaximumLevel, float duration)
		{
		}

		private bool CanClaimedChest()
		{
			return false;
		}
	}
}
