using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ViewMode : MonoBehaviour
{
    public EditCardPanelManager m_EditCardPanelManager;
    public List<Image> deckImageList = new List<Image>();
    public GameObject DeckName;
    public Text DeckNameText;
    public Image FavoriteCard;

    public RectTransform Parent;
    public RectTransform header;
    public RectTransform header_Image_Parent;
    public RectTransform header_Image;
    public RectTransform header_header;
    public RectTransform header_header_line1;
    public RectTransform header_header_line1_closeBtn;
    public RectTransform header_header_line2;
    public RectTransform header_header_line3;
    public RectTransform header_header_line4;
    public RectTransform hand;
    public RectTransform hand_line1;
    public List<RectTransform> hand_line1_list = new List<RectTransform>();
    public RectTransform hand_line2;
    public RectTransform hand_line2_firstDrawBtn;
    public RectTransform hand_line2_oneDrawBtn;
    public RectTransform hand_line3;
    public List<RectTransform> hand_line3_list = new List<RectTransform>();
    public RectTransform scrollView;
    public RectTransform scrollView_line1;
    public RectTransform scrollView_line2;
    public RectTransform scrollView_line3;
    public RectTransform scrollView_line4;
    public RectTransform scrollView_line5;
    public RectTransform scrollView_line6;
    public RectTransform scrollView_line7;
    public RectTransform scrollView_line8;
    public RectTransform scrollView_line9;
    public RectTransform scrollView_line10;
    public RectTransform scrollView_line11;
    public RectTransform scrollView_line12;
    public RectTransform scrollView_line13;
    public List<RectTransform> scrollView_line1_list = new List<RectTransform>();
    public List<RectTransform> scrollView_line2_list = new List<RectTransform>();
    public List<RectTransform> scrollView_line3_list = new List<RectTransform>();
    public List<RectTransform> scrollView_line4_list = new List<RectTransform>();
    public List<RectTransform> scrollView_line5_list = new List<RectTransform>();
    public List<RectTransform> scrollView_line6_list = new List<RectTransform>();
    public List<RectTransform> scrollView_line7_list = new List<RectTransform>();
    public List<RectTransform> scrollView_line8_list = new List<RectTransform>();
    public List<RectTransform> scrollView_line9_list = new List<RectTransform>();
    public List<RectTransform> scrollView_line10_list = new List<RectTransform>();
    public List<RectTransform> scrollView_line11_list = new List<RectTransform>();
    public List<RectTransform> scrollView_line12_list = new List<RectTransform>();
    public List<RectTransform> scrollView_line13_list = new List<RectTransform>();

    public SaveDataStatic m_SaveDataStatic = new SaveDataStatic();
    private ExtendUtil m_ExtendUtil = new ExtendUtil();
    public Menu_ConvertSpriteFromCardNo m_Menu_ConvertSpriteFromCardNo;

    public void Open()
    {
        this.gameObject.SetActive(true);
        UpdateDeckName();
        UpdateDeckList();
        FavoriteCard.sprite = m_Menu_ConvertSpriteFromCardNo.ConvertSpriteFromCardNo(m_SaveDataStatic.GetFavoriteCardInfo().GetCardNo());
    }

    public void UpdateDeckList()
    {
        List<CardInfo> DeckList = m_EditCardPanelManager.DeckList;
        for (int i = 0; i < deckImageList.Count; i++)
        {
            if(i < DeckList.Count)
            {
                deckImageList[i].sprite = DeckList[i].m_sprite;
                deckImageList[i].color = new Color(1, 1, 1, 1);
            }
            else
            {
                deckImageList[i].sprite = null;
                deckImageList[i].color = new Color(0, 0, 0, 0);
            }
        }
    }

    private void UpdateDeckName()
    {
        if(m_EditCardPanelManager.DeckName == "")
        {
            DeckNameText.text = "--–¼‘O‚È‚µ--";
        }
        else
        {
            DeckNameText.text = m_EditCardPanelManager.DeckName;
        }
    }

    public void onCloseBtn()
    {
        this.gameObject.SetActive(false);
    }

    public void onEditDeckNameBtn()
    {
        DeckName.SetActive(true);
    }

    public void onDeckName_CloseBtn()
    {
        DeckName.SetActive(false);
    }

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        Parent.sizeDelta = new Vector2(Parent.sizeDelta.x * magnification_x, Parent.sizeDelta.y * magnification_y);
        header.sizeDelta = new Vector2(header.sizeDelta.x * magnification_x, header.sizeDelta.y * magnification_y);
        header_Image_Parent.sizeDelta = new Vector2(header_Image_Parent.sizeDelta.x * magnification_x, header_Image_Parent.sizeDelta.y * magnification_y);
        header_header.sizeDelta = new Vector2(header_header.sizeDelta.x * magnification_x, header_header.sizeDelta.y * magnification_y);
        header_header_line1.sizeDelta = new Vector2(header_header_line1.sizeDelta.x * magnification_x, header_header_line1.sizeDelta.y * magnification_y);
        header_header_line2.sizeDelta = new Vector2(header_header_line2.sizeDelta.x * magnification_x, header_header_line2.sizeDelta.y * magnification_y);
        header_header_line3.sizeDelta = new Vector2(header_header_line3.sizeDelta.x * magnification_x, header_header_line3.sizeDelta.y * magnification_y);
        header_header_line4.sizeDelta = new Vector2(header_header_line4.sizeDelta.x * magnification_x, header_header_line4.sizeDelta.y * magnification_y);
        hand.sizeDelta = new Vector2(hand.sizeDelta.x * magnification_x, hand.sizeDelta.y * magnification_y);
        hand_line1.sizeDelta = new Vector2(hand_line1.sizeDelta.x * magnification_x, hand_line1.sizeDelta.y * magnification_y);
        hand_line2.sizeDelta = new Vector2(hand_line2.sizeDelta.x * magnification_x, hand_line2.sizeDelta.y * magnification_y);
        hand_line2_firstDrawBtn.sizeDelta = new Vector2(hand_line2_firstDrawBtn.sizeDelta.x * magnification_x, hand_line2_firstDrawBtn.sizeDelta.y * magnification_y);
        hand_line2_oneDrawBtn.sizeDelta = new Vector2(hand_line2_oneDrawBtn.sizeDelta.x * magnification_x, hand_line2_oneDrawBtn.sizeDelta.y * magnification_y);
        hand_line3.sizeDelta = new Vector2(hand_line3.sizeDelta.x * magnification_x, hand_line3.sizeDelta.y * magnification_y);

        float magnification = magnification_x;
        if (magnification_x > magnification_y)
        {
            magnification = magnification_y;
        }
        header_Image.sizeDelta = new Vector2(header_Image.sizeDelta.x * magnification, header_Image.sizeDelta.y * magnification);
        header_header_line1_closeBtn.sizeDelta = new Vector2(header_header_line1_closeBtn.sizeDelta.x * magnification, header_header_line1_closeBtn.sizeDelta.y * magnification);
        scrollView.sizeDelta = new Vector2(scrollView.sizeDelta.x * magnification, scrollView.sizeDelta.y * magnification);
        scrollView_line1.sizeDelta = new Vector2(scrollView_line1.sizeDelta.x * magnification, scrollView_line1.sizeDelta.y * magnification);
        scrollView_line2.sizeDelta = new Vector2(scrollView_line2.sizeDelta.x * magnification, scrollView_line2.sizeDelta.y * magnification);
        scrollView_line3.sizeDelta = new Vector2(scrollView_line3.sizeDelta.x * magnification, scrollView_line3.sizeDelta.y * magnification);
        scrollView_line4.sizeDelta = new Vector2(scrollView_line4.sizeDelta.x * magnification, scrollView_line4.sizeDelta.y * magnification);
        scrollView_line5.sizeDelta = new Vector2(scrollView_line5.sizeDelta.x * magnification, scrollView_line5.sizeDelta.y * magnification);
        scrollView_line6.sizeDelta = new Vector2(scrollView_line6.sizeDelta.x * magnification, scrollView_line6.sizeDelta.y * magnification);
        scrollView_line7.sizeDelta = new Vector2(scrollView_line7.sizeDelta.x * magnification, scrollView_line7.sizeDelta.y * magnification);
        scrollView_line8.sizeDelta = new Vector2(scrollView_line8.sizeDelta.x * magnification, scrollView_line8.sizeDelta.y * magnification);
        scrollView_line9.sizeDelta = new Vector2(scrollView_line9.sizeDelta.x * magnification, scrollView_line9.sizeDelta.y * magnification);
        scrollView_line10.sizeDelta = new Vector2(scrollView_line10.sizeDelta.x * magnification, scrollView_line10.sizeDelta.y * magnification);
        scrollView_line11.sizeDelta = new Vector2(scrollView_line11.sizeDelta.x * magnification, scrollView_line11.sizeDelta.y * magnification);
        scrollView_line12.sizeDelta = new Vector2(scrollView_line12.sizeDelta.x * magnification, scrollView_line12.sizeDelta.y * magnification);
        scrollView_line13.sizeDelta = new Vector2(scrollView_line13.sizeDelta.x * magnification, scrollView_line13.sizeDelta.y * magnification);

        for (int i = 0; i < hand_line1_list.Count; i++)
        {
            hand_line1_list[i].sizeDelta = new Vector2(hand_line1_list[i].sizeDelta.x * magnification, hand_line1_list[i].sizeDelta.y * magnification);
        }

        for (int i = 0; i < hand_line3_list.Count; i++)
        {
            hand_line3_list[i].sizeDelta = new Vector2(hand_line3_list[i].sizeDelta.x * magnification, hand_line3_list[i].sizeDelta.y * magnification);
        }

        for (int i = 0; i < scrollView_line1_list.Count; i++)
        {
            scrollView_line1_list[i].sizeDelta = new Vector2(scrollView_line1_list[i].sizeDelta.x * magnification, scrollView_line1_list[i].sizeDelta.y * magnification);
        }
        for (int i = 0; i < scrollView_line2_list.Count; i++)
        {
            scrollView_line2_list[i].sizeDelta = new Vector2(scrollView_line2_list[i].sizeDelta.x * magnification, scrollView_line2_list[i].sizeDelta.y * magnification);
        }
        for (int i = 0; i < scrollView_line3_list.Count; i++)
        {
            scrollView_line3_list[i].sizeDelta = new Vector2(scrollView_line3_list[i].sizeDelta.x * magnification, scrollView_line3_list[i].sizeDelta.y * magnification);
        }
        for (int i = 0; i < scrollView_line4_list.Count; i++)
        {
            scrollView_line4_list[i].sizeDelta = new Vector2(scrollView_line4_list[i].sizeDelta.x * magnification, scrollView_line4_list[i].sizeDelta.y * magnification);
        }
        for (int i = 0; i < scrollView_line5_list.Count; i++)
        {
            scrollView_line5_list[i].sizeDelta = new Vector2(scrollView_line5_list[i].sizeDelta.x * magnification, scrollView_line5_list[i].sizeDelta.y * magnification);
        }
        for (int i = 0; i < scrollView_line6_list.Count; i++)
        {
            scrollView_line6_list[i].sizeDelta = new Vector2(scrollView_line6_list[i].sizeDelta.x * magnification, scrollView_line6_list[i].sizeDelta.y * magnification);
        }
        for (int i = 0; i < scrollView_line7_list.Count; i++)
        {
            scrollView_line7_list[i].sizeDelta = new Vector2(scrollView_line7_list[i].sizeDelta.x * magnification, scrollView_line7_list[i].sizeDelta.y * magnification);
        }
        for (int i = 0; i < scrollView_line8_list.Count; i++)
        {
            scrollView_line8_list[i].sizeDelta = new Vector2(scrollView_line8_list[i].sizeDelta.x * magnification, scrollView_line8_list[i].sizeDelta.y * magnification);
        }
        for (int i = 0; i < scrollView_line9_list.Count; i++)
        {
            scrollView_line9_list[i].sizeDelta = new Vector2(scrollView_line9_list[i].sizeDelta.x * magnification, scrollView_line9_list[i].sizeDelta.y * magnification);
        }
        for (int i = 0; i < scrollView_line10_list.Count; i++)
        {
            scrollView_line10_list[i].sizeDelta = new Vector2(scrollView_line10_list[i].sizeDelta.x * magnification, scrollView_line10_list[i].sizeDelta.y * magnification);
        }
        for (int i = 0; i < scrollView_line11_list.Count; i++)
        {
            scrollView_line11_list[i].sizeDelta = new Vector2(scrollView_line11_list[i].sizeDelta.x * magnification, scrollView_line11_list[i].sizeDelta.y * magnification);
        }
        for (int i = 0; i < scrollView_line12_list.Count; i++)
        {
            scrollView_line12_list[i].sizeDelta = new Vector2(scrollView_line12_list[i].sizeDelta.x * magnification, scrollView_line12_list[i].sizeDelta.y * magnification);
        }
        for (int i = 0; i < scrollView_line13_list.Count; i++)
        {
            scrollView_line13_list[i].sizeDelta = new Vector2(scrollView_line13_list[i].sizeDelta.x * magnification, scrollView_line13_list[i].sizeDelta.y * magnification);
        }
    }
}
