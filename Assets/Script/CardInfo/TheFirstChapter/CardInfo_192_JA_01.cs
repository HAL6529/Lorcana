using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_192_JA_01 : CardInfo
{
    public CardInfo_192_JA_01()
    {
        this.cardNo = "192_JA_01";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "テ・カァ";
        this.cardName2 = "心なきもの";
        this.power = 5;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = "Andrew Trabbold";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = true; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = true; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class> { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Deity };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Steel };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
