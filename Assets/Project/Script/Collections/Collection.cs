using System;
using TMPro;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GatchAll.Project.Script.Collections
{
    public class Collection : MonoBehaviour
    {
        [field: SerializeField] public CollectionData Data { get; private set; }
        [field: SerializeField] public KeyCode Key { get; private set; }
        [field: SerializeField] public Transform DebugTransform { get; private set; }
        [field: SerializeField] public GameObject DebugGO { get; private set; }
        [field: SerializeField] public TextMeshProUGUI Text { get; private set; }

        private Item currentUnboxedItem;

        public void GetUnboxedItemData()
        {
            ItemData itemData = Data.ItemDatas[Random.Range(0, Data.ItemDatas.Count)];
            currentUnboxedItem = itemData.GetItem();
            Text.text = $"item unlocked: {currentUnboxedItem.Data.Name} Float: {currentUnboxedItem.Float} Description : {currentUnboxedItem.Data.Description}";
        }

        
        /*Debug pour spawn les trucs
        private void Update()
        {
            if (Input.GetKeyDown(Key))
            {
                GetUnboxedItemData();
                if (currentUnboxedItem.Data.itemPrefab == null)
                {
                    Debug.LogWarning("No item prefab found!");
                }
                
                if (DebugGO != null)
                {
                    Destroy(DebugGO);
                    DebugGO = null;
                }
                if (currentUnboxedItem.Data.itemPrefab != null && DebugTransform != null)
                {
                    DebugGO = Instantiate(currentUnboxedItem.Data.itemPrefab, DebugTransform.position, Quaternion.identity);
                    Debug.Log("Item Prefab found!");

                }
                
                if (currentUnboxedItem != null)
                {
                    Debug.Log($"item unlocked: {currentUnboxedItem.Data.Name} with" + 
                              $" a float value of {currentUnboxedItem.Float} and a description of {currentUnboxedItem.Data.Description}" );
                }
            }
            Fin debug pour spawn les trucs*/

        }
    }