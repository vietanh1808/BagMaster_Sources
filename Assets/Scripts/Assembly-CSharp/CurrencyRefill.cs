using System;
using Game;

[Serializable]
public class CurrencyRefill
{
	public int Id;

	public int CurrentValue;

	public int RefillTimeMinutes;

	public int RefillValue;

	public int MaxValue;

	private DateTime _saveTime;

	private float _countdown;

	private int _refillTimeInSeconds;

	public float CountDown => 0f;

	private PlayerInfo PlayerInfo => null;

	private DateTime Now => default;

	public CurrencyRefill(int id, int currentValue, int refillValue, int refillTimeMinutes, int maxValue)
	{
	}

	public void Initialize()
	{
	}

	private void RestoreCurrencyState()
	{
	}

	public void OnCurrencyChanged(OwnedResourceEntity resource, int amount)
	{
	}

	public void UpdateRefill(float deltaTime)
	{
	}

	public void SaveLogOutTime()
	{
	}
}
