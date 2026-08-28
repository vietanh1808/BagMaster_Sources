using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class PlayerStatViewUI : MonoBehaviour
	{
		public int Id;

		public Image Icon;

		public TextMeshProUGUI NameTxt;

		public TextMeshProUGUI ValueTxt;

		public string Format;

		private Stat _stat;

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void UpdateInfo(Stat stat)
		{
		}
	}
}
