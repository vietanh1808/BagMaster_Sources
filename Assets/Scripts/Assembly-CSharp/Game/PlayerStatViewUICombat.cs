using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class PlayerStatViewUICombat : MonoBehaviour
	{
		[SerializeField]
		private int _id;

		[SerializeField]
		private Image _icon;

		[SerializeField]
		private TextMeshProUGUI _nameTxt;

		[SerializeField]
		private TextMeshProUGUI _valueTxt;

		[SerializeField]
		private string _format;

		[SerializeField]
		private bool _isPercent;

		private Stat _stat;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void UpdateValue()
		{
		}
	}
}
