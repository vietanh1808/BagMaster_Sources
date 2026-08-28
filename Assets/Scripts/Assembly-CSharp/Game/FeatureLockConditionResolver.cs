using System.Collections.Generic;

namespace Game
{
	public class FeatureLockConditionResolver
	{
		private bool CheckChapterProgressCondition(int chapter)
		{
			return false;
		}

		private bool CheckWaveReachedInCurrentCampaign(int wave)
		{
			return false;
		}

		public bool Resolve(List<LockConditionData> conditions)
		{
			return false;
		}
	}
}
