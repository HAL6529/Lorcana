using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_175_JA_01 : CardInfo
{
    public CardInfo_175_JA_01()
    {
        this.cardNo = "175_JA_01";
        this.inkCost = 5;
        this.availableInk = false;
        this.cardName1 = "フック船長";
        this.cardName2 = "あくどいことを考え";
        this.power = 2;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = "Elliot Bocxtaele";
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
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Pirate, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift3, EnumController.KeywordAvility.Challenger3 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.PeterPan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
