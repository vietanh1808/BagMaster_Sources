using System.Collections.Generic;
using Game.Skin;
using UnityEngine;

namespace Game
{
	public class CharacterSkinPreview : MonoBehaviour
	{
		[SerializeField]
		private MonoBehaviour _actorPrefab;

		[SerializeField]
		private Transform _actorParent;

		private MonoBehaviour _actorInstance;

		private ICharacterSkin _skin;

		private void Awake()
		{
		}

		private void EnsureActor()
		{
		}

		public void Show(IEnumerable<(SkinPart part, string skinKey)> parts)
		{
		}

		public void ShowFromOwned(IEnumerable<OwnedItemEntity> owned)
		{
		}

		public void Clear()
		{
		}
	}
}
