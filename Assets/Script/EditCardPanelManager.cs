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

    public SaveDataStatic m_SaveDataStatic = new SaveDataStatic();
    public SearchClass m_SearchClass;
    public string DeckName = "";

    [SerializeField] private List<EditCardPanelTemp> EditCardPanelTempList_TheFirstChapter = new List<EditCardPanelTemp>();
    [SerializeField] private List<EditCardPanelTemp> EditCardPanelTempList_RiseOfTheFloodBorn = new List<EditCardPanelTemp>();
    [SerializeField] private List<EditCardPanelTemp> EditCardPanelTempList_IntoTheInkLands = new List<EditCardPanelTemp>();
    [SerializeField] private List<EditCardPanelTemp> EditCardPanelTempList_UrsulasReturn = new List<EditCardPanelTemp>();
    [SerializeField] private List<EditCardPanelTemp> EditCardPanelTempList_ShimmeringSkies = new List<EditCardPanelTemp>();
    [SerializeField] private List<EditCardPanelTemp> EditCardPanelTempList_ArchaziasIsland = new List<EditCardPanelTemp>();
    private List<EditCardPanelTemp> EditCardPanelTempList = new List<EditCardPanelTemp>();
    private List<EditCardPanelTemp> SortEditCardPanelTempList = new List<EditCardPanelTemp>();

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

    [SerializeField] private InfiniteScroll m_InfiniteScroll;
    public SearchFilterClass m_SearchFilterClass = new SearchFilterClass();
    public RectTransform CanvasRectTransform;

    void Start()
    {
        for (int i = 0; i < EditCardPanelTempList_TheFirstChapter.Count; i++)
        {
            EditCardPanelTempList.Add(EditCardPanelTempList_TheFirstChapter[i]);
        }
        for (int i = 0; i < EditCardPanelTempList_RiseOfTheFloodBorn.Count; i++)
        {
            EditCardPanelTempList.Add(EditCardPanelTempList_RiseOfTheFloodBorn[i]);
        }
        for (int i = 0; i < EditCardPanelTempList_IntoTheInkLands.Count; i++)
        {
            EditCardPanelTempList.Add(EditCardPanelTempList_IntoTheInkLands[i]);
        }
        for (int i = 0; i < EditCardPanelTempList_UrsulasReturn.Count; i++)
        {
            EditCardPanelTempList.Add(EditCardPanelTempList_UrsulasReturn[i]);
        }
        for (int i = 0; i < EditCardPanelTempList_ShimmeringSkies.Count; i++)
        {
            EditCardPanelTempList.Add(EditCardPanelTempList_ShimmeringSkies[i]);
        }
        for (int i = 0; i < EditCardPanelTempList_ArchaziasIsland.Count; i++)
        {
            EditCardPanelTempList.Add(EditCardPanelTempList_ArchaziasIsland[i]);
        }

        for (int i = 0;i < EditCardPanelTempList.Count; i++)
        {
            EditCardPanelTempList[i].SetIndex(i);
        }
        SortEditCardPanelTempList = EditCardPanelTempList;
    }

    public List<CardInfo> GetDeckList()
    {
        List<CardInfo> list = new List<CardInfo>();
        for (int i = 0; i < EditCardPanelTempList.Count; i++)
        {
            int cnt = EditCardPanelTempList[i].GetCardCount();
            if (cnt > 0)
            {
                for(int k = 0; k < cnt; k++)
                {
                    list.Add(EditCardPanelTempList[i].GetCardInfo());
                }
            }
        }
        return list;
    }

    public int GetEditCardPanelTempCount()
    {
        return SortEditCardPanelTempList.Count;
    }

    public EditCardPanelTemp GetEditCardPanelTemp(int itemCount)
    {
        if(itemCount > SortEditCardPanelTempList.Count - 1)
        {
            return new EditCardPanelTemp(null, 0);
        }
        return SortEditCardPanelTempList[itemCount];
    }

    public void LoadDeckList()
    {
        DeckName = m_SaveDataStatic.GetDeckTitle();
        List<CardInfo> TempDeckList = m_SaveDataStatic.GetCardInfoList();
        for (int i = 0; i < TempDeckList.Count; i++)
        {
            for (int k = 0; k < EditCardPanelTempList.Count; k++)
            {
                if (EditCardPanelTempList[k] == null)
                {
                    continue;
                }

                if (TempDeckList[i].GetCardNo() == EditCardPanelTempList[k].GetCardInfo().GetCardNo())
                {
                    EditCardPanelTempList[k].SetCardCount(EditCardPanelTempList[k].GetCardCount() + 1);
                    continue;
                }
            }
        }
        onDefaultSort();
    }

    public void onUpdateDeckList(int index, int cardCount)
    {
        EditCardPanelTempList[index].SetCardCount(cardCount);
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
                onDefaultSort();
                break;
            case SortStatus.InkSort:
                SortImage.sprite = InkSortIcon;
                onInkCostSort();
                break;
            case SortStatus.ColorSort:
                SortImage.sprite = ColorSortIcon;
                onColorSort();
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
                onDefaultSort();
                break;
            case SortStatus.InkSort:
                SortImage.sprite = InkSortIcon;
                onInkCostSort();
                break;
            case SortStatus.ColorSort:
                SortImage.sprite = ColorSortIcon;
                onColorSort();
                break;
        }
    }

    private void onDefaultSort()
    {
        SortEditCardPanelTempList = new List<EditCardPanelTemp>();
        for(int i = 0; i < EditCardPanelTempList.Count; i++)
        {
            if ((SwitchOwn && EditCardPanelTempList[i].GetCardCount() <= 0) || !m_SearchFilterClass.isSearchHit(EditCardPanelTempList[i].GetCardInfo()))
            {
                continue;
            }
            SortEditCardPanelTempList.Add(EditCardPanelTempList[i]);
        }
        m_InfiniteScroll.onResetValue();
    }

    private void onInkCostSort()
    {
        SortEditCardPanelTempList = new List<EditCardPanelTemp>();
        for(int i = 0; i < 11; i++)
        {
            for(int k = 0; k < EditCardPanelTempList.Count; k++)
            {
                if ((SwitchOwn && EditCardPanelTempList[k].GetCardCount() <= 0) || !m_SearchFilterClass.isSearchHit(EditCardPanelTempList[k].GetCardInfo()))
                {
                    continue;
                }

                if (EditCardPanelTempList[k].GetCardInfo().GetInkCost() == i)
                {
                    SortEditCardPanelTempList.Add(EditCardPanelTempList[k]);
                }
            }
        }
        m_InfiniteScroll.onResetValue();
    }

    private void onColorSort()
    {
        SortEditCardPanelTempList = new List<EditCardPanelTemp>();
        List<EditCardPanelTemp> AmberEditCardPanelTempList = new List<EditCardPanelTemp>();
        List<EditCardPanelTemp> AmethystEditCardPanelTempList = new List<EditCardPanelTemp>();
        List<EditCardPanelTemp> EmeraldEditCardPanelTempList = new List<EditCardPanelTemp>();
        List<EditCardPanelTemp> RubyEditCardPanelTempList = new List<EditCardPanelTemp>();
        List<EditCardPanelTemp> SapphireEditCardPanelTempList = new List<EditCardPanelTemp>();
        List<EditCardPanelTemp> SteelEditCardPanelTempList = new List<EditCardPanelTemp>();

        for (int i = 0; i < EditCardPanelTempList.Count; i++)
        {
            if ((SwitchOwn && EditCardPanelTempList[i].GetCardCount() <= 0) || !m_SearchFilterClass.isSearchHit(EditCardPanelTempList[i].GetCardInfo()))
            {
                continue;
            }
            List<EnumController.Colors> color = EditCardPanelTempList[i].GetCardInfo().GetColor();
            switch (color[0])
            {
                case EnumController.Colors.Amber:
                    AmberEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                    break;
                case EnumController.Colors.Amethyst:
                    AmethystEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                    break;
                case EnumController.Colors.Emerald:
                    EmeraldEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                    break;
                case EnumController.Colors.Ruby:
                    RubyEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                    break;
                case EnumController.Colors.Sapphire:
                    SapphireEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                    break;
                case EnumController.Colors.Steel:
                    SteelEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                    break;
                default:
                    break;
            }
        }

        for(int i = 0; i < AmberEditCardPanelTempList.Count; i++)
        {
            SortEditCardPanelTempList.Add(AmberEditCardPanelTempList[i]);
        }
        for (int i = 0; i < AmethystEditCardPanelTempList.Count; i++)
        {
            SortEditCardPanelTempList.Add(AmethystEditCardPanelTempList[i]);
        }
        for (int i = 0; i < EmeraldEditCardPanelTempList.Count; i++)
        {
            SortEditCardPanelTempList.Add(EmeraldEditCardPanelTempList[i]);
        }
        for (int i = 0; i < RubyEditCardPanelTempList.Count; i++)
        {
            SortEditCardPanelTempList.Add(RubyEditCardPanelTempList[i]);
        }
        for (int i = 0; i < SapphireEditCardPanelTempList.Count; i++)
        {
            SortEditCardPanelTempList.Add(SapphireEditCardPanelTempList[i]);
        }
        for (int i = 0; i < SteelEditCardPanelTempList.Count; i++)
        {
            SortEditCardPanelTempList.Add(SteelEditCardPanelTempList[i]);
        }

        m_InfiniteScroll.onResetValue();
    }

    public void Search(SearchFilterClass paramater)
    {
        m_SearchFilterClass = paramater;
        switch (m_SortStatus)
        {
            case SortStatus.Default:
                SortImage.sprite = DefaultSortIcon;
                onDefaultSort();
                break;
            case SortStatus.InkSort:
                SortImage.sprite = InkSortIcon;
                onInkCostSort();
                break;
            case SortStatus.ColorSort:
                SortImage.sprite = ColorSortIcon;
                onColorSort();
                break;
        }
    }
}

