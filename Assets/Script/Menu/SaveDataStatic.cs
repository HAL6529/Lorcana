using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveDataStatic : MonoBehaviour
{
    private static string DeckTitle;

    private static CardInfo m_CardInfo;

    private static CardInfo favoriteCard;

    private static List<CardInfo> m_CardInfoList = new List<CardInfo>();

    private ExtendUtil m_ExtendUtil = new ExtendUtil();

    public SaveDataStatic(SaveData paramater)
    {
        SetDeckTitle(paramater.GetDeckTitle());
        SetCardInfo(paramater.GetCardInfo());
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

    public CardInfo GetCardInfo()
    {
        return m_CardInfo;
    }

    public void SetCardInfo(CardInfo paramater)
    {
        m_CardInfo = paramater;
    }

    public List<CardInfo> GetCardInfoList()
    {
        return m_CardInfoList;
    }

    public void SetCardInfoList(List<CardInfo> paramater)
    {
        m_CardInfoList = paramater;
    }
}
