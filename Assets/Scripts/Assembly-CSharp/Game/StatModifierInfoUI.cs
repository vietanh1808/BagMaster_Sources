using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class StatModifierInfoUI : MonoBehaviour
	{
		[SerializeField]
		private Image icon;

		[SerializeField]
		private TextMeshProUGUI nameTxt;

		[SerializeField]
		private TextMeshProUGUI valueTxt;

		public void UpdateInfo(StatModifierData data)
		{
		}
	}
}
