using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_091_JA_12 : CardInfo
{
    public CardInfo_091_JA_12()
    {
        this.cardNo = "091_JA_12";
        this.inkCost = 7;
        this.availableInk = false;
        this.cardName1 = "バズ・ライトイヤー";
        this.cardName2 = "ジャングル・レンジャー";
        this.power = 7;
        this.toughness = 5;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.Koni;
        this.classList = new List<EnumController.Class>() { EnumController.Class.FloodBorn, EnumController.Class.Hero, EnumController.Class.Toy, EnumController.Class.Captain };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Emerald };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Shift5 };
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.ToyStory;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Legendary;
    }
}
