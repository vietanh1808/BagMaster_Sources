using System;
using System.Collections.Generic;
using Game;

[Obsolete]
public class CurrencyManager : Singleton<CurrencyManager>
{
	public List<CurrencyRefill> currencyRefillList;

	private PlayerInfo PlayerInfo => null;

	protected override void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	public CurrencyRefill GetCurrencyRefill(CurrencyData currencyData)
	{
		return null;
	}

	private void InitializeCurrencyRefills()
	{
	}

	private void UpdateCurrencyRefills(float deltaTime)
	{
	}

	public void SaveCurrencyLogoutTimes()
	{
	}
}
