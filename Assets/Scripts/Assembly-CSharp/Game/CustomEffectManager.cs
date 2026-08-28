using System;
using System.Collections.Generic;
using UnityEngine;

namespace Game
{
	public class CustomEffectManager : MonoBehaviour
	{
		public enum DataStatus
		{
			NonActive = 0,
			Actived = 1
		}

		public class Data
		{
			public Func<bool> InActive;

			public Action ApplyEffect;

			public Action CancelEffect;

			public DataStatus Status;
		}

		public class CardMonthyEffectSource
		{
		}

		private List<Data> _datas;

		private CardMonthyEffectSource _cardMonthyEffectSource;

		public static CustomEffectManager Instance { get; private set; }

		private PlayerInfo PInfo => null;

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void PerSecond()
		{
		}

		private void Handle(Data data)
		{
		}

		private void Initialize()
		{
		}

		private void InitializeMonthyCardEffect()
		{
		}
	}
}
