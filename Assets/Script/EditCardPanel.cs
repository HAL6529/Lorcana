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

    public GameObject ScrollView;

    public int cardCount;

    public List<GameObject> loreList;

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
        ScrollView.SetActive(false);
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
}
