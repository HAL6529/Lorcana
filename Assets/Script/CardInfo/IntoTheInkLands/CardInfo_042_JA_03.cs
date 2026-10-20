using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_042_JA_03 : CardInfo
{
    public CardInfo_042_JA_03()
    {
        this.cardNo = "042_JA_03";
        this.inkCost = 7;
        this.availableInk = true;
        this.cardName1 = "ジャファー";
        this.cardName2 = "ド派手な幻術使い";
        this.power = 4;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = "Nicola Saviori";
        this.isHandDestraction = false; //ハンデス効果を持つ
        this.isCIP = false; //CIP効果を持つ
        this.isPIG = false; //PIG効果を持つ
        this.isChallenge = false; //「チャレンジ中に退場させたとき」に関連する効果を持つ
        this.isAction = false; //アクションに関連する効果を持つ
        this.isGetLore = true; //「ロアを得る」効果を持つ
        this.isLostLore = false; //「相手はロアを失う」効果を持つ
        this.isAddInk = false; //インクを増やす効果を持つ
        this.isItem = false; //アイテムに関連する効果を持つ
        this.isLocation = false; //ロケーションに関連する効果を持つ
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Villain, EnumController.Class.Sorcerer };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amethyst };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Shift5, EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.Aladdin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
