using System;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using DG.Tweening;
using Game.Combat.SkillSystem;
using Game.Constant;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Game
{
	public static class Helper
	{
		private static EventSystem _eventSystem;

		public static string FormatTime(TimeSpan time)
		{
			return null;
		}

		public static (string, string, string) FormatTimeParts(TimeSpan time)
		{
			return default;
		}

		public static string FormatTimeHM(TimeSpan time)
		{
			return null;
		}

		public static string FormatTimeSpan(long durationInSeconds)
		{
			return null;
		}

		public static string FormatTimeDH(TimeSpan time)
		{
			return null;
		}

		public static string FormatTimeDHMS(TimeSpan time)
		{
			return null;
		}

		public static string FormatDateTime(long dateTimeInLong)
		{
			return null;
		}

		public static string FormatDateTime(DateTime dateTime)
		{
			return null;
		}

		public static T ParseEnum<T>(string value)
		{
			return default;
		}

		public static Rarity RandomRarities(Dictionary<Rarity, float> rates, Rarity defaultReturn = Rarity.Common)
		{
			return Rarity.Common;
		}

		public static List<Rarity> RandomRarities(Dictionary<Rarity, float> rates, int number, Rarity defaultReturn = Rarity.Common)
		{
			return null;
		}

		public static T RandomWithWeight<T>(this IEnumerable<IHasWeight<T>> rates, T defaultReturn = default(T))
		{
			return default;
		}

		public static RarityInfo GetRarityInfo(Rarity rarity)
		{
			return null;
		}

		public static bool Roll100(int success)
		{
			return false;
		}

		public static bool Roll01(float success)
		{
			return false;
		}

		public static float SumOf(this IEnumerable<IStatHolder> statHolders, StatName statName, Stat.GetValueCustomDelegate filter = null)
		{
			return 0f;
		}

		public static void GetStatFromEffectParam(EffectParams effectParams, out int id, out ModificationType modificationType, out float value)
		{
			id = default;
			modificationType = default;
			value = default;
		}

		public static bool IsValid(this OwnedResourceEntity resource)
		{
			return false;
		}

		public static bool IsValid(this OwnedItemEntity resource)
		{
			return false;
		}

		public static float CalculateGridLayoutHeight(RectTransform source, int itemCount, float minHeight = 0f)
		{
			return 0f;
		}

		public static bool IsOverUI()
		{
			return false;
		}

		public static bool AlreadyRounded(this float value)
		{
			return false;
		}

		public static Tween DOMoveToTargetPosition(this Transform transform, Transform target, Vector3 targetOffset, float duration, bool includeRotate)
		{
			return null;
		}

		public static Tween DOThrow(this Transform transform, Vector3 end, Vector2 randomX, Vector2 peekHeight, float speed, float minDuration)
		{
			return null;
		}

		public static Vector3 Parabola(Vector3 start, Vector3 end, float height, float t)
		{
			return default;
		}

		[Obsolete("Use TypeConverter.ConvertEpochToDateTime instead.")]
		public static DateTime ConvertEpochToDateTime(long epoch)
		{
			return default;
		}

		[Obsolete("Use TypeConverter.ConvertDateTimeToEpoch instead.")]
		public static long ConvertDateTimeToEpoch(DateTime dateTime)
		{
			return 0L;
		}

		public static UniTask ToUniTask(this Tween tween, Component component)
		{
			return default;
		}

		public static UniTask ToUniTask(this Tween tween, GameObject gameObject)
		{
			return default;
		}
	}
}
