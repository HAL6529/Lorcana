using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_190_JA_03 : CardInfo
{
    public CardInfo_190_JA_03()
    {
        this.cardNo = "190_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ロビン・フッド";
        this.cardName2 = "シャーウッドの英雄";
        this.power = 3;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = "Rudy Hill";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = true; //PIG効果を持つ
        this.isChallenge = true; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = true; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3 };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.RobinHood;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
