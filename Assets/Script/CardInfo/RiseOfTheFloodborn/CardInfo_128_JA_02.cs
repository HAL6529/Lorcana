using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_128_JA_02 : CardInfo
{
    public CardInfo_128_JA_02()
    {
        this.cardNo = "128_JA_02";
        this.inkCost = 4;
        this.availableInk = false;
        this.cardName1 = "トゥクトゥク";
        this.cardName2 = "ぶちかます大玉";
        this.power = 4;
        this.toughness = 5;
        this.lore = 0;
        this.illustrator = "Brian Weisz";
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
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Reckless };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.RayaAndTheLastDragon;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
