using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using BattlePass.Model;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using EnhancedUI.EnhancedScroller;
using Game;
using Game.SevenDayQuest;
using UnityEngine;

namespace BattlePass.Views
{
	public class BattlePassQuestView : MonoBehaviour, IEnhancedScrollerDelegate
	{
		[StructLayout((LayoutKind)3)]
		[CompilerGenerated]
		private struct _003COnEnable_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncVoidMethodBuilder _003C_003Et__builder;

			public BattlePassQuestView _003C_003E4__this;

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

		[Header("Settings")]
		[SerializeField]
		private float duration;

		[SerializeField]
		private float delay;

		[Header("Element")]
		[SerializeField]
		private GameObject content;

		[SerializeField]
		private EnhancedScroller scroller;

		[SerializeField]
		private SevenDayQuestUIItem questItemPrefab;

		[CompilerGenerated]
		private Action m_OnQuestClaimed;

		private readonly HashSet<SevenDayQuestUIItem> allQuestItems;

		private readonly Dictionary<int, int> mapOrderId;

		private readonly Dictionary<int, List<SevenDayQuestData>> questContainers;

		private bool questInitialized;

		private float itemHeight;

		private BattlePassPayload payload;

		private List<Sequence> allSequences;

		private static bool isRegisterPool;

		public event Action OnQuestClaimed
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

		private void Awake()
		{
		}

		[AsyncStateMachine(typeof(_003COnEnable_003Ed__17))]
		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private int Compare(SevenDayQuestData a, SevenDayQuestData b)
		{
			return 0;
		}

		private int OrderState(SevenDayQuestUIItem.State state)
		{
			return 0;
		}

		private (SevenDayQuestUIItem.State, float) GetTuple(SevenDayQuestData q)
		{
			return default;
		}

		public void ReturnPool()
		{
		}

		public int GetNumberOfCells(EnhancedScroller scroller)
		{
			return 0;
		}

		public float GetCellViewSize(EnhancedScroller scroller, int dataIndex)
		{
			return 0f;
		}

		private int SortDirection(int index)
		{
			return 0;
		}

		private SevenDayQuestData GetBestQuest(List<SevenDayQuestData> list)
		{
			return null;
		}

		public EnhancedScrollerCellView GetCellView(EnhancedScroller scroller, int dataIndex, int cellIndex)
		{
			return null;
		}
	}
}
