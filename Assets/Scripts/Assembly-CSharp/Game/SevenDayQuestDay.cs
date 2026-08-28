using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace Game
{
	public class SevenDayQuestDay : MonoBehaviour
	{
		[SerializeField]
		private Toggle _toggle;

		[SerializeField]
		private TextMeshProUGUI _dayText;

		[SerializeField]
		private Button _lockedButton;

		[SerializeField]
		private GameObject _locked;

		[SerializeField]
		private GameObject _notification;

		[SerializeField]
		private GameObject _onArrow;

		[SerializeField]
		private GameObject _completedMark;

		[SerializeField]
		private Color _textOnColor;

		[SerializeField]
		private Color _textOffColor;

		[Header("Event")]
		public UnityEvent OnSwitchedEvent;

		private int _day;

		private bool _isCompleted;

		private void Awake()
		{
		}

		public void UpdateUI(int day)
		{
		}

		public void SetLock(bool locked)
		{
		}

		public void SetNotification(bool on)
		{
		}

		public void SetCompleted(bool isCompleted)
		{
		}

		public void Render(bool isOn)
		{
		}
	}
}
