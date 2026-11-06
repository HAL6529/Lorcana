using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(InfiniteScroll))]
public class EditCardPanelControllerLimited : UIBehaviour, IInfiniteScrollSetup
{
    [SerializeField] private EditCardPanelManager m_EditCardPanelManager;
    [SerializeField, Range(1, 999)]
    private int max = 30;

    public void OnPostSetupItems()
    {
        var infiniteScroll = GetComponent<InfiniteScroll>();
        infiniteScroll.onUpdateItem.AddListener(OnUpdateItem);
        GetComponentInParent<ScrollRect>().movementType = ScrollRect.MovementType.Elastic;

        var rectTransform = GetComponent<RectTransform>();
        var delta = rectTransform.sizeDelta;
        delta.y = infiniteScroll.itemScale * max;
        rectTransform.sizeDelta = delta;
        m_EditCardPanelManager.LoadDeckList();
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

            var item = obj.GetComponentInChildren<EditCardPanel>();
            EditCardPanelTemp m_EditCardPanelTemp = m_EditCardPanelManager.GetEditCardPanelTemp(itemCount);
            item.SetEditCardPanel(m_EditCardPanelTemp.GetCardInfo(), m_EditCardPanelTemp.GetCardCount(), m_EditCardPanelTemp.GetIndex());
        }
    }
}
