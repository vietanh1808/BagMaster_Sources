using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class GameoverPhase : MonoBehaviour
	{
		public Unit Player;

		public CurrencyView CurrencyView;

		public Image Progress;

		public TextMeshProUGUI Progress01Txt;

		public TextMeshProUGUI WaveProgressTxt;

		public Button ReviveBtn;

		public Button NoThanksBtn;

		private RewardPack _rewardPack;

		private float _progress;

		private List<CurrencyView> _cached;

		private PlayerInfo PInfo => null;

		private OwnedResourceEntity ProgressResource => null;

		private void Start()
		{
		}

		public void Open()
		{
		}

		private void ClickNoThanksGoHome()
		{
		}

		private void Revive()
		{
		}
	}
}
