using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Game.Combat
{
	public class NewGearAppearCheck : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CPlayAnimation_003Ed__14 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public NewGearAppearCheck _003C_003E4__this;

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
			public _003CPlayAnimation_003Ed__14(int _003C_003E1__state)
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
		private GameObject _popup;

		[SerializeField]
		private float _delayShowPopup;

		[SerializeField]
		private Sprite _previewGridSprite;

		[SerializeField]
		private GameObject _newGear;

		[SerializeField]
		private GameObject _newGearGlow;

		[SerializeField]
		private GameObject _newGearText;

		[SerializeField]
		private Vector3 _markOffsetToTopOfGear;

		private Gear _gear;

		private int _initialSortingOrder;

		private List<GameObject> _gridPreviews;

		public bool ShowNewMark;

		public bool ShowNewGlow;

		public static NewGearAppearCheck CurrentNewGearAppearCheck;

		private void Start()
		{
		}

		[IteratorStateMachine(typeof(_003CPlayAnimation_003Ed__14))]
		private IEnumerator PlayAnimation()
		{
			return null;
		}

		private void OnStartPopping()
		{
		}

		private void OnEndPopping()
		{
		}

		private void CreatePreviewGridSprites()
		{
		}

		public void HideNewMark()
		{
		}

		public void ShowNewMarkIfShowed()
		{
		}

		public void OffCompletely()
		{
		}

		public void CheckOffCompletely()
		{
		}
	}
}
