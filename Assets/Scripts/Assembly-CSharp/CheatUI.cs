using System.Collections.Generic;
using Game;
using Game.Combat;
using Game.EquipmentSystem;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CheatUI : MonoBehaviour
{
	public Button CheatBtn;

	public GameObject CheatTab;

	public Unit Player;

	[Space(10f)]
	public Button AddEqmBtn;

	public Button AddEqmBtnx50;

	public TMP_InputField EqmIdTxt;

	public Button AddAllEqmBtn;

	public TMP_Dropdown EqmDropdown;

	public Button AddEqmbyIdBtn;

	public TMP_InputField EqmIdByIdTxt;

	[Space(10f)]
	public Button RemoveResBtn;

	public Button AddResBtn;

	public TMP_InputField ResIdTxt;

	public TMP_InputField ResNumerTxt;

	public Button AddAllResBtn;

	public Button Add100Golds;

	public Button Add1000Golds;

	[Space(10f)]
	public Button AddStatBtn;

	public TMP_InputField StatIdTxt;

	public TMP_InputField StatValueTxt;

	public TMP_Dropdown StatModType;

	public Button RemoveAllStatCheatBtn;

	[Space(10f)]
	public Button WinBtn;

	public Button AddPVPCupBtn;

	public Button RemovePVPCupWinBtn;

	public TMP_InputField CupNumber;

	[Header("Gear")]
	public TMP_Dropdown GearDropdown;

	public TMP_Dropdown GearLvDropdown;

	public Button RemoveGearBtn;

	public Button SpawnGearBtn;

	public TMP_InputField GearId;

	public Toggle EnableLog;

	[Space(10f)]
	public Button LevelUpBtn;

	public Button NextChapterBtn;

	[Space(10f)]
	public Button AddBuff;

	public Button RemoveBuff;

	public TMP_InputField BuffSkillId;

	[Space(10f)]
	public Button Add1Minutes;

	public Button Add1Hour;

	public Button Add1Day;

	public TextMeshProUGUI TimeCheatTxt;

	[Space(10f)]
	public Toggle OnOffGameplayUi;

	[Space(10f)]
	public Toggle SfxOnOff;

	public Toggle MusicOnOff;

	[Space(10f)]
	public Button ResetMailBtn;

	[Space(10f)]
	public Button Upgrade10TalentNormal;

	public Button Upgrade10TalentSpecial;

	[Space(10f)]
	public TMP_Dropdown EventDungeonDropdown;

	public TMP_InputField EventDungeonFloorTxt;

	public Button UnlockEventDungeonFloorBtn;

	[Space(10f)]
	public Toggle SevenDayQuestCheatToggle;

	[Space(10f)]
	public Toggle ShowBannerToggle;

	private static CheatUI cheatUI;

	public static bool EnableGearLog;

	private List<EquipmentData> _equipmentDatas;

	private List<GearData> _gearDatas;

	[SerializeField]
	private List<GameObject> _gameplayUIs;

	private float _spawnGearX;

	private PlayerInfo PInfo => null;

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void CreateEqmCheat()
	{
	}

	private void CreateGearCheat()
	{
	}

	private void OnDestroy()
	{
	}

	private Unit GetPlayer()
	{
		return null;
	}

	private void OnActiveSceneChanged(Scene scene, Scene scene2)
	{
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode)
	{
	}

	private void CreateEventDungeonCheat()
	{
	}

	private void CheckNewScene(string newSceneName)
	{
	}

	private void Update()
	{
	}
}
