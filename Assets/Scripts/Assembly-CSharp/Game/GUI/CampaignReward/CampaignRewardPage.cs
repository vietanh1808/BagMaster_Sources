using UnityEngine;

namespace Game.GUI.CampaignReward
{
	public class CampaignRewardPage : UiBehaviour
	{
		[SerializeField]
		private CampaignDifficultyModeSettings _settings;

		[SerializeField]
		private CampaignRewardPageContent _content;

		[SerializeField]
		private RadioButtonGroup<CampaignDifficultyMode> _difficultyModeButtonGroup;

		private bool _shouldPopPage;

		private void Start()
		{
		}

		public void Init(CampaignDifficultyMode selectedMode)
		{
		}

		private void Update()
		{
		}

		private void InitModeButtons(CampaignDifficultyMode selectedMode)
		{
		}
	}
}
