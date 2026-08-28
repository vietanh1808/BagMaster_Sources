using System;
using TMPro;
using UnityEngine;

[Obsolete]
public class GearPageSlider : MonoBehaviour
{
	[SerializeField]
	private TextMeshProUGUI _inventoryAmountText;

	[SerializeField]
	private int maxPage;

	[SerializeField]
	private int currentPage;

	private Vector3 targetPos;

	[SerializeField]
	private Vector3 targetStep;

	[SerializeField]
	private RectTransform levelPagesRect;

	[SerializeField]
	private float tweenTime;

	[SerializeField]
	private LeanTweenType tweenType;

	private void Start()
	{
	}

	public void Init()
	{
	}

	public void Next()
	{
	}

	public void Previous()
	{
	}

	private void MovePage()
	{
	}
}
