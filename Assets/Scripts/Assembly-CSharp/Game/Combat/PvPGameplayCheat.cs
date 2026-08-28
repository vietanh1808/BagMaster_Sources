using UnityEngine;

namespace Game.Combat
{
	[DefaultExecutionOrder(-20)]
	public class PvPGameplayCheat : MonoBehaviour
	{
		[SerializeField]
		private bool _inGodMode;

		[SerializeField]
		private string _startGearId;

		[SerializeField]
		private string _startBuffId;

		[SerializeField]
		private string _gearPoolIds;

		[SerializeField]
		private int _gearCountRound1;

		[SerializeField]
		private string _Player1SkillIds;

		[SerializeField]
		private string _Player2SkillIds;

		[SerializeField]
		private string _player2Equipments;
	}
}
