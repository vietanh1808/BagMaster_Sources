using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Game;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class FeatureUI : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CWaitForAbandonCombatSave_003Ed__25 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public FeatureUI _003C_003E4__this;

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
		public _003CWaitForAbandonCombatSave_003Ed__25(int _003C_003E1__state)
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

	private static List<FeatureUI> _allFeatures;

	public string featureName;

	[SerializeField]
	private bool ShowFTUEOnUnlock;

	[SerializeField]
	private GameObject _targetGraphic;

	[SerializeField]
	private Toggle _interactToggle;

	[SerializeField]
	private Button _interactButton;

	[SerializeField]
	private GameObject _lockBackground;

	[SerializeField]
	private List<LockConditionData> lockConditions;

	[SerializeField]
	private LockType lockType;

	[SerializeField]
	private bool checkOnStart;

	[SerializeField]
	private CanvasGroup _unlockingCanvasGroup;

	[SerializeField]
	private ExpandableGroupItem _groupItem;

	[Header("Events")]
	public UnityEvent<FeatureUI> OnHidedEvent;

	private Action _localizationChangedAction;

	public static List<FeatureUI> AllFeatures => null;

	private PlayerInfo PlayerInfo => null;

	public bool IsHided { get; private set; }

	public GameObject TargetGraphic => null;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(_003CWaitForAbandonCombatSave_003Ed__25))]
	private IEnumerator WaitForAbandonCombatSave()
	{
		return null;
	}

	public void SetLockConditions(List<LockConditionData> conditions)
	{
	}

	public void CheckLock(bool overrideLockMessage = true)
	{
	}

	public void UpdateLockMessage(int chapter, int wave)
	{
	}

	private void UpdateLockMessageLocalize()
	{
	}

	public void UnlockFeature()
	{
	}

	public void LockFeature(bool isLock)
	{
	}

	public bool IsFeatureUnlocked()
	{
		return false;
	}

	public bool IsConditionUnlockOk(out int lockChapter, out int lockWave)
	{
		lockChapter = default;
		lockWave = default;
		return false;
	}

	public void SetInteractable(bool interactable)
	{
	}

	public void SetVisible(bool visible)
	{
	}

	public void SetHided(bool hide)
	{
	}
}
