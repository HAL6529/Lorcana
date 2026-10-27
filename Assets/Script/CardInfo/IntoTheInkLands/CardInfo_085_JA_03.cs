using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_085_JA_03 : CardInfo
{
    public CardInfo_085_JA_03()
    {
        this.cardNo = "085_JA_03";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "シェンジ";
        this.cardName2 = "ハイエナの頭目";
        this.power = 0;
        this.toughness = 6;
        this.lore = 1;
        this.illustrator = "Jochem van Gool";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = true; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Hyena };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TheLionKing;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
