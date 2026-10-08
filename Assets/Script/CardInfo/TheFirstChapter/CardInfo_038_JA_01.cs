using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_038_JA_01 : CardInfo
{
    public CardInfo_038_JA_01()
    {
        this.cardNo = "038_JA_01";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ファシリエ";
        this.cardName2 = "イカサマ師";
        this.power = 0;
        this.toughness = 4;
        this.lore = 1;
        this.illustrator = "Grace Tran";
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
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Challenger2 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
