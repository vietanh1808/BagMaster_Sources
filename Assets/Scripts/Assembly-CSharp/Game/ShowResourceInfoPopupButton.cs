using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	[RequireComponent(typeof(CurrencyView))]
	[RequireComponent(typeof(Button))]
	public class ShowResourceInfoPopupButton : MonoBehaviour, IInfoPopup
	{
		[Header("Button")]
		[SerializeField]
		private bool _manualAssign;

		[SerializeField]
		[Tooltip("can show info popup?")]
		private bool _canShowInfoPopup;

		[SerializeField]
		private CurrencyView _currencyView;

		private void Start()
		{
		}

		public void Show()
		{
		}

		public void DisableShowInfoPopup()
		{
		}

		public void EnableShowInfoPopup()
		{
		}
	}
}
