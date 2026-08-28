using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Image))]
public class MonsterAnimationUIV2 : MonoBehaviour
{
	[SerializeField]
	private Texture2D _spriteSheetTexture;

	[SerializeField]
	private Sprite[] _frames;

	[SerializeField]
	[Range(1f, 60f)]
	private int _fps;

	[SerializeField]
	private Vector2 _pivotOffset;

	[SerializeField]
	private bool _debugMode;

	private Image _image;

	private RectTransform _rectTransform;

	private int _currentFrame;

	private float _timer;

	private bool _ready;

	public int FPS
	{
		get
		{
			return 0;
		}
		set
		{
		}
	}

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void UpdateFrame()
	{
	}
}
