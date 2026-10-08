using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_005_JA_01 : CardInfo
{
    public CardInfo_005_JA_01()
    {
        this.cardNo = "005_JA_01";
        this.inkCost = 8;
        this.availableInk = false;
        this.cardName1 = "ハデス";
        this.cardName2 = "オリンポスの王";
        this.power = 6;
        this.toughness = 7;
        this.lore = 1;
        this.illustrator = "Alex Accorsi";
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
        this.classList = new List<EnumController.Class> { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.King, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift6 };
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Hercules;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
