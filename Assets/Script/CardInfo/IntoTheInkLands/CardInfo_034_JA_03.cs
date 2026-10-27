using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_034_JA_03 : CardInfo
{
    public CardInfo_034_JA_03()
    {
        this.cardNo = "034_JA_03";
        this.inkCost = 3;
        this.availableInk = false;
        this.cardName1 = "ティアナズ・パレス";
        this.cardName2 = "ジャズレストラン";
        this.power = 2;
        this.toughness = 8;
        this.lore = 1;
        this.illustrator = "Valerio Buonfantino";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class>();
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.ThePrincessAndTheFrog;
        this.type = EnumController.Type.Location;
        this.rare = EnumController.Rare.Uncommon;
    }
}
