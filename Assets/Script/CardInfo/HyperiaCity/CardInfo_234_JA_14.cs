using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardInfo_234_JA_14 : CardInfo
{
    public CardInfo_234_JA_14()
    {
        this.cardNo = "234_JA_14";
        this.inkCost = 4;
        this.availableInk = true;
        this.cardName1 = "ムーラン";
        this.cardName2 = "武術の達人";
        this.power = 2;
        this.toughness = 3;
        this.lore = 2;
        this.illustrator = EnumController.Illustrator.LadyShalirinAndEriWelli;
        this.classList = new List<EnumController.Class>() { EnumController.Class.DreamBorn, EnumController.Class.Hero, EnumController.Class.Princess };
        this.color = new List<EnumController.Colors> { EnumController.Colors.Ruby };
        this.keywordAvility = new List<EnumController.KeywordAvility>();
        this.expansion = EnumController.Expansion.HyperiaCity;
        this.title = EnumController.Title.Mulan;
        this.type = EnumController.Type.Character;
        this.rare = EnumController.Rare.Enchanted;
    }
}
