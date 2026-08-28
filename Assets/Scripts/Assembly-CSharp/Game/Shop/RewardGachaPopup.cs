using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Shop
{
	public class RewardGachaPopup : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDisableShieldButtonAfterDelay_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float delay;

			public RewardGachaPopup _003C_003E4__this;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CDisableShieldButtonAfterDelay_003Ed__19(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CSkipAndDisableShieldButton_003Ed__18 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public RewardGachaPopup _003C_003E4__this;

			public float seekTime;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CSkipAndDisableShieldButton_003Ed__18(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private Animator _animator;

		[SerializeField]
		private Image _backGround;

		[SerializeField]
		private Image _textureBackground;

		[SerializeField]
		private GachaRewardPopupProfile _blueChestProfile;

		[SerializeField]
		private GachaRewardPopupProfile _purpleChestProfile;

		[SerializeField]
		private GachaRewardPopupProfile _yellowChestProfile;

		[SerializeField]
		private List<ResourceView> _items;

		[SerializeField]
		private Image _chestImage;

		[SerializeField]
		private Image _chestOpenImage;

		[SerializeField]
		private Image _chestOpenFakeImage;

		[SerializeField]
		private GameObject _closeButton;

		[SerializeField]
		private Button shieldButton;

		[SerializeField]
		private AnimatorSeeker animatorSeeker;

		[SerializeField]
		private float skipTo;

		public void UpdateInfo(RewardPack rewardPack)
		{
		}

		public void UpdateChestInfo(int chestId)
		{
		}

		public void ShowReward()
		{
		}

		public void Skip()
		{
		}

		[IteratorStateMachine(typeof(_003CSkipAndDisableShieldButton_003Ed__18))]
		public IEnumerator SkipAndDisableShieldButton(float seekTime)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CDisableShieldButtonAfterDelay_003Ed__19))]
		private IEnumerator DisableShieldButtonAfterDelay(float delay)
		{
			return null;
		}
	}
}
