using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InfiniteScrollForMenu))]
public class MenuControllerLimited : UIBehaviour, IInfiniteScrollSetup
{
    [SerializeField] private Menu_Menu m_Menu_Menu;
    [SerializeField, Range(1, 9999)]
    private int max = 30;

    public void OnPostSetupItems()
    {
        var InfiniteScrollForMenu = GetComponent<InfiniteScrollForMenu>();
        InfiniteScrollForMenu.onUpdateItem.AddListener(OnUpdateItem);
        GetComponentInParent<ScrollRect>().movementType = ScrollRect.MovementType.Elastic;

        var rectTransform = GetComponent<RectTransform>();
        var delta = rectTransform.sizeDelta;
        delta.y = InfiniteScrollForMenu.itemScale * m_Menu_Menu.GetSaveDataListCount();
        rectTransform.sizeDelta = delta;
        m_Menu_Menu.Load();
    }

    public void OnUpdateItem(int itemCount, GameObject obj)
    {
        if (itemCount < 0 || itemCount >= max)
        {
            obj.SetActive(false);
        }
        else
        {
            obj.SetActive(true);

            var item = obj.GetComponentInChildren<Menu_SelectDeckPanel>();
            SaveData sd = m_Menu_Menu.GetSaveDataList(itemCount);
            item.SetSaveData(sd);
        }
    }
}
