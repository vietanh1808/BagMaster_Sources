using Game;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Demo
{
	public class CampaignCheatPanel : MonoBehaviour
	{
		private static CampaignDifficultyMode[] _campaignModes;

		[SerializeField]
		private TMP_InputField _chapterInputText;

		[SerializeField]
		private Button _unlockChapterButton;

		[SerializeField]
		private TMP_Dropdown _chapterModeDropdown;

		private CampaignDifficultyMode _selectedMode;

		private void Start()
		{
		}

		private void UnlockChapter()
		{
		}
	}
}
