using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class PlayerCurrencyView : MonoBehaviour, IResourceReturnValueUI
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CAddDisplayValueOffsetAsync_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public DisplayValueOffset displayValueOffset;

			public PlayerCurrencyView _003C_003E4__this;

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

		public int Id;

		public Image StatIconImg;

		public TextMeshProUGUI StatValueTxt;

		public TextMeshProUGUI RefillTimeTxt;

		public string ValueFormat;

		public Image ValueProgressImg;

		public bool IsShowingMaxiumValue;

		[Header("Auto Hide")]
		public CanvasGroup CanvasGroup;

		public bool HideIf0Amount;

		[Header("Runtime")]
		public int DisplayedValueOffset;

		private List<DisplayValueOffset> _displayValueOffsets;

		private OwnedResourceEntity _currency;

		private CurrencyData _currencyData;

		public OwnedResourceEntity Currency
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private void Start()
		{
		}

		private void LateUpdate()
		{
		}

		private void UpdateRefillTime()
		{
		}

		private int GetTotalDisplayedValueOffset()
		{
			return 0;
		}

		public void SetDisplayValueOffset(int value)
		{
		}

		public void AddDisplayValueOffset(DisplayValueOffset displayValueOffset)
		{
		}

		public void RemoveDisplayValueOffset(DisplayValueOffset displayValueOffset)
		{
		}

		[AsyncStateMachine(typeof(_003CAddDisplayValueOffsetAsync_003Ed__23))]
		private UniTask AddDisplayValueOffsetAsync(DisplayValueOffset displayValueOffset)
		{
			return default;
		}

		private void OnDisable()
		{
		}

		public void ShowInfoPopup()
		{
		}
	}
}
