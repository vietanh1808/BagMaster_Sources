using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cysharp.Threading.Tasks;
using Game;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Modal_PurchaseTicket : MonoBehaviour
{
	[StructLayout((LayoutKind)3)]
	[CompilerGenerated]
	private struct _003CPurchase_003Ed__24 : IAsyncStateMachine
	{
		public int _003C_003E1__state;

		public AsyncTaskMethodBuilder _003C_003Et__builder;

		public Modal_PurchaseTicket _003C_003E4__this;

		private int _003Cvalue_003E5__2;

		private UniTask.Awaiter _003C_003Eu__1;

		private void MoveNext()
		{
		}

		void IAsyncStateMachine.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			this.MoveNext();
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}

		void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
		{
			//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
			this.SetStateMachine(stateMachine);
		}
	}

	[SerializeField]
	private TextMeshProUGUI titleText;

	[SerializeField]
	private TextMeshProUGUI descriptionText;

	[SerializeField]
	private PlayerCurrencyView sourceCurrencyView;

	[SerializeField]
	private Image priceIcon;

	[SerializeField]
	private Button buttonClose;

	[SerializeField]
	private Button areaClose;

	[SerializeField]
	private Button buttonAdd;

	[SerializeField]
	private Button buttonSubtract;

	[SerializeField]
	private Button buttonPurchase;

	[SerializeField]
	private Color colorPriceTextEnough;

	[SerializeField]
	private Color colorPriceTextNoEnough;

	[SerializeField]
	private TextMeshProUGUI priceText;

	[SerializeField]
	private Slider slider;

	[SerializeField]
	private CurrencyView currencyView;

	[SerializeField]
	private Image currencyIcon;

	private Action<int> OnPurchaseSuccess;

	private string purchasePlacement;

	private string titleFormat;

	private string descriptionFormat;

	private int quantity;

	private int[] priceSteps;

	private int currencyDestinationId;

	private int currencySourceId;

	private void Awake()
	{
	}

	[AsyncStateMachine(typeof(_003CPurchase_003Ed__24))]
	private Task Purchase()
	{
		return null;
	}

	private void Subtract()
	{
	}

	private void Add()
	{
	}

	private void Close()
	{
	}

	public static void Show(string titleFormat, string descriptionFormat, string purchasePlacement, int currencySourceId, int currencyDestinationId, int[] priceSteps, int quantity, int maxPurchase, string limitReachedMessage, Action<int> onPurchaseSuccess, int defaultStep = 1)
	{
	}

	private void Initialize(string titleFormat, string descriptionFormat, string purchasePlacement, int currencySourceId, int currencyDestinationId, int[] priceSteps, int quantity, int maxPurchase, Action<int> onPurchaseSuccess, int defaultStep)
	{
	}

	private void Refresh(float v)
	{
	}
}
