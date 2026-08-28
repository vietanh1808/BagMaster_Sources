using DG.Tweening;
using Game.AssetManager;
using UnityEngine;
using UnityEngine.Events;

public class ResourceFlyIcon : MonoBehaviour
{
	[SerializeField]
	private Vector2 _randomPosition;

	[SerializeField]
	private float _startScale;

	[SerializeField]
	private float _speed;

	[SerializeField]
	private Ease _moveEase;

	[SerializeField]
	private float _size;

	[SerializeField]
	private AudioClip _appearanceSfx;

	[SerializeField]
	private SoundPlayOption _appearanceSfxOption;

	[SerializeField]
	private AudioClip _hitSfx;

	[SerializeField]
	private SoundPlayOption _hitSfxOption;

	[SerializeField]
	private AudioClip _startFlySfx;

	[SerializeField]
	private SoundPlayOption _startFlySfxOption;

	[SerializeField]
	private SpriteRendererAddressable _sprite;

	[Header("Events")]
	public UnityEvent OnFlyCompletedEvent;

	private void Start()
	{
	}

	private void OnDisable()
	{
	}

	public void SetIcon(Sprite sprite)
	{
	}

	public void SetIcon(string spriteName)
	{
	}

	public void Fly(Vector3 destination, bool randomPosition, float delay, float startDuration, bool ignoreTimescale = false)
	{
	}

	private void OnCompleted()
	{
	}
}
