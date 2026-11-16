using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchFilterClass
{
    public bool isInkAvailable;
    public bool isInkDisavailable;

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

    public bool r_common;
    public bool r_uncommon;
    public bool r_rare;
    public bool r_superrare;
    public bool r_legendary;
    public bool r_enchanted;

    public int inkcost_lowerlimit;
    public int inkcost_upperlimit;
    public int power_lowerlimit;
    public int power_upperlimit;
    public int toughness_lowerlimit;
    public int toughness_upperlimit;
    public int lores_lowerlimit;
    public int lores_upperlimit;

    public bool isAlly;
    public bool isAlien;
    public bool isBroom;
    public bool isCaptain;
    public bool isDetective;
    public bool isDeity;
    public bool isDinosaur;
    public bool isDragon;
    public bool isDreamBorn;
    public bool isFairy;
    public bool isFloodBorn;
    public bool isGargoyle;
    public bool isGiant;
    public bool isHero;
    public bool isHunny;
    public bool isHyena;
    public bool isIllusion;
    public bool isInventor;
    public bool isKing;
    public bool isKnight;
    public bool isMadrigal;
    public bool isMentor;
    public bool isMonster;
    public bool isMusketeer;
    public bool isPirate;
    public bool isPrince;
    public bool isPrincess;
    public bool isPuppy;
    public bool isQueen;
    public bool isRacer;
    public bool isRedPanda;
    public bool isRobot;
    public bool isSevenDwarf;
    public bool isStoryBorn;
    public bool isSorcerer;
    public bool isSuper;
    public bool isTeam;
    public bool isTigger;
    public bool isTitan;
    public bool isToy;
    public bool isVillain;
    public bool isVineling;

    public bool isBodyGuard;
    public bool isChallenger;
    public bool isEvasive;
    public bool isShift;
    public bool isSinger;
    public bool isSingTogether;
    public bool isSupport;
    public bool isReckless;
    public bool isResist;
    public bool isRush;
    public bool isVanish;
    public bool isWard;

    public EnumController.Title title;

    public SearchFilterClass()
    {
        isInkAvailable = true;
        isInkDisavailable = true;

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

        r_common = true;
        r_uncommon = true;
        r_rare = true;
        r_superrare = true;
        r_legendary = true;
        r_enchanted = true;

        inkcost_lowerlimit = 0;
        inkcost_upperlimit = 12;
        power_lowerlimit = 0;
        power_upperlimit = 12;
        toughness_lowerlimit = 0;
        toughness_upperlimit = 12;
        lores_lowerlimit = 0;
        lores_upperlimit = 5;

        isAlly = true;
        isAlien = true;
        isBroom = true;
        isCaptain = true;
        isDetective = true;
        isDeity = true;
        isDinosaur = true;
        isDragon = true;
        isDreamBorn = true;
        isFairy = true;
        isFloodBorn = true;
        isGargoyle = true;
        isGiant = true;
        isHero = true;
        isHunny = true;
        isHyena = true;
        isIllusion = true;
        isInventor = true;
        isKing = true;
        isKnight = true;
        isMadrigal = true;
        isMentor = true;
        isMonster = true;
        isMusketeer = true;
        isPirate = true;
        isPrince = true;
        isPrincess = true;
        isPuppy = true;
        isQueen = true;
        isRacer = true;
        isRedPanda = true;
        isRobot = true;
        isSevenDwarf = true;
        isStoryBorn = true;
        isSorcerer = true;
        isSuper = true;
        isTeam = true;
        isTigger = true;
        isTitan = true;
        isToy = true;
        isVillain = true;
        isVineling = true;

        isBodyGuard = false;
        isChallenger = false;
        isEvasive = false;
        isShift = false;
        isSinger = false;
        isSingTogether = false;
        isSupport = false;
        isReckless = false;
        isResist = false;
        isRush = false;
        isVanish = false;
        isWard = false;

        title = EnumController.Title.None;
    }

    public bool isSearchHit(CardInfo m_CardInfo)
    {
        bool inkwell =m_CardInfo.GetAvailableInk();
        bool inkwellJudge = false;

        if (isInkAvailable && inkwell)
        {
            inkwellJudge = true;
        }

        if (isInkDisavailable && !inkwell)
        {
            inkwellJudge = true;
        }

        if (!inkwellJudge)
        {
            return false;
        }

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

        EnumController.Rare rarity = m_CardInfo.GetRare();
        bool rarityJudge = false;
        if (r_common && rarity == EnumController.Rare.Common)
        {
            rarityJudge = true;
        }

        if(r_uncommon && rarity == EnumController.Rare.Uncommon)
        {
            rarityJudge = true;
        }

        if (r_rare && rarity == EnumController.Rare.Rare)
        {
            rarityJudge = true;
        }

        if (r_superrare && rarity == EnumController.Rare.SuperRare)
        {
            rarityJudge = true;
        }

        if (r_legendary && rarity == EnumController.Rare.Legendary)
        {
            rarityJudge = true;
        }

        if (r_enchanted && rarity == EnumController.Rare.Enchanted)
        {
            rarityJudge = true;
        }

        if (!rarityJudge)
        {
            return false;
        }

        bool inkcostJudge = false;
        int inkcost = m_CardInfo.GetInkCost();
        if (inkcost_lowerlimit == 0 && inkcost_upperlimit == 12)
        {
            inkcostJudge = true;
        }
        if (inkcost >= inkcost_lowerlimit && inkcost_upperlimit >= inkcost)
        {
            inkcostJudge = true;
        }

        if (!inkcostJudge)
        {
            return false;
        }

        bool powerJudge = false;
        int power = m_CardInfo.GetPower();
        if (power_lowerlimit == 0 && power_upperlimit == 12)
        {
            powerJudge = true;
        }
        if (power >= power_lowerlimit && power_upperlimit >= power)
        {
            powerJudge = true;
        }

        if (!powerJudge)
        {
            return false;
        }

        bool toughnessJudge = false;
        int toughness = m_CardInfo.GetToughness();
        if (toughness_lowerlimit == 0 && toughness_upperlimit == 12)
        {
            toughnessJudge = true;
        }
        if (toughness >= toughness_lowerlimit && toughness_upperlimit >= toughness)
        {
            toughnessJudge = true;
        }

        if (!toughnessJudge)
        {
            return false;
        }

        bool loresJudge = false;
        int lores = m_CardInfo.GetLore();
        if(lores_lowerlimit == 0 && lores_upperlimit == 5)
        {
            loresJudge = true;
        }
        if (lores >= lores_lowerlimit && lores_upperlimit >= lores)
        {
            loresJudge = true;
        }

        if (!loresJudge)
        {
            return false;
        }

        bool classJudge = false;
        List<EnumController.Class> classList = m_CardInfo.GetClassList();
        if (isAlly && classList.Contains(EnumController.Class.Ally))
        {
            classJudge = true;
        }

        if(isAlien && classList.Contains(EnumController.Class.Alien))
        {
            classJudge = true;
        }

        if(isBroom && classList.Contains(EnumController.Class.Broom))
        {
            classJudge = true;
        }

        if(isCaptain && classList.Contains(EnumController.Class.Captain))
        {
            classJudge = true;
        }

        if(isDetective && classList.Contains(EnumController.Class.Detective))
        {
            classJudge = true;
        }

        if(isDeity && classList.Contains(EnumController.Class.Deity))
        {
            classJudge = true;
        }

        if (isDinosaur && classList.Contains(EnumController.Class.Dinosaur))
        {
            classJudge = true;
        }

        if (isDragon && classList.Contains(EnumController.Class.Dragon))
        {
            classJudge = true;
        }

        if (isDreamBorn && classList.Contains(EnumController.Class.DreamBorn))
        {
            classJudge = true;
        }

        if (isFairy && classList.Contains(EnumController.Class.Fairy))
        {
            classJudge = true;
        }

        if (isFloodBorn && classList.Contains(EnumController.Class.FloodBorn))
        {
            classJudge = true;
        }

        if (isGargoyle && classList.Contains(EnumController.Class.Gargoyle))
        {
            classJudge = true;
        }

        if (isGiant && classList.Contains(EnumController.Class.Giant))
        {
            classJudge = true;
        }

        if (isHero && classList.Contains(EnumController.Class.Hero))
        {
            classJudge = true;
        }

        if (isHunny && classList.Contains(EnumController.Class.Hunny))
        {
            classJudge = true;
        }

        if (isHyena && classList.Contains(EnumController.Class.Hyena))
        {
            classJudge = true;
        }

        if (isIllusion && classList.Contains(EnumController.Class.Illusion))
        {
            classJudge = true;
        }

        if (isInventor && classList.Contains(EnumController.Class.Inventor))
        {
            classJudge = true;
        }

        if (isKing && classList.Contains(EnumController.Class.King))
        {
            classJudge = true;
        }

        if (isKnight && classList.Contains(EnumController.Class.Knight))
        {
            classJudge = true;
        }

        if (isMadrigal && classList.Contains(EnumController.Class.Madrigal))
        {
            classJudge = true;
        }

        if (isMentor && classList.Contains(EnumController.Class.Mentor))
        {
            classJudge = true;
        }

        if (isMonster && classList.Contains(EnumController.Class.Monster))
        {
            classJudge = true;
        }

        if (isMusketeer && classList.Contains(EnumController.Class.Musketeer))
        {
            classJudge = true;
        }

        if (isPirate && classList.Contains(EnumController.Class.Pirate))
        {
            classJudge = true;
        }

        if (isPrince && classList.Contains(EnumController.Class.Prince))
        {
            classJudge = true;
        }

        if (isPrincess && classList.Contains(EnumController.Class.Princess))
        {
            classJudge = true;
        }

        if (isPuppy && classList.Contains(EnumController.Class.Puppy))
        {
            classJudge = true;
        }

        if (isQueen && classList.Contains(EnumController.Class.Queen))
        {
            classJudge = true;
        }

        if (isRacer && classList.Contains(EnumController.Class.Racer))
        {
            classJudge = true;
        }

        if (isRedPanda && classList.Contains(EnumController.Class.RedPanda))
        {
            classJudge = true;
        }

        if (isRobot && classList.Contains(EnumController.Class.Robot))
        {
            classJudge = true;
        }

        if (isSevenDwarf && classList.Contains(EnumController.Class.SevenDwarfs))
        {
            classJudge = true;
        }

        if (isStoryBorn && classList.Contains(EnumController.Class.StoryBorn))
        {
            classJudge = true;
        }

        if (isSorcerer && classList.Contains(EnumController.Class.Sorcerer))
        {
            classJudge = true;
        }

        if (isSuper && classList.Contains(EnumController.Class.Super))
        {
            classJudge = true;
        }

        if (isTeam && classList.Contains(EnumController.Class.Team))
        {
            classJudge = true;
        }

        if (isTigger && classList.Contains(EnumController.Class.Tigger))
        {
            classJudge = true;
        }

        if (isTitan && classList.Contains(EnumController.Class.Titan))
        {
            classJudge = true;
        }

        if (isToy && classList.Contains(EnumController.Class.Toy))
        {
            classJudge = true;
        }

        if (isVillain && classList.Contains(EnumController.Class.Villain))
        {
            classJudge = true;
        }

        if (isVineling && classList.Contains(EnumController.Class.Vineling))
        {
            classJudge = true;
        }

        if (isAlly && isAlien && isBroom && isCaptain && isDetective && isDeity && isDinosaur && isDragon && isDreamBorn && isFairy && isFloodBorn
            && isGargoyle && isGiant && isHero && isHunny && isHyena && isIllusion && isInventor && isKing && isKnight && isMadrigal && isMentor && isMonster
            && isMusketeer && isPirate && isPrince && isPrincess && isPuppy && isQueen && isRacer && isRedPanda && isRobot && isSevenDwarf && isStoryBorn
            && isSorcerer && isSuper && isTeam && isTigger && isTitan && isToy && isVillain && isVineling)
        {
            classJudge = true;
        }

        if (!classJudge)
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
            && (keywordList.Contains(EnumController.KeywordAvility.Challenger1) 
            || keywordList.Contains(EnumController.KeywordAvility.Challenger2) 
            || keywordList.Contains(EnumController.KeywordAvility.Challenger3) 
            || keywordList.Contains(EnumController.KeywordAvility.Challenger4)
            || keywordList.Contains(EnumController.KeywordAvility.Challenger7)))
        {
            keywordJudge = true;
        }

        if (isEvasive && keywordList.Contains(EnumController.KeywordAvility.Evasive))
        {
            keywordJudge = true;
        }

        if (isShift 
            && (keywordList.Contains(EnumController.KeywordAvility.PuppyShift3)
            || keywordList.Contains(EnumController.KeywordAvility.Shift1)
            || keywordList.Contains(EnumController.KeywordAvility.Shift2)
            || keywordList.Contains(EnumController.KeywordAvility.Shift3)
            || keywordList.Contains(EnumController.KeywordAvility.Shift4)
            || keywordList.Contains(EnumController.KeywordAvility.Shift5)
            || keywordList.Contains(EnumController.KeywordAvility.Shift6)
            || keywordList.Contains(EnumController.KeywordAvility.Shift7)
            || keywordList.Contains(EnumController.KeywordAvility.ShiftDiscardAnActionCard)
            || keywordList.Contains(EnumController.KeywordAvility.ShiftDiscardAnCharacterCard)
            || keywordList.Contains(EnumController.KeywordAvility.ShiftDiscardAnLocationCard)
            || keywordList.Contains(EnumController.KeywordAvility.ShiftDiscardAnSongCard)
            || keywordList.Contains(EnumController.KeywordAvility.ShiftDiscard2Cards)
            || keywordList.Contains(EnumController.KeywordAvility.UniversalShift4)))
        {
            keywordJudge = true;
        }

        if (isSinger 
            && (keywordList.Contains(EnumController.KeywordAvility.Singer3)
            || keywordList.Contains(EnumController.KeywordAvility.Singer4)
            || keywordList.Contains(EnumController.KeywordAvility.Singer5)
            || keywordList.Contains(EnumController.KeywordAvility.Singer6)
            || keywordList.Contains(EnumController.KeywordAvility.Singer7)
            || keywordList.Contains(EnumController.KeywordAvility.Singer9)))
        {
            keywordJudge = true;
        }

        if (isResist 
            && (keywordList.Contains(EnumController.KeywordAvility.Resist1)
            || keywordList.Contains(EnumController.KeywordAvility.Resist2)
            || keywordList.Contains(EnumController.KeywordAvility.Resist3)))
        {
            keywordJudge = true;
        }

        if (isSingTogether 
            && (keywordList.Contains(EnumController.KeywordAvility.SingTogether6)
            || keywordList.Contains(EnumController.KeywordAvility.SingTogether7)
            || keywordList.Contains(EnumController.KeywordAvility.SingTogether8)
            || keywordList.Contains(EnumController.KeywordAvility.SingTogether10)))
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

        if (isVanish && keywordList.Contains(EnumController.KeywordAvility.Vanish))
        {
            keywordJudge = true;
        }

        if (!isBodyGuard && !isChallenger && !isEvasive && !isShift && !isSinger && !isResist && !isSupport && !isReckless && !isRush && !isWard && !isSingTogether && !isVanish)
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
