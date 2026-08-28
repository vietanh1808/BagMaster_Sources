using DG.Tweening;
using DoorServices;
using Game.Shop;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game
{
	public class ChapterPackOffer : MonoBehaviour
	{
		[SerializeField]
		private ChapterPackShopItem _chapterPackShopItem;

		[SerializeField]
		private MMF_Player _returnFeedback;

		[SerializeField]
		private Ease _returnShopEase;

		[SerializeField]
		private float _returnDuration;

		[SerializeField]
		private GameObject _endReturnVfx;

		[HideInInspector]
		public Transform ShopUi;

		private bool _inClosingAnimation;

		public StoreEntryMethod StoreEntryMethod
		{
			get
			{
				return StoreEntryMethod.Others;
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void OnDestroy()
		{
		}

		public void UpdateInfo(ShopPackData shopPackData)
		{
		}

		public void Close()
		{
		}

		private void Pop()
		{
		}
	}
}
