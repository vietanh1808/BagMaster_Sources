using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.Combat
{
	public class RecycleChargeView : MonoBehaviour
	{
		public enum State
		{
			None = 0,
			Awake = 1,
			Sleep = 2
		}

		[SerializeField]
		private TextMeshProUGUI _chargeCountText;

		[SerializeField]
		private string _chargeTextFormat;

		[SerializeField]
		private Button _watchAdsButton;

		[SerializeField]
		private TextMeshProUGUI _adsRefillCountText;

		[SerializeField]
		private Color _outChargeTextColor;

		[Header("Visual")]
		[SerializeField]
		private SpriteRenderer _recycleRenderer;

		[SerializeField]
		private Sprite _recycleSpriteDefault;

		[SerializeField]
		private Sprite _recycleSpriteSleep;

		[Header("Messages")]
		[SerializeField]
		private bool _showMessageWhenUsed;

		[SerializeField]
		private Color _messageColor;

		[SerializeField]
		private Vector3 _messageOffet;

		[Header("UnityEvent")]
		public UnityEvent OnDefaultEvent;

		public UnityEvent OnSleepEvent;

		private RecyleDropArea _recycle;

		private State _latestState;

		private Color _countTextColor;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnStateChanged(State state)
		{
		}

		private void ShowOffer()
		{
		}

		public void UpdateChargeText(int remain, int total)
		{
		}

		private void OnChargeUsed()
		{
		}
	}
}
