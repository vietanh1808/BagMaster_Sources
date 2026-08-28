using System;
using System.Collections.Generic;
using Game.AssetManager;
using Game.Combat.SkillSystem;
using Game.Constant;
using MoreMountains.Feedbacks;
using R3;
using UnityEngine;
using UnityEngine.Events;

namespace Game.Combat
{
	public class Gear : MonoBehaviour, IEffectGear, IStatOwner, IEffectTarget, IUpgradeable, ISkillSwapOwner, IHasTags, IHasBuffDpsMod, IBagGridItem, ICounterItem, IBenchItem, IMergeableItem
	{
		private class ActiveSkillSwapData
		{
			public SkillData NewSkillData;

			public int Number;
		}

		public SpriteRenderer Renderer;

		public List<SimpleSkill> Skills;

		public GameObject InfoPopup;

		[SerializeField]
		private float _snapSupportAmount;

		[SerializeField]
		private float _extendSizeAtCounter;

		[SerializeField]
		private float _extendSizeAtCounterTop;

		[SerializeField]
		private float _horizontalExtendSizeAtCounter;

		[SerializeField]
		private float _scaleColliderAtCounter;

		[SerializeField]
		private List<string> _tags;

		[Header("Effects")]
		[SerializeField]
		private GameObject _trailEffect;

		[SerializeField]
		private float _extraScaleOnPress;

		[SerializeField]
		private GameObject _mergeVfx;

		[SerializeField]
		private ParticleSystem _appearSmokeVfx;

		public AudioClip MergeSound;

		public MMF_Player AppearFeedback;

		public MMF_Player MergeFeedback;

		[SerializeField]
		private MMF_Player _nearbyPassiveSkillActivatedFeedback;

		[SerializeField]
		private MMF_Player _nearbyPassiveSkillActivatedOnDropFeedback;

		public MMF_Player SynercyBuffFeedback;

		public MMF_Player SynercyBuffedFeedback;

		public MMF_Player SynercyTriggerFeedback;

		public MMF_Player UpgradedFeedback;

		[Header("Border")]
		public SpriteRenderer SlotFill;

		public SpriteRenderer SlotBorder;

		[Header("Events")]
		public UnityEvent OnPlaced;

		public UnityEvent OnRemoved;

		public UnityEvent<bool> OnSelected;

		public UnityEvent OnDestroyed;

		[Header("Others")]
		[SerializeField]
		private GearState _state;

		public float LogGearPower;

		public GearState LastState;

		public Animator Selected;

		public GameObject Preview;

		public Gear MergeableGear;

		public bool JustMerged;

		public BoxCollider2D[] Collider2Ds;

		private Unit _owner;

		private GearData _gearData;

		private SimpleSkill _activeSkill;

		private Vector2Int[] _draggingGridPoints;

		private Vector2Int _diffGridPosition;

		private float _initialScale;

		private Vector3 _initialRendererScale;

		private Vector2 _supportSnappingOffset;

		private Vector3 _previewPosition;

		private List<ActiveSkillSwapData> _activeSkillSwapDatas;

		private List<SimpleSkill> _mergeableNextSkills;

		private SpriteAddressable _atkSpriteLoader;

		private PrefabAddressable _mergeVfxLoader;

		private SpriteAddressable _uiSpriteLoader;

		private int _ownerIdInList;

		public static Subject<Gear> OnNewGearAppear;

		private static readonly Dictionary<int, List<Gear>> _gearsByPlayer;

		public static Gear DraggingGear;

		private static Subject<bool> _invokeGearInteraction;

		public int BuffReceived;

		public Unit Owner
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public SimpleSkill ActiveSkill
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public GameObject TrailEffect => null;

		public GearState State => GearState.None;

		public bool InBag => false;

		public bool WasInBag => false;

		public bool InCounter => false;

		public bool WasInCounter => false;

		public bool InBench => false;

		public bool WasInBench => false;

		public bool IsDestroyed => false;

		public bool InDragging => false;

		public IStatHolder StatHolder { get; private set; }

		public GearData GearData
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int Id => 0;

		public int GroupId => 0;

		public string Name => null;

		public string Description => null;

		public Sprite Icon => null;

		public Rarity Rarity => Rarity.Common;

		public string SkillIconName => null;

		public GameObject MergeAppearVfx => null;

		public GearData MergeTo => null;

		public int Level => 0;

		public bool HasAtkSprite { get; private set; }

		public Sprite AtkSprite => null;

		public Sprite UiSprite => null;

		public float Power => 0f;

		public Transform Transform => null;

		public Vector2Int[] PlacementPoints => null;

		public Vector2Int[] DraggingGridPoints => null;

		public Vector2 Offset { get; set; }

		public DragDropHandler Draggable { get; private set; }

		public Vector2 SupportSnappingOffset => default;

		public bool Placeable { get; private set; }

