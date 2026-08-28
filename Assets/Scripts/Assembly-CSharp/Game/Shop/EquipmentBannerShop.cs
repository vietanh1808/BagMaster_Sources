using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.UI;

namespace Game.Shop
{
	public class EquipmentBannerShop : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CGenerateEquipmentBanners_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public EquipmentBannerShop _003C_003E4__this;

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

		[CompilerGenerated]
		private sealed class _003CPreloadBanners_003Ed__2 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

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
			public _003CPreloadBanners_003Ed__2(int _003C_003E1__state)
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

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CShowCurrentBannerAsync_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public EquipmentBannerShop _003C_003E4__this;

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

		private static Dictionary<string, GameObject> _bannerPrefabs;

		private static AsyncOperationHandle<IList<GameObject>> _preloadHandle;

		[SerializeField]
		private List<RectTransform> _equipmentBannerSlots;

		[SerializeField]
		private ChestType _equipmentBannerType;

		[SerializeField]
		private Vector2 _bannerOffset;

		[SerializeField]
		private int _startSiblingIndex;

		[SerializeField]
		private Button _btnPrev;

		[SerializeField]
		private Button _btnNext;

		[SerializeField]
		private EquipmentBannerSizeUpdater BannerSizeController;

		[SerializeField]
		private List<RectTransform> _indexButtonSlots;

		private Dictionary<string, AsyncOperationHandle<GameObject>> _operationDictionary;

		private Dictionary<GachaData, GameObject> _bannerInstances;

		private List<GachaData> _validGachaDatas;

		private int _currentGachaIndex;

		private int _index;

		private const string GachaIndexPrefsKey = "EquipmentBannerShop_LastIndex";

		[IteratorStateMachine(typeof(_003CPreloadBanners_003Ed__2))]
		public static IEnumerator PreloadBanners()
		{
			return null;
		}

		public static void ReleasePreloadedBanners()
		{
		}

		private void SaveGachaIndex()
		{
		}

		private void LoadGachaIndex()
		{
		}

		private void Awake()
		{
		}

		private void OnIndexButtonClicked(int index)
		{
		}

		private void OnPrevClicked()
		{
		}

		private void OnNextClicked()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnEnable()
		{
		}

		[AsyncStateMachine(typeof(_003CGenerateEquipmentBanners_003Ed__26))]
		private UniTask GenerateEquipmentBanners()
		{
			return default;
		}

		[AsyncStateMachine(typeof(_003CShowCurrentBannerAsync_003Ed__27))]
		private UniTask ShowCurrentBannerAsync()
		{
			return default;
		}

		private void GenerateIndexButtons()
		{
		}

		private void CreateBannerInstance(GameObject bannerPrefab, GachaData gachaData)
		{
		}
	}
}
