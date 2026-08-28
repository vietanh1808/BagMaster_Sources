using UnityEngine;
using UnityEngine.UI;
using Yarn.Unity;

public class NarractiveCommands : MonoBehaviour
{
	[SerializeField]
	private DialogueRunner _dialogueRunner;

	[SerializeField]
	private Image[] _pigRenderers;

	[SerializeField]
	private Sprite[] _expressions;

	[YarnCommand("cast_skill")]
	public void CastSkill(int skillId)
	{
	}

	[YarnCommand("spawn_gear")]
	public void SpawnGear(int gearId)
	{
	}

	[YarnCommand("close")]
	public void Close()
	{
	}

	[YarnCommand("pause")]
	public void Pause(bool pause)
	{
	}
}
