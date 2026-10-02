using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchFilterClass : MonoBehaviour
{
    public bool isAmethyst;
    public bool isAmber;
    public bool isEmerald;
    public bool isSapphire;
    public bool isSteel;
    public bool isRuby;

    public bool a_isAction;
    public bool a_isCharacter;
    public bool a_isLocation;
    public bool a_isItem;
    public bool a_isSong;

    public bool isBodyGuard;
    public bool isChallenger;
    public bool isEvasive;
    public bool isShift;
    public bool isSinger;
    public bool isSupport;
    public bool isReckless;
    public bool isRush;
    public bool isWard;

    public bool isHandDestraction;
    public bool isCIP;
    public bool isPIG;
    public bool isChallenge;
    public bool isAction;
    public bool isGetLore;
    public bool isLostLore;
    public bool isAddInk;
    public bool isItem;
    public bool isLocation;

    public EnumController.Title title;

    public SearchFilterClass()
    {
        isAmethyst = true;
        isAmber = true;
        isEmerald = true;
        isSapphire = true;
        isSteel = true;
        isRuby = true;

        a_isAction = true;
        a_isCharacter = true;
        a_isLocation = true;
        a_isItem = true;
        a_isSong = true;

        isBodyGuard = false;
        isChallenger = false;
        isEvasive = false;
        isShift = false;
        isSinger = false;
        isSupport = false;
        isReckless = false;
        isRush = false;
        isWard = false;

        isHandDestraction = false;
        isCIP = false;
        isPIG = false;
        isChallenge = false;
        isAction = false;
        isGetLore = false;
        isLostLore = false;
        isAddInk = false;
        isItem = false;
        isLocation = false;

        title = EnumController.Title.None;
    }

    public bool isSearchHit(CardInfo m_CardInfo)
    {
        List<EnumController.Colors> colorList = m_CardInfo.GetColor();
        bool colorJudge = false;
        if(isAmethyst && colorList.Contains(EnumController.Colors.Amethyst))
        {
            colorJudge = true;
        }

        if (isAmber && colorList.Contains(EnumController.Colors.Amber))
        {
            colorJudge = true;
        }

        if (isEmerald && colorList.Contains(EnumController.Colors.Emerald))
        {
            colorJudge = true;
        }

        if (isSapphire && colorList.Contains(EnumController.Colors.Sapphire))
        {
            colorJudge = true;
        }

        if (isSteel && colorList.Contains(EnumController.Colors.Steel))
        {
            colorJudge = true;
        }

        if (isRuby && colorList.Contains(EnumController.Colors.Ruby))
        {
            colorJudge = true;
        }

        if (!colorJudge)
        {
            return false;
        }

        EnumController.Type type = m_CardInfo.GetType();
        bool typeJudge = false;
        if(a_isAction && type == EnumController.Type.Action)
        {
            typeJudge = true;
        }

        if (a_isCharacter && type == EnumController.Type.Character)
        {
            typeJudge = true;
        }

        if (a_isLocation && type == EnumController.Type.Location)
        {
            typeJudge = true;
        }

        if (a_isItem && type == EnumController.Type.Item)
        {
            typeJudge = true;
        }

        if (a_isSong && type == EnumController.Type.Song)
        {
            typeJudge = true;
        }

        if (!typeJudge)
        {
            return false;
        }

        List<EnumController.KeywordAvility> keywordList = m_CardInfo.GetKeywordAvility();
        bool keywordJudge = false;
        if (isBodyGuard && keywordList.Contains(EnumController.KeywordAvility.Bodyguard))
        {
            keywordJudge = true;
        }

        if (isChallenger 
            && (keywordList.Contains(EnumController.KeywordAvility.Challenger2) 
            || keywordList.Contains(EnumController.KeywordAvility.Challenger3) 
            || keywordList.Contains(EnumController.KeywordAvility.Challenger4)))
        {
            keywordJudge = true;
        }

        if (isEvasive && keywordList.Contains(EnumController.KeywordAvility.Evasive))
        {
            keywordJudge = true;
        }

        if (isShift 
            && (keywordList.Contains(EnumController.KeywordAvility.Shift3)
            || keywordList.Contains(EnumController.KeywordAvility.Shift4)
            || keywordList.Contains(EnumController.KeywordAvility.Shift5)
            || keywordList.Contains(EnumController.KeywordAvility.Shift6)))
        {
            keywordJudge = true;
        }

        if (isSinger 
            && (keywordList.Contains(EnumController.KeywordAvility.Singer4)
            || keywordList.Contains(EnumController.KeywordAvility.Singer5)))
        {
            keywordJudge = true;
        }

        if (isSupport && keywordList.Contains(EnumController.KeywordAvility.Support))
        {
            keywordJudge = true;
        }

        if (isReckless && keywordList.Contains(EnumController.KeywordAvility.Reckless))
        {
            keywordJudge = true;
        }

        if (isRush && keywordList.Contains(EnumController.KeywordAvility.Rush))
        {
            keywordJudge = true;
        }

        if (isWard && keywordList.Contains(EnumController.KeywordAvility.Ward))
        {
            keywordJudge = true;
        }

        if (!isBodyGuard && !isChallenger && !isEvasive && !isShift && !isSinger && !isSupport && !isReckless && !isRush && !isWard)
        {
            keywordJudge = true;
        }

        if (!keywordJudge)
        {
            return false;
        }

        bool titleJudge = false;
        if (title != EnumController.Title.None && title == m_CardInfo.GetTitle())
        {
            titleJudge = true;
        }

        if(title == EnumController.Title.None)
        {
            titleJudge = true;
        }

        if (!titleJudge)
        {
            return false;
        }

        return true;
    }
}
