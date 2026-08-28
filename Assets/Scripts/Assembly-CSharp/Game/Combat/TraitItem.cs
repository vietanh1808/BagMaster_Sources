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
	public class TraitItem : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CWaitForFinishTraitAnim_003Ed__52 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public float wait;

			public TraitItem _003C_003E4__this;

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
			public _003CWaitForFinishTraitAnim_003Ed__52(int _003C_003E1__state)
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
		private static Action<TraitItem> m_onGet;

		[SerializeField]
		protected BuffUIProfile _uiProfile;

		[SerializeField]
		private Image _iconImage;

		[SerializeField]
		private Image _rarityFrameImage;

		[SerializeField]
		private Image _iconFrameImage;

		[SerializeField]
		private Image _iconFrameBorderImage;

		[SerializeField]
		private TextMeshProUGUI _nameText;

		[SerializeField]
		private TextMeshProUGUI _descText;

		[SerializeField]
		private Sprite[] _rarityFrames;

		[SerializeField]
		private MMF_Player _appearFeedback;

		[Header("Gear effects")]
		[SerializeField]
		private TextMeshProUGUI _effectedGearCountText;

		[Header("Animation")]
		[SerializeField]
		private Animator _traitAnim;

		[SerializeField]
		private Animator _skillIconAnim;

		[SerializeField]
		private Button button;

		[SerializeField]
		private GameObject _recommendIcon;

		public Action OnGetCallback;

		public AudioSource LoopAudioSource;

		protected Unit _player;

		protected BuffData _buffData;

		protected float _destinationY;

		protected RectTransform _rectTransform;

		private float delayToStop;

		private bool _isRecommended;

		public Image RarityFrameImage => null;

		public Image IconFrameImage => null;

		public Image IconFrameBorderImage => null;

		public Sprite[] RarityFrames => null;

		public Image IconImage => null;

		public int toTier { get; private set; }

		public bool FinishedAnimation => false;

		public static event Action<TraitItem> onGet
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		protected void RaiseOnGet(TraitItem item)
		{
		}

		private void Awake()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		private void RemoveEvents()
		{
		}

		protected void RegisterEvents()
		{
		}

		private void OnSkipRollAnimation(bool isSkip, bool isEventDungeonCampaign)
		{
		}

		public virtual void Initialize(BuffData buffData, Unit player, float delayAppear, bool isRecommended)
		{
		}

		public void DoAppearAnim(float delay = 0f)
		{
		}

		public bool IsSkipBuffRollAnimation()
		{
			return false;
		}

		public virtual void NewAppearAnim(int toTier, float delay = 0f, int? animTier = null)
		{
		}

		public void StopRolling()
		{
		}

		[IteratorStateMachine(typeof(_003CWaitForFinishTraitAnim_003Ed__52))]
		private IEnumerator WaitForFinishTraitAnim(float wait)
		{
			return null;
		}

		public void EnableButtonInteract()
		{
		}

		public void ExitStateAnim()
		{
		}

		protected void ActivateBuff()
		{
		}

		public void StopLoopAudio()
		{
		}

		public void PlayLoopAudio()
		{
		}

		public virtual void RequestChangeFrame(Rarity rarity)
		{
		}

		private void UpdateGearEffectedInformation()
		{
		}

		protected virtual void OnDisable()
		{
		}
	}
}
