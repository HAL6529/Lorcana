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
}
