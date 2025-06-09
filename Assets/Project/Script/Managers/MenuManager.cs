using GatchAll.Project.Script.Collections;
using LTX.Singletons;
using TMPro;
using UnityEngine;

namespace GatchAll.Project.Script.Managers
{
    public class MenuManager : MonoSingleton<MenuManager>
    {
        [SerializeField] private GameObject CollectionMenu1;
        [SerializeField] private GameObject CollectionMenu2;
        [SerializeField] private GameObject Menu;
        [SerializeField] private TextMeshProUGUI ItemText1;
        [SerializeField] private TextMeshProUGUI ItemText2;
        
        [field: SerializeField] public Collection Collection1 { get; private set; }
        [field: SerializeField] public Collection Collection2 { get; private set; }


        public void OpenCollectionMenu1()
        {
            Menu.SetActive(false);
            CollectionMenu1.SetActive(true);
        }
        
        
        public void OpenCollectionMenu2()
        {
            Menu.SetActive(false);

            CollectionMenu2.SetActive(true);
        }

        public void CloseCollectionMenu1()
        {
            Menu.SetActive(true);

            CollectionMenu1.SetActive(false);
        }
        
        public void CloseCollectionMenu2()
        {
            Menu.SetActive(true);

            CollectionMenu2.SetActive(false);
        }

        public void OpenCaseCollection1()
        {
            Collection1.GetUnboxedItemData();
            ItemText1.text = Collection1.Text.text;
        }
        
        public void OpenCaseCollection2()
        {
            Collection2.GetUnboxedItemData();
            ItemText2.text = Collection2.Text.text;
        }
        
    }
}