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

    public RectTransform parent;
    public RectTransform closeBtn_Header;
    public RectTransform closeBtn_Header_closeBtn;
    public RectTransform space1;
    public RectTransform colorExplanation_Header;
    public RectTransform colorExplanation_Header_text1;
    public RectTransform colorExplanation_Header_text2;
    public RectTransform colors_Header;
    public RectTransform colors_Header_amethyst;
    public RectTransform colors_Header_amber;
    public RectTransform colors_Header_emerald;
    public RectTransform colors_Header_sapphire;
    public RectTransform colors_Header_steel;
    public RectTransform colors_Header_ruby;
    public RectTransform space2;
    public RectTransform typeExplanation_Header;
    public RectTransform typeExplanation_Header_text1;
    public RectTransform typeExplanation_Header_text2;
    public RectTransform type_Header;
    public RectTransform type_Header_action;
    public RectTransform type_Header_action_text;
    public RectTransform type_Header_character;
    public RectTransform type_Header_character_text;
    public RectTransform type_Header_location;
    public RectTransform type_Header_location_text;
    public RectTransform type_Header_item;
    public RectTransform type_Header_item_text;
    public RectTransform type_Header_song;
    public RectTransform type_Header_song_text;
    public RectTransform space3;
    public RectTransform keywordExplanation_header;
    public RectTransform keywordExplanation_header_text1;
    public RectTransform keywordExplanation_header_text2;
    public RectTransform keyword_header;
    public RectTransform keyword_header_left;
    public RectTransform keyword_header_left_bodyguard;
    public RectTransform keyword_header_left_bodyguard_btn;
    public RectTransform keyword_header_left_bodyguard_space;
    public RectTransform keyword_header_left_bodyguard_text;
    public RectTransform keyword_header_left_challenger;
    public RectTransform keyword_header_left_challenger_btn;
    public RectTransform keyword_header_left_challenger_space;
    public RectTransform keyword_header_left_challenger_text;
    public RectTransform keyword_header_left_evasive;
    public RectTransform keyword_header_left_evasive_btn;
    public RectTransform keyword_header_left_evasive_space;
    public RectTransform keyword_header_left_evasive_text;
    public RectTransform keyword_header_left_shift;
    public RectTransform keyword_header_left_shift_btn;
    public RectTransform keyword_header_left_shift_space;
    public RectTransform keyword_header_left_shift_text;
    public RectTransform keyword_header_left_singer;
    public RectTransform keyword_header_left_singer_btn;
    public RectTransform keyword_header_left_singer_space;
    public RectTransform keyword_header_left_singer_text;
    public RectTransform keyword_header_right;
    public RectTransform keyword_header_right_support;
    public RectTransform keyword_header_right_support_btn;
    public RectTransform keyword_header_right_support_space;
    public RectTransform keyword_header_right_support_text;
    public RectTransform keyword_header_right_reckless;
    public RectTransform keyword_header_right_reckless_btn;
    public RectTransform keyword_header_right_reckless_space;
    public RectTransform keyword_header_right_reckless_text;
    public RectTransform keyword_header_right_rush;
    public RectTransform keyword_header_right_rush_btn;
    public RectTransform keyword_header_right_rush_space;
    public RectTransform keyword_header_right_rush_text;
    public RectTransform keyword_header_right_ward;
    public RectTransform keyword_header_right_ward_btn;
    public RectTransform keyword_header_right_ward_space;
    public RectTransform keyword_header_right_ward_text;
    public RectTransform keyword_header_right_null;
    public RectTransform space4;
    public RectTransform abilityExplanation_header;
    public RectTransform abilityExplanation_header_text1;
    public RectTransform abilityExplanation_header_text2;
    public RectTransform ability_header;
    public RectTransform ability_header_left;
    public RectTransform ability_header_left_handDestruction;
    public RectTransform ability_header_left_handDestruction_btn;
    public RectTransform ability_header_left_handDestruction_space;
    public RectTransform ability_header_left_handDestruction_text;
    public RectTransform ability_header_left_CIP;
    public RectTransform ability_header_left_CIP_btn;
    public RectTransform ability_header_left_CIP_space;
    public RectTransform ability_header_left_CIP_text;
    public RectTransform ability_header_left_PIG;
    public RectTransform ability_header_left_PIG_btn;
    public RectTransform ability_header_left_PIG_space;
    public RectTransform ability_header_left_PIG_text;
    public RectTransform ability_header_left_challenge;
    public RectTransform ability_header_left_challenge_btn;
    public RectTransform ability_header_left_challenge_space;
    public RectTransform ability_header_left_challenge_text;
    public RectTransform ability_header_left_action;
    public RectTransform ability_header_left_action_btn;
    public RectTransform ability_header_left_action_space;
    public RectTransform ability_header_left_action_text;
    public RectTransform ability_header_right;
    public RectTransform ability_header_right_getLore;
    public RectTransform ability_header_right_getLore_btn;
    public RectTransform ability_header_right_getLore_space;
    public RectTransform ability_header_right_getLore_text;
    public RectTransform ability_header_right_lostLore;
    public RectTransform ability_header_right_lostLore_btn;
    public RectTransform ability_header_right_lostLore_space;
    public RectTransform ability_header_right_lostLore_text;
    public RectTransform ability_header_right_addInk;
    public RectTransform ability_header_right_addInk_btn;
    public RectTransform ability_header_right_addInk_space;
    public RectTransform ability_header_right_addInk_text;
    public RectTransform ability_header_right_item;
    public RectTransform ability_header_right_item_btn;
    public RectTransform ability_header_right_item_space;
    public RectTransform ability_header_right_item_text;
    public RectTransform ability_header_right_location;
    public RectTransform ability_header_right_locationbtn;
    public RectTransform ability_header_right_location_space;
    public RectTransform ability_header_right_location_text;
    public RectTransform space5;
    public RectTransform titleExplanation_header;
    public RectTransform titleExplanation_header_text1;
    public RectTransform titleExplanation_header_text2;
    public RectTransform title_header;
    public RectTransform title_header_dropdown;
    public RectTransform title_header_dropdown_Content;
    public RectTransform title_header_dropdown_Content_Item;
    public RectTransform title_header_dropdown_Content_Item_ItemBackGround;
    public RectTransform title_header_dropdown_Content_Item_Checkmark;
    public RectTransform title_header_dropdown_Content_Item_Label;
    public RectTransform space6;
    public RectTransform searchBtn_header;
    public RectTransform searchBtn;
    public RectTransform searchBtn_text;
    public RectTransform searchReset;
    public RectTransform searchReset_header;
    public RectTransform searchReset_header_text;
    public RectTransform searchReset_header_text_text;
    public RectTransform searchReset_header_Button;
    public RectTransform searchReset_header_space;

    public Dropdown m_TitleDropdown;
    public Text t_TitleDropdown;

    public ExtendUtil m_ExtendUtil = new ExtendUtil();

    public EditCardPanelManager m_EditCardPanelManager;

    public GameObject SerachObj;

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

    public void onSearchBtn()
    {
        SearchFilterClass m_SearchFilterClass = new SearchFilterClass();
        m_SearchFilterClass.isAmethyst = isAmethyst;
        m_SearchFilterClass.isAmber = isAmber;
        m_SearchFilterClass.isEmerald = isEmerald;
        m_SearchFilterClass.isSapphire = isSapphire;
        m_SearchFilterClass.isSteel = isSteel;
        m_SearchFilterClass.isRuby = isRuby;

        m_SearchFilterClass.a_isAction = a_isAction;
        m_SearchFilterClass.a_isCharacter = a_isCharacter;
        m_SearchFilterClass.a_isLocation = a_isLocation;
        m_SearchFilterClass.a_isItem = a_isItem;
        m_SearchFilterClass.a_isSong = a_isSong;

        m_SearchFilterClass.isBodyGuard = isBodyGuard;
        m_SearchFilterClass.isChallenger = isChallenger;
        m_SearchFilterClass.isEvasive = isEvasive;
        m_SearchFilterClass.isShift = isShift;
        m_SearchFilterClass.isSinger = isSinger;
        m_SearchFilterClass.isSupport = isSupport;
        m_SearchFilterClass.isReckless = isReckless;
        m_SearchFilterClass.isRush = isRush;
        m_SearchFilterClass.isWard = isWard;

        m_SearchFilterClass.isHandDestraction = isHandDestraction;
        m_SearchFilterClass.isCIP = isCIP;
        m_SearchFilterClass.isPIG = isPIG;
        m_SearchFilterClass.isChallenge = isChallenge;
        m_SearchFilterClass.isAction = isAction;
        m_SearchFilterClass.isGetLore = isGetLore;
        m_SearchFilterClass.isLostLore = isLostLore;
        m_SearchFilterClass.isAddInk = isAddInk;
        m_SearchFilterClass.isItem = isItem;
        m_SearchFilterClass.isLocation = isLocation;

        if(t_TitleDropdown.text == "--選択なし--")
        {
            m_SearchFilterClass.title = EnumController.Title.None;
        }
        else
        {
            m_SearchFilterClass.title = m_ExtendUtil.ConvertToTitleFromString(t_TitleDropdown.text);
        }

        m_EditCardPanelManager.Search(m_SearchFilterClass);
        SerachObj.SetActive(false);
    }

    public void onResetBtn()
    {
        isAmethyst = true;
        AmethystBtn.color = new(1, 1, 1, 1);
        isAmber = true;
        AmberBtn.color = new(1, 1, 1, 1);
        isEmerald = true;
        EmeraldBtn.color = new(1, 1, 1, 1);
        isSapphire = true;
        SapphireBtn.color = new(1, 1, 1, 1);
        isSteel = true;
        SteelBtn.color = new(1, 1, 1, 1);
        isRuby = true;
        RubyBtn.color = new(1, 1, 1, 1);

        a_isAction = true;
        a_ActionBtn.color = new(1, 1, 1, 1);
        a_isCharacter = true;
        a_CharacterBtn.color = new(1, 1, 1, 1);
        a_isLocation = true;
        a_LocationBtn.color = new(1, 1, 1, 1);
        a_isItem = true;
        a_ItemBtn.color = new(1, 1, 1, 1);
        a_isSong = true;
        a_SongBtn.color = new(1, 1, 1, 1);


        isBodyGuard = false;
        BodyGuardBtn.sprite = s_checkbtn_off;
        isChallenger = false;
        ChallengerBtn.sprite = s_checkbtn_off;
        isEvasive = false;
        EvasiveBtn.sprite = s_checkbtn_off;
        isShift = false;
        ShiftBtn.sprite = s_checkbtn_off;
        isSinger = false;
        SingerBtn.sprite = s_checkbtn_off;
        isSupport = false;
        SupportBtn.sprite = s_checkbtn_off;
        isReckless = false;
        RecklessBtn.sprite = s_checkbtn_off;
        isRush = false;
        RushBtn.sprite = s_checkbtn_off;
        isWard = false;
        WardBtn.sprite = s_checkbtn_off;

        isHandDestraction = false;
        HandDestractionBtn.sprite = s_checkbtn_off;
        isCIP = false;
        CIPBtn.sprite = s_checkbtn_off;
        isPIG = false;
        PIGBtn.sprite = s_checkbtn_off;
        isChallenge = false;
        ChallengeBtn.sprite = s_checkbtn_off;
        isAction = false;
        ActionBtn.sprite = s_checkbtn_off;
        isGetLore = false;
        GetLoreBtn.sprite = s_checkbtn_off;
        isLostLore = false;
        LostLoreBtn.sprite = s_checkbtn_off;
        isAddInk = false;
        AddInkBtn.sprite = s_checkbtn_off;
        isItem = false;
        ItemBtn.sprite = s_checkbtn_off;
        isLocation = false;
        LocationBtn.sprite = s_checkbtn_off;
    }

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        parent.sizeDelta = new Vector2(parent.sizeDelta.x * magnification_x, parent.sizeDelta.y * magnification_y);
        closeBtn_Header.sizeDelta = new Vector2(closeBtn_Header.sizeDelta.x * magnification_x, closeBtn_Header.sizeDelta.y * magnification_y);

        space1.sizeDelta = new Vector2(space1.sizeDelta.x * magnification_x, space1.sizeDelta.y * magnification_y);
        colorExplanation_Header.sizeDelta = new Vector2(colorExplanation_Header.sizeDelta.x * magnification_x, colorExplanation_Header.sizeDelta.y * magnification_y);
        colorExplanation_Header_text1.sizeDelta = new Vector2(colorExplanation_Header_text1.sizeDelta.x * magnification_x, colorExplanation_Header_text1.sizeDelta.y * magnification_y);
        colorExplanation_Header_text2.sizeDelta = new Vector2(colorExplanation_Header_text2.sizeDelta.x * magnification_x, colorExplanation_Header_text2.sizeDelta.y * magnification_y);
        colors_Header.sizeDelta = new Vector2(colors_Header.sizeDelta.x * magnification_x, colors_Header.sizeDelta.y * magnification_y);

        space2.sizeDelta = new Vector2(space2.sizeDelta.x * magnification_x, space2.sizeDelta.y * magnification_y);
        typeExplanation_Header.sizeDelta = new Vector2(typeExplanation_Header.sizeDelta.x * magnification_x, typeExplanation_Header.sizeDelta.y * magnification_y);
        typeExplanation_Header_text1.sizeDelta = new Vector2(typeExplanation_Header_text1.sizeDelta.x * magnification_x, typeExplanation_Header_text1.sizeDelta.y * magnification_y);
        typeExplanation_Header_text2.sizeDelta = new Vector2(typeExplanation_Header_text2.sizeDelta.x * magnification_x, typeExplanation_Header_text2.sizeDelta.y * magnification_y);
        type_Header.sizeDelta = new Vector2(type_Header.sizeDelta.x * magnification_x, type_Header.sizeDelta.y * magnification_y);

        space3.sizeDelta = new Vector2(space3.sizeDelta.x * magnification_x, space3.sizeDelta.y * magnification_y);
        keywordExplanation_header.sizeDelta = new Vector2(keywordExplanation_header.sizeDelta.x * magnification_x, keywordExplanation_header.sizeDelta.y * magnification_y);
        keywordExplanation_header_text1.sizeDelta = new Vector2(keywordExplanation_header_text1.sizeDelta.x * magnification_x, keywordExplanation_header_text1.sizeDelta.y * magnification_y);
        keywordExplanation_header_text2.sizeDelta = new Vector2(keywordExplanation_header_text2.sizeDelta.x * magnification_x, keywordExplanation_header_text2.sizeDelta.y * magnification_y);
        keyword_header.sizeDelta = new Vector2(keyword_header.sizeDelta.x * magnification_x, keyword_header.sizeDelta.y * magnification_y);
        keyword_header_left.sizeDelta = new Vector2(keyword_header_left.sizeDelta.x * magnification_x, keyword_header_left.sizeDelta.y * magnification_y);
        keyword_header_left_bodyguard.sizeDelta = new Vector2(keyword_header_left_bodyguard.sizeDelta.x * magnification_x, keyword_header_left_bodyguard.sizeDelta.y * magnification_y);

        keyword_header_left_bodyguard_space.sizeDelta = new Vector2(keyword_header_left_bodyguard_space.sizeDelta.x * magnification_x, keyword_header_left_bodyguard_space.sizeDelta.y * magnification_y);
        keyword_header_left_bodyguard_text.sizeDelta = new Vector2(keyword_header_left_bodyguard_text.sizeDelta.x * magnification_x, keyword_header_left_bodyguard_text.sizeDelta.y * magnification_y);
        keyword_header_left_challenger.sizeDelta = new Vector2(keyword_header_left_challenger.sizeDelta.x * magnification_x, keyword_header_left_challenger.sizeDelta.y * magnification_y);

        keyword_header_left_challenger_space.sizeDelta = new Vector2(keyword_header_left_challenger_space.sizeDelta.x * magnification_x, keyword_header_left_challenger_space.sizeDelta.y * magnification_y);
        keyword_header_left_challenger_text.sizeDelta = new Vector2(keyword_header_left_challenger_text.sizeDelta.x * magnification_x, keyword_header_left_challenger_text.sizeDelta.y * magnification_y);
        keyword_header_left_evasive.sizeDelta = new Vector2(keyword_header_left_evasive.sizeDelta.x * magnification_x, keyword_header_left_evasive.sizeDelta.y * magnification_y);

        keyword_header_left_evasive_space.sizeDelta = new Vector2(keyword_header_left_evasive_space.sizeDelta.x * magnification_x, keyword_header_left_evasive_space.sizeDelta.y * magnification_y);
        keyword_header_left_evasive_text.sizeDelta = new Vector2(keyword_header_left_evasive_text.sizeDelta.x * magnification_x, keyword_header_left_evasive_text.sizeDelta.y * magnification_y);
        keyword_header_left_shift.sizeDelta = new Vector2(keyword_header_left_shift.sizeDelta.x * magnification_x, keyword_header_left_shift.sizeDelta.y * magnification_y);

        keyword_header_left_shift_space.sizeDelta = new Vector2(keyword_header_left_shift_space.sizeDelta.x * magnification_x, keyword_header_left_shift_space.sizeDelta.y * magnification_y);
        keyword_header_left_shift_text.sizeDelta = new Vector2(keyword_header_left_shift_text.sizeDelta.x * magnification_x, keyword_header_left_shift_text.sizeDelta.y * magnification_y);
        keyword_header_left_singer.sizeDelta = new Vector2(keyword_header_left_singer.sizeDelta.x * magnification_x, keyword_header_left_singer.sizeDelta.y * magnification_y);

        keyword_header_left_singer_space.sizeDelta = new Vector2(keyword_header_left_singer_space.sizeDelta.x * magnification_x, keyword_header_left_singer_space.sizeDelta.y * magnification_y);
        keyword_header_left_singer_text.sizeDelta = new Vector2(keyword_header_left_singer_text.sizeDelta.x * magnification_x, keyword_header_left_singer_text.sizeDelta.y * magnification_y);
        keyword_header_right.sizeDelta = new Vector2(keyword_header_right.sizeDelta.x * magnification_x, keyword_header_right.sizeDelta.y * magnification_y);
        keyword_header_right_support.sizeDelta = new Vector2(keyword_header_right_support.sizeDelta.x * magnification_x, keyword_header_right_support.sizeDelta.y * magnification_y);

        keyword_header_right_support_space.sizeDelta = new Vector2(keyword_header_right_support_space.sizeDelta.x * magnification_x, keyword_header_right_support_space.sizeDelta.y * magnification_y);
        keyword_header_right_support_text.sizeDelta = new Vector2(keyword_header_right_support_text.sizeDelta.x * magnification_x, keyword_header_right_support_text.sizeDelta.y * magnification_y);
        keyword_header_right_reckless.sizeDelta = new Vector2(keyword_header_right_reckless.sizeDelta.x * magnification_x, keyword_header_right_reckless.sizeDelta.y * magnification_y);

        keyword_header_right_reckless_space.sizeDelta = new Vector2(keyword_header_right_reckless_space.sizeDelta.x * magnification_x, keyword_header_right_reckless_space.sizeDelta.y * magnification_y);
        keyword_header_right_reckless_text.sizeDelta = new Vector2(keyword_header_right_reckless_text.sizeDelta.x * magnification_x, keyword_header_right_reckless_text.sizeDelta.y * magnification_y);
        keyword_header_right_rush.sizeDelta = new Vector2(keyword_header_right_rush.sizeDelta.x * magnification_x, keyword_header_right_rush.sizeDelta.y * magnification_y);

        keyword_header_right_rush_space.sizeDelta = new Vector2(keyword_header_right_rush_space.sizeDelta.x * magnification_x, keyword_header_right_rush_space.sizeDelta.y * magnification_y);
        keyword_header_right_rush_text.sizeDelta = new Vector2(keyword_header_right_rush_text.sizeDelta.x * magnification_x, keyword_header_right_rush_text.sizeDelta.y * magnification_y);
        keyword_header_right_ward.sizeDelta = new Vector2(keyword_header_right_ward.sizeDelta.x * magnification_x, keyword_header_right_ward.sizeDelta.y * magnification_y);

        keyword_header_right_ward_space.sizeDelta = new Vector2(keyword_header_right_ward_space.sizeDelta.x * magnification_x, keyword_header_right_ward_space.sizeDelta.y * magnification_y);
        keyword_header_right_ward_text.sizeDelta = new Vector2(keyword_header_right_ward_text.sizeDelta.x * magnification_x, keyword_header_right_ward_text.sizeDelta.y * magnification_y);
        keyword_header_right_null.sizeDelta = new Vector2(keyword_header_right_null.sizeDelta.x * magnification_x, keyword_header_right_null.sizeDelta.y * magnification_y);
        space4.sizeDelta = new Vector2(space4.sizeDelta.x * magnification_x, space4.sizeDelta.y * magnification_y);
        abilityExplanation_header.sizeDelta = new Vector2(abilityExplanation_header.sizeDelta.x * magnification_x, abilityExplanation_header.sizeDelta.y * magnification_y);
        abilityExplanation_header_text1.sizeDelta = new Vector2(abilityExplanation_header_text1.sizeDelta.x * magnification_x, abilityExplanation_header_text1.sizeDelta.y * magnification_y);
        abilityExplanation_header_text2.sizeDelta = new Vector2(abilityExplanation_header_text2.sizeDelta.x * magnification_x, abilityExplanation_header_text2.sizeDelta.y * magnification_y);
        ability_header.sizeDelta = new Vector2(ability_header.sizeDelta.x * magnification_x, ability_header.sizeDelta.y * magnification_y);
        ability_header_left.sizeDelta = new Vector2(ability_header_left.sizeDelta.x * magnification_x, ability_header_left.sizeDelta.y * magnification_y);
        ability_header_left_handDestruction.sizeDelta = new Vector2(ability_header_left_handDestruction.sizeDelta.x * magnification_x, ability_header_left_handDestruction.sizeDelta.y * magnification_y);

        ability_header_left_handDestruction_space.sizeDelta = new Vector2(ability_header_left_handDestruction_space.sizeDelta.x * magnification_x, ability_header_left_handDestruction_space.sizeDelta.y * magnification_y);
        ability_header_left_handDestruction_text.sizeDelta = new Vector2(ability_header_left_handDestruction_text.sizeDelta.x * magnification_x, ability_header_left_handDestruction_text.sizeDelta.y * magnification_y);
        ability_header_left_CIP.sizeDelta = new Vector2(ability_header_left_CIP.sizeDelta.x * magnification_x, ability_header_left_CIP.sizeDelta.y * magnification_y);

        ability_header_left_CIP_space.sizeDelta = new Vector2(ability_header_left_CIP_space.sizeDelta.x * magnification_x, ability_header_left_CIP_space.sizeDelta.y * magnification_y);
        ability_header_left_CIP_text.sizeDelta = new Vector2(ability_header_left_CIP_text.sizeDelta.x * magnification_x, ability_header_left_CIP_text.sizeDelta.y * magnification_y);
        ability_header_left_PIG.sizeDelta = new Vector2(ability_header_left_PIG.sizeDelta.x * magnification_x, ability_header_left_PIG.sizeDelta.y * magnification_y);

        ability_header_left_PIG_space.sizeDelta = new Vector2(ability_header_left_PIG_space.sizeDelta.x * magnification_x, ability_header_left_PIG_space.sizeDelta.y * magnification_y);
        ability_header_left_PIG_text.sizeDelta = new Vector2(ability_header_left_PIG_text.sizeDelta.x * magnification_x, ability_header_left_PIG_text.sizeDelta.y * magnification_y);
        ability_header_left_challenge.sizeDelta = new Vector2(ability_header_left_challenge.sizeDelta.x * magnification_x, ability_header_left_challenge.sizeDelta.y * magnification_y);

        ability_header_left_challenge_space.sizeDelta = new Vector2(ability_header_left_challenge_space.sizeDelta.x * magnification_x, ability_header_left_challenge_space.sizeDelta.y * magnification_y);
        ability_header_left_challenge_text.sizeDelta = new Vector2(ability_header_left_challenge_text.sizeDelta.x * magnification_x, ability_header_left_challenge_text.sizeDelta.y * magnification_y);
        ability_header_left_action.sizeDelta = new Vector2(ability_header_left_action.sizeDelta.x * magnification_x, ability_header_left_action.sizeDelta.y * magnification_y);

        ability_header_left_action_space.sizeDelta = new Vector2(ability_header_left_action_space.sizeDelta.x * magnification_x, ability_header_left_action_space.sizeDelta.y * magnification_y);
        ability_header_left_action_text.sizeDelta = new Vector2(ability_header_left_action_text.sizeDelta.x * magnification_x, ability_header_left_action_text.sizeDelta.y * magnification_y);
        ability_header_right.sizeDelta = new Vector2(ability_header_right.sizeDelta.x * magnification_x, ability_header_right.sizeDelta.y * magnification_y);
        ability_header_right_getLore.sizeDelta = new Vector2(ability_header_right_getLore.sizeDelta.x * magnification_x, ability_header_right_getLore.sizeDelta.y * magnification_y);

        ability_header_right_getLore_space.sizeDelta = new Vector2(ability_header_right_getLore_space.sizeDelta.x * magnification_x, ability_header_right_getLore_space.sizeDelta.y * magnification_y);
        ability_header_right_getLore_text.sizeDelta = new Vector2(ability_header_right_getLore_text.sizeDelta.x * magnification_x, ability_header_right_getLore_text.sizeDelta.y * magnification_y);
        ability_header_right_lostLore.sizeDelta = new Vector2(ability_header_right_lostLore.sizeDelta.x * magnification_x, ability_header_right_lostLore.sizeDelta.y * magnification_y);

        ability_header_right_lostLore_space.sizeDelta = new Vector2(ability_header_right_lostLore_space.sizeDelta.x * magnification_x, ability_header_right_lostLore_space.sizeDelta.y * magnification_y);
        ability_header_right_lostLore_text.sizeDelta = new Vector2(ability_header_right_lostLore_text.sizeDelta.x * magnification_x, ability_header_right_lostLore_text.sizeDelta.y * magnification_y);
        ability_header_right_addInk.sizeDelta = new Vector2(ability_header_right_addInk.sizeDelta.x * magnification_x, ability_header_right_addInk.sizeDelta.y * magnification_y);

        ability_header_right_addInk_space.sizeDelta = new Vector2(ability_header_right_addInk_space.sizeDelta.x * magnification_x, ability_header_right_addInk_space.sizeDelta.y * magnification_y);
        ability_header_right_addInk_text.sizeDelta = new Vector2(ability_header_right_addInk_text.sizeDelta.x * magnification_x, ability_header_right_addInk_text.sizeDelta.y * magnification_y);
        ability_header_right_item.sizeDelta = new Vector2(ability_header_right_item.sizeDelta.x * magnification_x, ability_header_right_item.sizeDelta.y * magnification_y);

        ability_header_right_item_space.sizeDelta = new Vector2(ability_header_right_item_space.sizeDelta.x * magnification_x, ability_header_right_item_space.sizeDelta.y * magnification_y);
        ability_header_right_item_text.sizeDelta = new Vector2(ability_header_right_item_text.sizeDelta.x * magnification_x, ability_header_right_item_text.sizeDelta.y * magnification_y);
        ability_header_right_location.sizeDelta = new Vector2(ability_header_right_location.sizeDelta.x * magnification_x, ability_header_right_location.sizeDelta.y * magnification_y);

        ability_header_right_location_space.sizeDelta = new Vector2(ability_header_right_location_space.sizeDelta.x * magnification_x, ability_header_right_location_space.sizeDelta.y * magnification_y);
        ability_header_right_location_text.sizeDelta = new Vector2(ability_header_right_location_text.sizeDelta.x * magnification_x, ability_header_right_location_text.sizeDelta.y * magnification_y);
        space5.sizeDelta = new Vector2(space5.sizeDelta.x * magnification_x, space5.sizeDelta.y * magnification_y);
        titleExplanation_header.sizeDelta = new Vector2(titleExplanation_header.sizeDelta.x * magnification_x, titleExplanation_header.sizeDelta.y * magnification_y);
        titleExplanation_header_text1.sizeDelta = new Vector2(titleExplanation_header_text1.sizeDelta.x * magnification_x, titleExplanation_header_text1.sizeDelta.y * magnification_y);
        titleExplanation_header_text2.sizeDelta = new Vector2(titleExplanation_header_text2.sizeDelta.x * magnification_x, titleExplanation_header_text2.sizeDelta.y * magnification_y);
        title_header.sizeDelta = new Vector2(title_header.sizeDelta.x * magnification_x, title_header.sizeDelta.y * magnification_y);
        title_header_dropdown.sizeDelta = new Vector2(title_header_dropdown.sizeDelta.x * magnification_x, title_header_dropdown.sizeDelta.y * magnification_y);
        title_header_dropdown_Content.sizeDelta = new Vector2(title_header_dropdown_Content.sizeDelta.x * magnification_x, title_header_dropdown_Content.sizeDelta.y * magnification_y);
        title_header_dropdown_Content_Item.sizeDelta = new Vector2(title_header_dropdown_Content_Item.sizeDelta.x * magnification_x, title_header_dropdown_Content_Item.sizeDelta.y * magnification_y);
        title_header_dropdown_Content_Item_ItemBackGround.sizeDelta = new Vector2(title_header_dropdown_Content_Item_ItemBackGround.sizeDelta.x * magnification_x, title_header_dropdown_Content_Item_ItemBackGround.sizeDelta.y * magnification_y);
        title_header_dropdown_Content_Item_Checkmark.sizeDelta = new Vector2(title_header_dropdown_Content_Item_Checkmark.sizeDelta.x * magnification_x, title_header_dropdown_Content_Item_Checkmark.sizeDelta.y * magnification_y);
        title_header_dropdown_Content_Item_Label.sizeDelta = new Vector2(title_header_dropdown_Content_Item_Label.sizeDelta.x * magnification_x, title_header_dropdown_Content_Item_Label.sizeDelta.y * magnification_y);
        space6.sizeDelta = new Vector2(space6.sizeDelta.x * magnification_x, space6.sizeDelta.y * magnification_y);
        searchBtn_header.sizeDelta = new Vector2(searchBtn_header.sizeDelta.x * magnification_x, searchBtn_header.sizeDelta.y * magnification_y);
        searchReset.sizeDelta = new Vector2(searchReset.sizeDelta.x * magnification_x, searchReset.sizeDelta.y * magnification_y);
        searchReset_header.sizeDelta = new Vector2(searchReset_header.sizeDelta.x * magnification_x, searchReset_header.sizeDelta.y * magnification_y);
        searchReset_header_text.sizeDelta = new Vector2(searchReset_header_text.sizeDelta.x * magnification_x, searchReset_header_text.sizeDelta.y * magnification_y);
        searchReset_header_text_text.sizeDelta = new Vector2(searchReset_header_text_text.sizeDelta.x * magnification_x, searchReset_header_text_text.sizeDelta.y * magnification_y);
        searchReset_header_Button.sizeDelta = new Vector2(searchReset_header_Button.sizeDelta.x * magnification_x, searchReset_header_Button.sizeDelta.y * magnification_y);
        searchReset_header_space.sizeDelta = new Vector2(searchReset_header_space.sizeDelta.x * magnification_x, searchReset_header_space.sizeDelta.y * magnification_y);

        float magnification = magnification_x;
        if (magnification_x > magnification_y)
        {
            magnification = magnification_y;
        }

        closeBtn_Header_closeBtn.sizeDelta = new Vector2(closeBtn_Header_closeBtn.sizeDelta.x * magnification, closeBtn_Header_closeBtn.sizeDelta.y * magnification);
        colors_Header_amethyst.sizeDelta = new Vector2(colors_Header_amethyst.sizeDelta.x * magnification, colors_Header_amethyst.sizeDelta.y * magnification);
        colors_Header_amber.sizeDelta = new Vector2(colors_Header_amber.sizeDelta.x * magnification, colors_Header_amber.sizeDelta.y * magnification);
        colors_Header_emerald.sizeDelta = new Vector2(colors_Header_emerald.sizeDelta.x * magnification, colors_Header_emerald.sizeDelta.y * magnification);
        colors_Header_sapphire.sizeDelta = new Vector2(colors_Header_sapphire.sizeDelta.x * magnification, colors_Header_sapphire.sizeDelta.y * magnification);
        colors_Header_steel.sizeDelta = new Vector2(colors_Header_steel.sizeDelta.x * magnification, colors_Header_steel.sizeDelta.y * magnification);
        colors_Header_ruby.sizeDelta = new Vector2(colors_Header_ruby.sizeDelta.x * magnification, colors_Header_ruby.sizeDelta.y * magnification);

        type_Header_action.sizeDelta = new Vector2(type_Header_action.sizeDelta.x * magnification, type_Header_action.sizeDelta.y * magnification);
        type_Header_action_text.sizeDelta = new Vector2(type_Header_action_text.sizeDelta.x * magnification, type_Header_action_text.sizeDelta.y * magnification);
        type_Header_character.sizeDelta = new Vector2(type_Header_character.sizeDelta.x * magnification, type_Header_character.sizeDelta.y * magnification);
        type_Header_character_text.sizeDelta = new Vector2(type_Header_character_text.sizeDelta.x * magnification, type_Header_character_text.sizeDelta.y * magnification);
        type_Header_location.sizeDelta = new Vector2(type_Header_location.sizeDelta.x * magnification, type_Header_location.sizeDelta.y * magnification);
        type_Header_location_text.sizeDelta = new Vector2(type_Header_location_text.sizeDelta.x * magnification, type_Header_location_text.sizeDelta.y * magnification);
        type_Header_item.sizeDelta = new Vector2(type_Header_item.sizeDelta.x * magnification, type_Header_item.sizeDelta.y * magnification);
        type_Header_item_text.sizeDelta = new Vector2(type_Header_item_text.sizeDelta.x * magnification, type_Header_item_text.sizeDelta.y * magnification);
        type_Header_song.sizeDelta = new Vector2(type_Header_song.sizeDelta.x * magnification, type_Header_song.sizeDelta.y * magnification);
        type_Header_song_text.sizeDelta = new Vector2(type_Header_song_text.sizeDelta.x * magnification, type_Header_song_text.sizeDelta.y * magnification);

        keyword_header_left_bodyguard_btn.sizeDelta = new Vector2(keyword_header_left_bodyguard_btn.sizeDelta.x * magnification, keyword_header_left_bodyguard_btn.sizeDelta.y * magnification);
        keyword_header_left_challenger_btn.sizeDelta = new Vector2(keyword_header_left_challenger_btn.sizeDelta.x * magnification, keyword_header_left_challenger_btn.sizeDelta.y * magnification);
        keyword_header_left_evasive_btn.sizeDelta = new Vector2(keyword_header_left_evasive_btn.sizeDelta.x * magnification, keyword_header_left_evasive_btn.sizeDelta.y * magnification);
        keyword_header_left_shift_btn.sizeDelta = new Vector2(keyword_header_left_shift_btn.sizeDelta.x * magnification, keyword_header_left_shift_btn.sizeDelta.y * magnification);
        keyword_header_left_singer_btn.sizeDelta = new Vector2(keyword_header_left_singer_btn.sizeDelta.x * magnification, keyword_header_left_singer_btn.sizeDelta.y * magnification);
        keyword_header_right_support_btn.sizeDelta = new Vector2(keyword_header_right_support_btn.sizeDelta.x * magnification, keyword_header_right_support_btn.sizeDelta.y * magnification);
        keyword_header_right_reckless_btn.sizeDelta = new Vector2(keyword_header_right_reckless_btn.sizeDelta.x * magnification, keyword_header_right_reckless_btn.sizeDelta.y * magnification);
        keyword_header_right_rush_btn.sizeDelta = new Vector2(keyword_header_right_rush_btn.sizeDelta.x * magnification, keyword_header_right_rush_btn.sizeDelta.y * magnification);
        keyword_header_right_ward_btn.sizeDelta = new Vector2(keyword_header_right_ward_btn.sizeDelta.x * magnification, keyword_header_right_ward_btn.sizeDelta.y * magnification);

        ability_header_left_handDestruction_btn.sizeDelta = new Vector2(ability_header_left_handDestruction_btn.sizeDelta.x * magnification, ability_header_left_handDestruction_btn.sizeDelta.y * magnification);
        ability_header_left_CIP_btn.sizeDelta = new Vector2(ability_header_left_CIP_btn.sizeDelta.x * magnification, ability_header_left_CIP_btn.sizeDelta.y * magnification);
        ability_header_left_PIG_btn.sizeDelta = new Vector2(ability_header_left_PIG_btn.sizeDelta.x * magnification, ability_header_left_PIG_btn.sizeDelta.y * magnification);
        ability_header_left_challenge_btn.sizeDelta = new Vector2(ability_header_left_challenge_btn.sizeDelta.x * magnification, ability_header_left_challenge_btn.sizeDelta.y * magnification);
        ability_header_left_action_btn.sizeDelta = new Vector2(ability_header_left_action_btn.sizeDelta.x * magnification, ability_header_left_action_btn.sizeDelta.y * magnification);
        ability_header_right_getLore_btn.sizeDelta = new Vector2(ability_header_right_getLore_btn.sizeDelta.x * magnification, ability_header_right_getLore_btn.sizeDelta.y * magnification);
        ability_header_right_lostLore_btn.sizeDelta = new Vector2(ability_header_right_lostLore_btn.sizeDelta.x * magnification, ability_header_right_lostLore_btn.sizeDelta.y * magnification);
        ability_header_right_addInk_btn.sizeDelta = new Vector2(ability_header_right_addInk_btn.sizeDelta.x * magnification, ability_header_right_addInk_btn.sizeDelta.y * magnification);
        ability_header_right_item_btn.sizeDelta = new Vector2(ability_header_right_item_btn.sizeDelta.x * magnification, ability_header_right_item_btn.sizeDelta.y * magnification);
        ability_header_right_locationbtn.sizeDelta = new Vector2(ability_header_right_locationbtn.sizeDelta.x * magnification, ability_header_right_locationbtn.sizeDelta.y * magnification);
        searchBtn.sizeDelta = new Vector2(searchBtn.sizeDelta.x * magnification, searchBtn.sizeDelta.y * magnification);
        searchBtn_text.sizeDelta = new Vector2(searchBtn_text.sizeDelta.x * magnification, searchBtn_text.sizeDelta.y * magnification);
    }
}
