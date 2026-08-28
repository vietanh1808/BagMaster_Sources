using UnityEngine;

public class SyncSeedVFX : MonoBehaviour
{
	[Header("Controlled Particles")]
	[Tooltip("All ParticleSystems that should share the same seed")]
	[SerializeField]
	private ParticleSystem[] controlledParticles;

	[Header("Seed Settings")]
	[Tooltip("Generate new seed when PlayWithNewSeed() is called")]
	[SerializeField]
	private bool autoRegenerateOnPlay;

	[Header("Debug")]
	[SerializeField]
	private bool showDebugLogs;

	private uint _currentSeed;

	public uint CurrentSeed => 0u;

	private void Awake()
	{
	}

	private void OnEnable()
	{
	}

	public void GenerateAndApplySeed()
	{
	}

	public void PlayAllParticles()
	{
	}

	public void PlayWithNewSeed()
	{
	}

	public void StopAll()
	{
	}

	[ContextMenu("Play With New Seed (Test)")]
	private void PlayWithNewSeedTest()
	{
	}

	[ContextMenu("Generate New Seed (No Play)")]
	private void GenerateNewSeedTest()
	{
	}

	[ContextMenu("Play All (Same Seed)")]
	private void PlayAllParticlesMenu()
	{
	}

	[ContextMenu("Stop All Particles")]
	private void StopAllParticlesMenu()
	{
	}

	[ContextMenu("Show Current Seed")]
	private void ShowCurrentSeed()
	{
	}
}
