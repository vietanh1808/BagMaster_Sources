using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BattlePass.Views
{
	public class BattlePassUnlock : MonoBehaviour
	{
		[SerializeField]
		private Button buttonUnlock;

		[SerializeField]
		private TextMeshProUGUI textPrice;

		[SerializeField]
		private Color colorNotEnoughGem;

		private int currentStage;

		private bool enough;

		private string _notEnoughResourceStr;

		public Action<int> OnCallUnlock;

		private void Awake()
		{
		}

		private void Unlock()
		{
		}

		public void UpdateData(int stage, int price)
		{
		}
	}
}
