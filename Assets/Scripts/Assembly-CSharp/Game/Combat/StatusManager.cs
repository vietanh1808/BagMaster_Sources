using System.Collections.Generic;
using Game.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class StatusManager : MonoBehaviour, IUpdater
	{
		private List<StatusData> _statusDatas;

		public UnityEvent<StatusData> OnStatusApplied;

		public UnityEvent<StatusData> OnStatusRemoved;

		public int StatusCount => 0;

		private void OnEnable()
		{
		}

		public void CustomUpdate(float deltaTime)
		{
		}

		public void Apply(StatusData statusData, bool allowStackSameSource = false, bool allowSameType = true)
		{
		}

		public void Remove(StatusData statusData)
		{
		}

		public void RemoveAllOfType(StatusType statusType)
		{
		}

		private void RemoveSameSource(StatusData statusData)
		{
		}

		private void FetchSlow()
		{
		}

		public void Clear()
		{
		}

		public List<StatusData> GetAll()
		{
			return null;
		}

		private void LogAllStatusData()
		{
		}

		private void OnDisable()
		{
		}
	}
}
