using System;

[Serializable]
public class LockConditionData
{
	public enum ConditionOperator
	{
		And = 0,
		Or = 1
	}

	public ConditionOperator conditionOperator;

	public LockCondition lockCondition;

	public int intValue;

	public float floatValue;

	public string stringValue;

	public bool boolValue;
}
