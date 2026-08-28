using UnityEngine;

namespace Game.Combat
{
	public class DefeatPhase : VictoryPhase
	{
		[SerializeField]
		private GameObject _recommendStrongerPopup;

		public override void Open()
		{
		}

		protected virtual void CheckShowStrongerSuggestion()
		{
		}
	}
}
