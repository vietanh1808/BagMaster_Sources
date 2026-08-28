using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using DG.Tweening;
using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class RevivePopup : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COnGemOfferBought_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public RevivePopup _003C_003E4__this;

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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CPushGemOffer_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public RevivePopup _003C_003E4__this;

			private UniTask<(bool IsCanceled, bool Result)>.Awaiter _003C_003Eu__1;

			private UniTask.Awaiter _003C_003Eu__2;

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
		private Button _reviveButton;

		[SerializeField]
		private Button _reviveWithGemEnoughButton;

		[SerializeField]
		private CurrencyView _reviveGemPrice;

		[SerializeField]
		private Button _closeButton;

		[SerializeField]
		private RectTransform _cooldownProgress;

		[SerializeField]
		private MMF_Player _reviveFeedback;

		[Header("Loot")]
		[SerializeField]
		private List<CurrencyView> _lootItems;

		private Tween _cooldownTween;

		private Color _originalGemTextColor;

		private static QuickAidConfig ReviveConfig => default;

		private static ResourceRequireData ReviveCost => null;

		private static bool CanReviveWithAds => false;

		private static int ShopPackId => 0;

		protected virtual void Start()
		{
		}

		private void UpdateGemText()
		{
		}

		private void OnDestroy()
		{
		}

		private void ShowLoots()
		{
		}

		protected virtual RewardPack GetLootRewards()
		{
			return null;
		}

		private void Revive()
		{
		}

		private void ReviveWithGem()
		{
		}

		[AsyncStateMachine(typeof(_003CPushGemOffer_003Ed__24))]
		private UniTask PushGemOffer()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003COnGemOfferBought_003Ed__25))]
		private UniTask OnGemOfferBought()
		{
			return default;
		}

		private void ResumeCountdown()
		{
		}

		protected virtual void RevivePlayer()
		{
		}

		public void CloseWithoutRevive()
		{
		}

		protected virtual string GetDefeatPage()
		{
			return null;
		}

		private void SetButtonInteractions(bool interactable)
		{
		}

		private void OnOffMusic(bool on)
		{
		}
	}
}
