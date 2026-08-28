using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.Combat
{
	public class MonsterHexHandler : HexHandler
	{
		private EnemyController _enemyController;

		private GameObject _hexedModel;

		private MMF_Player _newHitFeedback;

		private MMF_Player _currentHitFeedback;

		protected override void Awake()
		{
		}

		protected override void CreateHexEffect(EChangeModelParams param)
		{
		}

		protected override void Show()
		{
		}

		protected override void Hide()
		{
		}

		protected override void Destroy()
		{
		}

		private void SetModelVisible(bool visible)
		{
		}
	}
}
