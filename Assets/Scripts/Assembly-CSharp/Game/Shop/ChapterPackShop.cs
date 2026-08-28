using System.Collections.Generic;
using R3;
using UnityEngine;
using UnityEngine.UI;

namespace Game.Shop
{
	public class ChapterPackShop : ShopByCategory
	{
		[SerializeField]
		private Button _turnLeftButton;

		[SerializeField]
		private Button _turnRightButton;

		[SerializeField]
		private GameObject _outOfStockUi;

		private int _currentIndex;

		private readonly List<ShopPackData> _visiblePackDatas;

		private DisposableBag _disposableBag;

		private PlayerInfo PInfo => null;

		protected override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void OnProgressChapter(CampaignDifficultyMode campaignDifficultyMode, int value)
		{
		}

		private void TurnLeft()
		{
		}

		private void TurnRight()
		{
		}

		protected override void GenerateShopItems()
		{
		}

		private void GetLastestPack()
		{
		}

		private void UpdateItemInfo()
		{
		}

		private void OnPackClaimed(ShopPackData packData)
		{
		}

		private void Empty()
		{
		}
	}
}
