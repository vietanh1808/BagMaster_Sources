using System.Collections.Generic;
using Game.Combat;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class EnvironmentEffectview : MonoBehaviour
	{
		[SerializeField]
		private List<Image> _uIIconWeathers;

		[SerializeField]
		private Sprite _uiWeatherDefault;

		[SerializeField]
		private Button _showEffectButton;

		[SerializeField]
		private GameObject _descriptionPanel;

		[SerializeField]
		private List<EnvironmentEffectDescriptionView> _detailViews;

		private LevelData _levelData;

		private List<string> _icons;

		private bool _descriptionSetup;

		private bool _hasEnvironmentEffect;

		public bool IsDescriptionPanelShowing { get; private set; }

		public bool HasLevelEfffect => false;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnShowEffectButtonClicked()
		{
		}

		public void UpdateInfo(Campaign data)
		{
		}

		public void HideDescriptionPanel(bool instant)
		{
		}

		public void ShowDescriptionPanel()
		{
		}

		private void LoadData(Campaign campaign)
		{
		}

		private void UpdateIcons()
		{
		}

		public void SetHasEffects()
		{
		}
	}
}
