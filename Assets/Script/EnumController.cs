using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnumController
{
    public enum Class
    {
        Ally, //仲間
        Alien, //エイリアン
        Broom, //ほうき
        Captain, //キャプテン
        Detective, //名探偵
        Deity, //神格
        Dragon, //ドラゴン
        DreamBorn, //ドリームボーン
        Fairy, //妖精
        FloodBorn, //フラッドボーン
        Hero, //ヒーロー
        Inventor, //発明家
        King, //王様
        Mentor, //導き手
        Musketeer, //銃士
        Pirate, //海賊
        Prince,　//プリンス
        Princess, //プリンセス
        Queen, //女王
        StoryBorn, //ストーリーボーン
        Sorcerer, //魔法使い
        Tigger, //ティガー
        Villain, //ヴィラン
    }

    public enum Colors
    {
        Amethyst,
        Amber,
        Emerald,
        Sapphire,
        Steel,
        Ruby,
    }

    public enum Expansion
    {
        TheFirstChapter,
    }

    public enum KeywordAvility
    {
        Bodyguard,
        Challenger2, //果敢+2
        Challenger3, //果敢+3
        Challenger4, //果敢+4
        Evasive,　//回避
        Shift3,
        Shift4,
        Shift5,
        Shift6,
        Singer4,
        Singer5,
        Support,
        Reckless, //暴勇
        Rush, //突進
        Ward, //魔除

    }

    public enum OKBtnParamater
    {
        FailedFileCreate,
        NamelessError,
        NotFoundSecureDataPass,
        SuccessFileCreate,
    }

    public enum Title
    {
        Aladdin, //アラジン
        AliceInWonderland, //不思議の国のアリス
        BeautyAndTheBeast, //美女と野獣
        Cinderella, //シンデレラ
        Fantasia, //ファンタジア
        Frozen, //アナと雪の女王
        Hercules, //ヘラクレス
        Tangled, //塔の上のラプンツェル
        TheEmperorsNewGroove, //ラマになった王様
        TheLionKing, //ライオンキング
        TheLittleMermaid,  //リトル・マーメイド
        ThePrincessAndTheFrog, //プリンセスと魔法のキス
        TheSwordInTheStone, //王様の剣
        TreasurePlanet, //トレジャー・プラネット
        LiloAndStitch, //リロ・アンド・スティッチ
        MickeyMouse, //ミッキーマウス
        Moana, //モアナと伝説の海
        Mulan, //ムーラン
        OneHundredAndOneDalmatians, //101匹わんちゃん
        PeterPan, //ピーターパン
        RobinHood, //ロビン・フッド
        SleepingBeauty, //眠れる森の美女
        SnowWhiteAndTheSevenDwarfs, //白雪姫
    }

    public enum Type
    {
        Action,
        Character,
        Location,
        Item,
        Song,
    }

    public enum Rare
    {
        Common,
        Uncommon,
        Rare,
        SuperRare,
        Legendary,
        Enchanted,
        Iconic,
        Promo,
    }
}
