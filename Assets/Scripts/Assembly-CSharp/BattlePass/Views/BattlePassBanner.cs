using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using I2.Loc;
using MoreMountains.Feedbacks;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace BattlePass.Views
{
	public class BattlePassBanner : MonoBehaviour
	{
		[CompilerGenerated]
		private sealed class _003CCheckEndSeasonTime_003Ed__19 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public BattlePassBanner _003C_003E4__this;

			private long _003Cduration_003E5__2;

			private WaitForSeconds _003Cwfs_003E5__3;

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
			public _003CCheckEndSeasonTime_003Ed__19(int _003C_003E1__state)
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

		[Header("Element")]
		[SerializeField]
		private Button buttonClose;

		[SerializeField]
		private Button buttonOpen;

		[SerializeField]
		private Image mask;

		[SerializeField]
		private Transform container;

		[SerializeField]
		private GameObject otherBanner;

		[SerializeField]
		private TextMeshProUGUI textEndSeasonTime;

		[SerializeField]
		private LocalizationParamsManager textEndSeasonTimeParam;

		[Header("Returning animation")]
		[SerializeField]
		private MMF_Player returnFeedback;

		[SerializeField]
		private float returnDuration;

		[SerializeField]
		private float returnScale;

		[SerializeField]
		private Ease returnEase;

		[SerializeField]
		private GameObject endReturnVfx;

		private bool canHide;

		public Action OnClosed;

		private void Awake()
		{
		}

		private void OpenPopup()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		public void CanHide()
		{
		}

		[IteratorStateMachine(typeof(_003CCheckEndSeasonTime_003Ed__19))]
		private IEnumerator CheckEndSeasonTime()
		{
			return null;
		}

		private void Hide()
		{
		}

		public void ForceHide()
		{
		}
	}
}
