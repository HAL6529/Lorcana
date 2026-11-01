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

    private class EditCardPanelTemp
    {
        private bool isSerachHit;
        private CardInfo m_CardInfo;
        private int cardCount;
        private int index;

        public EditCardPanelTemp(CardInfo m_CardInfo, int cardCount)
        {
            this.isSerachHit = true;
            this.m_CardInfo = m_CardInfo;
            this.cardCount = cardCount;
            this.index = 0;
        }

        public int GetCardCount() 
        {
            return cardCount;
        }

        public CardInfo GetCardInfo()
        {
            return m_CardInfo;
        }

        public bool GetIsSerachHit()
        {
            return isSerachHit;
        }

        public int GetIndex()
        {
            return index;
        }

        public void SetCardCount(int paramater)
        {
            cardCount = paramater;
        }

        public void SetCardInfo(CardInfo paramater)
        {
            m_CardInfo = paramater;
        }

        public void SetIsSerachHit(bool paramater)
        {
            isSerachHit = paramater;
        }

        public void SetIndex(int paramater)
        {
            index = paramater;
        }
    }

    public RectTransform parent;

    public SaveDataStatic m_SaveDataStatic = new SaveDataStatic();
    public SearchClass m_SearchClass;
    public string DeckName = "";

    public List<CardInfo> m_CardInfo_TheFirstChapter = new List<CardInfo>();
    private List<CardInfo> m_CardInfoList = new List<CardInfo>();
    public List<EditCardPanel> m_EditCardPanelList_TheFirstChapter = new List<EditCardPanel>();
    private List<EditCardPanel> m_EditCardPanelList = new List<EditCardPanel>();
    public List<CardInfo> DeckList = new List<CardInfo>();
    private List<EditCardPanelTemp> EditCardPanelTempList = new List<EditCardPanelTemp>();

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

    private int standbyCnt = 0;

    public SearchFilterClass m_SearchFilterClass = new SearchFilterClass();
    public List<RectTransform> rt_EditCardPanelList = new List<RectTransform>();
    public RectTransform rt_content;
    public RectTransform CanvasRectTransform;

    void Start()
    {
        m_CardInfoList = m_CardInfo_TheFirstChapter;

        for (int i = 0; i < m_CardInfoList.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(m_CardInfoList[i], 0));
            EditCardPanelTempList[i].SetIndex(i);
        }

        m_EditCardPanelList = m_EditCardPanelList_TheFirstChapter;

        float magnification_x = CanvasRectTransform.sizeDelta.x / 890;
        float magnification_y = CanvasRectTransform.sizeDelta.y / 1920;
        UpdateImage(magnification_x, magnification_y);
    }

    public void CheckStandby()
    {
        if(standbyCnt == m_EditCardPanelList.Count)
        {
            //m_SearchFilterClass = new SearchFilterClass();
            LoadDeckList();
        }
        else
        {
            standbyCnt++;
        }
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
        DeckList = new List<CardInfo>();
        for (int i = 0; i < m_EditCardPanelList.Count; i++)
        {
            if(m_EditCardPanelList[i] == null)
            {
                continue;
            }
            int t = m_EditCardPanelList[i].cardCount;
            if (t == 0)
            {
                continue;
            }
            for(int k = 0; k < t; k++)
            {
                DeckList.Add(m_EditCardPanelList[i].m_CardInfo);
            }
        }
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

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        parent.sizeDelta = new Vector2(parent.sizeDelta.x * magnification_x, parent.sizeDelta.y * magnification_y);
        float rt_EditCardPanelList_SizeY = 0;
        float size = 305 * magnification_y;
        if(m_EditCardPanelList.Count > 10)
        {
            for (int i = 0; i < 10; i++)
            {
                if (m_EditCardPanelList[i] == null || i > rt_EditCardPanelList.Count)
                {
                    continue;
                }
                StartCoroutine(EditCardPanelListInitialize(i, rt_EditCardPanelList_SizeY, magnification_x, magnification_y));
                rt_EditCardPanelList_SizeY += size;
            }
            rt_content.sizeDelta = new Vector2(rt_content.sizeDelta.x, rt_EditCardPanelList[0].sizeDelta.y * rt_EditCardPanelList.Count);
            for (int i = 10; i < m_EditCardPanelList.Count; i++)
            {
                if (m_EditCardPanelList[i] == null || i > rt_EditCardPanelList.Count)
                {
                    continue;
                }
                StartCoroutine(EditCardPanelListInitialize(i, rt_EditCardPanelList_SizeY, magnification_x, magnification_y));
                rt_EditCardPanelList_SizeY += size;
            }
        }
        else
        {
            for (int i = 0; i < m_EditCardPanelList.Count; i++)
            {
                if (m_EditCardPanelList[i] == null || i > rt_EditCardPanelList.Count)
                {
                    continue;
                }
                StartCoroutine(EditCardPanelListInitialize(i, rt_EditCardPanelList_SizeY, magnification_x, magnification_y));
                rt_EditCardPanelList_SizeY += size;
            }
            rt_content.sizeDelta = new Vector2(rt_content.sizeDelta.x, rt_EditCardPanelList[0].sizeDelta.y * rt_EditCardPanelList.Count);
        }
    }

    private IEnumerator EditCardPanelListInitialize(int index, float size, float magnification_x, float magnification_y)
    {
        Vector2 left_position = new Vector2(0, 1);
        rt_EditCardPanelList[index].anchorMin = left_position;
        rt_EditCardPanelList[index].anchorMax = left_position;
        rt_EditCardPanelList[index].pivot = left_position;
        rt_EditCardPanelList[index].anchoredPosition = new Vector2(0, size * (-1));
        m_EditCardPanelList[index].UpdateImage(magnification_x, magnification_y);
        if(index % 5 == 0)
        {
            yield return null;
        }
    }
}

