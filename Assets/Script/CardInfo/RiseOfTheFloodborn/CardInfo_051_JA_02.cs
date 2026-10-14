using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_051_JA_02 : CardInfo
{
    public CardInfo_051_JA_02()
    {
        this.cardNo = "051_JA_02";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "マーリン";
        this.cardName2 = "ヤギ";
        this.power = 4;
        this.toughness = 3;
        this.lore = 1;
        this.illustrator = "S.Shaw / L.Giammichele";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = true; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = true; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Mentor, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.RiseOfTheFloodBorn;
        this.title = EnumController.Title.TheSwordInTheStone;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
