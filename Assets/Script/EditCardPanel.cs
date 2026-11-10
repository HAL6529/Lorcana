using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditCardPanel : MonoBehaviour
{
    public Image m_sprite;
    public Image i_Base1;
    public Image i_Base2;
    public Image i_class;
    public Image i_label;
    public Image i_power;
    public Image i_toughness;
    public Text inkCost;
    public Text cardName1;
    public Text cardName2;
    public Text Class;
    public Text expantion;
    public Text title;
    public Text power;
    public Text toughness;
    public Text count;
    public Image rareSprite;
    public Image i_lore;
    public CardInfo m_CardInfo;

    public int cardCount;
    public int index;

    public RectTransform parent;
    public RectTransform image_parent;
    public RectTransform image;
    public RectTransform middle;
    public RectTransform inkHeader;
    public RectTransform inkHeader_ink;
    public RectTransform cardNameHeader;
    public RectTransform cardNameHeader_cardName;
    public RectTransform cardName2Header;
    public RectTransform cardName2Header_cardName;
    public RectTransform classHeader;
    public RectTransform classHeader_className;
    public RectTransform cardTextHeader;
    public RectTransform cardTextHeader_middle;
    public RectTransform powerToughness;
    public RectTransform expantionName;
    public RectTransform expantionName_expantion;
    public RectTransform expantionName_power;
    public RectTransform expantionName_power_power;
    public RectTransform expantionName_toughness;
    public RectTransform expantionName_toughness_toughness;
    public RectTransform titleHeader;
    public RectTransform titleHeader_title;
    public RectTransform space1;
    public RectTransform space2;
    public RectTransform lores;
    public RectTransform lores_lore;
    public RectTransform rareHeader;
    public RectTransform rareHeader_rare;
    public RectTransform plusMinusHeader;
    public RectTransform plusMinusHeader_label;
    public RectTransform plusMinusHeader_button;
    public RectTransform plusMinusHeader_label2;

    ExtendUtil m_ExtendUtil = new ExtendUtil();

    public DialogManager m_DialogManager;
    public EditCardPanelManager m_EditCardPanelManager;
    public PanelPicture m_PanelPicture;
    public RectTransform CanvasRectTransform;

    public Sprite Lore1;
    public Sprite Lore2;
    public Sprite Lore3;
    public Sprite Lore4;

    private const int parent_X = 890;
    private const int parent_Y = 305;
    private const int image_parent_X = 218;
    private const int image_parent_Y = 305;
    private const int image_X = 218;
    private const int image_Y = 305;
    private const int middle_X = 525;
    private const int middle_Y = 305;
    private const int inkHeader_X = 525;
    private const int inkHeader_Y = 30;
    private const int inkHeader_ink_X = 525;
    private const int inkHeader_ink_Y = 30;
    private const int cardNameHeader_X = 525;
    private const int cardNameHeader_Y = 30;
    private const int cardNameHeader_cardName_X = 525;
    private const int cardNameHeader_cardName_Y = 30;
    private const int cardName2Header_X = 525;
    private const int cardName2Header_Y = 30;
    private const int cardName2Header_cardName_X = 525;
    private const int cardName2Header_cardName_Y = 30;
    private const int classHeader_X = 525;
    private const int classHeader_Y = 30;
    private const int classHeader_className_X = 525;
    private const int classHeader_className_Y = 30;
    private const int cardTextHeader_X = 525;
    private const int cardTextHeader_Y = 155;
    private const int cardTextHeader_middle_X = 475;
    private const int cardTextHeader_middle_Y = 155;
    private const int powerToughness_X = 475;
    private const int powerToughness_Y = 30;
    private const int expantionName_X = 475;
    private const int expantionName_Y = 30;
    private const int expantionName_expantion_X = 401;
    private const int expantionName_expantion_Y = 30;
    private const int expantionName_power_X = 37;
    private const int expantionName_power_Y = 30;
    private const int expantionName_power_power_X = 37;
    private const int expantionName_power_power_Y = 30;
    private const int expantionName_toughness_X = 37;
    private const int expantionName_toughness_Y = 30;
    private const int expantionName_toughness_toughness_X = 37;
    private const int expantionName_toughness_toughness_Y = 30;
    private const int titleHeader_X = 475;
    private const int titleHeader_Y = 30;
    private const int titleHeader_title_X = 401;
    private const int titleHeader_title_Y = 30;
    private const int space1_X = 475;
    private const int space1_Y = 5;
    private const int space2_X = 475;
    private const int space2_Y = 90;
    private const int lores_X = 50;
    private const int lores_Y = 155;
    private const int lores_lore_X = 50;
    private const int lores_lore_Y = 155;
    private const int rareHeader_X = 525;
    private const int rareHeader_Y = 30;
    private const int rareHeader_rare_X = 30;
    private const int rareHeader_rare_Y = 30;
    private const int plusMinusHeader_X = 147;
    private const int plusMinusHeader_Y = 305;
    private const int plusMinusHeader_label_X = 147;
    private const int plusMinusHeader_label_Y = 30;
    private const int plusMinusHeader_button_X = 147;
    private const int plusMinusHeader_button_Y = 245;
    private const int plusMinusHeader_label2_X = 147;
    private const int plusMinusHeader_label2_Y = 30;

    public void Start()
    {
        UpdateImage(CanvasRectTransform.sizeDelta.x / 890, CanvasRectTransform.sizeDelta.y / 1920);
    }

    public void onAddCardButton()
    {
        m_DialogManager.AddCardDialog_Open(this);
    }

    public string GetCardNo()
    {
        return m_CardInfo.GetCardNo();
    }

    public void isSearchHit()
    {
        if (m_EditCardPanelManager.m_SearchFilterClass.isSearchHit(m_CardInfo))
        {
            if ((m_EditCardPanelManager.SwitchOwn && cardCount > 0) || !m_EditCardPanelManager.SwitchOwn)
            {
                SwitchActive(true);
            }
            else
            {
                SwitchActive(false);
            }
        }
        else
        {
            SwitchActive(false);
        }
    }

    public void SetEditCardPanel(int m_count)
    {
        this.cardCount = m_count;
        SetEditCardPanel2();
    }

    public void SetEditCardPanel(CardInfo m_CardInfo, int m_count, int index)
    {
        this.index = index;
        this.m_CardInfo = m_CardInfo;
        this.cardCount = m_count;
        SetEditCardPanel2();
    }

    private void SetEditCardPanel2()
    {
        if (m_CardInfo == null)
        {
            SwitchActive(false);
            return;
        }
        else
        {
            SwitchActive(true);
        }

        m_sprite.sprite = m_CardInfo.GetSprite();
        inkCost.text = m_CardInfo.GetInkCost().ToString();
        cardName1.text = m_CardInfo.GetCardName1();
        cardName2.text = m_CardInfo.GetCardName2();
        Class.text = EditClass(m_CardInfo.GetClassList());
        expantion.text = m_ExtendUtil.ConvertToStringFromExpantion(m_CardInfo.GetExpantion());
        title.text = m_ExtendUtil.ConvertToStringFromTitle(m_CardInfo.GetTitle());

        if (m_CardInfo.GetType() == EnumController.Type.Character || m_CardInfo.GetType() == EnumController.Type.Location)
        {
            power.text = m_CardInfo.GetPower().ToString();
            toughness.text = m_CardInfo.GetToughness().ToString();
        }
        else
        {
            power.text = "";
            toughness.text = "";
        }

        UpdatePlusMinusBtn();
        UpdateLore();
        UpdateRare();
        UpdateColor();
        UpdateColor2();
    }

    private string EditClass(List<EnumController.Class> paramater)
    {
        string temp = "";

        switch (m_CardInfo.GetType())
        {
            case EnumController.Type.Song:
                temp = "アクション・歌";
                return temp;
            case EnumController.Type.Action:
                temp = "アクション";
                return temp;
            case EnumController.Type.Item:
                temp = "アイテム";
                return temp;
            case EnumController.Type.Location:
                temp = "ロケーション";
                return temp;
            default:
                for (int i = 0; i < paramater.Count; i++)
                {
                    if (i > 0)
                    {
                        temp += ", ";
                    }

                    temp += m_ExtendUtil.ConvertToStringFromClass(paramater[i]);
                }
                return temp;
        }
    }

    public void onViewBtn()
    {
        m_PanelPicture.SetView(m_CardInfo);
    }

    public void SwitchActive(bool b)
    {
        this.gameObject.SetActive(b);
    }

    private void UpdateLore()
    {
        switch (m_CardInfo.GetLore())
        {
            case 1:
                i_lore.color = new Color(1, 1, 1, 1);
                i_lore.sprite = Lore1;
                return;
            case 2:
                i_lore.color = new Color(1, 1, 1, 1);
                i_lore.sprite = Lore2;
                return;
            case 3:
                i_lore.color = new Color(1, 1, 1, 1);
                i_lore.sprite = Lore3;
                return;
            case 4:
                i_lore.color = new Color(1, 1, 1, 1);
                i_lore.sprite = Lore4;
                return;
            default:
                i_lore.color = new Color(1, 1, 1, 0);
                return;
        }
    }

    private void UpdatePlusMinusBtn()
    {
        count.text = cardCount.ToString();
        m_EditCardPanelManager.onUpdateDeckList(index, cardCount);
    }

    private void UpdateRare()
    {
        switch (m_CardInfo.GetRare())
        {
            case EnumController.Rare.Common:
                rareSprite.sprite = m_EditCardPanelManager.Common;
                return;
            case EnumController.Rare.Uncommon:
                rareSprite.sprite = m_EditCardPanelManager.UnCommon;
                return;
            case EnumController.Rare.Rare:
                rareSprite.sprite = m_EditCardPanelManager.Rare;
                return;
            case EnumController.Rare.SuperRare:
                rareSprite.sprite = m_EditCardPanelManager.SuperRare;
                return;
            case EnumController.Rare.Legendary:
                rareSprite.sprite = m_EditCardPanelManager.Legendary;
                return;
            case EnumController.Rare.Enchanted:
                rareSprite.sprite = m_EditCardPanelManager.Enchanted;
                return;
            case EnumController.Rare.Iconic:
                rareSprite.sprite = m_EditCardPanelManager.Iconic;
                return;
            case EnumController.Rare.Promo:
                rareSprite.sprite = m_EditCardPanelManager.Promo;
                return;
            default:
                rareSprite.sprite = null;
                return;
        }
    }

    private void UpdateColor()
    {
        List<EnumController.Colors> list = m_CardInfo.GetColor();
        switch (list[0])
        {
            case EnumController.Colors.Amber:
                i_Base1.color = new Color(220f / 255f, 180f / 255f, 0, 255);
                i_Base2.color = new Color(220f / 255f, 180f / 255f, 0, 255);
                i_class.color = new Color(120f / 255f, 100f / 255f, 0, 255);
                i_label.color = new Color(120f / 255f, 100f / 255f, 0, 255);
                i_power.color = new Color(255f, 250f / 255f, 180f / 255f, 255);
                i_toughness.color = new Color(210f / 255f, 120f / 255f, 0, 255);
                return;
            case EnumController.Colors.Amethyst:
                i_Base1.color = new Color(160f / 255f, 0, 185f / 255f, 255);
                i_Base2.color = new Color(160f / 255f, 0, 185f / 255f, 255);
                i_class.color = new Color(20f / 255f, 0, 30f / 255f, 255);
                i_label.color = new Color(20f / 255f, 0, 30f / 255f, 255);
                i_power.color = new Color(200f / 255f, 155f / 255f, 200f / 255f, 255);
                i_toughness.color = new Color(80f / 255f, 25f / 255f, 100f / 255f, 255);
                return;
            case EnumController.Colors.Emerald:
                i_Base1.color = new Color(0, 150f / 255f, 40f / 255f, 255);
                i_Base2.color = new Color(0, 150f / 255f, 40f / 255f, 255);
                i_class.color = new Color(0, 60f / 255f, 25f / 255f, 255);
                i_label.color = new Color(0, 60f / 255f, 25f / 255f, 255);
                i_power.color = new Color(170f / 255f, 230f / 255f, 205f / 255f, 255);
                i_toughness.color = new Color(0, 80f / 255f, 10f / 255f, 255);
                return;
            case EnumController.Colors.Sapphire:
                i_Base1.color = new Color(25f / 255f, 130f / 255f, 200f / 255f, 255);
                i_Base2.color = new Color(25f / 255f, 130f / 255f, 200f / 255f, 255);
                i_class.color = new Color(30f / 255f, 30f / 255f, 90f / 255f, 255);
                i_label.color = new Color(30f / 255f, 30f / 255f, 90f / 255f, 255);
                i_power.color = new Color(220f / 255f, 240f / 255f, 255f / 255f, 255);
                i_toughness.color = new Color(0, 25f / 255f, 140f / 255f, 255);
                return;
            case EnumController.Colors.Steel:
                i_Base1.color = new Color(145f / 255f, 150f / 255f, 160f / 255f, 255);
                i_Base2.color = new Color(145f / 255f, 150f / 255f, 160f / 255f, 255);
                i_class.color = new Color(90f / 255f, 90f / 255f, 90f / 255f, 255);
                i_label.color = new Color(90f / 255f, 90f / 255f, 90f / 255f, 255);
                i_power.color = new Color(210f / 255f, 210f / 255f, 210f / 255f, 255);
                i_toughness.color = new Color(55f / 255f, 55f / 255f, 55f / 255f, 255);
                return;
            case EnumController.Colors.Ruby:
                i_Base1.color = new Color(215f / 255f, 0, 40f / 255f, 255);
                i_Base2.color = new Color(215f / 255f, 0, 40f / 255f, 255);
                i_class.color = new Color(45f / 255f, 0, 0, 255);
                i_label.color = new Color(45f / 255f, 0, 0, 255);
                i_power.color = new Color(255f / 255f, 135f / 255f, 140f / 255f, 255);
                i_toughness.color = new Color(100f / 255f, 0, 15f / 255f, 255);
                return;
        }
    }

    public void UpdateColor2()
    {
        if (m_CardInfo.GetType() == EnumController.Type.Character || m_CardInfo.GetType() == EnumController.Type.Location)
        {
            return;
        }

        List<EnumController.Colors> list = m_CardInfo.GetColor();
        switch (list[0])
        {
            case EnumController.Colors.Amber:
                i_power.color = new Color(255f, 250f / 255f, 180f / 255f, 0);
                i_toughness.color = new Color(210f / 255f, 120f / 255f, 0, 0);
                return;
            case EnumController.Colors.Amethyst:
                i_power.color = new Color(200f / 255f, 155f / 255f, 200f / 255f, 0);
                i_toughness.color = new Color(80f / 255f, 25f / 255f, 100f / 255f, 0);
                return;
            case EnumController.Colors.Emerald:
                i_power.color = new Color(170f / 255f, 230f / 255f, 205f / 255f, 0);
                i_toughness.color = new Color(0, 80f / 255f, 10f / 255f, 0);
                return;
            case EnumController.Colors.Sapphire:
                i_power.color = new Color(220f / 255f, 240f / 255f, 255f / 255f, 0);
                i_toughness.color = new Color(0, 25f / 255f, 140f / 255f, 0);
                return;
            case EnumController.Colors.Steel:
                i_power.color = new Color(210f / 255f, 210f / 255f, 210f / 255f, 0);
                i_toughness.color = new Color(55f / 255f, 55f / 255f, 55f / 255f, 0);
                return;
            case EnumController.Colors.Ruby:
                i_power.color = new Color(255f / 255f, 135f / 255f, 140f / 255f, 0);
                i_toughness.color = new Color(100f / 255f, 0, 15f / 255f, 0);
                return;
        }
    }

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        parent.sizeDelta = new Vector2(parent_X * magnification_x, parent_Y * magnification_y);
        image_parent.sizeDelta = new Vector2(image_parent_X * magnification_x, image_parent_Y * magnification_y);
        middle.sizeDelta = new Vector2(middle_X * magnification_x, middle_Y * magnification_y);
        inkHeader.sizeDelta = new Vector2(inkHeader_X * magnification_x, inkHeader_Y * magnification_y);
        inkHeader_ink.sizeDelta = new Vector2(inkHeader_ink_X * magnification_x, inkHeader_ink_Y * magnification_y);
        cardNameHeader.sizeDelta = new Vector2(cardNameHeader_X * magnification_x, cardNameHeader_Y * magnification_y);
        cardNameHeader_cardName.sizeDelta = new Vector2(cardNameHeader_cardName_X * magnification_x, cardNameHeader_cardName_Y * magnification_y);
        cardName2Header.sizeDelta = new Vector2(cardName2Header_X * magnification_x, cardName2Header_Y * magnification_y);
        cardName2Header_cardName.sizeDelta = new Vector2(cardName2Header_cardName_X * magnification_x, cardName2Header_cardName_Y * magnification_y);
        classHeader.sizeDelta = new Vector2(classHeader_X * magnification_x, classHeader_Y * magnification_y);
        classHeader_className.sizeDelta = new Vector2(classHeader_className_X * magnification_x, classHeader_className_Y * magnification_y);
        cardTextHeader.sizeDelta = new Vector2(cardTextHeader_X * magnification_x, cardTextHeader_Y * magnification_y);
        cardTextHeader_middle.sizeDelta = new Vector2(cardTextHeader_middle_X * magnification_x, cardTextHeader_middle_Y * magnification_y);
        powerToughness.sizeDelta = new Vector2(powerToughness_X, powerToughness_Y * magnification_y);
        expantionName.sizeDelta = new Vector2(expantionName_X * magnification_x, expantionName_Y * magnification_y);
        expantionName_expantion.sizeDelta = new Vector2(expantionName_expantion_X * magnification_x, expantionName_expantion_Y * magnification_y);
        expantionName_power.sizeDelta = new Vector2(expantionName_power_X * magnification_x, expantionName_power_Y * magnification_y);
        expantionName_power_power.sizeDelta = new Vector2(expantionName_power_power_X * magnification_x, expantionName_power_power_Y * magnification_y);
        expantionName_toughness.sizeDelta = new Vector2(expantionName_toughness_X * magnification_x, expantionName_toughness_Y * magnification_y);
        expantionName_toughness_toughness.sizeDelta = new Vector2(expantionName_toughness_toughness_X * magnification_x, expantionName_toughness_toughness_Y * magnification_y);
        titleHeader.sizeDelta = new Vector2(titleHeader_X * magnification_x, titleHeader_Y * magnification_y);
        titleHeader_title.sizeDelta = new Vector2(titleHeader_title_X * magnification_x, titleHeader_title_Y * magnification_y);
        space1.sizeDelta = new Vector2(space1_X * magnification_x, space1_Y * magnification_y);
        space2.sizeDelta = new Vector2(space2_X * magnification_x, space2_Y * magnification_y);
        lores.sizeDelta = new Vector2(lores_X * magnification_x, lores_Y * magnification_y);

        rareHeader.sizeDelta = new Vector2(rareHeader_X * magnification_x, rareHeader_Y * magnification_y);
        
        plusMinusHeader.sizeDelta = new Vector2(plusMinusHeader_X * magnification_x, plusMinusHeader_Y * magnification_y);
        plusMinusHeader_label.sizeDelta = new Vector2(plusMinusHeader_label_X * magnification_x, plusMinusHeader_label_Y * magnification_y);
        plusMinusHeader_button.sizeDelta = new Vector2(plusMinusHeader_button_X * magnification_x, plusMinusHeader_button_Y * magnification_y);
        plusMinusHeader_label2.sizeDelta = new Vector2(plusMinusHeader_label2_X * magnification_x, plusMinusHeader_label2_Y * magnification_y);

        float magnification = magnification_x;
        if (magnification_x > magnification_y)
        {
            magnification = magnification_y;
        }
        image.sizeDelta = new Vector2(image_X * magnification, image_Y * magnification);
        rareHeader_rare.sizeDelta = new Vector2(rareHeader_rare_X * magnification, rareHeader_rare_Y * magnification);
        lores_lore.sizeDelta = new Vector2(lores_lore_X * magnification, lores_lore_Y * magnification);

        Vector2 left_position = new Vector2(0, 1);
        image_parent.anchorMin = left_position;
        image_parent.anchorMax = left_position;
        image_parent.pivot = left_position;
        image_parent.anchoredPosition = Vector2.zero;

        image.anchorMin = left_position;
        image.anchorMax = left_position;
        image.pivot = left_position;
        image.anchoredPosition = new Vector2((image_parent.sizeDelta.x - image.sizeDelta.x) / 2, (image_parent.sizeDelta.y - image.sizeDelta.y) / 2);

        int FontSize = (int)(45 * magnification);
        count.fontSize = FontSize;
        //==============================================================================================
        //真ん中 --ここから--
        //==============================================================================================
        middle.anchorMin = left_position;
        middle.anchorMax = left_position;
        middle.pivot = left_position;
        middle.anchoredPosition = new Vector2(image_parent.sizeDelta.x, 0);

        float middleSize_y = 0;
        inkHeader.anchorMin = left_position;
        inkHeader.anchorMax = left_position;
        inkHeader.pivot = left_position;
        inkHeader.anchoredPosition = Vector2.zero;

        middleSize_y += inkHeader.sizeDelta.y;
        cardNameHeader.anchorMin = left_position;
        cardNameHeader.anchorMax = left_position;
        cardNameHeader.pivot = left_position;
        cardNameHeader.anchoredPosition = new Vector2(0, middleSize_y * (-1));

        middleSize_y += cardNameHeader.sizeDelta.y;
        cardName2Header.anchorMin = left_position;
        cardName2Header.anchorMax = left_position;
        cardName2Header.pivot = left_position;
        cardName2Header.anchoredPosition = new Vector2(0, middleSize_y * (-1));

        middleSize_y += cardName2Header.sizeDelta.y;
        classHeader.anchorMin = left_position;
        classHeader.anchorMax = left_position;
        classHeader.pivot = left_position;
        classHeader.anchoredPosition = new Vector2(0, middleSize_y * (-1));

        middleSize_y += classHeader.sizeDelta.y;
        cardTextHeader.anchorMin = left_position;
        cardTextHeader.anchorMax = left_position;
        cardTextHeader.pivot = left_position;
        cardTextHeader.anchoredPosition = new Vector2(0, middleSize_y * (-1));

        middleSize_y += cardTextHeader.sizeDelta.y;
        rareHeader.anchorMin = left_position;
        rareHeader.anchorMax = left_position;
        rareHeader.pivot = left_position;
        rareHeader.anchoredPosition = new Vector2(0, middleSize_y * (-1));

        inkHeader_ink.anchorMin = left_position;
        inkHeader_ink.anchorMax = left_position;
        inkHeader_ink.pivot = left_position;
        inkHeader_ink.anchoredPosition = Vector2.zero;

        cardNameHeader_cardName.anchorMin = left_position;
        cardNameHeader_cardName.anchorMax = left_position;
        cardNameHeader_cardName.pivot = left_position;
        cardNameHeader_cardName.anchoredPosition = Vector2.zero;

        cardName2Header_cardName.anchorMin = left_position;
        cardName2Header_cardName.anchorMax = left_position;
        cardName2Header_cardName.pivot = left_position;
        cardName2Header_cardName.anchoredPosition = Vector2.zero;

        classHeader_className.anchorMin = left_position;
        classHeader_className.anchorMax = left_position;
        classHeader_className.pivot = left_position;
        classHeader_className.anchoredPosition = Vector2.zero;

        cardTextHeader_middle.anchorMin = left_position;
        cardTextHeader_middle.anchorMax = left_position;
        cardTextHeader_middle.pivot = left_position;
        cardTextHeader_middle.anchoredPosition = Vector2.zero;

        float cardTextHeader_middleSize_y = 0;
        powerToughness.anchorMin = left_position;
        powerToughness.anchorMax = left_position;
        powerToughness.pivot = left_position;
        powerToughness.anchoredPosition = Vector2.zero;

        expantionName_expantion.anchorMin = left_position;
        expantionName_expantion.anchorMax = left_position;
        expantionName_expantion.pivot = left_position;
        expantionName_expantion.anchoredPosition = Vector2.zero;

        expantionName_power.anchorMin = left_position;
        expantionName_power.anchorMax = left_position;
        expantionName_power.pivot = left_position;
        expantionName_power.anchoredPosition = new Vector2(expantionName_expantion.sizeDelta.x, 0);

        expantionName_toughness.anchorMin = left_position;
        expantionName_toughness.anchorMax = left_position;
        expantionName_toughness.pivot = left_position;
        expantionName_toughness.anchoredPosition = new Vector2(expantionName_expantion.sizeDelta.x + expantionName_power.sizeDelta.x, 0);

        expantionName_power_power.anchorMin = left_position;
        expantionName_power_power.anchorMax = left_position;
        expantionName_power_power.pivot = left_position;
        expantionName_power_power.anchoredPosition = Vector2.zero;

        expantionName_toughness_toughness.anchorMin = left_position;
        expantionName_toughness_toughness.anchorMax = left_position;
        expantionName_toughness_toughness.pivot = left_position;
        expantionName_toughness_toughness.anchoredPosition = Vector2.zero;

        cardTextHeader_middleSize_y += powerToughness.sizeDelta.y;
        titleHeader.anchorMin = left_position;
        titleHeader.anchorMax = left_position;
        titleHeader.pivot = left_position;
        titleHeader.anchoredPosition = new Vector2(0, cardTextHeader_middleSize_y * (-1));

        titleHeader_title.anchorMin = left_position;
        titleHeader_title.anchorMax = left_position;
        titleHeader_title.pivot = left_position;
        titleHeader_title.anchoredPosition = Vector2.zero;

        cardTextHeader_middleSize_y += titleHeader.sizeDelta.y;
        space1.anchorMin = left_position;
        space1.anchorMax = left_position;
        space1.pivot = left_position;
        space1.anchoredPosition = new Vector2(0, cardTextHeader_middleSize_y * (-1));

        cardTextHeader_middleSize_y += space1.sizeDelta.y;
        space2.anchorMin = left_position;
        space2.anchorMax = left_position;
        space2.pivot = left_position;
        space2.anchoredPosition = new Vector2(0, cardTextHeader_middleSize_y * (-1));

        lores.anchorMin = left_position;
        lores.anchorMax = left_position;
        lores.pivot = left_position;
        lores.anchoredPosition = new Vector2(cardTextHeader_middle.sizeDelta.x, 0);

        lores_lore.anchorMin = left_position;
        lores_lore.anchorMax = left_position;
        lores_lore.pivot = left_position;
        lores_lore.anchoredPosition = new Vector2((lores.sizeDelta.x - lores_lore.sizeDelta.x) / 2, 0);

        rareHeader_rare.anchorMin = left_position;
        rareHeader_rare.anchorMax = left_position;
        rareHeader_rare.pivot = left_position;
        rareHeader_rare.anchoredPosition = new Vector2((rareHeader.sizeDelta.x - rareHeader_rare.sizeDelta.x) / 2, 0);
        //==============================================================================================
        //真ん中 --ここまで--
        //==============================================================================================
        //==============================================================================================
        //プラスマイナスボタン --ここから--
        //==============================================================================================

        plusMinusHeader.anchorMin = left_position;
        plusMinusHeader.anchorMax = left_position;
        plusMinusHeader.pivot = left_position;
        plusMinusHeader.anchoredPosition = new Vector2(image_parent.sizeDelta.x + middle.sizeDelta.x, 0);

        float plusMinusHeaderSize_y = 0;

        plusMinusHeader_label.anchorMin = left_position;
        plusMinusHeader_label.anchorMax = left_position;
        plusMinusHeader_label.pivot = left_position;
        plusMinusHeader_label.anchoredPosition = Vector2.zero;

        plusMinusHeaderSize_y += plusMinusHeader_label.sizeDelta.y;

        plusMinusHeader_button.anchorMin = left_position;
        plusMinusHeader_button.anchorMax = left_position;
        plusMinusHeader_button.pivot = left_position;
        plusMinusHeader_button.anchoredPosition = new Vector2(0, plusMinusHeaderSize_y * (-1));

        plusMinusHeaderSize_y += plusMinusHeader_button.sizeDelta.y;

        plusMinusHeader_label2.anchorMin = left_position;
        plusMinusHeader_label2.anchorMax = left_position;
        plusMinusHeader_label2.pivot = left_position;
        plusMinusHeader_label2.anchoredPosition = new Vector2(0, plusMinusHeaderSize_y * (-1));

        //==============================================================================================
        //プラスマイナスボタン --ここまで--
        //==============================================================================================
    }
}
