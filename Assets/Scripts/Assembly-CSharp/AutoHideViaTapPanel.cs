using UnityEngine;

public class AutoHideViaTapPanel : MonoBehaviour
{
	[SerializeField]
	protected GameObject _descriptionPanel;

	[SerializeField]
	protected bool _instant;

	public bool IsDescriptionPanelShowing;

	protected void Update()
	{
	}

	public void ToggleDescriptionPanel()
	{
	}

	public void ShowDescriptionPanel()
	{
	}

	public void HideDescriptionPanel()
	{
	}

	public void HideInstant()
	{
	}

	protected virtual void OnShown()
	{
	}

	protected virtual void OnHided()
	{
	}
}
