using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class BenchSlot : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CStart_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public BenchSlot _003C_003E4__this;

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
		private BenchDropArea _benchDropArea;

		[Header("Free-use")]
		[SerializeField]
		private Sprite[] _freeUseSprites;

		[SerializeField]
		private Button _watchAdsButton;

		[SerializeField]
		private TextMeshProUGUI _chargesText;

		[SerializeField]
		private GameObject _infiniteCharges;

		[SerializeField]
		private MMF_Player _costChargeFeedback;

		[SerializeField]
		private Color _outChargeTextColor;

		[SerializeField]
		private GameObject _outChargeFX;

		[Header("Message")]
		[SerializeField]
		private float _showMessageDelay;

		[SerializeField]
		private bool _showMessageWhenUsed;

		[SerializeField]
		private Color _messageColor;

		[SerializeField]
		private Vector3 _messageOffet;

		[Header("Premium-use")]
		[SerializeField]
		private Sprite[] _premiumUseSprites;

		private Color _defaultTextColor;

		private bool _showChargeInfoText;

		public int Charges => 0;

		public Gear CurrentGear => null;

		private void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003CStart_003Ed__20))]
		private void Start()
		{
		}

		private void LoadSave()
		{
		}

		private void CheckPremium()
		{
		}

		public bool IsPremium()
		{
			return false;
		}

		private void AddEventBenchUsage()
		{
		}

		private void AddAdsFunctions()
		{
		}

		private void ShowRemainChargeMessage()
		{
		}

		public void UpdateText(int charges)
		{
		}

		public void ShowOfferPopup()
		{
		}

		public void RestoreCharges(int value)
		{
		}

		public void SetCharges(int value)
		{
		}

		public int GetRestoreChargeValue()
		{
			return 0;
		}

		public int GetChargeResetPerWave()
		{
			return 0;
		}

		public void ResetBenchTarget()
		{
		}
	}
}
