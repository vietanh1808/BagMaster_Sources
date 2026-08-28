using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class SettingPopup_Language : PausePopup
	{
		public GameObject LanguageOptionPrefab;

		public GameObject LanguageOptionContainer;

		public Button CloseButton;

		private readonly List<SettingLanguageOptionView> _optionViews;

		private void Start()
		{
		}

		private void RefreshSelection()
		{
		}
	}
}
