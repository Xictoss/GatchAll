using System;
using System.Linq;
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
        private float chancePercent;
        
        public void OpenCollection()
        {
            ItemData selected = GetRandomItem();
            currentUnboxedItem = selected.GetItem();
            Text.text = $"🎯 Item tiré : {selected.name} chance : {Math.Round(chancePercent), 2}%";
        }

        private ItemData GetRandomItem()
        {
            float totalWeight = 0f;
            foreach (ItemData item in Data.ItemDatas) 
                totalWeight += item.Weight;

            float roll = Random.Range(0f, totalWeight);
            Debug.Log(roll);
            float cumulative = 0f;

            foreach (ItemData item in Data.ItemDatas)
            { 
                chancePercent = (item.Weight / totalWeight) * 100f;
                cumulative += item.Weight;
                if (roll < cumulative)
                    return item;
            }

            Debug.LogWarning("❌ Aucun item sélectionné !");
            return Data.ItemDatas.Last();
        }
    }
}