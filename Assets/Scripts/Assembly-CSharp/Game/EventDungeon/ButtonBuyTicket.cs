using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EventDungeon
{
	public class ButtonBuyTicket : MonoBehaviour
	{
		[SerializeField]
		private TMP_Text textBuyTimes;

		[SerializeField]
		private TMP_Text[] allTexts;

		[SerializeField]
		private Image imageTicket;

		[SerializeField]
		private Color invalidColor;

		public void SetTextBuyTime(Sprite ticketImg, string text, bool isInvalid)
		{
		}

		public void SetTextBuyTime(string ticketImg, string text, bool isInvalid)
		{
		}
	}
}
