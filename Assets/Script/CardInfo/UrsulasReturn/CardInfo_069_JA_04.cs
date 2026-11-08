using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_069_JA_04 : CardInfo
{
    public CardInfo_069_JA_04()
    {
        this.cardNo = "069_JA_04";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "クリキー";
        this.cardName2 = "幸運のコオロギ";
        this.power = 3;
        this.toughness = 4;
        this.lore = 3;
        this.illustrator = "Heidi NeunHoffer";
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
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.UrsulasReturn;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Rare;
    }
}
