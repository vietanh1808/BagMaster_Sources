using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using MoreMountains.Feedbacks;
using UnityEngine;

namespace Game.Combat
{
	public class GearSynercyEffectManager : MonoBehaviour
	{
		private class EffectData
		{
			public Vector3 FromPosition;

			public Vector3 ToPosition;

			public GameObject Source;

			public string FloatingText;
		}

		[CompilerGenerated]
		private sealed class _003C_003Ec__DisplayClass12_0
		{
			public GearSynercyEffectManager _003C_003E4__this;

			public Vector3 to;

			public GameObject vfx;

			internal void _003CCreateSelfSynercyVfx_003Eb__0()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CCreateSelfSynercyVfx_003Ed__12 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GearSynercyEffectManager _003C_003E4__this;

			public Vector3 to;

			public float timeScale;

			private _003C_003Ec__DisplayClass12_0 _003C_003E8__1;

			public Vector3 from;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CCreateSelfSynercyVfx_003Ed__12(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CPlayFeedbackStarDrop_003Ed__13 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GearSynercyEffectManager _003C_003E4__this;

			public float timeScale;

			public MMF_Player mmFeedback;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CPlayFeedbackStarDrop_003Ed__13(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CRunEffects_003Ed__5 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GearSynercyEffectManager _003C_003E4__this;

			public IReadOnlyCollection<BagSynercyMap.Data> synercyData;

			public IBagGridItem mainItem;

			public bool sequenceOther;

			public MMF_Player mmFeedback;

			public float timeScale;

			private List<EffectData> _003CmainBuffSelf_003E5__2;

			private List<EffectData> _003CmainEffectOthers_003E5__3;

			private List<EffectData> _003CmainReceiveFromOthers_003E5__4;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CRunEffects_003Ed__5(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowEffectBuffOtherInParallel_003Ed__9 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GearSynercyEffectManager _003C_003E4__this;

			public MMF_Player mmFeedback;

			public List<EffectData> datas;

			public float timeScale;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowEffectBuffOtherInParallel_003Ed__9(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowEffectBuffOtherInSequence_003Ed__8 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public List<EffectData> datas;

			public GearSynercyEffectManager _003C_003E4__this;

			public float timeScale;

			public MMF_Player mmFeedback;

			private List<EffectData>.Enumerator _003C_003E7__wrap1;

			private EffectData _003Cdata_003E5__3;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowEffectBuffOtherInSequence_003Ed__8(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			private void _003C_003Em__Finally1()
			{
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CShowEffectBuffOthers_003Ed__7 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public List<EffectData> datas;

			public bool sequence;

			public GearSynercyEffectManager _003C_003E4__this;

			public MMF_Player mmFeedback;

			public float timeScale;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CShowEffectBuffOthers_003Ed__7(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[CompilerGenerated]
		private sealed class _003CThrowSynercyVfx_003Ed__10 : IEnumerator<object>, IEnumerator, IDisposable
		{
			private int _003C_003E1__state;

			private object _003C_003E2__current;

			public GearSynercyEffectManager _003C_003E4__this;

			public Vector3 to;

			public Vector3 from;

			public float timeScale;

			public Action onEnd;

			object IEnumerator<object>.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			object IEnumerator.Current
			{
				[DebuggerHidden]
				get
				{
					return null;
				}
			}

			[DebuggerHidden]
			public _003CThrowSynercyVfx_003Ed__10(int _003C_003E1__state)
			{
			}

			[DebuggerHidden]
			void IDisposable.Dispose()
			{
			}

			private bool MoveNext()
			{
				return false;
			}

			bool IEnumerator.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				return this.MoveNext();
			}

			[DebuggerHidden]
			void IEnumerator.Reset()
			{
			}
		}

		[SerializeField]
		private GearSynercyEffectProfile _profile;

		private List<GameObject> _cacheVfxs;

		private void OnDestroy()
		{
		}

		public void PlayEffects(IBagGridItem mainItem, IReadOnlyCollection<BagSynercyMap.Data> synercyData, bool sequenceOther, MMF_Player mmFeedback, float timeScale = 1f)
		{
		}

		[IteratorStateMachine(typeof(_003CRunEffects_003Ed__5))]
		public IEnumerator RunEffects(IBagGridItem mainItem, IReadOnlyCollection<BagSynercyMap.Data> synercyData, bool sequenceOther, MMF_Player mmFeedback, float timeScale = 1f)
		{
			return null;
		}

		private void FilterEffectDatas(IReadOnlyCollection<BagSynercyMap.Data> source, IBagGridItem mainItem, List<EffectData> mainBuffOthers, List<EffectData> mainBuffSelf, List<EffectData> mainEffectOthers, List<EffectData> mainReceiveFromOthers)
		{
		}

		[IteratorStateMachine(typeof(_003CShowEffectBuffOthers_003Ed__7))]
		private IEnumerator ShowEffectBuffOthers(List<EffectData> datas, bool sequence, MMF_Player mmFeedback, float timeScale)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CShowEffectBuffOtherInSequence_003Ed__8))]
		private IEnumerator ShowEffectBuffOtherInSequence(List<EffectData> datas, MMF_Player mmFeedback, float timeScale)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CShowEffectBuffOtherInParallel_003Ed__9))]
		private IEnumerator ShowEffectBuffOtherInParallel(List<EffectData> datas, MMF_Player mmFeedback, float timeScale)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CThrowSynercyVfx_003Ed__10))]
		private IEnumerator ThrowSynercyVfx(Vector3 from, Vector3 to, float timeScale = 1f, Action onEnd = null)
		{
			return null;
		}

		private void ShowEffectBuffSelf(List<EffectData> datas, float timeScale)
		{
		}

		[IteratorStateMachine(typeof(_003CCreateSelfSynercyVfx_003Ed__12))]
		private IEnumerator CreateSelfSynercyVfx(Vector3 from, Vector3 to, float timeScale = 1f)
		{
			return null;
		}

		[IteratorStateMachine(typeof(_003CPlayFeedbackStarDrop_003Ed__13))]
		private IEnumerator PlayFeedbackStarDrop(MMF_Player mmFeedback, float timeScale)
		{
			return null;
		}

		private void ShowSynercyBuffText(string content, Vector3 position, GameObject source, MMF_Player mmFeedback)
		{
		}

		private void ClearEffects()
		{
		}
	}
}
