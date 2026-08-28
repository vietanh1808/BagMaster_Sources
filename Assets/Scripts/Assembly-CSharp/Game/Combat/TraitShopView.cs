using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.Constant;
using MoreMountains.Feedbacks;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Combat
{
	public class TraitShopView : MonoBehaviour
	{
		public struct OpenParams
		{
			public Unit Player;

			public List<int> PriorityBuffIds;

			public bool SaveOnGetItem;

			public bool RestoreHiddenGroupsOnDone;

			public IBuffManager BuffManager;

			public IEnumerable<CanvasGroup> HideWhenOpen;

			public Vector3? FlyBuffItemTarget;

			public static OpenParams Default => default;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass48_0
		{
			public bool wasItemGet;

			public TraitShopView _003C_003E4__this;

			internal bool _003CWaitUntilTraitItemIsGet_003Eb__1()
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CHideButtons_003Ed__57 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public TraitShopView _003C_003E4__this;

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
		private struct _003COpen_003Ed__45 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public TraitShopView _003C_003E4__this;

			public OpenParams param;

			private float _003CoriginalTimeScale_003E5__2;

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
		private struct _003COpen_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public TraitShopView _003C_003E4__this;

			public List<int> priorityBuffIds;

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
		private struct _003CRunOpenFlow_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public TraitShopView _003C_003E4__this;

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
		private struct _003CUpdateButtons_003Ed__58 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public float delay;

			public bool useSkipAnimation;

			public TraitShopView _003C_003E4__this;

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
		private struct _003CWaitShowRerollButton_003Ed__56 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public bool useSkipAnimation;

			public TraitShopView _003C_003E4__this;

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
		private struct _003CWaitUntilTraitItemIsGet_003Ed__48 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public TraitShopView _003C_003E4__this;

			private _003C_003Ec__DisplayClass48_0 _003C_003E8__1;

			private UniTask<bool>.Awaiter _003C_003Eu__1;

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
		private Button _bagReviewBtn;

		[SerializeField]
		private Button _buffReviewBtn;

		[SerializeField]
		private Sprite[] _titleSprites;

		[SerializeField]
		private Image _titleImage;

		[SerializeField]
		private TraitShopRerollView _rerollView;

		[Header("Peek Bag")]
		[SerializeField]
		private CanvasGroup _peekCanvasGroup;

		[Header("Other ")]
		public List<TraitItem> Items;

		public MMF_Player CloseFeedback;

		public GameObject FireworkVfx;

		public float[] ItemAppearDelays;

		public int MaxRerollPerOpen;

		public AudioSource LoopAudioSource;

		public GameObject FlyBuffItemPrefab;

		public AudioClip SoundSkip;

		private bool _initialized;

		private int _rerollCountThisOpen;

		private int _takeAllCountThisOpen;

		private bool _continue;

		private Canvas _canvas;

		private OpenParams _openParams;

		[SerializeField]
		private GameObject _mainContent;

		[SerializeField]
		private GameObject _viewBagButton;

		private bool _stopShowReroll;

		public TraitShopRerollView RerollView => null;

		public int LastClaimWave { get; private set; }

		public int RerollCount { get; private set; }

		public int TakeAllCount { get; private set; }

		public int TakeAllByAdsCount { get; private set; }

		public static void PushView(string prefabPath, OpenParams openParams)
		{
		}

		private void Start()
		{
		}

		private void OnDisable()
		{
		}

		private void Initialize()
		{
		}

		[AsyncStateMachine(typeof(_003COpen_003Ed__45))]
		private UniTask Open(OpenParams param)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CRunOpenFlow_003Ed__46))]
		private UniTask RunOpenFlow()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003COpen_003Ed__47))]
		private UniTask Open(List<int> priorityBuffIds)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CWaitUntilTraitItemIsGet_003Ed__48))]
		private UniTask WaitUntilTraitItemIsGet()
		{
			return default;
		}

		private static void FadeCanvasGroups(IEnumerable<CanvasGroup> canvasGroups, float endValue)
		{
		}

		private void Reroll()
		{
		}

		public bool IsSkipBuffRollAnimation()
		{
			return false;
		}

		private bool IsFinishAnimation()
		{
			return false;
		}

		private void TakeAllBuffs(bool usingAds)
		{
		}

		public void StopShowRerollButton()
		{
		}

		[AsyncStateMachine(typeof(_003CWaitShowRerollButton_003Ed__56))]
		private UniTask WaitShowRerollButton(bool useSkipAnimation = false)
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CHideButtons_003Ed__57))]
		private UniTask HideButtons()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CUpdateButtons_003Ed__58))]
		private UniTask UpdateButtons(float delay, bool useSkipAnimation = false)
		{
			return default;
		}

		private bool Restock(List<int> priorityBuffIds)
		{
			return false;
		}

		private bool Restock(int numberItems = 3, List<BuffData> priorityBuffs = null)
		{
			return false;
		}

		private void ShowTitleImage(Rarity rarity)
		{
		}

		private void DisplayBuffs(IEnumerable<BuffData> buffs, bool useSkipAnimation)
		{
		}

		private void CreateBuffUIItem(BuffData buffData, float delayAppear)
		{
		}

		private void PlayStartSound()
		{
		}

		private void OnGetItem(BuffData buffData, TraitItem item)
		{
		}

		private void CreateFlyItem(in Vector3 startPosition, Sprite frame, Sprite border, Sprite icon, Rarity rarity = Rarity.Uncommon)
		{
		}
	}
}
