using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityScreenNavigator.Runtime.Core.Modal;
using UnityScreenNavigator.Runtime.Core.Page;
using UnityScreenNavigator.Runtime.Core.Sheet;

namespace Game
{
	public class UINagivator : MonoBehaviour
	{
		public class SaveData
		{
			public string Path;

			public int Layer;

			public override int GetHashCode()
			{
				return 0;
			}

			public override bool Equals(object obj)
			{
				return false;
			}
		}

		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CLoadBuiltInMethod_003Ed__38<T> : IAsyncStateMachine where T : Component
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public UINagivator _003C_003E4__this;

			public string path;

			public int layer;

			public Action<T> onLoad;

			private AsyncOperationHandle<GameObject> _003Chandle_003E5__2;

			private UniTask<GameObject>.Awaiter _003C_003Eu__1;

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
		private sealed class _003CLoadSave_003Ed__47 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public UINagivator _003C_003E4__this;

			private List<SaveData> _003Csaves_003E5__2;

			private List<NavigationHomeButton> _003Cbuttons_003E5__3;

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
			public _003CLoadSave_003Ed__47(int _003C_003E1__state)
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

		private static Dictionary<string, UINagivator> _instances;

		private static Dictionary<string, List<SaveData>> _pathSaves;

		[Header("Containers")]
		public SheetContainer SheetContainer;

		public PageContainer[] PageContainers;

		public ModalContainer ModalContainer;

		public Transform BuiltInContainer;

		public GameObject NavigatorButtons;

		[Header("Setting")]
		[SerializeField]
		private bool _saveOnDestroy;

		public bool UseAnim;

		[SerializeField]
		private string _sceneName;

		[Header("Events")]
		public UnityEvent<string> OnSheetPushedEvent;

		private Dictionary<int, Stack<GameObject>> _builtInMethodObjects;

		private Dictionary<string, AsyncOperationHandle<GameObject>> _builtInMethodPrefabs;

		private string _linkScene;

		private bool _sheetLoaded;

		public static UINagivator Instance => null;

		public static void AddPath(string path, string sceneName)
		{
		}

		public static void ClearPath(string sceneName)
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void ShowNavigatorButtons()
		{
		}

		public void HideNavigatorButtons()
		{
		}

		public void UseNavigatorButton(string path)
		{
		}

		public bool Push(string path, int layer = 0)
		{
			return false;
		}

		public void Push<T>(T type, int layer = 0)
		{
		}

		public void Push<T>(UINameType type, int layer = 0, Action<T> onLoad = null)
		{
		}

		public void Push<TAction, TUI>(TUI type, int layer = 0, Action<TAction> onLoad = null)
		{
		}

		public void Push<T>(string path, int layer = 0, Action<T> onLoad = null)
		{
		}

		public void PushNonStackPage<T>(string path, int layer = 0, Action<T> onLoad = null)
		{
		}

		private void PushPage<T>(string path, int layer, Action<T> onLoad)
		{
		}

		private bool PushPage(string path, int layer)
		{
			return false;
		}

		private bool PushSheet(string path)
		{
			return false;
		}

		private void PushModal<T>(string path, Action<T> onLoad)
		{
		}

		private bool PushModal(string path)
		{
			return false;
		}

		public void PushBuiltInMethod<T>(string path, int layer, Action<T> onLoad) where T : Component
		{
		}

		[AsyncStateMachine(typeof(_003CLoadBuiltInMethod_003Ed__38<>))]
		private UniTask LoadBuiltInMethod<T>(string path, int layer, Action<T> onLoad) where T : Component
		{
			return default;
		}

		private void PushBuiltin<T>(GameObject prefab, int layer, Action<T> onLoad) where T : Component
		{
		}

		public void PopPage(int layer = 0)
		{
		}

		public void PopModal()
		{
		}

		public void PopContaining(Transform origin)
		{
		}

		public void PopBuiltInMethod(int layer)
		{
		}

		public void PopAllPages(int layer)
		{
		}

		public void PopAllModals()
		{
		}

		private void Save()
		{
		}

		[IteratorStateMachine(typeof(_003CLoadSave_003Ed__47))]
		private IEnumerator LoadSave()
		{
			return null;
		}
	}
}
