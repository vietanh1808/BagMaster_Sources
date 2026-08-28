using Game;
using UnityEngine;

namespace BattlePass.Views
{
	public class BattlePassLockMessage : MonoBehaviour
	{
		[SerializeField]
		private ShowMessage _showMessage;

		[SerializeField]
		private string _lockedKey;

		[SerializeField]
		private string _expiredKey;

		private void OnEnable()
		{
		}

		public void UpdateMessage()
		{
		}
	}
}
