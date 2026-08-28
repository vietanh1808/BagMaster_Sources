using TMPro;
using UnityEngine;

namespace Game.Combat
{
	public class GearStatUI : MonoBehaviour
	{
		[SerializeField]
		private Transform _ui;

		[SerializeField]
		private TextMeshPro _powerTxt;

		[SerializeField]
		private SpriteRenderer _powerIcon;

		[SerializeField]
		private Sprite _commonIcon;

		[SerializeField]
		private Sprite _hasBuffIcon;

		[SerializeField]
		private Sprite _hasDebuffIcon;

		public float BasePower;

		public float CurrentPower;

		public float NewPower;

		private Gear _gear;

		public void Initialize()
		{
		}

		private float CalculatePower(Gear exludeBuffSource = null)
		{
			return 0f;
		}

		private bool IsBuffFromGear(StatModifier statModifier, Gear gear)
		{
			return false;
		}

		private void SetupUIPosition()
		{
		}

		public int CompareCurrentAndNewPower(Gear exludeBuffGear)
		{
			return 0;
		}

		public void SetDefaultPower()
		{
		}

		public void SaveNewPower()
		{
		}

		public void SetDefaultUi()
		{
		}

		private void UpdatePowerText(float power)
		{
		}

		private int ToDisplayPower(float power)
		{
			return 0;
		}
	}
}
