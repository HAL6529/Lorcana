using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_077_JA_03 : CardInfo
{
    public CardInfo_077_JA_03()
    {
        this.cardNo = "077_JA_03";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "キット・クラウドキッカー";
        this.cardName2 = "タフガイ";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = "Jake Parker";
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
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
