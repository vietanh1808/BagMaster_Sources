using System.Collections.Generic;
using Game.Combat;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Game.Testing
{
	public class AutoReportBot : MonoBehaviour
	{
		[SerializeField]
		private GameObject _gameplayUi;

		[Header("UI")]
		[SerializeField]
		private GameObject _rowPrefab;

		[SerializeField]
		private GameObject _colPrefab;

		[SerializeField]
		private Transform _rowContainer;

		[SerializeField]
		private GameObject _emptyReportUi;

		[SerializeField]
		private Color _headerColor;

		[SerializeField]
		private Color _rowColor;

		[Header("Runtime")]
		public List<WaveReportData> Reports;

		public float PlayerShieldGained;

		public int MatchCount;

		private Unit _player;

		private BagGeneralStats _bagGeneralStats;

		private float _startCombatTime;

		private AutoPlayBot _autoPlayBot;

		private string[] Headers => null;

		private void Start()
		{
		}

		private void Update()
		{
		}

		private void OnDestroy()
		{
		}

		private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
		{
		}

		private void OnStartWave()
		{
		}

		private void OnEndWave()
		{
		}

		private void ReportInformation()
		{
		}

		private void GetReferences()
		{
		}

		private void InitializeTable()
		{
		}

		private void AddColumn(GameObject row, string text, Color color, float preferredWidth = 0f)
		{
		}

		private void AddReportRow(WaveReportData data)
		{
		}

		private string ToString(int value)
		{
			return null;
		}

		private string ToString(float value)
		{
			return null;
		}

		public void ClearReports()
		{
		}

		private void OnPlayerShield(CommonData data)
		{
		}

		private string[] GetStrDatas(WaveReportData data)
		{
			return null;
		}

		public void SaveReports()
		{
		}

		public List<WaveReportData> AverageReport(List<List<WaveReportData>> reports)
		{
			return null;
		}

		public void ExportToCSV(string folderPath, List<WaveReportData> reports)
		{
		}
	}
}
