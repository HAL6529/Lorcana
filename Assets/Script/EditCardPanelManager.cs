using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EditCardPanelManager : MonoBehaviour
{
    private enum SortStatus
    {
        Default,
        InkSort,
        ColorSort,
    }

    public SaveDataStatic m_SaveDataStatic = new SaveDataStatic();
    public SearchClass m_SearchClass;
    public string DeckName = "";

    private List<CardInfo> CardInfoList_TheFirstChapter = new List<CardInfo>();
    private List<CardInfo> CardInfoList_RiseOfTheFloodBorn = new List<CardInfo>();
    private List<CardInfo> CardInfoList_IntoTheInkLands = new List<CardInfo>();
    private List<CardInfo> CardInfoList_UrsulasReturn = new List<CardInfo>();
    private List<CardInfo> CardInfoList_ShimmeringSkies = new List<CardInfo>();
    private List<CardInfo> CardInfoList_AzuriteSea = new List<CardInfo>();
    private List<CardInfo> CardInfoList_ArchaziasIsland = new List<CardInfo>();
    private List<CardInfo> CardInfoList_ReignOfJafar = new List<CardInfo>();
    private List<CardInfo> CardInfoList_FabledVol1 = new List<CardInfo>();
    private List<CardInfo> CardInfoList_FabledVol2 = new List<CardInfo>();
    private List<CardInfo> CardInfoList_WinterSpellInTheWell = new List<CardInfo>();
    private List<CardInfo> CardInfoList_WinterSpell = new List<CardInfo>();
    private List<CardInfo> CardInfoList_WildsUnknown = new List<CardInfo>();
    private List<CardInfo> CardInfoList_AttackOfTheVine = new List<CardInfo>();
    private List<CardInfo> CardInfoList_HyperiaCity = new List<CardInfo>();

    private List<EditCardPanelTemp> EditCardPanelTempList = new List<EditCardPanelTemp>();
    private List<EditCardPanelTemp> SortEditCardPanelTempList = new List<EditCardPanelTemp>();

    public Sprite Common;
    public Sprite UnCommon;
    public Sprite Rare;
    public Sprite SuperRare;
    public Sprite Legendary;
    public Sprite Epic;
    public Sprite Enchanted;
    public Sprite Iconic;

    public Sprite DefaultSortIcon;
    public Sprite InkSortIcon;
    public Sprite ColorSortIcon;
    public Sprite DeckAllSwitchBtn1;
    public Sprite DeckAllSwitchBtn2;

    public GameObject MenuObj;
    public Image SortImage;
    public Image DeckAllSwitchBtnImage;

    private SortStatus m_SortStatus = SortStatus.Default;

    public bool SwitchOwn = false;

    [SerializeField] private InfiniteScroll m_InfiniteScroll;
    public SearchFilterClass m_SearchFilterClass = new SearchFilterClass();
    public RectTransform CanvasRectTransform;

    void Start()
    {
        CardInfoList_TheFirstChapter = new List<CardInfo> { new CardInfo_001_JA_01(), new CardInfo_002_JA_01(), new CardInfo_003_JA_01(), new CardInfo_004_JA_01(), new CardInfo_005_JA_01(), new CardInfo_006_JA_01(), new CardInfo_007_JA_01(), new CardInfo_008_JA_01(), new CardInfo_009_JA_01(), new CardInfo_010_JA_01(), new CardInfo_011_JA_01(), new CardInfo_012_JA_01(), new CardInfo_013_JA_01(), new CardInfo_014_JA_01(), new CardInfo_015_JA_01(), new CardInfo_016_JA_01(), new CardInfo_017_JA_01(), new CardInfo_018_JA_01(), new CardInfo_019_JA_01(), new CardInfo_020_JA_01(), new CardInfo_021_JA_01(), new CardInfo_022_JA_01(), new CardInfo_023_JA_01(), new CardInfo_024_JA_01(), new CardInfo_025_JA_01(), new CardInfo_026_JA_01(), new CardInfo_027_JA_01(), new CardInfo_028_JA_01(), new CardInfo_029_JA_01(), new CardInfo_030_JA_01(), new CardInfo_031_JA_01(), new CardInfo_032_JA_01(), new CardInfo_033_JA_01(), new CardInfo_034_JA_01(), new CardInfo_035_JA_01(), new CardInfo_036_JA_01(), new CardInfo_037_JA_01(), new CardInfo_038_JA_01(), new CardInfo_039_JA_01(), new CardInfo_040_JA_01(), new CardInfo_041_JA_01(), new CardInfo_042_JA_01(), new CardInfo_043_JA_01(), new CardInfo_044_JA_01(), new CardInfo_045_JA_01(), new CardInfo_046_JA_01(), new CardInfo_047_JA_01(), new CardInfo_048_JA_01(), new CardInfo_049_JA_01(), new CardInfo_050_JA_01(), new CardInfo_051_JA_01(), new CardInfo_052_JA_01(), new CardInfo_053_JA_01(), new CardInfo_054_JA_01(), new CardInfo_055_JA_01(), new CardInfo_056_JA_01(), new CardInfo_057_JA_01(), new CardInfo_058_JA_01(), new CardInfo_059_JA_01(), new CardInfo_060_JA_01(), new CardInfo_061_JA_01(), new CardInfo_062_JA_01(), new CardInfo_063_JA_01(), new CardInfo_064_JA_01(), new CardInfo_065_JA_01(), new CardInfo_066_JA_01(), new CardInfo_067_JA_01(), new CardInfo_068_JA_01(), new CardInfo_069_JA_01(), new CardInfo_070_JA_01(), new CardInfo_071_JA_01(), new CardInfo_072_JA_01(), new CardInfo_073_JA_01(), new CardInfo_074_JA_01(), new CardInfo_075_JA_01(), new CardInfo_076_JA_01(), new CardInfo_077_JA_01(), new CardInfo_078_JA_01(), new CardInfo_079_JA_01(), new CardInfo_080_JA_01(), new CardInfo_081_JA_01(), new CardInfo_082_JA_01(), new CardInfo_083_JA_01(), new CardInfo_084_JA_01(), new CardInfo_085_JA_01(), new CardInfo_086_JA_01(), new CardInfo_087_JA_01(), new CardInfo_088_JA_01(), new CardInfo_089_JA_01(), new CardInfo_090_JA_01(), new CardInfo_091_JA_01(), new CardInfo_092_JA_01(), new CardInfo_093_JA_01(), new CardInfo_094_JA_01(), new CardInfo_095_JA_01(), new CardInfo_096_JA_01(), new CardInfo_097_JA_01(), new CardInfo_098_JA_01(), new CardInfo_099_JA_01(), new CardInfo_100_JA_01(), new CardInfo_101_JA_01(), new CardInfo_102_JA_01(), new CardInfo_103_JA_01(), new CardInfo_104_JA_01(), new CardInfo_105_JA_01(), new CardInfo_106_JA_01(), new CardInfo_107_JA_01(), new CardInfo_108_JA_01(), new CardInfo_109_JA_01(), new CardInfo_110_JA_01(), new CardInfo_111_JA_01(), new CardInfo_112_JA_01(), new CardInfo_113_JA_01(), new CardInfo_114_JA_01(), new CardInfo_115_JA_01(), new CardInfo_116_JA_01(), new CardInfo_117_JA_01(), new CardInfo_118_JA_01(), new CardInfo_119_JA_01(), new CardInfo_120_JA_01(), new CardInfo_121_JA_01(), new CardInfo_122_JA_01(), new CardInfo_123_JA_01(), new CardInfo_124_JA_01(), new CardInfo_125_JA_01(), new CardInfo_126_JA_01(), new CardInfo_127_JA_01(), new CardInfo_128_JA_01(), new CardInfo_129_JA_01(), new CardInfo_130_JA_01(), new CardInfo_131_JA_01(), new CardInfo_132_JA_01(), new CardInfo_133_JA_01(), new CardInfo_134_JA_01(), new CardInfo_135_JA_01(), new CardInfo_136_JA_01(), new CardInfo_137_JA_01(), new CardInfo_138_JA_01(), new CardInfo_139_JA_01(), new CardInfo_140_JA_01(), new CardInfo_141_JA_01(), new CardInfo_142_JA_01(), new CardInfo_143_JA_01(), new CardInfo_144_JA_01(), new CardInfo_145_JA_01(), new CardInfo_146_JA_01(), new CardInfo_147_JA_01(), new CardInfo_148_JA_01(), new CardInfo_149_JA_01(), new CardInfo_150_JA_01(), new CardInfo_151_JA_01(), new CardInfo_152_JA_01(), new CardInfo_153_JA_01(), new CardInfo_154_JA_01(), new CardInfo_155_JA_01(), new CardInfo_156_JA_01(), new CardInfo_157_JA_01(), new CardInfo_158_JA_01(), new CardInfo_159_JA_01(), new CardInfo_160_JA_01(), new CardInfo_161_JA_01(), new CardInfo_162_JA_01(), new CardInfo_163_JA_01(), new CardInfo_164_JA_01(), new CardInfo_165_JA_01(), new CardInfo_166_JA_01(), new CardInfo_167_JA_01(), new CardInfo_168_JA_01(), new CardInfo_169_JA_01(), new CardInfo_170_JA_01(), new CardInfo_171_JA_01(), new CardInfo_172_JA_01(), new CardInfo_173_JA_01(), new CardInfo_174_JA_01(), new CardInfo_175_JA_01(), new CardInfo_176_JA_01(), new CardInfo_177_JA_01(), new CardInfo_178_JA_01(), new CardInfo_179_JA_01(), new CardInfo_180_JA_01(), new CardInfo_181_JA_01(), new CardInfo_182_JA_01(), new CardInfo_183_JA_01(), new CardInfo_184_JA_01(), new CardInfo_185_JA_01(), new CardInfo_186_JA_01(), new CardInfo_187_JA_01(), new CardInfo_188_JA_01(), new CardInfo_189_JA_01(), new CardInfo_190_JA_01(), new CardInfo_191_JA_01(), new CardInfo_192_JA_01(), new CardInfo_193_JA_01(), new CardInfo_194_JA_01(), new CardInfo_195_JA_01(), new CardInfo_196_JA_01(), new CardInfo_197_JA_01(), new CardInfo_198_JA_01(), new CardInfo_199_JA_01(), new CardInfo_200_JA_01(), new CardInfo_201_JA_01(), new CardInfo_202_JA_01(), new CardInfo_203_JA_01(), new CardInfo_204_JA_01(), new CardInfo_205_JA_01(), new CardInfo_206_JA_01(), new CardInfo_207_JA_01(), new CardInfo_208_JA_01(), new CardInfo_209_JA_01(), new CardInfo_210_JA_01(), new CardInfo_211_JA_01(), new CardInfo_212_JA_01(), new CardInfo_213_JA_01(), new CardInfo_214_JA_01(), new CardInfo_215_JA_01(), new CardInfo_216_JA_01() };
        CardInfoList_RiseOfTheFloodBorn = new List<CardInfo> { new CardInfo_001_JA_02(), new CardInfo_002_JA_02(), new CardInfo_003_JA_02(), new CardInfo_004_JA_02(), new CardInfo_005_JA_02(), new CardInfo_006_JA_02(), new CardInfo_007_JA_02(), new CardInfo_008_JA_02(), new CardInfo_009_JA_02(), new CardInfo_010_JA_02(), new CardInfo_011_JA_02(), new CardInfo_012_JA_02(), new CardInfo_013_JA_02(), new CardInfo_014_JA_02(), new CardInfo_015_JA_02(), new CardInfo_016_JA_02(), new CardInfo_017_JA_02(), new CardInfo_018_JA_02(), new CardInfo_019_JA_02(), new CardInfo_020_JA_02(), new CardInfo_021_JA_02(), new CardInfo_022_JA_02(), new CardInfo_023_JA_02(), new CardInfo_024_JA_02(), new CardInfo_025_JA_02(), new CardInfo_026_JA_02(), new CardInfo_027_JA_02(), new CardInfo_028_JA_02(), new CardInfo_029_JA_02(), new CardInfo_030_JA_02(), new CardInfo_031_JA_02(), new CardInfo_032_JA_02(), new CardInfo_033_JA_02(), new CardInfo_034_JA_02(), new CardInfo_035_JA_02(), new CardInfo_036_JA_02(), new CardInfo_037_JA_02(), new CardInfo_038_JA_02(), new CardInfo_039_JA_02(), new CardInfo_040_JA_02(), new CardInfo_041_JA_02(), new CardInfo_042_JA_02(), new CardInfo_043_JA_02(), new CardInfo_044_JA_02(), new CardInfo_045_JA_02(), new CardInfo_046_JA_02(), new CardInfo_047_JA_02(), new CardInfo_048_JA_02(), new CardInfo_049_JA_02(), new CardInfo_050_JA_02(), new CardInfo_051_JA_02(), new CardInfo_052_JA_02(), new CardInfo_053_JA_02(), new CardInfo_054_JA_02(), new CardInfo_055_JA_02(), new CardInfo_056_JA_02(), new CardInfo_057_JA_02(), new CardInfo_058_JA_02(), new CardInfo_059_JA_02(), new CardInfo_060_JA_02(), new CardInfo_061_JA_02(), new CardInfo_062_JA_02(), new CardInfo_063_JA_02(), new CardInfo_064_JA_02(), new CardInfo_065_JA_02(), new CardInfo_066_JA_02(), new CardInfo_067_JA_02(), new CardInfo_068_JA_02(), new CardInfo_069_JA_02(), new CardInfo_070_JA_02(), new CardInfo_071_JA_02(), new CardInfo_072_JA_02(), new CardInfo_073_JA_02(), new CardInfo_074_JA_02(), new CardInfo_075_JA_02(), new CardInfo_076_JA_02(), new CardInfo_077_JA_02(), new CardInfo_078_JA_02(), new CardInfo_079_JA_02(), new CardInfo_080_JA_02(), new CardInfo_081_JA_02(), new CardInfo_082_JA_02(), new CardInfo_083_JA_02(), new CardInfo_084_JA_02(), new CardInfo_085_JA_02(), new CardInfo_086_JA_02(), new CardInfo_087_JA_02(), new CardInfo_088_JA_02(), new CardInfo_089_JA_02(), new CardInfo_090_JA_02(), new CardInfo_091_JA_02(), new CardInfo_092_JA_02(), new CardInfo_093_JA_02(), new CardInfo_094_JA_02(), new CardInfo_095_JA_02(), new CardInfo_096_JA_02(), new CardInfo_097_JA_02(), new CardInfo_098_JA_02(), new CardInfo_099_JA_02(), new CardInfo_100_JA_02(), new CardInfo_101_JA_02(), new CardInfo_102_JA_02(), new CardInfo_103_JA_02(), new CardInfo_104_JA_02(), new CardInfo_105_JA_02(), new CardInfo_106_JA_02(), new CardInfo_107_JA_02(), new CardInfo_108_JA_02(), new CardInfo_109_JA_02(), new CardInfo_110_JA_02(), new CardInfo_111_JA_02(), new CardInfo_112_JA_02(), new CardInfo_113_JA_02(), new CardInfo_114_JA_02(), new CardInfo_115_JA_02(), new CardInfo_116_JA_02(), new CardInfo_117_JA_02(), new CardInfo_118_JA_02(), new CardInfo_119_JA_02(), new CardInfo_120_JA_02(), new CardInfo_121_JA_02(), new CardInfo_122_JA_02(), new CardInfo_123_JA_02(), new CardInfo_124_JA_02(), new CardInfo_125_JA_02(), new CardInfo_126_JA_02(), new CardInfo_127_JA_02(), new CardInfo_128_JA_02(), new CardInfo_129_JA_02(), new CardInfo_130_JA_02(), new CardInfo_131_JA_02(), new CardInfo_132_JA_02(), new CardInfo_133_JA_02(), new CardInfo_134_JA_02(), new CardInfo_135_JA_02(), new CardInfo_136_JA_02(), new CardInfo_137_JA_02(), new CardInfo_138_JA_02(), new CardInfo_139_JA_02(), new CardInfo_140_JA_02(), new CardInfo_141_JA_02(), new CardInfo_142_JA_02(), new CardInfo_143_JA_02(), new CardInfo_144_JA_02(), new CardInfo_145_JA_02(), new CardInfo_146_JA_02(), new CardInfo_147_JA_02(), new CardInfo_148_JA_02(), new CardInfo_149_JA_02(), new CardInfo_150_JA_02(), new CardInfo_151_JA_02(), new CardInfo_152_JA_02(), new CardInfo_153_JA_02(), new CardInfo_154_JA_02(), new CardInfo_155_JA_02(), new CardInfo_156_JA_02(), new CardInfo_157_JA_02(), new CardInfo_158_JA_02(), new CardInfo_159_JA_02(), new CardInfo_160_JA_02(), new CardInfo_161_JA_02(), new CardInfo_162_JA_02(), new CardInfo_163_JA_02(), new CardInfo_164_JA_02(), new CardInfo_165_JA_02(), new CardInfo_166_JA_02(), new CardInfo_167_JA_02(), new CardInfo_168_JA_02(), new CardInfo_169_JA_02(), new CardInfo_170_JA_02(), new CardInfo_171_JA_02(), new CardInfo_172_JA_02(), new CardInfo_173_JA_02(), new CardInfo_174_JA_02(), new CardInfo_175_JA_02(), new CardInfo_176_JA_02(), new CardInfo_177_JA_02(), new CardInfo_178_JA_02(), new CardInfo_179_JA_02(), new CardInfo_180_JA_02(), new CardInfo_181_JA_02(), new CardInfo_182_JA_02(), new CardInfo_183_JA_02(), new CardInfo_184_JA_02(), new CardInfo_185_JA_02(), new CardInfo_186_JA_02(), new CardInfo_187_JA_02(), new CardInfo_188_JA_02(), new CardInfo_189_JA_02(), new CardInfo_190_JA_02(), new CardInfo_191_JA_02(), new CardInfo_192_JA_02(), new CardInfo_193_JA_02(), new CardInfo_194_JA_02(), new CardInfo_195_JA_02(), new CardInfo_196_JA_02(), new CardInfo_197_JA_02(), new CardInfo_198_JA_02(), new CardInfo_199_JA_02(), new CardInfo_200_JA_02(), new CardInfo_201_JA_02(), new CardInfo_202_JA_02(), new CardInfo_203_JA_02(), new CardInfo_204_JA_02(), new CardInfo_205_JA_02(), new CardInfo_206_JA_02(), new CardInfo_207_JA_02(), new CardInfo_208_JA_02(), new CardInfo_209_JA_02(), new CardInfo_210_JA_02(), new CardInfo_211_JA_02(), new CardInfo_212_JA_02(), new CardInfo_213_JA_02(), new CardInfo_214_JA_02(), new CardInfo_215_JA_02(), new CardInfo_216_JA_02() };
        CardInfoList_IntoTheInkLands = new List<CardInfo> { new CardInfo_001_JA_03(), new CardInfo_002_JA_03(), new CardInfo_003_JA_03(), new CardInfo_004_JA_03(), new CardInfo_005_JA_03(), new CardInfo_006_JA_03(), new CardInfo_007_JA_03(), new CardInfo_008_JA_03(), new CardInfo_009_JA_03(), new CardInfo_010_JA_03(), new CardInfo_011_JA_03(), new CardInfo_012_JA_03(), new CardInfo_013_JA_03(), new CardInfo_014_JA_03(), new CardInfo_015_JA_03(), new CardInfo_016_JA_03(), new CardInfo_017_JA_03(), new CardInfo_018_JA_03(), new CardInfo_019_JA_03(), new CardInfo_020_JA_03(), new CardInfo_021_JA_03(), new CardInfo_022_JA_03(), new CardInfo_023_JA_03(), new CardInfo_024_JA_03(), new CardInfo_025_JA_03(), new CardInfo_026_JA_03(), new CardInfo_027_JA_03(), new CardInfo_028_JA_03(), new CardInfo_029_JA_03(), new CardInfo_030_JA_03(), new CardInfo_031_JA_03(), new CardInfo_032_JA_03(), new CardInfo_033_JA_03(), new CardInfo_034_JA_03(), new CardInfo_035_JA_03(), new CardInfo_036_JA_03(), new CardInfo_037_JA_03(), new CardInfo_038_JA_03(), new CardInfo_039_JA_03(), new CardInfo_040_JA_03(), new CardInfo_041_JA_03(), new CardInfo_042_JA_03(), new CardInfo_043_JA_03(), new CardInfo_044_JA_03(), new CardInfo_045_JA_03(), new CardInfo_046_JA_03(), new CardInfo_047_JA_03(), new CardInfo_048_JA_03(), new CardInfo_049_JA_03(), new CardInfo_050_JA_03(), new CardInfo_051_JA_03(), new CardInfo_052_JA_03(), new CardInfo_053_JA_03(), new CardInfo_054_JA_03(), new CardInfo_055_JA_03(), new CardInfo_056_JA_03(), new CardInfo_057_JA_03(), new CardInfo_058_JA_03(), new CardInfo_059_JA_03(), new CardInfo_060_JA_03(), new CardInfo_061_JA_03(), new CardInfo_062_JA_03(), new CardInfo_063_JA_03(), new CardInfo_064_JA_03(), new CardInfo_065_JA_03(), new CardInfo_066_JA_03(), new CardInfo_067_JA_03(), new CardInfo_068_JA_03(), new CardInfo_069_JA_03(), new CardInfo_070_JA_03(), new CardInfo_071_JA_03(), new CardInfo_072_JA_03(), new CardInfo_073_JA_03(), new CardInfo_074_JA_03(), new CardInfo_075_JA_03(), new CardInfo_076_JA_03(), new CardInfo_077_JA_03(), new CardInfo_078_JA_03(), new CardInfo_079_JA_03(), new CardInfo_080_JA_03(), new CardInfo_081_JA_03(), new CardInfo_082_JA_03(), new CardInfo_083_JA_03(), new CardInfo_084_JA_03(), new CardInfo_085_JA_03(), new CardInfo_086_JA_03(), new CardInfo_087_JA_03(), new CardInfo_088_JA_03(), new CardInfo_089_JA_03(), new CardInfo_090_JA_03(), new CardInfo_091_JA_03(), new CardInfo_092_JA_03(), new CardInfo_093_JA_03(), new CardInfo_094_JA_03(), new CardInfo_095_JA_03(), new CardInfo_096_JA_03(), new CardInfo_097_JA_03(), new CardInfo_098_JA_03(), new CardInfo_099_JA_03(), new CardInfo_100_JA_03(), new CardInfo_101_JA_03(), new CardInfo_102_JA_03(), new CardInfo_103_JA_03(), new CardInfo_104_JA_03(), new CardInfo_105_JA_03(), new CardInfo_106_JA_03(), new CardInfo_107_JA_03(), new CardInfo_108_JA_03(), new CardInfo_109_JA_03(), new CardInfo_110_JA_03(), new CardInfo_111_JA_03(), new CardInfo_112_JA_03(), new CardInfo_113_JA_03(), new CardInfo_114_JA_03(), new CardInfo_115_JA_03(), new CardInfo_116_JA_03(), new CardInfo_117_JA_03(), new CardInfo_118_JA_03(), new CardInfo_119_JA_03(), new CardInfo_120_JA_03(), new CardInfo_121_JA_03(), new CardInfo_122_JA_03(), new CardInfo_123_JA_03(), new CardInfo_124_JA_03(), new CardInfo_125_JA_03(), new CardInfo_126_JA_03(), new CardInfo_127_JA_03(), new CardInfo_128_JA_03(), new CardInfo_129_JA_03(), new CardInfo_130_JA_03(), new CardInfo_131_JA_03(), new CardInfo_132_JA_03(), new CardInfo_133_JA_03(), new CardInfo_134_JA_03(), new CardInfo_135_JA_03(), new CardInfo_136_JA_03(), new CardInfo_137_JA_03(), new CardInfo_138_JA_03(), new CardInfo_139_JA_03(), new CardInfo_140_JA_03(), new CardInfo_141_JA_03(), new CardInfo_142_JA_03(), new CardInfo_143_JA_03(), new CardInfo_144_JA_03(), new CardInfo_145_JA_03(), new CardInfo_146_JA_03(), new CardInfo_147_JA_03(), new CardInfo_148_JA_03(), new CardInfo_149_JA_03(), new CardInfo_150_JA_03(), new CardInfo_151_JA_03(), new CardInfo_152_JA_03(), new CardInfo_153_JA_03(), new CardInfo_154_JA_03(), new CardInfo_155_JA_03(), new CardInfo_156_JA_03(), new CardInfo_157_JA_03(), new CardInfo_158_JA_03(), new CardInfo_159_JA_03(), new CardInfo_160_JA_03(), new CardInfo_161_JA_03(), new CardInfo_162_JA_03(), new CardInfo_163_JA_03(), new CardInfo_164_JA_03(), new CardInfo_165_JA_03(), new CardInfo_166_JA_03(), new CardInfo_167_JA_03(), new CardInfo_168_JA_03(), new CardInfo_169_JA_03(), new CardInfo_170_JA_03(), new CardInfo_171_JA_03(), new CardInfo_172_JA_03(), new CardInfo_173_JA_03(), new CardInfo_174_JA_03(), new CardInfo_175_JA_03(), new CardInfo_176_JA_03(), new CardInfo_177_JA_03(), new CardInfo_178_JA_03(), new CardInfo_179_JA_03(), new CardInfo_180_JA_03(), new CardInfo_181_JA_03(), new CardInfo_182_JA_03(), new CardInfo_183_JA_03(), new CardInfo_184_JA_03(), new CardInfo_185_JA_03(), new CardInfo_186_JA_03(), new CardInfo_187_JA_03(), new CardInfo_188_JA_03(), new CardInfo_189_JA_03(), new CardInfo_190_JA_03(), new CardInfo_191_JA_03(), new CardInfo_192_JA_03(), new CardInfo_193_JA_03(), new CardInfo_194_JA_03(), new CardInfo_195_JA_03(), new CardInfo_196_JA_03(), new CardInfo_197_JA_03(), new CardInfo_198_JA_03(), new CardInfo_199_JA_03(), new CardInfo_200_JA_03(), new CardInfo_201_JA_03(), new CardInfo_202_JA_03(), new CardInfo_203_JA_03(), new CardInfo_204_JA_03(), new CardInfo_205_JA_03(), new CardInfo_206_JA_03(), new CardInfo_207_JA_03(), new CardInfo_208_JA_03(), new CardInfo_209_JA_03(), new CardInfo_210_JA_03(), new CardInfo_211_JA_03(), new CardInfo_212_JA_03(), new CardInfo_213_JA_03(), new CardInfo_214_JA_03(), new CardInfo_215_JA_03(), new CardInfo_216_JA_03(), new CardInfo_217_JA_03(), new CardInfo_218_JA_03(), new CardInfo_219_JA_03(), new CardInfo_220_JA_03(), new CardInfo_221_JA_03(), new CardInfo_222_JA_03() };
        CardInfoList_UrsulasReturn = new List<CardInfo> { new CardInfo_001_JA_04(), new CardInfo_002_JA_04(), new CardInfo_003_JA_04(), new CardInfo_004_JA_04(), new CardInfo_005_JA_04(), new CardInfo_006_JA_04(), new CardInfo_007_JA_04(), new CardInfo_008_JA_04(), new CardInfo_009_JA_04(), new CardInfo_010_JA_04(), new CardInfo_011_JA_04(), new CardInfo_012_JA_04(), new CardInfo_013_JA_04(), new CardInfo_014_JA_04(), new CardInfo_015_JA_04(), new CardInfo_016_JA_04(), new CardInfo_017_JA_04(), new CardInfo_018_JA_04(), new CardInfo_019_JA_04(), new CardInfo_020_JA_04(), new CardInfo_021_JA_04(), new CardInfo_022_JA_04(), new CardInfo_023_JA_04(), new CardInfo_024_JA_04(), new CardInfo_025_JA_04(), new CardInfo_026_JA_04(), new CardInfo_027_JA_04(), new CardInfo_028_JA_04(), new CardInfo_029_JA_04(), new CardInfo_030_JA_04(), new CardInfo_031_JA_04(), new CardInfo_032_JA_04(), new CardInfo_033_JA_04(), new CardInfo_034_JA_04(), new CardInfo_035_JA_04(), new CardInfo_036_JA_04(), new CardInfo_037_JA_04(), new CardInfo_038_JA_04(), new CardInfo_039_JA_04(), new CardInfo_040_JA_04(), new CardInfo_041_JA_04(), new CardInfo_042_JA_04(), new CardInfo_043_JA_04(), new CardInfo_044_JA_04(), new CardInfo_045_JA_04(), new CardInfo_046_JA_04(), new CardInfo_047_JA_04(), new CardInfo_048_JA_04(), new CardInfo_049_JA_04(), new CardInfo_050_JA_04(), new CardInfo_051_JA_04(), new CardInfo_052_JA_04(), new CardInfo_053_JA_04(), new CardInfo_054_JA_04(), new CardInfo_055_JA_04(), new CardInfo_056_JA_04(), new CardInfo_057_JA_04(), new CardInfo_058_JA_04(), new CardInfo_059_JA_04(), new CardInfo_060_JA_04(), new CardInfo_061_JA_04(), new CardInfo_062_JA_04(), new CardInfo_063_JA_04(), new CardInfo_064_JA_04(), new CardInfo_065_JA_04(), new CardInfo_066_JA_04(), new CardInfo_067_JA_04(), new CardInfo_068_JA_04(), new CardInfo_069_JA_04(), new CardInfo_070_JA_04(), new CardInfo_071_JA_04(), new CardInfo_072_JA_04(), new CardInfo_073_JA_04(), new CardInfo_074_JA_04(), new CardInfo_075_JA_04(), new CardInfo_076_JA_04(), new CardInfo_077_JA_04(), new CardInfo_078_JA_04(), new CardInfo_079_JA_04(), new CardInfo_080_JA_04(), new CardInfo_081_JA_04(), new CardInfo_082_JA_04(), new CardInfo_083_JA_04(), new CardInfo_084_JA_04(), new CardInfo_085_JA_04(), new CardInfo_086_JA_04(), new CardInfo_087_JA_04(), new CardInfo_088_JA_04(), new CardInfo_089_JA_04(), new CardInfo_090_JA_04(), new CardInfo_091_JA_04(), new CardInfo_092_JA_04(), new CardInfo_093_JA_04(), new CardInfo_094_JA_04(), new CardInfo_095_JA_04(), new CardInfo_096_JA_04(), new CardInfo_097_JA_04(), new CardInfo_098_JA_04(), new CardInfo_099_JA_04(), new CardInfo_100_JA_04(), new CardInfo_101_JA_04(), new CardInfo_102_JA_04(), new CardInfo_103_JA_04(), new CardInfo_104_JA_04(), new CardInfo_105_JA_04(), new CardInfo_106_JA_04(), new CardInfo_107_JA_04(), new CardInfo_108_JA_04(), new CardInfo_109_JA_04(), new CardInfo_110_JA_04(), new CardInfo_111_JA_04(), new CardInfo_112_JA_04(), new CardInfo_113_JA_04(), new CardInfo_114_JA_04(), new CardInfo_115_JA_04(), new CardInfo_116_JA_04(), new CardInfo_117_JA_04(), new CardInfo_118_JA_04(), new CardInfo_119_JA_04(), new CardInfo_120_JA_04(), new CardInfo_121_JA_04(), new CardInfo_122_JA_04(), new CardInfo_123_JA_04(), new CardInfo_124_JA_04(), new CardInfo_125_JA_04(), new CardInfo_126_JA_04(), new CardInfo_127_JA_04(), new CardInfo_128_JA_04(), new CardInfo_129_JA_04(), new CardInfo_130_JA_04(), new CardInfo_131_JA_04(), new CardInfo_132_JA_04(), new CardInfo_133_JA_04(), new CardInfo_134_JA_04(), new CardInfo_135_JA_04(), new CardInfo_136_JA_04(), new CardInfo_137_JA_04(), new CardInfo_138_JA_04(), new CardInfo_139_JA_04(), new CardInfo_140_JA_04(), new CardInfo_141_JA_04(), new CardInfo_142_JA_04(), new CardInfo_143_JA_04(), new CardInfo_144_JA_04(), new CardInfo_145_JA_04(), new CardInfo_146_JA_04(), new CardInfo_147_JA_04(), new CardInfo_148_JA_04(), new CardInfo_149_JA_04(), new CardInfo_150_JA_04(), new CardInfo_151_JA_04(), new CardInfo_152_JA_04(), new CardInfo_153_JA_04(), new CardInfo_154_JA_04(), new CardInfo_155_JA_04(), new CardInfo_156_JA_04(), new CardInfo_157_JA_04(), new CardInfo_158_JA_04(), new CardInfo_159_JA_04(), new CardInfo_160_JA_04(), new CardInfo_161_JA_04(), new CardInfo_162_JA_04(), new CardInfo_163_JA_04(), new CardInfo_164_JA_04(), new CardInfo_165_JA_04(), new CardInfo_166_JA_04(), new CardInfo_167_JA_04(), new CardInfo_168_JA_04(), new CardInfo_169_JA_04(), new CardInfo_170_JA_04(), new CardInfo_171_JA_04(), new CardInfo_172_JA_04(), new CardInfo_173_JA_04(), new CardInfo_174_JA_04(), new CardInfo_175_JA_04(), new CardInfo_176_JA_04(), new CardInfo_177_JA_04(), new CardInfo_178_JA_04(), new CardInfo_179_JA_04(), new CardInfo_180_JA_04(), new CardInfo_181_JA_04(), new CardInfo_182_JA_04(), new CardInfo_183_JA_04(), new CardInfo_184_JA_04(), new CardInfo_185_JA_04(), new CardInfo_186_JA_04(), new CardInfo_187_JA_04(), new CardInfo_188_JA_04(), new CardInfo_189_JA_04(), new CardInfo_190_JA_04(), new CardInfo_191_JA_04(), new CardInfo_192_JA_04(), new CardInfo_193_JA_04(), new CardInfo_194_JA_04(), new CardInfo_195_JA_04(), new CardInfo_196_JA_04(), new CardInfo_197_JA_04(), new CardInfo_198_JA_04(), new CardInfo_199_JA_04(), new CardInfo_200_JA_04(), new CardInfo_201_JA_04(), new CardInfo_202_JA_04(), new CardInfo_203_JA_04(), new CardInfo_204_JA_04(), new CardInfo_205_JA_04(), new CardInfo_206_JA_04(), new CardInfo_207_JA_04(), new CardInfo_208_JA_04(), new CardInfo_209_JA_04(), new CardInfo_210_JA_04(), new CardInfo_211_JA_04(), new CardInfo_212_JA_04(), new CardInfo_213_JA_04(), new CardInfo_214_JA_04(), new CardInfo_215_JA_04(), new CardInfo_216_JA_04(), new CardInfo_217_JA_04(), new CardInfo_218_JA_04(), new CardInfo_219_JA_04(), new CardInfo_220_JA_04(), new CardInfo_221_JA_04(), new CardInfo_222_JA_04() };
        CardInfoList_ShimmeringSkies = new List<CardInfo>() { new CardInfo_001_JA_05(), new CardInfo_002_JA_05(), new CardInfo_003_JA_05(), new CardInfo_004_JA_05(), new CardInfo_005_JA_05(), new CardInfo_006_JA_05(), new CardInfo_007_JA_05(), new CardInfo_008_JA_05(), new CardInfo_009_JA_05(), new CardInfo_010_JA_05(), new CardInfo_011_JA_05(), new CardInfo_012_JA_05(), new CardInfo_013_JA_05(), new CardInfo_014_JA_05(), new CardInfo_015_JA_05(), new CardInfo_016_JA_05(), new CardInfo_017_JA_05(), new CardInfo_018_JA_05(), new CardInfo_019_JA_05(), new CardInfo_020_JA_05(), new CardInfo_021_JA_05(), new CardInfo_022_JA_05(), new CardInfo_023_JA_05(), new CardInfo_024_JA_05(), new CardInfo_025_JA_05(), new CardInfo_026_JA_05(), new CardInfo_027_JA_05(), new CardInfo_028_JA_05(), new CardInfo_029_JA_05(), new CardInfo_030_JA_05(), new CardInfo_031_JA_05(), new CardInfo_032_JA_05(), new CardInfo_033_JA_05(), new CardInfo_034_JA_05(), new CardInfo_035_JA_05(), new CardInfo_036_JA_05(), new CardInfo_037_JA_05(), new CardInfo_038_JA_05(), new CardInfo_039_JA_05(), new CardInfo_040_JA_05(), new CardInfo_041_JA_05(), new CardInfo_042_JA_05(), new CardInfo_043_JA_05(), new CardInfo_044_JA_05(), new CardInfo_045_JA_05(), new CardInfo_046_JA_05(), new CardInfo_047_JA_05(), new CardInfo_048_JA_05(), new CardInfo_049_JA_05(), new CardInfo_050_JA_05(), new CardInfo_051_JA_05(), new CardInfo_052_JA_05(), new CardInfo_053_JA_05(), new CardInfo_054_JA_05(), new CardInfo_055_JA_05(), new CardInfo_056_JA_05(), new CardInfo_057_JA_05(), new CardInfo_058_JA_05(), new CardInfo_059_JA_05(), new CardInfo_060_JA_05(), new CardInfo_061_JA_05(), new CardInfo_062_JA_05(), new CardInfo_063_JA_05(), new CardInfo_064_JA_05(), new CardInfo_065_JA_05(), new CardInfo_066_JA_05(), new CardInfo_067_JA_05(), new CardInfo_068_JA_05(), new CardInfo_069_JA_05(), new CardInfo_070_JA_05(), new CardInfo_071_JA_05(), new CardInfo_072_JA_05(), new CardInfo_073_JA_05(), new CardInfo_074_JA_05(), new CardInfo_075_JA_05(), new CardInfo_076_JA_05(), new CardInfo_077_JA_05(), new CardInfo_078_JA_05(), new CardInfo_079_JA_05(), new CardInfo_080_JA_05(), new CardInfo_081_JA_05(), new CardInfo_082_JA_05(), new CardInfo_083_JA_05(), new CardInfo_084_JA_05(), new CardInfo_085_JA_05(), new CardInfo_086_JA_05(), new CardInfo_087_JA_05(), new CardInfo_088_JA_05(), new CardInfo_089_JA_05(), new CardInfo_090_JA_05(), new CardInfo_091_JA_05(), new CardInfo_092_JA_05(), new CardInfo_093_JA_05(), new CardInfo_094_JA_05(), new CardInfo_095_JA_05(), new CardInfo_096_JA_05(), new CardInfo_097_JA_05(), new CardInfo_098_JA_05(), new CardInfo_099_JA_05(), new CardInfo_100_JA_05(), new CardInfo_101_JA_05(), new CardInfo_102_JA_05(), new CardInfo_103_JA_05(), new CardInfo_104_JA_05(), new CardInfo_105_JA_05(), new CardInfo_106_JA_05(), new CardInfo_107_JA_05(), new CardInfo_108_JA_05(), new CardInfo_109_JA_05(), new CardInfo_110_JA_05(), new CardInfo_111_JA_05(), new CardInfo_112_JA_05(), new CardInfo_113_JA_05(), new CardInfo_114_JA_05(), new CardInfo_115_JA_05(), new CardInfo_116_JA_05(), new CardInfo_117_JA_05(), new CardInfo_118_JA_05(), new CardInfo_119_JA_05(), new CardInfo_120_JA_05(), new CardInfo_121_JA_05(), new CardInfo_122_JA_05(), new CardInfo_123_JA_05(), new CardInfo_124_JA_05(), new CardInfo_125_JA_05(), new CardInfo_126_JA_05(), new CardInfo_127_JA_05(), new CardInfo_128_JA_05(), new CardInfo_129_JA_05(), new CardInfo_130_JA_05(), new CardInfo_131_JA_05(), new CardInfo_132_JA_05(), new CardInfo_133_JA_05(), new CardInfo_134_JA_05(), new CardInfo_135_JA_05(), new CardInfo_136_JA_05(), new CardInfo_137_JA_05(), new CardInfo_138_JA_05(), new CardInfo_139_JA_05(), new CardInfo_140_JA_05(), new CardInfo_141_JA_05(), new CardInfo_142_JA_05(), new CardInfo_143_JA_05(), new CardInfo_144_JA_05(), new CardInfo_145_JA_05(), new CardInfo_146_JA_05(), new CardInfo_147_JA_05(), new CardInfo_148_JA_05(), new CardInfo_149_JA_05(), new CardInfo_150_JA_05(), new CardInfo_151_JA_05(), new CardInfo_152_JA_05(), new CardInfo_153_JA_05(), new CardInfo_154_JA_05(), new CardInfo_155_JA_05(), new CardInfo_156_JA_05(), new CardInfo_157_JA_05(), new CardInfo_158_JA_05(), new CardInfo_159_JA_05(), new CardInfo_160_JA_05(), new CardInfo_161_JA_05(), new CardInfo_162_JA_05(), new CardInfo_163_JA_05(), new CardInfo_164_JA_05(), new CardInfo_165_JA_05(), new CardInfo_166_JA_05(), new CardInfo_167_JA_05(), new CardInfo_168_JA_05(), new CardInfo_169_JA_05(), new CardInfo_170_JA_05(), new CardInfo_171_JA_05(), new CardInfo_172_JA_05(), new CardInfo_173_JA_05(), new CardInfo_174_JA_05(), new CardInfo_175_JA_05(), new CardInfo_176_JA_05(), new CardInfo_177_JA_05(), new CardInfo_178_JA_05(), new CardInfo_179_JA_05(), new CardInfo_180_JA_05(), new CardInfo_181_JA_05(), new CardInfo_182_JA_05(), new CardInfo_183_JA_05(), new CardInfo_184_JA_05(), new CardInfo_185_JA_05(), new CardInfo_186_JA_05(), new CardInfo_187_JA_05(), new CardInfo_188_JA_05(), new CardInfo_189_JA_05(), new CardInfo_190_JA_05(), new CardInfo_191_JA_05(), new CardInfo_192_JA_05(), new CardInfo_193_JA_05(), new CardInfo_194_JA_05(), new CardInfo_195_JA_05(), new CardInfo_196_JA_05(), new CardInfo_197_JA_05(), new CardInfo_198_JA_05(), new CardInfo_199_JA_05(), new CardInfo_200_JA_05(), new CardInfo_201_JA_05(), new CardInfo_202_JA_05(), new CardInfo_203_JA_05(), new CardInfo_204_JA_05(), new CardInfo_205_JA_05(), new CardInfo_206_JA_05(), new CardInfo_207_JA_05(), new CardInfo_208_JA_05(), new CardInfo_209_JA_05(), new CardInfo_210_JA_05(), new CardInfo_211_JA_05(), new CardInfo_212_JA_05(), new CardInfo_213_JA_05(), new CardInfo_214_JA_05(), new CardInfo_215_JA_05(), new CardInfo_216_JA_05(), new CardInfo_217_JA_05(), new CardInfo_218_JA_05(), new CardInfo_219_JA_05(), new CardInfo_220_JA_05(), new CardInfo_221_JA_05(), new CardInfo_222_JA_05() };
        CardInfoList_AzuriteSea = new List<CardInfo>() { new CardInfo_001_JA_06(), new CardInfo_002_JA_06(), new CardInfo_003_JA_06(), new CardInfo_004_JA_06(), new CardInfo_005_JA_06(), new CardInfo_006_JA_06(), new CardInfo_007_JA_06(), new CardInfo_008_JA_06(), new CardInfo_009_JA_06(), new CardInfo_010_JA_06(), new CardInfo_011_JA_06(), new CardInfo_012_JA_06(), new CardInfo_013_JA_06(), new CardInfo_014_JA_06(), new CardInfo_015_JA_06(), new CardInfo_016_JA_06(), new CardInfo_017_JA_06(), new CardInfo_018_JA_06(), new CardInfo_019_JA_06(), new CardInfo_020_JA_06(), new CardInfo_021_JA_06(), new CardInfo_022_JA_06(), new CardInfo_023_JA_06(), new CardInfo_024_JA_06(), new CardInfo_025_JA_06(), new CardInfo_026_JA_06(), new CardInfo_027_JA_06(), new CardInfo_028_JA_06(), new CardInfo_029_JA_06(), new CardInfo_030_JA_06(), new CardInfo_031_JA_06(), new CardInfo_032_JA_06(), new CardInfo_033_JA_06(), new CardInfo_034_JA_06(), new CardInfo_035_JA_06(), new CardInfo_036_JA_06(), new CardInfo_037_JA_06(), new CardInfo_038_JA_06(), new CardInfo_039_JA_06(), new CardInfo_040_JA_06(), new CardInfo_041_JA_06(), new CardInfo_042_JA_06(), new CardInfo_043_JA_06(), new CardInfo_044_JA_06(), new CardInfo_045_JA_06(), new CardInfo_046_JA_06(), new CardInfo_047_JA_06(), new CardInfo_048_JA_06(), new CardInfo_049_JA_06(), new CardInfo_050_JA_06(), new CardInfo_051_JA_06(), new CardInfo_052_JA_06(), new CardInfo_053_JA_06(), new CardInfo_054_JA_06(), new CardInfo_055_JA_06(), new CardInfo_056_JA_06(), new CardInfo_057_JA_06(), new CardInfo_058_JA_06(), new CardInfo_059_JA_06(), new CardInfo_060_JA_06(), new CardInfo_061_JA_06(), new CardInfo_062_JA_06(), new CardInfo_063_JA_06(), new CardInfo_064_JA_06(), new CardInfo_065_JA_06(), new CardInfo_066_JA_06(), new CardInfo_067_JA_06(), new CardInfo_068_JA_06(), new CardInfo_069_JA_06(), new CardInfo_070_JA_06(), new CardInfo_071_JA_06(), new CardInfo_072_JA_06(), new CardInfo_073_JA_06(), new CardInfo_074_JA_06(), new CardInfo_075_JA_06(), new CardInfo_076_JA_06(), new CardInfo_077_JA_06(), new CardInfo_078_JA_06(), new CardInfo_079_JA_06(), new CardInfo_080_JA_06(), new CardInfo_081_JA_06(), new CardInfo_082_JA_06(), new CardInfo_083_JA_06(), new CardInfo_084_JA_06(), new CardInfo_085_JA_06(), new CardInfo_086_JA_06(), new CardInfo_087_JA_06(), new CardInfo_088_JA_06(), new CardInfo_089_JA_06(), new CardInfo_090_JA_06(), new CardInfo_091_JA_06(), new CardInfo_092_JA_06(), new CardInfo_093_JA_06(), new CardInfo_094_JA_06(), new CardInfo_095_JA_06(), new CardInfo_096_JA_06(), new CardInfo_097_JA_06(), new CardInfo_098_JA_06(), new CardInfo_099_JA_06(), new CardInfo_100_JA_06(), new CardInfo_101_JA_06(), new CardInfo_102_JA_06(), new CardInfo_103_JA_06(), new CardInfo_104_JA_06(), new CardInfo_105_JA_06(), new CardInfo_106_JA_06(), new CardInfo_107_JA_06(), new CardInfo_108_JA_06(), new CardInfo_109_JA_06(), new CardInfo_110_JA_06(), new CardInfo_111_JA_06(), new CardInfo_112_JA_06(), new CardInfo_113_JA_06(), new CardInfo_114_JA_06(), new CardInfo_115_JA_06(), new CardInfo_116_JA_06(), new CardInfo_117_JA_06(), new CardInfo_118_JA_06(), new CardInfo_119_JA_06(), new CardInfo_120_JA_06(), new CardInfo_121_JA_06(), new CardInfo_122_JA_06(), new CardInfo_123_JA_06(), new CardInfo_124_JA_06(), new CardInfo_125_JA_06(), new CardInfo_126_JA_06(), new CardInfo_127_JA_06(), new CardInfo_128_JA_06(), new CardInfo_129_JA_06(), new CardInfo_130_JA_06(), new CardInfo_131_JA_06(), new CardInfo_132_JA_06(), new CardInfo_133_JA_06(), new CardInfo_134_JA_06(), new CardInfo_135_JA_06(), new CardInfo_136_JA_06(), new CardInfo_137_JA_06(), new CardInfo_138_JA_06(), new CardInfo_139_JA_06(), new CardInfo_140_JA_06(), new CardInfo_141_JA_06(), new CardInfo_142_JA_06(), new CardInfo_143_JA_06(), new CardInfo_144_JA_06(), new CardInfo_145_JA_06(), new CardInfo_146_JA_06(), new CardInfo_147_JA_06(), new CardInfo_148_JA_06(), new CardInfo_149_JA_06(), new CardInfo_150_JA_06(), new CardInfo_151_JA_06(), new CardInfo_152_JA_06(), new CardInfo_153_JA_06(), new CardInfo_154_JA_06(), new CardInfo_155_JA_06(), new CardInfo_156_JA_06(), new CardInfo_157_JA_06(), new CardInfo_158_JA_06(), new CardInfo_159_JA_06(), new CardInfo_160_JA_06(), new CardInfo_161_JA_06(), new CardInfo_162_JA_06(), new CardInfo_163_JA_06(), new CardInfo_164_JA_06(), new CardInfo_165_JA_06(), new CardInfo_166_JA_06(), new CardInfo_167_JA_06(), new CardInfo_168_JA_06(), new CardInfo_169_JA_06(), new CardInfo_170_JA_06(), new CardInfo_171_JA_06(), new CardInfo_172_JA_06(), new CardInfo_173_JA_06(), new CardInfo_174_JA_06(), new CardInfo_175_JA_06(), new CardInfo_176_JA_06(), new CardInfo_177_JA_06(), new CardInfo_178_JA_06(), new CardInfo_179_JA_06(), new CardInfo_180_JA_06(), new CardInfo_181_JA_06(), new CardInfo_182_JA_06(), new CardInfo_183_JA_06(), new CardInfo_184_JA_06(), new CardInfo_185_JA_06(), new CardInfo_186_JA_06(), new CardInfo_187_JA_06(), new CardInfo_188_JA_06(), new CardInfo_189_JA_06(), new CardInfo_190_JA_06(), new CardInfo_191_JA_06(), new CardInfo_192_JA_06(), new CardInfo_193_JA_06(), new CardInfo_194_JA_06(), new CardInfo_195_JA_06(), new CardInfo_196_JA_06(), new CardInfo_197_JA_06(), new CardInfo_198_JA_06(), new CardInfo_199_JA_06(), new CardInfo_200_JA_06(), new CardInfo_201_JA_06(), new CardInfo_202_JA_06(), new CardInfo_203_JA_06(), new CardInfo_204_JA_06(), new CardInfo_205_JA_06(), new CardInfo_206_JA_06(), new CardInfo_207_JA_06(), new CardInfo_208_JA_06(), new CardInfo_209_JA_06(), new CardInfo_210_JA_06(), new CardInfo_211_JA_06(), new CardInfo_212_JA_06(), new CardInfo_213_JA_06(), new CardInfo_214_JA_06(), new CardInfo_215_JA_06(), new CardInfo_216_JA_06(), new CardInfo_217_JA_06(), new CardInfo_218_JA_06(), new CardInfo_219_JA_06(), new CardInfo_220_JA_06(), new CardInfo_221_JA_06(), new CardInfo_222_JA_06() };
        CardInfoList_ArchaziasIsland = new List<CardInfo>() { new CardInfo_001_JA_07(), new CardInfo_002_JA_07(), new CardInfo_003_JA_07(), new CardInfo_004_JA_07(), new CardInfo_005_JA_07(), new CardInfo_006_JA_07(), new CardInfo_007_JA_07(), new CardInfo_008_JA_07(), new CardInfo_009_JA_07(), new CardInfo_010_JA_07(), new CardInfo_011_JA_07(), new CardInfo_012_JA_07(), new CardInfo_013_JA_07(), new CardInfo_014_JA_07(), new CardInfo_015_JA_07(), new CardInfo_016_JA_07(), new CardInfo_017_JA_07(), new CardInfo_018_JA_07(), new CardInfo_019_JA_07(), new CardInfo_020_JA_07(), new CardInfo_021_JA_07(), new CardInfo_022_JA_07(), new CardInfo_023_JA_07(), new CardInfo_024_JA_07(), new CardInfo_025_JA_07(), new CardInfo_026_JA_07(), new CardInfo_027_JA_07(), new CardInfo_028_JA_07(), new CardInfo_029_JA_07(), new CardInfo_030_JA_07(), new CardInfo_031_JA_07(), new CardInfo_032_JA_07(), new CardInfo_033_JA_07(), new CardInfo_034_JA_07(), new CardInfo_035_JA_07(), new CardInfo_036_JA_07(), new CardInfo_037_JA_07(), new CardInfo_038_JA_07(), new CardInfo_039_JA_07(), new CardInfo_040_JA_07(), new CardInfo_041_JA_07(), new CardInfo_042_JA_07(), new CardInfo_043_JA_07(), new CardInfo_044_JA_07(), new CardInfo_045_JA_07(), new CardInfo_046_JA_07(), new CardInfo_047_JA_07(), new CardInfo_048_JA_07(), new CardInfo_049_JA_07(), new CardInfo_050_JA_07(), new CardInfo_051_JA_07(), new CardInfo_052_JA_07(), new CardInfo_053_JA_07(), new CardInfo_054_JA_07(), new CardInfo_055_JA_07(), new CardInfo_056_JA_07(), new CardInfo_057_JA_07(), new CardInfo_058_JA_07(), new CardInfo_059_JA_07(), new CardInfo_060_JA_07(), new CardInfo_061_JA_07(), new CardInfo_062_JA_07(), new CardInfo_063_JA_07(), new CardInfo_064_JA_07(), new CardInfo_065_JA_07(), new CardInfo_066_JA_07(), new CardInfo_067_JA_07(), new CardInfo_068_JA_07(), new CardInfo_069_JA_07(), new CardInfo_070_JA_07(), new CardInfo_071_JA_07(), new CardInfo_072_JA_07(), new CardInfo_073_JA_07(), new CardInfo_074_JA_07(), new CardInfo_075_JA_07(), new CardInfo_076_JA_07(), new CardInfo_077_JA_07(), new CardInfo_078_JA_07(), new CardInfo_079_JA_07(), new CardInfo_080_JA_07(), new CardInfo_081_JA_07(), new CardInfo_082_JA_07(), new CardInfo_083_JA_07(), new CardInfo_084_JA_07(), new CardInfo_085_JA_07(), new CardInfo_086_JA_07(), new CardInfo_087_JA_07(), new CardInfo_088_JA_07(), new CardInfo_089_JA_07(), new CardInfo_090_JA_07(), new CardInfo_091_JA_07(), new CardInfo_092_JA_07(), new CardInfo_093_JA_07(), new CardInfo_094_JA_07(), new CardInfo_095_JA_07(), new CardInfo_096_JA_07(), new CardInfo_097_JA_07(), new CardInfo_098_JA_07(), new CardInfo_099_JA_07(), new CardInfo_100_JA_07(), new CardInfo_101_JA_07(), new CardInfo_102_JA_07(), new CardInfo_103_JA_07(), new CardInfo_104_JA_07(), new CardInfo_105_JA_07(), new CardInfo_106_JA_07(), new CardInfo_107_JA_07(), new CardInfo_108_JA_07(), new CardInfo_109_JA_07(), new CardInfo_110_JA_07(), new CardInfo_111_JA_07(), new CardInfo_112_JA_07(), new CardInfo_113_JA_07(), new CardInfo_114_JA_07(), new CardInfo_115_JA_07(), new CardInfo_116_JA_07(), new CardInfo_117_JA_07(), new CardInfo_118_JA_07(), new CardInfo_119_JA_07(), new CardInfo_120_JA_07(), new CardInfo_121_JA_07(), new CardInfo_122_JA_07(), new CardInfo_123_JA_07(), new CardInfo_124_JA_07(), new CardInfo_125_JA_07(), new CardInfo_126_JA_07(), new CardInfo_127_JA_07(), new CardInfo_128_JA_07(), new CardInfo_129_JA_07(), new CardInfo_130_JA_07(), new CardInfo_131_JA_07(), new CardInfo_132_JA_07(), new CardInfo_133_JA_07(), new CardInfo_134_JA_07(), new CardInfo_135_JA_07(), new CardInfo_136_JA_07(), new CardInfo_137_JA_07(), new CardInfo_138_JA_07(), new CardInfo_139_JA_07(), new CardInfo_140_JA_07(), new CardInfo_141_JA_07(), new CardInfo_142_JA_07(), new CardInfo_143_JA_07(), new CardInfo_144_JA_07(), new CardInfo_145_JA_07(), new CardInfo_146_JA_07(), new CardInfo_147_JA_07(), new CardInfo_148_JA_07(), new CardInfo_149_JA_07(), new CardInfo_150_JA_07(), new CardInfo_151_JA_07(), new CardInfo_152_JA_07(), new CardInfo_153_JA_07(), new CardInfo_154_JA_07(), new CardInfo_155_JA_07(), new CardInfo_156_JA_07(), new CardInfo_157_JA_07(), new CardInfo_158_JA_07(), new CardInfo_159_JA_07(), new CardInfo_160_JA_07(), new CardInfo_161_JA_07(), new CardInfo_162_JA_07(), new CardInfo_163_JA_07(), new CardInfo_164_JA_07(), new CardInfo_165_JA_07(), new CardInfo_166_JA_07(), new CardInfo_167_JA_07(), new CardInfo_168_JA_07(), new CardInfo_169_JA_07(), new CardInfo_170_JA_07(), new CardInfo_171_JA_07(), new CardInfo_172_JA_07(), new CardInfo_173_JA_07(), new CardInfo_174_JA_07(), new CardInfo_175_JA_07(), new CardInfo_176_JA_07(), new CardInfo_177_JA_07(), new CardInfo_178_JA_07(), new CardInfo_179_JA_07(), new CardInfo_180_JA_07(), new CardInfo_181_JA_07(), new CardInfo_182_JA_07(), new CardInfo_183_JA_07(), new CardInfo_184_JA_07(), new CardInfo_185_JA_07(), new CardInfo_186_JA_07(), new CardInfo_187_JA_07(), new CardInfo_188_JA_07(), new CardInfo_189_JA_07(), new CardInfo_190_JA_07(), new CardInfo_191_JA_07(), new CardInfo_192_JA_07(), new CardInfo_193_JA_07(), new CardInfo_194_JA_07(), new CardInfo_195_JA_07(), new CardInfo_196_JA_07(), new CardInfo_197_JA_07(), new CardInfo_198_JA_07(), new CardInfo_199_JA_07(), new CardInfo_200_JA_07(), new CardInfo_201_JA_07(), new CardInfo_202_JA_07(), new CardInfo_203_JA_07(), new CardInfo_204_JA_07(), new CardInfo_205_JA_07(), new CardInfo_206_JA_07(), new CardInfo_207_JA_07(), new CardInfo_208_JA_07(), new CardInfo_209_JA_07(), new CardInfo_210_JA_07(), new CardInfo_211_JA_07(), new CardInfo_212_JA_07(), new CardInfo_213_JA_07(), new CardInfo_214_JA_07(), new CardInfo_215_JA_07(), new CardInfo_216_JA_07(), new CardInfo_217_JA_07(), new CardInfo_218_JA_07(), new CardInfo_219_JA_07(), new CardInfo_220_JA_07(), new CardInfo_221_JA_07(), new CardInfo_222_JA_07() };
        CardInfoList_ReignOfJafar = new List<CardInfo>() { new CardInfo_001_JA_08(), new CardInfo_002_JA_08(), new CardInfo_003_JA_08(), new CardInfo_004_JA_08(), new CardInfo_005_JA_08(), new CardInfo_006_JA_08(), new CardInfo_007_JA_08(), new CardInfo_008_JA_08(), new CardInfo_009_JA_08(), new CardInfo_010_JA_08(), new CardInfo_011_JA_08(), new CardInfo_012_JA_08(), new CardInfo_013_JA_08(), new CardInfo_014_JA_08(), new CardInfo_015_JA_08(), new CardInfo_016_JA_08(), new CardInfo_017_JA_08(), new CardInfo_018_JA_08(), new CardInfo_019_JA_08(), new CardInfo_020_JA_08(), new CardInfo_021_JA_08(), new CardInfo_022_JA_08(), new CardInfo_023_JA_08(), new CardInfo_024_JA_08(), new CardInfo_025_JA_08(), new CardInfo_026_JA_08(), new CardInfo_027_JA_08(), new CardInfo_028_JA_08(), new CardInfo_029_JA_08(), new CardInfo_030_JA_08(), new CardInfo_031_JA_08(), new CardInfo_032_JA_08(), new CardInfo_033_JA_08(), new CardInfo_034_JA_08(), new CardInfo_035_JA_08(), new CardInfo_036_JA_08(), new CardInfo_037_JA_08(), new CardInfo_038_JA_08(), new CardInfo_039_JA_08(), new CardInfo_040_JA_08(), new CardInfo_041_JA_08(), new CardInfo_042_JA_08(), new CardInfo_043_JA_08(), new CardInfo_044_JA_08(), new CardInfo_045_JA_08(), new CardInfo_046_JA_08(), new CardInfo_047_JA_08(), new CardInfo_048_JA_08(), new CardInfo_049_JA_08(), new CardInfo_050_JA_08(), new CardInfo_051_JA_08(), new CardInfo_052_JA_08(), new CardInfo_053_JA_08(), new CardInfo_054_JA_08(), new CardInfo_055_JA_08(), new CardInfo_056_JA_08(), new CardInfo_057_JA_08(), new CardInfo_058_JA_08(), new CardInfo_059_JA_08(), new CardInfo_060_JA_08(), new CardInfo_061_JA_08(), new CardInfo_062_JA_08(), new CardInfo_063_JA_08(), new CardInfo_064_JA_08(), new CardInfo_065_JA_08(), new CardInfo_066_JA_08(), new CardInfo_067_JA_08(), new CardInfo_068_JA_08(), new CardInfo_069_JA_08(), new CardInfo_070_JA_08(), new CardInfo_071_JA_08(), new CardInfo_072_JA_08(), new CardInfo_073_JA_08(), new CardInfo_074_JA_08(), new CardInfo_075_JA_08(), new CardInfo_076_JA_08(), new CardInfo_077_JA_08(), new CardInfo_078_JA_08(), new CardInfo_079_JA_08(), new CardInfo_080_JA_08(), new CardInfo_081_JA_08(), new CardInfo_082_JA_08(), new CardInfo_083_JA_08(), new CardInfo_084_JA_08(), new CardInfo_085_JA_08(), new CardInfo_086_JA_08(), new CardInfo_087_JA_08(), new CardInfo_088_JA_08(), new CardInfo_089_JA_08(), new CardInfo_090_JA_08(), new CardInfo_091_JA_08(), new CardInfo_092_JA_08(), new CardInfo_093_JA_08(), new CardInfo_094_JA_08(), new CardInfo_095_JA_08(), new CardInfo_096_JA_08(), new CardInfo_097_JA_08(), new CardInfo_098_JA_08(), new CardInfo_099_JA_08(), new CardInfo_100_JA_08(), new CardInfo_101_JA_08(), new CardInfo_102_JA_08(), new CardInfo_103_JA_08(), new CardInfo_104_JA_08(), new CardInfo_105_JA_08(), new CardInfo_106_JA_08(), new CardInfo_107_JA_08(), new CardInfo_108_JA_08(), new CardInfo_109_JA_08(), new CardInfo_110_JA_08(), new CardInfo_111_JA_08(), new CardInfo_112_JA_08(), new CardInfo_113_JA_08(), new CardInfo_114_JA_08(), new CardInfo_115_JA_08(), new CardInfo_116_JA_08(), new CardInfo_117_JA_08(), new CardInfo_118_JA_08(), new CardInfo_119_JA_08(), new CardInfo_120_JA_08(), new CardInfo_121_JA_08(), new CardInfo_122_JA_08(), new CardInfo_123_JA_08(), new CardInfo_124_JA_08(), new CardInfo_125_JA_08(), new CardInfo_126_JA_08(), new CardInfo_127_JA_08(), new CardInfo_128_JA_08(), new CardInfo_129_JA_08(), new CardInfo_130_JA_08(), new CardInfo_131_JA_08(), new CardInfo_132_JA_08(), new CardInfo_133_JA_08(), new CardInfo_134_JA_08(), new CardInfo_135_JA_08(), new CardInfo_136_JA_08(), new CardInfo_137_JA_08(), new CardInfo_138_JA_08(), new CardInfo_139_JA_08(), new CardInfo_140_JA_08(), new CardInfo_141_JA_08(), new CardInfo_142_JA_08(), new CardInfo_143_JA_08(), new CardInfo_144_JA_08(), new CardInfo_145_JA_08(), new CardInfo_146_JA_08(), new CardInfo_147_JA_08(), new CardInfo_148_JA_08(), new CardInfo_149_JA_08(), new CardInfo_150_JA_08(), new CardInfo_151_JA_08(), new CardInfo_152_JA_08(), new CardInfo_153_JA_08(), new CardInfo_154_JA_08(), new CardInfo_155_JA_08(), new CardInfo_156_JA_08(), new CardInfo_157_JA_08(), new CardInfo_158_JA_08(), new CardInfo_159_JA_08(), new CardInfo_160_JA_08(), new CardInfo_161_JA_08(), new CardInfo_162_JA_08(), new CardInfo_163_JA_08(), new CardInfo_164_JA_08(), new CardInfo_165_JA_08(), new CardInfo_166_JA_08(), new CardInfo_167_JA_08(), new CardInfo_168_JA_08(), new CardInfo_169_JA_08(), new CardInfo_170_JA_08(), new CardInfo_171_JA_08(), new CardInfo_172_JA_08(), new CardInfo_173_JA_08(), new CardInfo_174_JA_08(), new CardInfo_175_JA_08(), new CardInfo_176_JA_08(), new CardInfo_177_JA_08(), new CardInfo_178_JA_08(), new CardInfo_179_JA_08(), new CardInfo_180_JA_08(), new CardInfo_181_JA_08(), new CardInfo_182_JA_08(), new CardInfo_183_JA_08(), new CardInfo_184_JA_08(), new CardInfo_185_JA_08(), new CardInfo_186_JA_08(), new CardInfo_187_JA_08(), new CardInfo_188_JA_08(), new CardInfo_189_JA_08(), new CardInfo_190_JA_08(), new CardInfo_191_JA_08(), new CardInfo_192_JA_08(), new CardInfo_193_JA_08(), new CardInfo_194_JA_08(), new CardInfo_195_JA_08(), new CardInfo_196_JA_08(), new CardInfo_197_JA_08(), new CardInfo_198_JA_08(), new CardInfo_199_JA_08(), new CardInfo_200_JA_08(), new CardInfo_201_JA_08(), new CardInfo_202_JA_08(), new CardInfo_203_JA_08(), new CardInfo_204_JA_08(), new CardInfo_205_JA_08(), new CardInfo_206_JA_08(), new CardInfo_207_JA_08(), new CardInfo_208_JA_08(), new CardInfo_209_JA_08(), new CardInfo_210_JA_08(), new CardInfo_211_JA_08(), new CardInfo_212_JA_08(), new CardInfo_213_JA_08(), new CardInfo_214_JA_08(), new CardInfo_215_JA_08(), new CardInfo_216_JA_08(), new CardInfo_217_JA_08(), new CardInfo_218_JA_08(), new CardInfo_219_JA_08(), new CardInfo_220_JA_08(), new CardInfo_221_JA_08(), new CardInfo_222_JA_08() };
        CardInfoList_FabledVol1 = new List<CardInfo>() { new CardInfo_001_JA_09(), new CardInfo_004_JA_09(), new CardInfo_006_JA_09(), new CardInfo_026_JA_09(), new CardInfo_045_JA_09(), new CardInfo_046_JA_09(), new CardInfo_047_JA_09(), new CardInfo_064_JA_09(), new CardInfo_076_JA_09(), new CardInfo_094_JA_09(), new CardInfo_100_JA_09(), new CardInfo_109_JA_09(), new CardInfo_110_JA_09(), new CardInfo_111_JA_09(), new CardInfo_117_JA_09(), new CardInfo_142_JA_09(), new CardInfo_178_JA_09(), new CardInfo_205_JA_09(), new CardInfo_206_JA_09(), new CardInfo_209_JA_09(), new CardInfo_210_JA_09(), new CardInfo_212_JA_09(), new CardInfo_213_JA_09(), new CardInfo_215_JA_09(), new CardInfo_218_JA_09(), new CardInfo_222_JA_09(), new CardInfo_224_JA_09(), new CardInfo_225_JA_09(), new CardInfo_228_JA_09(), new CardInfo_229_JA_09(), new CardInfo_231_JA_09(), new CardInfo_233_JA_09(), new CardInfo_235_JA_09(), new CardInfo_237_JA_09(), new CardInfo_240_JA_09(), new CardInfo_242_JA_09() };
        CardInfoList_FabledVol2 = new List<CardInfo>() { new CardInfo_005_JA_09(), new CardInfo_044_JA_09(), new CardInfo_074_JA_09(), new CardInfo_075_JA_09(), new CardInfo_077_JA_09(), new CardInfo_078_JA_09(), new CardInfo_112_JA_09(), new CardInfo_113_JA_09(), new CardInfo_114_JA_09(), new CardInfo_130_JA_09(), new CardInfo_141_JA_09(), new CardInfo_143_JA_09(), new CardInfo_173_JA_09(), new CardInfo_174_JA_09(), new CardInfo_175_JA_09(), new CardInfo_176_JA_09(), new CardInfo_207_JA_09(), new CardInfo_208_JA_09(), new CardInfo_211_JA_09(), new CardInfo_214_JA_09(), new CardInfo_216_JA_09(), new CardInfo_217_JA_09(), new CardInfo_219_JA_09(), new CardInfo_220_JA_09(), new CardInfo_221_JA_09(), new CardInfo_223_JA_09(), new CardInfo_226_JA_09(), new CardInfo_227_JA_09(), new CardInfo_230_JA_09(), new CardInfo_232_JA_09(), new CardInfo_234_JA_09(), new CardInfo_236_JA_09(), new CardInfo_238_JA_09(), new CardInfo_239_JA_09(), new CardInfo_241_JA_09() };
        CardInfoList_WinterSpellInTheWell = new List<CardInfo>() { new CardInfo_005_JA_10(), new CardInfo_007_JA_10(), new CardInfo_014_JA_10(), new CardInfo_015_JA_10(), new CardInfo_021_JA_10(), new CardInfo_024_JA_10(), new CardInfo_025_JA_10(), new CardInfo_026_JA_10(), new CardInfo_028_JA_10(), new CardInfo_029_JA_10(), new CardInfo_032_JA_10(), new CardInfo_034_JA_10(), new CardInfo_035_JA_10(), new CardInfo_036_JA_10(), new CardInfo_037_JA_10(), new CardInfo_038_JA_10(), new CardInfo_039_JA_10(), new CardInfo_043_JA_10(), new CardInfo_049_JA_10(), new CardInfo_050_JA_10(), new CardInfo_051_JA_10(), new CardInfo_061_JA_10(), new CardInfo_063_JA_10(), new CardInfo_070_JA_10(), new CardInfo_071_JA_10(), new CardInfo_074_JA_10(), new CardInfo_075_JA_10(), new CardInfo_077_JA_10(), new CardInfo_078_JA_10(), new CardInfo_079_JA_10(), new CardInfo_082_JA_10(), new CardInfo_083_JA_10(), new CardInfo_087_JA_10(), new CardInfo_089_JA_10(), new CardInfo_097_JA_10(), new CardInfo_098_JA_10(), new CardInfo_100_JA_10(), new CardInfo_102_JA_10(), new CardInfo_103_JA_10(), new CardInfo_110_JA_10(), new CardInfo_111_JA_10(), new CardInfo_114_JA_10(), new CardInfo_118_JA_10(), new CardInfo_119_JA_10(), new CardInfo_120_JA_10(), new CardInfo_122_JA_10(), new CardInfo_129_JA_10(), new CardInfo_133_JA_10(), new CardInfo_137_JA_10(), new CardInfo_138_JA_10(), new CardInfo_141_JA_10(), new CardInfo_146_JA_10(), new CardInfo_150_JA_10(), new CardInfo_154_JA_10(), new CardInfo_155_JA_10(), new CardInfo_156_JA_10(), new CardInfo_157_JA_10(), new CardInfo_160_JA_10(), new CardInfo_161_JA_10(), new CardInfo_162_JA_10(), new CardInfo_163_JA_10(), new CardInfo_165_JA_10(), new CardInfo_166_JA_10(), new CardInfo_169_JA_10(), new CardInfo_170_JA_10(), new CardInfo_172_JA_10(), new CardInfo_173_JA_10(), new CardInfo_174_JA_10(), new CardInfo_175_JA_10(), new CardInfo_176_JA_10(), new CardInfo_178_JA_10(), new CardInfo_179_JA_10(), new CardInfo_180_JA_10(), new CardInfo_181_JA_10(), new CardInfo_183_JA_10(), new CardInfo_185_JA_10(), new CardInfo_187_JA_10(), new CardInfo_188_JA_10(), new CardInfo_190_JA_10(), new CardInfo_194_JA_10(), new CardInfo_196_JA_10(), new CardInfo_199_JA_10(), new CardInfo_200_JA_10(), new CardInfo_202_JA_10(), new CardInfo_203_JA_10(), new CardInfo_205_JA_10(), new CardInfo_207_JA_10(), new CardInfo_208_JA_10(), new CardInfo_210_JA_10(), new CardInfo_212_JA_10(), new CardInfo_214_JA_10(), new CardInfo_217_JA_10(), new CardInfo_220_JA_10(), new CardInfo_223_JA_10(), new CardInfo_225_JA_10(), new CardInfo_226_JA_10(), new CardInfo_234_JA_10(), new CardInfo_235_JA_10(), new CardInfo_236_JA_10(), new CardInfo_238_JA_10(), new CardInfo_239_JA_10() };
        CardInfoList_WinterSpell = new List<CardInfo>() { new CardInfo_001_JA_11(), new CardInfo_004_JA_11(), new CardInfo_006_JA_11(), new CardInfo_008_JA_11(), new CardInfo_010_JA_11(), new CardInfo_011_JA_11(), new CardInfo_013_JA_11(), new CardInfo_015_JA_11(), new CardInfo_016_JA_11(), new CardInfo_022_JA_11(), new CardInfo_023_JA_11(), new CardInfo_026_JA_11(), new CardInfo_027_JA_11(), new CardInfo_028_JA_11(), new CardInfo_031_JA_11(), new CardInfo_033_JA_11(), new CardInfo_034_JA_11(), new CardInfo_038_JA_11(), new CardInfo_039_JA_11(), new CardInfo_040_JA_11(), new CardInfo_042_JA_11(), new CardInfo_043_JA_11(), new CardInfo_044_JA_11(), new CardInfo_046_JA_11(), new CardInfo_047_JA_11(), new CardInfo_048_JA_11(), new CardInfo_050_JA_11(), new CardInfo_051_JA_11(), new CardInfo_052_JA_11(), new CardInfo_059_JA_11(), new CardInfo_064_JA_11(), new CardInfo_065_JA_11(), new CardInfo_066_JA_11(), new CardInfo_068_JA_11(), new CardInfo_071_JA_11(), new CardInfo_072_JA_11(), new CardInfo_079_JA_11(), new CardInfo_080_JA_11(), new CardInfo_084_JA_11(), new CardInfo_085_JA_11(), new CardInfo_086_JA_11(), new CardInfo_087_JA_11(), new CardInfo_089_JA_11(), new CardInfo_090_JA_11(), new CardInfo_091_JA_11(), new CardInfo_092_JA_11(), new CardInfo_097_JA_11(), new CardInfo_100_JA_11(), new CardInfo_102_JA_11(), new CardInfo_106_JA_11(), new CardInfo_108_JA_11(), new CardInfo_111_JA_11(), new CardInfo_112_JA_11(), new CardInfo_113_JA_11(), new CardInfo_114_JA_11(), new CardInfo_115_JA_11(), new CardInfo_116_JA_11(), new CardInfo_119_JA_11(), new CardInfo_121_JA_11(), new CardInfo_124_JA_11(), new CardInfo_127_JA_11(), new CardInfo_133_JA_11(), new CardInfo_136_JA_11(), new CardInfo_139_JA_11(), new CardInfo_142_JA_11(), new CardInfo_143_JA_11(), new CardInfo_145_JA_11(), new CardInfo_147_JA_11(), new CardInfo_149_JA_11(), new CardInfo_150_JA_11(), new CardInfo_153_JA_11(), new CardInfo_155_JA_11(), new CardInfo_158_JA_11(), new CardInfo_161_JA_11(), new CardInfo_166_JA_11(), new CardInfo_168_JA_11(), new CardInfo_169_JA_11(), new CardInfo_170_JA_11(), new CardInfo_172_JA_11(), new CardInfo_174_JA_11(), new CardInfo_177_JA_11(), new CardInfo_179_JA_11(), new CardInfo_181_JA_11(), new CardInfo_182_JA_11(), new CardInfo_187_JA_11(), new CardInfo_188_JA_11(), new CardInfo_192_JA_11(), new CardInfo_193_JA_11(), new CardInfo_194_JA_11(), new CardInfo_196_JA_11(), new CardInfo_197_JA_11(), new CardInfo_199_JA_11(), new CardInfo_201_JA_11(), new CardInfo_202_JA_11(), new CardInfo_204_JA_11(), new CardInfo_206_JA_11(), new CardInfo_207_JA_11(), new CardInfo_209_JA_11(), new CardInfo_215_JA_11(), new CardInfo_216_JA_11(), new CardInfo_221_JA_11(), new CardInfo_223_JA_11(), new CardInfo_227_JA_11(), new CardInfo_228_JA_11(), new CardInfo_230_JA_11(), new CardInfo_233_JA_11(), new CardInfo_236_JA_11(), new CardInfo_239_JA_11(), new CardInfo_241_JA_11(), new CardInfo_242_JA_11() };
        CardInfoList_WildsUnknown = new List<CardInfo>() { new CardInfo_001_JA_12(), new CardInfo_002_JA_12(), new CardInfo_003_JA_12(), new CardInfo_004_JA_12(), new CardInfo_005_JA_12(), new CardInfo_006_JA_12(), new CardInfo_007_JA_12(), new CardInfo_008_JA_12(), new CardInfo_009_JA_12(), new CardInfo_010_JA_12(), new CardInfo_011_JA_12(), new CardInfo_012_JA_12(), new CardInfo_013_JA_12(), new CardInfo_014_JA_12(), new CardInfo_015_JA_12(), new CardInfo_016_JA_12(), new CardInfo_017_JA_12(), new CardInfo_018_JA_12(), new CardInfo_019_JA_12(), new CardInfo_020_JA_12(), new CardInfo_021_JA_12(), new CardInfo_022_JA_12(), new CardInfo_023_JA_12(), new CardInfo_024_JA_12(), new CardInfo_025_JA_12(), new CardInfo_026_JA_12(), new CardInfo_027_JA_12(), new CardInfo_028_JA_12(), new CardInfo_029_JA_12(), new CardInfo_030_JA_12(), new CardInfo_031_JA_12(), new CardInfo_032_JA_12(), new CardInfo_033_JA_12(), new CardInfo_034_JA_12(), new CardInfo_035_JA_12(), new CardInfo_036_JA_12(), new CardInfo_037_JA_12(), new CardInfo_038_JA_12(), new CardInfo_039_JA_12(), new CardInfo_040_JA_12(), new CardInfo_041_JA_12(), new CardInfo_042_JA_12(), new CardInfo_043_JA_12(), new CardInfo_044_JA_12(), new CardInfo_045_JA_12(), new CardInfo_046_JA_12(), new CardInfo_047_JA_12(), new CardInfo_048_JA_12(), new CardInfo_049_JA_12(), new CardInfo_050_JA_12(), new CardInfo_051_JA_12(), new CardInfo_052_JA_12(), new CardInfo_053_JA_12(), new CardInfo_054_JA_12(), new CardInfo_055_JA_12(), new CardInfo_056_JA_12(), new CardInfo_057_JA_12(), new CardInfo_058_JA_12(), new CardInfo_059_JA_12(), new CardInfo_060_JA_12(), new CardInfo_061_JA_12(), new CardInfo_062_JA_12(), new CardInfo_063_JA_12(), new CardInfo_064_JA_12(), new CardInfo_065_JA_12(), new CardInfo_066_JA_12(), new CardInfo_067_JA_12(), new CardInfo_068_JA_12(), new CardInfo_069_JA_12(), new CardInfo_070_JA_12(), new CardInfo_071_JA_12(), new CardInfo_072_JA_12(), new CardInfo_073_JA_12(), new CardInfo_074_JA_12(), new CardInfo_075_JA_12(), new CardInfo_076_JA_12(), new CardInfo_077_JA_12(), new CardInfo_078_JA_12(), new CardInfo_079_JA_12(), new CardInfo_080_JA_12(), new CardInfo_081_JA_12(), new CardInfo_082_JA_12(), new CardInfo_083_JA_12(), new CardInfo_084_JA_12(), new CardInfo_085_JA_12(), new CardInfo_086_JA_12(), new CardInfo_087_JA_12(), new CardInfo_088_JA_12(), new CardInfo_089_JA_12(), new CardInfo_090_JA_12(), new CardInfo_091_JA_12(), new CardInfo_092_JA_12(), new CardInfo_093_JA_12(), new CardInfo_094_JA_12(), new CardInfo_095_JA_12(), new CardInfo_096_JA_12(), new CardInfo_097_JA_12(), new CardInfo_098_JA_12(), new CardInfo_099_JA_12(), new CardInfo_100_JA_12(), new CardInfo_101_JA_12(), new CardInfo_102_JA_12(), new CardInfo_103_JA_12(), new CardInfo_104_JA_12(), new CardInfo_105_JA_12(), new CardInfo_106_JA_12(), new CardInfo_107_JA_12(), new CardInfo_108_JA_12(), new CardInfo_109_JA_12(), new CardInfo_110_JA_12(), new CardInfo_111_JA_12(), new CardInfo_112_JA_12(), new CardInfo_113_JA_12(), new CardInfo_114_JA_12(), new CardInfo_115_JA_12(), new CardInfo_116_JA_12(), new CardInfo_117_JA_12(), new CardInfo_118_JA_12(), new CardInfo_119_JA_12(), new CardInfo_120_JA_12(), new CardInfo_121_JA_12(), new CardInfo_122_JA_12(), new CardInfo_123_JA_12(), new CardInfo_124_JA_12(), new CardInfo_125_JA_12(), new CardInfo_126_JA_12(), new CardInfo_127_JA_12(), new CardInfo_128_JA_12(), new CardInfo_129_JA_12(), new CardInfo_130_JA_12(), new CardInfo_131_JA_12(), new CardInfo_132_JA_12(), new CardInfo_133_JA_12(), new CardInfo_134_JA_12(), new CardInfo_135_JA_12(), new CardInfo_136_JA_12(), new CardInfo_137_JA_12(), new CardInfo_138_JA_12(), new CardInfo_139_JA_12(), new CardInfo_140_JA_12(), new CardInfo_141_JA_12(), new CardInfo_142_JA_12(), new CardInfo_143_JA_12(), new CardInfo_144_JA_12(), new CardInfo_145_JA_12(), new CardInfo_146_JA_12(), new CardInfo_147_JA_12(), new CardInfo_148_JA_12(), new CardInfo_149_JA_12(), new CardInfo_150_JA_12(), new CardInfo_151_JA_12(), new CardInfo_152_JA_12(), new CardInfo_153_JA_12(), new CardInfo_154_JA_12(), new CardInfo_155_JA_12(), new CardInfo_156_JA_12(), new CardInfo_157_JA_12(), new CardInfo_158_JA_12(), new CardInfo_159_JA_12(), new CardInfo_160_JA_12(), new CardInfo_161_JA_12(), new CardInfo_162_JA_12(), new CardInfo_163_JA_12(), new CardInfo_164_JA_12(), new CardInfo_165_JA_12(), new CardInfo_166_JA_12(), new CardInfo_167_JA_12(), new CardInfo_168_JA_12(), new CardInfo_169_JA_12(), new CardInfo_170_JA_12(), new CardInfo_171_JA_12(), new CardInfo_172_JA_12(), new CardInfo_173_JA_12(), new CardInfo_174_JA_12(), new CardInfo_175_JA_12(), new CardInfo_176_JA_12(), new CardInfo_177_JA_12(), new CardInfo_178_JA_12(), new CardInfo_179_JA_12(), new CardInfo_180_JA_12(), new CardInfo_181_JA_12(), new CardInfo_182_JA_12(), new CardInfo_183_JA_12(), new CardInfo_184_JA_12(), new CardInfo_185_JA_12(), new CardInfo_186_JA_12(), new CardInfo_187_JA_12(), new CardInfo_188_JA_12(), new CardInfo_189_JA_12(), new CardInfo_190_JA_12(), new CardInfo_191_JA_12(), new CardInfo_192_JA_12(), new CardInfo_193_JA_12(), new CardInfo_194_JA_12(), new CardInfo_195_JA_12(), new CardInfo_196_JA_12(), new CardInfo_197_JA_12(), new CardInfo_198_JA_12(), new CardInfo_199_JA_12(), new CardInfo_200_JA_12(), new CardInfo_201_JA_12(), new CardInfo_202_JA_12(), new CardInfo_203_JA_12(), new CardInfo_204_JA_12(), new CardInfo_205_JA_12(), new CardInfo_206_JA_12(), new CardInfo_207_JA_12(), new CardInfo_208_JA_12(), new CardInfo_209_JA_12(), new CardInfo_210_JA_12(), new CardInfo_211_JA_12(), new CardInfo_212_JA_12(), new CardInfo_213_JA_12(), new CardInfo_214_JA_12(), new CardInfo_215_JA_12(), new CardInfo_216_JA_12(), new CardInfo_217_JA_12(), new CardInfo_218_JA_12(), new CardInfo_219_JA_12(), new CardInfo_220_JA_12(), new CardInfo_221_JA_12(), new CardInfo_222_JA_12(), new CardInfo_223_JA_12(), new CardInfo_224_JA_12(), new CardInfo_225_JA_12(), new CardInfo_226_JA_12(), new CardInfo_227_JA_12(), new CardInfo_228_JA_12(), new CardInfo_229_JA_12(), new CardInfo_230_JA_12(), new CardInfo_231_JA_12(), new CardInfo_232_JA_12(), new CardInfo_233_JA_12(), new CardInfo_234_JA_12(), new CardInfo_235_JA_12(), new CardInfo_236_JA_12(), new CardInfo_237_JA_12(), new CardInfo_238_JA_12(), new CardInfo_239_JA_12(), new CardInfo_240_JA_12(), new CardInfo_241_JA_12(), new CardInfo_242_JA_12() };
        CardInfoList_AttackOfTheVine = new List<CardInfo>() { new CardInfo_001_JA_13(), new CardInfo_002_JA_13(), new CardInfo_003_JA_13(), new CardInfo_004_JA_13(), new CardInfo_005_JA_13(), new CardInfo_006_JA_13(), new CardInfo_007_JA_13(), new CardInfo_008_JA_13(), new CardInfo_009_JA_13(), new CardInfo_010_JA_13(), new CardInfo_011_JA_13(), new CardInfo_012_JA_13(), new CardInfo_013_JA_13(), new CardInfo_014_JA_13(), new CardInfo_015_JA_13(), new CardInfo_016_JA_13(), new CardInfo_017_JA_13(), new CardInfo_018_JA_13(), new CardInfo_019_JA_13(), new CardInfo_020_JA_13(), new CardInfo_021_JA_13(), new CardInfo_022_JA_13(), new CardInfo_023_JA_13(), new CardInfo_024_JA_13(), new CardInfo_025_JA_13(), new CardInfo_026_JA_13(), new CardInfo_027_JA_13(), new CardInfo_028_JA_13(), new CardInfo_029_JA_13(), new CardInfo_030_JA_13(), new CardInfo_031_JA_13(), new CardInfo_032_JA_13(), new CardInfo_033_JA_13(), new CardInfo_034_JA_13(), new CardInfo_035_JA_13(), new CardInfo_036_JA_13(), new CardInfo_037_JA_13(), new CardInfo_038_JA_13(), new CardInfo_039_JA_13(), new CardInfo_040_JA_13(), new CardInfo_041_JA_13(), new CardInfo_042_JA_13(), new CardInfo_043_JA_13(), new CardInfo_044_JA_13(), new CardInfo_045_JA_13(), new CardInfo_046_JA_13(), new CardInfo_047_JA_13(), new CardInfo_048_JA_13(), new CardInfo_049_JA_13(), new CardInfo_050_JA_13(), new CardInfo_051_JA_13(), new CardInfo_052_JA_13(), new CardInfo_053_JA_13(), new CardInfo_054_JA_13(), new CardInfo_055_JA_13(), new CardInfo_056_JA_13(), new CardInfo_057_JA_13(), new CardInfo_058_JA_13(), new CardInfo_059_JA_13(), new CardInfo_060_JA_13(), new CardInfo_061_JA_13(), new CardInfo_062_JA_13(), new CardInfo_063_JA_13(), new CardInfo_064_JA_13(), new CardInfo_065_JA_13(), new CardInfo_066_JA_13(), new CardInfo_067_JA_13(), new CardInfo_068_JA_13(), new CardInfo_069_JA_13(), new CardInfo_070_JA_13(), new CardInfo_071_JA_13(), new CardInfo_072_JA_13(), new CardInfo_073_JA_13(), new CardInfo_074_JA_13(), new CardInfo_075_JA_13(), new CardInfo_076_JA_13(), new CardInfo_077_JA_13(), new CardInfo_078_JA_13(), new CardInfo_079_JA_13(), new CardInfo_080_JA_13(), new CardInfo_081_JA_13(), new CardInfo_082_JA_13(), new CardInfo_083_JA_13(), new CardInfo_084_JA_13(), new CardInfo_085_JA_13(), new CardInfo_086_JA_13(), new CardInfo_087_JA_13(), new CardInfo_088_JA_13(), new CardInfo_089_JA_13(), new CardInfo_090_JA_13(), new CardInfo_091_JA_13(), new CardInfo_092_JA_13(), new CardInfo_093_JA_13(), new CardInfo_094_JA_13(), new CardInfo_095_JA_13(), new CardInfo_096_JA_13(), new CardInfo_097_JA_13(), new CardInfo_098_JA_13(), new CardInfo_099_JA_13(), new CardInfo_100_JA_13(), new CardInfo_101_JA_13(), new CardInfo_102_JA_13(), new CardInfo_103_JA_13(), new CardInfo_104_JA_13(), new CardInfo_105_JA_13(), new CardInfo_106_JA_13(), new CardInfo_107_JA_13(), new CardInfo_108_JA_13(), new CardInfo_109_JA_13(), new CardInfo_110_JA_13(), new CardInfo_111_JA_13(), new CardInfo_112_JA_13(), new CardInfo_113_JA_13(), new CardInfo_114_JA_13(), new CardInfo_115_JA_13(), new CardInfo_116_JA_13(), new CardInfo_117_JA_13(), new CardInfo_118_JA_13(), new CardInfo_119_JA_13(), new CardInfo_120_JA_13(), new CardInfo_121_JA_13(), new CardInfo_122_JA_13(), new CardInfo_123_JA_13(), new CardInfo_124_JA_13(), new CardInfo_125_JA_13(), new CardInfo_126_JA_13(), new CardInfo_127_JA_13(), new CardInfo_128_JA_13(), new CardInfo_129_JA_13(), new CardInfo_130_JA_13(), new CardInfo_131_JA_13(), new CardInfo_132_JA_13(), new CardInfo_133_JA_13(), new CardInfo_134_JA_13(), new CardInfo_135_JA_13(), new CardInfo_136_JA_13(), new CardInfo_137_JA_13(), new CardInfo_138_JA_13(), new CardInfo_139_JA_13(), new CardInfo_140_JA_13(), new CardInfo_141_JA_13(), new CardInfo_142_JA_13(), new CardInfo_143_JA_13(), new CardInfo_144_JA_13(), new CardInfo_145_JA_13(), new CardInfo_146_JA_13(), new CardInfo_147_JA_13(), new CardInfo_148_JA_13(), new CardInfo_149_JA_13(), new CardInfo_150_JA_13(), new CardInfo_151_JA_13(), new CardInfo_152_JA_13(), new CardInfo_153_JA_13(), new CardInfo_154_JA_13(), new CardInfo_155_JA_13(), new CardInfo_156_JA_13(), new CardInfo_157_JA_13(), new CardInfo_158_JA_13(), new CardInfo_159_JA_13(), new CardInfo_160_JA_13(), new CardInfo_161_JA_13(), new CardInfo_162_JA_13(), new CardInfo_163_JA_13(), new CardInfo_164_JA_13(), new CardInfo_165_JA_13(), new CardInfo_166_JA_13(), new CardInfo_167_JA_13(), new CardInfo_168_JA_13(), new CardInfo_169_JA_13(), new CardInfo_170_JA_13(), new CardInfo_171_JA_13(), new CardInfo_172_JA_13(), new CardInfo_173_JA_13(), new CardInfo_174_JA_13(), new CardInfo_175_JA_13(), new CardInfo_176_JA_13(), new CardInfo_177_JA_13(), new CardInfo_178_JA_13(), new CardInfo_179_JA_13(), new CardInfo_180_JA_13(), new CardInfo_181_JA_13(), new CardInfo_182_JA_13(), new CardInfo_183_JA_13(), new CardInfo_184_JA_13(), new CardInfo_185_JA_13(), new CardInfo_186_JA_13(), new CardInfo_187_JA_13(), new CardInfo_188_JA_13(), new CardInfo_189_JA_13(), new CardInfo_190_JA_13(), new CardInfo_191_JA_13(), new CardInfo_192_JA_13(), new CardInfo_193_JA_13(), new CardInfo_194_JA_13(), new CardInfo_195_JA_13(), new CardInfo_196_JA_13(), new CardInfo_197_JA_13(), new CardInfo_198_JA_13(), new CardInfo_199_JA_13(), new CardInfo_200_JA_13(), new CardInfo_201_JA_13(), new CardInfo_202_JA_13(), new CardInfo_203_JA_13(), new CardInfo_204_JA_13(), new CardInfo_205_JA_13(), new CardInfo_206_JA_13(), new CardInfo_207_JA_13(), new CardInfo_208_JA_13(), new CardInfo_209_JA_13(), new CardInfo_210_JA_13(), new CardInfo_211_JA_13(), new CardInfo_212_JA_13(), new CardInfo_213_JA_13(), new CardInfo_214_JA_13(), new CardInfo_215_JA_13(), new CardInfo_216_JA_13(), new CardInfo_217_JA_13(), new CardInfo_218_JA_13(), new CardInfo_219_JA_13(), new CardInfo_220_JA_13(), new CardInfo_221_JA_13(), new CardInfo_222_JA_13(), new CardInfo_223_JA_13(), new CardInfo_224_JA_13(), new CardInfo_225_JA_13(), new CardInfo_226_JA_13(), new CardInfo_227_JA_13(), new CardInfo_228_JA_13(), new CardInfo_229_JA_13(), new CardInfo_230_JA_13(), new CardInfo_231_JA_13(), new CardInfo_232_JA_13(), new CardInfo_233_JA_13(), new CardInfo_234_JA_13(), new CardInfo_235_JA_13(), new CardInfo_236_JA_13(), new CardInfo_237_JA_13(), new CardInfo_238_JA_13(), new CardInfo_239_JA_13(), new CardInfo_240_JA_13(), new CardInfo_241_JA_13(), new CardInfo_242_JA_13(), new CardInfo_243_JA_13(), new CardInfo_244_JA_13(), new CardInfo_245_JA_13() };
        CardInfoList_HyperiaCity = new List<CardInfo>() { new CardInfo_001_JA_14(), new CardInfo_002_JA_14(), new CardInfo_003_JA_14(), new CardInfo_004_JA_14(), new CardInfo_005_JA_14(), new CardInfo_006_JA_14(), new CardInfo_007_JA_14(), new CardInfo_008_JA_14(), new CardInfo_009_JA_14(), new CardInfo_010_JA_14(), new CardInfo_011_JA_14(), new CardInfo_012_JA_14(), new CardInfo_013_JA_14(), new CardInfo_014_JA_14(), new CardInfo_015_JA_14(), new CardInfo_016_JA_14(), new CardInfo_017_JA_14(), new CardInfo_018_JA_14(), new CardInfo_019_JA_14(), new CardInfo_020_JA_14(), new CardInfo_021_JA_14(), new CardInfo_022_JA_14(), new CardInfo_023_JA_14(), new CardInfo_024_JA_14(), new CardInfo_025_JA_14(), new CardInfo_026_JA_14(), new CardInfo_027_JA_14(), new CardInfo_028_JA_14(), new CardInfo_029_JA_14(), new CardInfo_030_JA_14(), new CardInfo_031_JA_14(), new CardInfo_032_JA_14(), new CardInfo_033_JA_14(), new CardInfo_034_JA_14(), new CardInfo_035_JA_14(), new CardInfo_036_JA_14(), new CardInfo_037_JA_14(), new CardInfo_038_JA_14(), new CardInfo_039_JA_14(), new CardInfo_040_JA_14(), new CardInfo_041_JA_14(), new CardInfo_042_JA_14(), new CardInfo_043_JA_14(), new CardInfo_044_JA_14(), new CardInfo_045_JA_14(), new CardInfo_046_JA_14(), new CardInfo_047_JA_14(), new CardInfo_048_JA_14(), new CardInfo_049_JA_14(), new CardInfo_050_JA_14(), new CardInfo_051_JA_14(), new CardInfo_052_JA_14(), new CardInfo_053_JA_14(), new CardInfo_054_JA_14(), new CardInfo_055_JA_14(), new CardInfo_056_JA_14(), new CardInfo_057_JA_14(), new CardInfo_058_JA_14(), new CardInfo_059_JA_14(), new CardInfo_060_JA_14(), new CardInfo_061_JA_14(), new CardInfo_062_JA_14(), new CardInfo_063_JA_14(), new CardInfo_064_JA_14(), new CardInfo_065_JA_14(), new CardInfo_066_JA_14(), new CardInfo_067_JA_14(), new CardInfo_068_JA_14(), new CardInfo_069_JA_14(), new CardInfo_070_JA_14(), new CardInfo_071_JA_14(), new CardInfo_072_JA_14(), new CardInfo_073_JA_14(), new CardInfo_074_JA_14(), new CardInfo_075_JA_14(), new CardInfo_076_JA_14(), new CardInfo_077_JA_14(), new CardInfo_078_JA_14(), new CardInfo_079_JA_14(), new CardInfo_080_JA_14(), new CardInfo_081_JA_14(), new CardInfo_082_JA_14(), new CardInfo_083_JA_14(), new CardInfo_084_JA_14(), new CardInfo_085_JA_14(), new CardInfo_086_JA_14(), new CardInfo_087_JA_14(), new CardInfo_088_JA_14(), new CardInfo_089_JA_14(), new CardInfo_090_JA_14(), new CardInfo_091_JA_14(), new CardInfo_092_JA_14(), new CardInfo_093_JA_14(), new CardInfo_094_JA_14(), new CardInfo_095_JA_14(), new CardInfo_096_JA_14(), new CardInfo_097_JA_14(), new CardInfo_098_JA_14(), new CardInfo_099_JA_14(), new CardInfo_100_JA_14(), new CardInfo_101_JA_14(), new CardInfo_102_JA_14(), new CardInfo_103_JA_14(), new CardInfo_104_JA_14(), new CardInfo_105_JA_14(), new CardInfo_106_JA_14(), new CardInfo_107_JA_14(), new CardInfo_108_JA_14(), new CardInfo_109_JA_14(), new CardInfo_110_JA_14(), new CardInfo_111_JA_14(), new CardInfo_112_JA_14(), new CardInfo_113_JA_14(), new CardInfo_114_JA_14(), new CardInfo_115_JA_14(), new CardInfo_116_JA_14(), new CardInfo_117_JA_14(), new CardInfo_118_JA_14(), new CardInfo_119_JA_14(), new CardInfo_120_JA_14(), new CardInfo_121_JA_14(), new CardInfo_122_JA_14(), new CardInfo_123_JA_14(), new CardInfo_124_JA_14(), new CardInfo_125_JA_14(), new CardInfo_126_JA_14(), new CardInfo_127_JA_14(), new CardInfo_128_JA_14(), new CardInfo_129_JA_14(), new CardInfo_130_JA_14(), new CardInfo_131_JA_14(), new CardInfo_132_JA_14(), new CardInfo_133_JA_14(), new CardInfo_134_JA_14(), new CardInfo_135_JA_14(), new CardInfo_136_JA_14(), new CardInfo_137_JA_14(), new CardInfo_138_JA_14(), new CardInfo_139_JA_14(), new CardInfo_140_JA_14(), new CardInfo_141_JA_14(), new CardInfo_142_JA_14(), new CardInfo_143_JA_14(), new CardInfo_144_JA_14(), new CardInfo_145_JA_14(), new CardInfo_146_JA_14(), new CardInfo_147_JA_14(), new CardInfo_148_JA_14(), new CardInfo_149_JA_14(), new CardInfo_150_JA_14(), new CardInfo_151_JA_14(), new CardInfo_152_JA_14(), new CardInfo_153_JA_14(), new CardInfo_154_JA_14(), new CardInfo_155_JA_14(), new CardInfo_156_JA_14(), new CardInfo_157_JA_14(), new CardInfo_158_JA_14(), new CardInfo_159_JA_14(), new CardInfo_160_JA_14(), new CardInfo_161_JA_14(), new CardInfo_162_JA_14(), new CardInfo_163_JA_14(), new CardInfo_164_JA_14(), new CardInfo_165_JA_14(), new CardInfo_166_JA_14(), new CardInfo_167_JA_14(), new CardInfo_168_JA_14(), new CardInfo_169_JA_14(), new CardInfo_170_JA_14(), new CardInfo_171_JA_14(), new CardInfo_172_JA_14(), new CardInfo_173_JA_14(), new CardInfo_174_JA_14(), new CardInfo_175_JA_14(), new CardInfo_176_JA_14(), new CardInfo_177_JA_14(), new CardInfo_178_JA_14(), new CardInfo_179_JA_14(), new CardInfo_180_JA_14(), new CardInfo_181_JA_14(), new CardInfo_182_JA_14(), new CardInfo_183_JA_14(), new CardInfo_184_JA_14(), new CardInfo_185_JA_14(), new CardInfo_186_JA_14(), new CardInfo_187_JA_14(), new CardInfo_188_JA_14(), new CardInfo_189_JA_14(), new CardInfo_190_JA_14(), new CardInfo_191_JA_14(), new CardInfo_192_JA_14(), new CardInfo_193_JA_14(), new CardInfo_194_JA_14(), new CardInfo_195_JA_14(), new CardInfo_196_JA_14(), new CardInfo_197_JA_14(), new CardInfo_198_JA_14(), new CardInfo_199_JA_14(), new CardInfo_200_JA_14(), new CardInfo_201_JA_14(), new CardInfo_202_JA_14(), new CardInfo_203_JA_14(), new CardInfo_204_JA_14(), new CardInfo_205_JA_14(), new CardInfo_206_JA_14(), new CardInfo_207_JA_14(), new CardInfo_208_JA_14(), new CardInfo_209_JA_14(), new CardInfo_210_JA_14(), new CardInfo_211_JA_14(), new CardInfo_212_JA_14(), new CardInfo_213_JA_14(), new CardInfo_214_JA_14(), new CardInfo_215_JA_14(), new CardInfo_216_JA_14(), new CardInfo_217_JA_14(), new CardInfo_218_JA_14(), new CardInfo_219_JA_14(), new CardInfo_220_JA_14(), new CardInfo_221_JA_14(), new CardInfo_222_JA_14(), new CardInfo_223_JA_14(), new CardInfo_224_JA_14(), new CardInfo_225_JA_14(), new CardInfo_226_JA_14(), new CardInfo_227_JA_14(), new CardInfo_228_JA_14(), new CardInfo_229_JA_14(), new CardInfo_230_JA_14(), new CardInfo_231_JA_14(), new CardInfo_232_JA_14(), new CardInfo_233_JA_14(), new CardInfo_234_JA_14(), new CardInfo_235_JA_14(), new CardInfo_236_JA_14(), new CardInfo_237_JA_14(), new CardInfo_238_JA_14(), new CardInfo_239_JA_14(), new CardInfo_240_JA_14(), new CardInfo_241_JA_14(), new CardInfo_242_JA_14() };

        for (int i = 0; i < CardInfoList_TheFirstChapter.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(CardInfoList_TheFirstChapter[i], 0));
        }
        for (int i = 0; i < CardInfoList_RiseOfTheFloodBorn.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(CardInfoList_RiseOfTheFloodBorn[i], 0));
        }
        for (int i = 0; i < CardInfoList_IntoTheInkLands.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(CardInfoList_IntoTheInkLands[i], 0));
        }
        for (int i = 0; i < CardInfoList_UrsulasReturn.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(CardInfoList_UrsulasReturn[i], 0));
        }
        for (int i = 0; i < CardInfoList_ShimmeringSkies.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(CardInfoList_ShimmeringSkies[i], 0));
        }
        for (int i = 0; i < CardInfoList_AzuriteSea.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(CardInfoList_AzuriteSea[i], 0));
        }
        for (int i = 0; i < CardInfoList_ArchaziasIsland.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(CardInfoList_ArchaziasIsland[i], 0));
        }
        for (int i = 0; i < CardInfoList_ReignOfJafar.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(CardInfoList_ReignOfJafar[i], 0));
        }
        for (int i = 0; i < CardInfoList_FabledVol1.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(CardInfoList_FabledVol1[i], 0));
        }
        for (int i = 0; i < CardInfoList_FabledVol2.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(CardInfoList_FabledVol2[i], 0));
        }
        for (int i = 0; i < CardInfoList_WinterSpellInTheWell.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(CardInfoList_WinterSpellInTheWell[i], 0));
        }
        for (int i = 0; i < CardInfoList_WinterSpell.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(CardInfoList_WinterSpell[i], 0));
        }
        for (int i = 0; i < CardInfoList_WildsUnknown.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(CardInfoList_WildsUnknown[i], 0));
        }
        for (int i = 0; i < CardInfoList_AttackOfTheVine.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(CardInfoList_AttackOfTheVine[i], 0));
        }
        for (int i = 0; i < CardInfoList_HyperiaCity.Count; i++)
        {
            EditCardPanelTempList.Add(new EditCardPanelTemp(CardInfoList_HyperiaCity[i], 0));
        }

        for (int i = 0;i < EditCardPanelTempList.Count; i++)
        {
            EditCardPanelTempList[i].SetIndex(i);
        }
        SortEditCardPanelTempList = EditCardPanelTempList;
    }

    public List<EditCardPanelTemp> GetMytEditCardPanelTempList()
    {
        List<EditCardPanelTemp> list = new List<EditCardPanelTemp>();
        switch (m_SortStatus)
        {
            case SortStatus.InkSort:
                for (int i = 0; i < 11; i++)
                {
                    for (int k = 0; k < EditCardPanelTempList.Count; k++)
                    {
                        if (EditCardPanelTempList[k].GetCardCount() <= 0)
                        {
                            continue;
                        }

                        if (EditCardPanelTempList[k].GetCardInfo().GetInkCost() == i)
                        {
                            list.Add(EditCardPanelTempList[k]);
                        }
                    }
                }
                return list;
            case SortStatus.ColorSort:
                List<EditCardPanelTemp> AmberEditCardPanelTempList = new List<EditCardPanelTemp>();
                List<EditCardPanelTemp> AmethystEditCardPanelTempList = new List<EditCardPanelTemp>();
                List<EditCardPanelTemp> EmeraldEditCardPanelTempList = new List<EditCardPanelTemp>();
                List<EditCardPanelTemp> RubyEditCardPanelTempList = new List<EditCardPanelTemp>();
                List<EditCardPanelTemp> SapphireEditCardPanelTempList = new List<EditCardPanelTemp>();
                List<EditCardPanelTemp> SteelEditCardPanelTempList = new List<EditCardPanelTemp>();

                for (int i = 0; i < EditCardPanelTempList.Count; i++)
                {
                    if (EditCardPanelTempList[i].GetCardCount() <= 0)
                    {
                        continue;
                    }
                    List<EnumController.Colors> color = EditCardPanelTempList[i].GetCardInfo().GetColor();
                    switch (color[0])
                    {
                        case EnumController.Colors.Amber:
                            AmberEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                            break;
                        case EnumController.Colors.Amethyst:
                            AmethystEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                            break;
                        case EnumController.Colors.Emerald:
                            EmeraldEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                            break;
                        case EnumController.Colors.Ruby:
                            RubyEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                            break;
                        case EnumController.Colors.Sapphire:
                            SapphireEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                            break;
                        case EnumController.Colors.Steel:
                            SteelEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                            break;
                        default:
                            break;
                    }
                }

                for (int i = 0; i < AmberEditCardPanelTempList.Count; i++)
                {
                    list.Add(AmberEditCardPanelTempList[i]);
                }
                for (int i = 0; i < AmethystEditCardPanelTempList.Count; i++)
                {
                    list.Add(AmethystEditCardPanelTempList[i]);
                }
                for (int i = 0; i < EmeraldEditCardPanelTempList.Count; i++)
                {
                    list.Add(EmeraldEditCardPanelTempList[i]);
                }
                for (int i = 0; i < RubyEditCardPanelTempList.Count; i++)
                {
                    list.Add(RubyEditCardPanelTempList[i]);
                }
                for (int i = 0; i < SapphireEditCardPanelTempList.Count; i++)
                {
                    list.Add(SapphireEditCardPanelTempList[i]);
                }
                for (int i = 0; i < SteelEditCardPanelTempList.Count; i++)
                {
                    list.Add(SteelEditCardPanelTempList[i]);
                }
                return list;
        }
        for (int i = 0; i < EditCardPanelTempList.Count; i++)
        {
            if (EditCardPanelTempList[i].GetCardCount() <= 0)
            {
                continue;
            }
            list.Add(EditCardPanelTempList[i]);
        }
        return list;
    }

    public List<CardInfo> GetDeckList()
    {
        List<CardInfo> list = new List<CardInfo>();
        for (int i = 0; i < EditCardPanelTempList.Count; i++)
        {
            int cnt = EditCardPanelTempList[i].GetCardCount();
            if (cnt > 0)
            {
                for(int k = 0; k < cnt; k++)
                {
                    list.Add(EditCardPanelTempList[i].GetCardInfo());
                }
            }
        }
        return list;
    }

    public int GetEditCardPanelTempCount()
    {
        return SortEditCardPanelTempList.Count;
    }

    public EditCardPanelTemp GetEditCardPanelTemp(int itemCount)
    {
        if(itemCount > SortEditCardPanelTempList.Count - 1)
        {
            return new EditCardPanelTemp(null, 0);
        }
        return SortEditCardPanelTempList[itemCount];
    }

    public void LoadDeckList()
    {
        DeckName = m_SaveDataStatic.GetDeckTitle();
        List<CardInfo> TempDeckList = m_SaveDataStatic.GetCardInfoList();
        for (int i = 0; i < TempDeckList.Count; i++)
        {
            for (int k = 0; k < EditCardPanelTempList.Count; k++)
            {
                if (EditCardPanelTempList[k] == null)
                {
                    continue;
                }

                if (TempDeckList[i].GetCardNo() == EditCardPanelTempList[k].GetCardInfo().GetCardNo())
                {
                    EditCardPanelTempList[k].SetCardCount(EditCardPanelTempList[k].GetCardCount() + 1);
                    continue;
                }
            }
        }
        onDefaultSort();
    }

    public void onUpdateDeckList(int index, int cardCount)
    {
        EditCardPanelTempList[index].SetCardCount(cardCount);
    }

    public void onSearchBtn()
    {
        m_SearchClass.Open();
    }

    public void onSwitchBtn()
    {
        if (SwitchOwn)
        {
            SwitchOwn = false;
        }
        else
        {
            SwitchOwn = true;
        }

        if (SwitchOwn)
        {
            DeckAllSwitchBtnImage.sprite = DeckAllSwitchBtn2;
        }
        else
        {
            DeckAllSwitchBtnImage.sprite = DeckAllSwitchBtn1;
        }

        switch (m_SortStatus)
        {
            case SortStatus.Default:
                SortImage.sprite = DefaultSortIcon;
                onDefaultSort();
                break;
            case SortStatus.InkSort:
                SortImage.sprite = InkSortIcon;
                onInkCostSort();
                break;
            case SortStatus.ColorSort:
                SortImage.sprite = ColorSortIcon;
                onColorSort();
                break;
        }
    }

    public void onMenuBtn()
    {
        MenuObj.SetActive(true);
    }

    public void onSortBtn()
    {
        switch (m_SortStatus)
        {
            case SortStatus.Default:
                m_SortStatus = SortStatus.InkSort;
                break;
            case SortStatus.InkSort:
                m_SortStatus = SortStatus.ColorSort;
                break;
            case SortStatus.ColorSort:
                m_SortStatus = SortStatus.Default;
                break;
        }

        switch (m_SortStatus)
        {
            case SortStatus.Default:
                SortImage.sprite = DefaultSortIcon;
                onDefaultSort();
                break;
            case SortStatus.InkSort:
                SortImage.sprite = InkSortIcon;
                onInkCostSort();
                break;
            case SortStatus.ColorSort:
                SortImage.sprite = ColorSortIcon;
                onColorSort();
                break;
        }
    }

    private void onDefaultSort()
    {
        SortEditCardPanelTempList = new List<EditCardPanelTemp>();
        for(int i = 0; i < EditCardPanelTempList.Count; i++)
        {
            if ((SwitchOwn && EditCardPanelTempList[i].GetCardCount() <= 0) || !m_SearchFilterClass.isSearchHit(EditCardPanelTempList[i].GetCardInfo()))
            {
                continue;
            }
            SortEditCardPanelTempList.Add(EditCardPanelTempList[i]);
        }
        m_InfiniteScroll.onResetValue();
    }

    private void onInkCostSort()
    {
        SortEditCardPanelTempList = new List<EditCardPanelTemp>();
        for(int i = 0; i < 11; i++)
        {
            for(int k = 0; k < EditCardPanelTempList.Count; k++)
            {
                if ((SwitchOwn && EditCardPanelTempList[k].GetCardCount() <= 0) || !m_SearchFilterClass.isSearchHit(EditCardPanelTempList[k].GetCardInfo()))
                {
                    continue;
                }

                if (EditCardPanelTempList[k].GetCardInfo().GetInkCost() == i)
                {
                    SortEditCardPanelTempList.Add(EditCardPanelTempList[k]);
                }
            }
        }
        m_InfiniteScroll.onResetValue();
    }

    private void onColorSort()
    {
        SortEditCardPanelTempList = new List<EditCardPanelTemp>();
        List<EditCardPanelTemp> AmberEditCardPanelTempList = new List<EditCardPanelTemp>();
        List<EditCardPanelTemp> AmethystEditCardPanelTempList = new List<EditCardPanelTemp>();
        List<EditCardPanelTemp> EmeraldEditCardPanelTempList = new List<EditCardPanelTemp>();
        List<EditCardPanelTemp> RubyEditCardPanelTempList = new List<EditCardPanelTemp>();
        List<EditCardPanelTemp> SapphireEditCardPanelTempList = new List<EditCardPanelTemp>();
        List<EditCardPanelTemp> SteelEditCardPanelTempList = new List<EditCardPanelTemp>();

        for (int i = 0; i < EditCardPanelTempList.Count; i++)
        {
            if ((SwitchOwn && EditCardPanelTempList[i].GetCardCount() <= 0) || !m_SearchFilterClass.isSearchHit(EditCardPanelTempList[i].GetCardInfo()))
            {
                continue;
            }
            List<EnumController.Colors> color = EditCardPanelTempList[i].GetCardInfo().GetColor();
            switch (color[0])
            {
                case EnumController.Colors.Amber:
                    AmberEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                    break;
                case EnumController.Colors.Amethyst:
                    AmethystEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                    break;
                case EnumController.Colors.Emerald:
                    EmeraldEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                    break;
                case EnumController.Colors.Ruby:
                    RubyEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                    break;
                case EnumController.Colors.Sapphire:
                    SapphireEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                    break;
                case EnumController.Colors.Steel:
                    SteelEditCardPanelTempList.Add(EditCardPanelTempList[i]);
                    break;
                default:
                    break;
            }
        }

        for(int i = 0; i < AmberEditCardPanelTempList.Count; i++)
        {
            SortEditCardPanelTempList.Add(AmberEditCardPanelTempList[i]);
        }
        for (int i = 0; i < AmethystEditCardPanelTempList.Count; i++)
        {
            SortEditCardPanelTempList.Add(AmethystEditCardPanelTempList[i]);
        }
        for (int i = 0; i < EmeraldEditCardPanelTempList.Count; i++)
        {
            SortEditCardPanelTempList.Add(EmeraldEditCardPanelTempList[i]);
        }
        for (int i = 0; i < RubyEditCardPanelTempList.Count; i++)
        {
            SortEditCardPanelTempList.Add(RubyEditCardPanelTempList[i]);
        }
        for (int i = 0; i < SapphireEditCardPanelTempList.Count; i++)
        {
            SortEditCardPanelTempList.Add(SapphireEditCardPanelTempList[i]);
        }
        for (int i = 0; i < SteelEditCardPanelTempList.Count; i++)
        {
            SortEditCardPanelTempList.Add(SteelEditCardPanelTempList[i]);
        }

        m_InfiniteScroll.onResetValue();
    }

    public void Search(SearchFilterClass paramater)
    {
        m_SearchFilterClass = paramater;
        switch (m_SortStatus)
        {
            case SortStatus.Default:
                SortImage.sprite = DefaultSortIcon;
                onDefaultSort();
                break;
            case SortStatus.InkSort:
                SortImage.sprite = InkSortIcon;
                onInkCostSort();
                break;
            case SortStatus.ColorSort:
                SortImage.sprite = ColorSortIcon;
                onColorSort();
                break;
        }
    }
}

