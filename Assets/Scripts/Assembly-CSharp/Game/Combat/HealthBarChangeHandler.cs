using System;
using MoreMountains.Tools;
using TMPro;

namespace Game.Combat
{
	public class HealthBarChangeHandler
	{
		private TextMeshProUGUI _textComponent;

		private Func<float> _valueGetter;

		private float _mainValue;

		private float _extraValue;

		public HealthBarChangeHandler(Func<float> ValueGetter, TextMeshProUGUI textComponent, MMProgressBar progressBarComponent)
		{
		}

		public void UpdateText()
		{
		}

		private void OnProgressBarStart()
		{
		}

		private void OnProgressBarStop()
		{
		}
	}
}
