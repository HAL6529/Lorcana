using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_187_JA_01 : CardInfo
{
    public CardInfo_187_JA_01()
    {
        this.cardNo = "187_JA_01";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "エリック王子";
        this.cardName2 = "勇猛果敢";
        this.power = 1;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "Cristian Romero";
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
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Cinderella;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
