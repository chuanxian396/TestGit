namespace WorldGridMono
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using UnityEngine;

    public static class MonoGridItem
    {
        private static Dictionary<string, UnityEngine.Object> LoadedPrefabs;

        public static void DestroyOrPool(GameObject objForDestroy)
        {
        }

        public static bool SetShader(GameObject block, string shaderName)
        {
        }

        public static bool TryToInstantiate(string prefabName, out GameObject obj)
        {
        }

        public static bool TryToInstantiate(GameObject prefab, out GameObject obj)
        {
        }

        public static bool TryToInstantiate<T>(T prefab, out T obj) where T: Component
        {
        }

        public static bool TryToInstantiate(string prefabName, Vector3 position, Quaternion rotation, out GameObject obj)
        {
        }

        public static bool TryToInstantiate(GameObject prefab, Vector3 position, Quaternion rotation, out GameObject obj)
        {
        }

        public static bool TryToInstantiate<T>(T prefab, Vector3 pos, Quaternion rot, out T obj) where T: Component
        {
        }

        [CompilerGenerated]
        private sealed class <SetShader>c__AnonStorey149
        {
            internal string shaderName;

            internal void <>m__236(Renderer rend)
            {
            }
        }
    }
}

