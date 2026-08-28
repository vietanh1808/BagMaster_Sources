using UnityEngine;

public class MaterialFlick : MonoBehaviour
{
	[SerializeField]
	private Renderer _renderer;

	[SerializeField]
	private string _colorProperty;

	[SerializeField]
	private Color _flickColor;

	[SerializeField]
	private float _duration;

	[SerializeField]
	private int _loopCount;

	private MaterialPropertyBlock _block;

	private Color _originalColor;

	private Color _activeFlickColor;

	private int _colorId;

	private float _step;

	private float _timer;

	private int _remainingPulses;

	private bool _on;

	private bool _initialized;

	public void Flick()
	{
	}

	public void Flick(Color flickColor, float duration)
	{
	}

	public void Stop()
	{
	}

	private void Update()
	{
	}

	private void OnDisable()
	{
	}

	private void ApplyColor(Color color)
	{
	}

	private bool EnsureInit()
	{
		return false;
	}
}
