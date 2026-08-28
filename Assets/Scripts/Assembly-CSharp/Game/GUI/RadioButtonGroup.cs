using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MoreMountains.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace Game.GUI
{
	public class RadioButtonGroup<T> : UiBehaviour
	{
		[CompilerGenerated]
		private sealed class _003Cget_Buttons_003Ed__7 : IEnumerable<(T, RadioButton)>, IEnumerable, IEnumerator<(T, RadioButton)>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private (T Key, RadioButton Button) _003C_003E2__current;

			private int _003C_003El__initialThreadId;

			public RadioButtonGroup<T> _003C_003E4__this;

			private Dictionary<T, RadioButton>.Enumerator _003C_003E7__wrap1;

			(T, RadioButton) IEnumerator<(T, RadioButton)>.Current
			{
				[DebuggerHidden]
				get
				{
					return System_002ECollections_002EGeneric_002EIEnumerator_003C_0028TKey_002CGame_002EGUI_002ERadioButtonButton_0029_003E_002Eget_Current();
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
			public _003Cget_Buttons_003Ed__7(int _003C_003E1__state)
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
			private (T, RadioButton) System_002ECollections_002EGeneric_002EIEnumerator_003C_0028TKey_002CGame_002EGUI_002ERadioButtonButton_0029_003E_002Eget_Current()
			{
				return default;
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}

			[DebuggerHidden]
			IEnumerator<(T, RadioButton)> IEnumerable<(T, RadioButton)>.GetEnumerator()
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
		private MMSerializableDictionary<T, RadioButton> _buttons;

		public UnityEvent<T> SelectedKeyChanged;

		private T _currentKey;

		private bool _hasSelectedAnything;

		protected virtual EqualityComparer<T> Comparer => null;

		public IEnumerable<(T Key, RadioButton Button)> Buttons
		{
			[IteratorStateMachine(typeof(RadioButtonGroup<>._003Cget_Buttons_003Ed__7))]
			get
			{
				return null;
			}
		}

		protected virtual void Start()
		{
		}

		public void Select(T selectedKey)
		{
		}

		protected virtual void SetSelectedState(RadioButton button, T buttonKey, T selectedKey)
		{
		}
	}
}
