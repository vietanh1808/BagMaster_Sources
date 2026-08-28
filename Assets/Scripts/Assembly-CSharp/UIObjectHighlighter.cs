using System.Collections.Generic;
using Coffee.UIExtensions;
using UnityEngine;

public class UIObjectHighlighter : MonoBehaviour
{
	[SerializeField]
	private GameObject unmaskPanel;

	[SerializeField]
	private Unmask unMaskItem;

	private List<Unmask> unMaskItems;

	private List<UnmaskRaycastFilter> raycastFilters;

	public void Highlight(params HighlightObjectData[] inputs)
	{
	}

	public void Reactive()
	{
	}

	public void Hide()
	{
	}

	public void ClearAllItems()
	{
	}
}
