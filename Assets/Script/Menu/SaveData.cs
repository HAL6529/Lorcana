using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveData
{
    private string DeckTitle = "";

    private CardInfo m_CardInfo = new CardInfo();

    private List<CardInfo> m_CardInfoList = new List<CardInfo>();

    private string SaveDataPass = "";

    private bool isAmethyst = false;
    private bool isAmber = false;
    private bool isEmerald = false;
    private bool isSapphire = false;
    private bool isSteel = false;
    private bool isRuby = false;

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
            if(list[1] == "Amethyst")
            {
                isAmethyst = true;
            }
            else
            {
                isAmethyst = false;
            }
        }

        if (list.Count > 2)
        {
            if (list[2] == "Amber")
            {
                isAmber = true;
            }
            else
            {
                isAmber = false;
            }
        }

        if (list.Count > 3)
        {
            if (list[3] == "Emerald")
            {
                isEmerald = true;
            }
            else
            {
                isEmerald = false;
            }
        }

        if (list.Count > 4)
        {
            if (list[4] == "Sapphire")
            {
                isSapphire = true;
            }
            else
            {
                isSapphire = false;
            }
        }

        if (list.Count > 5)
        {
            if (list[5] == "Steel")
            {
                isSteel = true;
            }
            else
            {
                isSteel = false;
            }
        }

        if (list.Count > 6)
        {
            if (list[6] == "Ruby")
            {
                isRuby = true;
            }
            else
            {
                isRuby = false;
            }
        }

        if (list.Count > 7)
        {
            SetCardInfo(m_ExtendUtil.ConvertToCardInfoFromString(list[7]));
        }

        if (list.Count > 8)
        {
            for (int i = 8; i < list.Count; i++)
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

    public bool GetIsAmethyst()
    {
        return isAmethyst;
    }

    public bool GetIsAmber()
    {
        return isAmber;
    }

    public bool GetIsEmerald()
    {
        return isEmerald;
    }

    public bool GetIsSapphire()
    {
        return isSapphire;
    }

    public bool GetisSteel()
    {
        return isSteel;
    }

    public bool GetIsRuby()
    {
        return isRuby;
    }
}
