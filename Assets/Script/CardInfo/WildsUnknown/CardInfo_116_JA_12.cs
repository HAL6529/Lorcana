using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_116_JA_12 : CardInfo
{
    public CardInfo_116_JA_12()
    {
        this.cardNo = "116_JA_12";
        this.inkCost = 6;
        this.availableInk = true;
        this.cardName1 = "コッパー";
        this.cardName2 = "立派な猟犬";
        this.power = 7;
        this.toughness = 6;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.SauloNate;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Hero };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.WildsUnknown;
        this.title = EnumController.Title.TheFoxAndTheHound;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
