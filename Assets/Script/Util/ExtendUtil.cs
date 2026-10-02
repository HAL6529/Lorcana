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
            case EnumController.Class.FloodBorn:
                return "フラッドボーン";
            case EnumController.Class.Hero:
                return "ヒーロー";
            case EnumController.Class.Inventor:
                return "発明家";
            case EnumController.Class.King:
                return "王様";
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
            case EnumController.Class.Queen:
                return "女王";
            case EnumController.Class.StoryBorn:
                return "ストーリーボーン";
            case EnumController.Class.Sorcerer:
                return "魔法使い";
            case EnumController.Class.Tigger:
                return "ティガー";
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
            case EnumController.Title.BeautyAndTheBeast:
                return "美女と野獣";
            case EnumController.Title.Cinderella:
                return "シンデレラ";
            case EnumController.Title.Fantasia:
                return "ファンタジア";
            case EnumController.Title.Frozen:
                return "アナと雪の女王";
            case EnumController.Title.Hercules:
                return "ヘラクレス";
            case EnumController.Title.Tangled:
                return "塔の上のラプンツェル";
            case EnumController.Title.TheEmperorsNewGroove:
                return "ラマになった王様";
            case EnumController.Title.TheLionKing:
                return "ライオンキング";
            case EnumController.Title.TheLittleMermaid:
                return "リトル・マーメイド";
            case EnumController.Title.ThePrincessAndTheFrog:
                return "プリンセスと魔法のキス";
            case EnumController.Title.TheSwordInTheStone:
                return "王様の剣";
            case EnumController.Title.TreasurePlanet:
                return "トレジャー・プラネット";
            case EnumController.Title.LiloAndStitch:
                return "リロ・アンド・スティッチ";
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
            case EnumController.Title.RobinHood:
                return "ロビン・フッド";
            case EnumController.Title.SleepingBeauty:
                return "眠れる森の美女";
            case EnumController.Title.SnowWhiteAndTheSevenDwarfs:
                return "白雪姫";
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
                return new CardInfo();
            case "206_JA_01":
                return new CardInfo();
            case "207_JA_01":
                return new CardInfo();
            case "208_JA_01":
                return new CardInfo();
            case "209_JA_01":
                return new CardInfo();
            case "210_JA_01":
                return new CardInfo();
            case "211_JA_01":
                return new CardInfo();
            case "212_JA_01":
                return new CardInfo();
            case "213_JA_01":
                return new CardInfo();
            case "214_JA_01":
                return new CardInfo();
            case "215_JA_01":
                return new CardInfo();
            default:
                return new CardInfo();
        }
    }
}
