using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InfiniteScrollForViewMode))]
public class ViewModeItemControllerLimited : UIBehaviour, IInfiniteScrollSetup
{
    [SerializeField] private ViewModeItemManager m_ViewModeItemManager;
    [SerializeField] private EditCardPanelManager m_EditCardPanelManager;
    [SerializeField] private ViewMode m_ViewMode;

    [SerializeField, Range(1, 9999)]
    private int max = 30;

    public void OnPostSetupItems()
    {
        var InfiniteScrollForViewMode = GetComponent<InfiniteScrollForViewMode>();
        InfiniteScrollForViewMode.onUpdateItem.AddListener(OnUpdateItem);
        GetComponentInParent<ScrollRect>().movementType = ScrollRect.MovementType.Elastic;

        var rectTransform = GetComponent<RectTransform>();
        var delta = rectTransform.sizeDelta;
        int c_size = 0;
        if (m_ViewMode.m_GetMytEditCardPanelTempList.Count > 0)
        {
            if (m_ViewMode.m_GetMytEditCardPanelTempList.Count % 5 > 0)
            {

                c_size = (int)(Math.Truncate((double)m_ViewMode.m_GetMytEditCardPanelTempList.Count / 5) + 1);
            }
            else
            {
                c_size = (int)(Math.Truncate((double)m_ViewMode.m_GetMytEditCardPanelTempList.Count / 5));
            }

        }
        delta.y = InfiniteScrollForViewMode.itemScale * c_size;
        rectTransform.sizeDelta = delta;
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

            var item = obj.GetComponentInChildren<ViewModeItemManager>();
            item.UpdateDeckList(itemCount);
        }
    }
}
