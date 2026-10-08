using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_061_JA_01 : CardInfo
{
    public CardInfo_061_JA_01()
    {
        this.cardNo = "061_JA_01";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "ゼウス";
        this.cardName2 = "稲妻の神";
        this.power = 0;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = "Koni";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つs
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Challenger4, EnumController.KeywordAvility.Rush };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
