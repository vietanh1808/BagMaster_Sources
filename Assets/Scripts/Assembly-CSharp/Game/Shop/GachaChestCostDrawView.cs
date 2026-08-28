using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Shop
{
	public class GachaChestCostDrawView : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CHandleDraw_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GachaChestCostDrawView _003C_003E4__this;

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
			public _003CHandleDraw_003Ed__9(int _003C_003E1__state)
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

		[SerializeField]
		private Button _drawButton;

		[SerializeField]
		private Image _costIcon;

		[SerializeField]
		private TextMeshProUGUI _costText;

		[SerializeField]
		private string _costFormat;

		private IGachaCostService _costService;

		private bool _updateRequired;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDrawButtonClicked()
		{
		}

		[IteratorStateMachine(typeof(_003CHandleDraw_003Ed__9))]
		private IEnumerator HandleDraw()
		{
			return null;
		}

		private void UpdateCostDisplay()
		{
		}

		public void UpdateInfo(IGachaCostService costService, ResourceEntityHasVisual costVisual)
		{
		}

		public void Show()
		{
		}

		public void Hide()
		{
		}
	}
}
