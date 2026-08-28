using MoreMountains.Tools;
using UnityEngine;

[CreateAssetMenu(fileName = "SoundPlayOption", menuName = "Game/SoundPlayOption", order = 0)]
public class SoundPlayOption : ScriptableObject
{
	public Vector2 RandomPitch;

	public MMSoundManagerPlayOptions MMOptions;

	public MMSoundManagerPlayOptions GetOption()
	{
		return default;
	}
}
