using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cysharp.Threading.Tasks;
using Game.UI;
using UnityEngine;

namespace Game.EquipmentSystem
{
	public class EquipmentListViewV2<T> : MonoBehaviour where T : EquipmentInfo
	{
		[CompilerGenerated]
		private sealed class _003CConvertOwnedItems_003Ed__20 : IEnumerable<EquipmentDisplayData>, IEnumerable, IEnumerator<EquipmentDisplayData>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private EquipmentDisplayData _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			private IEnumerable<OwnedItemEntity> items;

			public IEnumerable<OwnedItemEntity> _003C_003E3__items;

			private Predicate<OwnedItemEntity> validationMethod;

			public Predicate<OwnedItemEntity> _003C_003E3__validationMethod;

			private IEnumerator<OwnedItemEntity> _003C_003E7__wrap1;

			EquipmentDisplayData IEnumerator<EquipmentDisplayData>.Current
			{
				[DebuggerHidden]
				get
				{
					return default;
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
			public _003CConvertOwnedItems_003Ed__20(int _003C_003E1__state)
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

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<EquipmentDisplayData> IEnumerable<EquipmentDisplayData>.GetEnumerator()
			{
				return null;
			}

			[DebuggerHidden]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}
		}

		[SerializeField]
		private PoolingGridController<EquipmentDisplayData, T> _gridController;

		private UniTask _updateTask;

		public bool IsInitialized { get; private set; }

		public IReadOnlyList<EquipmentDisplayData> Items => null;

		public IEnumerable<T> ViewItems => null;

		public event Action<EquipmentDisplayData, T> OnEquipmentClicked
		{
			add
			{
			}
			remove
			{
			}
		}

		public event Action<EquipmentDisplayData, T> OnItemBecomeVisible
		{
			add
			{
			}
			remove
			{
			}
		}

		private void Start()
		{
		}

		private void Update()
		{
		}

		public void Init()
		{
		}

		public void Refresh(IEnumerable<OwnedItemEntity> items, Predicate<OwnedItemEntity> validationMethod, Comparison<EquipmentDisplayData> compareMethod = null)
		{
		}

		[IteratorStateMachine(typeof(EquipmentListViewV2<>._003CConvertOwnedItems_003Ed__20))]
		private static IEnumerable<EquipmentDisplayData> ConvertOwnedItems(IEnumerable<OwnedItemEntity> items, Predicate<OwnedItemEntity> validationMethod)
		{
			return null;
		}

		private void OnInitDone()
		{
		}

		public void RemoveDisplayData(OwnedItemEntity ownedItem)
		{
		}

		public void Sort(Comparison<EquipmentDisplayData> compareMethod = null)
		{
		}

		public void AnimateRefresh()
		{
		}
	}
}
