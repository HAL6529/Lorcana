using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SearchClass : MonoBehaviour
{
    public Sprite s_checkbtn_on;
    public Sprite s_checkbtn_off;

    public Image InkAvailableBtn;
    public Image InkDisavailableBtn;

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

    public Image r_commonBtn_background;
    public Image r_commonBtn;
    public Image r_uncommonBtn_background;
    public Image r_uncommonBtn;
    public Image r_rareBtn_background;
    public Image r_rareBtn;
    public Image r_superrareBtn_background;
    public Image r_superrareBtn;
    public Image r_legendaryBtn_background;
    public Image r_legendaryBtn;
    public Image r_enchantedBtn_background;
    public Image r_enchantedBtn;

    public Image BodyGuardBtn;
    public Image ChallengerBtn;
    public Image EvasiveBtn;
    public Image ShiftBtn;
    public Image SingerBtn;
    public Image SupportBtn;
    public Image RecklessBtn;
    public Image RushBtn;
    public Image WardBtn;

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

    public bool isBodyGuard;
    public bool isChallenger;
    public bool isEvasive;
    public bool isShift;
    public bool isSinger;
    public bool isSupport;
    public bool isReckless;
    public bool isRush;
    public bool isWard;

    public RectTransform parent;
    public RectTransform closeBtn_Header;
    public RectTransform closeBtn_Header_closeBtn;
    public RectTransform space1;
    public RectTransform r_ScrollView;
    public RectTransform r_ScrollView_content;
    public RectTransform InkwellExplanation_Header;
    public RectTransform InkwellExplanation_Header_text;
    public RectTransform Inkwell_Header;
    public RectTransform Inkwell_Header_available;
    public RectTransform Inkwell_Header_disavailable;
    public RectTransform space1_1;
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
    public RectTransform rarityExplanation_header;
    public RectTransform rarityExplanation_header_text1;
    public RectTransform rarityExplanation_header_text2;
    public RectTransform rarity_Header;
    public RectTransform rarity_Header_common;
    public RectTransform rarity_Header_common_image;
    public RectTransform rarity_Header_uncommon;
    public RectTransform rarity_Header_uncommon_image;
    public RectTransform rarity_Header_rare;
    public RectTransform rarity_Header_rare_image;
    public RectTransform rarity_Header_superrare;
    public RectTransform rarity_Header_superrare_image;
    public RectTransform rarity_Header_legendary;
    public RectTransform rarity_Header_legendary_image;
    public RectTransform rarity_Header_enchanted;
    public RectTransform rarity_Header_enchanted_image;
    public RectTransform space3_1;
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
    public RectTransform inkcostExplanation_header;
    public RectTransform inkcostExplanation_header_text;
    public RectTransform inkcost_header;
    public RectTransform inkcost_header_space;
    public RectTransform inkcost_header_lowerLimitText;
    public RectTransform inkcost_header_lowerDropdown;
    public RectTransform inkcost_header_space2;
    public RectTransform inkcost_header_upperLimitText;
    public RectTransform inkcost_header_upperDropdown;
    public RectTransform inkcost_header_space3;
    public RectTransform space5;
    public RectTransform powerExplanation_header;
    public RectTransform powerExplanation_header_text;
    public RectTransform power_header;
    public RectTransform power_header_space;
    public RectTransform power_header_lowerLimitText;
    public RectTransform power_header_lowerDropdown;
    public RectTransform power_header_space2;
    public RectTransform power_header_upperLimitText;
    public RectTransform power_header_upperDropdown;
    public RectTransform power_header_space3;
    public RectTransform space6;
    public RectTransform toughnessExplanation_header;
    public RectTransform toughnessExplanation_header_text;
    public RectTransform toughness_header;
    public RectTransform toughness_header_space;
    public RectTransform toughness_header_lowerLimitText;
    public RectTransform toughness_header_lowerDropdown;
    public RectTransform toughness_header_space2;
    public RectTransform toughness_header_upperLimitText;
    public RectTransform toughness_header_upperDropdown;
    public RectTransform toughness_header_space3;
    public RectTransform space7;
    public RectTransform loresExplanation_header;
    public RectTransform loresExplanation_header_text;
    public RectTransform lores_header;
    public RectTransform lores_header_space;
    public RectTransform lores_header_lowerLimitText;
    public RectTransform lores_header_lowerDropdown;
    public RectTransform lores_header_space2;
    public RectTransform lores_header_upperLimitText;
    public RectTransform lores_header_upperDropdown;
    public RectTransform lores_header_space3;
    public RectTransform space8;
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
    public RectTransform space9;
    public RectTransform searchBtn_header;
    public RectTransform searchBtn;
    public RectTransform searchBtn_text;
    public RectTransform searchReset;
    public RectTransform searchReset_header;
    public RectTransform searchReset_header_text;
    public RectTransform searchReset_header_text_text;
    public RectTransform searchReset_header_Button;
    public RectTransform searchReset_header_space;

    public Dropdown m_InkLowerLimitDropdown;
    public Dropdown m_InkUpperLimitDropdown;
    public Dropdown m_PowerLowerLimitDropdown;
    public Dropdown m_PowerUpperLimitDropdown;
    public Dropdown m_ToughnessLowerLimitDropdown;
    public Dropdown m_ToughnessUpperLimitDropdown;
    public Dropdown m_LoresLowerLimitDropdown;
    public Dropdown m_LoresUpperLimitDropdown;
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

        isBodyGuard = false;
        isChallenger = false;
        isEvasive = false;
        isShift = false;
        isSinger = false;
        isSupport = false;
        isReckless = false;
        isRush = false;
        isWard = false;

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

    public void onInkAvailable(string paramater)
    {
        switch (paramater)
        {
            case "Aavailable":
                if (isInkAvailable)
                {
                    this.isInkAvailable = false;
                    InkAvailableBtn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    this.isInkAvailable = true;
                    InkAvailableBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Disavailable":
                if (isInkDisavailable)
                {
                    this.isInkDisavailable = false;
                    InkDisavailableBtn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    this.isInkDisavailable = true;
                    InkDisavailableBtn.color = new(1, 1, 1, 1);
                }
                break;
        }
    }

    public void onInkCostChanged(string paramater)
    {
        switch (paramater)
        {
            case "Upper":
                if(m_InkLowerLimitDropdown.value > m_InkUpperLimitDropdown.value)
                {
                    m_InkLowerLimitDropdown.value = m_InkUpperLimitDropdown.value;
                }
                return; ;
            case "Lower":
                if (m_InkLowerLimitDropdown.value > m_InkUpperLimitDropdown.value)
                {
                    m_InkUpperLimitDropdown.value = m_InkLowerLimitDropdown.value;
                }
                return; ;
        }
    }

    public void onPowerChanged(string paramater)
    {
        switch (paramater)
        {
            case "Upper":
                if (m_PowerLowerLimitDropdown.value > m_PowerUpperLimitDropdown.value)
                {
                    m_PowerLowerLimitDropdown.value = m_PowerUpperLimitDropdown.value;
                }
                return; ;
            case "Lower":
                if (m_PowerLowerLimitDropdown.value > m_PowerUpperLimitDropdown.value)
                {
                    m_PowerUpperLimitDropdown.value = m_PowerLowerLimitDropdown.value;
                }
                return; ;
        }
    }

    public void onToughnessChanged(string paramater)
    {
        switch (paramater)
        {
            case "Upper":
                if (m_ToughnessLowerLimitDropdown.value > m_ToughnessUpperLimitDropdown.value)
                {
                    m_ToughnessLowerLimitDropdown.value = m_ToughnessUpperLimitDropdown.value;
                }
                return; ;
            case "Lower":
                if (m_ToughnessLowerLimitDropdown.value > m_ToughnessUpperLimitDropdown.value)
                {
                    m_ToughnessUpperLimitDropdown.value = m_ToughnessLowerLimitDropdown.value;
                }
                return; ;
        }
    }

    public void onLoresChanged(string paramater)
    {
        switch (paramater)
        {
            case "Upper":
                if (m_LoresLowerLimitDropdown.value > m_LoresUpperLimitDropdown.value)
                {
                    m_LoresLowerLimitDropdown.value = m_LoresUpperLimitDropdown.value;
                }
                return; ;
            case "Lower":
                if (m_LoresLowerLimitDropdown.value > m_LoresUpperLimitDropdown.value)
                {
                    m_LoresUpperLimitDropdown.value = m_LoresLowerLimitDropdown.value;
                }
                return; ;
        }
    }

    public void onSearchBtn()
    {
        SearchFilterClass m_SearchFilterClass = new SearchFilterClass();
        m_SearchFilterClass.isInkAvailable = isInkAvailable;
        m_SearchFilterClass.isInkDisavailable = isInkDisavailable;

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

        m_SearchFilterClass.r_common = r_common;
        m_SearchFilterClass.r_uncommon = r_uncommon;
        m_SearchFilterClass.r_rare = r_rare;
        m_SearchFilterClass.r_superrare = r_superrare;
        m_SearchFilterClass.r_legendary = r_legendary;
        m_SearchFilterClass.r_enchanted = r_enchanted;

        m_SearchFilterClass.inkcost_lowerlimit = m_InkLowerLimitDropdown.value;
        m_SearchFilterClass.inkcost_upperlimit = m_InkUpperLimitDropdown.value;
        m_SearchFilterClass.power_lowerlimit = m_PowerLowerLimitDropdown.value;
        m_SearchFilterClass.power_upperlimit = m_PowerUpperLimitDropdown.value;
        m_SearchFilterClass.toughness_lowerlimit = m_ToughnessLowerLimitDropdown.value;
        m_SearchFilterClass.toughness_upperlimit = m_ToughnessUpperLimitDropdown.value;
        m_SearchFilterClass.lores_lowerlimit = m_LoresLowerLimitDropdown.value;
        m_SearchFilterClass.lores_upperlimit = m_LoresUpperLimitDropdown.value;

        m_SearchFilterClass.isBodyGuard = isBodyGuard;
        m_SearchFilterClass.isChallenger = isChallenger;
        m_SearchFilterClass.isEvasive = isEvasive;
        m_SearchFilterClass.isShift = isShift;
        m_SearchFilterClass.isSinger = isSinger;
        m_SearchFilterClass.isSupport = isSupport;
        m_SearchFilterClass.isReckless = isReckless;
        m_SearchFilterClass.isRush = isRush;
        m_SearchFilterClass.isWard = isWard;

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

    public void onRarityBtn(string paramater)
    {
        switch (paramater)
        {
            case "Common":
                if (r_common)
                {
                    r_common = false;
                    r_commonBtn_background.color = new(200f / 255f, 200f / 255f, 200f / 255f, 50f / 255f);
                    r_commonBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);
                }
                else
                {
                    r_common = true;
                    r_commonBtn_background.color = new(1, 1, 1, 1);
                    r_commonBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Uncommon":
                if (r_uncommon)
                {
                    r_uncommon = false;
                    r_uncommonBtn_background.color = new(200f / 255f, 200f / 255f, 200f / 255f, 50f / 255f);
                    r_uncommonBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);
                }
                else
                {
                    r_uncommon = true;
                    r_uncommonBtn_background.color = new(1, 1, 1, 1);
                    r_uncommonBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Rare":
                if (r_rare)
                {
                    r_rare = false;
                    r_rareBtn_background.color = new(200f / 255f, 200f / 255f, 200f / 255f, 50f / 255f);
                    r_rareBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);
                }
                else
                {
                    r_rare = true;
                    r_rareBtn_background.color = new(1, 1, 1, 1);
                    r_rareBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "SuperRare":
                if (r_superrare)
                {
                    r_superrare = false;
                    r_superrareBtn_background.color = new(200f / 255f, 200f / 255f, 200f / 255f, 50f / 255f);
                    r_superrareBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);
                }
                else
                {
                    r_superrare = true;
                    r_superrareBtn_background.color = new(1, 1, 1, 1);
                    r_superrareBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Legendary":
                if (r_legendary)
                {
                    r_legendary = false;
                    r_legendaryBtn_background.color = new(200f / 255f, 200f / 255f, 200f / 255f, 50f / 255f);
                    r_legendaryBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);
                }
                else
                {
                    r_legendary = true;
                    r_legendaryBtn_background.color = new(1, 1, 1, 1);
                    r_legendaryBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Enchanted":
                if (r_enchanted)
                {
                    r_enchanted = false;
                    r_enchantedBtn_background.color = new(200f / 255f, 200f / 255f, 200f / 255f, 50f / 255f);
                    r_enchantedBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);
                }
                else
                {
                    r_enchanted = true;
                    r_enchantedBtn_background.color = new(1, 1, 1, 1);
                    r_enchantedBtn.color = new(1, 1, 1, 1);
                }
                break;
        }
    }

    public void onResetBtn()
    {
        isInkAvailable = true;
        InkAvailableBtn.color = new(1, 1, 1, 1);
        isInkDisavailable = true;
        InkDisavailableBtn.color = new(1, 1, 1, 1);

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

        r_common = true;
        r_commonBtn_background.color = new(1, 1, 1, 1);
        r_commonBtn.color = new(1, 1, 1, 1);
        r_uncommon = true;
        r_uncommonBtn_background.color = new(1, 1, 1, 1);
        r_uncommonBtn.color = new(1, 1, 1, 1);
        r_rare = true;
        r_rareBtn_background.color = new(1, 1, 1, 1);
        r_rareBtn.color = new(1, 1, 1, 1);
        r_superrare = true;
        r_superrareBtn_background.color = new(1, 1, 1, 1);
        r_superrareBtn.color = new(1, 1, 1, 1);
        r_legendary = true;
        r_legendaryBtn_background.color = new(1, 1, 1, 1);
        r_legendaryBtn.color = new(1, 1, 1, 1);
        r_enchanted = true;
        r_enchantedBtn_background.color = new(1, 1, 1, 1);
        r_enchantedBtn.color = new(1, 1, 1, 1);

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

        m_InkLowerLimitDropdown.value = 0;
        m_InkUpperLimitDropdown.value = 12;
        m_PowerLowerLimitDropdown.value = 0;
        m_PowerUpperLimitDropdown.value = 12;
        m_ToughnessLowerLimitDropdown.value = 0;
        m_ToughnessUpperLimitDropdown.value = 12;
        m_LoresLowerLimitDropdown.value = 0;
        m_LoresUpperLimitDropdown.value = 5;
        m_TitleDropdown.value = 0;
    }

    public void UpdateImage(float magnification_x, float magnification_y)
    {
        parent.sizeDelta = new Vector2(parent.sizeDelta.x * magnification_x, parent.sizeDelta.y * magnification_y);
        closeBtn_Header.sizeDelta = new Vector2(closeBtn_Header.sizeDelta.x * magnification_x, closeBtn_Header.sizeDelta.y * magnification_y);

        space1.sizeDelta = new Vector2(space1.sizeDelta.x * magnification_x, space1.sizeDelta.y * magnification_y);
        r_ScrollView.sizeDelta = new Vector2(r_ScrollView.sizeDelta.x * magnification_x, r_ScrollView.sizeDelta.y * magnification_y);
        r_ScrollView_content.sizeDelta = new Vector2(r_ScrollView_content.sizeDelta.x * magnification_x, r_ScrollView_content.sizeDelta.y * magnification_y);
        InkwellExplanation_Header.sizeDelta = new Vector2(InkwellExplanation_Header.sizeDelta.x * magnification_x, InkwellExplanation_Header.sizeDelta.y * magnification_y);
        InkwellExplanation_Header_text.sizeDelta = new Vector2(InkwellExplanation_Header_text.sizeDelta.x * magnification_x, InkwellExplanation_Header_text.sizeDelta.y * magnification_y);
        Inkwell_Header.sizeDelta = new Vector2(Inkwell_Header.sizeDelta.x * magnification_x, Inkwell_Header.sizeDelta.y * magnification_y);
        Inkwell_Header_available.sizeDelta = new Vector2(Inkwell_Header_available.sizeDelta.x * magnification_x, Inkwell_Header_available.sizeDelta.y * magnification_y);
        Inkwell_Header_disavailable.sizeDelta = new Vector2(Inkwell_Header_disavailable.sizeDelta.x * magnification_x, Inkwell_Header_disavailable.sizeDelta.y * magnification_y);

        space1_1.sizeDelta = new Vector2(space1_1.sizeDelta.x * magnification_x, space1_1.sizeDelta.y * magnification_y);
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
        rarityExplanation_header.sizeDelta = new Vector2(rarityExplanation_header.sizeDelta.x * magnification_x, rarityExplanation_header.sizeDelta.y * magnification_y);
        rarityExplanation_header_text1.sizeDelta = new Vector2(rarityExplanation_header_text1.sizeDelta.x * magnification_x, rarityExplanation_header_text1.sizeDelta.y * magnification_y);
        rarityExplanation_header_text2.sizeDelta = new Vector2(rarityExplanation_header_text2.sizeDelta.x * magnification_x, rarityExplanation_header_text2.sizeDelta.y * magnification_y);

        rarity_Header.sizeDelta = new Vector2(rarity_Header.sizeDelta.x * magnification_x, rarity_Header.sizeDelta.y * magnification_y);

        space3_1.sizeDelta = new Vector2(space3_1.sizeDelta.x * magnification_x, space3_1.sizeDelta.y * magnification_y);
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
        inkcostExplanation_header.sizeDelta = new Vector2(inkcostExplanation_header.sizeDelta.x * magnification_x, inkcostExplanation_header.sizeDelta.y * magnification_y);
        inkcostExplanation_header_text.sizeDelta = new Vector2(inkcostExplanation_header_text.sizeDelta.x * magnification_x, inkcostExplanation_header_text.sizeDelta.y * magnification_y);
        inkcost_header.sizeDelta = new Vector2(inkcost_header.sizeDelta.x * magnification_x, inkcost_header.sizeDelta.y * magnification_y);
        inkcost_header_space.sizeDelta = new Vector2(inkcost_header_space.sizeDelta.x * magnification_x, inkcost_header_space.sizeDelta.y * magnification_y);
        inkcost_header_lowerLimitText.sizeDelta = new Vector2(inkcost_header_lowerLimitText.sizeDelta.x * magnification_x, inkcost_header_lowerLimitText.sizeDelta.y * magnification_y);
        inkcost_header_lowerDropdown.sizeDelta = new Vector2(inkcost_header_lowerDropdown.sizeDelta.x * magnification_x, inkcost_header_lowerDropdown.sizeDelta.y * magnification_y);
        inkcost_header_space2.sizeDelta = new Vector2(inkcost_header_space2.sizeDelta.x * magnification_x, inkcost_header_space2.sizeDelta.y * magnification_y);
        inkcost_header_upperLimitText.sizeDelta = new Vector2(inkcost_header_upperLimitText.sizeDelta.x * magnification_x, inkcost_header_upperLimitText.sizeDelta.y * magnification_y);
        inkcost_header_upperDropdown.sizeDelta = new Vector2(inkcost_header_upperDropdown.sizeDelta.x * magnification_x, inkcost_header_upperDropdown.sizeDelta.y * magnification_y);
        inkcost_header_space3.sizeDelta = new Vector2(inkcost_header_space3.sizeDelta.x * magnification_x, inkcost_header_space3.sizeDelta.y * magnification_y);
        
        space5.sizeDelta = new Vector2(space5.sizeDelta.x * magnification_x, space5.sizeDelta.y * magnification_y);
        powerExplanation_header.sizeDelta = new Vector2(powerExplanation_header.sizeDelta.x * magnification_x, powerExplanation_header.sizeDelta.y * magnification_y);
        powerExplanation_header_text.sizeDelta = new Vector2(powerExplanation_header_text.sizeDelta.x * magnification_x, powerExplanation_header_text.sizeDelta.y * magnification_y);
        power_header.sizeDelta = new Vector2(power_header.sizeDelta.x * magnification_x, power_header.sizeDelta.y * magnification_y);
        power_header_space.sizeDelta = new Vector2(power_header_space.sizeDelta.x * magnification_x, power_header_space.sizeDelta.y * magnification_y);
        power_header_lowerLimitText.sizeDelta = new Vector2(power_header_lowerLimitText.sizeDelta.x * magnification_x, power_header_lowerLimitText.sizeDelta.y * magnification_y);
        power_header_lowerDropdown.sizeDelta = new Vector2(power_header_lowerDropdown.sizeDelta.x * magnification_x, power_header_lowerDropdown.sizeDelta.y * magnification_y);
        power_header_space2.sizeDelta = new Vector2(power_header_space2.sizeDelta.x * magnification_x, power_header_space2.sizeDelta.y * magnification_y);
        power_header_upperLimitText.sizeDelta = new Vector2(power_header_upperLimitText.sizeDelta.x * magnification_x, power_header_upperLimitText.sizeDelta.y * magnification_y);
        power_header_upperDropdown.sizeDelta = new Vector2(power_header_upperDropdown.sizeDelta.x * magnification_x, power_header_upperDropdown.sizeDelta.y * magnification_y);
        power_header_space3.sizeDelta = new Vector2(power_header_space3.sizeDelta.x * magnification_x, power_header_space3.sizeDelta.y * magnification_y);

        space6.sizeDelta = new Vector2(space6.sizeDelta.x * magnification_x, space6.sizeDelta.y * magnification_y);
        toughnessExplanation_header.sizeDelta = new Vector2(toughnessExplanation_header.sizeDelta.x * magnification_x, toughnessExplanation_header.sizeDelta.y * magnification_y);
        toughnessExplanation_header_text.sizeDelta = new Vector2(toughnessExplanation_header_text.sizeDelta.x * magnification_x, toughnessExplanation_header_text.sizeDelta.y * magnification_y);
        toughness_header.sizeDelta = new Vector2(toughness_header.sizeDelta.x * magnification_x, toughness_header.sizeDelta.y * magnification_y);
        toughness_header_space.sizeDelta = new Vector2(toughness_header_space.sizeDelta.x * magnification_x, toughness_header_space.sizeDelta.y * magnification_y);
        toughness_header_lowerLimitText.sizeDelta = new Vector2(toughness_header_lowerLimitText.sizeDelta.x * magnification_x, toughness_header_lowerLimitText.sizeDelta.y * magnification_y);
        toughness_header_lowerDropdown.sizeDelta = new Vector2(toughness_header_lowerDropdown.sizeDelta.x * magnification_x, toughness_header_lowerDropdown.sizeDelta.y * magnification_y);
        toughness_header_space2.sizeDelta = new Vector2(toughness_header_space2.sizeDelta.x * magnification_x, toughness_header_space2.sizeDelta.y * magnification_y);
        toughness_header_upperLimitText.sizeDelta = new Vector2(toughness_header_upperLimitText.sizeDelta.x * magnification_x, toughness_header_upperLimitText.sizeDelta.y * magnification_y);
        toughness_header_upperDropdown.sizeDelta = new Vector2(toughness_header_upperDropdown.sizeDelta.x * magnification_x, toughness_header_upperDropdown.sizeDelta.y * magnification_y);
        toughness_header_space3.sizeDelta = new Vector2(toughness_header_space3.sizeDelta.x * magnification_x, toughness_header_space3.sizeDelta.y * magnification_y);
        
        space7.sizeDelta = new Vector2(space7.sizeDelta.x * magnification_x, space7.sizeDelta.y * magnification_y);
        loresExplanation_header.sizeDelta = new Vector2(loresExplanation_header.sizeDelta.x * magnification_x, loresExplanation_header.sizeDelta.y * magnification_y);
        loresExplanation_header_text.sizeDelta = new Vector2(loresExplanation_header_text.sizeDelta.x * magnification_x, loresExplanation_header_text.sizeDelta.y * magnification_y);
        lores_header.sizeDelta = new Vector2(lores_header.sizeDelta.x * magnification_x, lores_header.sizeDelta.y * magnification_y);
        lores_header_space.sizeDelta = new Vector2(lores_header_space.sizeDelta.x * magnification_x, lores_header_space.sizeDelta.y * magnification_y);
        lores_header_lowerLimitText.sizeDelta = new Vector2(lores_header_lowerLimitText.sizeDelta.x * magnification_x, lores_header_lowerLimitText.sizeDelta.y * magnification_y);
        lores_header_lowerDropdown.sizeDelta = new Vector2(lores_header_lowerDropdown.sizeDelta.x * magnification_x, lores_header_lowerDropdown.sizeDelta.y * magnification_y);
        lores_header_space2.sizeDelta = new Vector2(lores_header_space2.sizeDelta.x * magnification_x, lores_header_space2.sizeDelta.y * magnification_y);
        lores_header_upperLimitText.sizeDelta = new Vector2(lores_header_upperLimitText.sizeDelta.x * magnification_x, lores_header_upperLimitText.sizeDelta.y * magnification_y);
        lores_header_upperDropdown.sizeDelta = new Vector2(lores_header_upperDropdown.sizeDelta.x * magnification_x, lores_header_upperDropdown.sizeDelta.y * magnification_y);
        lores_header_space3.sizeDelta = new Vector2(lores_header_space3.sizeDelta.x * magnification_x, lores_header_space3.sizeDelta.y * magnification_y);

        space8.sizeDelta = new Vector2(space8.sizeDelta.x * magnification_x, space8.sizeDelta.y * magnification_y);
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

        space9.sizeDelta = new Vector2(space9.sizeDelta.x * magnification_x, space9.sizeDelta.y * magnification_y);
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

        rarity_Header_common.sizeDelta = new Vector2(rarity_Header_common.sizeDelta.x * magnification, rarity_Header_common.sizeDelta.y * magnification);
        rarity_Header_common_image.sizeDelta = new Vector2(rarity_Header_common_image.sizeDelta.x * magnification, rarity_Header_common_image.sizeDelta.y * magnification);
        rarity_Header_uncommon.sizeDelta = new Vector2(rarity_Header_uncommon.sizeDelta.x * magnification, rarity_Header_uncommon.sizeDelta.y * magnification);
        rarity_Header_uncommon_image.sizeDelta = new Vector2(rarity_Header_uncommon_image.sizeDelta.x * magnification, rarity_Header_uncommon_image.sizeDelta.y * magnification);
        rarity_Header_rare.sizeDelta = new Vector2(rarity_Header_rare.sizeDelta.x * magnification, rarity_Header_rare.sizeDelta.y * magnification);
        rarity_Header_rare_image.sizeDelta = new Vector2(rarity_Header_rare_image.sizeDelta.x * magnification, rarity_Header_rare_image.sizeDelta.y * magnification);
        rarity_Header_superrare.sizeDelta = new Vector2(rarity_Header_superrare.sizeDelta.x * magnification, rarity_Header_superrare.sizeDelta.y * magnification);
        rarity_Header_superrare_image.sizeDelta = new Vector2(rarity_Header_superrare_image.sizeDelta.x * magnification, rarity_Header_superrare_image.sizeDelta.y * magnification);
        rarity_Header_legendary.sizeDelta = new Vector2(rarity_Header_legendary.sizeDelta.x * magnification, rarity_Header_legendary.sizeDelta.y * magnification);
        rarity_Header_legendary_image.sizeDelta = new Vector2(rarity_Header_legendary_image.sizeDelta.x * magnification, rarity_Header_legendary_image.sizeDelta.y * magnification);
        rarity_Header_enchanted.sizeDelta = new Vector2(rarity_Header_enchanted.sizeDelta.x * magnification, rarity_Header_enchanted.sizeDelta.y * magnification);
        rarity_Header_enchanted_image.sizeDelta = new Vector2(rarity_Header_enchanted_image.sizeDelta.x * magnification, rarity_Header_enchanted_image.sizeDelta.y * magnification);

        keyword_header_left_bodyguard_btn.sizeDelta = new Vector2(keyword_header_left_bodyguard_btn.sizeDelta.x * magnification, keyword_header_left_bodyguard_btn.sizeDelta.y * magnification);
        keyword_header_left_challenger_btn.sizeDelta = new Vector2(keyword_header_left_challenger_btn.sizeDelta.x * magnification, keyword_header_left_challenger_btn.sizeDelta.y * magnification);
        keyword_header_left_evasive_btn.sizeDelta = new Vector2(keyword_header_left_evasive_btn.sizeDelta.x * magnification, keyword_header_left_evasive_btn.sizeDelta.y * magnification);
        keyword_header_left_shift_btn.sizeDelta = new Vector2(keyword_header_left_shift_btn.sizeDelta.x * magnification, keyword_header_left_shift_btn.sizeDelta.y * magnification);
        keyword_header_left_singer_btn.sizeDelta = new Vector2(keyword_header_left_singer_btn.sizeDelta.x * magnification, keyword_header_left_singer_btn.sizeDelta.y * magnification);
        keyword_header_right_support_btn.sizeDelta = new Vector2(keyword_header_right_support_btn.sizeDelta.x * magnification, keyword_header_right_support_btn.sizeDelta.y * magnification);
        keyword_header_right_reckless_btn.sizeDelta = new Vector2(keyword_header_right_reckless_btn.sizeDelta.x * magnification, keyword_header_right_reckless_btn.sizeDelta.y * magnification);
        keyword_header_right_rush_btn.sizeDelta = new Vector2(keyword_header_right_rush_btn.sizeDelta.x * magnification, keyword_header_right_rush_btn.sizeDelta.y * magnification);
        keyword_header_right_ward_btn.sizeDelta = new Vector2(keyword_header_right_ward_btn.sizeDelta.x * magnification, keyword_header_right_ward_btn.sizeDelta.y * magnification);

        searchBtn.sizeDelta = new Vector2(searchBtn.sizeDelta.x * magnification, searchBtn.sizeDelta.y * magnification);
        searchBtn_text.sizeDelta = new Vector2(searchBtn_text.sizeDelta.x * magnification, searchBtn_text.sizeDelta.y * magnification);
    }
}
