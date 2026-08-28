using System;
using System.Collections;
using System.Collections.Generic;

namespace Game.Data
{
	public static class IVariantConfigExtensions
	{
		private const int DefaultVariant = 0;

		public static TCollection GetConfigs<TRawData, TCollection>(this IEnumerable<TRawData> configs, int variantId, Func<TCollection> createCollection, Action<TCollection, TRawData> addToCollection) where TRawData : IVariantConfig where TCollection : ICollection
		{
			return default;
		}
	}
}
