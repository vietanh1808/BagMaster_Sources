using Game.Constant;
using UnityEngine;
using UnityEngine.UI;

public class FlyBuffItem : MonoBehaviour
{
	[Header("Settings")]
	[SerializeField]
	private float _shakeDelay;

	[SerializeField]
	private float _shakeDuration;

	[SerializeField]
	private float[] _rarityHitBagIntensities;

	[Header("UI")]
	[SerializeField]
	private Image _rarityFillImage;

	[SerializeField]
	private Image _rarityFrameImage;

	[SerializeField]
	private Image _iconImage;

	[SerializeField]
	private GameObject _endVfx;

	private Rarity _rarity;

	private Vector3? _destination;

	private void OnEnable()
	{
	}

	public void UpdateInfo(Sprite rarityFill, Sprite rarityFrame, Sprite icon, Rarity rarity, Vector3? destination = null)
	{
	}

	public void DetermineDestination()
	{
	}

	public void Complete()
	{
	}
}
