using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtendUtil
{
    public string ConvertToStringFromClass(EnumController.Class paramater)
    {
        switch (paramater)
        {
            case EnumController.Class.Ally:
                return "仲間";
            case EnumController.Class.Alien:
                return "エイリアン";
            case EnumController.Class.Broom:
                return "ほうき";
            case EnumController.Class.Captain:
                return "キャプテン";
            case EnumController.Class.Deity:
                return "神格";
            case EnumController.Class.Dragon:
                return "ドラゴン";
            case EnumController.Class.DreamBorn:
                return "ドリームボーン";
            case EnumController.Class.Fairy:
                return "妖精";
            case EnumController.Class.FloodBorn:
                return "フラッドボーン";
            case EnumController.Class.Hero:
                return "ヒーロー";
            case EnumController.Class.Hunny:
                return "ハニー";
            case EnumController.Class.Hyena:
                return "ハイエナ";
            case EnumController.Class.Inventor:
                return "発明家";
            case EnumController.Class.King:
                return "王様";
            case EnumController.Class.Knight:
                return "騎士";
            case EnumController.Class.Madrigal:
                return "マドリガル家";
            case EnumController.Class.Mentor:
                return "導き手";
            case EnumController.Class.Musketeer:
                return "銃士";
            case EnumController.Class.Pirate:
                return "海賊";
            case EnumController.Class.Prince:
                return "プリンス";
            case EnumController.Class.Princess:
                return "プリンセス";
            case EnumController.Class.Puppy:
                return "子犬";
            case EnumController.Class.Queen:
                return "女王";
            case EnumController.Class.Racer:
                return "レーサー";
            case EnumController.Class.SevenDwarfs:
                return "7人の小人";
            case EnumController.Class.StoryBorn:
                return "ストーリーボーン";
            case EnumController.Class.Sorcerer:
                return "魔法使い";
            case EnumController.Class.Tigger:
                return "ティガー";
            case EnumController.Class.Titan:
                return "タイタン";
            case EnumController.Class.Villain:
                return "ヴィランズ";
            default:
                return "";
        }
    } 

    public string ConvertToStringFromExpantion(EnumController.Expansion paramater)
    {
        switch (paramater)
        {
            case EnumController.Expansion.TheFirstChapter:
                return "The First Chapter -物語の始まり-";
            case EnumController.Expansion.RiseOfTheFloodBorn:
                return "Rise of the Floodborn -フラッドボーンの渾沌-";
            case EnumController.Expansion.IntoTheInkLands:
                return "Into the Inklands -インクランド探訪-";
            case EnumController.Expansion.UrsulasReturn:
                return "Ursula's Return -逆襲のアースラ-";
            case EnumController.Expansion.ShimmeringSkies:
                return "Shimmering Skies -星々の輝き-";
            default:
                return "";
        }
    }

    public string ConvertToStringFromTitle(EnumController.Title paramater)
    {
        switch (paramater)
        {
            case EnumController.Title.Aladdin:
                return "アラジン";
            case EnumController.Title.AliceInWonderland:
                return "不思議の国のアリス";
            case EnumController.Title.AtlantisTheLostEmpire:
                return "アトランティス 失われた帝国";
            case EnumController.Title.BeautyAndTheBeast:
                return "美女と野獣";
            case EnumController.Title.BrotherBear:
                return "ブラザー・ベア";
            case EnumController.Title.Cinderella:
                return "シンデレラ";
            case EnumController.Title.DuckTales:
                return "ダックテイル";
            case EnumController.Title.Encanto:
                return "ミラベルと魔法だらけの家";
            case EnumController.Title.Fantasia:
                return "ファンタジア";
            case EnumController.Title.Frozen:
                return "アナと雪の女王";
            case EnumController.Title.Hercules:
                return "ヘラクレス";
            case EnumController.Title.TaleSpin:
                return "テイルスピン";
            case EnumController.Title.Tangled:
                return "塔の上のラプンツェル";
            case EnumController.Title.TheEmperorsNewGroove:
                return "ラマになった王様";
            case EnumController.Title.TheGreatMouseDetective:
                return "オリビアちゃんの大冒険";
            case EnumController.Title.TheJungleBook:
                return "ジャングル・ブック";
            case EnumController.Title.TheLionKing:
                return "ライオンキング";
            case EnumController.Title.TheLittleMermaid:
                return "リトル・マーメイド";
            case EnumController.Title.ThePrincessAndTheFrog:
                return "プリンセスと魔法のキス";
            case EnumController.Title.TheRescuers:
                return "ビアンカの大冒険";
            case EnumController.Title.TheSwordInTheStone:
                return "王様の剣";
            case EnumController.Title.TheTaleOfAMouse:
                return "The Tale of a Mouse";
            case EnumController.Title.TreasurePlanet:
                return "トレジャー・プラネット";
            case EnumController.Title.LiloAndStitch:
                return "リロ・アンド・スティッチ";
            case EnumController.Title.Lorcana:
                return "ロルカナ";
            case EnumController.Title.MickeyMouse:
                return "ミッキーマウス";
            case EnumController.Title.Moana:
                return "モアナと伝説の海";
            case EnumController.Title.Mulan:
                return "ムーラン";
            case EnumController.Title.OneHundredAndOneDalmatians:
                return "101匹わんちゃん";
            case EnumController.Title.PeterPan:
                return "ピーターパン";
            case EnumController.Title.Pinocchio:
                return "ピノキオ";
            case EnumController.Title.RayaAndTheLastDragon:
                return "ラーヤと龍の王国";
            case EnumController.Title.RobinHood:
                return "ロビン・フッド";
            case EnumController.Title.SleepingBeauty:
                return "眠れる森の美女";
            case EnumController.Title.SnowWhiteAndTheSevenDwarfs:
                return "白雪姫";
            case EnumController.Title.WinnieThePooh:
                return "クマのプーさん";
            case EnumController.Title.WreckItRalph:
                return "シュガーラッシュ";
            case EnumController.Title.Zootopia:
                return "ズートピア";
            default:
                return "";
        }
    }

    public EnumController.Title ConvertToTitleFromString(string paramater)
    {
        switch (paramater)
        {
            case "アラジン":
                return EnumController.Title.Aladdin;
            case "不思議の国のアリス":
                return EnumController.Title.AliceInWonderland;
            case "美女と野獣":
                return EnumController.Title.BeautyAndTheBeast;
            case "シンデレラ":
                return EnumController.Title.Cinderella;
            case "ファンタジア":
                return EnumController.Title.Fantasia;
            case "アナと雪の女王":
                return EnumController.Title.Frozen;
            case "ヘラクレス":
                return EnumController.Title.Hercules;
            case "塔の上のラプンツェル":
                return EnumController.Title.Tangled;
            case  "ラマになった王様":
                return EnumController.Title.TheEmperorsNewGroove;
            case  "ライオンキング":
                return EnumController.Title.TheLionKing;
            case  "リトル・マーメイド":
                return EnumController.Title.TheLittleMermaid;
            case  "プリンセスと魔法のキス":
                return EnumController.Title.ThePrincessAndTheFrog;
            case  "王様の剣":
                return EnumController.Title.TheSwordInTheStone;
            case  "トレジャー・プラネット":
                return EnumController.Title.TreasurePlanet;
            case  "リロ・アンド・スティッチ":
                return EnumController.Title.LiloAndStitch;
            case  "ミッキーマウス":
                return EnumController.Title.MickeyMouse;
            case  "モアナと伝説の海":
                return EnumController.Title.Moana;
            case  "ムーラン":
                return EnumController.Title.Mulan;
            case  "101匹わんちゃん":
                return EnumController.Title.OneHundredAndOneDalmatians;
            case  "ピーターパン":
                return EnumController.Title.PeterPan;
            case  "ロビン・フッド":
                return EnumController.Title.RobinHood;
            case  "眠れる森の美女":
                return EnumController.Title.SleepingBeauty;
            case "白雪姫":
                return EnumController.Title.SnowWhiteAndTheSevenDwarfs;
            default:
                return EnumController.Title.None;
        }
    }

    public string GetSecureDataPath()
    {
        try
        {
            using (var unityPlayer = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
            using (var currentActivity = unityPlayer.GetStatic<AndroidJavaObject>("currentActivity"))
            using (var getFilesDir = currentActivity.Call<AndroidJavaObject>("getFilesDir"))
            {
                string secureDataPathForAndroid = getFilesDir.Call<string>("getCanonicalPath");
                return secureDataPathForAndroid;
            }
        }
        catch (Exception e)
        {
            Debug.Log(e);
        }

        // TODO: 本来は各プラットフォームに対応した処理が必要
        //return Application.persistentDataPath;
        return "";
    }

    public string ConvertToUTF8FromString(string s)
    {
        byte[] array = System.Text.Encoding.UTF8.GetBytes(s);

        string return_s = "";
        for (int i = 0; i < array.Length; i++)
        {
            return_s += array[i].ToString();
        }

        return return_s;
    }

    public CardInfo ConvertToCardInfoFromString(string paramater)
    {
        switch (paramater)
        {
            case "001_JA_01":
                return new CardInfo_001_JA_01();
            case "002_JA_01":
                return new CardInfo_002_JA_01();
            case "003_JA_01":
                return new CardInfo_003_JA_01();
            case "004_JA_01":
                return new CardInfo_004_JA_01();
            case "005_JA_01":
                return new CardInfo_005_JA_01();
            case "006_JA_01":
                return new CardInfo_006_JA_01();
            case "007_JA_01":
                return new CardInfo_007_JA_01();
            case "008_JA_01":
                return new CardInfo_008_JA_01();
            case "009_JA_01":
                return new CardInfo_009_JA_01();
            case "010_JA_01":
                return new CardInfo_010_JA_01();
            case "011_JA_01":
                return new CardInfo_011_JA_01();
            case "012_JA_01":
                return new CardInfo_012_JA_01();
            case "013_JA_01":
                return new CardInfo_013_JA_01();
            case "014_JA_01":
                return new CardInfo_014_JA_01();
            case "015_JA_01":
                return new CardInfo_015_JA_01();
            case "016_JA_01":
                return new CardInfo_016_JA_01();
            case "017_JA_01":
                return new CardInfo_017_JA_01();
            case "018_JA_01":
                return new CardInfo_018_JA_01();
            case "019_JA_01":
                return new CardInfo_019_JA_01();
            case "020_JA_01":
                return new CardInfo_020_JA_01();
            case "021_JA_01":
                return new CardInfo_021_JA_01();
            case "022_JA_01":
                return new CardInfo_022_JA_01();
            case "023_JA_01":
                return new CardInfo_023_JA_01();
            case "024_JA_01":
                return new CardInfo_024_JA_01();
            case "025_JA_01":
                return new CardInfo_025_JA_01();
            case "026_JA_01":
                return new CardInfo_026_JA_01();
            case "027_JA_01":
                return new CardInfo_027_JA_01();
            case "028_JA_01":
                return new CardInfo_028_JA_01();
            case "029_JA_01":
                return new CardInfo_029_JA_01();
            case "030_JA_01":
                return new CardInfo_030_JA_01();
            case "031_JA_01":
                return new CardInfo_031_JA_01();
            case "032_JA_01":
                return new CardInfo_032_JA_01();
            case "033_JA_01":
                return new CardInfo_033_JA_01();
            case "034_JA_01":
                return new CardInfo_034_JA_01();
            case "035_JA_01":
                return new CardInfo_035_JA_01();
            case "036_JA_01":
                return new CardInfo_036_JA_01();
            case "037_JA_01":
                return new CardInfo_037_JA_01();
            case "038_JA_01":
                return new CardInfo_038_JA_01();
            case "039_JA_01":
                return new CardInfo_039_JA_01();
            case "040_JA_01":
                return new CardInfo_040_JA_01();
            case "041_JA_01":
                return new CardInfo_041_JA_01();
            case "042_JA_01":
                return new CardInfo_042_JA_01();
            case "043_JA_01":
                return new CardInfo_043_JA_01();
            case "044_JA_01":
                return new CardInfo_044_JA_01();
            case "045_JA_01":
                return new CardInfo_045_JA_01();
            case "046_JA_01":
                return new CardInfo_046_JA_01();
            case "047_JA_01":
                return new CardInfo_047_JA_01();
            case "048_JA_01":
                return new CardInfo_048_JA_01();
            case "049_JA_01":
                return new CardInfo_049_JA_01();
            case "050_JA_01":
                return new CardInfo_050_JA_01();
            case "051_JA_01":
                return new CardInfo_051_JA_01();
            case "052_JA_01":
                return new CardInfo_052_JA_01();
            case "053_JA_01":
                return new CardInfo_053_JA_01();
            case "054_JA_01":
                return new CardInfo_054_JA_01();
            case "055_JA_01":
                return new CardInfo_055_JA_01();
            case "056_JA_01":
                return new CardInfo_056_JA_01();
            case "057_JA_01":
                return new CardInfo_057_JA_01();
            case "058_JA_01":
                return new CardInfo_058_JA_01();
            case "059_JA_01":
                return new CardInfo_059_JA_01();
            case "060_JA_01":
                return new CardInfo_060_JA_01();
            case "061_JA_01":
                return new CardInfo_061_JA_01();
            case "062_JA_01":
                return new CardInfo_062_JA_01();
            case "063_JA_01":
                return new CardInfo_063_JA_01();
            case "064_JA_01":
                return new CardInfo_064_JA_01();
            case "065_JA_01":
                return new CardInfo_065_JA_01();
            case "066_JA_01":
                return new CardInfo_066_JA_01();
            case "067_JA_01":
                return new CardInfo_067_JA_01();
            case "068_JA_01":
                return new CardInfo_068_JA_01();
            case "069_JA_01":
                return new CardInfo_069_JA_01();
            case "070_JA_01":
                return new CardInfo_070_JA_01();
            case "071_JA_01":
                return new CardInfo_071_JA_01();
            case "072_JA_01":
                return new CardInfo_072_JA_01();
            case "073_JA_01":
                return new CardInfo_073_JA_01();
            case "074_JA_01":
                return new CardInfo_074_JA_01();
            case "075_JA_01":
                return new CardInfo_075_JA_01();
            case "076_JA_01":
                return new CardInfo_076_JA_01();
            case "077_JA_01":
                return new CardInfo_077_JA_01();
            case "078_JA_01":
                return new CardInfo_078_JA_01();
            case "079_JA_01":
                return new CardInfo_079_JA_01();
            case "080_JA_01":
                return new CardInfo_080_JA_01();
            case "081_JA_01":
                return new CardInfo_081_JA_01();
            case "082_JA_01":
                return new CardInfo_082_JA_01();
            case "083_JA_01":
                return new CardInfo_083_JA_01();
            case "084_JA_01":
                return new CardInfo_084_JA_01();
            case "085_JA_01":
                return new CardInfo_085_JA_01();
            case "086_JA_01":
                return new CardInfo_086_JA_01();
            case "087_JA_01":
                return new CardInfo_087_JA_01();
            case "088_JA_01":
                return new CardInfo_088_JA_01();
            case "089_JA_01":
                return new CardInfo_089_JA_01();
            case "090_JA_01":
                return new CardInfo_090_JA_01();
            case "091_JA_01":
                return new CardInfo_091_JA_01();
            case "092_JA_01":
                return new CardInfo_092_JA_01();
            case "093_JA_01":
                return new CardInfo_093_JA_01();
            case "094_JA_01":
                return new CardInfo_094_JA_01();
            case "095_JA_01":
                return new CardInfo_095_JA_01();
            case "096_JA_01":
                return new CardInfo_096_JA_01();
            case "097_JA_01":
                return new CardInfo_097_JA_01();
            case "098_JA_01":
                return new CardInfo_098_JA_01();
            case "099_JA_01":
                return new CardInfo_099_JA_01();
            case "100_JA_01":
                return new CardInfo_100_JA_01();
            case "101_JA_01":
                return new CardInfo_101_JA_01();
            case "102_JA_01":
                return new CardInfo_102_JA_01();
            case "103_JA_01":
                return new CardInfo_103_JA_01();
            case "104_JA_01":
                return new CardInfo_104_JA_01();
            case "105_JA_01":
                return new CardInfo_105_JA_01();
            case "106_JA_01":
                return new CardInfo_106_JA_01();
            case "107_JA_01":
                return new CardInfo_107_JA_01();
            case "108_JA_01":
                return new CardInfo_108_JA_01();
            case "109_JA_01":
                return new CardInfo_109_JA_01();
            case "110_JA_01":
                return new CardInfo_110_JA_01();
            case "111_JA_01":
                return new CardInfo_111_JA_01();
            case "112_JA_01":
                return new CardInfo_112_JA_01();
            case "113_JA_01":
                return new CardInfo_113_JA_01();
            case "114_JA_01":
                return new CardInfo_114_JA_01();
            case "115_JA_01":
                return new CardInfo_115_JA_01();
            case "116_JA_01":
                return new CardInfo_116_JA_01();
            case "117_JA_01":
                return new CardInfo_117_JA_01();
            case "118_JA_01":
                return new CardInfo_118_JA_01();
            case "119_JA_01":
                return new CardInfo_119_JA_01();
            case "120_JA_01":
                return new CardInfo_120_JA_01();
            case "121_JA_01":
                return new CardInfo_121_JA_01();
            case "122_JA_01":
                return new CardInfo_122_JA_01();
            case "123_JA_01":
                return new CardInfo_123_JA_01();
            case "124_JA_01":
                return new CardInfo_124_JA_01();
            case "125_JA_01":
                return new CardInfo_125_JA_01();
            case "126_JA_01":
                return new CardInfo_126_JA_01();
            case "127_JA_01":
                return new CardInfo_127_JA_01();
            case "128_JA_01":
                return new CardInfo_128_JA_01();
            case "129_JA_01":
                return new CardInfo_129_JA_01();
            case "130_JA_01":
                return new CardInfo_130_JA_01();
            case "131_JA_01":
                return new CardInfo_131_JA_01();
            case "132_JA_01":
                return new CardInfo_132_JA_01();
            case "133_JA_01":
                return new CardInfo_133_JA_01();
            case "134_JA_01":
                return new CardInfo_134_JA_01();
            case "135_JA_01":
                return new CardInfo_135_JA_01();
            case "136_JA_01":
                return new CardInfo_136_JA_01();
            case "137_JA_01":
                return new CardInfo_137_JA_01();
            case "138_JA_01":
                return new CardInfo_138_JA_01();
            case "139_JA_01":
                return new CardInfo_139_JA_01();
            case "140_JA_01":
                return new CardInfo_140_JA_01();
            case "141_JA_01":
                return new CardInfo_141_JA_01();
            case "142_JA_01":
                return new CardInfo_142_JA_01();
            case "143_JA_01":
                return new CardInfo_143_JA_01();
            case "144_JA_01":
                return new CardInfo_144_JA_01();
            case "145_JA_01":
                return new CardInfo_145_JA_01();
            case "146_JA_01":
                return new CardInfo_146_JA_01();
            case "147_JA_01":
                return new CardInfo_147_JA_01();
            case "148_JA_01":
                return new CardInfo_148_JA_01();
            case "149_JA_01":
                return new CardInfo_149_JA_01();
            case "150_JA_01":
                return new CardInfo_150_JA_01();
            case "151_JA_01":
                return new CardInfo_151_JA_01();
            case "152_JA_01":
                return new CardInfo_152_JA_01();
            case "153_JA_01":
                return new CardInfo_153_JA_01();
            case "154_JA_01":
                return new CardInfo_154_JA_01();
            case "155_JA_01":
                return new CardInfo_155_JA_01();
            case "156_JA_01":
                return new CardInfo_156_JA_01();
            case "157_JA_01":
                return new CardInfo_157_JA_01();
            case "158_JA_01":
                return new CardInfo_158_JA_01();
            case "159_JA_01":
                return new CardInfo_159_JA_01();
            case "160_JA_01":
                return new CardInfo_160_JA_01();
            case "161_JA_01":
                return new CardInfo_161_JA_01();
            case "162_JA_01":
                return new CardInfo_162_JA_01();
            case "163_JA_01":
                return new CardInfo_163_JA_01();
            case "164_JA_01":
                return new CardInfo_164_JA_01();
            case "165_JA_01":
                return new CardInfo_165_JA_01();
            case "166_JA_01":
                return new CardInfo_166_JA_01();
            case "167_JA_01":
                return new CardInfo_167_JA_01();
            case "168_JA_01":
                return new CardInfo_168_JA_01();
            case "169_JA_01":
                return new CardInfo_169_JA_01();
            case "170_JA_01":
                return new CardInfo_170_JA_01();
            case "171_JA_01":
                return new CardInfo_171_JA_01();
            case "172_JA_01":
                return new CardInfo_172_JA_01();
            case "173_JA_01":
                return new CardInfo_173_JA_01();
            case "174_JA_01":
                return new CardInfo_174_JA_01();
            case "175_JA_01":
                return new CardInfo_175_JA_01();
            case "176_JA_01":
                return new CardInfo_176_JA_01();
            case "177_JA_01":
                return new CardInfo_177_JA_01();
            case "178_JA_01":
                return new CardInfo_178_JA_01();
            case "179_JA_01":
                return new CardInfo_179_JA_01();
            case "180_JA_01":
                return new CardInfo_180_JA_01();
            case "181_JA_01":
                return new CardInfo_181_JA_01();
            case "182_JA_01":
                return new CardInfo_182_JA_01();
            case "183_JA_01":
                return new CardInfo_183_JA_01();
            case "184_JA_01":
                return new CardInfo_184_JA_01();
            case "185_JA_01":
                return new CardInfo_185_JA_01();
            case "186_JA_01":
                return new CardInfo_186_JA_01();
            case "187_JA_01":
                return new CardInfo_187_JA_01();
            case "188_JA_01":
                return new CardInfo_188_JA_01();
            case "189_JA_01":
                return new CardInfo_189_JA_01();
            case "190_JA_01":
                return new CardInfo_190_JA_01();
            case "191_JA_01":
                return new CardInfo_191_JA_01();
            case "192_JA_01":
                return new CardInfo_192_JA_01();
            case "193_JA_01":
                return new CardInfo_193_JA_01();
            case "194_JA_01":
                return new CardInfo_194_JA_01();
            case "195_JA_01":
                return new CardInfo_195_JA_01();
            case "196_JA_01":
                return new CardInfo_196_JA_01();
            case "197_JA_01":
                return new CardInfo_197_JA_01();
            case "198_JA_01":
                return new CardInfo_198_JA_01();
            case "199_JA_01":
                return new CardInfo_199_JA_01();
            case "200_JA_01":
                return new CardInfo_200_JA_01();
            case "201_JA_01":
                return new CardInfo_201_JA_01();
            case "202_JA_01":
                return new CardInfo_202_JA_01();
            case "203_JA_01":
                return new CardInfo_203_JA_01();
            case "204_JA_01":
                return new CardInfo_204_JA_01();
            case "205_JA_01":
                return new CardInfo_205_JA_01();
            case "206_JA_01":
                return new CardInfo_206_JA_01();
            case "207_JA_01":
                return new CardInfo_207_JA_01();
            case "208_JA_01":
                return new CardInfo_208_JA_01();
            case "209_JA_01":
                return new CardInfo_209_JA_01();
            case "210_JA_01":
                return new CardInfo_210_JA_01();
            case "211_JA_01":
                return new CardInfo_211_JA_01();
            case "212_JA_01":
                return new CardInfo_212_JA_01();
            case "213_JA_01":
                return new CardInfo_213_JA_01();
            case "214_JA_01":
                return new CardInfo_214_JA_01();
            case "215_JA_01":
                return new CardInfo_215_JA_01();
            case "216_JA_01":
                return new CardInfo_216_JA_01();
        }

        switch (paramater)
        {
            case "001_JA_02":
                return new CardInfo_001_JA_02();
            case "002_JA_02":
                return new CardInfo_002_JA_02();
            case "003_JA_02":
                return new CardInfo_003_JA_02();
            case "004_JA_02":
                return new CardInfo_004_JA_02();
            case "005_JA_02":
                return new CardInfo_005_JA_02();
            case "006_JA_02":
                return new CardInfo_006_JA_02();
            case "007_JA_02":
                return new CardInfo_007_JA_02();
            case "008_JA_02":
                return new CardInfo_008_JA_02();
            case "009_JA_02":
                return new CardInfo_009_JA_02();
            case "010_JA_02":
                return new CardInfo_010_JA_02();
            case "011_JA_02":
                return new CardInfo_011_JA_02();
            case "012_JA_02":
                return new CardInfo_012_JA_02();
            case "013_JA_02":
                return new CardInfo_013_JA_02();
            case "014_JA_02":
                return new CardInfo_014_JA_02();
            case "015_JA_02":
                return new CardInfo_015_JA_02();
            case "016_JA_02":
                return new CardInfo_016_JA_02();
            case "017_JA_02":
                return new CardInfo_017_JA_02();
            case "018_JA_02":
                return new CardInfo_018_JA_02();
            case "019_JA_02":
                return new CardInfo_019_JA_02();
            case "020_JA_02":
                return new CardInfo_020_JA_02();
            case "021_JA_02":
                return new CardInfo_021_JA_02();
            case "022_JA_02":
                return new CardInfo_022_JA_02();
            case "023_JA_02":
                return new CardInfo_023_JA_02();
            case "024_JA_02":
                return new CardInfo_024_JA_02();
            case "025_JA_02":
                return new CardInfo_025_JA_02();
            case "026_JA_02":
                return new CardInfo_026_JA_02();
            case "027_JA_02":
                return new CardInfo_027_JA_02();
            case "028_JA_02":
                return new CardInfo_028_JA_02();
            case "029_JA_02":
                return new CardInfo_029_JA_02();
            case "030_JA_02":
                return new CardInfo_030_JA_02();
            case "031_JA_02":
                return new CardInfo_031_JA_02();
            case "032_JA_02":
                return new CardInfo_032_JA_02();
            case "033_JA_02":
                return new CardInfo_033_JA_02();
            case "034_JA_02":
                return new CardInfo_034_JA_02();
            case "035_JA_02":
                return new CardInfo_035_JA_02();
            case "036_JA_02":
                return new CardInfo_036_JA_02();
            case "037_JA_02":
                return new CardInfo_037_JA_02();
            case "038_JA_02":
                return new CardInfo_038_JA_02();
            case "039_JA_02":
                return new CardInfo_039_JA_02();
            case "040_JA_02":
                return new CardInfo_040_JA_02();
            case "041_JA_02":
                return new CardInfo_041_JA_02();
            case "042_JA_02":
                return new CardInfo_042_JA_02();
            case "043_JA_02":
                return new CardInfo_043_JA_02();
            case "044_JA_02":
                return new CardInfo_044_JA_02();
            case "045_JA_02":
                return new CardInfo_045_JA_02();
            case "046_JA_02":
                return new CardInfo_046_JA_02();
            case "047_JA_02":
                return new CardInfo_047_JA_02();
            case "048_JA_02":
                return new CardInfo_048_JA_02();
            case "049_JA_02":
                return new CardInfo_049_JA_02();
            case "050_JA_02":
                return new CardInfo_050_JA_02();
            case "051_JA_02":
                return new CardInfo_051_JA_02();
            case "052_JA_02":
                return new CardInfo_052_JA_02();
            case "053_JA_02":
                return new CardInfo_053_JA_02();
            case "054_JA_02":
                return new CardInfo_054_JA_02();
            case "055_JA_02":
                return new CardInfo_055_JA_02();
            case "056_JA_02":
                return new CardInfo_056_JA_02();
            case "057_JA_02":
                return new CardInfo_057_JA_02();
            case "058_JA_02":
                return new CardInfo_058_JA_02();
            case "059_JA_02":
                return new CardInfo_059_JA_02();
            case "060_JA_02":
                return new CardInfo_060_JA_02();
            case "061_JA_02":
                return new CardInfo_061_JA_02();
            case "062_JA_02":
                return new CardInfo_062_JA_02();
            case "063_JA_02":
                return new CardInfo_063_JA_02();
            case "064_JA_02":
                return new CardInfo_064_JA_02();
            case "065_JA_02":
                return new CardInfo_065_JA_02();
            case "066_JA_02":
                return new CardInfo_066_JA_02();
            case "067_JA_02":
                return new CardInfo_067_JA_02();
            case "068_JA_02":
                return new CardInfo_068_JA_02();
            case "069_JA_02":
                return new CardInfo_069_JA_02();
            case "070_JA_02":
                return new CardInfo_070_JA_02();
            case "071_JA_02":
                return new CardInfo_071_JA_02();
            case "072_JA_02":
                return new CardInfo_072_JA_02();
            case "073_JA_02":
                return new CardInfo_073_JA_02();
            case "074_JA_02":
                return new CardInfo_074_JA_02();
            case "075_JA_02":
                return new CardInfo_075_JA_02();
            case "076_JA_02":
                return new CardInfo_076_JA_02();
            case "077_JA_02":
                return new CardInfo_077_JA_02();
            case "078_JA_02":
                return new CardInfo_078_JA_02();
            case "079_JA_02":
                return new CardInfo_079_JA_02();
            case "080_JA_02":
                return new CardInfo_080_JA_02();
            case "081_JA_02":
                return new CardInfo_081_JA_02();
            case "082_JA_02":
                return new CardInfo_082_JA_02();
            case "083_JA_02":
                return new CardInfo_083_JA_02();
            case "084_JA_02":
                return new CardInfo_084_JA_02();
            case "085_JA_02":
                return new CardInfo_085_JA_02();
            case "086_JA_02":
                return new CardInfo_086_JA_02();
            case "087_JA_02":
                return new CardInfo_087_JA_02();
            case "088_JA_02":
                return new CardInfo_088_JA_02();
            case "089_JA_02":
                return new CardInfo_089_JA_02();
            case "090_JA_02":
                return new CardInfo_090_JA_02();
            case "091_JA_02":
                return new CardInfo_091_JA_02();
            case "092_JA_02":
                return new CardInfo_092_JA_02();
            case "093_JA_02":
                return new CardInfo_093_JA_02();
            case "094_JA_02":
                return new CardInfo_094_JA_02();
            case "095_JA_02":
                return new CardInfo_095_JA_02();
            case "096_JA_02":
                return new CardInfo_096_JA_02();
            case "097_JA_02":
                return new CardInfo_097_JA_02();
            case "098_JA_02":
                return new CardInfo_098_JA_02();
            case "099_JA_02":
                return new CardInfo_099_JA_02();
            case "100_JA_02":
                return new CardInfo_100_JA_02();
            case "101_JA_02":
                return new CardInfo_101_JA_02();
            case "102_JA_02":
                return new CardInfo_102_JA_02();
            case "103_JA_02":
                return new CardInfo_103_JA_02();
            case "104_JA_02":
                return new CardInfo_104_JA_02();
            case "105_JA_02":
                return new CardInfo_105_JA_02();
            case "106_JA_02":
                return new CardInfo_106_JA_02();
            case "107_JA_02":
                return new CardInfo_107_JA_02();
            case "108_JA_02":
                return new CardInfo_108_JA_02();
            case "109_JA_02":
                return new CardInfo_109_JA_02();
            case "110_JA_02":
                return new CardInfo_110_JA_02();
            case "111_JA_02":
                return new CardInfo_111_JA_02();
            case "112_JA_02":
                return new CardInfo_112_JA_02();
            case "113_JA_02":
                return new CardInfo_113_JA_02();
            case "114_JA_02":
                return new CardInfo_114_JA_02();
            case "115_JA_02":
                return new CardInfo_115_JA_02();
            case "116_JA_02":
                return new CardInfo_116_JA_02();
            case "117_JA_02":
                return new CardInfo_117_JA_02();
            case "118_JA_02":
                return new CardInfo_118_JA_02();
            case "119_JA_02":
                return new CardInfo_119_JA_02();
            case "120_JA_02":
                return new CardInfo_120_JA_02();
            case "121_JA_02":
                return new CardInfo_121_JA_02();
            case "122_JA_02":
                return new CardInfo_122_JA_02();
            case "123_JA_02":
                return new CardInfo_123_JA_02();
            case "124_JA_02":
                return new CardInfo_124_JA_02();
            case "125_JA_02":
                return new CardInfo_125_JA_02();
            case "126_JA_02":
                return new CardInfo_126_JA_02();
            case "127_JA_02":
                return new CardInfo_127_JA_02();
            case "128_JA_02":
                return new CardInfo_128_JA_02();
            case "129_JA_02":
                return new CardInfo_129_JA_02();
            case "130_JA_02":
                return new CardInfo_130_JA_02();
            case "131_JA_02":
                return new CardInfo_131_JA_02();
            case "132_JA_02":
                return new CardInfo_132_JA_02();
            case "133_JA_02":
                return new CardInfo_133_JA_02();
            case "134_JA_02":
                return new CardInfo_134_JA_02();
            case "135_JA_02":
                return new CardInfo_135_JA_02();
            case "136_JA_02":
                return new CardInfo_136_JA_02();
            case "137_JA_02":
                return new CardInfo_137_JA_02();
            case "138_JA_02":
                return new CardInfo_138_JA_02();
            case "139_JA_02":
                return new CardInfo_139_JA_02();
            case "140_JA_02":
                return new CardInfo_140_JA_02();
            case "141_JA_02":
                return new CardInfo_141_JA_02();
            case "142_JA_02":
                return new CardInfo_142_JA_02();
            case "143_JA_02":
                return new CardInfo_143_JA_02();
            case "144_JA_02":
                return new CardInfo_144_JA_02();
            case "145_JA_02":
                return new CardInfo_145_JA_02();
            case "146_JA_02":
                return new CardInfo_146_JA_02();
            case "147_JA_02":
                return new CardInfo_147_JA_02();
            case "148_JA_02":
                return new CardInfo_148_JA_02();
            case "149_JA_02":
                return new CardInfo_149_JA_02();
            case "150_JA_02":
                return new CardInfo_150_JA_02();
            case "151_JA_02":
                return new CardInfo_151_JA_02();
            case "152_JA_02":
                return new CardInfo_152_JA_02();
            case "153_JA_02":
                return new CardInfo_153_JA_02();
            case "154_JA_02":
                return new CardInfo_154_JA_02();
            case "155_JA_02":
                return new CardInfo_155_JA_02();
            case "156_JA_02":
                return new CardInfo_156_JA_02();
            case "157_JA_02":
                return new CardInfo_157_JA_02();
            case "158_JA_02":
                return new CardInfo_158_JA_02();
            case "159_JA_02":
                return new CardInfo_159_JA_02();
            case "160_JA_02":
                return new CardInfo_160_JA_02();
            case "161_JA_02":
                return new CardInfo_161_JA_02();
            case "162_JA_02":
                return new CardInfo_162_JA_02();
            case "163_JA_02":
                return new CardInfo_163_JA_02();
            case "164_JA_02":
                return new CardInfo_164_JA_02();
            case "165_JA_02":
                return new CardInfo_165_JA_02();
            case "166_JA_02":
                return new CardInfo_166_JA_02();
            case "167_JA_02":
                return new CardInfo_167_JA_02();
            case "168_JA_02":
                return new CardInfo_168_JA_02();
            case "169_JA_02":
                return new CardInfo_169_JA_02();
            case "170_JA_02":
                return new CardInfo_170_JA_02();
            case "171_JA_02":
                return new CardInfo_171_JA_02();
            case "172_JA_02":
                return new CardInfo_172_JA_02();
            case "173_JA_02":
                return new CardInfo_173_JA_02();
            case "174_JA_02":
                return new CardInfo_174_JA_02();
            case "175_JA_02":
                return new CardInfo_175_JA_02();
            case "176_JA_02":
                return new CardInfo_176_JA_02();
            case "177_JA_02":
                return new CardInfo_177_JA_02();
            case "178_JA_02":
                return new CardInfo_178_JA_02();
            case "179_JA_02":
                return new CardInfo_179_JA_02();
            case "180_JA_02":
                return new CardInfo_180_JA_02();
            case "181_JA_02":
                return new CardInfo_181_JA_02();
            case "182_JA_02":
                return new CardInfo_182_JA_02();
            case "183_JA_02":
                return new CardInfo_183_JA_02();
            case "184_JA_02":
                return new CardInfo_184_JA_02();
            case "185_JA_02":
                return new CardInfo_185_JA_02();
            case "186_JA_02":
                return new CardInfo_186_JA_02();
            case "187_JA_02":
                return new CardInfo_187_JA_02();
            case "188_JA_02":
                return new CardInfo_188_JA_02();
            case "189_JA_02":
                return new CardInfo_189_JA_02();
            case "190_JA_02":
                return new CardInfo_190_JA_02();
            case "191_JA_02":
                return new CardInfo_191_JA_02();
            case "192_JA_02":
                return new CardInfo_192_JA_02();
            case "193_JA_02":
                return new CardInfo_193_JA_02();
            case "194_JA_02":
                return new CardInfo_194_JA_02();
            case "195_JA_02":
                return new CardInfo_195_JA_02();
            case "196_JA_02":
                return new CardInfo_196_JA_02();
            case "197_JA_02":
                return new CardInfo_197_JA_02();
            case "198_JA_02":
                return new CardInfo_198_JA_02();
            case "199_JA_02":
                return new CardInfo_199_JA_02();
            case "200_JA_02":
                return new CardInfo_200_JA_02();
            case "201_JA_02":
                return new CardInfo_201_JA_02();
            case "202_JA_02":
                return new CardInfo_202_JA_02();
            case "203_JA_02":
                return new CardInfo_203_JA_02();
            case "204_JA_02":
                return new CardInfo_204_JA_02();
            case "205_JA_02":
                return new CardInfo_205_JA_02();
            case "206_JA_02":
                return new CardInfo_206_JA_02();
            case "207_JA_02":
                return new CardInfo_207_JA_02();
            case "208_JA_02":
                return new CardInfo_208_JA_02();
            case "209_JA_02":
                return new CardInfo_209_JA_02();
            case "210_JA_02":
                return new CardInfo_210_JA_02();
            case "211_JA_02":
                return new CardInfo_211_JA_02();
            case "212_JA_02":
                return new CardInfo_212_JA_02();
            case "213_JA_02":
                return new CardInfo_213_JA_02();
            case "214_JA_02":
                return new CardInfo_214_JA_02();
            case "215_JA_02":
                return new CardInfo_215_JA_02();
            case "216_JA_02":
                return new CardInfo_216_JA_02();
        }

        switch (paramater)
        {
            case "001_JA_03":
                return new CardInfo_001_JA_03();
            case "002_JA_03":
                return new CardInfo_002_JA_03();
            case "003_JA_03":
                return new CardInfo_003_JA_03();
            case "004_JA_03":
                return new CardInfo_004_JA_03();
            case "005_JA_03":
                return new CardInfo_005_JA_03();
            case "006_JA_03":
                return new CardInfo_006_JA_03();
            case "007_JA_03":
                return new CardInfo_007_JA_03();
            case "008_JA_03":
                return new CardInfo_008_JA_03();
            case "009_JA_03":
                return new CardInfo_009_JA_03();
            case "010_JA_03":
                return new CardInfo_010_JA_03();
            case "011_JA_03":
                return new CardInfo_011_JA_03();
            case "012_JA_03":
                return new CardInfo_012_JA_03();
            case "013_JA_03":
                return new CardInfo_013_JA_03();
            case "014_JA_03":
                return new CardInfo_014_JA_03();
            case "015_JA_03":
                return new CardInfo_015_JA_03();
            case "016_JA_03":
                return new CardInfo_016_JA_03();
            case "017_JA_03":
                return new CardInfo_017_JA_03();
            case "018_JA_03":
                return new CardInfo_018_JA_03();
            case "019_JA_03":
                return new CardInfo_019_JA_03();
            case "020_JA_03":
                return new CardInfo_030_JA_03();
            case "021_JA_03":
                return new CardInfo_031_JA_03();
            case "022_JA_03":
                return new CardInfo_032_JA_03();
            case "023_JA_03":
                return new CardInfo_033_JA_03();
            case "024_JA_03":
                return new CardInfo_034_JA_03();
            case "025_JA_03":
                return new CardInfo_035_JA_03();
            case "026_JA_03":
                return new CardInfo_036_JA_03();
            case "027_JA_03":
                return new CardInfo_037_JA_03();
            case "028_JA_03":
                return new CardInfo_038_JA_03();
            case "029_JA_03":
                return new CardInfo_039_JA_03();
            case "030_JA_03":
                return new CardInfo_030_JA_03();
            case "031_JA_03":
                return new CardInfo_031_JA_03();
            case "032_JA_03":
                return new CardInfo_032_JA_03();
            case "033_JA_03":
                return new CardInfo_033_JA_03();
            case "034_JA_03":
                return new CardInfo_034_JA_03();
            case "035_JA_03":
                return new CardInfo_035_JA_03();
            case "036_JA_03":
                return new CardInfo_036_JA_03();
            case "037_JA_03":
                return new CardInfo_037_JA_03();
            case "038_JA_03":
                return new CardInfo_038_JA_03();
            case "039_JA_03":
                return new CardInfo_039_JA_03();
            case "040_JA_03":
                return new CardInfo_040_JA_03();
            case "041_JA_03":
                return new CardInfo_041_JA_03();
            case "042_JA_03":
                return new CardInfo_042_JA_03();
            case "043_JA_03":
                return new CardInfo_043_JA_03();
            case "044_JA_03":
                return new CardInfo_044_JA_03();
            case "045_JA_03":
                return new CardInfo_045_JA_03();
            case "046_JA_03":
                return new CardInfo_046_JA_03();
            case "047_JA_03":
                return new CardInfo_047_JA_03();
            case "048_JA_03":
                return new CardInfo_048_JA_03();
            case "049_JA_03":
                return new CardInfo_049_JA_03();
            case "050_JA_03":
                return new CardInfo_050_JA_03();
            case "051_JA_03":
                return new CardInfo_051_JA_03();
            case "052_JA_03":
                return new CardInfo_052_JA_03();
            case "053_JA_03":
                return new CardInfo_053_JA_03();
            case "054_JA_03":
                return new CardInfo_054_JA_03();
            case "055_JA_03":
                return new CardInfo_055_JA_03();
            case "056_JA_03":
                return new CardInfo_056_JA_03();
            case "057_JA_03":
                return new CardInfo_057_JA_03();
            case "058_JA_03":
                return new CardInfo_058_JA_03();
            case "059_JA_03":
                return new CardInfo_059_JA_03();
            case "060_JA_03":
                return new CardInfo_060_JA_03();
            case "061_JA_03":
                return new CardInfo_061_JA_03();
            case "062_JA_03":
                return new CardInfo_062_JA_03();
            case "063_JA_03":
                return new CardInfo_063_JA_03();
            case "064_JA_03":
                return new CardInfo_064_JA_03();
            case "065_JA_03":
                return new CardInfo_065_JA_03();
            case "066_JA_03":
                return new CardInfo_066_JA_03();
            case "067_JA_03":
                return new CardInfo_067_JA_03();
            case "068_JA_03":
                return new CardInfo_068_JA_03();
            case "069_JA_03":
                return new CardInfo_069_JA_03();
            case "070_JA_03":
                return new CardInfo_070_JA_03();
            case "071_JA_03":
                return new CardInfo_071_JA_03();
            case "072_JA_03":
                return new CardInfo_072_JA_03();
            case "073_JA_03":
                return new CardInfo_073_JA_03();
            case "074_JA_03":
                return new CardInfo_074_JA_03();
            case "075_JA_03":
                return new CardInfo_075_JA_03();
            case "076_JA_03":
                return new CardInfo_076_JA_03();
            case "077_JA_03":
                return new CardInfo_077_JA_03();
            case "078_JA_03":
                return new CardInfo_078_JA_03();
            case "079_JA_03":
                return new CardInfo_079_JA_03();
            case "080_JA_03":
                return new CardInfo_080_JA_03();
            case "081_JA_03":
                return new CardInfo_081_JA_03();
            case "082_JA_03":
                return new CardInfo_082_JA_03();
            case "083_JA_03":
                return new CardInfo_083_JA_03();
            case "084_JA_03":
                return new CardInfo_084_JA_03();
            case "085_JA_03":
                return new CardInfo_085_JA_03();
            case "086_JA_03":
                return new CardInfo_086_JA_03();
            case "087_JA_03":
                return new CardInfo_087_JA_03();
            case "088_JA_03":
                return new CardInfo_088_JA_03();
            case "089_JA_03":
                return new CardInfo_089_JA_03();
            case "090_JA_03":
                return new CardInfo_090_JA_03();
            case "091_JA_03":
                return new CardInfo_091_JA_03();
            case "092_JA_03":
                return new CardInfo_092_JA_03();
            case "093_JA_03":
                return new CardInfo_093_JA_03();
            case "094_JA_03":
                return new CardInfo_094_JA_03();
            case "095_JA_03":
                return new CardInfo_095_JA_03();
            case "096_JA_03":
                return new CardInfo_096_JA_03();
            case "097_JA_03":
                return new CardInfo_097_JA_03();
            case "098_JA_03":
                return new CardInfo_098_JA_03();
            case "099_JA_03":
                return new CardInfo_099_JA_03();
            case "100_JA_03":
                return new CardInfo_100_JA_03();
            case "101_JA_03":
                return new CardInfo_101_JA_03();
            case "102_JA_03":
                return new CardInfo_102_JA_03();
            case "103_JA_03":
                return new CardInfo_103_JA_03();
            case "104_JA_03":
                return new CardInfo_104_JA_03();
            case "105_JA_03":
                return new CardInfo_105_JA_03();
            case "106_JA_03":
                return new CardInfo_106_JA_03();
            case "107_JA_03":
                return new CardInfo_107_JA_03();
            case "108_JA_03":
                return new CardInfo_108_JA_03();
            case "109_JA_03":
                return new CardInfo_109_JA_03();
            case "110_JA_03":
                return new CardInfo_110_JA_03();
            case "111_JA_03":
                return new CardInfo_111_JA_03();
            case "112_JA_03":
                return new CardInfo_112_JA_03();
            case "113_JA_03":
                return new CardInfo_113_JA_03();
            case "114_JA_03":
                return new CardInfo_114_JA_03();
            case "115_JA_03":
                return new CardInfo_115_JA_03();
            case "116_JA_03":
                return new CardInfo_116_JA_03();
            case "117_JA_03":
                return new CardInfo_117_JA_03();
            case "118_JA_03":
                return new CardInfo_118_JA_03();
            case "119_JA_03":
                return new CardInfo_119_JA_03();
            case "120_JA_03":
                return new CardInfo_120_JA_03();
            case "121_JA_03":
                return new CardInfo_121_JA_03();
            case "122_JA_03":
                return new CardInfo_122_JA_03();
            case "123_JA_03":
                return new CardInfo_123_JA_03();
            case "124_JA_03":
                return new CardInfo_124_JA_03();
            case "125_JA_03":
                return new CardInfo_125_JA_03();
            case "126_JA_03":
                return new CardInfo_126_JA_03();
            case "127_JA_03":
                return new CardInfo_127_JA_03();
            case "128_JA_03":
                return new CardInfo_128_JA_03();
            case "129_JA_03":
                return new CardInfo_129_JA_03();
            case "130_JA_03":
                return new CardInfo_130_JA_03();
            case "131_JA_03":
                return new CardInfo_131_JA_03();
            case "132_JA_03":
                return new CardInfo_132_JA_03();
            case "133_JA_03":
                return new CardInfo_133_JA_03();
            case "134_JA_03":
                return new CardInfo_134_JA_03();
            case "135_JA_03":
                return new CardInfo_135_JA_03();
            case "136_JA_03":
                return new CardInfo_136_JA_03();
            case "137_JA_03":
                return new CardInfo_137_JA_03();
            case "138_JA_03":
                return new CardInfo_138_JA_03();
            case "139_JA_03":
                return new CardInfo_139_JA_03();
            case "140_JA_03":
                return new CardInfo_140_JA_03();
            case "141_JA_03":
                return new CardInfo_141_JA_03();
            case "142_JA_03":
                return new CardInfo_142_JA_03();
            case "143_JA_03":
                return new CardInfo_143_JA_03();
            case "144_JA_03":
                return new CardInfo_144_JA_03();
            case "145_JA_03":
                return new CardInfo_145_JA_03();
            case "146_JA_03":
                return new CardInfo_146_JA_03();
            case "147_JA_03":
                return new CardInfo_147_JA_03();
            case "148_JA_03":
                return new CardInfo_148_JA_03();
            case "149_JA_03":
                return new CardInfo_149_JA_03();
            case "150_JA_03":
                return new CardInfo_150_JA_03();
            case "151_JA_03":
                return new CardInfo_151_JA_03();
            case "152_JA_03":
                return new CardInfo_152_JA_03();
            case "153_JA_03":
                return new CardInfo_153_JA_03();
            case "154_JA_03":
                return new CardInfo_154_JA_03();
            case "155_JA_03":
                return new CardInfo_155_JA_03();
            case "156_JA_03":
                return new CardInfo_156_JA_03();
            case "157_JA_03":
                return new CardInfo_157_JA_03();
            case "158_JA_03":
                return new CardInfo_158_JA_03();
            case "159_JA_03":
                return new CardInfo_159_JA_03();
            case "160_JA_03":
                return new CardInfo_160_JA_03();
            case "161_JA_03":
                return new CardInfo_161_JA_03();
            case "162_JA_03":
                return new CardInfo_162_JA_03();
            case "163_JA_03":
                return new CardInfo_163_JA_03();
            case "164_JA_03":
                return new CardInfo_164_JA_03();
            case "165_JA_03":
                return new CardInfo_165_JA_03();
            case "166_JA_03":
                return new CardInfo_166_JA_03();
            case "167_JA_03":
                return new CardInfo_167_JA_03();
            case "168_JA_03":
                return new CardInfo_168_JA_03();
            case "169_JA_03":
                return new CardInfo_169_JA_03();
            case "170_JA_03":
                return new CardInfo_170_JA_03();
            case "171_JA_03":
                return new CardInfo_171_JA_03();
            case "172_JA_03":
                return new CardInfo_172_JA_03();
            case "173_JA_03":
                return new CardInfo_173_JA_03();
            case "174_JA_03":
                return new CardInfo_174_JA_03();
            case "175_JA_03":
                return new CardInfo_175_JA_03();
            case "176_JA_03":
                return new CardInfo_176_JA_03();
            case "177_JA_03":
                return new CardInfo_177_JA_03();
            case "178_JA_03":
                return new CardInfo_178_JA_03();
            case "179_JA_03":
                return new CardInfo_179_JA_03();
            case "180_JA_03":
                return new CardInfo_180_JA_03();
            case "181_JA_03":
                return new CardInfo_181_JA_03();
            case "182_JA_03":
                return new CardInfo_182_JA_03();
            case "183_JA_03":
                return new CardInfo_183_JA_03();
            case "184_JA_03":
                return new CardInfo_184_JA_03();
            case "185_JA_03":
                return new CardInfo_185_JA_03();
            case "186_JA_03":
                return new CardInfo_186_JA_03();
            case "187_JA_03":
                return new CardInfo_187_JA_03();
            case "188_JA_03":
                return new CardInfo_188_JA_03();
            case "189_JA_03":
                return new CardInfo_189_JA_03();
            case "190_JA_03":
                return new CardInfo_190_JA_03();
            case "191_JA_03":
                return new CardInfo_191_JA_03();
            case "192_JA_03":
                return new CardInfo_192_JA_03();
            case "193_JA_03":
                return new CardInfo_193_JA_03();
            case "194_JA_03":
                return new CardInfo_194_JA_03();
            case "195_JA_03":
                return new CardInfo_195_JA_03();
            case "196_JA_03":
                return new CardInfo_196_JA_03();
            case "197_JA_03":
                return new CardInfo_197_JA_03();
            case "198_JA_03":
                return new CardInfo_198_JA_03();
            case "199_JA_03":
                return new CardInfo_199_JA_03();
            case "200_JA_03":
                return new CardInfo_200_JA_03();
            case "201_JA_03":
                return new CardInfo_201_JA_03();
            case "202_JA_03":
                return new CardInfo_202_JA_03();
            case "203_JA_03":
                return new CardInfo_203_JA_03();
            case "204_JA_03":
                return new CardInfo_204_JA_03();
            case "205_JA_03":
                return new CardInfo_205_JA_03();
            case "206_JA_03":
                return new CardInfo_206_JA_03();
            case "207_JA_03":
                return new CardInfo_207_JA_03();
            case "208_JA_03":
                return new CardInfo_208_JA_03();
            case "209_JA_03":
                return new CardInfo_209_JA_03();
            case "210_JA_03":
                return new CardInfo_210_JA_03();
            case "211_JA_03":
                return new CardInfo_211_JA_03();
            case "212_JA_03":
                return new CardInfo_212_JA_03();
            case "213_JA_03":
                return new CardInfo_213_JA_03();
            case "214_JA_03":
                return new CardInfo_214_JA_03();
            case "215_JA_03":
                return new CardInfo_215_JA_03();
            case "216_JA_03":
                return new CardInfo_216_JA_03();
            case "217_JA_03":
                return new CardInfo_217_JA_03();
            case "218_JA_03":
                return new CardInfo_218_JA_03();
            case "219_JA_03":
                return new CardInfo_219_JA_03();
            case "220_JA_03":
                return new CardInfo_220_JA_03();
            case "221_JA_03":
                return new CardInfo_221_JA_03();
            case "222_JA_03":
                return new CardInfo_222_JA_03();
        }

        switch (paramater)
        {
            case "001_JA_04":
                return new CardInfo_001_JA_04();
            case "002_JA_04":
                return new CardInfo_002_JA_04();
            case "003_JA_04":
                return new CardInfo_003_JA_04();
            case "004_JA_04":
                return new CardInfo_004_JA_04();
            case "005_JA_04":
                return new CardInfo_005_JA_04();
            case "006_JA_04":
                return new CardInfo_006_JA_04();
            case "007_JA_04":
                return new CardInfo_007_JA_04();
            case "008_JA_04":
                return new CardInfo_008_JA_04();
            case "009_JA_04":
                return new CardInfo_009_JA_04();
            case "010_JA_04":
                return new CardInfo_010_JA_04();
            case "011_JA_04":
                return new CardInfo_011_JA_04();
            case "012_JA_04":
                return new CardInfo_012_JA_04();
            case "013_JA_04":
                return new CardInfo_013_JA_04();
            case "014_JA_04":
                return new CardInfo_014_JA_04();
            case "015_JA_04":
                return new CardInfo_015_JA_04();
            case "016_JA_04":
                return new CardInfo_016_JA_04();
            case "017_JA_04":
                return new CardInfo_017_JA_04();
            case "018_JA_04":
                return new CardInfo_018_JA_04();
            case "019_JA_04":
                return new CardInfo_019_JA_04();
            case "020_JA_04":
                return new CardInfo_040_JA_04();
            case "021_JA_04":
                return new CardInfo_041_JA_04();
            case "022_JA_04":
                return new CardInfo_042_JA_04();
            case "023_JA_04":
                return new CardInfo_043_JA_04();
            case "024_JA_04":
                return new CardInfo_044_JA_04();
            case "025_JA_04":
                return new CardInfo_045_JA_04();
            case "026_JA_04":
                return new CardInfo_046_JA_04();
            case "027_JA_04":
                return new CardInfo_047_JA_04();
            case "028_JA_04":
                return new CardInfo_048_JA_04();
            case "029_JA_04":
                return new CardInfo_049_JA_04();
            case "030_JA_04":
                return new CardInfo_040_JA_04();
            case "031_JA_04":
                return new CardInfo_041_JA_04();
            case "032_JA_04":
                return new CardInfo_042_JA_04();
            case "033_JA_04":
                return new CardInfo_043_JA_04();
            case "034_JA_04":
                return new CardInfo_044_JA_04();
            case "035_JA_04":
                return new CardInfo_045_JA_04();
            case "036_JA_04":
                return new CardInfo_046_JA_04();
            case "037_JA_04":
                return new CardInfo_047_JA_04();
            case "038_JA_04":
                return new CardInfo_048_JA_04();
            case "039_JA_04":
                return new CardInfo_039_JA_04();
            case "040_JA_04":
                return new CardInfo_040_JA_04();
            case "041_JA_04":
                return new CardInfo_041_JA_04();
            case "042_JA_04":
                return new CardInfo_042_JA_04();
            case "043_JA_04":
                return new CardInfo_043_JA_04();
            case "044_JA_04":
                return new CardInfo_044_JA_04();
            case "045_JA_04":
                return new CardInfo_045_JA_04();
            case "046_JA_04":
                return new CardInfo_046_JA_04();
            case "047_JA_04":
                return new CardInfo_047_JA_04();
            case "048_JA_04":
                return new CardInfo_048_JA_04();
            case "049_JA_04":
                return new CardInfo_049_JA_04();
            case "050_JA_04":
                return new CardInfo_050_JA_04();
            case "051_JA_04":
                return new CardInfo_051_JA_04();
            case "052_JA_04":
                return new CardInfo_052_JA_04();
            case "053_JA_04":
                return new CardInfo_053_JA_04();
            case "054_JA_04":
                return new CardInfo_054_JA_04();
            case "055_JA_04":
                return new CardInfo_055_JA_04();
            case "056_JA_04":
                return new CardInfo_056_JA_04();
            case "057_JA_04":
                return new CardInfo_057_JA_04();
            case "058_JA_04":
                return new CardInfo_058_JA_04();
            case "059_JA_04":
                return new CardInfo_059_JA_04();
            case "060_JA_04":
                return new CardInfo_060_JA_04();
            case "061_JA_04":
                return new CardInfo_061_JA_04();
            case "062_JA_04":
                return new CardInfo_062_JA_04();
            case "063_JA_04":
                return new CardInfo_063_JA_04();
            case "064_JA_04":
                return new CardInfo_064_JA_04();
            case "065_JA_04":
                return new CardInfo_065_JA_04();
            case "066_JA_04":
                return new CardInfo_066_JA_04();
            case "067_JA_04":
                return new CardInfo_067_JA_04();
            case "068_JA_04":
                return new CardInfo_068_JA_04();
            case "069_JA_04":
                return new CardInfo_069_JA_04();
            case "070_JA_04":
                return new CardInfo_070_JA_04();
            case "071_JA_04":
                return new CardInfo_071_JA_04();
            case "072_JA_04":
                return new CardInfo_072_JA_04();
            case "073_JA_04":
                return new CardInfo_073_JA_04();
            case "074_JA_04":
                return new CardInfo_074_JA_04();
            case "075_JA_04":
                return new CardInfo_075_JA_04();
            case "076_JA_04":
                return new CardInfo_076_JA_04();
            case "077_JA_04":
                return new CardInfo_077_JA_04();
            case "078_JA_04":
                return new CardInfo_078_JA_04();
            case "079_JA_04":
                return new CardInfo_079_JA_04();
            case "080_JA_04":
                return new CardInfo_080_JA_04();
            case "081_JA_04":
                return new CardInfo_081_JA_04();
            case "082_JA_04":
                return new CardInfo_082_JA_04();
            case "083_JA_04":
                return new CardInfo_083_JA_04();
            case "084_JA_04":
                return new CardInfo_084_JA_04();
            case "085_JA_04":
                return new CardInfo_085_JA_04();
            case "086_JA_04":
                return new CardInfo_086_JA_04();
            case "087_JA_04":
                return new CardInfo_087_JA_04();
            case "088_JA_04":
                return new CardInfo_088_JA_04();
            case "089_JA_04":
                return new CardInfo_089_JA_04();
            case "090_JA_04":
                return new CardInfo_090_JA_04();
            case "091_JA_04":
                return new CardInfo_091_JA_04();
            case "092_JA_04":
                return new CardInfo_092_JA_04();
            case "093_JA_04":
                return new CardInfo_093_JA_04();
            case "094_JA_04":
                return new CardInfo_094_JA_04();
            case "095_JA_04":
                return new CardInfo_095_JA_04();
            case "096_JA_04":
                return new CardInfo_096_JA_04();
            case "097_JA_04":
                return new CardInfo_097_JA_04();
            case "098_JA_04":
                return new CardInfo_098_JA_04();
            case "099_JA_04":
                return new CardInfo_099_JA_04();
            case "100_JA_04":
                return new CardInfo_100_JA_04();
            case "101_JA_04":
                return new CardInfo_101_JA_04();
            case "102_JA_04":
                return new CardInfo_102_JA_04();
            case "103_JA_04":
                return new CardInfo_103_JA_04();
            case "104_JA_04":
                return new CardInfo_104_JA_04();
            case "105_JA_04":
                return new CardInfo_105_JA_04();
            case "106_JA_04":
                return new CardInfo_106_JA_04();
            case "107_JA_04":
                return new CardInfo_107_JA_04();
            case "108_JA_04":
                return new CardInfo_108_JA_04();
            case "109_JA_04":
                return new CardInfo_109_JA_04();
            case "110_JA_04":
                return new CardInfo_110_JA_04();
            case "111_JA_04":
                return new CardInfo_111_JA_04();
            case "112_JA_04":
                return new CardInfo_112_JA_04();
            case "113_JA_04":
                return new CardInfo_113_JA_04();
            case "114_JA_04":
                return new CardInfo_114_JA_04();
            case "115_JA_04":
                return new CardInfo_115_JA_04();
            case "116_JA_04":
                return new CardInfo_116_JA_04();
            case "117_JA_04":
                return new CardInfo_117_JA_04();
            case "118_JA_04":
                return new CardInfo_118_JA_04();
            case "119_JA_04":
                return new CardInfo_119_JA_04();
            case "120_JA_04":
                return new CardInfo_120_JA_04();
            case "121_JA_04":
                return new CardInfo_121_JA_04();
            case "122_JA_04":
                return new CardInfo_122_JA_04();
            case "123_JA_04":
                return new CardInfo_123_JA_04();
            case "124_JA_04":
                return new CardInfo_124_JA_04();
            case "125_JA_04":
                return new CardInfo_125_JA_04();
            case "126_JA_04":
                return new CardInfo_126_JA_04();
            case "127_JA_04":
                return new CardInfo_127_JA_04();
            case "128_JA_04":
                return new CardInfo_128_JA_04();
            case "129_JA_04":
                return new CardInfo_129_JA_04();
            case "130_JA_04":
                return new CardInfo_130_JA_04();
            case "131_JA_04":
                return new CardInfo_131_JA_04();
            case "132_JA_04":
                return new CardInfo_132_JA_04();
            case "133_JA_04":
                return new CardInfo_133_JA_04();
            case "134_JA_04":
                return new CardInfo_134_JA_04();
            case "135_JA_04":
                return new CardInfo_135_JA_04();
            case "136_JA_04":
                return new CardInfo_136_JA_04();
            case "137_JA_04":
                return new CardInfo_137_JA_04();
            case "138_JA_04":
                return new CardInfo_138_JA_04();
            case "139_JA_04":
                return new CardInfo_139_JA_04();
            case "140_JA_04":
                return new CardInfo_140_JA_04();
            case "141_JA_04":
                return new CardInfo_141_JA_04();
            case "142_JA_04":
                return new CardInfo_142_JA_04();
            case "143_JA_04":
                return new CardInfo_143_JA_04();
            case "144_JA_04":
                return new CardInfo_144_JA_04();
            case "145_JA_04":
                return new CardInfo_145_JA_04();
            case "146_JA_04":
                return new CardInfo_146_JA_04();
            case "147_JA_04":
                return new CardInfo_147_JA_04();
            case "148_JA_04":
                return new CardInfo_148_JA_04();
            case "149_JA_04":
                return new CardInfo_149_JA_04();
            case "150_JA_04":
                return new CardInfo_150_JA_04();
            case "151_JA_04":
                return new CardInfo_151_JA_04();
            case "152_JA_04":
                return new CardInfo_152_JA_04();
            case "153_JA_04":
                return new CardInfo_153_JA_04();
            case "154_JA_04":
                return new CardInfo_154_JA_04();
            case "155_JA_04":
                return new CardInfo_155_JA_04();
            case "156_JA_04":
                return new CardInfo_156_JA_04();
            case "157_JA_04":
                return new CardInfo_157_JA_04();
            case "158_JA_04":
                return new CardInfo_158_JA_04();
            case "159_JA_04":
                return new CardInfo_159_JA_04();
            case "160_JA_04":
                return new CardInfo_160_JA_04();
            case "161_JA_04":
                return new CardInfo_161_JA_04();
            case "162_JA_04":
                return new CardInfo_162_JA_04();
            case "163_JA_04":
                return new CardInfo_163_JA_04();
            case "164_JA_04":
                return new CardInfo_164_JA_04();
            case "165_JA_04":
                return new CardInfo_165_JA_04();
            case "166_JA_04":
                return new CardInfo_166_JA_04();
            case "167_JA_04":
                return new CardInfo_167_JA_04();
            case "168_JA_04":
                return new CardInfo_168_JA_04();
            case "169_JA_04":
                return new CardInfo_169_JA_04();
            case "170_JA_04":
                return new CardInfo_170_JA_04();
            case "171_JA_04":
                return new CardInfo_171_JA_04();
            case "172_JA_04":
                return new CardInfo_172_JA_04();
            case "173_JA_04":
                return new CardInfo_173_JA_04();
            case "174_JA_04":
                return new CardInfo_174_JA_04();
            case "175_JA_04":
                return new CardInfo_175_JA_04();
            case "176_JA_04":
                return new CardInfo_176_JA_04();
            case "177_JA_04":
                return new CardInfo_177_JA_04();
            case "178_JA_04":
                return new CardInfo_178_JA_04();
            case "179_JA_04":
                return new CardInfo_179_JA_04();
            case "180_JA_04":
                return new CardInfo_180_JA_04();
            case "181_JA_04":
                return new CardInfo_181_JA_04();
            case "182_JA_04":
                return new CardInfo_182_JA_04();
            case "183_JA_04":
                return new CardInfo_183_JA_04();
            case "184_JA_04":
                return new CardInfo_184_JA_04();
            case "185_JA_04":
                return new CardInfo_185_JA_04();
            case "186_JA_04":
                return new CardInfo_186_JA_04();
            case "187_JA_04":
                return new CardInfo_187_JA_04();
            case "188_JA_04":
                return new CardInfo_188_JA_04();
            case "189_JA_04":
                return new CardInfo_189_JA_04();
            case "190_JA_04":
                return new CardInfo_190_JA_04();
            case "191_JA_04":
                return new CardInfo_191_JA_04();
            case "192_JA_04":
                return new CardInfo_192_JA_04();
            case "193_JA_04":
                return new CardInfo_193_JA_04();
            case "194_JA_04":
                return new CardInfo_194_JA_04();
            case "195_JA_04":
                return new CardInfo_195_JA_04();
            case "196_JA_04":
                return new CardInfo_196_JA_04();
            case "197_JA_04":
                return new CardInfo_197_JA_04();
            case "198_JA_04":
                return new CardInfo_198_JA_04();
            case "199_JA_04":
                return new CardInfo_199_JA_04();
            case "200_JA_04":
                return new CardInfo_200_JA_04();
            case "201_JA_04":
                return new CardInfo_201_JA_04();
            case "202_JA_04":
                return new CardInfo_202_JA_04();
            case "203_JA_04":
                return new CardInfo_203_JA_04();
            case "204_JA_04":
                return new CardInfo_204_JA_04();
            case "205_JA_04":
                return new CardInfo_205_JA_04();
            case "206_JA_04":
                return new CardInfo_206_JA_04();
            case "207_JA_04":
                return new CardInfo_207_JA_04();
            case "208_JA_04":
                return new CardInfo_208_JA_04();
            case "209_JA_04":
                return new CardInfo_209_JA_04();
            case "210_JA_04":
                return new CardInfo_210_JA_04();
            case "211_JA_04":
                return new CardInfo_211_JA_04();
            case "212_JA_04":
                return new CardInfo_212_JA_04();
            case "213_JA_04":
                return new CardInfo_213_JA_04();
            case "214_JA_04":
                return new CardInfo_214_JA_04();
            case "215_JA_04":
                return new CardInfo_215_JA_04();
            case "216_JA_04":
                return new CardInfo_216_JA_04();
            case "217_JA_04":
                return new CardInfo_217_JA_04();
            case "218_JA_04":
                return new CardInfo_218_JA_04();
            case "219_JA_04":
                return new CardInfo_219_JA_04();
            case "220_JA_04":
                return new CardInfo_220_JA_04();
            case "221_JA_04":
                return new CardInfo_221_JA_04();
            case "222_JA_04":
                return new CardInfo_222_JA_04();
            default:
                return new CardInfo();
        }
    }
}
