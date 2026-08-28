using TMPro;
using UnityEngine;

namespace Game.GearUpgrade
{
	public class GearUIProperty : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _mainStatText;

		[SerializeField]
		private TextMeshProUGUI _addStatText;

		[SerializeField]
		private string _addTextFormat;

		public void SetProperty(float main, float add)
		{
		}

		public void SetProperty(string text, string adddText)
		{
		}

		public void SetProperty(string text)
		{
		}
	}
}
