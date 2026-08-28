using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cysharp.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Game.EventDungeon
{
	public class PageEventTabView : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCreateButton_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public CategoryData cat;

			public PageEventTabView _003C_003E4__this;

			private Sprite _003Cicon_003E5__2;

			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

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
		private struct _003CPreload_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public IEnumerable<string> categories;

			private IEnumerator<string> _003C_003E7__wrap1;

			private Dictionary<string, Sprite> _003C_003E7__wrap2;

			private string _003C_003E7__wrap3;

			private UniTask<Sprite>.Awaiter _003C_003Eu__1;

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

		private static Dictionary<string, Sprite> cacheIcon;

		[SerializeField]
		private ToggleGroup toggleGroup;

		[SerializeField]
		private PageEventTabButton buttonPrefab;

		private List<PageEventTabButton> buttons;

		[AsyncStateMachine(typeof(_003CPreload_003Ed__4))]
		public static void Preload(IEnumerable<string> categories)
		{
		}

		public void SetCategories(IEnumerable<CategoryData> categories)
		{
		}

		public void ActiveToggle(string category)
		{
		}

		[AsyncStateMachine(typeof(_003CCreateButton_003Ed__7))]
		private void CreateButton(CategoryData cat)
		{
		}
	}
}
