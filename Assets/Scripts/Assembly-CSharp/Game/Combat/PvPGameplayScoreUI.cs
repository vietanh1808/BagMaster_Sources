using System;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;

namespace Game.Combat
{
	public class PvPGameplayScoreUI : MonoBehaviour
	{
		[Serializable]
		public class ScoreUi
		{
			public TextMeshProUGUI Text;

			public MMF_Player UpFeedback;

			[Header("Runtime")]
			public int CurrentScore;
		}

		[SerializeField]
		private ScoreUi[] _scoreUis;

		public void UpdateScore(int[] scores, bool hasAnimation)
		{
		}
	}
}
