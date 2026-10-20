using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_125_JA_03 : CardInfo
{
    public CardInfo_125_JA_03()
    {
        this.cardNo = "125_JA_03";
        this.inkCost = 2;
        this.availableInk = false;
        this.cardName1 = "スティッチ";
        this.cardName2 = "小型ロケット";
        this.power = 3;
        this.toughness = 1;
        this.lore = 1;
        this.illustrator = "Nicola Saviori";
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
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.LiloAndStitch;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
