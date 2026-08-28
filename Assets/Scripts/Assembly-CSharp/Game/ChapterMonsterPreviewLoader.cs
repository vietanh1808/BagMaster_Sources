using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Game.AssetManager;
using Game.Combat;
using UnityEngine;

namespace Game
{
	public class ChapterMonsterPreviewLoader : MonoBehaviour
	{
		[SerializeField]
		private Transform[] _spawnRoots;

		[CompilerGenerated]
		private Action<IReadOnlyList<GameObject>> m_OnMonsterLoadComplete;

		private readonly List<GameObject> _instanceMonster;

		private readonly List<PrefabAddressable> _monsterLoaders;

		private int _expected;

		private int _completed;

		private ChapterPreviewAnimation _previewAnimation;

		public event Action<IReadOnlyList<GameObject>> OnMonsterLoadComplete
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void BindChapter(Campaign campaign, bool isLocked)
		{
		}

		private void LoadCampaign(Campaign campaign)
		{
		}

		private void SpawnMonster(PrefabAddressable loader, Transform spawnRoot)
		{
		}

		private void OnPrefabLoadFailed()
		{
		}

		public void Cancel()
		{
		}

		private void OnRequestLoadDone()
		{
		}

		private void CompleteLoad()
		{
		}

		private List<string> GetMonsterPreviewMap(Campaign campaign)
		{
			return null;
		}
	}
}
