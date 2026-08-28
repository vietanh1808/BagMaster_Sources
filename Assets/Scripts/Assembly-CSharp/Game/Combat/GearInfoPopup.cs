using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game.Combat.SkillSystem;
using Game.GearUpgrade;
using MoreMountains.Feedbacks;
using R3;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class GearInfoPopup : MonoBehaviour
	{
		[Serializable]
		private class MergeTierAppearProfile
		{
			public Sprite Background;

			public Color MergeLevelTextColor;
		}

		[CompilerGenerated]
		private sealed class _003CDelayPop_003Ed__54 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GearInfoPopup _003C_003E4__this;

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
			public _003CDelayPop_003Ed__54(int _003C_003E1__state)
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

		[Header("Positioning")]
		[SerializeField]
		private RectTransform _popup;

		[SerializeField]
		private float _offsetYWithHighest;

		[SerializeField]
		private float _minTopPadding;

		[Header("UI")]
		[SerializeField]
		private Image _background;

		[SerializeField]
		private TextMeshProUGUI itemNameTxt;

		[SerializeField]
		private Image iconMg;

		[SerializeField]
		private TextMeshProUGUI descriptionTxt;

		[SerializeField]
		private Image element;

		[SerializeField]
		private GearInfoProperty _cooldownProperty;

		[SerializeField]
		private GearInfoProperty _critRateProperty;

		[SerializeField]
		private GearInfoProperty _attackProperty;

		[SerializeField]
		private GearInfoProperty _healProperty;

		[SerializeField]
		private GearInfoProperty _shieldProperty;

		[SerializeField]
		private MergeTierAppearProfile[] _appearProfiles;

		[SerializeField]
		private TextMeshProUGUI _synercyDescriptionText;

		[SerializeField]
		private float _delayPop;

		[SerializeField]
		private GameObject _newMark;

		[SerializeField]
		private GameObject _newGlow;

		[SerializeField]
		private GearUITags _gearUiTags;

		[SerializeField]
		private GearTagIconProfile _gearTagIconProfile;

		[Header("Feedbacks")]
		[SerializeField]
		private MMF_Player _openFeedback;

		[SerializeField]
		private MMF_Player _mergeableFeedback;

		[Header("Buff")]
		[SerializeField]
		private List<SupportSkillSlot> _buffIcons;

		private Gear _gear;

		private Action _updateMainStatAction;

		private GearInfoProperty _mainStatUI;

		public static GearInfoPopup CurrentPopup;

		public const int Layer = 0;

		public Gear Gear => null;

		public static Subject<bool> ActiveChanged { get; }

		private void Start()
		{
		}

		private void OnMergeableGearChanged(Gear mergableGear)
		{
		}

		public void UpdateStats()
		{
		}

		public void UpdateInfo(Gear gear, GearData gearData)
		{
		}

		public void UpdateInfo(GearData gearData)
		{
		}

		public void UpdateProfile(GearData gearData)
		{
		}

		private void UpdateMainStat(Gear gear, GearData gearData)
		{
		}

		private void UpdateCooldown(Gear gear, SkillData skillData)
		{
		}

		private void UpdateCritRate(Gear gear)
		{
		}

		private void GenerateGearTag(Gear gear)
		{
		}

		private void GenerateBuffIcons(Gear gear)
		{
		}

		public void UpdatePostionBaseOnBagSize()
		{
		}

		private void UpdateNewMark(Gear gear)
		{
		}

		private void UpdateMainStatDamage(Gear gear, GearData gearData, SkillData skillData, EffectData effectData)
		{
		}

		private void UpdateMainStatHeal(Gear gear, GearData gearData, SkillData activeSkillData, EffectData effectData)
		{
		}

		private void UpdateMainStatShield(Gear gear, GearData gearData, SkillData activeSkillData, EffectData effectData)
		{
		}

		private void CreateEffects(Gear gear, GearData gearData, EffectData effectData, out IEffect withBuff, out IEffect withoutBuff)
		{
			withBuff = null;
			withoutBuff = null;
		}

		private string FormatStatValue(float value, bool hasPrefix)
		{
			return null;
		}

		public void OpenStatDebug()
		{
		}

		public void Pop()
		{
		}

		[IteratorStateMachine(typeof(_003CDelayPop_003Ed__54))]
		private IEnumerator DelayPop()
		{
			return null;
		}

		public void PopImmediately()
		{
		}
	}
}
