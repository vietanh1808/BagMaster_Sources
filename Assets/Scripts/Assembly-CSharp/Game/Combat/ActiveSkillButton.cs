using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game.Constant;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class ActiveSkillButton : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CDoScale_003Ed__37 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public ActiveSkillButton _003C_003E4__this;

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
			public _003CDoScale_003Ed__37(int _003C_003E1__state)
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
		private BuffUIProfile _uiProfile;

		[SerializeField]
		private Image _skillIcon;

		[SerializeField]
		private Image _skillCooldownSkipIcon;

		[SerializeField]
		private Image _sourceIcon;

		[SerializeField]
		private Image _sourceBackground;

		[SerializeField]
		private Image _sourceBorder;

		[SerializeField]
		private Button _activateSkillButton;

		[SerializeField]
		private Image _cooldown;

		[SerializeField]
		private TextMeshProUGUI _cooldownCounterText;

		[SerializeField]
		private Image _border;

		[SerializeField]
		private Color _inCooldownBorderColor;

		[SerializeField]
		private float _thresoldFinishCooldown;

		[SerializeField]
		private MMF_Player _finishCooldownFeedback;

		[SerializeField]
		private MMF_Player _activateFeedback;

		[SerializeField]
		private GameObject _activateableVfx;

		[SerializeField]
		private GameObject _castingVfx;

		[SerializeField]
		private Transform _adsOptionDisplayPos;

		[Header("Runtime")]
		public SimpleSkill Skill;

		private float _clickTime;

		private bool _lastState;

		private IDisposable _event;

		private string _notReadyStr;

		private bool _adsShowable;

		private bool _isCooldownSkillByAdsUnlocked;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		private void CheckAdsShowable(float remainTime)
		{
		}

		private void SetCooldownSkipIconDisplay(bool isActive)
		{
		}

		private void SetCooldownToReady()
		{
		}

		private void DoActivateOrCastSkill(bool isResetCooldown)
		{
		}

		private void CheckSkipCooldownUnlocked()
		{
		}

		private void OnButtonClick()
		{
		}

		private void ShowAdsOption()
		{
		}

		private void CastSkillFromAdsOption()
		{
		}

		private void OnAdsOptionPopupHolderShowed(AdsOptionPopupHolder popup)
		{
		}

		[IteratorStateMachine(typeof(_003CDoScale_003Ed__37))]
		private IEnumerator DoScale()
		{
			return null;
		}

		public void UpdateInfo(string skillIconName, string sourceIconName, Rarity sourceRarity)
		{
		}

		public bool IsReady()
		{
			return false;
		}

		public void InvokeClick()
		{
		}
	}
}
