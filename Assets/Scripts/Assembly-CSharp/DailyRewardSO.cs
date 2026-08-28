using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DailyRewardSO", menuName = "ScriptableObjects/DailyRewardSO", order = 2)]
public class DailyRewardSO : ScriptableObject
{
	public int dayCondition;

	public List<Reward> reward;

	public bool isDouble;
}
