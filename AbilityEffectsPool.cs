using Render;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class AbilityEffectsPool : MonoBehaviour
{
    private bool ENABLED_POOLING;
    private AssetGPUPreloader m_gpuPreloader;
    private static Dictionary<int, bool> m_pooledIdsChecked;
    private static Dictionary<string, PoolItem> m_pooledItems;
    private static Dictionary<string, GameObject> m_prefabsLoaded;
    private const int MAX_ITEMS = 1;
    private bool POOLING_LIST_FROM_BATTLE_START;
    private bool SILENT_MODE;
    private static bool USE_SIMPLE_ACTIVE;
    public string[] usedItems;

    public GameObject CreateFromPool(string name, Vector3 position, Quaternion rotation)
    {
    }

    public void DebugCheckPoolConsistency()
    {
    }

    public void EvictLoadedObjects(bool forceAll = false)
    {
    }

    private GameObject InstantiateItem(string itemName)
    {
    }

    public void Preload(string[] effectList)
    {
    }

    public void PrepareForLanding(GameObject toPool)
    {
    }

    public void PrepareForTakeOff(GameObject fromPool)
    {
    }

    public void ReturnToPool(GameObject creature)
    {
    }

    private static void SetActive(GameObject forObject, bool active)
    {
    }

    private void Start()
    {
    }

    private void Update()
    {
    }

    private class PoolItem
    {
        public LinkedList<GameObject> itemList;
        public Vector3 scaleForInstance;
    }
}

