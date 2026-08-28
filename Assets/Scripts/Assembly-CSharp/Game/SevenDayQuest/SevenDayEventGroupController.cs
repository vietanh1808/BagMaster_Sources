using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;
using Game.GUI;
using UnityEngine;

namespace Game.SevenDayQuest
{
	public class SevenDayEventGroupController : MonoBehaviour
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003CCheckShowUnlockPopup_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder _003C_003Et__builder;

			public SevenDayEventGroupController _003C_003E4__this;

			private UniTask.Awaiter _003C_003Eu__1;

			private List<SevenDayQuestManager>.Enumerator _003C_003E7__wrap1;

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
		private struct _003CInitialize_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskVoidMethodBuilder _003C_003Et__builder;

			public SevenDayEventGroupController _003C_003E4__this;

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

		[SerializeField]
		private ExpandableGroupVertical _group;

		[SerializeField]
		private GameObject _buttonPrefab;

		[SerializeField]
		private UnlockPopup _unlockPopup;

		private readonly List<ExpandableGroupItem> _spawnedItems;

		private bool _isStarted;

		private CancellationTokenSource _showIntroTokenSource;

		private PlayerInfo PInfo => null;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		[AsyncStateMachine(typeof(_003CInitialize_003Ed__11))]
		private UniTaskVoid Initialize()
		{
			return default;
		}

		private void ClearButtons()
		{
		}

		private void BuildButtons()
		{
		}

		private void SpawnButtons(SevenDayEventConfig eventConfig, bool isEventComingSoon, HashSet<int> addedEventIds)
		{
		}

		private void CheckAnyNewEvents()
		{
		}

		[AsyncStateMachine(typeof(_003CCheckShowUnlockPopup_003Ed__16))]
		private UniTask CheckShowUnlockPopup()
		{
			return default;
		}

		private void ShowIntroPopup(SevenDayEventConfig config)
		{
		}

		private UnlockPopup GetUnlockPopup()
		{
			return null;
		}

		private bool WaitForPageReady()
		{
			return false;
		}

		private void TestShowAllRunningIntroPopups()
		{
		}
	}
}
