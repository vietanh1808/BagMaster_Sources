using Game.Combat;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Game
{
	public class ElementalCounterView : AutoHideViaTapPanel
	{
		[Header("UI")]
		[SerializeField]
		private Button _showEffectButton;

		[SerializeField]
		private TextMeshProUGUI _fireElementText;

		[SerializeField]
		private TextMeshProUGUI _plantElementText;

		[SerializeField]
		private TextMeshProUGUI _electricElementText;

		[SerializeField]
		private TextMeshProUGUI _iceElementText;

		private CanvasGroup _canvasGroup;

		private void Start()
		{
		}

		private void OnPlayerActionGameplay(PlayerActionEventData e)
		{
		}
	}
}
