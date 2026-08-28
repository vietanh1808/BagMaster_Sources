using System;
using System.Collections.Generic;
using DG.Tweening;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Combat
{
	public class RecyleDropArea : DropArea
	{
		private class AnimationData
		{
			public float ProgressStart;

			public float ProgressValue;

			public float Value;

			public float TargetValue;

			public float FullValue;

			public bool CallBack;

			public int CustomChargeText;
		}

		[SerializeField]
		private List<LockConditionData> _unlockConditions;

		[SerializeField]
		private TextMeshPro _recycleText;

		[SerializeField]
		private string _recycleTextFormat;

		[SerializeField]
		private string _recycleTextFormatWhenOver;

		[SerializeField]
		private TextMeshPro _previewChangeText;

		[SerializeField]
		private MMF_Player _dropGearFeedback;

		[SerializeField]
		private MMF_Player _fullRequireFeedback;

		[SerializeField]
		private string _recycleSoundName;

		[SerializeField]
		private GameObject _recycleEffect;

		[SerializeField]
		private GameObject _recycleFireEffect;

		[SerializeField]
		private ParticleSystem _suckingVFX;

		[SerializeField]
		[Obsolete]
		private SpriteRenderer _progressBar;

		[SerializeField]
		private Image _progressBarContent;

		[SerializeField]
		private MMF_Player _clickShowTooltipFeedback;

		[SerializeField]
		private Ease _progressEase;

		[SerializeField]
		private float _progressBarSpeed;

		[SerializeField]
		private float _progressBarSpeedReverses;

		[SerializeField]
		private float _progressBarSpeed0to1;

		[SerializeField]
		private float _delayWhenReachFull;

		[SerializeField]
		private RecycleChargeView _chargeView;

		[SerializeField]
		private RecyclePremiumView _premiumChargeView;

		[Header("Model animation")]
		[SerializeField]
		private Transform _modelScaler;

		[SerializeField]
		private float _puffStrength;

		[SerializeField]
		private float _puffDuration;

		[Header("Events")]
		public UnityEvent OnRecycleFullCompleteEvent;

		public UnityEvent OnFreeRerollChargeRefilledEvent;

		[Header("Runtime")]
		public bool FreererollUnlimited;

		public int FreererollTotalCharges;

		public int FreererollRemainCharges;

		private int _currentLevel;

		private float _currentValue;

		private float _currentProgressValue;

		private Gear _previewing;

		private List<AnimationData> _animationDatas;

		private bool _dirty;

		private float timeEffectLast;

		[SerializeField]
		private bool doNotLoadSave;

		private Queue<Sequence> _sequences;

		private bool _isAnimating;

		private PlayerInfo PInfo => null;

		private float TargetValue => 0f;

		public int Level => 0;

		public float Value => 0f;

		public float TimeEffectLast
		{
			set
			{
			}
		}

		public bool CanProduceFreeReroll => false;

		private void OnEnable()
		{
		}

		private void Start()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void CheckChargeView()
		{
		}

		public void PlaysuckingVFX()
		{
		}

		public override void LateUpdate()
		{
		}

		private void UpdateProgressBar()
		{
		}

		private Tween TweenProgressTo(float start, float value)
		{
			return null;
		}

		private void SetProgressBarValue(float normalizeValue)
		{
		}

		public override bool CanAccept(DragDropHandler dragDropHandler)
		{
			return false;
		}

		public override void Drop(DragDropHandler dragDropHandler)
		{
		}

		private void AddValue(float value)
		{
		}

		public void ContinueProgress()
		{
		}

		private void CreateAnimationDataNow(float progressStart, float progressValue, float value, float fullValue, bool callback, int overrideChargeRemain)
		{
		}

		public void AutoRecycleGear(GameObject gearItem)
		{
		}

		private void RemoveGear(Gear gear)
		{
		}

		private void UpdateText()
		{
		}

		private void UpdateText(float current, float target)
		{
		}

		public void UpdateChargeText()
		{
		}

		public void CustomChargeText(int remainValue)
		{
		}

		public void Preview(Gear gear)
		{
		}

		public override void OnClick()
		{
		}

		public void LoadSaveData()
		{
		}

		public override void OnHover(DragDropHandler dragDropHandler)
		{
		}

		public override void OnExit(DragDropHandler dragDropHandler)
		{
		}

		public void SetGearPositionHere(Gear gear)
		{
		}

		public void ResetFreeRerollCharge(int amount)
		{
		}

		public void RefillFreeRerollCharge(int amount)
		{
		}

		public bool IsPremium()
		{
			return false;
		}

		public int GetRewardedCharges()
		{
			return 0;
		}

		private void TestPunchScale()
		{
		}
	}
}
