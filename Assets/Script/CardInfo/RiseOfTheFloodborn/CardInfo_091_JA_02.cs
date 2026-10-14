using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_091_JA_02 : CardInfo
{
    public CardInfo_091_JA_02()
    {
        this.cardNo = "091_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ラティガン";
        this.cardName2 = "犯罪王";
        this.power = 4;
        this.toughness = 1;
        this.lore = 2;
        this.illustrator = "Michaela Martin";
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
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheGreatMouseDetective;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
