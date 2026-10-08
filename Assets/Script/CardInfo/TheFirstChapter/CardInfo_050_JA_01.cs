using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_050_JA_01 : CardInfo
{
    public CardInfo_050_JA_01()
    {
        this.cardNo = "050_JA_01";
        this.inkCost = 6;
        this.availableInk = false;
        this.cardName1 = "マシュマロウ";
        this.cardName2 = "しぶとい守護者";
        this.power = 5;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = "Kendall Hale / Anh Dang";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = true; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = false; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.TheFirstChapter;
        this.title = EnumController.Title.Frozen;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.SuperRare;
    }
}
