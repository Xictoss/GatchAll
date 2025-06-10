using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GatchAll
{
    [System.Serializable]
    public class Item
    {
        [field: SerializeField] public ItemData Data { get; private set; }
        [field: SerializeField] public float Float { get; private set; }
        
        //Constructor for Items
        public Item(ItemData data)
        {
            Data = data;
            Float = (float)Math.Round(Random.Range(0f, 1f), 4);
        }

        
        
    }
}