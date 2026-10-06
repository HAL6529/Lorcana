using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData
{
    private string DeckTitle = "";

    private CardInfo m_CardInfo = new CardInfo();

    private List<CardInfo> m_CardInfoList = new List<CardInfo>();

    private string SaveDataPass = "";

    private string colors1 = "None";
    private string colors2 = "None";

    private ExtendUtil m_ExtendUtil = new ExtendUtil();

    public SaveData()
    {

    }

    public SaveData(string s, string SaveDataPass)
    {
        string[] array = s.Split(',');
        List<string> list = new List<string>();

        for (int i = 0; i < array.Length; i++)
        {
            list.Add(array[i]);
        }

        if(list.Count > 0)
        {
            SetDeckTitle(list[0]);
        }

        if (list.Count > 1)
        {
            colors1 = list[1];
        }
        if (list.Count > 2)
        {
            colors2 = list[2];
        }

        if (list.Count > 3)
        {
            SetCardInfo(m_ExtendUtil.ConvertToCardInfoFromString(list[3]));
        }

        if (list.Count > 4)
        {
            for (int i = 4; i < list.Count; i++)
            {
                m_CardInfoList.Add(m_ExtendUtil.ConvertToCardInfoFromString(list[i]));
            }
        }

        SetSaveDataPass(SaveDataPass);
    }

    public string GetSaveDataPass()
    {
        return SaveDataPass;
    }

    public void SetSaveDataPass(string paramater)
    {
        SaveDataPass = paramater;
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

    public string GetColors1()
    {
        return colors1;
    }

    public string GetColors2()
    {
        return colors2;
    }
}
