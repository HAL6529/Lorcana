using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchClass : MonoBehaviour
{
    public Sprite s_checkbtn_on;
    public Sprite s_checkbtn_off;

    public Image AmethystBtn;
    public Image AmberBtn;
    public Image EmeraldBtn;
    public Image SapphireBtn;
    public Image SteelBtn;
    public Image RubyBtn;

    public Image a_ActionBtn;
    public Image a_CharacterBtn;
    public Image a_LocationBtn;
    public Image a_ItemBtn;
    public Image a_SongBtn;

    public Image BodyGuardBtn;
    public Image ChallengerBtn;
    public Image EvasiveBtn;
    public Image ShiftBtn;
    public Image SingerBtn;
    public Image SupportBtn;
    public Image RecklessBtn;
    public Image RushBtn;
    public Image WardBtn;

    public Image HandDestractionBtn;
    public Image CIPBtn;
    public Image PIGBtn;
    public Image ChallengeBtn;
    public Image ActionBtn;
    public Image GetLoreBtn;
    public Image LostLoreBtn;
    public Image AddInkBtn;
    public Image ItemBtn;
    public Image LocationBtn;

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

    public Dropdown m_TitleDropdown;
    public Text t_TitleDropdown;

    private List<string> TitleDropdownList = new List<string>() { "--選択なし--", "アラジン", "不思議の国のアリス", "美女と野獣", "シンデレラ", 
                                                                    "ファンタジア", "アナと雪の女王", "ヘラクレス","塔の上のラプンツェル",
                                                                    "ラマになった王様","ライオンキング","リトル・マーメイド","プリンセスと魔法のキス",
                                                                    "王様の剣","トレジャー・プラネット","リロ・アンド・スティッチ",
                                                                    "ミッキーマウス","モアナと伝説の海","ムーラン","101匹わんちゃん",
                                                                    "ピーターパン","ロビン・フッド","眠れる森の美女","白雪姫"};

    void Start()
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

        m_TitleDropdown.ClearOptions();
        for(int i = 0; i < TitleDropdownList.Count; i++)
        {
            Dropdown.OptionData m_NewData = new Dropdown.OptionData();
            m_NewData.text = TitleDropdownList[i];
            m_TitleDropdown.options.Add(m_NewData);
        }
        t_TitleDropdown.text = "--選択なし--";  
    }

    public void Open()
    {
        this.gameObject.SetActive(true);
    }

    public void onCloseBtn()
    {
        this.gameObject.SetActive(false);
    }

    public void onAbilityBtn(string paramater)
    {
        switch (paramater)
        {
            case "HandDestraction":
                if (isHandDestraction)
                {
                    isHandDestraction = false;
                    HandDestractionBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    isHandDestraction = true;
                    HandDestractionBtn.sprite = s_checkbtn_on;
                }
                break;
            case "CIP":
                if (isCIP)
                {
                    isCIP = false;
                    CIPBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    isCIP = true;
                    CIPBtn.sprite = s_checkbtn_on;
                }
                break;
            case "PIG":
                if (isPIG)
                {
                    isPIG = false;
                    PIGBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    isPIG = true;
                    PIGBtn.sprite = s_checkbtn_on;
                }
                break;
            case "Challenge":
                if (isChallenge)
                {
                    isChallenge = false;
                    ChallengeBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    isChallenge = true;
                    ChallengeBtn.sprite = s_checkbtn_on;
                }
                break;
            case "Action":
                if (isAction)
                {
                    isAction = false;
                    ActionBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    isAction = true;
                    ActionBtn.sprite = s_checkbtn_on;
                }
                break;
            case "GetLore":
                if (isGetLore)
                {
                    isGetLore = false;
                    GetLoreBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    isGetLore = true;
                    GetLoreBtn.sprite = s_checkbtn_on;
                }
                break;
            case "LostLore":
                if (isLostLore)
                {
                    isLostLore = false;
                    LostLoreBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    isLostLore = true;
                    LostLoreBtn.sprite = s_checkbtn_on;
                }
                break;
            case "AddInk":
                if (isAddInk)
                {
                    isAddInk = false;
                    AddInkBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    isAddInk = true;
                    AddInkBtn.sprite = s_checkbtn_on;
                }
                break;
            case "Item":
                if (isItem)
                {
                    isItem = false;
                    ItemBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    isItem = true;
                    ItemBtn.sprite = s_checkbtn_on;
                }
                break;
            case "Location":
                if (isLocation)
                {
                    isLocation = false;
                    LocationBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    isLocation = true;
                    LocationBtn.sprite = s_checkbtn_on;
                }
                break;
        }
    }

    public void onColorBtn(string paramater)
    {
        switch (paramater)
        {
            case "Amethyst":
                if (isAmethyst)
                {
                    isAmethyst = false;
                    AmethystBtn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isAmethyst = true;
                    AmethystBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Amber":
                if (isAmber)
                {
                    isAmber = false;
                    AmberBtn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isAmber = true;
                    AmberBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Emerald":
                if (isEmerald)
                {
                    isEmerald = false;
                    EmeraldBtn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isEmerald = true;
                    EmeraldBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Sapphire":
                if (isSapphire)
                {
                    isSapphire = false;
                    SapphireBtn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isSapphire = true;
                    SapphireBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Steel":
                if (isSteel)
                {
                    isSteel = false;
                    SteelBtn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isSteel = true;
                    SteelBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Ruby":
                if (isRuby)
                {
                    isRuby = false;
                    RubyBtn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isRuby = true;
                    RubyBtn.color = new(1, 1, 1, 1);
                }
                break;
        }
    }

    public void onKeywordAbilityBtn(string paramater)
    {
        switch (paramater)
        {
            case "Bodyguard":
                if (isBodyGuard)
                {
                    this.isBodyGuard = false;
                    BodyGuardBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    this.isBodyGuard = true;
                    BodyGuardBtn.sprite = s_checkbtn_on;
                }
                break;
            case "Challenger":
                if (isChallenger)
                {
                    this.isChallenger = false;
                    ChallengerBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    this.isChallenger = true;
                    ChallengerBtn.sprite = s_checkbtn_on;
                }
                break;
            case "Evasive":
                if (isEvasive)
                {
                    this.isEvasive = false;
                    EvasiveBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    this.isEvasive = true;
                    EvasiveBtn.sprite = s_checkbtn_on;
                }
                break;
            case "Shift":
                if (isShift)
                {
                    this.isShift = false;
                    ShiftBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    this.isShift = true;
                    ShiftBtn.sprite = s_checkbtn_on;
                }
                break;
            case "Singer":
                if (isSinger)
                {
                    this.isSinger = false;
                    SingerBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    this.isSinger = true;
                    SingerBtn.sprite = s_checkbtn_on;
                }
                break;
            case "Support":
                if (isSupport)
                {
                    this.isSupport = false;
                    SupportBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    this.isSupport = true;
                    SupportBtn.sprite = s_checkbtn_on;
                }
                break;
            case "Reckless":
                if (isReckless)
                {
                    this.isReckless = false;
                    RecklessBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    this.isReckless = true;
                    RecklessBtn.sprite = s_checkbtn_on;
                }
                break;
            case "Rush":
                if (isRush)
                {
                    this.isRush = false;
                    RushBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    this.isRush = true;
                    RushBtn.sprite = s_checkbtn_on;
                }
                break;
            case "Ward":
                if (isWard)
                {
                    this.isWard = false;
                    WardBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    this.isWard = true;
                    WardBtn.sprite = s_checkbtn_on;
                }
                break;
        }
        return;
    }

    public void onTypeBtn(string paramater)
    {
        switch (paramater)
        {
            case "Action":
                if (a_isAction)
                {
                    this.a_isAction = false;
                    a_ActionBtn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    this.a_isAction = true;
                    a_ActionBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Character":
                if (a_isCharacter)
                {
                    this.a_isCharacter = false;
                    a_CharacterBtn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    this.a_isCharacter = true;
                    a_CharacterBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Location":
                if (a_isLocation)
                {
                    this.a_isLocation = false;
                    a_LocationBtn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    this.a_isLocation = true;
                    a_LocationBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Item":
                if (a_isItem)
                {
                    this.a_isItem = false;
                    a_ItemBtn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    this.a_isItem = true;
                    a_ItemBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Song":
                if (a_isSong)
                {
                    this.a_isSong = false;
                    a_SongBtn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    this.a_isSong = true;
                    a_SongBtn.color = new(1, 1, 1, 1);
                }
                break;
        }
    }
}
