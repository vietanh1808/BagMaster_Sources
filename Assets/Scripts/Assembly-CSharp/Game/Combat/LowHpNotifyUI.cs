using UnityEngine;

namespace Game.Combat
{
	public class LowHpNotifyUI : MonoBehaviour
	{
		[SerializeField]
		private float _warningThresold;

		[SerializeField]
		private CanvasGroup _warningUi;

		private Health _playerHealth;

		private void Start()
		{
		}

		private void OnPlayerHpChanges(float currentHp)
		{
		}
	}
}
