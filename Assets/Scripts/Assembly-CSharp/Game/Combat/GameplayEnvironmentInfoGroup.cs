using UnityEngine;

namespace Game.Combat
{
	public class GameplayEnvironmentInfoGroup : MonoBehaviour
	{
		[SerializeField]
		private EnvironmentEffectview _view;

		[SerializeField]
		private GameObject _weatherIcon;

		[Header("Visibility")]
		[SerializeField]
		private int _preparePhaseOrder;

		[SerializeField]
		private int _fightPhaseOrder;

		private Canvas _canvas;

		private void Start()
		{
		}
	}
}
