using UnityEngine;

namespace Game.Combat
{
	public class CanvasInteractiveController : MonoBehaviour
	{
		[SerializeField]
		private bool _interactableOnPrepare;

		[SerializeField]
		private bool _interactableOnFight;

		[SerializeField]
		private CanvasGroup[] _targets;

		private void Start()
		{
		}

		private void OnGamePhaseChange(GamePhase phase)
		{
		}
	}
}
