using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_015_JA_14 : CardInfo
{
    public CardInfo_015_JA_14()
    {
        this.cardNo = "015_JA_14";
        this.inkCost = 3;
        this.availableInk = true;
        this.cardName1 = "クロウハウザー";
        this.cardName2 = "交通安全係";
        this.power = 3;
        this.toughness = 5;
        this.lore = 1;
        this.illustrator = EnumController.Illustrator.JosepSole;
        this.classList = new List<EnumController.Class> { EnumController.Class.StoryBorn, EnumController.Class.Ally, EnumController.Class.Detective };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Amber };
        this.keywordAvility = new List<EnumController.KeywordAvility> { EnumController.KeywordAvility.Bodyguard };
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Zootopia;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Uncommon;
    }
}
