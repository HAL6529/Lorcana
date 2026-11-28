using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewModeItemManager : MonoBehaviour
{
    [SerializeField] private RectTransform parent_1;
    [SerializeField] private RectTransform Image_1;
    [SerializeField] private RectTransform countImage_1;
    [SerializeField] private Text t_count_1;
    [SerializeField] private RectTransform Image_2;
    [SerializeField] private RectTransform countImage_2;
    [SerializeField] private Text t_count_2;
    [SerializeField] private RectTransform Image_3;
    [SerializeField] private RectTransform countImage_3;
    [SerializeField] private Text t_count_3;
    [SerializeField] private RectTransform Image_4;
    [SerializeField] private RectTransform countImage_4;
    [SerializeField] private Text t_count_4;
    [SerializeField] private RectTransform Image_5;
    [SerializeField] private RectTransform countImage_5;
    [SerializeField] private Text t_count_5;
    [SerializeField] private RectTransform CanvasRectTransform;

    [SerializeField] private ViewMode m_ViewMode;
    [SerializeField] private EditCardPanelManager m_EditCardPanelManager;
    [SerializeField] private Menu_ConvertSpriteFromCardNo m_Menu_ConvertSpriteFromCardNo;
    [SerializeField] private List<ViewMode_Image> m_ViewMode_ImageList = new List<ViewMode_Image>();

    public void Start()
    {
        UpdateImage(CanvasRectTransform.sizeDelta.x / 890, CanvasRectTransform.sizeDelta.y / 1920);
    }

    public void UpdateDeckList(int itemCount)
    {
        int count = m_ViewMode.m_GetMytEditCardPanelTempList.Count;
        if (count + 5 <= 5 * (itemCount + 1))
        {
            this.gameObject.SetActive(false);
            return;
        }

        int index = 5 * itemCount;
        this.gameObject.SetActive(true);
        for (int i = 0; i < 5; i++)
        {
            if (index + i > count - 1)
            {
                m_ViewMode_ImageList[i].SetImage(null, 0);
                continue;
            }
            Sprite s = m_Menu_ConvertSpriteFromCardNo.ConvertSpriteFromCardNo(m_ViewMode.m_GetMytEditCardPanelTempList[index + i].GetCardInfo().GetCardNo());
            int c = m_ViewMode.m_GetMytEditCardPanelTempList[index + i].GetCardCount();
            m_ViewMode_ImageList[i].SetImage(s, c);
        }
        return;
    }

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        float magnification = magnification_x;
        if (magnification_x > magnification_y)
        {
            magnification = magnification_y;
        }
        parent_1.sizeDelta = new Vector2(parent_1.sizeDelta.x * magnification, parent_1.sizeDelta.y * magnification);
        Image_1.sizeDelta = new Vector2(Image_1.sizeDelta.x * magnification, Image_1.sizeDelta.y * magnification);
        countImage_1.sizeDelta = new Vector2(countImage_1.sizeDelta.x * magnification, countImage_1.sizeDelta.y * magnification);
        t_count_1.fontSize = (int)(t_count_1.fontSize * magnification);

        Image_2.sizeDelta = new Vector2(Image_2.sizeDelta.x * magnification, Image_2.sizeDelta.y * magnification);
        countImage_2.sizeDelta = new Vector2(countImage_2.sizeDelta.x * magnification, countImage_2.sizeDelta.y * magnification);
        t_count_2.fontSize = (int)(t_count_2.fontSize * magnification);

        Image_3.sizeDelta = new Vector2(Image_3.sizeDelta.x * magnification, Image_3.sizeDelta.y * magnification);
        countImage_3.sizeDelta = new Vector2(countImage_3.sizeDelta.x * magnification, countImage_3.sizeDelta.y * magnification);
        t_count_3.fontSize = (int)(t_count_3.fontSize * magnification);

        Image_4.sizeDelta = new Vector2(Image_4.sizeDelta.x * magnification, Image_4.sizeDelta.y * magnification);
        countImage_4.sizeDelta = new Vector2(countImage_4.sizeDelta.x * magnification, countImage_4.sizeDelta.y * magnification);
        t_count_4.fontSize = (int)(t_count_4.fontSize * magnification);

        Image_5.sizeDelta = new Vector2(Image_5.sizeDelta.x * magnification, Image_5.sizeDelta.y * magnification);
        countImage_5.sizeDelta = new Vector2(countImage_5.sizeDelta.x * magnification, countImage_5.sizeDelta.y * magnification);
        t_count_5.fontSize = (int)(t_count_5.fontSize * magnification);

        /*Vector2 left_position = new Vector2(0, 1);
        parent_1.anchorMin = left_position;
        parent_1.anchorMax = left_position;
        parent_1.pivot = left_position;
        parent_1.anchoredPosition = Vector2.zero;*/
    }
}
