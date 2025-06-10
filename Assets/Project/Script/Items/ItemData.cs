using UnityEngine;
using UnityEngine.UI;

namespace GatchAll
{
    [CreateAssetMenu(fileName = "ItemData", menuName = "Datas/ItemData")]
    public class ItemData : ScriptableObject
    {
        [Header("Item Data")]
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public string Description { get; private set; }
        
        [Header("Item Rarity")]
        [field: SerializeField] public string Rarity { get; private set; }
        [field: SerializeField] public float Weight { get; private set; }
        
        [Header("Item Prefab")]
        [field: SerializeField] public GameObject itemPrefab { get; private set; }

        public Item GetItem()
        {
            Item item = new Item(this);
            return item;
        }
        
    }
}
