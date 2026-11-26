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

    public Image r_commonBtn;
    public Image r_uncommonBtn;
    public Image r_rareBtn;
    public Image r_superrareBtn;
    public Image r_legendaryBtn;
    public Image r_epicBtn;
    public Image r_enchantedBtn;
    public Image r_iconicBtn;

    public Image b_StoryBorn;
    public Image b_DreamBorn;
    public Image b_FloodBorn;
    public Image b_SevenDwarf;
    public Image b_Illusion;
    public Image b_Vineling;
    public Image b_Villain;
    public Image b_Alien;
    public Image b_Gargoyle;
    public Image b_Captain;
    public Image b_Super;
    public Image b_Titan;
    public Image b_Team;
    public Image b_Tigger;
    public Image b_Toy;
    public Image b_Dragon;
    public Image b_Hyena;
    public Image b_Hunny;
    public Image b_Hero;
    public Image b_Prince;
    public Image b_Princess;
    public Image b_Broom;
    public Image b_Madrigal;
    public Image b_Monster;
    public Image b_Racer;
    public Image b_RedPanda;
    public Image b_Robot;
    public Image b_Ally;
    public Image b_Queen;
    public Image b_Fairy;
    public Image b_Puppy;
    public Image b_Mentor;
    public Image b_Giant;
    public Image b_Dinosaur;
    public Image b_Detective;
    public Image b_Pirate;
    public Image b_King;
    public Image b_Inventor;
    public Image b_Deity;
    public Image b_Musketeer;
    public Image b_Knight;
    public Image b_Sorcerer;

    public Image b_TheFirstChapter;
    public Image b_RiseOfTheFloodBorn;
    public Image b_IntoTheInkLands;
    public Image b_UrsulasReturn;
    public Image b_ShimmeringSkies;
    public Image b_AzuriteSea;
    public Image b_ArchaziasIsland;
    public Image b_ReignOfJafar;
    public Image b_Fabled_vol1;
    public Image b_Fabled_vol2;
    public Image b_WinterSpellInTheWell;
    public Image b_WinterSpell;
    public Image b_WildsUnknown;
    public Image b_AttackOfTheVine;
    public Image b_HyperiaCity;

    public Image BodyGuardBtn;
    public Image ChallengerBtn;
    public Image EvasiveBtn;
    public Image ShiftBtn;
    public Image SingerBtn;
    public Image ResistBtn;
    public Image AlertBtn;
    public Image SupportBtn;
    public Image RecklessBtn;
    public Image RushBtn;
    public Image WardBtn;
    public Image SingTogetherBtn;
    public Image VanishBtn;
    public Image AdventurousBtn;

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
    public bool r_epic;
    public bool r_enchanted;
    public bool r_iconic;

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

    public bool isTheFirstChapter;
    public bool isRiseOfTheFloodBorn;
    public bool isIntoTheInkLands;
    public bool isUrsulasReturn;
    public bool isShimmeringSkies;
    public bool isAzuriteSea;
    public bool isArchaziasIsland;
    public bool isReignOfJafar;
    public bool isFabled_vol1;
    public bool isFabled_vol2;
    public bool isWinterSpellInTheWell;
    public bool isWinterSpell;
    public bool isWildsUnknown;
    public bool isAttackOfTheVine;
    public bool isHyperiaCity;

    public bool isAdventurous;
    public bool isAlert;
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
    public RectTransform rarity_Header_space_1;
    public RectTransform rarity_Header_left;
    public RectTransform rarity_Header_left_space;
    public RectTransform rarity_Header_left_common;
    public RectTransform rarity_Header_left_space_1;
    public RectTransform rarity_Header_left_rare;
    public RectTransform rarity_Header_left_space_2;
    public RectTransform rarity_Header_left_legendary;
    public RectTransform rarity_Header_left_space_3;
    public RectTransform rarity_Header_left_enchanted;
    public RectTransform rarity_Header_left_space_4;
    public RectTransform rarity_Header_space_2;
    public RectTransform rarity_Header_right;
    public RectTransform rarity_Header_right_space;
    public RectTransform rarity_Header_right_uncommon;
    public RectTransform rarity_Header_right_space_1;
    public RectTransform rarity_Header_right_superrare;
    public RectTransform rarity_Header_right_space_2;
    public RectTransform rarity_Header_right_epic;
    public RectTransform rarity_Header_right_space_3;
    public RectTransform rarity_Header_right_iconic;
    public RectTransform rarity_Header_right_space_4;
    public RectTransform rarity_Header_space_3;
    public RectTransform space3_1;
    public RectTransform classExplanation_Header;
    public RectTransform classExplanation_Header_text1;
    public RectTransform classExplanation_Header_text2;
    public RectTransform class_Header;
    public RectTransform class_Header_space1;
    public RectTransform class_Header_line1;
    public RectTransform class_Header_line1_button1;
    public RectTransform class_Header_line1_button2;
    public RectTransform class_Header_line1_button3;
    public RectTransform class_Header_space2;
    public RectTransform class_Header_line2;
    public RectTransform class_Header_line2_button1;
    public RectTransform class_Header_line2_button2;
    public RectTransform class_Header_line2_button3;
    public RectTransform class_Header_space3;
    public RectTransform class_Header_line3;
    public RectTransform class_Header_line3_button1;
    public RectTransform class_Header_line3_button2;
    public RectTransform class_Header_line3_button3;
    public RectTransform class_Header_space4;
    public RectTransform class_Header_line4;
    public RectTransform class_Header_line4_button1;
    public RectTransform class_Header_line4_button2;
    public RectTransform class_Header_line4_button3;
    public RectTransform class_Header_space5;
    public RectTransform class_Header_line5;
    public RectTransform class_Header_line5_button1;
    public RectTransform class_Header_line5_button2;
    public RectTransform class_Header_line5_button3;
    public RectTransform class_Header_space6;
    public RectTransform class_Header_line6;
    public RectTransform class_Header_line6_button1;
    public RectTransform class_Header_line6_button2;
    public RectTransform class_Header_line6_button3;
    public RectTransform class_Header_space7;
    public RectTransform class_Header_line7;
    public RectTransform class_Header_line7_button1;
    public RectTransform class_Header_line7_button2;
    public RectTransform class_Header_line7_button3;
    public RectTransform class_Header_space8;
    public RectTransform class_Header_line8;
    public RectTransform class_Header_line8_button1;
    public RectTransform class_Header_line8_button2;
    public RectTransform class_Header_line8_button3;
    public RectTransform class_Header_space9;
    public RectTransform class_Header_line9;
    public RectTransform class_Header_line9_button1;
    public RectTransform class_Header_line9_button2;
    public RectTransform class_Header_line9_button3;
    public RectTransform class_Header_space10;
    public RectTransform class_Header_line10;
    public RectTransform class_Header_line10_button1;
    public RectTransform class_Header_line10_button2;
    public RectTransform class_Header_line10_button3;
    public RectTransform class_Header_space11;
    public RectTransform class_Header_line11;
    public RectTransform class_Header_line11_button1;
    public RectTransform class_Header_line11_button2;
    public RectTransform class_Header_line11_button3;
    public RectTransform class_Header_space12;
    public RectTransform class_Header_line12;
    public RectTransform class_Header_line12_button1;
    public RectTransform class_Header_line12_button2;
    public RectTransform class_Header_line12_button3;
    public RectTransform class_Header_space13;
    public RectTransform class_Header_line13;
    public RectTransform class_Header_line13_button1;
    public RectTransform class_Header_line13_button2;
    public RectTransform class_Header_line13_button3;
    public RectTransform class_Header_space14;
    public RectTransform class_Header_line14;
    public RectTransform class_Header_line14_button1;
    public RectTransform class_Header_line14_button2;
    public RectTransform class_Header_line14_button3;
    public RectTransform space3_2;
    public RectTransform expantionExplanation_Header;
    public RectTransform expantionExplanation_Header_text1;
    public RectTransform expantionExplanation_Header_text2;
    public RectTransform expantion_Header;
    public RectTransform expantion_Header_space;
    public RectTransform expantion_Header_button1;
    public RectTransform expantion_Header_space1;
    public RectTransform expantion_Header_button2;
    public RectTransform expantion_Header_space2;
    public RectTransform expantion_Header_button3;
    public RectTransform expantion_Header_space3;
    public RectTransform expantion_Header_button4;
    public RectTransform expantion_Header_space4;
    public RectTransform expantion_Header_button5;
    public RectTransform expantion_Header_space5;
    public RectTransform expantion_Header_button6;
    public RectTransform expantion_Header_space6;
    public RectTransform expantion_Header_button7;
    public RectTransform expantion_Header_space7;
    public RectTransform expantion_Header_button8;
    public RectTransform expantion_Header_space8;
    public RectTransform expantion_Header_button9;
    public RectTransform expantion_Header_space9;
    public RectTransform expantion_Header_button10;
    public RectTransform expantion_Header_space10;
    public RectTransform expantion_Header_button11;
    public RectTransform expantion_Header_space11;
    public RectTransform expantion_Header_button12;
    public RectTransform expantion_Header_space12;
    public RectTransform expantion_Header_button13;
    public RectTransform expantion_Header_space13;
    public RectTransform expantion_Header_button14;
    public RectTransform expantion_Header_space14;
    public RectTransform expantion_Header_button15;
    public RectTransform space3_3;
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
    public RectTransform keyword_header_left_resist;
    public RectTransform keyword_header_left_resist_btn;
    public RectTransform keyword_header_left_resist_space;
    public RectTransform keyword_header_left_resist_text;
    public RectTransform keyword_header_left_alert;
    public RectTransform keyword_header_left_alert_btn;
    public RectTransform keyword_header_left_alert_space;
    public RectTransform keyword_header_left_alert_text;
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
    public RectTransform keyword_header_right_singtogether;
    public RectTransform keyword_header_right_singtogether_btn;
    public RectTransform keyword_header_right_singtogether_space;
    public RectTransform keyword_header_right_singtogether_text;
    public RectTransform keyword_header_right_vanish;
    public RectTransform keyword_header_right_vanish_btn;
    public RectTransform keyword_header_right_vanish_space;
    public RectTransform keyword_header_right_vanish_text;
    public RectTransform keyword_header_right_adventurous;
    public RectTransform keyword_header_right_adventurous_btn;
    public RectTransform keyword_header_right_adventurous_space;
    public RectTransform keyword_header_right_adventurous_text;
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
    public RectTransform space10;
    public RectTransform searchReset;
    public RectTransform searchReset_header;
    public RectTransform searchReset_header_text;
    public RectTransform searchReset_header_Button;

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
        r_epic = true;
        r_enchanted = true;
        r_iconic = true;

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

        isTheFirstChapter = true;
        isRiseOfTheFloodBorn = true;
        isIntoTheInkLands = true;
        isUrsulasReturn = true;
        isShimmeringSkies = true;
        isAzuriteSea = true;
        isArchaziasIsland = true;
        isReignOfJafar = true;
        isFabled_vol1 = true;
        isFabled_vol2 = true;
        isWinterSpellInTheWell = true;
        isWinterSpell = true;
        isWildsUnknown = true;
        isAttackOfTheVine = true;
        isHyperiaCity = true;

        isAdventurous = false;
        isAlert = false;
        isBodyGuard = false;
        isChallenger = false;
        isEvasive = false;
        isShift = false;
        isSinger = false;
        isResist = false;
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

    public void onClassBtn(string paramater)
    {
        if (isAlly && isAlien && isBroom && isCaptain && isDetective && isDeity && isDinosaur && isDragon && isDreamBorn && isFairy && isFloodBorn
            && isGargoyle && isGiant && isHero && isHunny && isHyena && isIllusion && isInventor && isKing && isKnight && isMadrigal && isMentor && isMonster
            && isMusketeer && isPirate && isPrince && isPrincess && isPuppy && isQueen && isRacer && isRedPanda && isRobot && isSevenDwarf && isStoryBorn
            && isSorcerer && isSuper && isTeam && isTigger && isTitan && isToy && isVillain && isVineling)
        {
            isAlly = false;
            isAlien = false;
            isBroom = false;
            isCaptain = false;
            isDetective = false;
            isDeity = false;
            isDinosaur = false;
            isDragon = false;
            isDreamBorn = false;
            isFairy = false;
            isFloodBorn = false;
            isGargoyle = false;
            isGiant = false;
            isHero = false;
            isHunny = false;
            isHyena = false;
            isIllusion = false;
            isInventor = false;
            isKing = false;
            isKnight = false;
            isMadrigal = false;
            isMentor = false;
            isMonster = false;
            isMusketeer = false;
            isPirate = false;
            isPrince = false;
            isPrincess = false;
            isPuppy = false;
            isQueen = false;
            isRacer = false;
            isRedPanda = false;
            isRobot = false;
            isSevenDwarf = false;
            isStoryBorn = false;
            isSorcerer = false;
            isSuper = false;
            isTeam = false;
            isTigger = false;
            isTitan = false;
            isToy = false;
            isVillain = false;
            isVineling = false;

            b_StoryBorn.color = new(1, 1, 1, 50f / 255f);
            b_DreamBorn.color = new(1, 1, 1, 50f / 255f);
            b_FloodBorn.color = new(1, 1, 1, 50f / 255f);
            b_SevenDwarf.color = new(1, 1, 1, 50f / 255f);
            b_Illusion.color = new(1, 1, 1, 50f / 255f);
            b_Vineling.color = new(1, 1, 1, 50f / 255f);
            b_Villain.color = new(1, 1, 1, 50f / 255f);
            b_Alien.color = new(1, 1, 1, 50f / 255f);
            b_Gargoyle.color = new(1, 1, 1, 50f / 255f);
            b_Captain.color = new(1, 1, 1, 50f / 255f);
            b_Super.color = new(1, 1, 1, 50f / 255f);
            b_Titan.color = new(1, 1, 1, 50f / 255f);
            b_Team.color = new(1, 1, 1, 50f / 255f);
            b_Tigger.color = new(1, 1, 1, 50f / 255f);
            b_Toy.color = new(1, 1, 1, 50f / 255f);
            b_Dragon.color = new(1, 1, 1, 50f / 255f);
            b_Hyena.color = new(1, 1, 1, 50f / 255f);
            b_Hunny.color = new(1, 1, 1, 50f / 255f);
            b_Hero.color = new(1, 1, 1, 50f / 255f);
            b_Prince.color = new(1, 1, 1, 50f / 255f);
            b_Princess.color = new(1, 1, 1, 50f / 255f);
            b_Broom.color = new(1, 1, 1, 50f / 255f);
            b_Madrigal.color = new(1, 1, 1, 50f / 255f);
            b_Monster.color = new(1, 1, 1, 50f / 255f);
            b_Racer.color = new(1, 1, 1, 50f / 255f);
            b_RedPanda.color = new(1, 1, 1, 50f / 255f);
            b_Robot.color = new(1, 1, 1, 50f / 255f);
            b_Ally.color = new(1, 1, 1, 50f / 255f);
            b_Queen.color = new(1, 1, 1, 50f / 255f);
            b_Fairy.color = new(1, 1, 1, 50f / 255f);
            b_Puppy.color = new(1, 1, 1, 50f / 255f);
            b_Mentor.color = new(1, 1, 1, 50f / 255f);
            b_Giant.color = new(1, 1, 1, 50f / 255f);
            b_Dinosaur.color = new(1, 1, 1, 50f / 255f);
            b_Detective.color = new(1, 1, 1, 50f / 255f);
            b_Pirate.color = new(1, 1, 1, 50f / 255f);
            b_King.color = new(1, 1, 1, 50f / 255f);
            b_Inventor.color = new(1, 1, 1, 50f / 255f);
            b_Deity.color = new(1, 1, 1, 50f / 255f);
            b_Musketeer.color = new(1, 1, 1, 50f / 255f);
            b_Knight.color = new(1, 1, 1, 50f / 255f);
            b_Sorcerer.color = new(1, 1, 1, 50f / 255f);
        }

        switch (paramater)
        {
            case "Ally":
                if (isAlly)
                {
                    isAlly = false;
                    b_Ally.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isAlly = true;
                    b_Ally.color = new(1, 1, 1, 1);
                }
                break;
            case "Alien":
                if (isAlien)
                {
                    isAlien = false;
                    b_Alien.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isAlien = true;
                    b_Alien.color = new(1, 1, 1, 1);
                }
                break;
            case "Broom":
                if (isBroom)
                {
                    isBroom = false;
                    b_Broom.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isBroom = true;
                    b_Broom.color = new(1, 1, 1, 1);
                }
                break;
            case "Captain":
                if (isCaptain)
                {
                    isCaptain = false;
                    b_Captain.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isCaptain = true;
                    b_Captain.color = new(1, 1, 1, 1);
                }
                break;
            case "Detective":
                if (isDetective)
                {
                    isDetective = false;
                    b_Detective.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isDetective = true;
                    b_Detective.color = new(1, 1, 1, 1);
                }
                break;
            case "Deity":
                if (isDeity)
                {
                    isDeity = false;
                    b_Deity.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isDeity = true;
                    b_Deity.color = new(1, 1, 1, 1);
                }
                break;
            case "Dinosaur":
                if (isDinosaur)
                {
                    isDinosaur = false;
                    b_Dinosaur.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isDinosaur = true;
                    b_Dinosaur.color = new(1, 1, 1, 1);
                }
                break;
            case "Dragon":
                if (isDragon)
                {
                    isDragon = false;
                    b_Dragon.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isDragon = true;
                    b_Dragon.color = new(1, 1, 1, 1);
                }
                break;
            case "DreamBorn":
                if (isDreamBorn)
                {
                    isDreamBorn = false;
                    b_DreamBorn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isDreamBorn = true;
                    b_DreamBorn.color = new(1, 1, 1, 1);
                }
                break;
            case "Fairy":
                if (isFairy)
                {
                    isFairy = false;
                    b_Fairy.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isFairy = true;
                    b_Fairy.color = new(1, 1, 1, 1);
                }
                break;
            case "FloodBorn":
                if (isFloodBorn)
                {
                    isFloodBorn = false;
                    b_FloodBorn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isFloodBorn = true;
                    b_FloodBorn.color = new(1, 1, 1, 1);
                }
                break;
            case "Gargoyle":
                if (isGargoyle)
                {
                    isGargoyle = false;
                    b_Gargoyle.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isGargoyle = true;
                    b_Gargoyle.color = new(1, 1, 1, 1);
                }
                break;
            case "Giant":
                if (isGiant)
                {
                    isGiant = false;
                    b_Giant.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isGiant = true;
                    b_Giant.color = new(1, 1, 1, 1);
                }
                break;
            case "Hero":
                if (isHero)
                {
                    isHero = false;
                    b_Hero.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isHero = true;
                    b_Hero.color = new(1, 1, 1, 1);
                }
                break;
            case "Hunny":
                if (isHunny)
                {
                    isHunny = false;
                    b_Hunny.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isHunny = true;
                    b_Hunny.color = new(1, 1, 1, 1);
                }
                break;
            case "Hyena":
                if (isHyena)
                {
                    isHyena = false;
                    b_Hyena.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isHyena = true;
                    b_Hyena.color = new(1, 1, 1, 1);
                }
                break;
            case "Illusion":
                if (isIllusion)
                {
                    isIllusion = false;
                    b_Illusion.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isIllusion = true;
                    b_Illusion.color = new(1, 1, 1, 1);
                }
                break;
            case "Inventor":
                if (isInventor)
                {
                    isInventor = false;
                    b_Inventor.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isInventor = true;
                    b_Inventor.color = new(1, 1, 1, 1);
                }
                break;
            case "King":
                if (isKing)
                {
                    isKing = false;
                    b_King.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isKing = true;
                    b_King.color = new(1, 1, 1, 1);
                }
                break;
            case "Knight":
                if (isKnight)
                {
                    isKnight = false;
                    b_Knight.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isKnight = true;
                    b_Knight.color = new(1, 1, 1, 1);
                }
                break;
            case "Madrigal":
                if (isMadrigal)
                {
                    isMadrigal = false;
                    b_Madrigal.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isMadrigal = true;
                    b_Madrigal.color = new(1, 1, 1, 1);
                }
                break;
            case "Mentor":
                if (isMentor)
                {
                    isMentor = false;
                    b_Mentor.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isMentor = true;
                    b_Mentor.color = new(1, 1, 1, 1);
                }
                break;
            case "Monster":
                if (isMonster)
                {
                    isMonster = false;
                    b_Monster.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isMonster = true;
                    b_Monster.color = new(1, 1, 1, 1);
                }
                break;
            case "Musketeer":
                if (isMusketeer)
                {
                    isMusketeer = false;
                    b_Musketeer.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isMusketeer = true;
                    b_Musketeer.color = new(1, 1, 1, 1);
                }
                break;
            case "Pirate":
                if (isPirate)
                {
                    isPirate = false;
                    b_Pirate.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isPirate = true;
                    b_Pirate.color = new(1, 1, 1, 1);
                }
                break;
            case "Prince":
                if (isPrince)
                {
                    isPrince = false;
                    b_Prince.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isPrince = true;
                    b_Prince.color = new(1, 1, 1, 1);
                }
                break;
            case "Princess":
                if (isPrincess)
                {
                    isPrincess = false;
                    b_Princess.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isPrincess = true;
                    b_Princess.color = new(1, 1, 1, 1);
                }
                break;
            case "Puppy":
                if (isPuppy)
                {
                    isPuppy = false;
                    b_Puppy.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isPuppy = true;
                    b_Puppy.color = new(1, 1, 1, 1);
                }
                break;
            case "Queen":
                if (isQueen)
                {
                    isQueen = false;
                    b_Queen.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isQueen = true;
                    b_Queen.color = new(1, 1, 1, 1);
                }
                break;
            case "Racer":
                if (isRacer)
                {
                    isRacer = false;
                    b_Racer.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isRacer = true;
                    b_Racer.color = new(1, 1, 1, 1);
                }
                break;
            case "RedPanda":
                if (isRedPanda)
                {
                    isRedPanda = false;
                    b_RedPanda.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isRedPanda = true;
                    b_RedPanda.color = new(1, 1, 1, 1);
                }
                break;
            case "Robot":
                if (isRobot)
                {
                    isRobot = false;
                    b_Robot.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isRobot = true;
                    b_Robot.color = new(1, 1, 1, 1);
                }
                break;
            case "SevenDwarf":
                if (isSevenDwarf)
                {
                    isSevenDwarf = false;
                    b_SevenDwarf.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isSevenDwarf = true;
                    b_SevenDwarf.color = new(1, 1, 1, 1);
                }
                break;
            case "StoryBorn":
                if (isStoryBorn)
                {
                    isStoryBorn = false;
                    b_StoryBorn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isStoryBorn = true;
                    b_StoryBorn.color = new(1, 1, 1, 1);
                }
                break;
            case "Sorcerer":
                if (isSorcerer)
                {
                    isSorcerer = false;
                    b_Sorcerer.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isSorcerer = true;
                    b_Sorcerer.color = new(1, 1, 1, 1);
                }
                break;
            case "Super":
                if (isSuper)
                {
                    isSuper = false;
                    b_Super.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isSuper = true;
                    b_Super.color = new(1, 1, 1, 1);
                }
                break;
            case "Team":
                if (isTeam)
                {
                    isTeam = false;
                    b_Team.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isTeam = true;
                    b_Team.color = new(1, 1, 1, 1);
                }
                break;
            case "Tigger":
                if (isTigger)
                {
                    isTigger = false;
                    b_Tigger.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isTigger = true;
                    b_Tigger.color = new(1, 1, 1, 1);
                }
                break;
            case "Titan":
                if (isTitan)
                {
                    isTitan = false;
                    b_Titan.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isTitan = true;
                    b_Titan.color = new(1, 1, 1, 1);
                }
                break;
            case "Toy":
                if (isToy)
                {
                    isToy = false;
                    b_Toy.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isToy = true;
                    b_Toy.color = new(1, 1, 1, 1);
                }
                break;
            case "Villain":
                if (isVillain)
                {
                    isVillain = false;
                    b_Villain.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isVillain = true;
                    b_Villain.color = new(1, 1, 1, 1);
                }
                break;
            case "Vineling":
                if (isVineling)
                {
                    isVineling = false;
                    b_Vineling.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isVineling = true;
                    b_Vineling.color = new(1, 1, 1, 1);
                }
                break;
        }
    }

    public void onColorBtn(string paramater)
    {
        if(isAmethyst && isAmber && isEmerald && isSapphire && isSteel && isRuby)
        {
            isAmethyst = false;
            AmethystBtn.color = new(1, 1, 1, 50f / 255f);
            isAmber = false;
            AmberBtn.color = new(1, 1, 1, 50f / 255f);
            isEmerald = false;
            EmeraldBtn.color = new(1, 1, 1, 50f / 255f);
            isSapphire = false;
            SapphireBtn.color = new(1, 1, 1, 50f / 255f);
            isSteel = false;
            SteelBtn.color = new(1, 1, 1, 50f / 255f);
            isRuby = false;
            RubyBtn.color = new(1, 1, 1, 50f / 255f);
        }

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
            case "Adventurous":
                if (isAdventurous)
                {
                    this.isAdventurous = false;
                    AdventurousBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    this.isAdventurous = true;
                    AdventurousBtn.sprite = s_checkbtn_on;
                }
                break;
            case "Alert":
                if (isAlert)
                {
                    this.isAlert = false;
                    AlertBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    this.isAlert = true;
                    AlertBtn.sprite = s_checkbtn_on;
                }
                break;
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
            case "SingTogether":
                if (isSingTogether)
                {
                    this.isSingTogether = false;
                    SingTogetherBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    this.isSingTogether = true;
                    SingTogetherBtn.sprite = s_checkbtn_on;
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
            case "Resist":
                if (isResist)
                {
                    this.isResist = false;
                    ResistBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    this.isResist = true;
                    ResistBtn.sprite = s_checkbtn_on;
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
            case "Vanish":
                if (isVanish)
                {
                    this.isVanish = false;
                    VanishBtn.sprite = s_checkbtn_off;
                }
                else
                {
                    this.isVanish = true;
                    VanishBtn.sprite = s_checkbtn_on;
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

    public void onExpantionBtn(string paramater)
    {
        if(isTheFirstChapter && isRiseOfTheFloodBorn && isIntoTheInkLands && isUrsulasReturn && isShimmeringSkies && isAzuriteSea
            && isArchaziasIsland && isReignOfJafar && isFabled_vol1 && isFabled_vol2 && isWinterSpellInTheWell && isWinterSpell
            && isWildsUnknown && isAttackOfTheVine && isHyperiaCity)
        {
            isTheFirstChapter = false;
            isRiseOfTheFloodBorn = false;
            isIntoTheInkLands = false;
            isUrsulasReturn = false;
            isShimmeringSkies = false;
            isAzuriteSea = false;
            isArchaziasIsland = false;
            isReignOfJafar = false;
            isFabled_vol1 = false;
            isFabled_vol2 = false;
            isWinterSpellInTheWell = false;
            isWinterSpell = false;
            isWildsUnknown = false;
            isAttackOfTheVine = false;
            isHyperiaCity = false;

            b_TheFirstChapter.color = new(1, 1, 1, 50f / 255f);
            b_RiseOfTheFloodBorn.color = new(1, 1, 1, 50f / 255f);
            b_IntoTheInkLands.color = new(1, 1, 1, 50f / 255f);
            b_UrsulasReturn.color = new(1, 1, 1, 50f / 255f);
            b_ShimmeringSkies.color = new(1, 1, 1, 50f / 255f);
            b_AzuriteSea.color = new(1, 1, 1, 50f / 255f);
            b_ArchaziasIsland.color = new(1, 1, 1, 50f / 255f);
            b_ReignOfJafar.color = new(1, 1, 1, 50f / 255f);
            b_Fabled_vol1.color = new(1, 1, 1, 50f / 255f);
            b_Fabled_vol2.color = new(1, 1, 1, 50f / 255f);
            b_WinterSpellInTheWell.color = new(1, 1, 1, 50f / 255f);
            b_WinterSpell.color = new(1, 1, 1, 50f / 255f);
            b_WildsUnknown.color = new(1, 1, 1, 50f / 255f);
            b_AttackOfTheVine.color = new(1, 1, 1, 50f / 255f);
            b_HyperiaCity.color = new(1, 1, 1, 50f / 255f);
        }
        switch (paramater)
        {
            case "TheFirstChapter":
                if (isTheFirstChapter)
                {
                    isTheFirstChapter = false;
                    b_TheFirstChapter.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isTheFirstChapter = true;
                    b_TheFirstChapter.color = new(1, 1, 1, 1);
                }
                break;
            case "RiseOfTheFloodBorn":
                if (isRiseOfTheFloodBorn)
                {
                    isRiseOfTheFloodBorn = false;
                    b_RiseOfTheFloodBorn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isRiseOfTheFloodBorn = true;
                    b_RiseOfTheFloodBorn.color = new(1, 1, 1, 1);
                }
                break;
            case "IntoTheInkLands":
                if (isIntoTheInkLands)
                {
                    isIntoTheInkLands = false;
                    b_IntoTheInkLands.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isIntoTheInkLands = true;
                    b_IntoTheInkLands.color = new(1, 1, 1, 1);
                }
                break;
            case "UrsulasReturn":
                if (isUrsulasReturn)
                {
                    isUrsulasReturn = false;
                    b_UrsulasReturn.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isUrsulasReturn = true;
                    b_UrsulasReturn.color = new(1, 1, 1, 1);
                }
                break;
            case "ShimmeringSkies":
                if (isShimmeringSkies)
                {
                    isShimmeringSkies = false;
                    b_ShimmeringSkies.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isShimmeringSkies = true;
                    b_ShimmeringSkies.color = new(1, 1, 1, 1);
                }
                break;
            case "AzuriteSea":
                if (isAzuriteSea)
                {
                    isAzuriteSea = false;
                    b_AzuriteSea.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isAzuriteSea = true;
                    b_AzuriteSea.color = new(1, 1, 1, 1);
                }
                break;
            case "ArchaziasIsland":
                if (isArchaziasIsland)
                {
                    isArchaziasIsland = false;
                    b_ArchaziasIsland.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isArchaziasIsland = true;
                    b_ArchaziasIsland.color = new(1, 1, 1, 1);
                }
                break;
            case "ReignOfJafar":
                if (isReignOfJafar)
                {
                    isReignOfJafar = false;
                    b_ReignOfJafar.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isReignOfJafar = true;
                    b_ReignOfJafar.color = new(1, 1, 1, 1);
                }
                break;
            case "Fabled_vol1":
                if (isFabled_vol1)
                {
                    isFabled_vol1 = false;
                    b_Fabled_vol1.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isFabled_vol1 = true;
                    b_Fabled_vol1.color = new(1, 1, 1, 1);
                }
                break;
            case "Fabled_vol2":
                if (isFabled_vol2)
                {
                    isFabled_vol2 = false;
                    b_Fabled_vol2.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isFabled_vol2 = true;
                    b_Fabled_vol2.color = new(1, 1, 1, 1);
                }
                break;
            case "WinterSpellInTheWell":
                if (isWinterSpellInTheWell)
                {
                    isWinterSpellInTheWell = false;
                    b_WinterSpellInTheWell.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isWinterSpellInTheWell = true;
                    b_WinterSpellInTheWell.color = new(1, 1, 1, 1);
                }
                break;
            case "WinterSpell":
                if (isWinterSpell)
                {
                    isWinterSpell = false;
                    b_WinterSpell.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isWinterSpell = true;
                    b_WinterSpell.color = new(1, 1, 1, 1);
                }
                break;
            case "WildsUnknown":
                if (isWildsUnknown)
                {
                    isWildsUnknown = false;
                    b_WildsUnknown.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isWildsUnknown = true;
                    b_WildsUnknown.color = new(1, 1, 1, 1);
                }
                break;
            case "AttackOfTheVine":
                if (isAttackOfTheVine)
                {
                    isAttackOfTheVine = false;
                    b_AttackOfTheVine.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isAttackOfTheVine = true;
                    b_AttackOfTheVine.color = new(1, 1, 1, 1);
                }
                break;
            case "HyperiaCity":
                if (isHyperiaCity)
                {
                    isHyperiaCity = false;
                    b_HyperiaCity.color = new(1, 1, 1, 50f / 255f);
                }
                else
                {
                    isHyperiaCity = true;
                    b_HyperiaCity.color = new(1, 1, 1, 1);
                }
                break;
            
        }
    }

    public void onTypeBtn(string paramater)
    {
        if(a_isAction && a_isCharacter && a_isLocation && a_isItem && a_isSong)
        {
            this.a_isAction = false;
            a_ActionBtn.color = new(1, 1, 1, 50f / 255f);
            this.a_isCharacter = false;
            a_CharacterBtn.color = new(1, 1, 1, 50f / 255f);
            this.a_isLocation = false;
            a_LocationBtn.color = new(1, 1, 1, 50f / 255f);
            this.a_isItem = false;
            a_ItemBtn.color = new(1, 1, 1, 50f / 255f);
            this.a_isSong = false;
            a_SongBtn.color = new(1, 1, 1, 50f / 255f);
        }

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
        if(isInkAvailable && isInkDisavailable)
        {
            this.isInkAvailable = false;
            InkAvailableBtn.color = new(1, 1, 1, 50f / 255f);
            this.isInkDisavailable = false;
            InkDisavailableBtn.color = new(1, 1, 1, 50f / 255f);
        }
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
        m_SearchFilterClass.r_epic = r_epic;
        m_SearchFilterClass.r_enchanted = r_enchanted;
        m_SearchFilterClass.r_iconic = r_iconic;

        m_SearchFilterClass.isAlly = isAlly;
        m_SearchFilterClass.isAlien = isAlien;
        m_SearchFilterClass.isBroom = isBroom;
        m_SearchFilterClass.isCaptain = isCaptain;
        m_SearchFilterClass.isDetective = isDetective;
        m_SearchFilterClass.isDeity = isDeity;
        m_SearchFilterClass.isDinosaur = isDinosaur;
        m_SearchFilterClass.isDragon = isDragon;
        m_SearchFilterClass.isDreamBorn = isDreamBorn;
        m_SearchFilterClass.isFairy = isFairy;
        m_SearchFilterClass.isFloodBorn = isFloodBorn;
        m_SearchFilterClass.isGargoyle = isGargoyle;
        m_SearchFilterClass.isGiant = isGiant;
        m_SearchFilterClass.isHero = isHero;
        m_SearchFilterClass.isHunny = isHunny;
        m_SearchFilterClass.isHyena = isHyena;
        m_SearchFilterClass.isIllusion = isIllusion;
        m_SearchFilterClass.isInventor = isInventor;
        m_SearchFilterClass.isKing = isKing;
        m_SearchFilterClass.isKnight = isKnight;
        m_SearchFilterClass.isMadrigal = isMadrigal;
        m_SearchFilterClass.isMentor = isMentor;
        m_SearchFilterClass.isMonster = isMonster;
        m_SearchFilterClass.isMusketeer = isMusketeer;
        m_SearchFilterClass.isPirate = isPirate;
        m_SearchFilterClass.isPrince = isPrince;
        m_SearchFilterClass.isPrincess = isPrincess;
        m_SearchFilterClass.isPuppy = isPuppy;
        m_SearchFilterClass.isQueen = isQueen;
        m_SearchFilterClass.isRacer = isRacer;
        m_SearchFilterClass.isRedPanda = isRedPanda;
        m_SearchFilterClass.isRobot = isRobot;
        m_SearchFilterClass.isSevenDwarf = isSevenDwarf;
        m_SearchFilterClass.isStoryBorn = isStoryBorn;
        m_SearchFilterClass.isSorcerer = isSorcerer;
        m_SearchFilterClass.isSuper = isSuper;
        m_SearchFilterClass.isTeam = isTeam;
        m_SearchFilterClass.isTigger = isTigger;
        m_SearchFilterClass.isTitan = isTitan;
        m_SearchFilterClass.isToy = isToy;
        m_SearchFilterClass.isVillain = isVillain;
        m_SearchFilterClass.isVineling = isVineling;

        m_SearchFilterClass.isTheFirstChapter = isTheFirstChapter;
        m_SearchFilterClass.isRiseOfTheFloodBorn = isRiseOfTheFloodBorn;
        m_SearchFilterClass.isIntoTheInkLands = isIntoTheInkLands;
        m_SearchFilterClass.isUrsulasReturn = isUrsulasReturn;
        m_SearchFilterClass.isShimmeringSkies = isShimmeringSkies;
        m_SearchFilterClass.isAzuriteSea = isAzuriteSea;
        m_SearchFilterClass.isArchaziasIsland = isArchaziasIsland;
        m_SearchFilterClass.isReignOfJafar = isReignOfJafar;
        m_SearchFilterClass.isFabled_vol1 = isFabled_vol1;
        m_SearchFilterClass.isFabled_vol2 = isFabled_vol2;
        m_SearchFilterClass.isWinterSpellInTheWell = isWinterSpellInTheWell;
        m_SearchFilterClass.isWinterSpell = isWinterSpell;
        m_SearchFilterClass.isWildsUnknown = isWildsUnknown;
        m_SearchFilterClass.isAttackOfTheVine = isAttackOfTheVine;
        m_SearchFilterClass.isHyperiaCity = isHyperiaCity;

        m_SearchFilterClass.inkcost_lowerlimit = m_InkLowerLimitDropdown.value;
        m_SearchFilterClass.inkcost_upperlimit = m_InkUpperLimitDropdown.value;
        m_SearchFilterClass.power_lowerlimit = m_PowerLowerLimitDropdown.value;
        m_SearchFilterClass.power_upperlimit = m_PowerUpperLimitDropdown.value;
        m_SearchFilterClass.toughness_lowerlimit = m_ToughnessLowerLimitDropdown.value;
        m_SearchFilterClass.toughness_upperlimit = m_ToughnessUpperLimitDropdown.value;
        m_SearchFilterClass.lores_lowerlimit = m_LoresLowerLimitDropdown.value;
        m_SearchFilterClass.lores_upperlimit = m_LoresUpperLimitDropdown.value;

        m_SearchFilterClass.isAdventurous = isAdventurous;
        m_SearchFilterClass.isAlert = isAlert;
        m_SearchFilterClass.isBodyGuard = isBodyGuard;
        m_SearchFilterClass.isChallenger = isChallenger;
        m_SearchFilterClass.isEvasive = isEvasive;
        m_SearchFilterClass.isShift = isShift;
        m_SearchFilterClass.isSinger = isSinger;
        m_SearchFilterClass.isSingTogether = isSingTogether;
        m_SearchFilterClass.isSupport = isSupport;
        m_SearchFilterClass.isReckless = isReckless;
        m_SearchFilterClass.isResist = isResist;
        m_SearchFilterClass.isRush = isRush;
        m_SearchFilterClass.isVanish = isVanish;
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
        if (r_common && r_uncommon && r_rare && r_superrare && r_legendary && r_epic && r_enchanted && r_iconic)
        {
            r_common = false;
            r_commonBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);

            r_uncommon = false;
            r_uncommonBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);

            r_rare = false;
            r_rareBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);

            r_superrare = false;
            r_superrareBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);

            r_legendary = false;
            r_legendaryBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);

            r_epic = false;
            r_epicBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);

            r_enchanted = false;
            r_enchantedBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);

            r_iconic = false;
            r_iconicBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);
        }
        switch (paramater)
        {
            case "Common":
                if (r_common)
                {
                    r_common = false;
                    r_commonBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);
                }
                else
                {
                    r_common = true;
                    r_commonBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Uncommon":
                if (r_uncommon)
                {
                    r_uncommon = false;
                    r_uncommonBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);
                }
                else
                {
                    r_uncommon = true;
                    r_uncommonBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Rare":
                if (r_rare)
                {
                    r_rare = false;
                    r_rareBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);
                }
                else
                {
                    r_rare = true;
                    r_rareBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "SuperRare":
                if (r_superrare)
                {
                    r_superrare = false;
                    r_superrareBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);
                }
                else
                {
                    r_superrare = true;
                    r_superrareBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Legendary":
                if (r_legendary)
                {
                    r_legendary = false;
                    r_legendaryBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);
                }
                else
                {
                    r_legendary = true;
                    r_legendaryBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Epic":
                if (r_epic)
                {
                    r_epic = false;
                    r_epicBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);
                }
                else
                {
                    r_epic = true;
                    r_epicBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Enchanted":
                if (r_enchanted)
                {
                    r_enchanted = false;
                    r_enchantedBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);
                }
                else
                {
                    r_enchanted = true;
                    r_enchantedBtn.color = new(1, 1, 1, 1);
                }
                break;
            case "Iconic":
                if (r_iconic)
                {
                    r_iconic = false;
                    r_iconicBtn.color = new(70f / 255f, 70f / 255f, 70f / 255f, 255f);
                }
                else
                {
                    r_iconic = true;
                    r_iconicBtn.color = new(1, 1, 1, 1);
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
        r_commonBtn.color = new(1, 1, 1, 1);
        r_uncommon = true;
        r_uncommonBtn.color = new(1, 1, 1, 1);
        r_rare = true;
        r_rareBtn.color = new(1, 1, 1, 1);
        r_superrare = true;
        r_superrareBtn.color = new(1, 1, 1, 1);
        r_legendary = true;
        r_legendaryBtn.color = new(1, 1, 1, 1);
        r_epic = true;
        r_epicBtn.color = new(1, 1, 1, 1);
        r_enchanted = true;
        r_enchantedBtn.color = new(1, 1, 1, 1);
        r_iconic = true;
        r_iconicBtn.color = new(1, 1, 1, 1);

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

        b_StoryBorn.color = new(1, 1, 1, 1);
        b_DreamBorn.color = new(1, 1, 1, 1);
        b_FloodBorn.color = new(1, 1, 1, 1);
        b_SevenDwarf.color = new(1, 1, 1, 1);
        b_Illusion.color = new(1, 1, 1, 1);
        b_Vineling.color = new(1, 1, 1, 1);
        b_Villain.color = new(1, 1, 1, 1);
        b_Alien.color = new(1, 1, 1, 1);
        b_Gargoyle.color = new(1, 1, 1, 1);
        b_Captain.color = new(1, 1, 1, 1);
        b_Super.color = new(1, 1, 1, 1);
        b_Titan.color = new(1, 1, 1, 1);
        b_Team.color = new(1, 1, 1, 1);
        b_Tigger.color = new(1, 1, 1, 1);
        b_Toy.color = new(1, 1, 1, 1);
        b_Dragon.color = new(1, 1, 1, 1);
        b_Hyena.color = new(1, 1, 1, 1);
        b_Hunny.color = new(1, 1, 1, 1);
        b_Hero.color = new(1, 1, 1, 1);
        b_Prince.color = new(1, 1, 1, 1);
        b_Princess.color = new(1, 1, 1, 1);
        b_Broom.color = new(1, 1, 1, 1);
        b_Madrigal.color = new(1, 1, 1, 1);
        b_Monster.color = new(1, 1, 1, 1);
        b_Racer.color = new(1, 1, 1, 1);
        b_RedPanda.color = new(1, 1, 1, 1);
        b_Robot.color = new(1, 1, 1, 1);
        b_Ally.color = new(1, 1, 1, 1);
        b_Queen.color = new(1, 1, 1, 1);
        b_Fairy.color = new(1, 1, 1, 1);
        b_Puppy.color = new(1, 1, 1, 1);
        b_Mentor.color = new(1, 1, 1, 1);
        b_Giant.color = new(1, 1, 1, 1);
        b_Dinosaur.color = new(1, 1, 1, 1);
        b_Detective.color = new(1, 1, 1, 1);
        b_Pirate.color = new(1, 1, 1, 1);
        b_King.color = new(1, 1, 1, 1);
        b_Inventor.color = new(1, 1, 1, 1);
        b_Deity.color = new(1, 1, 1, 1);
        b_Musketeer.color = new(1, 1, 1, 1);
        b_Knight.color = new(1, 1, 1, 1);
        b_Sorcerer.color = new(1, 1, 1, 1);

        isTheFirstChapter = true;
        isRiseOfTheFloodBorn = true;
        isIntoTheInkLands = true;
        isUrsulasReturn = true;
        isShimmeringSkies = true;
        isAzuriteSea = true;
        isArchaziasIsland = true;
        isReignOfJafar = true;
        isFabled_vol1 = true;
        isFabled_vol2 = true;
        isWinterSpellInTheWell = true;
        isWinterSpell = true;
        isWildsUnknown = true;
        isAttackOfTheVine = true;
        isHyperiaCity = true;

        b_TheFirstChapter.color = new(1, 1, 1, 1);
        b_RiseOfTheFloodBorn.color = new(1, 1, 1, 1);
        b_IntoTheInkLands.color = new(1, 1, 1, 1);
        b_UrsulasReturn.color = new(1, 1, 1, 1);
        b_ShimmeringSkies.color = new(1, 1, 1, 1);
        b_AzuriteSea.color = new(1, 1, 1, 1);
        b_ArchaziasIsland.color = new(1, 1, 1, 1);
        b_ReignOfJafar.color = new(1, 1, 1, 1);
        b_Fabled_vol1.color = new(1, 1, 1, 1);
        b_Fabled_vol2.color = new(1, 1, 1, 1);
        b_WinterSpellInTheWell.color = new(1, 1, 1, 1);
        b_WinterSpell.color = new(1, 1, 1, 1);
        b_WildsUnknown.color = new(1, 1, 1, 1);
        b_AttackOfTheVine.color = new(1, 1, 1, 1);
        b_HyperiaCity.color = new(1, 1, 1, 1);

        isAdventurous = false;
        AdventurousBtn.sprite = s_checkbtn_off;
        isAlert = false;
        AlertBtn.sprite = s_checkbtn_off;
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
        isResist = false;
        ResistBtn.sprite = s_checkbtn_off;
        isVanish = false;
        VanishBtn.sprite = s_checkbtn_off;
        isWard = false;
        WardBtn.sprite = s_checkbtn_off;
        isSingTogether = false;
        SingTogetherBtn.sprite = s_checkbtn_off;

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

        type_Header_action.sizeDelta = new Vector2(type_Header_action.sizeDelta.x * magnification_x, type_Header_action.sizeDelta.y * magnification_y);
        type_Header_action_text.sizeDelta = new Vector2(type_Header_action_text.sizeDelta.x * magnification_x, type_Header_action_text.sizeDelta.y * magnification_y);
        type_Header_character.sizeDelta = new Vector2(type_Header_character.sizeDelta.x * magnification_x, type_Header_character.sizeDelta.y * magnification_y);
        type_Header_character_text.sizeDelta = new Vector2(type_Header_character_text.sizeDelta.x * magnification_x, type_Header_character_text.sizeDelta.y * magnification_y);
        type_Header_location.sizeDelta = new Vector2(type_Header_location.sizeDelta.x * magnification_x, type_Header_location.sizeDelta.y * magnification_y);
        type_Header_location_text.sizeDelta = new Vector2(type_Header_location_text.sizeDelta.x * magnification_x, type_Header_location_text.sizeDelta.y * magnification_y);
        type_Header_item.sizeDelta = new Vector2(type_Header_item.sizeDelta.x * magnification_x, type_Header_item.sizeDelta.y * magnification_y);
        type_Header_item_text.sizeDelta = new Vector2(type_Header_item_text.sizeDelta.x * magnification_x, type_Header_item_text.sizeDelta.y * magnification_y);
        type_Header_song.sizeDelta = new Vector2(type_Header_song.sizeDelta.x * magnification_x, type_Header_song.sizeDelta.y * magnification_y);
        type_Header_song_text.sizeDelta = new Vector2(type_Header_song_text.sizeDelta.x * magnification_x, type_Header_song_text.sizeDelta.y * magnification_y);

        space3.sizeDelta = new Vector2(space3.sizeDelta.x * magnification_x, space3.sizeDelta.y * magnification_y);
        rarityExplanation_header.sizeDelta = new Vector2(rarityExplanation_header.sizeDelta.x * magnification_x, rarityExplanation_header.sizeDelta.y * magnification_y);
        rarityExplanation_header_text1.sizeDelta = new Vector2(rarityExplanation_header_text1.sizeDelta.x * magnification_x, rarityExplanation_header_text1.sizeDelta.y * magnification_y);
        rarityExplanation_header_text2.sizeDelta = new Vector2(rarityExplanation_header_text2.sizeDelta.x * magnification_x, rarityExplanation_header_text2.sizeDelta.y * magnification_y);

        rarity_Header_space_1.sizeDelta = new Vector2(rarity_Header_space_1.sizeDelta.x * magnification_x, rarity_Header_space_1.sizeDelta.y * magnification_y);
        rarity_Header_left.sizeDelta = new Vector2(rarity_Header_left.sizeDelta.x * magnification_x, rarity_Header_left.sizeDelta.y * magnification_y);
        rarity_Header_left_space.sizeDelta = new Vector2(rarity_Header_left_space.sizeDelta.x * magnification_x, rarity_Header_left_space.sizeDelta.y * magnification_y);
        rarity_Header_left_common.sizeDelta = new Vector2(rarity_Header_left_common.sizeDelta.x * magnification_x, rarity_Header_left_common.sizeDelta.y * magnification_y);
        rarity_Header_left_space_1.sizeDelta = new Vector2(rarity_Header_left_space_1.sizeDelta.x * magnification_x, rarity_Header_left_space_1.sizeDelta.y * magnification_y);
        rarity_Header_left_rare.sizeDelta = new Vector2(rarity_Header_left_rare.sizeDelta.x * magnification_x, rarity_Header_left_rare.sizeDelta.y * magnification_y);
        rarity_Header_left_space_2.sizeDelta = new Vector2(rarity_Header_left_space_2.sizeDelta.x * magnification_x, rarity_Header_left_space_2.sizeDelta.y * magnification_y);
        rarity_Header_left_legendary.sizeDelta = new Vector2(rarity_Header_left_legendary.sizeDelta.x * magnification_x, rarity_Header_left_legendary.sizeDelta.y * magnification_y);
        rarity_Header_left_space_3.sizeDelta = new Vector2(rarity_Header_left_space_3.sizeDelta.x * magnification_x, rarity_Header_left_space_3.sizeDelta.y * magnification_y);
        rarity_Header_left_enchanted.sizeDelta = new Vector2(rarity_Header_left_enchanted.sizeDelta.x * magnification_x, rarity_Header_left_enchanted.sizeDelta.y * magnification_y);
        rarity_Header_left_space_4.sizeDelta = new Vector2(rarity_Header_left_space_4.sizeDelta.x * magnification_x, rarity_Header_left_space_4.sizeDelta.y * magnification_y);
        rarity_Header_space_2.sizeDelta = new Vector2(rarity_Header_space_2.sizeDelta.x * magnification_x, rarity_Header_space_2.sizeDelta.y * magnification_y);
        rarity_Header_right.sizeDelta = new Vector2(rarity_Header_right.sizeDelta.x * magnification_x, rarity_Header_right.sizeDelta.y * magnification_y);
        rarity_Header_right_space.sizeDelta = new Vector2(rarity_Header_right_space.sizeDelta.x * magnification_x, rarity_Header_right_space.sizeDelta.y * magnification_y);
        rarity_Header_right_uncommon.sizeDelta = new Vector2(rarity_Header_right_uncommon.sizeDelta.x * magnification_x, rarity_Header_right_uncommon.sizeDelta.y * magnification_y);
        rarity_Header_right_space_1.sizeDelta = new Vector2(rarity_Header_right_space_1.sizeDelta.x * magnification_x, rarity_Header_right_space_1.sizeDelta.y * magnification_y);
        rarity_Header_right_superrare.sizeDelta = new Vector2(rarity_Header_right_superrare.sizeDelta.x * magnification_x, rarity_Header_right_superrare.sizeDelta.y * magnification_y);
        rarity_Header_right_space_2.sizeDelta = new Vector2(rarity_Header_right_space_2.sizeDelta.x * magnification_x, rarity_Header_right_space_2.sizeDelta.y * magnification_y);
        rarity_Header_right_epic.sizeDelta = new Vector2(rarity_Header_right_epic.sizeDelta.x * magnification_x, rarity_Header_right_epic.sizeDelta.y * magnification_y);
        rarity_Header_right_space_3.sizeDelta = new Vector2(rarity_Header_right_space_3.sizeDelta.x * magnification_x, rarity_Header_right_space_3.sizeDelta.y * magnification_y);
        rarity_Header_right_iconic.sizeDelta = new Vector2(rarity_Header_right_iconic.sizeDelta.x * magnification_x, rarity_Header_right_iconic.sizeDelta.y * magnification_y);
        rarity_Header_right_space_4.sizeDelta = new Vector2(rarity_Header_right_space_4.sizeDelta.x * magnification_x, rarity_Header_right_space_4.sizeDelta.y * magnification_y);
        rarity_Header_space_3.sizeDelta = new Vector2(rarity_Header_space_3.sizeDelta.x * magnification_x, rarity_Header_space_3.sizeDelta.y * magnification_y);

        rarity_Header.sizeDelta = new Vector2(rarity_Header.sizeDelta.x * magnification_x, rarity_Header.sizeDelta.y * magnification_y);

        space3_1.sizeDelta = new Vector2(space3_1.sizeDelta.x * magnification_x, space3_1.sizeDelta.y * magnification_y);
        classExplanation_Header.sizeDelta = new Vector2(classExplanation_Header.sizeDelta.x * magnification_x, classExplanation_Header.sizeDelta.y * magnification_y);
        classExplanation_Header_text1.sizeDelta = new Vector2(classExplanation_Header_text1.sizeDelta.x * magnification_x, classExplanation_Header_text1.sizeDelta.y * magnification_y);
        classExplanation_Header_text2.sizeDelta = new Vector2(classExplanation_Header_text2.sizeDelta.x * magnification_x, classExplanation_Header_text2.sizeDelta.y * magnification_y);
        class_Header.sizeDelta = new Vector2(class_Header.sizeDelta.x * magnification_x, class_Header.sizeDelta.y * magnification_y);
        class_Header_space1.sizeDelta = new Vector2(class_Header_space1.sizeDelta.x * magnification_x, class_Header_space1.sizeDelta.y * magnification_y);
        class_Header_line1.sizeDelta = new Vector2(class_Header_line1.sizeDelta.x * magnification_x, class_Header_line1.sizeDelta.y * magnification_y);
        class_Header_line1_button1.sizeDelta = new Vector2(class_Header_line1_button1.sizeDelta.x * magnification_x, class_Header_line1_button1.sizeDelta.y * magnification_y);
        class_Header_line1_button2.sizeDelta = new Vector2(class_Header_line1_button2.sizeDelta.x * magnification_x, class_Header_line1_button2.sizeDelta.y * magnification_y);
        class_Header_line1_button3.sizeDelta = new Vector2(class_Header_line1_button3.sizeDelta.x * magnification_x, class_Header_line1_button3.sizeDelta.y * magnification_y);
        class_Header_space2.sizeDelta = new Vector2(class_Header_space2.sizeDelta.x * magnification_x, class_Header_space2.sizeDelta.y * magnification_y);
        class_Header_line2.sizeDelta = new Vector2(class_Header_line2.sizeDelta.x * magnification_x, class_Header_line2.sizeDelta.y * magnification_y);
        class_Header_line2_button1.sizeDelta = new Vector2(class_Header_line2_button1.sizeDelta.x * magnification_x, class_Header_line2_button1.sizeDelta.y * magnification_y);
        class_Header_line2_button2.sizeDelta = new Vector2(class_Header_line2_button2.sizeDelta.x * magnification_x, class_Header_line2_button2.sizeDelta.y * magnification_y);
        class_Header_line2_button3.sizeDelta = new Vector2(class_Header_line2_button3.sizeDelta.x * magnification_x, class_Header_line2_button3.sizeDelta.y * magnification_y);
        class_Header_space3.sizeDelta = new Vector2(class_Header_space3.sizeDelta.x * magnification_x, class_Header_space3.sizeDelta.y * magnification_y);
        class_Header_line3.sizeDelta = new Vector2(class_Header_line3.sizeDelta.x * magnification_x, class_Header_line3.sizeDelta.y * magnification_y);
        class_Header_line3_button1.sizeDelta = new Vector2(class_Header_line3_button1.sizeDelta.x * magnification_x, class_Header_line3_button1.sizeDelta.y * magnification_y);
        class_Header_line3_button2.sizeDelta = new Vector2(class_Header_line3_button2.sizeDelta.x * magnification_x, class_Header_line3_button2.sizeDelta.y * magnification_y);
        class_Header_line3_button3.sizeDelta = new Vector2(class_Header_line3_button3.sizeDelta.x * magnification_x, class_Header_line3_button3.sizeDelta.y * magnification_y);
        class_Header_space4.sizeDelta = new Vector2(class_Header_space4.sizeDelta.x * magnification_x, class_Header_space4.sizeDelta.y * magnification_y);
        class_Header_line4.sizeDelta = new Vector2(class_Header_line4.sizeDelta.x * magnification_x, class_Header_line4.sizeDelta.y * magnification_y);
        class_Header_line4_button1.sizeDelta = new Vector2(class_Header_line4_button1.sizeDelta.x * magnification_x, class_Header_line4_button1.sizeDelta.y * magnification_y);
        class_Header_line4_button2.sizeDelta = new Vector2(class_Header_line4_button2.sizeDelta.x * magnification_x, class_Header_line4_button2.sizeDelta.y * magnification_y);
        class_Header_line4_button3.sizeDelta = new Vector2(class_Header_line4_button3.sizeDelta.x * magnification_x, class_Header_line4_button3.sizeDelta.y * magnification_y);
        class_Header_space5.sizeDelta = new Vector2(class_Header_space5.sizeDelta.x * magnification_x, class_Header_space5.sizeDelta.y * magnification_y);
        class_Header_line5.sizeDelta = new Vector2(class_Header_line5.sizeDelta.x * magnification_x, class_Header_line5.sizeDelta.y * magnification_y);
        class_Header_line5_button1.sizeDelta = new Vector2(class_Header_line5_button1.sizeDelta.x * magnification_x, class_Header_line5_button1.sizeDelta.y * magnification_y);
        class_Header_line5_button2.sizeDelta = new Vector2(class_Header_line5_button2.sizeDelta.x * magnification_x, class_Header_line5_button2.sizeDelta.y * magnification_y);
        class_Header_line5_button3.sizeDelta = new Vector2(class_Header_line5_button3.sizeDelta.x * magnification_x, class_Header_line5_button3.sizeDelta.y * magnification_y);
        class_Header_space6.sizeDelta = new Vector2(class_Header_space6.sizeDelta.x * magnification_x, class_Header_space6.sizeDelta.y * magnification_y);
        class_Header_line6.sizeDelta = new Vector2(class_Header_line6.sizeDelta.x * magnification_x, class_Header_line6.sizeDelta.y * magnification_y);
        class_Header_line6_button1.sizeDelta = new Vector2(class_Header_line6_button1.sizeDelta.x * magnification_x, class_Header_line6_button1.sizeDelta.y * magnification_y);
        class_Header_line6_button2.sizeDelta = new Vector2(class_Header_line6_button2.sizeDelta.x * magnification_x, class_Header_line6_button2.sizeDelta.y * magnification_y);
        class_Header_line6_button3.sizeDelta = new Vector2(class_Header_line6_button3.sizeDelta.x * magnification_x, class_Header_line6_button3.sizeDelta.y * magnification_y);
        class_Header_space7.sizeDelta = new Vector2(class_Header_space7.sizeDelta.x * magnification_x, class_Header_space7.sizeDelta.y * magnification_y);
        class_Header_line7.sizeDelta = new Vector2(class_Header_line7.sizeDelta.x * magnification_x, class_Header_line7.sizeDelta.y * magnification_y);
        class_Header_line7_button1.sizeDelta = new Vector2(class_Header_line7_button1.sizeDelta.x * magnification_x, class_Header_line7_button1.sizeDelta.y * magnification_y);
        class_Header_line7_button2.sizeDelta = new Vector2(class_Header_line7_button2.sizeDelta.x * magnification_x, class_Header_line7_button2.sizeDelta.y * magnification_y);
        class_Header_line7_button3.sizeDelta = new Vector2(class_Header_line7_button3.sizeDelta.x * magnification_x, class_Header_line7_button3.sizeDelta.y * magnification_y);
        class_Header_space8.sizeDelta = new Vector2(class_Header_space8.sizeDelta.x * magnification_x, class_Header_space8.sizeDelta.y * magnification_y);
        class_Header_line8.sizeDelta = new Vector2(class_Header_line8.sizeDelta.x * magnification_x, class_Header_line8.sizeDelta.y * magnification_y);
        class_Header_line8_button1.sizeDelta = new Vector2(class_Header_line8_button1.sizeDelta.x * magnification_x, class_Header_line8_button1.sizeDelta.y * magnification_y);
        class_Header_line8_button2.sizeDelta = new Vector2(class_Header_line8_button2.sizeDelta.x * magnification_x, class_Header_line8_button2.sizeDelta.y * magnification_y);
        class_Header_line8_button3.sizeDelta = new Vector2(class_Header_line8_button3.sizeDelta.x * magnification_x, class_Header_line8_button3.sizeDelta.y * magnification_y);
        class_Header_space9.sizeDelta = new Vector2(class_Header_space9.sizeDelta.x * magnification_x, class_Header_space9.sizeDelta.y * magnification_y);
        class_Header_line9.sizeDelta = new Vector2(class_Header_line9.sizeDelta.x * magnification_x, class_Header_line9.sizeDelta.y * magnification_y);
        class_Header_line9_button1.sizeDelta = new Vector2(class_Header_line9_button1.sizeDelta.x * magnification_x, class_Header_line9_button1.sizeDelta.y * magnification_y);
        class_Header_line9_button2.sizeDelta = new Vector2(class_Header_line9_button2.sizeDelta.x * magnification_x, class_Header_line9_button2.sizeDelta.y * magnification_y);
        class_Header_line9_button3.sizeDelta = new Vector2(class_Header_line9_button3.sizeDelta.x * magnification_x, class_Header_line9_button3.sizeDelta.y * magnification_y);
        class_Header_space10.sizeDelta = new Vector2(class_Header_space10.sizeDelta.x * magnification_x, class_Header_space10.sizeDelta.y * magnification_y);
        class_Header_line10.sizeDelta = new Vector2(class_Header_line10.sizeDelta.x * magnification_x, class_Header_line10.sizeDelta.y * magnification_y);
        class_Header_line10_button1.sizeDelta = new Vector2(class_Header_line10_button1.sizeDelta.x * magnification_x, class_Header_line10_button1.sizeDelta.y * magnification_y);
        class_Header_line10_button2.sizeDelta = new Vector2(class_Header_line10_button2.sizeDelta.x * magnification_x, class_Header_line10_button2.sizeDelta.y * magnification_y);
        class_Header_line10_button3.sizeDelta = new Vector2(class_Header_line10_button3.sizeDelta.x * magnification_x, class_Header_line10_button3.sizeDelta.y * magnification_y);
        class_Header_space11.sizeDelta = new Vector2(class_Header_space11.sizeDelta.x * magnification_x, class_Header_space11.sizeDelta.y * magnification_y);
        class_Header_line11.sizeDelta = new Vector2(class_Header_line11.sizeDelta.x * magnification_x, class_Header_line11.sizeDelta.y * magnification_y);
        class_Header_line11_button1.sizeDelta = new Vector2(class_Header_line11_button1.sizeDelta.x * magnification_x, class_Header_line11_button1.sizeDelta.y * magnification_y);
        class_Header_line11_button2.sizeDelta = new Vector2(class_Header_line11_button2.sizeDelta.x * magnification_x, class_Header_line11_button2.sizeDelta.y * magnification_y);
        class_Header_line11_button3.sizeDelta = new Vector2(class_Header_line11_button3.sizeDelta.x * magnification_x, class_Header_line11_button3.sizeDelta.y * magnification_y);
        class_Header_space12.sizeDelta = new Vector2(class_Header_space12.sizeDelta.x * magnification_x, class_Header_space12.sizeDelta.y * magnification_y);
        class_Header_line12.sizeDelta = new Vector2(class_Header_line12.sizeDelta.x * magnification_x, class_Header_line12.sizeDelta.y * magnification_y);
        class_Header_line12_button1.sizeDelta = new Vector2(class_Header_line12_button1.sizeDelta.x * magnification_x, class_Header_line12_button1.sizeDelta.y * magnification_y);
        class_Header_line12_button2.sizeDelta = new Vector2(class_Header_line12_button2.sizeDelta.x * magnification_x, class_Header_line12_button2.sizeDelta.y * magnification_y);
        class_Header_line12_button3.sizeDelta = new Vector2(class_Header_line12_button3.sizeDelta.x * magnification_x, class_Header_line12_button3.sizeDelta.y * magnification_y);
        class_Header_space13.sizeDelta = new Vector2(class_Header_space13.sizeDelta.x * magnification_x, class_Header_space13.sizeDelta.y * magnification_y);
        class_Header_line13.sizeDelta = new Vector2(class_Header_line13.sizeDelta.x * magnification_x, class_Header_line13.sizeDelta.y * magnification_y);
        class_Header_line13_button1.sizeDelta = new Vector2(class_Header_line13_button1.sizeDelta.x * magnification_x, class_Header_line13_button1.sizeDelta.y * magnification_y);
        class_Header_line13_button2.sizeDelta = new Vector2(class_Header_line13_button2.sizeDelta.x * magnification_x, class_Header_line13_button2.sizeDelta.y * magnification_y);
        class_Header_line13_button3.sizeDelta = new Vector2(class_Header_line13_button3.sizeDelta.x * magnification_x, class_Header_line13_button3.sizeDelta.y * magnification_y);
        class_Header_space14.sizeDelta = new Vector2(class_Header_space14.sizeDelta.x * magnification_x, class_Header_space14.sizeDelta.y * magnification_y);
        class_Header_line14.sizeDelta = new Vector2(class_Header_line14.sizeDelta.x * magnification_x, class_Header_line14.sizeDelta.y * magnification_y);
        class_Header_line14_button1.sizeDelta = new Vector2(class_Header_line14_button1.sizeDelta.x * magnification_x, class_Header_line14_button1.sizeDelta.y * magnification_y);
        class_Header_line14_button2.sizeDelta = new Vector2(class_Header_line14_button2.sizeDelta.x * magnification_x, class_Header_line14_button2.sizeDelta.y * magnification_y);
        class_Header_line14_button3.sizeDelta = new Vector2(class_Header_line14_button3.sizeDelta.x * magnification_x, class_Header_line14_button3.sizeDelta.y * magnification_y);
        space3_2.sizeDelta = new Vector2(space3_2.sizeDelta.x * magnification_x, space3_2.sizeDelta.y * magnification_y);

        expantionExplanation_Header.sizeDelta = new Vector2(expantionExplanation_Header.sizeDelta.x * magnification_x, expantionExplanation_Header.sizeDelta.y * magnification_y);
        expantionExplanation_Header_text1.sizeDelta = new Vector2(expantionExplanation_Header_text1.sizeDelta.x * magnification_x, expantionExplanation_Header_text1.sizeDelta.y * magnification_y);
        expantionExplanation_Header_text2.sizeDelta = new Vector2(expantionExplanation_Header_text2.sizeDelta.x * magnification_x, expantionExplanation_Header_text2.sizeDelta.y * magnification_y);
        expantion_Header.sizeDelta = new Vector2(expantion_Header.sizeDelta.x * magnification_x, expantion_Header.sizeDelta.y * magnification_y);
        expantion_Header_space.sizeDelta = new Vector2(expantion_Header_space.sizeDelta.x * magnification_x, expantion_Header_space.sizeDelta.y * magnification_y);
        expantion_Header_button1.sizeDelta = new Vector2(expantion_Header_button1.sizeDelta.x * magnification_x, expantion_Header_button1.sizeDelta.y * magnification_y);
        expantion_Header_space1.sizeDelta = new Vector2(expantion_Header_space1.sizeDelta.x * magnification_x, expantion_Header_space1.sizeDelta.y * magnification_y);
        expantion_Header_button2.sizeDelta = new Vector2(expantion_Header_button2.sizeDelta.x * magnification_x, expantion_Header_button2.sizeDelta.y * magnification_y);
        expantion_Header_space2.sizeDelta = new Vector2(expantion_Header_space2.sizeDelta.x * magnification_x, expantion_Header_space2.sizeDelta.y * magnification_y);
        expantion_Header_button3.sizeDelta = new Vector2(expantion_Header_button3.sizeDelta.x * magnification_x, expantion_Header_button3.sizeDelta.y * magnification_y);
        expantion_Header_space3.sizeDelta = new Vector2(expantion_Header_space3.sizeDelta.x * magnification_x, expantion_Header_space3.sizeDelta.y * magnification_y);
        expantion_Header_button4.sizeDelta = new Vector2(expantion_Header_button4.sizeDelta.x * magnification_x, expantion_Header_button4.sizeDelta.y * magnification_y);
        expantion_Header_space4.sizeDelta = new Vector2(expantion_Header_space4.sizeDelta.x * magnification_x, expantion_Header_space4.sizeDelta.y * magnification_y);
        expantion_Header_button5.sizeDelta = new Vector2(expantion_Header_button5.sizeDelta.x * magnification_x, expantion_Header_button5.sizeDelta.y * magnification_y);
        expantion_Header_space5.sizeDelta = new Vector2(expantion_Header_space5.sizeDelta.x * magnification_x, expantion_Header_space5.sizeDelta.y * magnification_y);
        expantion_Header_button6.sizeDelta = new Vector2(expantion_Header_button6.sizeDelta.x * magnification_x, expantion_Header_button6.sizeDelta.y * magnification_y);
        expantion_Header_space6.sizeDelta = new Vector2(expantion_Header_space6.sizeDelta.x * magnification_x, expantion_Header_space6.sizeDelta.y * magnification_y);
        expantion_Header_button7.sizeDelta = new Vector2(expantion_Header_button7.sizeDelta.x * magnification_x, expantion_Header_button7.sizeDelta.y * magnification_y);
        expantion_Header_space7.sizeDelta = new Vector2(expantion_Header_space7.sizeDelta.x * magnification_x, expantion_Header_space7.sizeDelta.y * magnification_y);
        expantion_Header_button8.sizeDelta = new Vector2(expantion_Header_button8.sizeDelta.x * magnification_x, expantion_Header_button8.sizeDelta.y * magnification_y);
        expantion_Header_space8.sizeDelta = new Vector2(expantion_Header_space8.sizeDelta.x * magnification_x, expantion_Header_space8.sizeDelta.y * magnification_y);
        expantion_Header_button9.sizeDelta = new Vector2(expantion_Header_button9.sizeDelta.x * magnification_x, expantion_Header_button9.sizeDelta.y * magnification_y);
        expantion_Header_space9.sizeDelta = new Vector2(expantion_Header_space9.sizeDelta.x * magnification_x, expantion_Header_space9.sizeDelta.y * magnification_y);
        expantion_Header_button10.sizeDelta = new Vector2(expantion_Header_button10.sizeDelta.x * magnification_x, expantion_Header_button10.sizeDelta.y * magnification_y);
        expantion_Header_space10.sizeDelta = new Vector2(expantion_Header_space10.sizeDelta.x * magnification_x, expantion_Header_space10.sizeDelta.y * magnification_y);
        expantion_Header_button11.sizeDelta = new Vector2(expantion_Header_button11.sizeDelta.x * magnification_x, expantion_Header_button11.sizeDelta.y * magnification_y);
        expantion_Header_space11.sizeDelta = new Vector2(expantion_Header_space11.sizeDelta.x * magnification_x, expantion_Header_space11.sizeDelta.y * magnification_y);
        expantion_Header_button12.sizeDelta = new Vector2(expantion_Header_button12.sizeDelta.x * magnification_x, expantion_Header_button12.sizeDelta.y * magnification_y);
        expantion_Header_space12.sizeDelta = new Vector2(expantion_Header_space12.sizeDelta.x * magnification_x, expantion_Header_space12.sizeDelta.y * magnification_y);
        expantion_Header_button13.sizeDelta = new Vector2(expantion_Header_button13.sizeDelta.x * magnification_x, expantion_Header_button13.sizeDelta.y * magnification_y);
        expantion_Header_space13.sizeDelta = new Vector2(expantion_Header_space13.sizeDelta.x * magnification_x, expantion_Header_space13.sizeDelta.y * magnification_y);
        expantion_Header_button14.sizeDelta = new Vector2(expantion_Header_button14.sizeDelta.x * magnification_x, expantion_Header_button14.sizeDelta.y * magnification_y);
        expantion_Header_space14.sizeDelta = new Vector2(expantion_Header_space14.sizeDelta.x * magnification_x, expantion_Header_space14.sizeDelta.y * magnification_y);
        expantion_Header_button15.sizeDelta = new Vector2(expantion_Header_button15.sizeDelta.x * magnification_x, expantion_Header_button15.sizeDelta.y * magnification_y);
        space3_3.sizeDelta = new Vector2(space3_3.sizeDelta.x * magnification_x, space3_3.sizeDelta.y * magnification_y);

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

        keyword_header_left_alert.sizeDelta = new Vector2(keyword_header_left_alert.sizeDelta.x * magnification_x, keyword_header_left_alert.sizeDelta.y * magnification_y);
        keyword_header_left_alert_space.sizeDelta = new Vector2(keyword_header_left_alert_space.sizeDelta.x * magnification_x, keyword_header_left_alert_space.sizeDelta.y * magnification_y);
        keyword_header_left_alert_text.sizeDelta = new Vector2(keyword_header_left_alert_text.sizeDelta.x * magnification_x, keyword_header_left_alert_text.sizeDelta.y * magnification_y);

        keyword_header_right.sizeDelta = new Vector2(keyword_header_right.sizeDelta.x * magnification_x, keyword_header_right.sizeDelta.y * magnification_y);
        keyword_header_right_support.sizeDelta = new Vector2(keyword_header_right_support.sizeDelta.x * magnification_x, keyword_header_right_support.sizeDelta.y * magnification_y);

        keyword_header_left_resist.sizeDelta = new Vector2(keyword_header_left_resist.sizeDelta.x * magnification_x, keyword_header_left_resist.sizeDelta.y * magnification_y);
        keyword_header_left_resist_space.sizeDelta = new Vector2(keyword_header_left_resist_space.sizeDelta.x * magnification_x, keyword_header_left_resist_space.sizeDelta.y * magnification_y);
        keyword_header_left_resist_text.sizeDelta = new Vector2(keyword_header_left_resist_text.sizeDelta.x * magnification_x, keyword_header_left_resist_text.sizeDelta.y * magnification_y);

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
        keyword_header_right_singtogether.sizeDelta = new Vector2(keyword_header_right_singtogether.sizeDelta.x * magnification_x, keyword_header_right_singtogether.sizeDelta.y * magnification_y);

        keyword_header_right_singtogether_space.sizeDelta = new Vector2(keyword_header_right_singtogether_space.sizeDelta.x * magnification_x, keyword_header_right_singtogether_space.sizeDelta.y * magnification_y);
        keyword_header_right_singtogether_text.sizeDelta = new Vector2(keyword_header_right_singtogether_text.sizeDelta.x * magnification_x, keyword_header_right_singtogether_text.sizeDelta.y * magnification_y);

        keyword_header_right_vanish.sizeDelta = new Vector2(keyword_header_right_vanish.sizeDelta.x * magnification_x, keyword_header_right_vanish.sizeDelta.y * magnification_y);
        keyword_header_right_vanish_space.sizeDelta = new Vector2(keyword_header_right_vanish_space.sizeDelta.x * magnification_x, keyword_header_right_vanish_space.sizeDelta.y * magnification_y);
        keyword_header_right_vanish_text.sizeDelta = new Vector2(keyword_header_right_vanish_text.sizeDelta.x * magnification_x, keyword_header_right_vanish_text.sizeDelta.y * magnification_y);

        keyword_header_right_adventurous.sizeDelta = new Vector2(keyword_header_right_adventurous.sizeDelta.x * magnification_x, keyword_header_right_adventurous.sizeDelta.y * magnification_y);
        keyword_header_right_adventurous_space.sizeDelta = new Vector2(keyword_header_right_adventurous_space.sizeDelta.x * magnification_x, keyword_header_right_adventurous_space.sizeDelta.y * magnification_y);
        keyword_header_right_adventurous_text.sizeDelta = new Vector2(keyword_header_right_adventurous_text.sizeDelta.x * magnification_x, keyword_header_right_adventurous_text.sizeDelta.y * magnification_y);

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

        space10.sizeDelta = new Vector2(space10.sizeDelta.x * magnification_x, space10.sizeDelta.y * magnification_y);
        searchReset.sizeDelta = new Vector2(searchReset.sizeDelta.x * magnification_x, searchReset.sizeDelta.y * magnification_y);
        searchReset_header.sizeDelta = new Vector2(searchReset_header.sizeDelta.x * magnification_x, searchReset_header.sizeDelta.y * magnification_y);
        searchReset_header_text.sizeDelta = new Vector2(searchReset_header_text.sizeDelta.x * magnification_x, searchReset_header_text.sizeDelta.y * magnification_y);
        searchReset_header_Button.sizeDelta = new Vector2(searchReset_header_Button.sizeDelta.x * magnification_x, searchReset_header_Button.sizeDelta.y * magnification_y);

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

        keyword_header_left_bodyguard_btn.sizeDelta = new Vector2(keyword_header_left_bodyguard_btn.sizeDelta.x * magnification, keyword_header_left_bodyguard_btn.sizeDelta.y * magnification);
        keyword_header_left_challenger_btn.sizeDelta = new Vector2(keyword_header_left_challenger_btn.sizeDelta.x * magnification, keyword_header_left_challenger_btn.sizeDelta.y * magnification);
        keyword_header_left_evasive_btn.sizeDelta = new Vector2(keyword_header_left_evasive_btn.sizeDelta.x * magnification, keyword_header_left_evasive_btn.sizeDelta.y * magnification);
        keyword_header_left_shift_btn.sizeDelta = new Vector2(keyword_header_left_shift_btn.sizeDelta.x * magnification, keyword_header_left_shift_btn.sizeDelta.y * magnification);
        keyword_header_left_singer_btn.sizeDelta = new Vector2(keyword_header_left_singer_btn.sizeDelta.x * magnification, keyword_header_left_singer_btn.sizeDelta.y * magnification);
        keyword_header_left_resist_btn.sizeDelta = new Vector2(keyword_header_left_resist_btn.sizeDelta.x * magnification, keyword_header_left_resist_btn.sizeDelta.y * magnification);
        keyword_header_left_alert_btn.sizeDelta = new Vector2(keyword_header_left_alert_btn.sizeDelta.x * magnification, keyword_header_left_alert_btn.sizeDelta.y * magnification);
        keyword_header_right_support_btn.sizeDelta = new Vector2(keyword_header_right_support_btn.sizeDelta.x * magnification, keyword_header_right_support_btn.sizeDelta.y * magnification);
        keyword_header_right_reckless_btn.sizeDelta = new Vector2(keyword_header_right_reckless_btn.sizeDelta.x * magnification, keyword_header_right_reckless_btn.sizeDelta.y * magnification);
        keyword_header_right_rush_btn.sizeDelta = new Vector2(keyword_header_right_rush_btn.sizeDelta.x * magnification, keyword_header_right_rush_btn.sizeDelta.y * magnification);
        keyword_header_right_ward_btn.sizeDelta = new Vector2(keyword_header_right_ward_btn.sizeDelta.x * magnification, keyword_header_right_ward_btn.sizeDelta.y * magnification);
        keyword_header_right_singtogether_btn.sizeDelta = new Vector2(keyword_header_right_singtogether_btn.sizeDelta.x * magnification, keyword_header_right_singtogether_btn.sizeDelta.y * magnification);
        keyword_header_right_vanish_btn.sizeDelta = new Vector2(keyword_header_right_vanish_btn.sizeDelta.x * magnification, keyword_header_right_vanish_btn.sizeDelta.y * magnification);
        keyword_header_right_adventurous_btn.sizeDelta = new Vector2(keyword_header_right_adventurous_btn.sizeDelta.x * magnification, keyword_header_right_adventurous_btn.sizeDelta.y * magnification);

        searchBtn.sizeDelta = new Vector2(searchBtn.sizeDelta.x * magnification, searchBtn.sizeDelta.y * magnification);
        searchBtn_text.sizeDelta = new Vector2(searchBtn_text.sizeDelta.x * magnification, searchBtn_text.sizeDelta.y * magnification);
    }
}
