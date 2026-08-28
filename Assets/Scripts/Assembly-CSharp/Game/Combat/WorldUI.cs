using System;
using DG.Tweening;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

namespace Game.Combat
{
	public class WorldUI : MonoBehaviour
	{
		[SerializeField]
		private Transform _bag;

		[SerializeField]
		private SortingGroup _bagSortingGroup;

		[SerializeField]
		private GameObject _bagContent;

		[SerializeField]
		private CanvasGroup _bagUI;

		[SerializeField]
		private CanvasGroup _topUI;

		[SerializeField]
		private Image _gearManagementDim;

		[SerializeField]
		private RectTransform _bagBackground;

		[SerializeField]
		private GameObject _benchSlot;

		[SerializeField]
		private GameObject _recycle;

		[SerializeField]
		private Camera _uiCam;

		private Sequence _openBagSequence;

		private Sequence _closeBagSequence;

		private Sequence _peekBagSequence;

		public GameObject startButton;

		public GameObject rerollBtn;

		public GameObject buySlotBtnContent;

		public GameObject buySlotBtn;

		public GameObject benchSlot;

		public GameObject recycleSlot;

		public GameObject goldBar;

		public GameObject pauseButton;

		public GameObject speedUpButton;

		private float _initialUiCameraY;

		private float _initialUiCameraSize;

		private float _initialBenchSlotX;

		private float _initialRecycleX;

		private float _currentBagPositionY;

		private float _currentCameraY;

		private float _currentCameraSize;

		public bool IsBagReady;

		public static WorldUI Instance { get; private set; }

		public Camera UiCam => null;

		public GameObject Recycle => null;

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		private void SetupSequence(Sequence seq)
		{
		}

		public void OpenBag(Action onCompleted = null)
		{
		}

		public void CloseBagCounter()
		{
		}

		public void CloseBag(Action onCompleted = null)
		{
		}

		public Tween HideBagUi()
		{
			return null;
		}

		public void PeekBag()
		{
		}

		public void UnpeekBag()
		{
		}

		public void ActiveBuyButton(bool value)
		{
		}
	}
}