		public List<string> Tags
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete]
		public List<float> Mods { get; private set; }

		public bool IsSelected { get; private set; }

		public Bag Bag { get; private set; }

		public static Subject<bool> InvokeGearInteraction => null;

		public void SetPlaceable(bool placeable)
		{
		}

		public void ToggleInteract(bool interactable)
		{
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private void OnDestroy()
		{
		}

		private void Update()
		{
		}

		private void LateUpdate()
		{
		}

		public void SetInteractable(bool interactable)
		{
		}

		public void PlaySmokeVfx()
		{
		}

		public void StartDrag()
		{
		}

		public void Dragging()
		{
		}

		private void PlacingCommon()
		{
		}

		private bool TryPlacingWithSupport()
		{
			return false;
		}

		private void PreviewSquares()
		{
		}

		private bool CheckPlaceable(out Vector2Int[] newDraggingPoints)
		{
			newDraggingPoints = null;
			return false;
		}

		private void PreviewRecycle()
		{
		}

		public void Drop()
		{
		}

		public void UpdateDraggingGridPoints()
		{
		}

		public void UpdateDraggingGridPoints(Vector2Int[] points)
		{
		}

		public void MoveDraggingPointsBy(Vector2Int v)
		{
		}

		public void MoveDraggingPointsTo(Vector2Int[] newPoints)
		{
		}

		public void ReceiveStats(params Gear[] gears)
		{
		}

		public void UpdateCollider(float colliderRefSize)
		{
		}

		void IBagGridItem.OnDrop()
		{
		}

		List<SimpleSkill> IBagGridItem.GetSkills()
		{
			return null;
		}

		public void CancelEffects()
		{
		}

		public Vector2Int GetGridAnchorPosition(Transform overrideContainer = null)
		{
			return default;
		}

		public void StartMovePosition()
		{
		}

		public void EndMovePosition()
		{
		}

		Transform ICounterItem.GetTranform()
		{
			return null;
		}

		float ICounterItem.GetWidth()
		{
			return 0f;
		}

		void ICounterItem.OnDrop()
		{
		}

		private void UpdateColliderEasyDragging()
		{
		}

		void IMergeableItem.SetMergeable(IMergeableItem item)
		{
		}

		public bool CanMerged(IMergeableItem other)
		{
			return false;
		}

		Transform IMergeableItem.GetTranform()
		{
			return null;
		}

		public void ActivateSkill()
		{
		}

		public void DeactiveSkill()
		{
		}

		public void Fade(float value, bool draggableEnabled)
		{
		}

		private void DoCancelWhenLeaveBagComponent(List<SimpleSkill> skills)
		{
		}

		public void FetchPassiveOnGridChanged(IReadOnlyDictionary<Vector2Int, IBagGridItem> gridMap, IReadOnlyDictionary<IBagGridItem, List<Vector2Int>> gearPlacementPoints)
		{
		}

		private void FetchPassiveOnGridChanged(List<SimpleSkill> skills, IReadOnlyDictionary<Vector2Int, IBagGridItem> gridMap, IReadOnlyDictionary<IBagGridItem, List<Vector2Int>> gearPlacementPoints)
		{
		}

		private void RemoveMergeableSkills()
		{
		}

		public void FeedbackIfAnyNearPassiveActivted(IBagGridItem gearNear)
		{
		}

		public void ShowPopupInfo()
		{
		}

		public void Upgrade(int value)
		{
		}

		private static void AddGearToList(Gear gear, int ownerId)
		{
		}

		private static void RemoveGearFromList(Gear gear)
		{
		}

		public static IReadOnlyList<Gear> GetGearsForPlayer(int playerId)
		{
			return null;
		}

		public static IReadOnlyList<Gear> GetAllGears()
		{
			return null;
		}

		public static void ClearGearsForPlayer(int playerId)
		{
		}

		public static int CountGearsById(int gearId)
		{
			return 0;
		}

		public static int CountGearsById(int gearId, int playerId)
		{
			return 0;
		}

		private void OnDrawGizmos()
		{
		}

		public void Swap(SkillData from, SkillData to)
		{
		}

		public void Revert(SkillData newData)
		{
		}

		private void RefreshActiveSkill(SkillData activeSkillData = null)
		{
		}

		public bool IsFloatable()
		{
			return false;
		}

		public bool IsWeapon()
		{
			return false;
		}

		public bool IsThrowType()
		{
			return false;
		}

		public AudioClip GetMergeSound()
		{
			return null;
		}

		public Vector3 GetSize()
		{
			return default;
		}

		public void SetSelectedActive(bool active)
		{
		}

		public void ShowBorder(bool show)
		{
		}

		public void ShowFill(bool show)
		{
		}

		public void SetMuzzle(Transform muzzle)
		{
		}

		public void SetState(GearState state)
		{
		}

		public List<float> GetBuffMods()
		{
			return null;
		}
	}
}
