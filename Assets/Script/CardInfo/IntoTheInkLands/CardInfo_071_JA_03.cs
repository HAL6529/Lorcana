using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_071_JA_03 : CardInfo
{
    public CardInfo_071_JA_03()
    {
        this.cardNo = "071_JA_03";
        this.inkCost = 5;
        this.availableInk = true;
        this.cardName1 = "ドン・カルナージ";
        this.cardName2 = "空の盗賊プリンス";
        this.power = 4;
        this.toughness = 4;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LuisHuerta;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Villain, EnumController.Class.Prince, EnumController.Class.Pirate };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility>() { EnumController.KeywordAvility.Evasive };
        this.expansion = EnumController.Expansion.IntoTheInkLands;
        this.title = EnumController.Title.TaleSpin;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Common;
    }
}
