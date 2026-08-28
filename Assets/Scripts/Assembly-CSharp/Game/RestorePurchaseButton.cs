using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class RestorePurchaseButton : MonoBehaviour
	{
		[SerializeField]
		private Button _button;

		[SerializeField]
		private GameObject _loadingIndicator;

		private void Awake()
		{
		}

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		private void OnButtonClicked()
		{
		}

		private void OnRestoreCompleted(bool success, List<RewardPack> restoredPacks)
		{
		}

		private void SetRestoring(bool isRestoring)
		{
		}
	}
}
