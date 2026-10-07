using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataStatic
{
    private static string DeckTitle = "";

    private static CardInfo favoriteCard = new CardInfo();

    private static List<CardInfo> m_CardInfoList = new List<CardInfo>();

    private ExtendUtil m_ExtendUtil = new ExtendUtil();

    public SaveDataStatic()
    {

    }

    public SaveDataStatic(SaveData paramater)
    {
        SetDeckTitle(paramater.GetDeckTitle());
        SetFavoriteCardInfo(paramater.GetCardInfo());
        SetCardInfoList(paramater.GetCardInfoList());
    }

    public string GetDeckTitle()
    {
        return DeckTitle;
    }

    public void SetDeckTitle(string paramater)
    {
        DeckTitle = paramater;
    }

    public List<CardInfo> GetCardInfoList()
    {
        return m_CardInfoList;
    }

    public void SetCardInfoList(List<CardInfo> paramater)
    {
        m_CardInfoList = paramater;
    }

    public CardInfo GetFavoriteCardInfo()
    {
        return favoriteCard;
    }

    public void SetFavoriteCardInfo(CardInfo paramater)
    {
        favoriteCard = paramater;
    }
}
