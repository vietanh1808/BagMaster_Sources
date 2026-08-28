using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class GeneralCCommands : MonoBehaviour
{
	[SerializeField]
	private Image[] _characterImages;

	[SerializeField]
	private Sprite[] _expressions;

	[SerializeField]
	private Color _listenColor;

	[SerializeField]
	private bool _activeOnEnable;

	private void Start()
	{
	}

	[YarnCommand("set_expression")]
	public void SetExpression(string expression)
	{
	}

	[YarnCommand("listen")]
	public void Listen()
	{
	}

	[YarnCommand("talk")]
	public void Talk()
	{
	}

	[YarnCommand("On")]
	public void On()
	{
	}

	[YarnCommand("Off")]
	public void Off()
	{
	}
}
