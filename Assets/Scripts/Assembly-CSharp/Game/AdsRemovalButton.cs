using TMPro;
using UnityEngine;

namespace Game
{
	public class AdsRemovalButton : MonoBehaviour
	{
		public enum OfferType
		{
			Default = 0,
			Discount1 = 1,
			Discount2 = 2
		}

		[Header("Offer")]
		[SerializeField]
		private TextMeshProUGUI _nameText;

		[SerializeField]
		private GameObject _buyButton;

		[Header("Discount")]
		[SerializeField]
		private TextMeshProUGUI _discountDurationText;

		[SerializeField]
		private string _discountDurationTextFormat;

		[SerializeField]
		private string _discountDurationTextFormat1;

		[SerializeField]
		private GameObject[] _discountObjects;

		[Header("In Duration")]
		[SerializeField]
		private GameObject _inDurationButton;

		[SerializeField]
		private TextMeshProUGUI _remainDurationText;

		[SerializeField]
		private string _remainDurationFormat;

		[SerializeField]
		private TextMeshProUGUI _remainDuration2Text;

		[Header("References")]
		[SerializeField]
		private ExpandableGroupItem _groupItem;

		[Header("Runtime")]
		[SerializeField]
		private OfferType _currentOfferType;

		private float _timer;

		public static AdsRemovalButton Instance { get; private set; }

		private PlayerInfo PInfo => null;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		public bool IsUnlocked()
		{
			return false;
		}

		private void CheckDuration()
		{
		}

		private void DisplaySuitableOffer()
		{
		}

		private void NextFrameCheck()
		{
		}

		public void ShowOffer()
		{
		}

		public void ShowDiscount(OfferType type)
		{
		}
	}
}
