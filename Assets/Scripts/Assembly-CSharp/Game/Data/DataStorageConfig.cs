using UnityEngine;

namespace Game.Data
{
	[CreateAssetMenu(fileName = "DataStorageConfig", menuName = "DataStorageConfig", order = 0)]
	public class DataStorageConfig : ScriptableObject
	{
		[field: SerializeField]
		public string Path { get; private set; }
	}
}
