using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DoorServices;
using Game.Data;
using Game.GUI;
using TMPro;
using UnityEngine;
using UnityEngine.Purchasing;
using UnityEngine.UI;

namespace Game.ChainPack
{
	public class ChainPackItem : UiBehaviour, IIapOfferView
	{
		[Serializable]
		private struct Direction
		{
			public ChainPackDirection direction;

			public GameObject container;

			public GameObject highlight;

			public GameObject normal;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCheckVisibility_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public ChainPackItem _003C_003E4__this;

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
		private GameObject bgHighlight;

		[SerializeField]
		private GameObject bgNormal;

		[SerializeField]
		private ResourceView[] items;

		[SerializeField]
		private Button btnFree;

		[SerializeField]
		private GameObject objFreeLock;

		[SerializeField]
		private Button btnPurchase;

		[SerializeField]
		private TextMeshProUGUI textPrice;

		[SerializeField]
		private GameObject objPurchaseLock;

		[SerializeField]
		private GameObject objClaimed;

		[SerializeField]
		private Direction[] directions;

		private Action<ChainPackItem> OnClaimReward;

		private ResourcesState currentState;

		private readonly HashSet<string> _oldProductIds;

		public bool IsIap { get; private set; }

		public ResourceView[] Items => null;

		public string IapProductId { get; private set; }

		public StoreEntryMethod StoreEntryMethod { get; private set; }

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void Initialize(in ChainPackConfig config, ResourcesState state, ChainPackDirection direction, Action<ChainPackItem> onClaimReward, StoreEntryMethod storeEntryMethod)
		{
		}

		[AsyncStateMachine(typeof(_003CCheckVisibility_003Ed__32))]
		private UniTaskVoid CheckVisibility()
		{
			return default;
		}

		public override void OnUiBecameVisible()
		{
		}

		private void InvokeClaimReward()
		{
		}

		private void CallPurchase()
		{
		}

		private void OnPurchaseSuccess(Order confirmedOrder)
		{
		}

		public void ActiveClaimMark()
		{
		}

		public void DeactiveButtons()
		{
		}
	}
}
