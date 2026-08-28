using MoreMountains.Tools;
using TMPro;
using UnityEngine;

namespace Game.Combat
{
	public class HealthBar : MonoBehaviour
	{
		[SerializeField]
		private Health _playerHealth;

		[SerializeField]
		private MMProgressBar _hpBar;

		[SerializeField]
		private TextMeshProUGUI _currentHpTxt;

		[SerializeField]
		private MMProgressBar _shieldBar;

		[SerializeField]
		private string _shieldTextFormat;

		[SerializeField]
		private bool _enableFormatLargeNumber;

		private void Start()
		{
		}

		private void UpdateShield(float v)
		{
		}

		private void UpdateHp(float v)
		{
		}

		private void UpdateText()
		{
		}

		public void SetPlayerHealth(Health playerHealth)
		{
		}
	}
}
