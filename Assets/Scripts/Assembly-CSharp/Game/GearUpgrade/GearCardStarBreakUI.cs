using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.StarBreaking;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.GearUpgrade
{
	public class GearCardStarBreakUI : MonoBehaviour
	{
		[Serializable]
		public class TierNameMapping
		{
			public int Tier;

			public string TierName;

			public string AnimationName;

			public float LevelUpAnimationDuration;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRun_003Ed__39 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GearCardStarBreakUI _003C_003E4__this;

			public StarBreakResult result;

			public CancellationToken cancellationToken;

			public List<GearCardStarBreakRewardItem> cardRewards;

			private int _003CtapCount_003E5__2;

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
		private struct _003CRunSkip_003Ed__38 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public GearCardStarBreakUI _003C_003E4__this;

			public StarBreakResult result;

			public CancellationToken cancellationToken;

			public List<GearCardStarBreakRewardItem> cardRewards;

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

		[Header("UI References")]
		[SerializeField]
		private Button _orbButton;

		[SerializeField]
		private Button _skipButton;

		[SerializeField]
		private Button _closeButton;

		[SerializeField]
		private TextMeshProUGUI _currentTierText;

		[SerializeField]
		private TextMeshProUGUI _currentValueText;

		[SerializeField]
		private string _currentValueTextFormat;

		[SerializeField]
		private GearCardStarBreakResultPanelUI _resultPanelUI;

		[SerializeField]
		private Animator _orbAnimator;

		[SerializeField]
		private List<GearCardStarBreakChanceItemUI> _chanceItems;

		[SerializeField]
		private Image _foreGroundSprite;

		[SerializeField]
		private CanvasGroup _starBreakCanvasGroup;

		[Header("Animation")]
		[SerializeField]
		private int _minCrackAnimationIndex;

		[SerializeField]
		private int _maxCrackAnimationIndex;

		[SerializeField]
		private float _startDelay;

		[SerializeField]
		private float _crackDuration;

		[SerializeField]
		private float _breakDuraiton;

		[SerializeField]
		private TextMeshProUGUI _floatingText;

		[SerializeField]
		private Animator _floatingTextAnimator;

		[SerializeField]
		private string _floatingTextPopTrigger;

		[Header("Configuration")]
		[SerializeField]
		private TierNameMapping[] _tierNameMappings;

		[SerializeField]
		private StarBreakMaterialProfile _colorMaterialProfile;

		[Header("Events")]
		public UnityEvent OnOrbTapFail;

		public UnityEvent OnOrbTapSizeUpgrade;

		public UnityEvent OnOrbTapTierUpgrade;

		public UnityEvent OnOrbTapTierDoubleUpgrade;

		public UnityEvent OnClosedEvent;

		public UnityEvent OnBreakEvent;

		private StarBreakResult _currentResult;

		private int _currentTierIndex;

		private int _currentSizeIndex;

		private int _currentTapIndex;

		private int _currentDoubleSizeCount;

		private TierNameMapping _currentTierName;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void UpdateInfo(StarBreakResult result, List<GearCardStarBreakRewardItem> cardRewards)
		{
		}

		public void UpdateInfo(StarBreakResult result, List<GearCardStarBreakRewardItem> cardRewards, bool skipAnimation)
		{
		}

		[AsyncStateMachine(typeof(_003CRunSkip_003Ed__38))]
		private UniTask RunSkip(StarBreakResult result, List<GearCardStarBreakRewardItem> cardRewards, CancellationToken cancellationToken)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CRun_003Ed__39))]
		private UniTask Run(StarBreakResult result, List<GearCardStarBreakRewardItem> cardRewards, CancellationToken cancellationToken)
		{
			return default;
		}

		private void TriggerAnimation(string triggerName)
		{
		}

		protected virtual string GetIdleTriggerName()
		{
			return null;
		}

		private string GetCrackTriggerName()
		{
			return null;
		}

		private string GetBreakTriggerName()
		{
			return null;
		}

		private void UpdateCurrentTierName()
		{
		}

		private void UpdateCurrentValueText()
		{
		}

		private string GetLevelUpTierName()
		{
			return null;
		}

		private void OnLevelUp()
		{
		}

		private void OnSizeUp(bool tierDouble)
		{
		}

		private void OnFail()
		{
		}

		private void PlayFloatingText(string text)
		{
		}

		private void OnTap()
		{
		}

		private void OnSkip()
		{
		}

		private void OnClose()
		{
		}

		private void UpdateCurrentVisualMaterial()
		{
		}
	}
}
