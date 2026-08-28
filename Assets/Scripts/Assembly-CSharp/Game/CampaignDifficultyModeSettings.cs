using System.Collections;
using System.Collections.Generic;
using MoreMountains.Tools;
using UnityEngine;

namespace Game
{
	public class CampaignDifficultyModeSettings : ScriptableObject, IReadOnlyDictionary<CampaignDifficultyMode, CampaignDifficultyModeSetting>, IEnumerable<KeyValuePair<CampaignDifficultyMode, CampaignDifficultyModeSetting>>, IEnumerable, IReadOnlyCollection<KeyValuePair<CampaignDifficultyMode, CampaignDifficultyModeSetting>>
	{
		[SerializeField]
		private MMSerializableDictionary<CampaignDifficultyMode, CampaignDifficultyModeSetting> _settings;

		public int Count => 0;

		public CampaignDifficultyModeSetting this[CampaignDifficultyMode key] => default;

		public IEnumerable<CampaignDifficultyMode> Keys => null;

		public IEnumerable<CampaignDifficultyModeSetting> Values => null;

		public IEnumerator<KeyValuePair<CampaignDifficultyMode, CampaignDifficultyModeSetting>> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}

		public bool ContainsKey(CampaignDifficultyMode key)
		{
			return false;
		}

		public bool TryGetValue(CampaignDifficultyMode key, out CampaignDifficultyModeSetting value)
		{
			value = default;
			return false;
		}
	}
}
