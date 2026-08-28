using System;
using Newtonsoft.Json;

[Serializable]
public class QuestContextData
{
	[JsonProperty("name")]
	public string name;

	[JsonProperty("day")]
	public int day;

	[JsonProperty("total_steps")]
	public int totalStep;

	[JsonProperty("quest_number")]
	public int questNumber;

	[JsonProperty("points")]
	public int points;

	public string ToJson()
	{
		return null;
	}

	public static QuestContextData QuestAvailable(string questName, int day)
	{
		return null;
	}

	public static QuestContextData QuestRedirect(string questName, int day)
	{
		return null;
	}

	public static QuestContextData QuestDone(string questName, int totalSteps, int questNumber, int day, int points)
	{
		return null;
	}

	public static QuestContextData QuestRewardClaimed(string questName, int totalSteps, int questNumber, int day)
	{
		return null;
	}
}
