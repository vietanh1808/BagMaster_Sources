using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game.ProgressPointSystem
{
	public class ProgressItem : MonoBehaviour, IProgressItem
	{
		public enum State
		{
			Locked = 0,
			Claimable = 1,
			Claimed = 2
		}

		[SerializeField]
		private TextMeshProUGUI _pointText;

		[SerializeField]
		private Button _claimButton;

		[SerializeField]
		private GameObject _lockedState;

		[SerializeField]
		private GameObject _claimableState;

		[SerializeField]
		private GameObject _claimedState;

		[Header("Events")]
		public UnityEvent<IProgressItem> OnClaimedEvent;

		protected State _state;

		public ProgressData Data { get; private set; }

		public GameObject GameObject => null;

		UnityEvent<IProgressItem> IProgressItem.OnClaimedEvent => null;

		protected virtual void Start()
		{
		}

		public void UpdateInfo(ProgressData data, bool isClaimed, bool canClaim)
		{
		}

		public void SetContentScale(float scale)
		{
		}

		public void SetState(State state)
		{
		}

		private void OnClaimClicked()
		{
		}

		public bool IsClaimable()
		{
			return false;
		}

		public bool IsClaimed()
		{
			return false;
		}
	}
}
