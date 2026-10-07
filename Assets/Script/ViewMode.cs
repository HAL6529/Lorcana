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
    public Image BackGround1;
    public Image BackGround2;
    public Image Mark1;
    public Image Mark2;
    public Image Mark3;
    public Image Mark4;
    public Image Mark5;
    public Image Mark6;
    public Sprite Amethyst;
    public Sprite Amber;
    public Sprite Emerald;
    public Sprite Ruby;
    public Sprite Sapphire;
    public Sprite Steel;

    public RectTransform Parent;
    public RectTransform header;
    public RectTransform header_background;
    public RectTransform header_background_background1;
    public RectTransform header_background_background2;
    public RectTransform header_Image_Parent;
    public RectTransform header_Image;
    public RectTransform header_header_Parent;
    public RectTransform header_header;
    public RectTransform header_header_line1;
    public RectTransform header_header_line1_closeBtn;
    public RectTransform header_header_line2;
    public RectTransform header_header_line2_space;
    public RectTransform header_header_line2_text;
    public RectTransform header_header_line3;
    public RectTransform header_header_line3_space1;
    public RectTransform header_header_line3_mark1;
    public RectTransform header_header_line3_space2;
    public RectTransform header_header_line3_mark2;
    public RectTransform header_header_line3_space3;
    public RectTransform header_header_line3_mark3;
    public RectTransform header_header_line3_space4;
    public RectTransform header_header_line3_mark4;
    public RectTransform header_header_line3_space5;
    public RectTransform header_header_line3_mark5;
    public RectTransform header_header_line3_space6;
    public RectTransform header_header_line3_mark6;
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

    private List<EnumController.Colors> colors = new List<EnumController.Colors>();

    public void Open()
    {
        this.gameObject.SetActive(true);
        UpdateDeckName();
        UpdateDeckList();
        FavoriteCard.sprite = m_Menu_ConvertSpriteFromCardNo.ConvertSpriteFromCardNo(m_SaveDataStatic.GetFavoriteCardInfo().GetCardNo());
        UpdateHeader();
    }

    private void UpdateHeader()
    {
        colors = new List<EnumController.Colors>();
        for (int i = 0; i< m_EditCardPanelManager.DeckList.Count; i++)
        {
            List<EnumController.Colors> temp = m_EditCardPanelManager.DeckList[i].GetColor();
            for (int k = 0; k < temp.Count; k++)
            {
                if (colors.Contains(temp[k]))
                {
                    continue;
                }
                else
                {
                    colors.Add(temp[k]);
                }
            }
        }

        if(colors.Count > 1)
        {
            switch (colors[0])
            {
                case EnumController.Colors.Amber:
                    BackGround1.color = new Color(220f / 255f, 180f / 255f, 0, 145f / 255f);
                    break;
                case EnumController.Colors.Amethyst:
                    BackGround1.color = new Color(160f / 255f, 0, 185f / 255f, 145f / 255f);
                    break;
                case EnumController.Colors.Emerald:
                    BackGround1.color = new Color(0, 150f / 255f, 40f / 255f, 145f / 255f);
                    break;
                case EnumController.Colors.Sapphire:
                    BackGround1.color = new Color(25f / 255f, 130f / 255f, 200f / 255f, 145f / 255f);
                    break;
                case EnumController.Colors.Steel:
                    BackGround1.color = new Color(145f / 255f, 150f / 255f, 160f / 255f, 145f / 255f);
                    break;
                case EnumController.Colors.Ruby:
                    BackGround1.color = new Color(215f / 255f, 0, 40f / 255f, 145f / 255f);
                    break;
                default:
                    BackGround1.color = new Color(1, 1, 1, 0);
                    break;
            }

            switch (colors[1])
            {
                case EnumController.Colors.Amber:
                    BackGround2.color = new Color(220f / 255f, 180f / 255f, 0, 145f / 255f);
                    break;
                case EnumController.Colors.Amethyst:
                    BackGround2.color = new Color(160f / 255f, 0, 185f / 255f, 145f / 255f);
                    break;
                case EnumController.Colors.Emerald:
                    BackGround2.color = new Color(0, 150f / 255f, 40f / 255f, 145f / 255f);
                    break;
                case EnumController.Colors.Sapphire:
                    BackGround2.color = new Color(25f / 255f, 130f / 255f, 200f / 255f, 145f / 255f);
                    break;
                case EnumController.Colors.Steel:
                    BackGround2.color = new Color(145f / 255f, 150f / 255f, 160f / 255f, 145f / 255f);
                    break;
                case EnumController.Colors.Ruby:
                    BackGround2.color = new Color(215f / 255f, 0, 40f / 255f, 145f / 255f);
                    break;
                default:
                    BackGround2.color = new Color(1, 1, 1, 0);
                    break;
            }
        }
        else if (colors.Count == 1)
        {
            switch (colors[0])
            {
                case EnumController.Colors.Amber:
                    BackGround1.color = new Color(220f / 255f, 180f / 255f, 0, 145f / 255f);
                    BackGround2.color = new Color(220f / 255f, 180f / 255f, 0, 145f / 255f);
                    break;
                case EnumController.Colors.Amethyst:
                    BackGround1.color = new Color(160f / 255f, 0, 185f / 255f, 145f / 255f);
                    BackGround2.color = new Color(160f / 255f, 0, 185f / 255f, 145f / 255f);
                    break;
                case EnumController.Colors.Emerald:
                    BackGround1.color = new Color(0, 150f / 255f, 40f / 255f, 145f / 255f);
                    BackGround2.color = new Color(0, 150f / 255f, 40f / 255f, 145f / 255f);
                    break;
                case EnumController.Colors.Sapphire:
                    BackGround1.color = new Color(25f / 255f, 130f / 255f, 200f / 255f, 145f / 255f);
                    BackGround2.color = new Color(25f / 255f, 130f / 255f, 200f / 255f, 145f / 255f);
                    break;
                case EnumController.Colors.Steel:
                    BackGround1.color = new Color(145f / 255f, 150f / 255f, 160f / 255f, 145f / 255f);
                    BackGround2.color = new Color(145f / 255f, 150f / 255f, 160f / 255f, 145f / 255f);
                    break;
                case EnumController.Colors.Ruby:
                    BackGround1.color = new Color(215f / 255f, 0, 40f / 255f, 145f / 255f);
                    BackGround2.color = new Color(215f / 255f, 0, 40f / 255f, 145f / 255f);
                    break;
                default:
                    BackGround1.color = new Color(1, 1, 1, 0);
                    BackGround2.color = new Color(1, 1, 1, 0);
                    break;
            }
        }
        else
        {
            BackGround1.color = new Color(1, 1, 1, 0);
            BackGround2.color = new Color(1, 1, 1, 0);
        }

        if(colors.Count == 0)
        {
            Mark1.sprite = null;
            Mark1.color = new Color(1, 1, 1, 0);
        }
        else
        {
            Mark1.sprite = ConvertToSpriteFromColors(colors[0]);
            Mark1.color = new Color(1, 1, 1, 1);
        }

        if (colors.Count > 1)
        {
            Mark2.sprite = ConvertToSpriteFromColors(colors[1]);
            Mark2.color = new Color(1, 1, 1, 1);
        }
        else
        {
            Mark2.sprite = null;
            Mark2.color = new Color(1, 1, 1, 0);
        }

        if (colors.Count > 2)
        {
            Mark3.sprite = ConvertToSpriteFromColors(colors[2]);
            Mark3.color = new Color(1, 1, 1, 1);
        }
        else
        {
            Mark3.sprite = null;
            Mark3.color = new Color(1, 1, 1, 0);
        }

        if (colors.Count > 3)
        {
            Mark4.sprite = ConvertToSpriteFromColors(colors[3]);
            Mark4.color = new Color(1, 1, 1, 1);
        }
        else
        {
            Mark4.sprite = null;
            Mark4.color = new Color(1, 1, 1, 0);
        }

        if (colors.Count > 4)
        {
            Mark5.sprite = ConvertToSpriteFromColors(colors[4]);
            Mark5.color = new Color(1, 1, 1, 1);
        }
        else
        {
            Mark5.sprite = null;
            Mark5.color = new Color(1, 1, 1, 0);
        }

        if (colors.Count > 5)
        {
            Mark6.sprite = ConvertToSpriteFromColors(colors[5]);
            Mark6.color = new Color(1, 1, 1, 1);
        }
        else
        {
            Mark6.sprite = null;
            Mark6.color = new Color(1, 1, 1, 0);
        }
    }

    private Sprite ConvertToSpriteFromColors(EnumController.Colors paramater)
    {
        switch (paramater)
        {
            case EnumController.Colors.Amber:
                return Amber;
            case EnumController.Colors.Amethyst:
                return Amethyst;
            case EnumController.Colors.Emerald:
                return Emerald;
            case EnumController.Colors.Sapphire:
                return Sapphire;
            case EnumController.Colors.Steel:
                return Steel;
            case EnumController.Colors.Ruby:
                return Ruby;
            default:
                return null;
        }
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
        DeckNameText.text = m_EditCardPanelManager.DeckName;
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
        header_header_line3_space1.sizeDelta = new Vector2(header_header_line3_space1.sizeDelta.x * magnification_x, header_header_line3_space1.sizeDelta.y * magnification_y);
        header_header_line3_space2.sizeDelta = new Vector2(header_header_line3_space2.sizeDelta.x * magnification_x, header_header_line3_space2.sizeDelta.y * magnification_y);
        header_header_line3_space3.sizeDelta = new Vector2(header_header_line3_space3.sizeDelta.x * magnification_x, header_header_line3_space3.sizeDelta.y * magnification_y);
        header_header_line3_space4.sizeDelta = new Vector2(header_header_line3_space4.sizeDelta.x * magnification_x, header_header_line3_space4.sizeDelta.y * magnification_y);
        header_header_line3_space5.sizeDelta = new Vector2(header_header_line3_space5.sizeDelta.x * magnification_x, header_header_line3_space5.sizeDelta.y * magnification_y);
        header_header_line3_space6.sizeDelta = new Vector2(header_header_line3_space6.sizeDelta.x * magnification_x, header_header_line3_space6.sizeDelta.y * magnification_y);
        header_header_line4.sizeDelta = new Vector2(header_header_line4.sizeDelta.x * magnification_x, header_header_line4.sizeDelta.y * magnification_y);
        hand.sizeDelta = new Vector2(hand.sizeDelta.x * magnification_x, hand.sizeDelta.y * magnification_y);
        hand_line1.sizeDelta = new Vector2(hand_line1.sizeDelta.x * magnification_x, hand_line1.sizeDelta.y * magnification_y);
        hand_line2.sizeDelta = new Vector2(hand_line2.sizeDelta.x * magnification_x, hand_line2.sizeDelta.y * magnification_y);
        header_header_line2_space.sizeDelta = new Vector2(header_header_line2_space.sizeDelta.x * magnification_x, header_header_line2_space.sizeDelta.y * magnification_y);
        header_header_line2_text.sizeDelta = new Vector2(header_header_line2_text.sizeDelta.x * magnification_x, header_header_line2_text.sizeDelta.y * magnification_y);
        hand_line2_firstDrawBtn.sizeDelta = new Vector2(hand_line2_firstDrawBtn.sizeDelta.x * magnification_x, hand_line2_firstDrawBtn.sizeDelta.y * magnification_y);
        hand_line2_oneDrawBtn.sizeDelta = new Vector2(hand_line2_oneDrawBtn.sizeDelta.x * magnification_x, hand_line2_oneDrawBtn.sizeDelta.y * magnification_y);
        hand_line3.sizeDelta = new Vector2(hand_line3.sizeDelta.x * magnification_x, hand_line3.sizeDelta.y * magnification_y);
        header_background.sizeDelta = new Vector2(header_background.sizeDelta.x * magnification_x, header_background.sizeDelta.y * magnification_y);
        header_background_background1.sizeDelta = new Vector2(header_background_background1.sizeDelta.x * magnification_x, header_background_background1.sizeDelta.y * magnification_y);
        header_background_background2.sizeDelta = new Vector2(header_background_background2.sizeDelta.x * magnification_x, header_background_background2.sizeDelta.y * magnification_y);
        header_header_Parent.sizeDelta = new Vector2(header_header_Parent.sizeDelta.x * magnification_x, header_header_Parent.sizeDelta.y * magnification_y);

        float magnification = magnification_x;
        if (magnification_x > magnification_y)
        {
            magnification = magnification_y;
        }
        header_Image.sizeDelta = new Vector2(header_Image.sizeDelta.x * magnification, header_Image.sizeDelta.y * magnification);
        header_header_line1_closeBtn.sizeDelta = new Vector2(header_header_line1_closeBtn.sizeDelta.x * magnification, header_header_line1_closeBtn.sizeDelta.y * magnification);
        header_header_line3_mark1.sizeDelta = new Vector2(header_header_line3_mark1.sizeDelta.x * magnification, header_header_line3_mark1.sizeDelta.y * magnification);
        header_header_line3_mark2.sizeDelta = new Vector2(header_header_line3_mark2.sizeDelta.x * magnification, header_header_line3_mark2.sizeDelta.y * magnification);
        header_header_line3_mark3.sizeDelta = new Vector2(header_header_line3_mark3.sizeDelta.x * magnification, header_header_line3_mark3.sizeDelta.y * magnification);
        header_header_line3_mark4.sizeDelta = new Vector2(header_header_line3_mark4.sizeDelta.x * magnification, header_header_line3_mark4.sizeDelta.y * magnification);
        header_header_line3_mark5.sizeDelta = new Vector2(header_header_line3_mark5.sizeDelta.x * magnification, header_header_line3_mark5.sizeDelta.y * magnification);
        header_header_line3_mark6.sizeDelta = new Vector2(header_header_line3_mark6.sizeDelta.x * magnification, header_header_line3_mark6.sizeDelta.y * magnification);
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
