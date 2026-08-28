using System;
using Game.AssetManager;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class ConfirmationPurchasePopup : MonoBehaviour
	{
		[SerializeField]
		private ResourceView resourceView;

		[SerializeField]
		private ImageAddressable icon;

		[SerializeField]
		private TextMeshProUGUI txtPrice;

		[SerializeField]
		private TextMeshProUGUI _confirmTitle;

		[SerializeField]
		private TextMeshProUGUI _wishingTxt;

		private ResourceRewardData cost;

		private ResourceRewardData reward;

		private Action onPurchase;

		private Action onCancel;

		public static void Show(ResourceRewardData cost, ResourceRewardData reward, UnityAction onPurchase = null, UnityAction onCancel = null)
		{
		}

		private void Initialize(ResourceRewardData cost, ResourceRewardData reward)
		{
		}

		public void Purchase()
		{
		}

		public void Close()
		{
		}
	}
}
