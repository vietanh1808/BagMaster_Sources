using System;
using UnityEngine;
using UnityEngine.Events;

namespace Game.GUI
{
	public class RadioButton : StandardGameButton
	{
		[Serializable]
		private struct Setting
		{
			public Sprite Sprite;

			public Color Color;

			public bool ChangeCtaState;

			public bool ShowCta;
		}

		[SerializeField]
		private Setting _selectedSetting;

		[SerializeField]
		private Setting _unselectedSetting;

		public UnityEvent<bool> StateChanged;

		private bool _isSelected;

		public bool IsSelected
		{
			get
			{
				return false;
			}
			set
			{
			}
		}

		private void UpdateUi()
		{
		}

		private void UpdateUi(in Setting setting)
		{
		}
	}
}
