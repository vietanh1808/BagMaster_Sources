using System;
using I2.Loc;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BattlePass.Views
{
	public class BattlePassUnlockPanel : MonoBehaviour
	{
		[SerializeField]
		private MMF_Player player;

		[SerializeField]
		private Button close;

		[SerializeField]
		private Button close2;

		[SerializeField]
		private Button purchase;

		[SerializeField]
		private LocalizationParamsManager textDecs;

		[SerializeField]
		private TextMeshProUGUI textPrice;

		private Action onPurchase;

		private int currencyValue;

		private int currencyType;

		private bool canHide;

		private void Awake()
		{
		}

		private void Purchase()
		{
		}

		public void Show(int currencyType, int currencyValue, Action purchaseCallback)
		{
		}

		private void CanHide()
		{
		}

		public void Hide()
		{
		}
	}
}
