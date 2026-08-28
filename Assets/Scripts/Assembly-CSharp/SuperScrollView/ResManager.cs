using System.Collections.Generic;
using UnityEngine;

namespace SuperScrollView
{
	public class ResManager : MonoBehaviour
	{
		public Sprite[] spriteObjArray;

		private static ResManager instance;

		private string[] mWordList;

		private Dictionary<string, Sprite> spriteObjDict;

		public static ResManager Get => null;

		public int SpriteCount => 0;

		private void InitData()
		{
		}

		private void Awake()
		{
		}

		public Sprite GetSpriteByName(string spriteName)
		{
			return null;
		}

		public string GetRandomSpriteName()
		{
			return null;
		}

		public Sprite GetSpriteByIndex(int index)
		{
			return null;
		}

		public string GetSpriteNameByIndex(int index)
		{
			return null;
		}
	}
}
