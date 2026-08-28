using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Game
{
	public class CombatPowerGetter : MonoBehaviour
	{
		[SerializeField]
		private TextMeshProUGUI _combatPowerText;

		[SerializeField]
		private float _statValue;

		[SerializeField]
		private float _gearValue;

		[SerializeField]
		private float _combatPower;

		public UnityEvent<float, float> OnCombatPowerChangedEvent;

		private PlayerInfo PInfo => null;

		public float CombatPower => 0f;

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnPlayerStatChanged()
		{
		}

		private void OnGearStatChanged()
		{
		}

		private void CalculateGearValue()
		{
		}

		private void CalculateStatValue()
		{
		}

		private void CalculateCombatPower()
		{
		}
	}
}
