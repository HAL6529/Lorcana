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
    public CardInfo m_CardInfo;
    public Button plusBtn;
    public Button minusBtn;

    public int cardCount;

    public List<GameObject> loreList;

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
    public List<RectTransform> lores_loreList = new List<RectTransform>();
    public RectTransform rareHeader;
    public RectTransform rareHeader_rare;
    public RectTransform plusMinusHeader;
    public RectTransform plusMinusHeader_label;
    public RectTransform plusMinusHeader_space1;
    public RectTransform plusMinusHeader_plus;
    public RectTransform plusMinusHeader_space2;
    public RectTransform plusMinusHeader_count;
    public RectTransform plusMinusHeader_space3;
    public RectTransform plusMinusHeader_minus;
    public RectTransform plusMinusHeader_space4;
    public RectTransform plusMinusHeader_label2;

    ExtendUtil m_ExtendUtil = new ExtendUtil();

    public EditCardPanelManager m_EditCardPanelManager;
    public PanelPicture m_PanelPicture;

    public void Start()
    {
        SetEditCardPanel(m_CardInfo, 0);
        m_EditCardPanelManager.CheckStandby();
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

    public void SetEditCardPanel(CardInfo m_CardInfo, int m_count)
    {
        this.m_CardInfo = m_CardInfo;
        m_sprite.sprite = m_CardInfo.GetSprite();
        inkCost.text = m_CardInfo.GetInkCost().ToString();
        cardName1.text = m_CardInfo.GetCardName1();
        cardName2.text = m_CardInfo.GetCardName2();
        Class.text = EditClass(m_CardInfo.GetClassList());
        expantion.text = m_ExtendUtil.ConvertToStringFromExpantion(m_CardInfo.GetExpantion());
        title.text = m_ExtendUtil.ConvertToStringFromTitle(m_CardInfo.GetTitle());
        this.cardCount = m_count;

        if (m_CardInfo.GetType() == EnumController.Type.Character)
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
        
        if(m_CardInfo.GetType() == EnumController.Type.Song)
        {
            temp = "アクション・歌";
            return temp;
        }
        else if(m_CardInfo.GetType() == EnumController.Type.Action)
        {
            temp = "アクション";
            return temp;
        }
        else if (m_CardInfo.GetType() == EnumController.Type.Item)
        {
            temp = "アイテム";
            return temp;
        }

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

    public void onMinusBtn()
    {
        if (cardCount == 0)
        {
            return;
        }
        cardCount--;
        UpdatePlusMinusBtn();
        return;
    }

    public void onPlusBtn()
    {
        if (cardCount == 4)
        {
            return;
        }
        cardCount++;
        UpdatePlusMinusBtn();
        return;
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
        if (m_CardInfo.GetLore() < 5)
        {
            for(int i = 0; i < 4; i++)
            {
                if (i < m_CardInfo.GetLore())
                {
                    loreList[i].SetActive(true);
                }
                else
                {
                    loreList[i].SetActive(false);
                }
            }
        }
        else if(m_CardInfo.GetLore() < 0)
        {
            for (int i = 0; i < 4; i++)
            {
                loreList[i].SetActive(false);
            }
        }
    }

    private void UpdatePlusMinusBtn()
    {
        if(cardCount == 0)
        {
            minusBtn.interactable = false;
        }
        else
        {
            minusBtn.interactable = true;
        }

        if (cardCount == 4)
        {
            plusBtn.interactable = false;
        }
        else
        {
            plusBtn.interactable = true;
        }

        count.text = cardCount.ToString();
        m_EditCardPanelManager.onUpdateDeckList();
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
        if (m_CardInfo.GetType() == EnumController.Type.Character)
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
        parent.sizeDelta = new Vector2(parent.sizeDelta.x * magnification_x, parent.sizeDelta.y * magnification_y);
        image_parent.sizeDelta = new Vector2(image_parent.sizeDelta.x * magnification_x, image_parent.sizeDelta.y * magnification_y);
        middle.sizeDelta = new Vector2(middle.sizeDelta.x * magnification_x, middle.sizeDelta.y * magnification_y);
        inkHeader.sizeDelta = new Vector2(inkHeader.sizeDelta.x * magnification_x, inkHeader.sizeDelta.y * magnification_y);
        inkHeader_ink.sizeDelta = new Vector2(inkHeader_ink.sizeDelta.x * magnification_x, inkHeader_ink.sizeDelta.y * magnification_y);
        cardNameHeader.sizeDelta = new Vector2(cardNameHeader.sizeDelta.x * magnification_x, cardNameHeader.sizeDelta.y * magnification_y);
        cardNameHeader_cardName.sizeDelta = new Vector2(cardNameHeader_cardName.sizeDelta.x * magnification_x, cardNameHeader_cardName.sizeDelta.y * magnification_y);
        cardName2Header.sizeDelta = new Vector2(cardName2Header.sizeDelta.x * magnification_x, cardName2Header.sizeDelta.y * magnification_y);
        cardName2Header_cardName.sizeDelta = new Vector2(cardName2Header_cardName.sizeDelta.x * magnification_x, cardName2Header_cardName.sizeDelta.y * magnification_y);
        classHeader.sizeDelta = new Vector2(classHeader.sizeDelta.x * magnification_x, classHeader.sizeDelta.y * magnification_y);
        classHeader_className.sizeDelta = new Vector2(classHeader_className.sizeDelta.x * magnification_x, classHeader_className.sizeDelta.y * magnification_y);
        cardTextHeader.sizeDelta = new Vector2(cardTextHeader.sizeDelta.x * magnification_x, cardTextHeader.sizeDelta.y * magnification_y);
        cardTextHeader_middle.sizeDelta = new Vector2(cardTextHeader_middle.sizeDelta.x * magnification_x, cardTextHeader_middle.sizeDelta.y * magnification_y);
        powerToughness.sizeDelta = new Vector2(powerToughness.sizeDelta.x * magnification_x, powerToughness.sizeDelta.y * magnification_y);
        expantionName.sizeDelta = new Vector2(expantionName.sizeDelta.x * magnification_x, expantionName.sizeDelta.y * magnification_y);
        expantionName_expantion.sizeDelta = new Vector2(expantionName_expantion.sizeDelta.x * magnification_x, expantionName_expantion.sizeDelta.y * magnification_y);
        expantionName_power.sizeDelta = new Vector2(expantionName_power.sizeDelta.x * magnification_x, expantionName_power.sizeDelta.y * magnification_y);
        expantionName_power_power.sizeDelta = new Vector2(expantionName_power_power.sizeDelta.x * magnification_x, expantionName_power_power.sizeDelta.y * magnification_y);
        expantionName_toughness.sizeDelta = new Vector2(expantionName_toughness.sizeDelta.x * magnification_x, expantionName_toughness.sizeDelta.y * magnification_y);
        expantionName_toughness_toughness.sizeDelta = new Vector2(expantionName_toughness_toughness.sizeDelta.x * magnification_x, expantionName_toughness_toughness.sizeDelta.y * magnification_y);
        titleHeader.sizeDelta = new Vector2(titleHeader.sizeDelta.x * magnification_x, titleHeader.sizeDelta.y * magnification_y);
        titleHeader_title.sizeDelta = new Vector2(titleHeader_title.sizeDelta.x * magnification_x, titleHeader_title.sizeDelta.y * magnification_y);
        space1.sizeDelta = new Vector2(space1.sizeDelta.x * magnification_x, space1.sizeDelta.y * magnification_y);
        space2.sizeDelta = new Vector2(space2.sizeDelta.x * magnification_x, space2.sizeDelta.y * magnification_y);
        lores.sizeDelta = new Vector2(lores.sizeDelta.x * magnification_x, lores.sizeDelta.y * magnification_y);

        for(int i = 0; i < lores_loreList.Count; i++)
        {
            lores_loreList[i].sizeDelta = new Vector2(lores_loreList[i].sizeDelta.x * magnification_x, lores_loreList[i].sizeDelta.y * magnification_y);
        }

        rareHeader.sizeDelta = new Vector2(rareHeader.sizeDelta.x * magnification_x, rareHeader.sizeDelta.y * magnification_y);
        
        plusMinusHeader.sizeDelta = new Vector2(plusMinusHeader.sizeDelta.x * magnification_x, plusMinusHeader.sizeDelta.y * magnification_y);
        plusMinusHeader_label.sizeDelta = new Vector2(plusMinusHeader_label.sizeDelta.x * magnification_x, plusMinusHeader_label.sizeDelta.y * magnification_y);
        plusMinusHeader_space1.sizeDelta = new Vector2(plusMinusHeader_space1.sizeDelta.x * magnification_x, plusMinusHeader_space1.sizeDelta.y * magnification_y);

        plusMinusHeader_space2.sizeDelta = new Vector2(plusMinusHeader_space2.sizeDelta.x * magnification_x, plusMinusHeader_space2.sizeDelta.y * magnification_y);
        plusMinusHeader_count.sizeDelta = new Vector2(plusMinusHeader_count.sizeDelta.x * magnification_x, plusMinusHeader_count.sizeDelta.y * magnification_y);
        plusMinusHeader_space3.sizeDelta = new Vector2(plusMinusHeader_space3.sizeDelta.x * magnification_x, plusMinusHeader_space3.sizeDelta.y * magnification_y);

        plusMinusHeader_space4.sizeDelta = new Vector2(plusMinusHeader_space4.sizeDelta.x * magnification_x, plusMinusHeader_space4.sizeDelta.y * magnification_y);
        plusMinusHeader_label2.sizeDelta = new Vector2(plusMinusHeader_label2.sizeDelta.x * magnification_x, plusMinusHeader_label2.sizeDelta.y * magnification_y);


        float magnification = magnification_x;
        if (magnification_x > magnification_y)
        {
            magnification = magnification_y;
        }
        image.sizeDelta = new Vector2(image.sizeDelta.x * magnification, image.sizeDelta.y * magnification);
        rareHeader_rare.sizeDelta = new Vector2(rareHeader_rare.sizeDelta.x * magnification, rareHeader_rare.sizeDelta.y * magnification);
        plusMinusHeader_plus.sizeDelta = new Vector2(plusMinusHeader_plus.sizeDelta.x * magnification, plusMinusHeader_plus.sizeDelta.y * magnification);
        plusMinusHeader_minus.sizeDelta = new Vector2(plusMinusHeader_minus.sizeDelta.x * magnification, plusMinusHeader_minus.sizeDelta.y * magnification);
    }
}
