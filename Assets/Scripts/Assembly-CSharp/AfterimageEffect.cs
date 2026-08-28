using UnityEngine;

public class AfterimageEffect : MonoBehaviour
{
	[Header("Afterimage Settings")]
	[Tooltip("Khoảng cách nhân vật phải đi được trước khi spawn afterimage mới")]
	public float spawnDistance;

	[Tooltip("Thời gian afterimage tồn tại (giây)")]
	public float lifetime;

	[Tooltip("Độ sáng ban đầu của afterimage (1 = full, 0.5 = nửa sáng)")]
	public float startBrightness;

	[HideInInspector]
	public Material overrideMaterial;

	private SpriteRenderer _sr;

	private Vector3 _lastSpawnPos;

	private AfterimageSlot _slot;

	private static AfterimagePool _pool;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void SpawnAfterimage()
	{
	}
}
