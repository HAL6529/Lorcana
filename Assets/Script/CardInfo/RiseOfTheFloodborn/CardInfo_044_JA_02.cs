using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_044_JA_02 : CardInfo
{
    public CardInfo_044_JA_02()
    {
        this.cardNo = "044_JA_02";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "ジミニー・クリケット";
        this.cardName2 = "ピノキオの良心";
        this.power = 1;
        this.toughness = 2;
        this.lore = 1;
        this.illustrator = "Isaiah Mesq";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = true; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.Pinocchio;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
