using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_195_JA_02 : CardInfo
{
    public CardInfo_195_JA_02()
    {
        this.cardNo = "195_JA_02";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "王子";
        this.cardName2 = "決してあきらめない";
        this.power = 1;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = "Eri Welli";
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
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Prince };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Bodyguard, EnumController.KeywordAvility.Resist1 };
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.SnowWhiteAndTheSevenDwarfs;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
