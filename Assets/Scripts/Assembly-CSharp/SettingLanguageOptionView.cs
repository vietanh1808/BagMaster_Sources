using System;
using System.Collections.Generic;
using Game;
using I2.Loc;
using UnityEngine;

public class SettingLanguageOptionView : MonoBehaviour
{
	public GameObject OnState;

	public GameObject OffState;

	public List<Localize> LanguageTexts;

	public LanguageFontCollection Settings;

	private string _language;

	private Action _onSelected;

	public void InitSettingOptionView(string language, bool isOn, Action onSelected)
	{
	}

	public void Refresh(string currentLanguage)
	{
	}

	public void OnClick()
	{
	}

	private void SetVisual(bool isOn)
	{
	}
}
