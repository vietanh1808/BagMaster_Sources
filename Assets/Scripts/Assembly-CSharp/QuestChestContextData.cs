using System;
using Newtonsoft.Json;

[Serializable]
public class QuestChestContextData
{
	[JsonProperty("chest_index")]
	public int? chestIndex;

	[JsonProperty("threshold_points")]
	public int? thresholdPoints;

	[JsonProperty("is_picker")]
	public bool? isPicker;

	public string ToJson()
	{
		return null;
	}

	public static QuestChestContextData QuestChestAvailable(int chestIndex, int thresholdPoints)
	{
		return null;
	}

	public static QuestChestContextData QuestChestClaimed(int chestIndex, int thresholdPoints, bool isPicker)
	{
		return null;
	}
}
