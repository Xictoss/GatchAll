using UnityEngine;

namespace GatchAll
{
    [CreateAssetMenu(fileName = "ItemData", menuName = "Datas/ItemData")]
    public class ItemData : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public string Description { get; private set; }
        
        
        [field: SerializeField] public GameObject itemPrefab { get; private set; }

        public Item GetItem()
        {
            Item item = new Item(this);
            return item;
        }
        
    }
}
