namespace WorldGridMono
{
    using Common.Logger;
    using System;
    using System.Runtime.CompilerServices;
    using UnityEngine;
    using WorldGridSharedTypes;

    public class ActiveBlockMono
    {
        private static readonly Common.Logger.Logger _log;
        [CompilerGenerated]
        private static Action<Transform> <>f__am$cache1D;
        private static readonly float APPEARANCE_DURATION;
        private static readonly Vector3 BLOCK_COLLIDER_SIZE;
        private static readonly Vector3 BLOCK_POSITION;
        private static readonly Vector3 BLOCK_ROTATION;
        private static readonly float DISAPPEARANCE_DURATION;
        private IGridItem m_block;
        private GameObject m_blockMono;
        private Camera m_camera;
        private MetagameHUDBlockController m_cameraBlock;
        private MetagameHUDBlockController m_cameraPreviousBlock;
        private BlockRotationType m_currentRotation;
        private bool m_dragged;
        private GameObject m_draggedPhantom;
        private bool m_enabled;
        private WorldGridSharedTypes.EventSystem m_events;
        private GridItemPos? m_gridPos;
        private RaycastHit m_hit;
        private Predicate<GridItemPos> m_isPosAvailable;
        private IGridItem m_nextBlock;
        private Ray m_ray;
        private bool m_repick;
        private bool m_setOnGrid;
        private Material m_sharedMaterial;
        private ActiveBlockState m_state;
        private GameObject m_staticPhantom;
        private float m_timer;
        private Camera m_uiCamera;
        private bool m_visible;
        private const string SHADER_NAME = "Custom/meshEffect_repick_block";

        private void AddMeshColliderToCameraBlock()
        {
        }

        private void CreateDraggedPhantomEffect(bool oneStepToClose)
        {
        }

        public void CreateMono(bool repick)
        {
        }

        private void CreateStaticPhantom(GridItemPos pos, bool isOneStepToClose)
        {
        }

        public void HideWorldBlock()
        {
        }

        private bool IsCameraNull()
        {
        }

        private void OnAppear()
        {
        }

        private void OnDissapear()
        {
        }

        private void OnPhantomVisibleChanged(bool isVisible, GridItemPos pos)
        {
        }

        public void OnShutdown()
        {
        }

        public void PlaceWorldBlock()
        {
        }

        private void RemoveStaticPhantomEffect(RemovePhantomMode mode)
        {
        }

        public bool Rotate(BlockRotationType rotation)
        {
        }

        public bool SetBlock(IGridItem block, bool isRepick)
        {
        }

        private void SetDragged(bool value)
        {
        }

        public void SetDraggedPhantom(GridItemPos pos, bool oneStepToClose)
        {
        }

        private void SetEnable(bool enabled)
        {
        }

        public void SetFreeDragging()
        {
        }

        public void SetStaticPhantom(GridItemPos pos, bool isOneStepToClose)
        {
        }

        private void SetVisible(bool value)
        {
        }

        public void Update()
        {
        }

        public bool Enabled
        {
            get
            {
            }
            set
            {
            }
        }

        public IEventSystem EventSystem
        {
            get
            {
            }
        }

        public bool HasValue
        {
            get
            {
            }
        }

        public bool IsDragged
        {
            get
            {
            }
            set
            {
            }
        }

        public Predicate<GridItemPos> IsPosAvailable
        {
            get
            {
            }
            set
            {
            }
        }

        public ActiveBlockState State
        {
            get
            {
            }
        }

        public bool Visible
        {
            get
            {
            }
            set
            {
            }
        }

        public enum ActiveBlockState
        {
            Idle,
            Disappearing,
            Appearing
        }

        public enum RemovePhantomMode
        {
            DISAPPEAR,
            MOVE,
            APPLY
        }
    }
}

