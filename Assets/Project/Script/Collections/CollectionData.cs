using System.Collections.Generic;
using UnityEngine;

namespace GatchAll.Project.Script.Collections
{
    [CreateAssetMenu(fileName = "CollectionData", menuName = "Datas/CollectionData")]

    public class CollectionData : ScriptableObject
    {
        [field: SerializeField] public string Name { get; private set; }
        [field: SerializeField] public string Description { get; private set; }
        [field: SerializeField] public List<ItemData> ItemDatas { get; private set; }
    }
}