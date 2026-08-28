using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class GearLogItemUI : MonoBehaviour
	{
		[SerializeField]
		private Image _trophyImg;

		[SerializeField]
		private TextMeshProUGUI _trophyText;

		[SerializeField]
		private TextMeshProUGUI _gearNameText;

		[SerializeField]
		private SupportSkillSlot _iconUi;

		[SerializeField]
		private TextMeshProUGUI _totalDamageText;

		[SerializeField]
		private Image _damageDealtProgressImg;

		[SerializeField]
		private List<SupportSkillSlot> _buffItemUIs;

		public GearLog GearLog;

		public float Highest;

		public void UpdateInfo(Gear gear)
		{
		}

		private void Update()
		{
		}

		public void SetTrophy(Sprite sprite, int rank)
		{
		}

		public void Empty()
		{
		}
	}
}
