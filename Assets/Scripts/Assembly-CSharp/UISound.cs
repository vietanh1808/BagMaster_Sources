using MoreMountains.Tools;
using UnityEngine;

public class UISound : MonoBehaviour
{
	[Header("Sounds")]
	[SerializeField]
	private AudioClip _overrideSound;

	[SerializeField]
	private AudioClip _negativeOverrideSound;

	[SerializeField]
	private string _soundName;

	[SerializeField]
	private string _negativeSoundName;

	[Header("Setting")]
	[SerializeField]
	private AudioSource _audioSource;

	[SerializeField]
	private bool _playSound;

	[SerializeField]
	private bool _playOnEnable;

	[SerializeField]
	private bool _stopPreviousSound;

	[SerializeField]
	private MMSoundManagerPlayOptions _options;

	public bool Negative;

	private AudioSource _usedAudioSource;

	private void OnEnable()
	{
	}

	public void PlaySound()
	{
	}

	public void EnableSFX(bool enable)
	{
	}

	public void StopAudioSource()
	{
	}
}
