using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Game.Combat
{
	public class NewSlot : MonoBehaviour
	{
		public enum State
		{
			EnoughMoney = 0,
			NoEnoughMoney = 1,
			NoUnlockedSlotNearby = 2,
			UnlockByAds = 3
		}

		[SerializeField]
		private NewSlotVisualConfig _visualConfig;

		[SerializeField]
		private TextMeshPro _priceTxt;

		[SerializeField]
		private GameObject _priceUI;

		[Header("Appeer Effect")]
		[SerializeField]
		private float _appearDuration;

		private List<(SpriteRenderer, int)> _squares;

		private int _price;

		private bool _interactable;

		public State _state;

		private Sprite[] _currentSpriteSheets;

		private Collider2D[] _colliders;

		private IDisposable _listenNewSlot;

		public BagLayoutManager LayoutManager;

		private Bag Bag => null;

		private OwnedResourceEntity Gold => null;

		public int SlotCount => 0;

		private void Awake()
		{
		}

		public void Initialize()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnMouseUpAsButton()
		{
		}

		public void Unlock(float delayAppearTime = 0.5f)
		{
		}

		public void DoUnlock(float delayAppearTime)
		{
		}

		private void FindSpriteSheet(Sprite sprite)
		{
		}

		private int FindIndexOfSprite(Sprite sprite)
		{
			return 0;
		}

		public void UpdateInfo(int start)
		{
		}

		private void OnGoldValueChanged(int newValue)
		{
		}

		private bool EnoughGold()
		{
			return false;
		}

		private bool AnySquareNearby()
		{
			return false;
		}

		public List<Vector2Int> GetUnlockPositions()
		{
			return null;
		}

		public Dictionary<Vector2Int, GameObject> GetLockedPositions()
		{
			return null;
		}

		public int SlotPrice()
		{
			return 0;
		}

		private void ChangeState(State state)
		{
		}

		public static int CompareOrder(NewSlot a, NewSlot b)
		{
			return 0;
		}

		public int OrderValue()
		{
			return 0;
		}
	}
}
