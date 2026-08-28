using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.AssetManager;
using Game.EquipmentSystem.Inventory;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EquipmentSystem.Fuse
{
	public class FusePanel : MonoBehaviour
	{
		[Serializable]
		private class FuseSlot
		{
			public GameObject SlotObject;

			public EquipmentInfo EquipmentView;
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CRefresh_003Ed__43 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public FusePanel _003C_003E4__this;

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
		private struct _003CStart_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public Awaitable.AwaitableAsyncMethodBuilder _003C_003Et__builder;

			public FusePanel _003C_003E4__this;

			private Awaitable.Awaiter _003C_003Eu__1;

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

		[Header("Fusion Materials")]
		[SerializeField]
		private EquipmentListViewV2<Item> _equipmentListView;

		[SerializeField]
		private FuseSlot[] _fuseSlots;

		[SerializeField]
		private FuseResultView _fuseResultView;

		[SerializeField]
		private FusePreviewView _fusePreviewView;

		[SerializeField]
		private FuseAnimator _fuseAnimator;

		[SerializeField]
		private EquipmentTransitionAnimator _equipmentTransitionAnimator;

		[Header("Buttons")]
		[SerializeField]
		private Button _fuseableButton;

		[SerializeField]
		private Button _nonFuseableButton;

		[SerializeField]
		private Button _autoFuseAllButton;

		[SerializeField]
		private Button _nonAutoFuseAllButton;

		[Header("Misc")]
		[SerializeField]
		private ScrollRect _itemScrollRect;

		[SerializeField]
		private List<GameObject> _disableObjects;

		[SerializeField]
		private Transform _shadow;

		[SerializeField]
		private GameObject _noItemText;

		private FuseMap _fuseMap;

		private FusePanelSortService _sortService;

		private FuseItemStatusService _itemStatusService;

		private FusePushPopService _pushPopService;

		private SpriteCacheService _spriteCacheService;

		private PlayerInfo PInfo => null;

		private void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003CStart_003Ed__23))]
		private Awaitable Start()
		{
			return null;
		}

		private void OnEquipmentInListViewClicked(EquipmentDisplayData data, Item viewItem)
		{
		}

		private void OnEnable()
		{
		}

		private void LateUpdate()
		{
		}

		private void OnDisable()
		{
		}

		private void OnDestroy()
		{
		}

		private void ClearFuse()
		{
		}

		private void OnMainMaterialPushed(OwnedItemEntity material)
		{
		}

		private void OnMaterialPushed(int index, OwnedItemEntity material)
		{
		}

		private void OnMaterialPopped(int index, OwnedItemEntity material)
		{
		}

		private void OnRequireReached()
		{
		}

		private void OnFuseClicked()
		{
		}

		private void AutoFuseAll()
		{
		}

		public void PushFusingPopup()
		{
		}

		public bool CanPush(EquipmentData equipmentData)
		{
			return false;
		}

		public bool IsPushed(OwnedItemEntity material)
		{
			return false;
		}

		public void PushMaterial(OwnedItemEntity material, EquipmentInfo from)
		{
		}

		public void PopMaterial(OwnedItemEntity material)
		{
		}

		public void ReturnFromFusingPopup()
		{
		}

		private void RebuildListItems()
		{
		}

		[AsyncStateMachine(typeof(_003CRefresh_003Ed__43))]
		private UniTask Refresh()
		{
			return default;
		}

		private void LogFuseMap()
		{
		}
	}
}
