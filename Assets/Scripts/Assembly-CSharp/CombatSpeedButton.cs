using UnityEngine;
using UnityEngine.UI;

public class CombatSpeedButton : MonoBehaviour
{
	[SerializeField]
	private Image _image;

	[SerializeField]
	private int _currentLevel;

	[SerializeField]
	private float[] _levels;

	[SerializeField]
	private int _chapterUnlock;

	[SerializeField]
	private Sprite[] _spriteByLevel;

	[SerializeField]
	private int _x3Level;

	[SerializeField]
	private GameObject _highlight;

	private float TimeSpeed => 0f;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public bool Unlocked()
	{
		return false;
	}

	public void DoSpeed()
	{
	}

	public void DoNotifyNotUnlocked()
	{
	}

	private void UpdateVisual()
	{
	}

	private int GetMaxLevel()
	{
		return 0;
	}
}
