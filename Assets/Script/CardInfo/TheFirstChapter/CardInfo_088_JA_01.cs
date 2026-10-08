using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_088_JA_01 : CardInfo
{
    public CardInfo_088_JA_01()
    {
        this.cardNo = "088_JA_01";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "ミッキーマウス";
        this.cardName2 = "腕利きの盗賊";
        this.power = 6;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Alex Accorsi/ Kendall Hale";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = true; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.MickeyMouse;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
