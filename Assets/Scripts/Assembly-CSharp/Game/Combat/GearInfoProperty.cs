using TMPro;
using UnityEngine;

namespace Game.Combat
{
	public class GearInfoProperty : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _mainValueText;

		[SerializeField]
		private TextMeshProUGUI _mainValueTextIfHasChange;

		[SerializeField]
		private TextMeshProUGUI _changeValueText;

		[Space(10f)]
		[SerializeField]
		private string _mainValueFormat;

		[SerializeField]
		private string _changeValueFormat;

		[SerializeField]
		private bool _percentValue;

		[SerializeField]
		private int _formatType;

		public void SetProperty(string mainValue)
		{
		}

		public void SetProperty(float value)
		{
		}

		public void SetPropertyNotAdd(float mainValue, float subValue)
		{
		}

		public void SetProperty(float mainValue, float subValue)
		{
		}

		private string FormatStatValue(float value, bool hasPrefix)
		{
			return null;
		}

		public void SetNull()
		{
		}
	}
}
