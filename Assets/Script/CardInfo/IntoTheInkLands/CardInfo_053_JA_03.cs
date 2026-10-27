using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_053_JA_03 : CardInfo
{
    public CardInfo_053_JA_03()
    {
        this.cardNo = "053_JA_03";
        this.inkCost = 2;
        this.availableInk = true;
        this.cardName1 = "プア";
        this.cardName2 = "まんまるおなかの相棒";
        this.power = 2;
        this.toughness = 2;
        this.lore = 2;
        this.illustrator = "Denny Minonne";
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
        this.classList = new List<EnumController.Class>() { EnumController.Class.StoryBorn, EnumController.Class.Ally};
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Moana;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
