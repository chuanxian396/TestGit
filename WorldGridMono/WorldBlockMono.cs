namespace WorldGridMono
{
    using Data;
    using SharedTypes;
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using UnityEngine;
    using WorldGridLogic;
    using WorldGridSharedTypes;

    public static class WorldBlockMono
    {
        private static Dictionary<int, BlockPartModelInfo> m_instanceIdToModelInfo;
        private const string PREFAB_PATH = "bundled_resources/autobuild/models/modules/";

        public static GameObject Create(PatternBlock patternBlock)
        {
        }

        public static GameObject Create(WorldBlock worldBlock)
        {
        }

        public static GameObject CreateGround(WorldBlock worldBlock)
        {
        }

        private static MetagameData.WorldBlockObject GetBlockPartPrefab(TerrainType terrain, BlockPartModelType modelType, BlockRotationType rotation, bool isActive)
        {
        }

        public static List<BlockPartModelInfo> GetBlockParts(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11, WorldBlockPart pFarT = null, WorldBlockPart pFarR = null)
        {
        }

        public static List<GroundPartModelInfo> GetGroundPart(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11)
        {
        }

        public static BlockPartModelInfo GetModelInfo(GameObject go)
        {
        }

        private static GameObject GetPatternPartPrefab(TerrainType terrain, BlockPartModelType modelType)
        {
        }

        private static BlockPartModelInfo.ShadowType GetQuad270Shadow(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11)
        {
        }

        private static BlockPartModelInfo.ShadowType GetQuad90Shadow(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11, WorldBlockPart pFarRight)
        {
        }

        private static BlockPartModelInfo.ShadowType GetQuadShadow(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11)
        {
        }

        private static BlockPartModelInfo.ShadowType GetShorts90Shadow(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11)
        {
        }

        private static BlockPartModelInfo.ShadowType GetShortsShadow(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11)
        {
        }

        private static BlockPartModelInfo.ShadowType GetX1_180Shadow(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11)
        {
        }

        private static BlockPartModelInfo.ShadowType GetX1_270Shadow(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11, WorldBlockPart pFarT)
        {
        }

        private static BlockPartModelInfo.ShadowType GetX1_90Shadow(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11, WorldBlockPart pFarRight)
        {
        }

        private static BlockPartModelInfo.ShadowType GetX1_Shadow(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11)
        {
        }

        private static BlockPartModelInfo.ShadowType GetX2_90Shadow(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11)
        {
        }

        private static BlockPartModelInfo.ShadowType GetX2Shadow(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11)
        {
        }

        private static BlockPartModelInfo.ShadowType GetX3_180Shadow(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11)
        {
        }

        private static BlockPartModelInfo.ShadowType GetX3_270Shadow(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11)
        {
        }

        private static BlockPartModelInfo.ShadowType GetX3_90Shadow(WorldBlockPart p00, WorldBlockPart p01, WorldBlockPart p10, WorldBlockPart p11)
        {
        }

        private static bool IsShadowed(WorldBlockPart part, WorldBlockPart otherPart)
        {
        }

        public static BlockRotationType Rotate180(BlockRotationType rotation)
        {
        }

        public static void SetUpdateMaterial(GameObject go, bool enabled)
        {
        }

        public static void Shutdown()
        {
        }
    }
}

