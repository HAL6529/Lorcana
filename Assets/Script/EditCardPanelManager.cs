using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditCardPanelManager : MonoBehaviour
{
    private enum SortStatus
    {
        Default,
        InkSort,
        ColorSort,
    }

    public RectTransform parent;

    public SaveDataStatic m_SaveDataStatic = new SaveDataStatic();
    public SearchClass m_SearchClass;
    public string DeckName = "";

    private List<CardInfo> m_CardInfo_TheFirstChapter = new List<CardInfo>();
    private List<CardInfo> m_CardInfoList = new List<CardInfo>();
    public List<CardInfo> DeckList = new List<CardInfo>();
    public List<EditCardPanelTemp> EditCardPanelTempList = new List<EditCardPanelTemp>();

    public Sprite Common;
    public Sprite UnCommon;
    public Sprite Rare;
    public Sprite SuperRare;
    public Sprite Legendary;
    public Sprite Enchanted;
    public Sprite Iconic;
    public Sprite Promo;

    public Sprite DefaultSortIcon;
    public Sprite InkSortIcon;
    public Sprite ColorSortIcon;
    public Sprite DeckAllSwitchBtn1;
    public Sprite DeckAllSwitchBtn2;

    public GameObject MenuObj;
    public Image SortImage;
    public Image DeckAllSwitchBtnImage;

    private SortStatus m_SortStatus = SortStatus.Default;

    public bool SwitchOwn = false;

    public SearchFilterClass m_SearchFilterClass = new SearchFilterClass();
    public List<RectTransform> rt_EditCardPanelList = new List<RectTransform>();
    public RectTransform rt_content;
    public RectTransform CanvasRectTransform;

    void Start()
    {
        m_CardInfoList = m_CardInfo_TheFirstChapter;

        for(int i = 0;i < EditCardPanelTempList.Count; i++)
        {
            EditCardPanelTempList[i].SetIndex(i);
        }
        rt_content.sizeDelta = new Vector2(rt_content.sizeDelta.x, 305 * 30);
    }

    public EditCardPanelTemp GetEditCardPanelTemp(int index)
    {
        return EditCardPanelTempList[index];
    }

    private void LoadDeckList()
    {
        /*onDefaultSort(m_CardInfoList);
        List<CardInfo> TempDeckList = m_SaveDataStatic.GetCardInfoList();
        DeckName = m_SaveDataStatic.GetDeckTitle();
        for (int i = 0; i < TempDeckList.Count; i++)
        {
            for (int k = 0; k < m_EditCardPanelList.Count; k++)
            {
                if (m_EditCardPanelList[k] == null)
                {
                    continue;
                }

                if(TempDeckList[i].GetCardNo() == m_EditCardPanelList[k].GetCardNo())
                {
                    m_EditCardPanelList[k].onPlusBtn();
                    continue;
                }
            }
        }*/
    }

    public void onUpdateDeckList()
    {

    }

    public void onSearchBtn()
    {
        m_SearchClass.Open();
    }

    public void onSwitchBtn()
    {
        if (SwitchOwn)
        {
            SwitchOwn = false;
        }
        else
        {
            SwitchOwn = true;
        }

        if (SwitchOwn)
        {
            DeckAllSwitchBtnImage.sprite = DeckAllSwitchBtn2;
        }
        else
        {
            DeckAllSwitchBtnImage.sprite = DeckAllSwitchBtn1;
        }

        switch (m_SortStatus)
        {
            case SortStatus.Default:
                SortImage.sprite = DefaultSortIcon;
                onDefaultSort(m_CardInfoList);
                break;
            case SortStatus.InkSort:
                SortImage.sprite = InkSortIcon;
                onInkCostSort(m_CardInfoList);
                break;
            case SortStatus.ColorSort:
                SortImage.sprite = ColorSortIcon;
                onColorSort(m_CardInfoList);
                break;
        }
    }

    public void onMenuBtn()
    {
        MenuObj.SetActive(true);
    }

    public void onSortBtn()
    {
        switch (m_SortStatus)
        {
            case SortStatus.Default:
                m_SortStatus = SortStatus.InkSort;
                break;
            case SortStatus.InkSort:
                m_SortStatus = SortStatus.ColorSort;
                break;
            case SortStatus.ColorSort:
                m_SortStatus = SortStatus.Default;
                break;
        }

        switch (m_SortStatus)
        {
            case SortStatus.Default:
                SortImage.sprite = DefaultSortIcon;
                onDefaultSort(m_CardInfoList);
                break;
            case SortStatus.InkSort:
                SortImage.sprite = InkSortIcon;
                onInkCostSort(m_CardInfoList);
                break;
            case SortStatus.ColorSort:
                SortImage.sprite = ColorSortIcon;
                onColorSort(m_CardInfoList);
                break;
        }
    }

    private void onDefaultSort(List<CardInfo> paramaterList)
    {
        /*List<EditCardPanelTemp> temp_return = EditCardPanelTempList;
        for(int i = 0; i < m_EditCardPanelList.Count; i++)
        {
            m_EditCardPanelList[i].SetEditCardPanel(EditCardPanelTempList[i].GetCardInfo(), EditCardPanelTempList[i].GetCardCount(), EditCardPanelTempList[i].GetIndex(), true);
        }*/
        /*List<EditCardPanelTemp> EditCardPanelTempList = new List<EditCardPanelTemp>();
        List<EditCardPanelTemp> temp_return = new List<EditCardPanelTemp>();

        for (int i = 0; i < m_EditCardPanelList.Count; i++)
        {
            if (m_EditCardPanelList[i] == null)
            {
                continue;
            }
            EditCardPanelTemp m_EditCardPanelTemp = new EditCardPanelTemp(m_EditCardPanelList[i].m_CardInfo, m_EditCardPanelList[i].cardCount);
            EditCardPanelTempList.Add(m_EditCardPanelTemp);
        }

        for (int k = 0; k < paramaterList.Count; k++)
        {
            for (int i = 0; i < EditCardPanelTempList.Count; i++)
            {
                if (EditCardPanelTempList[i] == null)
                {
                    continue;
                }

                if (EditCardPanelTempList[i].m_CardInfo == paramaterList[k])
                {
                    temp_return.Add(EditCardPanelTempList[i]);
                    EditCardPanelTempList[i] = null;
                    continue;
                }
            }
        }

        for (int i = 0; i < temp_return.Count; i++)
        {
            CardInfo c = temp_return[i].m_CardInfo;
            int n = temp_return[i].cardCount;
            m_EditCardPanelList[i].SetEditCardPanel(c, n);

            if (SwitchOwn)
            {
                if (n == 0)
                {
                    m_EditCardPanelList[i].SwitchActive(false);
                }
                else
                {
                    m_EditCardPanelList[i].SwitchActive(true);
                }
            }
        }

        for (int i = 0; i < m_EditCardPanelList.Count; i++)
        {
            if (m_EditCardPanelList[i] == null)
            {
                continue;
            }
            m_EditCardPanelList[i].isSearchHit();
        }*/
    }

    private void onInkCostSort(List<CardInfo> paramaterList)
    {
        /*List<EditCardPanelTemp> EditCardPanelTempList = new List<EditCardPanelTemp>();
        List<EditCardPanelTemp> temp_return = new List<EditCardPanelTemp>();

        for (int i = 0; i < m_EditCardPanelList.Count; i++)
        {
            if (m_EditCardPanelList[i] == null)
            {
                continue;
            }
            EditCardPanelTemp m_EditCardPanelTemp = new EditCardPanelTemp(m_EditCardPanelList[i].m_CardInfo, m_EditCardPanelList[i].cardCount);
            EditCardPanelTempList.Add(m_EditCardPanelTemp);
        }

        for(int k = 0; k < 11; k++)
        {
            for (int i = 0; i < EditCardPanelTempList.Count; i++)
            {
                if(EditCardPanelTempList[i] == null)
                {
                    continue;
                }

                if (EditCardPanelTempList[i].m_CardInfo.GetInkCost() == k)
                {
                    temp_return.Add(EditCardPanelTempList[i]);
                    EditCardPanelTempList[i] = null;
                    continue;
                }
            }
        }

        for (int i = 0; i < temp_return.Count; i++)
        {
            CardInfo c = temp_return[i].m_CardInfo;
            int n = temp_return[i].cardCount;
            m_EditCardPanelList[i].SetEditCardPanel(c, n);

            if (SwitchOwn)
            {
                if (n == 0)
                {
                    m_EditCardPanelList[i].SwitchActive(false);
                }
                else
                {
                    m_EditCardPanelList[i].SwitchActive(true);
                }
            }
        }

        for (int i = 0; i < m_EditCardPanelList.Count; i++)
        {
            if (m_EditCardPanelList[i] == null)
            {
                continue;
            }
            m_EditCardPanelList[i].isSearchHit();
        }*/
    }

    private void onColorSort(List<CardInfo> paramaterList)
    {
        /*onDefaultSort(paramaterList);
        List<EditCardPanelTemp> EditCardPanelTempList = new List<EditCardPanelTemp>();
        List<EditCardPanelTemp> temp_return = new List<EditCardPanelTemp>();

        for (int i = 0; i < m_EditCardPanelList.Count; i++)
        {
            if (m_EditCardPanelList[i] == null)
            {
                continue;
            }
            EditCardPanelTemp m_EditCardPanelTemp = new EditCardPanelTemp(m_EditCardPanelList[i].m_CardInfo, m_EditCardPanelList[i].cardCount);
            EditCardPanelTempList.Add(m_EditCardPanelTemp);
        }
        List<EnumController.Colors> enumColorList = new List<EnumController.Colors>() { EnumController.Colors.Amber, EnumController.Colors.Amethyst, EnumController.Colors.Emerald, EnumController.Colors.Ruby, EnumController.Colors.Sapphire, EnumController.Colors.Steel };


        for(int i = 0; i < EditCardPanelTempList.Count; i++)
        {
            List<EnumController.Colors> colors = EditCardPanelTempList[i].m_CardInfo.GetColor();
            if (colors.Contains(EnumController.Colors.Amber))
            {
                temp_return.Add(EditCardPanelTempList[i]);
            }
        }

        for (int i = 0; i < EditCardPanelTempList.Count; i++)
        {
            List<EnumController.Colors> colors = EditCardPanelTempList[i].m_CardInfo.GetColor();
            if (colors.Contains(EnumController.Colors.Amethyst))
            {
                temp_return.Add(EditCardPanelTempList[i]);
            }
        }

        for (int i = 0; i < EditCardPanelTempList.Count; i++)
        {
            List<EnumController.Colors> colors = EditCardPanelTempList[i].m_CardInfo.GetColor();
            if (colors.Contains(EnumController.Colors.Emerald))
            {
                temp_return.Add(EditCardPanelTempList[i]);
            }
        }

        for (int i = 0; i < EditCardPanelTempList.Count; i++)
        {
            List<EnumController.Colors> colors = EditCardPanelTempList[i].m_CardInfo.GetColor();
            if (colors.Contains(EnumController.Colors.Ruby))
            {
                temp_return.Add(EditCardPanelTempList[i]);
            }
        }


        for (int i = 0; i < EditCardPanelTempList.Count; i++)
        {
            List<EnumController.Colors> colors = EditCardPanelTempList[i].m_CardInfo.GetColor();
            if (colors.Contains(EnumController.Colors.Sapphire))
            {
                temp_return.Add(EditCardPanelTempList[i]);
            }
        }

        for (int i = 0; i < EditCardPanelTempList.Count; i++)
        {
            List<EnumController.Colors> colors = EditCardPanelTempList[i].m_CardInfo.GetColor();
            if (colors.Contains(EnumController.Colors.Steel))
            {
                temp_return.Add(EditCardPanelTempList[i]);
            }
        }

        for (int i = 0; i < temp_return.Count; i++)
        {
            CardInfo c = temp_return[i].m_CardInfo;
            int n = temp_return[i].cardCount;
            m_EditCardPanelList[i].SetEditCardPanel(c, n);

            if (SwitchOwn)
            {
                if (n == 0)
                {
                    m_EditCardPanelList[i].SwitchActive(false);
                }
                else
                {
                    m_EditCardPanelList[i].SwitchActive(true);
                }
            }
        }

        for (int i = 0; i < m_EditCardPanelList.Count; i++)
        {
            if (m_EditCardPanelList[i] == null)
            {
                continue;
            }
            m_EditCardPanelList[i].isSearchHit();
        }*/
    }

    public void Search(SearchFilterClass paramater)
    {
        m_SearchFilterClass = paramater;
        switch (m_SortStatus)
        {
            case SortStatus.Default:
                SortImage.sprite = DefaultSortIcon;
                onDefaultSort(m_CardInfoList);
                break;
            case SortStatus.InkSort:
                SortImage.sprite = InkSortIcon;
                onInkCostSort(m_CardInfoList);
                break;
            case SortStatus.ColorSort:
                SortImage.sprite = ColorSortIcon;
                onColorSort(m_CardInfoList);
                break;
        }
    }
}

